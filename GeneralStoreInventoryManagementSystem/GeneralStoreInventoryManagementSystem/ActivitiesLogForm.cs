using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Custom Library
using InventoryManagementBusinessLayer.ActivityInformation;
using InventoryManagementBusinessLayer.Protocols;

namespace GeneralStoreInventoryManagementSystem
{
    public partial class ActivitiesLogForm : Form
    {
        public ActivitiesLogForm()
        {
            InitializeComponent();
        }

        #region Load Logic Form
        private void ActivitiesLogForm_Load(object sender, EventArgs e)
        {
            // Limiting option according to current user's access level
            if (SystemProtocols.ApplySessionsProtocols(1, null, null))
            {
                // Disabling the entire Products option given the remainder of options are prohibited for a basic user
                registerNewProductMenuSubOption.Visible = false;
                registerNewProductMenuSubOption.Enabled = false;
                restockProductsMenuSubOption.Visible = false;
                restockProductsMenuSubOption.Enabled = false;

                // Disabling all admin options
                adminMenuOption.Visible = false;
                adminMenuOption.Enabled = false;
            }

            // Executing correct activity according to given code
            SystemProtocols.ApplyActivityProtocols("ACT1", null, null);

            PopulateActivityListDataGrid();
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
            FormsMenuList.activitiesLogForm.Dispose();
        }
        #endregion

        #region Menu Bar Options
        private void ViewSalesMenuSubOption_Click(object sender, EventArgs e)
        {
            // Summon Sales Registry Form
            FormsMenuList.salesRecordForm = new SalesRecordForm();
            FormsMenuList.salesRecordForm.Show();

            // Closing form while freeing system resources
            FormsMenuList.activitiesLogForm.Dispose();
        }

        private void MakeSaleMenuSubOption_Click(object sender, EventArgs e)
        {
            // Summon Register New Sale Form
            FormsMenuList.registerNewSaleForm = new RegisterNewSaleFrom();
            FormsMenuList.registerNewSaleForm.Show();

            // Closing form while freeing system resources
            FormsMenuList.activitiesLogForm.Dispose();
        }

        private void BrowseProductsMenuSubOption_Click(object sender, EventArgs e)
        {
            // Summon Product Browser Form
            FormsMenuList.inventorySearchForm = new InventorySearchForm();
            FormsMenuList.inventorySearchForm.Show();

            // Closing form while freeing system resources
            FormsMenuList.activitiesLogForm.Dispose();
        }

        private void RegisterNewProductMenuSubOption_Click(object sender, EventArgs e)
        {
            // Summon Register New Product Form
            FormsMenuList.registerNewProduct = new RegisterNewProductForm();
            FormsMenuList.registerNewProduct.Show();

            // Closing form while freeing system resources
            FormsMenuList.activitiesLogForm.Dispose();
        }

        private void RestockProductsMenuSubOption_Click(object sender, EventArgs e)
        {
            // Summon Restock Products Form
            FormsMenuList.restockProductsFrom = new RestockProductsForm();
            FormsMenuList.restockProductsFrom.Show();

            // Closing form while freeing system resources
            FormsMenuList.activitiesLogForm.Dispose();
        }

        private void ViewUsersOption_Click(object sender, EventArgs e)
        {
            // Summon Users Registry Form
            FormsMenuList.usersRegistryForm = new UsersRegistryForm();
            FormsMenuList.usersRegistryForm.Show();

            // Closing form while freeing system resources
            FormsMenuList.activitiesLogForm.Dispose();
        }

        private void RegisterNewUserOption_Click(object sender, EventArgs e)
        {
            // Summon Register New User Form
            FormsMenuList.registerNewUserForm = new RegisterNewUserForm();
            FormsMenuList.registerNewUserForm.Show();

            // Closing form while freeing system resources
            FormsMenuList.activitiesLogForm.Dispose();
        }

        private void ViewGraphsOption_Click(object sender, EventArgs e)
        {
            // Summon Graphs Analytics Form
            FormsMenuList.graphsAnaliticsForm = new GraphsAnalyticsForm();
            FormsMenuList.graphsAnaliticsForm.Show();

            // Closing form while freeing system resources
            FormsMenuList.activitiesLogForm.Dispose();
        }

        private void ViewReportsOption_Click(object sender, EventArgs e)
        {
            // Summon Reports Analytics Form
            FormsMenuList.reportsAnalyticsForm = new ReportsAnalyticsForm();
            FormsMenuList.reportsAnalyticsForm.Show();

            // Closing form while freeing system resources
            FormsMenuList.activitiesLogForm.Dispose();
        }

        private void ViewErrorLogsMenuSubOption_Click(object sender, EventArgs e)
        {
            // Summon Error Logs Form
            FormsMenuList.errorsLogForm = new ErrorsLogForm();
            FormsMenuList.errorsLogForm.Show();

            // Closing form while freeing system resources
            FormsMenuList.activitiesLogForm.Dispose();
        }

