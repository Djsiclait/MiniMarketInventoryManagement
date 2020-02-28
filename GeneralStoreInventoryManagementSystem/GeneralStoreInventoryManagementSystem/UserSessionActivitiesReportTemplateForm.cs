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

        private void UserSessionActivitiesReportTemplateForm_Load(object sender, EventArgs e)
        {
            newestDateTimePicker.Value = DateTime.Now;
            oldestDateTimePicker.Value = DateTime.Today.AddDays(-1);
            oldestDateTimePicker.MaxDate = DateTime.Today.AddDays(-1);

            PopulateSessionLogDataGrid();
        }

        #region Auxiliary Functions
        /// <summary>
        /// 
        /// </summary>
        private void PopulateSessionLogDataGrid()
        {
            sessionsDataGridView.DataSource = ReportInformationManager.ConsultUserSessionLogInformation(user.Username, oldestDateTimePicker.Value, newestDateTimePicker.Value);
        }
        #endregion
    }
}
