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
using InventoryManagementEntityLayer.UserProfile;

namespace GeneralStoreInventoryManagementSystem
{
    public partial class UserSessionActivitiesReportTemplateForm : Form
    {
        UserProfile user;

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
            newestDateTimePicker.Value = DateTime.Now;
            oldestDateTimePicker.Value = DateTime.Today.AddDays(-1);
            oldestDateTimePicker.MaxDate = DateTime.Today.AddDays(-1);

            PopulateSessionLogDataGrid();
        }
        #endregion

        #region Value Changed Logic
        private void NewestDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            oldestDateTimePicker.MaxDate = newestDateTimePicker.Value.AddDays(-1); // Required to be first given such a small interval of time
            oldestDateTimePicker.Value = newestDateTimePicker.Value.AddDays(-1);

            PopulateSessionLogDataGrid();
        }

        private void OldestDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            PopulateSessionLogDataGrid();
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
        #endregion
    }
}
