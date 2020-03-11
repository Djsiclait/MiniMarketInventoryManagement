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
        // Trigger
        int assistance = 0;
        bool requestSalesBarGraph = true;

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

            // Recording user access to this form
            SystemProtocols.ApplyActivityProtocols("GRA1", null, null);

            // Hiding message lables
            missingMessageLabel.Visible = false;
            shownMessageLabel.Visible = false;

            // Initilizing combo box
            timeComboBox.Items.Add("24 hours");
            timeComboBox.Items.Add("72 hours");
            timeComboBox.Items.Add("week");
            timeComboBox.Items.Add("2 weeks");
            timeComboBox.Items.Add("month");
            timeComboBox.Items.Add("2 months");
            timeComboBox.SelectedIndex = 0;

            // Populating Graphs
            PopulateUsernameTimesheetListBox();
            PopulateUsernameSalesListBox();

            // Initializing date time pickers
            #region Bubble Chart
            newestBubbleDateTimePicker.Value = DateTime.Now;
            newestBubbleDateTimePicker.MaxDate = DateTime.Today.AddDays(1);
            #endregion

            #region Sales Bar Chart
            newestSalesBarChartDateTimePicker.Value = DateTime.Now;
            newestSalesBarChartDateTimePicker.MaxDate = DateTime.Today.AddDays(1);
            #endregion
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
        private void SearchTimesheetTextBox_TextChanged(object sender, EventArgs e)
        {
            PopulateUsernameTimesheetListBox(); // filtering the usernames for the timesheets
        }

        private void SearchSalesTextBox_TextChanged(object sender, EventArgs e)
        {
            PopulateUsernameSalesListBox(); // filtering tge usernames for the sales graphs
        }
        #endregion

        #region Value Changed Logic
        private void NewestBubbleDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (usernamesTimesheetListBox.Items.Count > 0) // ensurring the username list box has been initialized
                GenerateTimesheetBubbleChart(); // requesting timesheet 
        }

        private void TimeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (usernamesTimesheetListBox.Items.Count > 0) // ensurring the username list box has been initialized
                GenerateTimesheetBubbleChart(); // requesting timesheet 
        }

        private void NewestSalesBarChartDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            // Updating the second date time picker to establish an interval of one month
            oldestSalesBarChartDateTimePicker.MaxDate = newestSalesBarChartDateTimePicker.Value.AddDays(-1);
            oldestSalesBarChartDateTimePicker.Value = newestSalesBarChartDateTimePicker.Value.AddMonths(-1);
        }

        private void OldestSalesBarChartDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (usernamesSalesListBox.Items.Count > 0 && !requestSalesBarGraph) // ensurring the username list box has been initialized
                GenerateSalesBarChart(); // requesting sales charts
        }
        #endregion

        #region List Box Click Logic
        private void UsernamesListBox_Click(object sender, EventArgs e)
        {
            GenerateTimesheetBubbleChart(); // requesting timesheet 
        }

        private void UsernamesSalesListBox_Click(object sender, EventArgs e)
        {
            GenerateSalesBarChart(); // requesting sales charts
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

        #region Tab enter Logic
        private void SalesTabPage_Enter(object sender, EventArgs e)
        {
            Console.WriteLine("Ping!");
            if (requestSalesBarGraph)
            {
                GenerateSalesBarChart(); // requesting sales charts
                requestSalesBarGraph = false;
            }
        }
        #endregion

        #region Auxiliary Functions
        /// <summary>
        /// Function to populate the list box with the username of all registered users for the timesheet tab
        /// </summary>
        private void PopulateUsernameTimesheetListBox()
        {
            usernamesTimesheetListBox.DataSource = GraphInformationManager.ConsultAllRegisteredUsernameInformation(searchTimesheetTextBox.Text);
        }

        /// <summary>
        /// Function to populate the list box with the username of all registered users for the sales tab
        /// </summary>
        private void PopulateUsernameSalesListBox()
        {
            usernamesSalesListBox.DataSource = GraphInformationManager.ConsultAllRegisteredUsernameInformation(searchSalesTextBox.Text);
        }

        /// <summary>
        /// Function assigned to generate requested sales graph given the chosen congfigurations
        /// </summary>
        private void GenerateSalesBarChart()
        {
            Console.WriteLine("Pong!");
            // Counters
            int numberOfSales = 0;
            Decimal total = 0;

            if (usernamesSalesListBox.SelectedItem.ToString() == "ALL") // the user requests to see generated sales made by all registered users
            {
                totalSalesChart.Series.Clear(); // clearing the sales chart of previous information
                totalSalesChart.Visible = true; // Showing the proper graph to display sales made by all users
                userSalesChart.Visible = false; // Hiding graph designated to view the sales of a single user

                // Requesting the neccessary information to generate the graphs
                List<Sale> salesBar = GraphInformationManager.ConsultSalesBarChartInformation(newestSalesBarChartDateTimePicker.Value, oldestSalesBarChartDateTimePicker.Value);

                if (salesBar.Count > 0) // assuring at least one graph point exists
                {
                    // Establishing series name with the time interval specifications
                    String seriesName = "Sales between " + oldestSalesBarChartDateTimePicker.Value.ToShortDateString() + " and " + newestSalesBarChartDateTimePicker.Value.ToShortDateString();

                    // Configuring the series
                    totalSalesChart.Series.Add(seriesName); // specifying the series
                    totalSalesChart.Series[seriesName].ChartType = SeriesChartType.Column; // specifying what type of graph is desired
                    totalSalesChart.ChartAreas["BarChartArea"].AxisX.Title = "Username"; // Naming the X-axis
                    totalSalesChart.ChartAreas["BarChartArea"].AxisY.Title = "Sales Amount ($)"; // Naming the Y-axis
                    totalSalesChart.ChartAreas["BarChartArea"].AxisY.LabelStyle.Format = "$0.00"; // Formating the scale of the Y-axis
                    totalSalesChart.ChartAreas["BarChartArea"].AxisY.Minimum = 0; // Establishing the Y-axis minimum

                    // Establishing the data points for the graph
                    foreach (Sale bar in salesBar)
                    {
                        numberOfSales += bar.NumberOfSales; // counting the number of sales preformed

                        // Adding new data point to graph
                        int position = totalSalesChart.Series[seriesName].Points.AddXY(bar.Username, bar.Total); // X: p.siclait, Y: $1000.00
                        // Adding a label to provide more accuracy and readability of the graph
                        totalSalesChart.Series[seriesName].Points[position].Label = bar.NumberOfSales + " sale(s) for " + bar.Total.ToString("$0.00");

                        total += bar.Total; // adding the total amount of dollars generated
                    }
                }
            }
            else // User has chosen to view the sales genenerated by one specific user
            {
                userSalesChart.Series.Clear(); // clearing the username's sales chart of previous information
                userSalesChart.Visible = true; // Showing graph designated to view the sales of a single user
                totalSalesChart.Visible = false; // Hiding the proper graph to display sales made by all users

                // Requesting the neccessary information to generate the graphs
                List<Sale> salesBar = GraphInformationManager.ConsultUserSalesBarChartInformation(usernamesSalesListBox.SelectedItem.ToString(), newestSalesBarChartDateTimePicker.Value, oldestSalesBarChartDateTimePicker.Value);

                if (salesBar.Count > 0) // assuring at least one graph point exists
                {
                    // Configuring the series
                    userSalesChart.Series.Add(usernamesSalesListBox.SelectedItem.ToString()); // specifying the series
                    userSalesChart.Series[usernamesSalesListBox.SelectedItem.ToString()].ChartType = SeriesChartType.Column; // specifying what type of graph is desired
                    userSalesChart.ChartAreas["BarChartArea"].AxisX.Title = "Transaction Dates"; // Naming the X-axis
                    userSalesChart.ChartAreas["BarChartArea"].AxisY.Title = "Sales Amount ($)"; // Naming the Y-axis
                    userSalesChart.ChartAreas["BarChartArea"].AxisY.LabelStyle.Format = "$0.00"; // Formating the scale of the Y-axis
                    userSalesChart.ChartAreas["BarChartArea"].AxisY.Minimum = 0; // Establishing the Y-axis minimum

                    // Establishing the data points for the graph
                    foreach (Sale bar in salesBar)
                    {
                        numberOfSales += bar.NumberOfSales; // counting the number of sales preformed

                        // Adding new data point to graph
                        int position = userSalesChart.Series[usernamesSalesListBox.SelectedItem.ToString()].Points.AddXY(bar.TransactionDate, bar.Total); // X: 09-01-2020, Y:$45000.00
                        // Adding a label to provide more accuracy and readability of the graph
                        userSalesChart.Series[usernamesSalesListBox.SelectedItem.ToString()].Points[position].Label = bar.NumberOfSales + " sale(s) for " + bar.Total.ToString("$0.00");

                        total += bar.Total; // adding the total amount of dollars generated
                    }
                }
            }

            // Updating supplementary summary information 
            numberSalesLabel.Text = numberSalesLabel.Text.Split(':')[0] + ": " + numberOfSales;
            totalSalesLabel.Text = totalSalesLabel.Text.Split('$')[0] + "$" + total.ToString("0.00");
        }

        /// <summary>
        /// Function assigned to generate requested timesheet graph given the chosen congfigurations
        /// </summary>
        private void GenerateTimesheetBubbleChart()
        {
            Console.WriteLine("Pang!");
            timesheetChart.Series.Clear(); // clearig the bubble chart of any previous information

            // Counters
            int totalSessions = 0;
            int shownSessions = 0;
            int missingSessions = 0;

            if (usernamesTimesheetListBox.SelectedItem.ToString() == "ALL") // the user requests to see generated timesheets of all registered users
                foreach (String username in usernamesTimesheetListBox.Items) // generating a timesheet for each reagistered user
                {
                    if (username != "ALL") // ignoring the all option given that this is not a recognized username
                    {
                        // Requesting a timesheet for the designated username
                        List<BubblePoint> bubblePoints = GraphInformationManager.ConsultUserTimesheetBubbleChartInformation(username, newestBubbleDateTimePicker.Value, CalculateOldestDate());

                        if (bubblePoints.Count > 0) // ensuring at least one graph point exists
                        {
                            // Configuring the series
                            timesheetChart.Series.Add(username); // Creating the series
                            timesheetChart.Series[username].ChartType = SeriesChartType.Bubble; // specifying what type of graph is desired
                            timesheetChart.Series[username].MarkerStyle = MarkerStyle.Circle; // Chosing the shape of the bubbles
                            timesheetChart.ChartAreas["BubbleChartArea"].AxisX.Title = "Date"; // Naming the X-axis
                            timesheetChart.ChartAreas["BubbleChartArea"].AxisY.Title = "Hours of the Day"; // Naming the Y-axis
                            timesheetChart.ChartAreas["BubbleChartArea"].AxisY.LabelStyle.Format = "00H"; // Formating the scale of the Y-axis
                            timesheetChart.ChartAreas["BubbleChartArea"].AxisY.Minimum = 0; // Establishing the Y-axis minimum
                            timesheetChart.ChartAreas["BubbleChartArea"].AxisY.Maximum = 24; // Establishing the Y-axis maximum

                            // Adding points
                            foreach (BubblePoint bubble in bubblePoints)
                            {
                                totalSessions++; // counting the total amount of sessions

                                if (bubble.Minutes > 0) // generating data points only for sessions that last longer than a minute 
                                {
                                    // Adding new data point to graph
                                    timesheetChart.Series[username].Points.AddXY(
                                        DateTime.Parse(bubble.LogInDate), // log in date
                                        FormatToInt(bubble.LogInTime.Split(':')[0]), // the hour at which the user was logged in (VERY INACCURATE)
                                        bubble.Seconds); // total seconds logged in to establich each bubble's magnitude/area/size

                                    shownSessions++; // counting all sessions at least a minute long
                                }
                                else
                                    missingSessions++; // counting all sessions less than a minute long
                            }

                            // adding invisible ancor point
                            int i = timesheetChart.Series[username].Points.AddXY(newestBubbleDateTimePicker.Value, 1, 0);
                            timesheetChart.Series[username].Points[i].Color = Color.Transparent;
                        }
                    }
                }
            else // User has chosen to view the timesheet of one specific user
            {
                // Requesting a timesheet for the selected username
                List<BubblePoint> bubblePoints = GraphInformationManager.ConsultUserTimesheetBubbleChartInformation(usernamesTimesheetListBox.SelectedItem.ToString(), newestBubbleDateTimePicker.Value, CalculateOldestDate());

                if (bubblePoints.Count > 0) // assuring at least one graph point exists
                {
                    // Configuring the series
                    timesheetChart.Series.Add(usernamesTimesheetListBox.SelectedItem.ToString()); // Creating the series
                    timesheetChart.Series[usernamesTimesheetListBox.SelectedItem.ToString()].ChartType = SeriesChartType.Bubble; // specifying what type of graph is desired
                    timesheetChart.Series[usernamesTimesheetListBox.SelectedItem.ToString()].MarkerStyle = MarkerStyle.Circle; // Chosing the shape of the bubbles
                    timesheetChart.ChartAreas["BubbleChartArea"].AxisX.Title = "Date"; // Naming the X-axis
                    timesheetChart.ChartAreas["BubbleChartArea"].AxisY.Title = "Hours of the Day"; // Naming the Y-axis
                    timesheetChart.ChartAreas["BubbleChartArea"].AxisY.LabelStyle.Format = "00H"; // Formating the scale of the Y-axis
                    timesheetChart.ChartAreas["BubbleChartArea"].AxisY.Minimum = 0; // Establishing the Y-axis minimum
                    timesheetChart.ChartAreas["BubbleChartArea"].AxisY.Maximum = 24; // Establishing the Y-axis maximum

                    int minimum = 25; // indicator to limit the individual timesheet

                    // Adding points
                    foreach (BubblePoint bubble in bubblePoints)
                    {
                        totalSessions++; // counting the total amount of sessions

                        if (bubble.Minutes > 0) // generating data points only for sessions that last longer than a minute
                        {
                            // Adding new data point to graph
                            int position = timesheetChart.Series[usernamesTimesheetListBox.SelectedItem.ToString()].Points.AddXY(
                                DateTime.Parse(bubble.LogInDate), // log in date
                                FormatToInt(bubble.LogInTime.Split(':')[0]), // the hour at which the user was logged in (VERY INACCURATE)
                                bubble.Seconds);
                            // Adding label to improve readability of graph
                            timesheetChart.Series[usernamesTimesheetListBox.SelectedItem.ToString()].Points[position].Label = bubble.Minutes.ToString("0.####") + " min";

                            if (FormatToInt(bubble.LogInTime.Split(':')[0]) < minimum)
                                minimum = FormatToInt(bubble.LogInTime.Split(':')[0]) - 4 > 0 ? FormatToInt(bubble.LogInTime.Split(':')[0]) - 4 : 0;

                            shownSessions++; // counting all sessions at least a minute long
                        }
                        else
                            missingSessions++; // counting all sessions less than a minute long
                    }

                    // adding invisible ancor point
                    int i = timesheetChart.Series[usernamesTimesheetListBox.SelectedItem.ToString()].Points.AddXY(newestBubbleDateTimePicker.Value, minimum + 1, 0);
                    timesheetChart.Series[usernamesTimesheetListBox.SelectedItem.ToString()].Points[i].Color = Color.Transparent;

                    // Updating chart minimum
                    timesheetChart.ChartAreas["BubbleChartArea"].AxisY.Minimum = minimum;
                }
            }

            // Updating supplementary summary information for timesheet tab
            totalSessionsLabel.Text = totalSessionsLabel.Text.Split(':')[0] + ": " + totalSessions;
            shownLabel.Text = shownLabel.Text.Split(':')[0] + ": " + shownSessions;
            missingLabel.Text = missingLabel.Text.Split(':')[0] + ": " + missingSessions;
        }

        /// <summary>
        /// Function to calculte the correct time frame chosen by the user
        /// </summary>
        /// <returns></returns>
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
