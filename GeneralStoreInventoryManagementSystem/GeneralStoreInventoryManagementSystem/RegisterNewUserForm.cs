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
using InventoryManagementBusinessLayer.Protocols;
using InventoryManagementBusinessLayer.Resources;
using InventoryManagementBusinessLayer.UserInformation;
using InventoryManagementEntityLayer.UserProfile;

namespace GeneralStoreInventoryManagementSystem
{
    public partial class RegisterNewUserForm : Form
    {
        int assistance = 0;

        public RegisterNewUserForm()
        {
            InitializeComponent();
        }

        #region Load Form Logic
        private void RegisterNewUserForm_Load(object sender, EventArgs e)
        {
            // Identifying correct protocol for current user in session
            if (SystemProtocols.ApplySessionsProtocols(1))
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

            // Executing correct activity according to given code
            SystemProtocols.ApplyActivityProtocols("USE2");
        }
        #endregion

        #region On Form Closing Override
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            // Executing correct log out processes
            SystemProtocols.ApplyLogOutProtocols();
            FormsMenuList.loginForm.Show();

            SystemProtocols.ApplyCartManagementProtocol(3, null, 0, null, 0); // clearing the cart before logging out

            // Closing form while freeing system resources
            FormsMenuList.registerNewUserForm.Dispose();
        }
        #endregion

        #region Menu Bar Options
        private void ViewSalesMenuSubOption_Click(object sender, EventArgs e)
        {
            // Summon Sales Registry Form
            FormsMenuList.salesRecordForm = new SalesRecordForm();
            FormsMenuList.salesRecordForm.Show();

            // Closing form while freeing system resources
            FormsMenuList.registerNewUserForm.Dispose();
        }

        private void MakeSaleMenuSubOption_Click(object sender, EventArgs e)
        {
            // Summon Register New Sale Form
            FormsMenuList.registerNewSaleForm = new RegisterNewSaleFrom();
            FormsMenuList.registerNewSaleForm.Show();

            // Closing form while freeing system resources
            FormsMenuList.registerNewUserForm.Dispose();
        }

        private void BrowseProductsMenuSubOption_Click(object sender, EventArgs e)
        {
            // Summon Product Browser Form
            FormsMenuList.inventorySearchForm = new InventorySearchForm();
            FormsMenuList.inventorySearchForm.Show();

            // Closing form while freeing system resources
            FormsMenuList.registerNewUserForm.Dispose();
        }

        private void RegisterNewProductMenuSubOption_Click(object sender, EventArgs e)
        {
            // Summon Register New Product Form
            FormsMenuList.registerNewProduct = new RegisterNewProductForm();
            FormsMenuList.registerNewProduct.Show();

            // Closing form while freeing system resources
            FormsMenuList.registerNewUserForm.Dispose();
        }

        private void RestockProductsMenuSubOption_Click(object sender, EventArgs e)
        {
            // Summon Restock Products Form
            FormsMenuList.restockProductsFrom = new RestockProductsForm();
            FormsMenuList.restockProductsFrom.Show();

            // Closing form while freeing system resources
            FormsMenuList.registerNewUserForm.Dispose();
        }

        private void ViewUsersMenuSubOption_Click(object sender, EventArgs e)
        {
            // Summon Users Registry Form
            FormsMenuList.usersRegistryForm = new UsersRegistryForm();
            FormsMenuList.usersRegistryForm.Show();

            // Closing form while freeing system resources
            FormsMenuList.registerNewUserForm.Dispose();
        }

        private void ViewGraphsOption_Click(object sender, EventArgs e)
        {
            // Summon Graphs Analytics Form
            FormsMenuList.graphsAnaliticsForm = new GraphsAnalyticsForm();
            FormsMenuList.graphsAnaliticsForm.Show();

            // Closing form while freeing system resources
            FormsMenuList.registerNewUserForm.Dispose();
        }

