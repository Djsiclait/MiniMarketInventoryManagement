using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Custom Libraries
using InventoryManagementBusinessLayer.ReportInformation;
using InventoryManagementBusinessLayer.UserInformation;
using InventoryManagementEntityLayer.Activity;
using InventoryManagementEntityLayer.UserProfile;

namespace GeneralStoreInventoryManagementSystem
{
    public partial class UserSessionActivitiesReportTemplateForm : Form
    {
        readonly UserProfile user;

        public UserSessionActivitiesReportTemplateForm(String username)
        {
            InitializeComponent();

            user = UserInformationManager.ConsultUserInformationByUsername(username);

            usernameLabel.Text = user.Username;
            roleLabel.Text = user.Role;
        }

        #region On Form Load Logic
        private void UserSessionActivitiesReportTemplateForm_Load(object sender, EventArgs e)
        {
            saleMessageLabel.Visible = false;

            newestDateTimePicker.Value = DateTime.Now;
            newestDateTimePicker.MaxDate = DateTime.Today.AddDays(1);
            oldestDateTimePicker.Value = DateTime.Today.AddMonths(-1);
            oldestDateTimePicker.MaxDate = DateTime.Today.AddDays(-1);
        }
        #endregion

        #region Key Down Logic
        private void SessionsDataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.Up)
                DisplaySelectedSessionActivities(); // there's a delaly in between the key down and the switch of the selected row
        }
        #endregion

        #region Value Changed Logic
        private void NewestDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            oldestDateTimePicker.MaxDate = newestDateTimePicker.Value.AddDays(-1); // Required to be first given such a small interval of time
            oldestDateTimePicker.Value = newestDateTimePicker.Value.AddDays(-1);
        }

        private void OldestDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            PopulateSessionLogDataGrid();
            DisplaySelectedSessionActivities();
        }
        #endregion

        #region Cell Click Logic
        private void SessionsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DisplaySelectedSessionActivities();
        }
        #endregion

        #region Sales Message Label Logic
        private void SalesLabel_MouseHover(object sender, EventArgs e)
        {
            saleMessageLabel.Visible = true;
        }

        private void SalesLabel_MouseLeave(object sender, EventArgs e)
        {
            saleMessageLabel.Visible = false;
        }
        #endregion

        #region Auxiliary Functions
        /// <summary>
        /// Function to fetch and display the target user's session log
        /// </summary>
        private void PopulateSessionLogDataGrid()
        {
            sessionsDataGridView.DataSource = ReportInformationManager.ConsultUserSessionLogInformation(user.Username, oldestDateTimePicker.Value, newestDateTimePicker.Value);

            sessionsDataGridView.Columns["LogIn"].Width = 170;
            sessionsDataGridView.Columns["LogOut"].Width = 170;
            sessionsDataGridView.Columns["TotalSessionMinutes"].Width = 150;
        }

        /// <summary>
        /// Function to display all activities complete during a selected session 
        /// </summary>
        private void DisplaySelectedSessionActivities()
        {
            activitiesDataGridView.DataSource = new List<Activity>();
            activitiesDataGridView.Refresh();

            activitiesDataGridView.Columns["Username"].Visible = false;
            activitiesDataGridView.Columns["Description"].Width = 300;
            activitiesDataGridView.Columns["Type"].Width = 200;
            activitiesDataGridView.Columns["Timestamp"].Width = 200;

            List<Activity> activities = new List<Activity>();

            // TODO: Take into account warnings
            if (sessionsDataGridView.RowCount > 0)
                activities = ReportInformationManager.ConsultUserActivitiesDuringSessionInformation(user.Username, DateTime.Parse(sessionsDataGridView.SelectedCells[0].Value.ToString()), DateTime.Parse(sessionsDataGridView.SelectedCells[1].Value.ToString()));
          
            activitiesDataGridView.DataSource = activities;
            activitiesDataGridView.Refresh();

            int errorCounter = 0;
            int salesCounter = 0;
            int returnsCounter = 0;

            foreach (Activity activity in activities)
            {
                if (activity.Type == "ERROR")
                    errorCounter++;

                if (activity.Type == "NEW TRANSACTION")
                    salesCounter++;

                if (activity.Type == "RETURN TRANSACTION")
                    returnsCounter++;
            }

            totalLabel.Text = totalLabel.Text.Split(':')[0] + ": " + activities.Count;
            errorsLabel.Text = errorsLabel.Text.Split(':')[0] + ": " + errorCounter;
            salesLabel.Text = salesLabel.Text.Split(':')[0] + ": " + (salesCounter - returnsCounter); // only counts sales that have not originated from returns
            returnsLabel.Text = returnsLabel.Text.Split(':')[0] + ": " + returnsCounter; 
        }
        #endregion
    }
}
