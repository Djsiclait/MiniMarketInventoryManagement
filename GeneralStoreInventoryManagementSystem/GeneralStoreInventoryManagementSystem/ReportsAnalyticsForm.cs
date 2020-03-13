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
using InventoryManagementBusinessLayer.ReportInformation;
using InventoryManagementEntityLayer.ReportEssentials;

namespace GeneralStoreInventoryManagementSystem
{
    public partial class ReportsAnalyticsForm : Form
    {
        UserSessionActivitiesReportTemplateForm timesheetChild; // child form to display additional information for timesheets
        UserSalesRecordsTemplateForm salesRecordChild; // child form to display additional information for sales records

        // Triggers
        int assistance = 0;
        bool requestSalesRecord = true;

        public ReportsAnalyticsForm()
        {
            InitializeComponent();
        }

        #region Load Form Logic
        private void ReportsAnalyticsForm_Load(object sender, EventArgs e)
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

            // Initializing latest date time pickers
            #region Users' Timesheet Report
            newestTimesheetDateTimePicker.Value = DateTime.Now;
            newestTimesheetDateTimePicker.MaxDate = DateTime.Today.AddDays(1);
            #endregion

            #region Users's Sales Record
            newestSalesRecordDateTimePicker.Value = DateTime.Now;
            newestSalesRecordDateTimePicker.MaxDate = DateTime.Today.AddDays(1);
            #endregion

            // Recording admin access to this form 
            SystemProtocols.ApplyActivityProtocols("REP1");
        }
        #endregion

        #region On Form Closing Override
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            // Executing correct log out processes
            SystemProtocols.ApplyLogOutProtocols();
            FormsMenuList.loginForm.Show();

            if (timesheetChild != null)
                timesheetChild.Dispose(); // disposing of child timesheet if open

            if (salesRecordChild != null)
                salesRecordChild.Dispose(); // disposing of child sales record if open

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

            if (timesheetChild != null)
                timesheetChild.Dispose(); // disposing of child timesheet if open

            if (salesRecordChild != null)
                salesRecordChild.Dispose(); // disposing of child sales record if open

