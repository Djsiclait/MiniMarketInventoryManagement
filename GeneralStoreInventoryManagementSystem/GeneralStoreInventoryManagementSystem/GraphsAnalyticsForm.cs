using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

// Custom Library
using InventoryManagementBusinessLayer.GraphInformation;
using InventoryManagementBusinessLayer.Protocols;
using InventoryManagementEntityLayer.GraphEssentials;

namespace GeneralStoreInventoryManagementSystem
{
    public partial class GraphsAnalyticsForm : Form
    {
        int assistance = 0;

        public GraphsAnalyticsForm()
        {
            InitializeComponent();
        }

        #region Load Form Logic
        private void GraphsAnalyticsForm_Load(object sender, EventArgs e)
        {
            // Identifying correct protocol for current user in session
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

            SystemProtocols.ApplyActivityProtocols("GRA1", null, null);

            missingMessageLabel.Visible = false;
            shownMessageLabel.Visible = false;

            timeComboBox.Items.Add("24 hours");
            timeComboBox.Items.Add("72 hours");
            timeComboBox.Items.Add("week");
            timeComboBox.Items.Add("2 weeks");
            timeComboBox.Items.Add("month");
            timeComboBox.Items.Add("2 months");
            timeComboBox.SelectedIndex = 0;

            PopulateUsernameTimesheetListBox();
            PopulateUsernameSalesListBox();

            newestBubbleDateTimePicker.Value = DateTime.Now;
            newestBubbleDateTimePicker.MaxDate = DateTime.Today.AddDays(1);
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
            FormsMenuList.graphsAnaliticsForm.Dispose();
        }
        #endregion

        #region Menu Bar Options
        private void ViewSalesMenuSubOption_Click(object sender, EventArgs e)
        {
            // Summon Sales Registry Form
            FormsMenuList.salesRecordForm = new SalesRecordForm();
            FormsMenuList.salesRecordForm.Show();

            // Closing form while freeing system resources
            FormsMenuList.graphsAnaliticsForm.Dispose();
        }

        private void MakeSaleMenuSubOption_Click(object sender, EventArgs e)
        {
            // Summon Register New Sale Form
            FormsMenuList.registerNewSaleForm = new RegisterNewSaleFrom();
            FormsMenuList.registerNewSaleForm.Show();

            // Closing form while freeing system resources
            FormsMenuList.graphsAnaliticsForm.Dispose();
        }

        private void BrowseProductsMenuSubOption_Click(object sender, EventArgs e)
        {
            // Summon Product Browser Form
            FormsMenuList.inventorySearchForm = new InventorySearchForm();
            FormsMenuList.inventorySearchForm.Show();

            // Closing form while freeing system resources
            FormsMenuList.graphsAnaliticsForm.Dispose();
        }

        private void RegisterNewProductMenuSubOption_Click(object sender, EventArgs e)
        {
            // Summon Register New Product Form
            FormsMenuList.registerNewProduct = new RegisterNewProductForm();
            FormsMenuList.registerNewProduct.Show();

            // Closing form while freeing system resources
            FormsMenuList.graphsAnaliticsForm.Dispose();
        }

        private void RestockProductsMenuSubOption_Click(object sender, EventArgs e)
        {
            // Summon Restock Products Form
            FormsMenuList.restockProductsFrom = new RestockProductsForm();
            FormsMenuList.restockProductsFrom.Show();

            // Closing form while freeing system resources
            FormsMenuList.graphsAnaliticsForm.Dispose();
        }

        private void ViewUsersOption_Click(object sender, EventArgs e)
        {
            // Summon Users Registry Form
            FormsMenuList.usersRegistryForm = new UsersRegistryForm();
            FormsMenuList.usersRegistryForm.Show();

            // Closing form while freeing system resources
            FormsMenuList.graphsAnaliticsForm.Dispose();
        }

        private void RegisterNewUserOption_Click(object sender, EventArgs e)
        {
            // Summon Register New User Form
            FormsMenuList.registerNewUserForm = new RegisterNewUserForm();
            FormsMenuList.registerNewUserForm.Show();

            // Closing form while freeing system resources
            FormsMenuList.graphsAnaliticsForm.Dispose();
        }

        private void ViewReportsMenuSubOption_Click(object sender, EventArgs e)
        {
            // Summon Reports Analytics Form
            FormsMenuList.reportsAnalyticsForm = new ReportsAnalyticsForm();
            FormsMenuList.reportsAnalyticsForm.Show();

            // Closing form while freeing system resources
            FormsMenuList.graphsAnaliticsForm.Dispose();
        }

