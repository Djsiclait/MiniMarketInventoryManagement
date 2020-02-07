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
using InventoryManagementBusinessLayer;
using InventoryManagementEntityLayer;

namespace GeneralStoreInventoryManagementSystem
{
    public partial class UserInformationTemplateForm : Form
    {
        UserProfile user;

        public UserInformationTemplateForm(String username)
        {
            InitializeComponent();

            user = ConsultInformation.FetchUserInformationByUsername(username); // fetching information of target user

            userTitleLabel.Text += " " + username;
        }

////////// Load Form Logic
        private void UserInformationTemplateForm_Load(object sender, EventArgs e)
        {
            // Disabling features according to target user's aacces level compared to current user in session's access level
            if (user.Username != SystemResources.UserInSession.Username && user.Role == SystemResources.UserInSession.Role) // If the target user is of a different account and access level is equals to the current user in session
            {
                changeAccessLevelButtom.Visible = false;
                changeAccessLevelButtom.Enabled = false;
                changePasswordButton.Visible = false;
                changePasswordButton.Enabled = false;
            }
            else if (user.Username == SystemResources.UserInSession.Username) // If the target user the one with the current open sesison
            {
                changeAccessLevelButtom.Visible = false;
                changeAccessLevelButtom.Enabled = false;
                suspendUserButton.Visible = false;
                suspendUserButton.Enabled = false;
            }
            else // If the target user is of a different account and access level is different to the current user in session
            {
                changePasswordButton.Visible = false;
                changePasswordButton.Enabled = false;
            }

            // Modifuing components based on target user's access level
            changeAccessLevelButtom.Text = user.Role == "Admin" ? "Demote to User Level" : "Promote to Admin Level";
            suspendUserButton.Text = user.Status == "Active" ? "Suspend User" : "Reinstate User";

            // Displaying target user's information
            usernameTextBox.Text = user.Username;
            firstNameTextBox.Text = user.FirstName;
            lastNameTextBox.Text = user.LastName;
            roleTextBox.Text = user.Role;
            creatorTextBox.Text = user.Creator;
            statusTextBox.Text = user.Status;
            registrationDateDateTimePicker.Text = user.RegistrationDate.ToString();
            lastLoginDateTimePicker.Text = user.LastLogin.ToString();

            PopulateActivityList();
        }
////////// END Load Form Logic

////////// Text Changed Logic
        private void ActivitySearchBox_TextChanged(object sender, EventArgs e)
        {
            PopulateActivityList();
        }
////////// END Text Changed Logic

////////// Button Click Logic
        private void ChangePasswordButton_Click(object sender, EventArgs e)
        {
            // Requesting a password change for the current user in session
            ChangePasswordMiniForm changePasswordMiniForm = new ChangePasswordMiniForm(SystemResources.UserInSession.Username);
            changePasswordMiniForm.Show();
        }

        private void ChangeAccessLevelButtom_Click(object sender, EventArgs e)
        {
            // Requesting a access level change for a target user
            UpdateInformation.ChangeTargetUserAccessLevelData(user.Username, user.Role == "Admin" ? "User" : "Admin");

            // Updating information of the form
            user.Role = user.Role == "Admin" ? "User" : "Admin";
            roleTextBox.Text = user.Role;
            changeAccessLevelButtom.Text = user.Role == "Admin" ? "Demote to User Level" : "Promote to Admin Level";

            // Disabling features according to target user's aacces level compared to current user in session's access level
            if (user.Username != SystemResources.UserInSession.Username && user.Role == SystemResources.UserInSession.Role) // If the target user is of a different account and access level is equals to the current user in session
            {
                changeAccessLevelButtom.Visible = false;
                changeAccessLevelButtom.Enabled = false;
                changePasswordButton.Visible = false;
                changePasswordButton.Enabled = false;
            }

            // Executing correct activity according to given code
            SystemProtocols.ApplyActivityProtocols("SPE2", user.Username, user.Role);

            // Refreshing and updating information of parent form
            FormsMenuList.usersRegistryForm.RefreshDatagridInformation();
        }

        private void SuspendUserButton_Click(object sender, EventArgs e)
        {
            // Requesting status change of terget user account
            UpdateInformation.ChangeTargerUserStatusInformation(user.Username, user.Status == "Active" ? 1 : 0);

            // Updating form information
            user.Status = user.Status == "Active" ? "1" : "0";
            statusTextBox.Text = user.Status;
            suspendUserButton.Text = user.Status == "Active" ? "Suspend User" : "ReinstateUser";

            // Executing correct activity according to given code
            SystemProtocols.ApplyActivityProtocols("SPE3", user.Username, user.Status);

            // Refreshing and updating information of parent form
            FormsMenuList.usersRegistryForm.RefreshDatagridInformation();
        }
////////// END Button Click Logic

////////// Auxiliary Function
        /// <summary>
        /// Function that populates the activity log with a specific user's activities
        /// </summary>
        private void PopulateActivityList()
        {
            // Requesting a user's activities
            activityList.DataSource = ConsultInformation.FetchActivityListInformationByUsername(user.Username, activitySearchBox.Text);

            // Formating data grid
            activityList.Columns["Username"].Visible = false;
            activityList.Columns["Description"].Width = 170;
            activityList.Columns["Timestamp"].Width = 130;
        }
    }
}
