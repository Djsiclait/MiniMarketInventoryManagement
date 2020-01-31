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

            user = InventoryManagementBusinessLayer.ConsultInformation.FetchUserInformationByUsername(username);

            userTitleLabel.Text += " " + username;
        }

        private void UserInformationTemplateForm_Load(object sender, EventArgs e)
        {
            if (user.Username != CollectiveResources.UserInSession.Username && user.Role == CollectiveResources.UserInSession.Role)
            {
                changeAccessLevelButtom.Visible = false;
                changeAccessLevelButtom.Enabled = false;
                changePasswordButton.Visible = false;
                changePasswordButton.Enabled = false;
            }
            else if (user.Username == CollectiveResources.UserInSession.Username)
            {
                changeAccessLevelButtom.Visible = false;
                changeAccessLevelButtom.Enabled = false;
                suspendUserButton.Visible = false;
                suspendUserButton.Enabled = false;
            }
            else
            {
                changePasswordButton.Visible = false;
                changePasswordButton.Enabled = false;
            }

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

        private void PopulateActivityList()
        {
            activityList.DataSource = InventoryManagementBusinessLayer.ConsultInformation.FetchActivityListInformationByUsername(CollectiveResources.UserInSession.Role, user.Username, activitySearchBox.Text);

            activityList.Columns["Username"].Visible = false;
            activityList.Columns["Description"].Width = 170;
            activityList.Columns["Timestamp"].Width = 130;
        }

        private void ActivitySearchBox_TextChanged(object sender, EventArgs e)
        {
            PopulateActivityList();
        }

        private void ChangePasswordButton_Click(object sender, EventArgs e)
        {
            ChangePasswordMiniForm changePasswordMiniForm = new ChangePasswordMiniForm(CollectiveResources.UserInSession.Username);
            changePasswordMiniForm.Show();
        }
    }
}