        private void ViewActivityLogsOption_Click(object sender, EventArgs e)
        {
            // Summon Activity Logs Form
            FormsMenuList.activitiesLogForm = new ActivitiesLogForm();
            FormsMenuList.activitiesLogForm.Show();

            // Closing form while freeing system resources
            FormsMenuList.graphsAnaliticsForm.Dispose();
        }

        private void ViewErrorLogsOption_Click(object sender, EventArgs e)
        {
            // Summon Error Logs Form
            FormsMenuList.errorsLogForm = new ErrorsLogForm();
            FormsMenuList.errorsLogForm.Show();

            // Closing form while freeing system resources
            FormsMenuList.graphsAnaliticsForm.Dispose();
        }

        private void ViewCartLabel_Click(object sender, EventArgs e)
        {
            // Summon View Cart Form
            FormsMenuList.viewCartForm = new ViewCartForm();
            FormsMenuList.viewCartForm.Show();

            // Closing form while freeing system resources
            FormsMenuList.graphsAnaliticsForm.Dispose();
        }

        private void ViewCartLabel_MouseHover(object sender, EventArgs e)
        {
            FormsMenuList.graphsAnaliticsForm.viewCartLabel.ForeColor = Color.Blue;
        }

        private void ViewCartLabel_MouseLeave(object sender, EventArgs e)
        {
            FormsMenuList.graphsAnaliticsForm.viewCartLabel.ForeColor = Color.Black;
        }

        #region Log Out
        private void LogOutLabel_Click(object sender, EventArgs e)
        {
            // Executing correct log out processes
            SystemProtocols.ApplyLogOutProtocols();
            FormsMenuList.loginForm.Show();

            SystemProtocols.ApplyCartManagementProtocol(3, null, 0, null, 0); // clearing the cart before logging out

            // Closing form while freeing system resources
            FormsMenuList.graphsAnaliticsForm.Dispose();
        }

        private void LogOutLabel_MouseHover(object sender, EventArgs e)
        {
            FormsMenuList.graphsAnaliticsForm.logOutLabel.ForeColor = Color.Red;
        }

        private void LogOutLabel_MouseLeave(object sender, EventArgs e)
        {
            FormsMenuList.graphsAnaliticsForm.logOutLabel.ForeColor = Color.Black;
        }
        #endregion

        #endregion

        #region Key Down Shortcut Logic
        // POSSIBLY SUBJECT TO CHANGE DUE TO FUTURE DESIGNS
        private void GraphsAnalyticsForm_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F1:

                    #region View Sales
                    // Summon Sales Registry Form
                    FormsMenuList.salesRecordForm = new SalesRecordForm();
                    FormsMenuList.salesRecordForm.Show();

                    // Closing form while freeing system resources
                    FormsMenuList.graphsAnaliticsForm.Dispose();
                    #endregion

                    break;

                case Keys.F2:

                    #region Make Sales
                    // Summon Register New Sale Form
                    FormsMenuList.registerNewSaleForm = new RegisterNewSaleFrom();
                    FormsMenuList.registerNewSaleForm.Show();

                    // Closing form while freeing system resources
                    FormsMenuList.graphsAnaliticsForm.Dispose();
                    #endregion

                    break;

                case Keys.F3:

                    #region Product Browser
                    // Summon Product Browser Form
                    FormsMenuList.inventorySearchForm = new InventorySearchForm();
                    FormsMenuList.inventorySearchForm.Show();

                    // Closing form while freeing system resources
                    FormsMenuList.graphsAnaliticsForm.Dispose();
                    #endregion

                    break;

                case Keys.F4:

                    #region Register New User
                    // Identifying correct protocol for current user in session
                    if (!SystemProtocols.ApplySessionsProtocols(1, null, null))
                    {
                        // Summon Register New Product Form
                        FormsMenuList.registerNewProduct = new RegisterNewProductForm();
                        FormsMenuList.registerNewProduct.Show();

                        // Closing form while freeing system resources
                        FormsMenuList.graphsAnaliticsForm.Dispose();
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
                        FormsMenuList.graphsAnaliticsForm.Dispose();
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
                        FormsMenuList.graphsAnaliticsForm.Dispose();
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
                        FormsMenuList.graphsAnaliticsForm.Dispose();
                    }
                    #endregion

                    break;

