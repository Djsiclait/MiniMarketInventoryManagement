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
using InventoryManagementBusinessLayer.Protocols;
using InventoryManagementBusinessLayer.ReportInformation;

namespace GeneralStoreInventoryManagementSystem
{
    public partial class ReportsAnalyticsForm : Form
    {
        UserSessionActivitiesReportTemplateForm child;

        int assistance = 0;

        public ReportsAnalyticsForm()
        {
            InitializeComponent();
        }

        #region Load Form Logic
        private void ReportsAnalyticsForm_Load(object sender, EventArgs e)
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

            newestDateTimePicker.Value = DateTime.Now;
            oldestDateTimePicker.Value = DateTime.Today.AddMonths(-1);
            oldestDateTimePicker.MaxDate = DateTime.Today.AddDays(-1);

            UpdateTimesheetDataGrid();

            SystemProtocols.ApplyActivityProtocols("REP1", null, null);
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
            FormsMenuList.reportsAnalyticsForm.Dispose();
        }
        #endregion

        #region Menu Bar Options
        private void ViewSalesMenuSubOption_Click(object sender, EventArgs e)
        {
            // Summon Sales Registry Form
            FormsMenuList.salesRecordForm = new SalesRecordForm();
            FormsMenuList.salesRecordForm.Show();

            // Closing form while freeing system resources
            FormsMenuList.reportsAnalyticsForm.Dispose();
        }

        private void MakeSaleMenuSubOption_Click(object sender, EventArgs e)
        {
            // Summon Register New Sale Form
            FormsMenuList.registerNewSaleForm = new RegisterNewSaleFrom();
            FormsMenuList.registerNewSaleForm.Show();

            // Closing form while freeing system resources
            FormsMenuList.reportsAnalyticsForm.Dispose();
        }

        private void BrowseProductsMenuSubOption_Click(object sender, EventArgs e)
        {
            // Summon Product Browser Form
            FormsMenuList.inventorySearchForm = new InventorySearchForm();
            FormsMenuList.inventorySearchForm.Show();

            // Closing form while freeing system resources
            FormsMenuList.reportsAnalyticsForm.Dispose();
        }

        private void RegisterNewProductMenuSubOption_Click(object sender, EventArgs e)
        {
            // Summon Register New Product Form
            FormsMenuList.registerNewProduct = new RegisterNewProductForm();
            FormsMenuList.registerNewProduct.Show();

            // Closing form while freeing system resources
            FormsMenuList.reportsAnalyticsForm.Dispose();
        }

        private void RestockProductsMenuSubOption_Click(object sender, EventArgs e)
        {
            // Summon Restock Products Form
            FormsMenuList.restockProductsFrom = new RestockProductsForm();
            FormsMenuList.restockProductsFrom.Show();

            // Closing form while freeing system resources
            FormsMenuList.reportsAnalyticsForm.Dispose();
        }

        private void ViewUsersOption_Click(object sender, EventArgs e)
        {
            // Summon Users Registry Form
            FormsMenuList.usersRegistryForm = new UsersRegistryForm();
            FormsMenuList.usersRegistryForm.Show();

            // Closing form while freeing system resources
            FormsMenuList.reportsAnalyticsForm.Dispose();
        }

        private void RegisterNewUserOption_Click(object sender, EventArgs e)
        {
            // Summon Register New User Form
            FormsMenuList.registerNewUserForm = new RegisterNewUserForm();
            FormsMenuList.registerNewUserForm.Show();

            // Closing form while freeing system resources
            FormsMenuList.reportsAnalyticsForm.Dispose();
        }

        private void ViewGraphsMenuSubOption_Click(object sender, EventArgs e)
        {
            // Summon Graphs Analytics Form
            FormsMenuList.graphsAnaliticsForm = new GraphsAnalyticsForm();
            FormsMenuList.graphsAnaliticsForm.Show();

            // Closing form while freeing system resources
            FormsMenuList.reportsAnalyticsForm.Dispose();
        }

        private void ViewActivityLogsOption_Click(object sender, EventArgs e)
        {
            // Summon Activity Logs Form
            FormsMenuList.activitiesLogForm = new ActivitiesLogForm();
            FormsMenuList.activitiesLogForm.Show();

            // Closing form while freeing system resources
            FormsMenuList.reportsAnalyticsForm.Dispose();
        }

        private void ViewErrorLogsOption_Click(object sender, EventArgs e)
        {
            // Summon Error Logs Form
            FormsMenuList.errorsLogForm = new ErrorsLogForm();
            FormsMenuList.errorsLogForm.Show();

            // Closing form while freeing system resources
            FormsMenuList.reportsAnalyticsForm.Dispose();
        }

        private void ViewCartLabel_Click(object sender, EventArgs e)
        {
            // Summon View Cart Form
            FormsMenuList.viewCartForm = new ViewCartForm();
            FormsMenuList.viewCartForm.Show();

            // Closing form while freeing system resources
            FormsMenuList.reportsAnalyticsForm.Dispose();
        }

        private void ViewCartLabel_MouseHover(object sender, EventArgs e)
        {
            FormsMenuList.reportsAnalyticsForm.viewCartLabel.ForeColor = Color.Blue;
        }

