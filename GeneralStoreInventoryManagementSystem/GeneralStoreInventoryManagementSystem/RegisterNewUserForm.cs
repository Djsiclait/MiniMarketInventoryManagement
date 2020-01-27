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
    public partial class RegisterNewUserForm : Form
    {
        public RegisterNewUserForm()
        {
            InitializeComponent();
        }

        private void RegisterNewUserForm_Load(object sender, EventArgs e)
        {
            messageLabel.Text = "";
            usernameErrorLable.Visible = false;
            passwordErrorLabel.Visible = false;
        }

        ////////// Menu Bar Options
        private void ViewSalesMenuSubOption_Click(object sender, EventArgs e)
        {
            // Closing form while freeing system resources
            FormsMenuList.registerNewUserForm.Dispose();

            // Summon Sales Registry Form
            FormsMenuList.salesRecordForm = new SalesRecordForm();
            FormsMenuList.salesRecordForm.Show();
        }

        private void MakeSaleMenuSubOption_Click(object sender, EventArgs e)
        {
            // Closing form while freeing system resources
            FormsMenuList.registerNewUserForm.Dispose();

            // Summon Register New Sale Form
            FormsMenuList.registerNewSaleForm = new RegisterNewSaleFrom();
            FormsMenuList.registerNewSaleForm.Show();
        }

        private void BrowseProductsMenuSubOption_Click(object sender, EventArgs e)
        {
            // Closing form while freeing system resources
            FormsMenuList.registerNewUserForm.Dispose();

            // Summon Product Browser Form
            FormsMenuList.inventorySearchForm.Show(); // TODO: instanciate this form after removing the application ancor
        }

        private void RegisterNewProductMenuSubOption_Click(object sender, EventArgs e)
        {
            // Closing form while freeing system resources
            FormsMenuList.registerNewUserForm.Dispose();

            // Summon Register New Product Form
            FormsMenuList.registerNewProduct = new RegisterNewProductForm();
            FormsMenuList.registerNewProduct.Show();
        }

        private void RestockProductsMenuSubOption_Click(object sender, EventArgs e)
        {
            // Closing form while freeing system resources
            FormsMenuList.registerNewUserForm.Dispose();

            // Summon Restock Products Form
            FormsMenuList.restockProductsFrom = new RestockProductsForm();
            FormsMenuList.restockProductsFrom.Show();
        }

        private void ViewUsersMenuSubOption_Click(object sender, EventArgs e)
        {
            // Closing form while freeing system resources
            FormsMenuList.registerNewUserForm.Dispose();

            // Summon Users Registry Form
            FormsMenuList.usersRegistryForm = new UsersRegistryForm();
            FormsMenuList.usersRegistryForm.Show();
        }

        private void ViewGraphsOption_Click(object sender, EventArgs e)
        {
            // Closing form while freeing system resources
            FormsMenuList.registerNewUserForm.Dispose();

            // Summon Graphs Analytics Form
            FormsMenuList.graphsAnaliticsForm = new GraphsAnalyticsForm();
            FormsMenuList.graphsAnaliticsForm.Show();
        }

        private void ViewReportsOption_Click(object sender, EventArgs e)
        {
            // Closing form while freeing system resources
            FormsMenuList.registerNewUserForm.Dispose();

            // Summon Reports Analytics Form
            FormsMenuList.reportsAnalyticsForm = new ReportsAnalyticsForm();
            FormsMenuList.reportsAnalyticsForm.Show();
        }

        private void ViewActivityLogsOption_Click(object sender, EventArgs e)
        {
            // Closing form while freeing system resources
            FormsMenuList.registerNewUserForm.Dispose();

            // Summon Activity Logs Form
            FormsMenuList.activitiesLogForm = new ActivitiesLogForm();
            FormsMenuList.activitiesLogForm.Show();
        }

        private void ViewErrorLogsOption_Click(object sender, EventArgs e)
        {
            // Closing form while freeing system resources
            FormsMenuList.registerNewUserForm.Dispose();

            // Summon Error Logs Form
            FormsMenuList.errorsLogForm = new ErrorsLogForm();
            FormsMenuList.errorsLogForm.Show();
        }

        private void ViewCartLabel_Click(object sender, EventArgs e)
        {
            // Closing form while freeing system resources
            FormsMenuList.registerNewUserForm.Dispose();

            // Summon View Cart Form
            FormsMenuList.viewCartForm = new ViewCartForm();
            FormsMenuList.viewCartForm.Show();
        }

        private void ViewCartLabel_MouseHover(object sender, EventArgs e)
        {
            FormsMenuList.registerNewUserForm.viewCartLabel.ForeColor = Color.Blue;
        }

        private void ViewCartLabel_MouseLeave(object sender, EventArgs e)
        {
            FormsMenuList.registerNewUserForm.viewCartLabel.ForeColor = Color.Black;
        }

        private void LogOutLabel_Click(object sender, EventArgs e)
        {
            // Closing form while freeing system resources
            FormsMenuList.registerNewUserForm.Dispose();

            // Log out of current session
            FormsMenuList.loginForm = new LoginForm(); // TODO: Remove this instantiation and leave the Show() function
            FormsMenuList.loginForm.Show();
        }

        private void LogOutLabel_MouseHover(object sender, EventArgs e)
        {
            FormsMenuList.registerNewUserForm.LogOutLabel.ForeColor = Color.Red;
        }

        private void LogOutLabel_MouseLeave(object sender, EventArgs e)
        {
            FormsMenuList.registerNewUserForm.LogOutLabel.ForeColor = Color.Black;
        }
        ////////// Menu Bar Options

        private void UsernameTextBox_TextChanged(object sender, EventArgs e)
        {
            if(InventoryManagementBusinessLayer.ConsultInformation.CheckUsernameAvailability(usernameTextBox.Text))
                usernameErrorLable.Visible = false;
            else
                usernameErrorLable.Visible = true;
        }

        private void ConfirmPasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            if (passwordTextBox.Text != confirmPasswordTextBox.Text)
                passwordErrorLabel.Visible = true;
            else
                passwordErrorLabel.Visible = false;
        }

        private void CreateNewUserButton_Click(object sender, EventArgs e)
        {
            bool availability = InventoryManagementBusinessLayer.ConsultInformation.CheckUsernameAvailability(usernameTextBox.Text);

            messageLabel.Text = InventoryManagementBusinessLayer.CreateInformation.CreateNewUserProfileInformation(CreateUserProfile());

            ClearTextBoxBuffers();
        }

        private void CreateAndReturnButton_Click(object sender, EventArgs e)
        {
            bool availability = InventoryManagementBusinessLayer.ConsultInformation.CheckUsernameAvailability(usernameTextBox.Text );

            ClearTextBoxBuffers();

            messageLabel.Text = InventoryManagementBusinessLayer.CreateInformation.CreateNewUserProfileInformation(CreateUserProfile());
            // Closing form while freeing system resources
            FormsMenuList.registerNewUserForm.Dispose();

            // Summon Users Registry Form
            FormsMenuList.usersRegistryForm = new UsersRegistryForm();
            FormsMenuList.usersRegistryForm.Show();
        }
        
        private UserProfile CreateUserProfile()
        {
            UserProfile profile = new UserProfile();

            profile.Username = usernameTextBox.Text;
            profile.Password = passwordTextBox.Text;
            profile.FirstName = firstNameTextBox.Text;
            profile.LastName = lastNameTextBox.Text;
            profile.Role = grantAdminCheckbox.Checked ? "Admin" : "User";
            profile.Creator = "super.admin"; // TODO: Replaxce with profile of user currently in session

            return profile;
        }

        private void ClearTextBoxBuffers()
        {
            usernameTextBox.Text = "";
            firstNameTextBox.Text = "";
            lastNameTextBox.Text = "";
            passwordTextBox.Text = "";
            confirmPasswordTextBox.Text = "";
            grantAdminCheckbox.Checked = false;
        }

        private bool ValidateUserInput()
        {
            bool validate = true;

            if (usernameTextBox.Text == "")
                validate = false;

            if (firstNameTextBox.Text == "")
                validate = false;

            if (lastNameTextBox.Text == "")
                validate = false;

            if (passwordTextBox.Text == "")
                validate = false;

            if (confirmPasswordTextBox.Text == "")
                validate = false;

            if (passwordTextBox.Text != confirmPasswordTextBox.Text)
                validate = false;

            return validate;
        }
    }
}