                case Keys.F8:

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
                            "View Graphs\t(You are here!)\n" +
                            "View Reports\t(F9)\n" +
                            "View Activities Log\t(F10)\n" +
                            "View Errors Log\t(F11)\n" +
                            "View Cart\t\t(F12)");

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
                        FormsMenuList.graphsAnaliticsForm.Dispose();
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
                        FormsMenuList.graphsAnaliticsForm.Dispose();
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
                        FormsMenuList.graphsAnaliticsForm.Dispose();
                    }
                    #endregion

                    break;

                case Keys.F12:

                    #region View Cart
                    // Summon View Cart Form
                    FormsMenuList.viewCartForm = new ViewCartForm();
                    FormsMenuList.viewCartForm.Show();

                    // Closing form while freeing system resources
                    FormsMenuList.graphsAnaliticsForm.Dispose();
                    #endregion

                    break;

                default:
                    break;
            }
        }
        #endregion

        #region Text Changed Logic
        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            PopulateUsernameTimesheetListBox();
        }

        private void SearchSalesTextBox_TextChanged(object sender, EventArgs e)
        {
            PopulateUsernameSalesListBox();
        }
        #endregion

        #region Value Changed Logic
        private void NewestBubbleDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (usernamesTimesheetListBox.Items.Count > 0)
                GenerateTimesheetBubbleChart();
        }

        private void TimeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (usernamesTimesheetListBox.Items.Count > 0)
                GenerateTimesheetBubbleChart();
        }
        #endregion

        #region List Box Click Logic
        private void UsernamesListBox_Click(object sender, EventArgs e)
        {
            GenerateTimesheetBubbleChart();
        }
        #endregion

        #region Message Labels Logic
        private void MissingLabel_MouseHover(object sender, EventArgs e)
        {
            missingMessageLabel.Visible = true;
        }

        private void MissingLabel_MouseLeave(object sender, EventArgs e)
        {
            missingMessageLabel.Visible = false;
        }

        private void shownLabel_MouseHover(object sender, EventArgs e)
        {
            shownMessageLabel.Visible = true;
        }

        private void shownLabel_MouseLeave(object sender, EventArgs e)
        {
            shownMessageLabel.Visible = false;
        }
        #endregion

        #region Auxiliary Functions
        private void PopulateUsernameTimesheetListBox()
        {
            usernamesTimesheetListBox.DataSource = GraphInformationManager.ConsultAllRegisteredUsernameInformation(searchTimesheetTextBox.Text);
        }

        private void PopulateUsernameSalesListBox()
        {
            usernamesSalesListBox.DataSource = GraphInformationManager.ConsultAllRegisteredUsernameInformation(searchSalesTextBox.Text);
        }

        private void GenerateTimesheetBubbleChart()
        {
            if (usernamesTimesheetListBox.SelectedItem.ToString() == "ALL")
            {
                // TODO: Generate multi series timesheet
                timesheetChart.Series.Clear();

                int totalSessions = 0;
                int shownSessions = 0;
                int missingSessions = 0;

                foreach (String username in usernamesTimesheetListBox.Items)
                {
                    if (username != "ALL")
                    {
                        List<BubblePoint> bubblePoints = GraphInformationManager.ConsultUserTimesheetBubbleChartInformation(username, newestBubbleDateTimePicker.Value, CalculateOldestDate());

                        if (bubblePoints.Count > 0)
                        {
                            timesheetChart.Series.Add(username); // Creating the series
                            timesheetChart.Series[username].ChartType = SeriesChartType.Bubble;
                            timesheetChart.Series[username].MarkerStyle = MarkerStyle.Circle;
                            timesheetChart.ChartAreas["BubbleChartArea"].AxisX.Title = "Date";
                            timesheetChart.ChartAreas["BubbleChartArea"].AxisY.Title = "Hours of the Day";
                            timesheetChart.ChartAreas["BubbleChartArea"].AxisY.LabelStyle.Format = "00H";
                            timesheetChart.ChartAreas["BubbleChartArea"].AxisY.Minimum = 0;
                            timesheetChart.ChartAreas["BubbleChartArea"].AxisY.Maximum = 24;

                            // Adding points
                            foreach (BubblePoint bubble in bubblePoints)
                            {
                                totalSessions++;

                                if (bubble.Minutes > 0)
                                {
                                    int position = timesheetChart.Series[username].Points.AddXY(
                                        DateTime.Parse(bubble.LogInDate),
                                        FormatToInt(bubble.LogInTime.Split(':')[0]),
                                        bubble.Seconds);

                                    //timesheetChart.Series[username].Points[position].Label = bubble.Minutes.ToString("0.####") + " min";

                                    shownSessions++;
                                }
                                else
                                    missingSessions++;
                            }

                            // adding invisible ancor point
                            int i = timesheetChart.Series[username].Points.AddXY(newestBubbleDateTimePicker.Value, 1, 0);
                            timesheetChart.Series[username].Points[i].Color = Color.Transparent;
                        }
                    }
                }

                totalLabel.Text = totalLabel.Text.Split(':')[0] + ": " + totalSessions;
                shownLabel.Text = shownLabel.Text.Split(':')[0] + ": " + shownSessions;
                missingLabel.Text = missingLabel.Text.Split(':')[0] + ": " + missingSessions;
            }
            else
            {
                timesheetChart.Series.Clear();

                List<BubblePoint> bubblePoints = GraphInformationManager.ConsultUserTimesheetBubbleChartInformation(usernamesTimesheetListBox.SelectedItem.ToString(), newestBubbleDateTimePicker.Value, CalculateOldestDate());

                int totalSessions = 0;
                int shownSessions = 0;
                int missingSessions = 0;

                if (bubblePoints.Count > 0)
                {
                    timesheetChart.Series.Add(usernamesTimesheetListBox.SelectedItem.ToString()); // Creating the series
                    timesheetChart.Series[usernamesTimesheetListBox.SelectedItem.ToString()].ChartType = SeriesChartType.Bubble;
                    timesheetChart.Series[usernamesTimesheetListBox.SelectedItem.ToString()].MarkerStyle = MarkerStyle.Circle;
                    timesheetChart.ChartAreas["BubbleChartArea"].AxisX.Title = "Date";
                    timesheetChart.ChartAreas["BubbleChartArea"].AxisY.Title = "Hours of the Day";
                    timesheetChart.ChartAreas["BubbleChartArea"].AxisY.LabelStyle.Format = "00H";
                    timesheetChart.ChartAreas["BubbleChartArea"].AxisY.Minimum = 0;
                    timesheetChart.ChartAreas["BubbleChartArea"].AxisY.Maximum = 24;

                    int minimum = 25;

                    // Adding points
                    foreach (BubblePoint bubble in bubblePoints)
                    {
                        totalSessions++;

                        if (bubble.Minutes > 0)
                        {
                            int position = timesheetChart.Series[usernamesTimesheetListBox.SelectedItem.ToString()].Points.AddXY(
                                DateTime.Parse(bubble.LogInDate),
                                FormatToInt(bubble.LogInTime.Split(':')[0]),
                                bubble.Seconds);

                            timesheetChart.Series[usernamesTimesheetListBox.SelectedItem.ToString()].Points[position].Label = bubble.Minutes.ToString("0.####") + " min";

                            if (FormatToInt(bubble.LogInTime.Split(':')[0]) < minimum)
                                minimum = FormatToInt(bubble.LogInTime.Split(':')[0]) - 3;

                            shownSessions++;
                        }
                        else
                            missingSessions++;
                    }

                    // adding invisible ancor point
                    int i = timesheetChart.Series[usernamesTimesheetListBox.SelectedItem.ToString()].Points.AddXY(newestBubbleDateTimePicker.Value, minimum + 1, 0);
                    timesheetChart.Series[usernamesTimesheetListBox.SelectedItem.ToString()].Points[i].Color = Color.Transparent;
                    timesheetChart.ChartAreas["BubbleChartArea"].AxisY.Minimum = minimum;
                }

                totalLabel.Text = totalLabel.Text.Split(':')[0] + ": " + totalSessions;
                shownLabel.Text = shownLabel.Text.Split(':')[0] + ": " + shownSessions;
                missingLabel.Text = missingLabel.Text.Split(':')[0] + ": " + missingSessions;
            }
        }

        private DateTime CalculateOldestDate()
        {
            switch (timeComboBox.Text)
            {
                case "72 hours":
                    return newestBubbleDateTimePicker.Value.AddHours(-24);

                case "week":
                    return newestBubbleDateTimePicker.Value.AddDays(-7);

                case "2 weeks":
                    return newestBubbleDateTimePicker.Value.AddDays(-14);

                case "month":
                    return newestBubbleDateTimePicker.Value.AddMonths(-1);

                case "2 months":
                    return newestBubbleDateTimePicker.Value.AddMonths(-2);

                case "24 hours":
                default:
                    return newestBubbleDateTimePicker.Value.AddHours(-24);
            }
        }

        /// <summary>
        /// Function to convert strings to ints
        /// </summary>
        /// <param name="value">String value needed to be converted</param>
        /// <returns>An int equivalent of the provided string value</returns>
        private static int FormatToInt(String value)
        {
            int.TryParse(value, out int result);

            return result;
        }
        #endregion
    }
}