        private void ViewReportsOption_Click(object sender, EventArgs e)
        {
            // Summon Reports Analytics Form
            FormsMenuList.reportsAnalyticsForm = new ReportsAnalyticsForm();
            FormsMenuList.reportsAnalyticsForm.Show();

            // Closing form while freeing system resources
            FormsMenuList.registerNewUserForm.Dispose();
        }

        private void ViewActivityLogsOption_Click(object sender, EventArgs e)
        {
            // Summon Activity Logs Form
            FormsMenuList.activitiesLogForm = new ActivitiesLogForm();
            FormsMenuList.activitiesLogForm.Show();

            // Closing form while freeing system resources
            FormsMenuList.registerNewUserForm.Dispose();
        }

        private void ViewErrorLogsOption_Click(object sender, EventArgs e)
        {
            // Summon Error Logs Form
            FormsMenuList.errorsLogForm = new ErrorsLogForm();
            FormsMenuList.errorsLogForm.Show();

            // Closing form while freeing system resources
            FormsMenuList.registerNewUserForm.Dispose();
        }

        private void ViewCartLabel_Click(object sender, EventArgs e)
        {
            // Summon View Cart Form
            FormsMenuList.viewCartForm = new ViewCartForm();
            FormsMenuList.viewCartForm.Show();

            // Closing form while freeing system resources
            FormsMenuList.registerNewUserForm.Dispose();
        }

        private void ViewCartLabel_MouseHover(object sender, EventArgs e)
        {
            FormsMenuList.registerNewUserForm.viewCartLabel.ForeColor = Color.Blue;
        }

        private void ViewCartLabel_MouseLeave(object sender, EventArgs e)
        {
            FormsMenuList.registerNewUserForm.viewCartLabel.ForeColor = Color.Black;
        }

        #region Log Out
        private void LogOutLabel_Click(object sender, EventArgs e)
        {
            // Executing correct log out processes
            SystemProtocols.ApplyLogOutProtocols();
            FormsMenuList.loginForm.Show();

            SystemProtocols.ApplyCartManagementProtocol(3, null, 0, null, 0); // clearing the cart before logging out

            // Closing form while freeing system resources
            FormsMenuList.registerNewUserForm.Dispose();
        }

        private void LogOutLabel_MouseHover(object sender, EventArgs e)
        {
            FormsMenuList.registerNewUserForm.LogOutLabel.ForeColor = Color.Red;
        }

        private void LogOutLabel_MouseLeave(object sender, EventArgs e)
        {
            FormsMenuList.registerNewUserForm.LogOutLabel.ForeColor = Color.Black;
        }
        #endregion

        #endregion

        #region  Key Down Shortcut Logic
        private void RegisterNewUserForm_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F1:

                    #region View Sales
                    // Summon Sales Registry Form
                    FormsMenuList.salesRecordForm = new SalesRecordForm();
                    FormsMenuList.salesRecordForm.Show();

                    // Closing form while freeing system resources
                    FormsMenuList.registerNewUserForm.Dispose();
                    #endregion

                    break;

                case Keys.F2:

                    #region Make Sales
                    // Summon Register New Sale Form
                    FormsMenuList.registerNewSaleForm = new RegisterNewSaleFrom();
                    FormsMenuList.registerNewSaleForm.Show();

                    // Closing form while freeing system resources
                    FormsMenuList.registerNewUserForm.Dispose();
                    #endregion

                    break;

                case Keys.F3:

                    #region Product Browser
                    // Summon Product Browser Form
                    FormsMenuList.inventorySearchForm = new InventorySearchForm();
                    FormsMenuList.inventorySearchForm.Show();

                    // Closing form while freeing system resources
                    FormsMenuList.registerNewUserForm.Dispose();
                    #endregion

                    break;

                case Keys.F4:

                    #region Register New Product
                    // Identifying correct protocol for current user in session
                    if (!SystemProtocols.ApplySessionsProtocols(1))
                    {
                        FormsMenuList.registerNewProduct = new RegisterNewProductForm();
                        FormsMenuList.registerNewProduct.Show();

                        // Closing form while freeing system resources
                        FormsMenuList.registerNewUserForm.Dispose();
                    }
                    #endregion

