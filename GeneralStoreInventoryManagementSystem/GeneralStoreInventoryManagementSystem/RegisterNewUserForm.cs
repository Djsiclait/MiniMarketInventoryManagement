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

////////// Load Form Logic
        private void RegisterNewUserForm_Load(object sender, EventArgs e)
        {
            // Limiting option according to current user's access level
            if (CollectiveResources.UserInSession.Role == "User")
            {
                // Disabling the other Products option 
                registerNewProductMenuSubOption.Visible = false;
                registerNewProductMenuSubOption.Enabled = false;
                restockProductsMenuSubOption.Visible = false;
                restockProductsMenuSubOption.Enabled = false;

                // Disabling all admin options
                adminMenuOption.Visible = false;
                adminMenuOption.Enabled = false;
            }

            // Inictializing message labels
            messageLabel.Text = "";
            usernameErrorLable.Visible = false;
            passwordErrorLabel.Text = "Invalid Password";
            passwordErrorLabel.Visible = false;
            confirmationPasswordErrorLabel.Visible = false;
        }
////////// END Load Form Logic

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
            FormsMenuList.inventorySearchForm = new InventorySearchForm();
            FormsMenuList.inventorySearchForm.Show();
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
            CollectiveResources.EndUserSession();
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

////////// Username Validation Function
        private void UsernameTextBox_TextChanged(object sender, EventArgs e)
        {
            usernameTextBox.BackColor = Color.White;

            // Requesting an availability check for the new username 
            if (usernameTextBox.Text.ToLower() == "admin" || usernameTextBox.Text.ToLower() == "super" || usernameTextBox.Text.ToLower() == "superadmin" || usernameTextBox.Text.ToLower() == "adminsuper")
                usernameErrorLable.Visible = true; // username is invalid regardless if it isn't registered
            else if (usernameTextBox.Text.Count() < 3)
                usernameErrorLable.Visible = true; // username is invalid due to legnth
            else if (UsernameHasEmptySpace())
                usernameErrorLable.Visible = true; // username is invalid due to empty space 
            else if(InventoryManagementBusinessLayer.ConsultInformation.CheckUsernameAvailability(usernameTextBox.Text))
                usernameErrorLable.Visible = false; // username is available and validated so error message is hidden
        }
////////// END Username Validation Function

////////// Style formating
        private void FirstNameTextBox_TextChanged(object sender, EventArgs e)
        {
            firstNameTextBox.BackColor = Color.White;
        }

        private void LastNameTextBox_TextChanged(object sender, EventArgs e)
        {
            lastNameTextBox.BackColor = Color.White;
        }
////////// END Style formating

////////// Validating password
        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            passwordTextBox.BackColor = Color.White; // Formating color 

            if (passwordTextBox.Text.Count() < 8) // rejecting password due to length
            {
                passwordErrorLabel.Text = "Invalid Password: Must be at least 8 characters long";
                passwordErrorLabel.Visible = true;
            }
            else if (passwordTextBox.Text == "12345678") // rejecting passsword due to predictability
            {
                passwordErrorLabel.Text = "Invalid Password: Password too weak";
                passwordErrorLabel.Visible = true;
            }
            else if (passwordTextBox.Text == usernameTextBox.Text) // rejecting passwords similar to he username
            {
                passwordErrorLabel.Text = "Invalid Password: Cannot be the same as chosen username";
                passwordErrorLabel.Visible = true;
            }
            else // Password correct and validated
            {
                passwordErrorLabel.Text = "Invalid Password";
                passwordErrorLabel.Visible = false;
            }

            // Verifying if password and confirmation password are the same
            if (passwordTextBox.Text != confirmPasswordTextBox.Text)
                confirmationPasswordErrorLabel.Visible = true; // Confirmation is incorrect
            else
                confirmationPasswordErrorLabel.Visible = false; // passwords are the same
        }
////////// END Validating password

////////// Validating confirmation password
        private void ConfirmPasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            confirmPasswordTextBox.BackColor = Color.White; // Formating color

            // Verifying if password and confirmation password are the same
            if (passwordTextBox.Text != confirmPasswordTextBox.Text)
                confirmationPasswordErrorLabel.Visible = true; // Confirmation is incorrect
            else
                confirmationPasswordErrorLabel.Visible = false; // passwords are the same
        }
////////// END Validating confirmation password