        private void ViewCartLabel_MouseLeave(object sender, EventArgs e)
        {
            FormsMenuList.reportsAnalyticsForm.viewCartLabel.ForeColor = Color.Black;
        }

        #region Log Out
        private void LogOutLabel_Click(object sender, EventArgs e)
        {
            // Executing correct log out processes
            SystemProtocols.ApplyLogOutProtocols();
            FormsMenuList.loginForm.Show();

            SystemProtocols.ApplyCartManagementProtocol(3, null, 0, null, 0); // clearing the cart before logging out

            // Closing form while freeing system resources
            FormsMenuList.reportsAnalyticsForm.Dispose();
        }

        private void LogOutLabel_MouseHover(object sender, EventArgs e)
        {
            FormsMenuList.reportsAnalyticsForm.logOutLabel.ForeColor = Color.Red;
        }

        private void LogOutLabel_MouseLeave(object sender, EventArgs e)
        {
            FormsMenuList.reportsAnalyticsForm.logOutLabel.ForeColor = Color.Black;
        }
        #endregion

        #endregion

        #region  Key Down Shortcut Logic
        private void ReportsAnalyticsForm_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F1:

                    #region View Sales
                    // Summon Sales Registry Form
                    FormsMenuList.salesRecordForm = new SalesRecordForm();
                    FormsMenuList.salesRecordForm.Show();

                    // Closing form while freeing system resources
                    FormsMenuList.reportsAnalyticsForm.Dispose();
                    #endregion

                    break;

                case Keys.F2:

                    #region Make Sales
                    // Summon Register New Sale Form
                    FormsMenuList.registerNewSaleForm = new RegisterNewSaleFrom();
                    FormsMenuList.registerNewSaleForm.Show();

                    // Closing form while freeing system resources
                    FormsMenuList.reportsAnalyticsForm.Dispose();
                    #endregion

                    break;

                case Keys.F3:

                    #region Product Browser
                    // Summon Product Browser Form
                    FormsMenuList.inventorySearchForm = new InventorySearchForm();
                    FormsMenuList.inventorySearchForm.Show();

                    // Closing form while freeing system resources
                    FormsMenuList.reportsAnalyticsForm.Dispose();

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
                        FormsMenuList.reportsAnalyticsForm.Dispose();
                    }
                    #endregion

                    break;

                case Keys.F5:

                    #region Restock Product
                    // Identifying correct protocol for current user in session
                    if (!SystemProtocols.ApplySessionsProtocols(1, null, null))
                    {
                        // Summon Restock Products Form
                        FormsMenuList.restockProductsFrom = new RestockProductsForm();
                        FormsMenuList.restockProductsFrom.Show();

                        // Closing form while freeing system resources
                        FormsMenuList.reportsAnalyticsForm.Dispose();
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
                        FormsMenuList.reportsAnalyticsForm.Dispose();
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
                        FormsMenuList.reportsAnalyticsForm.Dispose();
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
                        FormsMenuList.reportsAnalyticsForm.Dispose();
                    }
                    #endregion

                    break;

                case Keys.F9:

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
                            "Register New User\t(F7)\n" +
                            "View Graphs\t(F8)\n" +
                            "View Reports\t(You are here!)\n" +
                            "View Activities Log\t(F10)\n" +
                            "View Errors Log\t(F11)\n" +
                            "View Cart\t\t(F12)");

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
                        FormsMenuList.reportsAnalyticsForm.Dispose();
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
                        FormsMenuList.reportsAnalyticsForm.Dispose();
                    }
                    #endregion

                    break;

                case Keys.F12:

                    #region View Cart
                    // Summon View Cart Form
                    FormsMenuList.viewCartForm = new ViewCartForm();
                    FormsMenuList.viewCartForm.Show();

                    // Closing form while freeing system resources
                    FormsMenuList.reportsAnalyticsForm.Dispose();
                    #endregion

                    break;

                default:
                    break;
            }
        }
        #endregion

        #region Value Changed Logic
        private void newestDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            oldestDateTimePicker.Value = newestDateTimePicker.Value.AddMonths(-1);
            oldestDateTimePicker.MaxDate = newestDateTimePicker.Value.AddDays(-1);

            UpdateTimesheetDataGrid();
        }

        private void oldestDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            UpdateTimesheetDataGrid();
        }
        #endregion

        #region Cell Double Click Logic
        private void TimeSheetDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (child != null)
                child.Dispose();

            child = new UserSessionActivitiesReportTemplateForm(timeSheetDataGridView.SelectedCells[0].Value.ToString());
            child.Show();
        }
        #endregion

        #region Auxiliary Functions
        private void UpdateTimesheetDataGrid()
        {
            timeSheetDataGridView.DataSource = ReportInformationManager.ConsultTimesheetSummaryInformation(newestDateTimePicker.Value, oldestDateTimePicker.Value);

            timeSheetDataGridView.Columns["AverageMinutesPerSession"].Width = 150;
            timeSheetDataGridView.Columns["FullName"].Width = 150;
        }
        #endregion
    }
}