                    break;

                case Keys.F5:

                    #region Restock Products
                    // Identifying correct protocol for current user in session
                    if (!SystemProtocols.ApplySessionsProtocols(1))
                    {
                        // Summon Restock Products Form
                        FormsMenuList.restockProductsFrom = new RestockProductsForm();
                        FormsMenuList.restockProductsFrom.Show();

                        // Closing form while freeing system resources
                        FormsMenuList.registerNewUserForm.Dispose();
                    }
                    #endregion

                    break;

                case Keys.F6:

                    #region View Users
                    // Identifying correct protocol for current user in session
                    if (!SystemProtocols.ApplySessionsProtocols(1))
                    {
                        // Summon Users Registry Form
                        FormsMenuList.usersRegistryForm = new UsersRegistryForm();
                        FormsMenuList.usersRegistryForm.Show();

                        // Closing form while freeing system resources
                        FormsMenuList.registerNewUserForm.Dispose();
                    }
                    #endregion

                    break;

                case Keys.F7:

                    // The user is already viewing the desired page
                    if (assistance < 3)
                        assistance++;
                    else
                        MessageBox.Show("\t---Menu Shortcuts---\n\n" +
                            "View Sales\t\t(F1)\n" +
                            "Make Sales\t(F2)\n" +
                            "Product Browser\t(F3)\n" +
                            "Register Product\t(F4)\n" +
                            "Restock Products\t(F5)\n" +
                            "View Users\t(F6)\n" +
                            "Register New User\t(You are here!)\n" +
                            "View Graphs\t(F8)\n" +
                            "View Reports\t(F9)\n" +
                            "View Activities Log\t(F10)\n" +
                            "View Errors Log\t(F11)\n" +
                            "View Cart\t\t(F12)");

                    break;

                case Keys.F8:

                    #region View Graphs
                    // Identifying correct protocol for current user in session
                    if (!SystemProtocols.ApplySessionsProtocols(1))
                    {
                        // Summon Graphs Analytics Form
                        FormsMenuList.graphsAnaliticsForm = new GraphsAnalyticsForm();
                        FormsMenuList.graphsAnaliticsForm.Show();

                        // Closing form while freeing system resources
                        FormsMenuList.registerNewUserForm.Dispose();
                    }
                    #endregion

                    break;

                case Keys.F9:

                    #region View Reports
                    // Identifying correct protocol for current user in session
                    if (!SystemProtocols.ApplySessionsProtocols(1))
                    {
                        // Summon Reports Analytics Form
                        FormsMenuList.reportsAnalyticsForm = new ReportsAnalyticsForm();
                        FormsMenuList.reportsAnalyticsForm.Show();

                        // Closing form while freeing system resources
                        FormsMenuList.registerNewUserForm.Dispose();
                    }
                    #endregion

                    break;

                case Keys.F10:

                    #region View Activities Log
                    // Identifying correct protocol for current user in session
                    if (!SystemProtocols.ApplySessionsProtocols(1))
                    {
                        // Summon Activity Logs Form
                        FormsMenuList.activitiesLogForm = new ActivitiesLogForm();
                        FormsMenuList.activitiesLogForm.Show();

                        // Closing form while freeing system resources
                        FormsMenuList.registerNewUserForm.Dispose();
                    }
                    #endregion

                    break;

                case Keys.F11:

                    #region View Errors Log
                    // Identifying correct protocol for current user in session
                    if (!SystemProtocols.ApplySessionsProtocols(1))
                    {
                        // Summon Error Logs Form
                        FormsMenuList.errorsLogForm = new ErrorsLogForm();
                        FormsMenuList.errorsLogForm.Show();

                        // Closing form while freeing system resources
                        FormsMenuList.registerNewUserForm.Dispose();
                    }
                    #endregion

                    break;

                case Keys.F12:

                    #region View Cart
                    // Summon View Cart Form
                    FormsMenuList.viewCartForm = new ViewCartForm();
                    FormsMenuList.viewCartForm.Show();