////////// Submit New User for Creation
        private void CreateNewUserButton_Click(object sender, EventArgs e)
        {
            if (ValidateUserInput()) // Verifying if user input confirm with all requirements
            {
                String message = InventoryManagementBusinessLayer.CreateInformation.CreateNewUserProfileInformation(CreateUserProfile()); // Confimring the user creation process

                if (message == "User created") // Creation process has been successful
                {
                    messageLabel.Text = "User " + usernameTextBox.Text + " has been created succesfully!";
                    ClearTextBoxBuffers(); // cleaning textboxes
                }
                else
                    messageLabel.Text = "A Fatal Error has occured!"; // The new user profile has not been created due to en error
            }
            else
                messageLabel.Text = "Please fill in every information correctly"; // user input has not been validated
        }
////////// END Submit New User for Creation

////////// Submit New User and Return to User Registry
        private void CreateAndReturnButton_Click(object sender, EventArgs e)
        {
            if (ValidateUserInput()) // Verifying if user input confirm with all requirements
            {
                String message = InventoryManagementBusinessLayer.CreateInformation.CreateNewUserProfileInformation(CreateUserProfile()); // Confimring the user creation process

                if (message == "User created") // Creation process has been successful
                {
                    messageLabel.Text = "User has been created succesfully!";
                    ClearTextBoxBuffers(); // cleaning textboxes

                    // Closing form while freeing system resources
                    FormsMenuList.registerNewUserForm.Dispose();

                    // Summon Users Registry Form
                    FormsMenuList.usersRegistryForm = new UsersRegistryForm();
                    FormsMenuList.usersRegistryForm.Show();
                }
                else
                    messageLabel.Text = "A Fatal Error has occured!"; // The new user profile has not been created due to en error
            }
            else
                messageLabel.Text = "Please fill in every information correctly"; // user input has not been validated
        }
////////// END Submit New User and Return to User Registry

////////// Fucntion to create a user profile object with user input values
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
////////// END Fucntion to create a user profile

////////// Clearing TextBox Function
        private void ClearTextBoxBuffers()
        {
            usernameTextBox.Text = "";
            firstNameTextBox.Text = "";
            lastNameTextBox.Text = "";
            passwordTextBox.Text = "";
            confirmPasswordTextBox.Text = "";
            grantAdminCheckbox.Checked = false;

            usernameErrorLable.Visible = false;
            passwordErrorLabel.Visible = false;
        }
////////// END Clearing TextBox Function

////////// Validating user input for correct format and standards
        private bool ValidateUserInput()
        {
            bool validate = true; // No error has been detected

            if (usernameTextBox.Text == "") // username has been left empty
            {
                validate = false;
                usernameTextBox.BackColor = Color.Red;
            }

            if (usernameErrorLable.Visible) // username format error has occured
            {
                validate = false;
                usernameTextBox.BackColor = Color.Red;
            }

            if (firstNameTextBox.Text == "") // first name has been left empty 
            {
                validate = false;
                firstNameTextBox.BackColor = Color.Red;
            }

            if (lastNameTextBox.Text == "") // last name has been left empty
            {
                validate = false;
                lastNameTextBox.BackColor = Color.Red;
            }

            if (passwordTextBox.Text == "") // password has been left empty
            {
                validate = false;
                passwordTextBox.BackColor = Color.Red;
            }

            if (passwordErrorLabel.Visible) // password format error has occured
            {
                validate = false;
                passwordTextBox.BackColor = Color.Red;
            }

            if (confirmPasswordTextBox.Text == "") // confirmation password has been left empty
            {
                validate = false;
                confirmPasswordTextBox.BackColor = Color.Red;
            }
            if (confirmationPasswordErrorLabel.Visible) // confirmation password format error has occured
            {
                validate = false;
                confirmPasswordTextBox.BackColor = Color.Red;
            }

            if (passwordTextBox.Text != confirmPasswordTextBox.Text) // password and confirmation password do not match
            {
                validate = false;
                passwordTextBox.BackColor = Color.Red;
                confirmPasswordTextBox.BackColor = Color.Red;
            }

            return validate; // returning respons to the validation analysis
        }
/////////// END Validating user input

////////// Function to ensure usernames are only composed of one word
        private bool UsernameHasEmptySpace()
        {
            bool result = false;

            string[] words = usernameTextBox.Text.Split(' '); // detecting white spaces

            if (words.Count() > 1) // if white spaces are detected the username will be split into multiple words
                result = true;

            return result;
        }
/////////// END Function
    }
}
