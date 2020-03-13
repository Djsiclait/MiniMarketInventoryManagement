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
using InventoryManagementBusinessLayer.ActivityInformation;
using InventoryManagementBusinessLayer.Protocols;
using InventoryManagementBusinessLayer.Resources;
using InventoryManagementBusinessLayer.UserInformation;
using InventoryManagementEntityLayer.UserProfile;

namespace GeneralStoreInventoryManagementSystem
{
    public partial class UserInformationTemplateForm : Form
    {
        UserProfile user;

        public UserInformationTemplateForm(String username)
        {
            InitializeComponent();

            user = UserInformationManager.ConsultUserInformationByUsername(username); // fetching information of target user

            userTitleLabel.Text += " " + username;
        }

        #region Load Form Logic
        private void UserInformationTemplateForm_Load(object sender, EventArgs e)
        {
            // Disabling features according to target user's aacces level compared to current user in session's access level
            if (SystemProtocols.ApplySessionsProtocols(2, user.Username, user.Role)) // If the target user is of a different account and access level is equals to the current user in session
            {   // TODO: Hide System resources in business layer
                changeAccessLevelButtom.Visible = false;
                changeAccessLevelButtom.Enabled = false;
                changePasswordButton.Visible = false;
                changePasswordButton.Enabled = false;
            }
            else if (SystemProtocols.ApplySessionsProtocols(3, user.Username)) // If the target user the one with the current open sesison
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
            createdOnLabel.Text = user.RegistrationDate.ToString();
            LastLabel.Text = user.LastLogin.ToString();

            PopulateActivityList();
        }
        #endregion

        #region Text Changed Logic
        private void ActivitySearchBox_TextChanged(object sender, EventArgs e)
        {
            PopulateActivityList();
        }
        #endregion

        #region Button Click Logic
        private void ChangePasswordButton_Click(object sender, EventArgs e)
        {
            // Requesting a password change for the current user in session
            ChangePasswordMiniForm changePasswordMiniForm = new ChangePasswordMiniForm(SystemResources.UserInSession.Username);
            changePasswordMiniForm.Show();
        }

        private void ChangeAccessLevelButtom_Click(object sender, EventArgs e)
        {
            // Requesting a access level change for a target user
            UserInformationManager.UpdateTargetUserAccessLevelInformation(user.Username, user.Role == "Admin" ? "User" : "Admin");

            // Updating information of the form
            user.Role = user.Role == "Admin" ? "User" : "Admin";
            roleTextBox.Text = user.Role;
            changeAccessLevelButtom.Text = user.Role == "Admin" ? "Demote to User Level" : "Promote to Admin Level";

            // Disabling features according to target user's access level compared to current user in session's access level
            if (SystemProtocols.ApplySessionsProtocols(2, user.Username, user.Role)) 
            {
                changeAccessLevelButtom.Visible = false;
                changeAccessLevelButtom.Enabled = false;
                changePasswordButton.Visible = false;
                changePasswordButton.Enabled = false;
            }

            // Refreshing and updating information of parent form
            FormsMenuList.usersRegistryForm.RefreshDatagridInformation();
        }

        private void SuspendUserButton_Click(object sender, EventArgs e)
        {
            // Requesting status change of terget user account
            UserInformationManager.UpdateTargerUserStatusInformation(user.Username, user.Status == "Active" ? 1 : 0, user.Status == "Active" ? "Inactive" : "Active");

            // Updating form information
            user.Status = user.Status == "Active" ? "1" : "0";
            statusTextBox.Text = user.Status;
            suspendUserButton.Text = user.Status == "Active" ? "Suspend User" : "Reinstate User";

            // Refreshing and updating information of parent form
            FormsMenuList.usersRegistryForm.RefreshDatagridInformation();
        }
        #endregion

        #region Auxiliary Function
        /// <summary>
        /// Function that populates the activity log with a specific user's activities
        /// </summary>
        private void PopulateActivityList()
        {
            // Requesting a user's activities
            activityList.DataSource = ActivityInformationManager.ConsultActivityListInformationByUsername(user.Username, activitySearchBox.Text);

            // Formating data grid
            activityList.Columns["Username"].Visible = false;
            activityList.Columns["Description"].Width = 170;
            activityList.Columns["Timestamp"].Width = 130;
        }
        #endregion
    }
}
