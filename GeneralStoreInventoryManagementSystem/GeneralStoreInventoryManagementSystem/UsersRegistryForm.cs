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

namespace GeneralStoreInventoryManagementSystem
{
    public partial class UsersRegistryForm : Form
    {
        int assistance = 0;

        public UsersRegistryForm()
        {
            InitializeComponent();
        }

        #region Load Form Logic
        private void UsersRegistryForm_Load(object sender, EventArgs e)
        {
            // Identifying correct protocol for current user in session
            if (SystemProtocols.ApplySessionsProtocols(1, null, null))
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

            PopulateUserResigtryDataGrid();

            // Executing correct activity according to given code
            SystemProtocols.ApplyActivityProtocols("USE1", null, null);

            PopulateActicityListDataGrid();
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
            FormsMenuList.usersRegistryForm.Dispose();
        }
        #endregion

        #region Menu Bar Options
        private void ViewSalesMenuSubOption_Click(object sender, EventArgs e)
        {
            // Summon Sales Registry Form
            FormsMenuList.salesRecordForm = new SalesRecordForm();
            FormsMenuList.salesRecordForm.Show();

            // Closing form while freeing system resources
            FormsMenuList.usersRegistryForm.Dispose();
        }

        private void MakeSaleMenuSubOption_Click(object sender, EventArgs e)
        {
            // Summon Register New Sale Form
            FormsMenuList.registerNewSaleForm = new RegisterNewSaleFrom();
            FormsMenuList.registerNewSaleForm.Show();

            // Closing form while freeing system resources
            FormsMenuList.usersRegistryForm.Dispose();
        }

        private void BrowseProductsMenuSubOption_Click(object sender, EventArgs e)
        {
            // Summon Product Browser Form
            FormsMenuList.inventorySearchForm = new InventorySearchForm();
            FormsMenuList.inventorySearchForm.Show();

            // Closing form while freeing system resources
            FormsMenuList.usersRegistryForm.Dispose();
        }

        private void RegisterNewProductMenuSubOption_Click(object sender, EventArgs e)
        {
            // Summon Register New Product Form
            FormsMenuList.registerNewProduct = new RegisterNewProductForm();
            FormsMenuList.registerNewProduct.Show();

            // Closing form while freeing system resources
            FormsMenuList.usersRegistryForm.Dispose();
        }

        private void RestockProductsMenuSubOption_Click(object sender, EventArgs e)
        {
            // Summon Restock Products Form
            FormsMenuList.restockProductsFrom = new RestockProductsForm();
            FormsMenuList.restockProductsFrom.Show();

            // Closing form while freeing system resources
            FormsMenuList.usersRegistryForm.Dispose();
        }

        private void RegisterNewUserMenuSubOption_Click(object sender, EventArgs e)
        {
            // Summon Register New User Form
            FormsMenuList.registerNewUserForm = new RegisterNewUserForm();
            FormsMenuList.registerNewUserForm.Show();

            // Closing form while freeing system resources
            FormsMenuList.usersRegistryForm.Dispose();
        }

        private void ViewGraphsOption_Click(object sender, EventArgs e)
        {
            // Summon Graphs Analytics Form
            FormsMenuList.graphsAnaliticsForm = new GraphsAnalyticsForm();
            FormsMenuList.graphsAnaliticsForm.Show();

            // Closing form while freeing system resources
            FormsMenuList.usersRegistryForm.Dispose();
        }

        private void ViewReportsOption_Click(object sender, EventArgs e)
        {
            // Summon Reports Analytics Form
            FormsMenuList.reportsAnalyticsForm = new ReportsAnalyticsForm();
            FormsMenuList.reportsAnalyticsForm.Show();

            // Closing form while freeing system resources
            FormsMenuList.usersRegistryForm.Dispose();
        }

        private void ViewActivityLogsOption_Click(object sender, EventArgs e)
        {
            // Summon Activity Logs Form
            FormsMenuList.activitiesLogForm = new ActivitiesLogForm();
            FormsMenuList.activitiesLogForm.Show();

            // Closing form while freeing system resources
            FormsMenuList.usersRegistryForm.Dispose();
        }

        private void ViewErrorLogsOption_Click(object sender, EventArgs e)
        {
            // Summon Error Logs Form
            FormsMenuList.errorsLogForm = new ErrorsLogForm();
            FormsMenuList.errorsLogForm.Show();

            // Closing form while freeing system resources
            FormsMenuList.usersRegistryForm.Dispose();
        }