                    // Closing form while freeing system resources
                    FormsMenuList.registerNewUserForm.Dispose();
                    #endregion

                    break;

                default:
                    break;
            }
        }
        #endregion

        #region Text Changed Logic
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
            else if(UserInformationManager.ConsultUsernameAvailability(usernameTextBox.Text))
                usernameErrorLable.Visible = false; // username is available and validated so error message is hidden
        }

        private void FirstNameTextBox_TextChanged(object sender, EventArgs e)
        {
            firstNameTextBox.BackColor = Color.White;
        }

        private void LastNameTextBox_TextChanged(object sender, EventArgs e)
        {
            lastNameTextBox.BackColor = Color.White;
        }

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

        private void ConfirmPasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            confirmPasswordTextBox.BackColor = Color.White; // Formating color

            // Verifying if password and confirmation password are the same
            if (passwordTextBox.Text != confirmPasswordTextBox.Text)
                confirmationPasswordErrorLabel.Visible = true; // Confirmation is incorrect
            else
                confirmationPasswordErrorLabel.Visible = false; // passwords are the same
        }
        #endregion

        #region Button Click Logic
        private void CreateNewUserButton_Click(object sender, EventArgs e)
        {
            if (ValidateUserInput()) // Verifying if user input confirm with all requirements
            {
                String message = UserInformationManager.CreateNewUserProfileInformation(CreateUserProfile()); // Confimring the user creation process

                if (message == "SUCCESS") // Creation process has been successful
                {
                    messageLabel.Text = "User " + usernameTextBox.Text + " has been created succesfully!";
                    ClearTextBoxBuffers(); // cleaning textboxes
                }
                else
                {
                    // Executing correct activity according to given code
                    SystemProtocols.ApplyActivityProtocols("ERR2");
                    messageLabel.Text = "A Fatal Error has occured!"; // The new user profile has not been created due to en error
                }
            }
            else
                messageLabel.Text = "Please fill in every information correctly"; // user input has not been validated
        }

        private void CreateAndReturnButton_Click(object sender, EventArgs e)
        {
            if (ValidateUserInput()) // Verifying if user input confirm with all requirements
            {
                String message = UserInformationManager.CreateNewUserProfileInformation(CreateUserProfile()); // Confimring the user creation process

                if (message == "SUCCESS") // Creation process has been successful
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
                {
                    // Executing correct activity according to given code
                    SystemProtocols.ApplyActivityProtocols("ERR2");
                    messageLabel.Text = "A Fatal Error has occured!"; // The new user profile has not been created due to en error
                }
            }
            else
                messageLabel.Text = "Please fill in every information correctly"; // user input has not been validated
        }
        #endregion

        #region Auxiliary Functions
        /// <summary>
        /// Function to clean user input buffers
        /// </summary>
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

        /// <summary>
        /// Fucntion to create a user profile object with user input values
        /// </summary>
        /// <returns>A user profile object with corresponding information</returns>
        private UserProfile CreateUserProfile()
        {
            UserProfile profile = new UserProfile();

            // capturing user input to store information
            profile.Username = usernameTextBox.Text;
            profile.Password = passwordTextBox.Text;
            profile.FirstName = firstNameTextBox.Text;
            profile.LastName = lastNameTextBox.Text;
            profile.Role = grantAdminCheckbox.Checked ? "Admin" : "User";
            profile.Creator = SystemResources.UserInSession.Username;

            return profile;
        }

        /// <summary>
        /// Function to prevent the creation of username with space
        /// </summary>
        /// <returns>True or False</returns>
        private bool UsernameHasEmptySpace()
        {
            bool result = false;

            string[] words = usernameTextBox.Text.Split(' '); // detecting white spaces

            if (words.Count() > 1) // if white spaces are detected the username will be split into multiple words
                result = true;

            return result;
        }

        /// <summary>
        /// Function to validate user inputs
        /// </summary>
        /// <returns>True or False</returns>
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
        #endregion
    }
}