        private void ViewCartLabel_Click(object sender, EventArgs e)
        {
            // Summon View Cart Form
            FormsMenuList.viewCartForm = new ViewCartForm();
            FormsMenuList.viewCartForm.Show();

            // Closing form while freeing system resources
            FormsMenuList.activitiesLogForm.Dispose();
        }

        private void ViewCartLabel_MouseHover(object sender, EventArgs e)
        {
            FormsMenuList.activitiesLogForm.viewCartLabel.ForeColor = Color.Blue;
        }

        private void ViewCartLabel_MouseLeave(object sender, EventArgs e)
        {
            FormsMenuList.activitiesLogForm.viewCartLabel.ForeColor = Color.Black;
        }

        #region Log Out
        private void LogOutLabel_Click(object sender, EventArgs e)
        {
            // Executing correct log out processes
            SystemProtocols.ApplyLogOutProtocols();
            FormsMenuList.loginForm.Show();

            SystemProtocols.ApplyCartManagementProtocol(3, null, 0, null, 0); // clearing the cart before logging out

            // Closing form while freeing system resources
            FormsMenuList.activitiesLogForm.Dispose();
        }

        private void LogOutLabel_MouseHover(object sender, EventArgs e)
        {
            FormsMenuList.activitiesLogForm.logOutLabel.ForeColor = Color.Red;
        }

        private void LogOutLabel_MouseLeave(object sender, EventArgs e)
        {
            FormsMenuList.activitiesLogForm.logOutLabel.ForeColor = Color.Black;
        }
        #endregion

        #endregion

        #region Key Down Logic
        private void ActivitySearchBox_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F1:

                    #region View Sales
                    // Summon Sales Registry Form
                    FormsMenuList.salesRecordForm = new SalesRecordForm();
                    FormsMenuList.salesRecordForm.Show();

                    // Closing form while freeing system resources
                    FormsMenuList.activitiesLogForm.Dispose();
                    #endregion

                    break;

                case Keys.F2:

                    #region Make Sales
                    // Summon Register New Sale Form
                    FormsMenuList.registerNewSaleForm = new RegisterNewSaleFrom();
                    FormsMenuList.registerNewSaleForm.Show();

                    // Closing form while freeing system resources
                    FormsMenuList.activitiesLogForm.Dispose();
                    #endregion

                    break;

                case Keys.F3:

                    #region Product Browser
                    // Summon Product Browser Form
                    FormsMenuList.inventorySearchForm = new InventorySearchForm();
                    FormsMenuList.inventorySearchForm.Show();

                    // Closing form while freeing system resources
                    FormsMenuList.activitiesLogForm.Dispose();
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
                        FormsMenuList.activitiesLogForm.Dispose();
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
                        FormsMenuList.activitiesLogForm.Dispose();
                    }
                    #endregion

                    break;

                case Keys.F6:

                    #region View Users
                    // Identifying correct protocol for current user in session
                    if (!SystemProtocols.ApplySessionsProtocols(1, null, null))
                    {
                        // Summon Users Registry Form
                        FormsMenuList.usersRegistryForm = new UsersRegistryForm();
                        FormsMenuList.usersRegistryForm.Show();

                        // Closing form while freeing system resources
                        FormsMenuList.activitiesLogForm.Dispose();
                    }
                    #endregion

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
                        FormsMenuList.activitiesLogForm.Dispose();
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
                        FormsMenuList.activitiesLogForm.Dispose();
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
                        FormsMenuList.activitiesLogForm.Dispose();
                    }
                    #endregion

                    break;

                case Keys.F10:

                    // The user is already viewing the desired page

                    break;

                case Keys.F11:

                    #region Errors Log
                    // Identifying correct protocol for current user in session
                    if (!SystemProtocols.ApplySessionsProtocols(1, null, null))
                    {
                        // Summon Error Logs Form
                        FormsMenuList.errorsLogForm = new ErrorsLogForm();
                        FormsMenuList.errorsLogForm.Show();

                        // Closing form while freeing system resources
                        FormsMenuList.activitiesLogForm.Dispose();
                    }
                    #endregion

                    break;

                case Keys.F12:

                    #region View Cart
                    // Summon View Cart Form
                    FormsMenuList.viewCartForm = new ViewCartForm();
                    FormsMenuList.viewCartForm.Show();

                    // Closing form while freeing system resources
                    FormsMenuList.activitiesLogForm.Dispose();
                    #endregion

                    break;

                default:
                    break;
            }
        }
        #endregion

        #region Text Changed Logic
        private void ActivitySearchBox_TextChanged(object sender, EventArgs e)
        {
            PopulateActivityListDataGrid();
        }
        #endregion

        #region Auxiliary Function
        /// <summary>
        /// Function to populate the activity log
        /// </summary>
        private void PopulateActivityListDataGrid()
        {
            // Requesting information to populate the activities log
            activityList.DataSource = ActivityInformationManager.ConsultActivityListInformation(activitySearchBox.Text, false);

            // Hiding unnecessary fields
            activityList.Columns["Description"].Width = 550;
            activityList.Columns["Timestamp"].Width = 200;
        }
        #endregion
    }
}