            // Closing form while freeing system resources
            FormsMenuList.reportsAnalyticsForm.Dispose();
        }

        private void MakeSaleMenuSubOption_Click(object sender, EventArgs e)
        {
            // Summon Register New Sale Form
            FormsMenuList.registerNewSaleForm = new RegisterNewSaleFrom();
            FormsMenuList.registerNewSaleForm.Show();

            if (timesheetChild != null)
                timesheetChild.Dispose(); // disposing of child timesheet if open

            if (salesRecordChild != null)
                salesRecordChild.Dispose(); // disposing of child sales record if open

            // Closing form while freeing system resources
            FormsMenuList.reportsAnalyticsForm.Dispose();
        }

        private void BrowseProductsMenuSubOption_Click(object sender, EventArgs e)
        {
            // Summon Product Browser Form
            FormsMenuList.inventorySearchForm = new InventorySearchForm();
            FormsMenuList.inventorySearchForm.Show();

            if (timesheetChild != null)
                timesheetChild.Dispose(); // disposing of child timesheet if open

            if (salesRecordChild != null)
                salesRecordChild.Dispose(); // disposing of child sales record if open

            // Closing form while freeing system resources
            FormsMenuList.reportsAnalyticsForm.Dispose();
        }

        private void RegisterNewProductMenuSubOption_Click(object sender, EventArgs e)
        {
            // Summon Register New Product Form
            FormsMenuList.registerNewProduct = new RegisterNewProductForm();
            FormsMenuList.registerNewProduct.Show();

            if (timesheetChild != null)
                timesheetChild.Dispose(); // disposing of child timesheet if open

            if (salesRecordChild != null)
                salesRecordChild.Dispose(); // disposing of child sales record if open

            // Closing form while freeing system resources
            FormsMenuList.reportsAnalyticsForm.Dispose();
        }

        private void RestockProductsMenuSubOption_Click(object sender, EventArgs e)
        {
            // Summon Restock Products Form
            FormsMenuList.restockProductsFrom = new RestockProductsForm();
            FormsMenuList.restockProductsFrom.Show();

            if (timesheetChild != null)
                timesheetChild.Dispose(); // disposing of child timesheet if open

            if (salesRecordChild != null)
                salesRecordChild.Dispose(); // disposing of child sales record if open

            // Closing form while freeing system resources
            FormsMenuList.reportsAnalyticsForm.Dispose();
        }

        private void ViewUsersOption_Click(object sender, EventArgs e)
        {
            // Summon Users Registry Form
            FormsMenuList.usersRegistryForm = new UsersRegistryForm();
            FormsMenuList.usersRegistryForm.Show();

            if (timesheetChild != null)
                timesheetChild.Dispose(); // disposing of child timesheet if open

            if (salesRecordChild != null)
                salesRecordChild.Dispose(); // disposing of child sales record if open

            // Closing form while freeing system resources
            FormsMenuList.reportsAnalyticsForm.Dispose();
        }

        private void RegisterNewUserOption_Click(object sender, EventArgs e)
        {
            // Summon Register New User Form
            FormsMenuList.registerNewUserForm = new RegisterNewUserForm();
            FormsMenuList.registerNewUserForm.Show();

            if (timesheetChild != null)
                timesheetChild.Dispose(); // disposing of child timesheet if open

            if (salesRecordChild != null)
                salesRecordChild.Dispose(); // disposing of child sales record if open

            // Closing form while freeing system resources
            FormsMenuList.reportsAnalyticsForm.Dispose();
        }

        private void ViewGraphsMenuSubOption_Click(object sender, EventArgs e)
        {
            // Summon Graphs Analytics Form
            FormsMenuList.graphsAnaliticsForm = new GraphsAnalyticsForm();
            FormsMenuList.graphsAnaliticsForm.Show();

            if (timesheetChild != null)
                timesheetChild.Dispose(); // disposing of child timesheet if open

            if (salesRecordChild != null)
                salesRecordChild.Dispose(); // disposing of child sales record if open

            // Closing form while freeing system resources
            FormsMenuList.reportsAnalyticsForm.Dispose();
        }

        private void ViewActivityLogsOption_Click(object sender, EventArgs e)
        {
            // Summon Activity Logs Form
            FormsMenuList.activitiesLogForm = new ActivitiesLogForm();
            FormsMenuList.activitiesLogForm.Show();

            if (timesheetChild != null)
                timesheetChild.Dispose(); // disposing of child timesheet if open

            if (salesRecordChild != null)
                salesRecordChild.Dispose(); // disposing of child sales record if open

            // Closing form while freeing system resources
            FormsMenuList.reportsAnalyticsForm.Dispose();
        }

        private void ViewErrorLogsOption_Click(object sender, EventArgs e)
        {
            // Summon Error Logs Form
            FormsMenuList.errorsLogForm = new ErrorsLogForm();
            FormsMenuList.errorsLogForm.Show();

            if (timesheetChild != null)
                timesheetChild.Dispose(); // disposing of child timesheet if open

            if (salesRecordChild != null)
                salesRecordChild.Dispose(); // disposing of child sales record if open

            // Closing form while freeing system resources
            FormsMenuList.reportsAnalyticsForm.Dispose();
        }

        private void ViewCartLabel_Click(object sender, EventArgs e)
        {
            // Summon View Cart Form
            FormsMenuList.viewCartForm = new ViewCartForm();
            FormsMenuList.viewCartForm.Show();

            if (timesheetChild != null)
                timesheetChild.Dispose(); // disposing of child timesheet if open

            if (salesRecordChild != null)
                salesRecordChild.Dispose(); // disposing of child sales record if open

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

            if (timesheetChild != null)
                timesheetChild.Dispose(); // disposing of child timesheet if open

            if (salesRecordChild != null)
                salesRecordChild.Dispose(); // disposing of child sales record if open

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

                    if (timesheetChild != null)
                        timesheetChild.Dispose(); // disposing of child timesheet if open

                    if (salesRecordChild != null)
                        salesRecordChild.Dispose(); // disposing of child sales record if open

                    // Closing form while freeing system resources
                    FormsMenuList.reportsAnalyticsForm.Dispose();
                    #endregion

                    break;

                case Keys.F2:

                    #region Make Sales
                    // Summon Register New Sale Form
                    FormsMenuList.registerNewSaleForm = new RegisterNewSaleFrom();
                    FormsMenuList.registerNewSaleForm.Show();

                    if (timesheetChild != null)
                        timesheetChild.Dispose(); // disposing of child timesheet if open

                    if (salesRecordChild != null)
                        salesRecordChild.Dispose(); // disposing of child sales record if open

                    // Closing form while freeing system resources
                    FormsMenuList.reportsAnalyticsForm.Dispose();
                    #endregion

                    break;

                case Keys.F3:

                    #region Product Browser
                    // Summon Product Browser Form
                    FormsMenuList.inventorySearchForm = new InventorySearchForm();
                    FormsMenuList.inventorySearchForm.Show();

                    if (timesheetChild != null)
                        timesheetChild.Dispose(); // disposing of child timesheet if open

                    if (salesRecordChild != null)
                        salesRecordChild.Dispose(); // disposing of child sales record if open

                    // Closing form while freeing system resources
                    FormsMenuList.reportsAnalyticsForm.Dispose();

                    #endregion

                    break;

                case Keys.F4:

                    #region Register New Product
                    // Identifying correct protocol for current user in session
                    if (!SystemProtocols.ApplySessionsProtocols(1))
                    {
                        // Summon Register New Product Form
                        FormsMenuList.registerNewProduct = new RegisterNewProductForm();
                        FormsMenuList.registerNewProduct.Show();

                        if (timesheetChild != null)
                            timesheetChild.Dispose(); // disposing of child timesheet if open

                        if (salesRecordChild != null)
                            salesRecordChild.Dispose(); // disposing of child sales record if open

                        // Closing form while freeing system resources
                        FormsMenuList.reportsAnalyticsForm.Dispose();
                    }
                    #endregion

                    break;

                case Keys.F5:

                    #region Restock Product
                    // Identifying correct protocol for current user in session
                    if (!SystemProtocols.ApplySessionsProtocols(1))
                    {
                        // Summon Restock Products Form
                        FormsMenuList.restockProductsFrom = new RestockProductsForm();
                        FormsMenuList.restockProductsFrom.Show();

                        if (timesheetChild != null)
                            timesheetChild.Dispose(); // disposing of child timesheet if open

                        if (salesRecordChild != null)
                            salesRecordChild.Dispose(); // disposing of child sales record if open

                        // Closing form while freeing system resources
                        FormsMenuList.reportsAnalyticsForm.Dispose();
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

                        if (timesheetChild != null)
                            timesheetChild.Dispose(); // disposing of child timesheet if open

                        if (salesRecordChild != null)
                            salesRecordChild.Dispose(); // disposing of child sales record if open

                        // Closing form while freeing system resources
                        FormsMenuList.reportsAnalyticsForm.Dispose();
                    }
                    #endregion

                    break;

                case Keys.F7:

                    #region Register New User
                    // Identifying correct protocol for current user in session
                    if (!SystemProtocols.ApplySessionsProtocols(1))
                    {
                        // Summon Register New User Form
                        FormsMenuList.registerNewUserForm = new RegisterNewUserForm();
                        FormsMenuList.registerNewUserForm.Show();

                        if (timesheetChild != null)
                            timesheetChild.Dispose(); // disposing of child timesheet if open

                        if (salesRecordChild != null)
                            salesRecordChild.Dispose(); // disposing of child sales record if open

                        // Closing form while freeing system resources
                        FormsMenuList.reportsAnalyticsForm.Dispose();
                    }
                    #endregion

                    break;

                case Keys.F8:

                    #region View Graphs
                    // Identifying correct protocol for current user in session
                    if (!SystemProtocols.ApplySessionsProtocols(1))
                    {
                        // Summon Graphs Analytics Form
                        FormsMenuList.graphsAnaliticsForm = new GraphsAnalyticsForm();
                        FormsMenuList.graphsAnaliticsForm.Show();

                        if (timesheetChild != null)
                            timesheetChild.Dispose(); // disposing of child timesheet if open

                        if (salesRecordChild != null)
                            salesRecordChild.Dispose(); // disposing of child sales record if open

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
                    if (!SystemProtocols.ApplySessionsProtocols(1))
                    {
                        // Summon Activity Logs Form
                        FormsMenuList.activitiesLogForm = new ActivitiesLogForm();
                        FormsMenuList.activitiesLogForm.Show();

                        if (timesheetChild != null)
                            timesheetChild.Dispose(); // disposing of child timesheet if open

                        if (salesRecordChild != null)
                            salesRecordChild.Dispose(); // disposing of child sales record if open

                        // Closing form while freeing system resources
                        FormsMenuList.reportsAnalyticsForm.Dispose();
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

                        if (timesheetChild != null)
                            timesheetChild.Dispose(); // disposing of child timesheet if open

                        if (salesRecordChild != null)
                            salesRecordChild.Dispose(); // disposing of child sales record if open

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

                    if (timesheetChild != null)
                        timesheetChild.Dispose(); // disposing of child timesheet if open

                    if (salesRecordChild != null)
                        salesRecordChild.Dispose(); // disposing of child sales record if open

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
        private void NewestTimesheetDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            // Initializing the earliest date in the desired time interval for the timesheet tab
            oldestTimesheetDateTimePicker.MaxDate = newestTimesheetDateTimePicker.Value.AddDays(-1);
            oldestTimesheetDateTimePicker.Value = newestTimesheetDateTimePicker.Value.AddMonths(-1);
        }

        private void OldestTimesheetDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            UpdateTimesheetDataGrid(); // Requesting an update to the timesheet records
        }

        private void NewestSalesRecordDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            // Initializing the earliest date in the desired time interval for the sales tab
            oldestSalesRecordDateTimePicker.MaxDate = newestSalesRecordDateTimePicker.Value.AddDays(-1);
            oldestSalesRecordDateTimePicker.Value = newestSalesRecordDateTimePicker.Value.AddMonths(-1);
        }

        private void OldestSalesRecordDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (!requestSalesRecord)
                UpdateSalesRecordsDataGrid(); // Requesting sales records if available (only functional after the user has requested to fetch the sales records information)
        }
        #endregion

        #region Cell Double Click Logic
        private void TimeSheetDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (timesheetChild != null)
                timesheetChild.Dispose(); // disposing any previously occupied child

            if (timeSheetDataGridView.Rows.Count > 0) // proceed if at least one row exists
            {
                // Displaying detailed information
                timesheetChild = new UserSessionActivitiesReportTemplateForm(timeSheetDataGridView.SelectedCells[0].Value.ToString());
                timesheetChild.Show();
            }
            else
                MessageBox.Show("There is no available information at the moment");
        }

        private void SalesRecordsDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (salesRecordChild != null)
                salesRecordChild.Dispose(); // disposing any previously occupied child

            if (salesRecordsDataGridView.Rows.Count > 0) // proceed if at least one row exists
            {
                // Displaying detailed information
                salesRecordChild = new UserSalesRecordsTemplateForm(salesRecordsDataGridView.SelectedCells[0].Value.ToString());
                salesRecordChild.Show();
            }
            else
                MessageBox.Show("There is no available information at the moment");
        }
        #endregion

        #region Tab Enter Logic
        private void UsersSalesRecordsTabPage_Enter(object sender, EventArgs e)
        {
            // To reduce amount of information requests and memory usage the sales record tabs only fetches the information once the user requests it 
            if (requestSalesRecord)
            {
                UpdateSalesRecordsDataGrid();
                requestSalesRecord = false;
            }
        }
        #endregion

        #region Auxiliary Functions
        /// <summary>
        /// Funtion to update the timesheet data grid
        /// </summary>
        private void UpdateTimesheetDataGrid()
        {
            timeSheetDataGridView.DataSource = ReportInformationManager.ConsultTimesheetSummaryInformation(newestTimesheetDateTimePicker.Value, oldestTimesheetDateTimePicker.Value);

            timeSheetDataGridView.Columns["AverageMinutesPerSession"].Width = 150;
            timeSheetDataGridView.Columns["FullName"].Width = 150;
        }

        /// <summary>
        /// Function to update the sales records data grid
        /// </summary>
        private void UpdateSalesRecordsDataGrid()
        {
            // Initializing the grid before information is fetched
            salesRecordsDataGridView.DataSource = new List<SalesRecord>();
            salesRecordsDataGridView.Refresh();

            // Requesting sales information
            List<SalesRecord> salesRecords = ReportInformationManager.ConsultUsersSalesRecordsInformation(oldestSalesRecordDateTimePicker.Value, newestSalesRecordDateTimePicker.Value);

            // Staging the requested information 
            salesRecordsDataGridView.DataSource = salesRecords;
            salesRecordsDataGridView.Refresh();

            // Counters
            int sales = 0;
            Decimal salesTotal = 0;
            int returns = 0;
            Decimal returnsTotal = 0;

            foreach (SalesRecord record in salesRecords)
            {
                sales += record.Sales; // adding the number of sales for the current record
                salesTotal += record.SalesTotal; // adding the total dollar amount of sales for the current record
                returns += record.Returns; // adding the number of returns of the current record
                returnsTotal += record.ReturnsTotal; // adding the total dollar amount of returns fot the current record
            }

            // Publishing the records summary
            numberOfSalesLabel.Text = numberOfSalesLabel.Text.Split(':')[0] + ": " + sales;
            salesTotalLabel.Text = salesTotalLabel.Text.Split('$')[0] + "$ " + salesTotal.ToString("0.00");
            numberOfReturnsLabel.Text = numberOfReturnsLabel.Text.Split(':')[0] + ": " + returns;
            returnsTotalLabel.Text = returnsTotalLabel.Text.Split('$')[0] + "$ " + returnsTotal.ToString("0.00");
        }
        #endregion
    }
}