        private void ViewCartLabel_Click(object sender, EventArgs e)
        {
            // Summon View Cart Form
            FormsMenuList.viewCartForm = new ViewCartForm();
            FormsMenuList.viewCartForm.Show();

            // Closing form while freeing system resources
            FormsMenuList.usersRegistryForm.Dispose();
        }

        private void ViewCartLabel_MouseHover(object sender, EventArgs e)
        {
            FormsMenuList.usersRegistryForm.viewCartLabel.ForeColor = Color.Blue;
        }

        private void ViewCartLabel_MouseLeave(object sender, EventArgs e)
        {
            FormsMenuList.usersRegistryForm.viewCartLabel.ForeColor = Color.Black;
        }

        #region Log Out
        private void LogOutLabel_Click(object sender, EventArgs e)
        {
            // Executing correct log out processes
            SystemProtocols.ApplyLogOutProtocols();
            FormsMenuList.loginForm.Show();

            SystemProtocols.ApplyCartManagementProtocol(3, null, 0, null, 0); // clearing the cart before logging out

            // Closing form while freeing system resources
            FormsMenuList.usersRegistryForm.Dispose();
        }

        private void LogOutLabel_MouseHover(object sender, EventArgs e)
        {
            FormsMenuList.usersRegistryForm.LogOutLabel.ForeColor = Color.Red;
        }

        private void LogOutLabel_MouseLeave(object sender, EventArgs e)
        {
            FormsMenuList.usersRegistryForm.LogOutLabel.ForeColor = Color.Black;
        }
        #endregion

        #endregion

        #region  Key Down Shortcut Logic
        private void UsersRegistryForm_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F1:

                    #region View Sales
                    // Summon Sales Registry Form
                    FormsMenuList.salesRecordForm = new SalesRecordForm();
                    FormsMenuList.salesRecordForm.Show();

                    // Closing form while freeing system resources
                    FormsMenuList.usersRegistryForm.Dispose();
                    #endregion

                    break;

                case Keys.F2:

                    #region Make Sales
                    // Summon Register New Sale Form
                    FormsMenuList.registerNewSaleForm = new RegisterNewSaleFrom();
                    FormsMenuList.registerNewSaleForm.Show();

                    // Closing form while freeing system resources
                    FormsMenuList.usersRegistryForm.Dispose();
                    #endregion

                    break;

                case Keys.F3:

                    #region Product Browser
                    // Summon Product Browser Form
                    FormsMenuList.inventorySearchForm = new InventorySearchForm();
                    FormsMenuList.inventorySearchForm.Show();

                    // Closing form while freeing system resources
                    FormsMenuList.usersRegistryForm.Dispose();
                    #endregion

                    break;

                case Keys.F4:

                    #region Register New Product
                    // Identifying correct protocol for current user in session
                    if (!SystemProtocols.ApplySessionsProtocols(1, null, null))
                    {
                        // Summon Register New Product Form
                        FormsMenuList.registerNewProduct = new RegisterNewProductForm();
                        FormsMenuList.registerNewProduct.Show();

                        // Closing form while freeing system resources
                        FormsMenuList.usersRegistryForm.Dispose();
                    }
                    #endregion

                    break;

                case Keys.F5:

                    #region Restock Products
                    // Identifying correct protocol for current user in session
                    if (!SystemProtocols.ApplySessionsProtocols(1, null, null))
                    {
                        // Summon Restock Products Form
                        FormsMenuList.restockProductsFrom = new RestockProductsForm();
                        FormsMenuList.restockProductsFrom.Show();

                        // Closing form while freeing system resources
                        FormsMenuList.usersRegistryForm.Dispose();
                    }
                    #endregion

                    break;

                case Keys.F6:

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
                            "View Users\t(You are here!)\n" +
                            "Register New User\t(F7)\n" +
                            "View Graphs\t(F8)\n" +
                            "View Reports\t(F9)\n" +
                            "View Activities Log\t(F10)\n" +
                            "View Errors Log\t(F11)\n" +
                            "View Cart\t\t(F12)");

                    break;

                case Keys.F7:

                    #region Register New User
                    // Identifying correct protocol for current user in session
                    if (!SystemProtocols.ApplySessionsProtocols(1, null, null))
                    {
                        // Summon Register New User Form
                        FormsMenuList.registerNewUserForm = new RegisterNewUserForm();
                        FormsMenuList.registerNewUserForm.Show();

                        // Closing form while freeing system resources
                        FormsMenuList.usersRegistryForm.Dispose();
                    }
                    #endregion

                    break;

                case Keys.F8:

                    #region View Graphs
                    // Identifying correct protocol for current user in session
                    if (!SystemProtocols.ApplySessionsProtocols(1, null, null))
                    {
                        // Summon Graphs Analytics Form
                        FormsMenuList.graphsAnaliticsForm = new GraphsAnalyticsForm();
                        FormsMenuList.graphsAnaliticsForm.Show();

                        // Closing form while freeing system resources
                        FormsMenuList.usersRegistryForm.Dispose();
                    }
                    #endregion

                    break;

                case Keys.F9:

                    #region View Reports
                    // Identifying correct protocol for current user in session
                    if (!SystemProtocols.ApplySessionsProtocols(1, null, null))
                    {
                        // Summon Reports Analytics Form
                        FormsMenuList.reportsAnalyticsForm = new ReportsAnalyticsForm();
                        FormsMenuList.reportsAnalyticsForm.Show();

                        // Closing form while freeing system resources
                        FormsMenuList.usersRegistryForm.Dispose();
                    }
                    #endregion

                    break;

                case Keys.F10:

                    #region View Activities Log
                    // Identifying correct protocol for current user in session
                    if (!SystemProtocols.ApplySessionsProtocols(1, null, null))
                    {
                        // Summon Activity Logs Form
                        FormsMenuList.activitiesLogForm = new ActivitiesLogForm();
                        FormsMenuList.activitiesLogForm.Show();

                        // Closing form while freeing system resources
                        FormsMenuList.usersRegistryForm.Dispose();
                    }
                    #endregion

                    break;

                case Keys.F11:

                    #region View Errors Log
                    // Identifying correct protocol for current user in session
                    if (!SystemProtocols.ApplySessionsProtocols(1, null, null))
                    {
                        // Summon Error Logs Form
                        FormsMenuList.errorsLogForm = new ErrorsLogForm();
                        FormsMenuList.errorsLogForm.Show();

                        // Closing form while freeing system resources
                        FormsMenuList.usersRegistryForm.Dispose();
                    }
                    #endregion

                    break;

                case Keys.F12:

                    #region View Cart
                    // Summon View Cart Form
                    FormsMenuList.viewCartForm = new ViewCartForm();
                    FormsMenuList.viewCartForm.Show();

                    // Closing form while freeing system resources
                    FormsMenuList.usersRegistryForm.Dispose();
                    #endregion

                    break;

                default:
                    break;
            }
        }
        #endregion

        #region Text Changed Logic
        private void UserSearchBox_TextChanged(object sender, EventArgs e)
        {
            PopulateUserResigtryDataGrid(); // REMINDER, to search for active and inactive users use 0, 1, etc.
        }

        private void activitySearchBox_TextChanged(object sender, EventArgs e)
        {
            PopulateActicityListDataGrid();
        }
        #endregion

        #region Button Click Logic
        private void ProfileButton_Click(object sender, EventArgs e)
        {
            UserInformationTemplateForm userInformationForm = new UserInformationTemplateForm(SystemResources.UserInSession.Username);
            userInformationForm.Show();
        }
        #endregion

        #region Cell Double Click Logic
        private void UserList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            UserInformationTemplateForm userInformationForm = new UserInformationTemplateForm(userList.SelectedCells[0].Value.ToString());
            userInformationForm.Show();
        }
        #endregion

        #region Auxiliary Functions
        /// <summary>
        /// Fucntion to populate the user registry data grid
        /// </summary>
        private void PopulateUserResigtryDataGrid()
        {
            // Requestion information to fill data grid
            userList.DataSource = UserInformationManager.ConsultUserListInformation(userSearchBox.Text);

            // Hiding unnecessary fields
            userList.Columns["Password"].Visible = false;
            userList.Columns["Creator"].Visible = false;
            userList.Columns["RegistrationDate"].Visible = false;

            // Modifying data grid
            userList.Columns["Status"].Width = 70;
            userList.Columns["LastLogin"].Width = 130;
        }

        /// <summary>
        /// Function to populate the activity log for the last 24 hours
        /// </summary>
        private void PopulateActicityListDataGrid()
        {
            // Requesting information to fill activity log data grid
            activityList.DataSource = ActivityInformationManager.ConsultActivityListInformation(activitySearchBox.Text, true);

            // Modifying data grid
            activityList.Columns["Description"].Width = 450;
            activityList.Columns["Type"].Width = 200;
            activityList.Columns["Timestamp"].Width = 200;
        }

        /// <summary>
        /// Function to refres all data grid in the form
        /// </summary>
        public void RefreshDatagridInformation()
        {
            PopulateUserResigtryDataGrid();
            PopulateActicityListDataGrid();
        }
        #endregion
    }
}
