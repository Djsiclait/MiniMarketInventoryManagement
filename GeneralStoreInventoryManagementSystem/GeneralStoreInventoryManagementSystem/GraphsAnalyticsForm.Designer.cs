namespace GeneralStoreInventoryManagementSystem
{
    partial class GraphsAnalyticsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title5 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title6 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.viewCartLabel = new System.Windows.Forms.Label();
            this.logOutLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.salesMenuOption = new System.Windows.Forms.ToolStripMenuItem();
            this.viewSalesMenuSubOption = new System.Windows.Forms.ToolStripMenuItem();
            this.makeSaleMenuSubOption = new System.Windows.Forms.ToolStripMenuItem();
            this.productsMenuOption = new System.Windows.Forms.ToolStripMenuItem();
            this.browseProductsMenuSubOption = new System.Windows.Forms.ToolStripMenuItem();
            this.registerNewProductMenuSubOption = new System.Windows.Forms.ToolStripMenuItem();
            this.restockProductsMenuSubOption = new System.Windows.Forms.ToolStripMenuItem();
            this.adminMenuOption = new System.Windows.Forms.ToolStripMenuItem();
            this.manageUsersMenuSubOption = new System.Windows.Forms.ToolStripMenuItem();
            this.viewUsersOption = new System.Windows.Forms.ToolStripMenuItem();
            this.registerNewUserOption = new System.Windows.Forms.ToolStripMenuItem();
            this.viewReportsMenuSubOption = new System.Windows.Forms.ToolStripMenuItem();
            this.logsMenuSubOption = new System.Windows.Forms.ToolStripMenuItem();
            this.viewActivityLogsOption = new System.Windows.Forms.ToolStripMenuItem();
            this.viewErrorLogsOption = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.timesheetTabPage = new System.Windows.Forms.TabPage();
            this.shownMessageLabel = new System.Windows.Forms.Label();
            this.missingMessageLabel = new System.Windows.Forms.Label();
            this.missingLabel = new System.Windows.Forms.Label();
            this.shownLabel = new System.Windows.Forms.Label();
            this.totalSessionsLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timeComboBox = new System.Windows.Forms.ComboBox();
            this.printTimesheetButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.newestBubbleDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.searchTimesheetTextBox = new System.Windows.Forms.TextBox();
            this.usernamesTimesheetListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timesheetChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.salesTabPage = new System.Windows.Forms.TabPage();
            this.userSalesChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.totalSalesLabel = new System.Windows.Forms.Label();
            this.numberSalesLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.oldestSalesBarChartDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.newestSalesBarChartDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.searchSalesTextBox = new System.Windows.Forms.TextBox();
            this.usernamesSalesListBox = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.totalSalesChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label13 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.timesheetTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timesheetChart)).BeginInit();
            this.salesTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userSalesChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalSalesChart)).BeginInit();
            this.SuspendLayout();
            // 
            // viewCartLabel
            // 
            this.viewCartLabel.AutoSize = true;
            this.viewCartLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.viewCartLabel.Location = new System.Drawing.Point(765, 9);
            this.viewCartLabel.Name = "viewCartLabel";
            this.viewCartLabel.Size = new System.Drawing.Size(52, 13);
            this.viewCartLabel.TabIndex = 9;
            this.viewCartLabel.Text = "View Cart";
            this.viewCartLabel.Click += new System.EventHandler(this.ViewCartLabel_Click);
            this.viewCartLabel.MouseLeave += new System.EventHandler(this.ViewCartLabel_MouseLeave);
            this.viewCartLabel.MouseHover += new System.EventHandler(this.ViewCartLabel_MouseHover);
            // 
            // logOutLabel
            // 
            this.logOutLabel.AutoSize = true;
            this.logOutLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.logOutLabel.Location = new System.Drawing.Point(870, 9);
            this.logOutLabel.Name = "logOutLabel";
            this.logOutLabel.Size = new System.Drawing.Size(45, 13);
            this.logOutLabel.TabIndex = 8;
            this.logOutLabel.Text = "Log Out";
            this.logOutLabel.Click += new System.EventHandler(this.LogOutLabel_Click);
            this.logOutLabel.MouseLeave += new System.EventHandler(this.LogOutLabel_MouseLeave);
            this.logOutLabel.MouseHover += new System.EventHandler(this.LogOutLabel_MouseHover);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salesMenuOption,
            this.productsMenuOption,
            this.adminMenuOption});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(927, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GraphsAnalyticsForm_KeyDown);
            // 
            // salesMenuOption
            // 
            this.salesMenuOption.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewSalesMenuSubOption,
            this.makeSaleMenuSubOption});
            this.salesMenuOption.Name = "salesMenuOption";
            this.salesMenuOption.Size = new System.Drawing.Size(45, 20);
            this.salesMenuOption.Text = "Sales";
            // 
            // viewSalesMenuSubOption
            // 
            this.viewSalesMenuSubOption.Name = "viewSalesMenuSubOption";
            this.viewSalesMenuSubOption.ShortcutKeyDisplayString = "F1";
            this.viewSalesMenuSubOption.Size = new System.Drawing.Size(151, 22);
            this.viewSalesMenuSubOption.Text = "View Sales";
            this.viewSalesMenuSubOption.Click += new System.EventHandler(this.ViewSalesMenuSubOption_Click);
            // 
            // makeSaleMenuSubOption
            // 
            this.makeSaleMenuSubOption.Name = "makeSaleMenuSubOption";
            this.makeSaleMenuSubOption.ShortcutKeyDisplayString = "F2";
            this.makeSaleMenuSubOption.Size = new System.Drawing.Size(151, 22);
            this.makeSaleMenuSubOption.Text = "Make Sales";
            this.makeSaleMenuSubOption.Click += new System.EventHandler(this.MakeSaleMenuSubOption_Click);
            // 
            // productsMenuOption
            // 
            this.productsMenuOption.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.browseProductsMenuSubOption,
            this.registerNewProductMenuSubOption,
            this.restockProductsMenuSubOption});
            this.productsMenuOption.Name = "productsMenuOption";
            this.productsMenuOption.Size = new System.Drawing.Size(66, 20);
            this.productsMenuOption.Text = "Products";
            // 
            // browseProductsMenuSubOption
            // 
            this.browseProductsMenuSubOption.Name = "browseProductsMenuSubOption";
            this.browseProductsMenuSubOption.ShortcutKeyDisplayString = "F3";
            this.browseProductsMenuSubOption.Size = new System.Drawing.Size(207, 22);
            this.browseProductsMenuSubOption.Text = "Product Browser";
            this.browseProductsMenuSubOption.Click += new System.EventHandler(this.BrowseProductsMenuSubOption_Click);
            // 
            // registerNewProductMenuSubOption
            // 
            this.registerNewProductMenuSubOption.Name = "registerNewProductMenuSubOption";
            this.registerNewProductMenuSubOption.ShortcutKeyDisplayString = "F4";
            this.registerNewProductMenuSubOption.Size = new System.Drawing.Size(207, 22);
            this.registerNewProductMenuSubOption.Text = "Register New Product";
            this.registerNewProductMenuSubOption.Click += new System.EventHandler(this.RegisterNewProductMenuSubOption_Click);
            // 
            // restockProductsMenuSubOption
            // 
            this.restockProductsMenuSubOption.Name = "restockProductsMenuSubOption";
            this.restockProductsMenuSubOption.ShortcutKeyDisplayString = "F5";
            this.restockProductsMenuSubOption.Size = new System.Drawing.Size(207, 22);
            this.restockProductsMenuSubOption.Text = "Restock Products";
            this.restockProductsMenuSubOption.Click += new System.EventHandler(this.RestockProductsMenuSubOption_Click);
            // 
            // adminMenuOption
            // 
            this.adminMenuOption.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageUsersMenuSubOption,
            this.viewReportsMenuSubOption,
            this.logsMenuSubOption});
            this.adminMenuOption.Name = "adminMenuOption";
            this.adminMenuOption.Size = new System.Drawing.Size(55, 20);
            this.adminMenuOption.Text = "Admin";
            // 
            // manageUsersMenuSubOption
            // 
            this.manageUsersMenuSubOption.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewUsersOption,
            this.registerNewUserOption});
            this.manageUsersMenuSubOption.Name = "manageUsersMenuSubOption";
            this.manageUsersMenuSubOption.Size = new System.Drawing.Size(161, 22);
            this.manageUsersMenuSubOption.Text = "Manage Users";
            // 
            // viewUsersOption
            // 
            this.viewUsersOption.Name = "viewUsersOption";
            this.viewUsersOption.ShortcutKeyDisplayString = "F6";
            this.viewUsersOption.Size = new System.Drawing.Size(188, 22);
            this.viewUsersOption.Text = "View Users";
            this.viewUsersOption.Click += new System.EventHandler(this.ViewUsersOption_Click);
            // 
            // registerNewUserOption
            // 
            this.registerNewUserOption.Name = "registerNewUserOption";
            this.registerNewUserOption.ShortcutKeyDisplayString = "F7";
            this.registerNewUserOption.Size = new System.Drawing.Size(188, 22);
            this.registerNewUserOption.Text = "Register New User";
            this.registerNewUserOption.Click += new System.EventHandler(this.RegisterNewUserOption_Click);
            // 
            // viewReportsMenuSubOption
            // 
            this.viewReportsMenuSubOption.Name = "viewReportsMenuSubOption";
            this.viewReportsMenuSubOption.ShortcutKeyDisplayString = "F9";
            this.viewReportsMenuSubOption.Size = new System.Drawing.Size(161, 22);
            this.viewReportsMenuSubOption.Text = "View Reports";
            this.viewReportsMenuSubOption.Click += new System.EventHandler(this.ViewReportsMenuSubOption_Click);
            // 
            // logsMenuSubOption
            // 
            this.logsMenuSubOption.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewActivityLogsOption,
            this.viewErrorLogsOption});
            this.logsMenuSubOption.Name = "logsMenuSubOption";
            this.logsMenuSubOption.Size = new System.Drawing.Size(161, 22);
            this.logsMenuSubOption.Text = "Logs";
            // 
            // viewActivityLogsOption
            // 
            this.viewActivityLogsOption.Name = "viewActivityLogsOption";
            this.viewActivityLogsOption.ShortcutKeyDisplayString = "F10";
            this.viewActivityLogsOption.Size = new System.Drawing.Size(198, 22);
            this.viewActivityLogsOption.Text = "View Activities Log";
            this.viewActivityLogsOption.Click += new System.EventHandler(this.ViewActivityLogsOption_Click);
            // 
            // viewErrorLogsOption
            // 
            this.viewErrorLogsOption.Name = "viewErrorLogsOption";
            this.viewErrorLogsOption.ShortcutKeyDisplayString = "F11";
            this.viewErrorLogsOption.Size = new System.Drawing.Size(198, 22);
            this.viewErrorLogsOption.Text = "View Errors Log";
            this.viewErrorLogsOption.Click += new System.EventHandler(this.ViewErrorLogsOption_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.timesheetTabPage);
            this.tabControl1.Controls.Add(this.salesTabPage);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(903, 640);
            this.tabControl1.TabIndex = 10;
            this.tabControl1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GraphsAnalyticsForm_KeyDown);
            // 
            // timesheetTabPage
            // 
            this.timesheetTabPage.Controls.Add(this.shownMessageLabel);
            this.timesheetTabPage.Controls.Add(this.missingMessageLabel);
            this.timesheetTabPage.Controls.Add(this.missingLabel);
            this.timesheetTabPage.Controls.Add(this.shownLabel);
            this.timesheetTabPage.Controls.Add(this.totalSessionsLabel);
            this.timesheetTabPage.Controls.Add(this.label3);
            this.timesheetTabPage.Controls.Add(this.timeComboBox);
            this.timesheetTabPage.Controls.Add(this.printTimesheetButton);
            this.timesheetTabPage.Controls.Add(this.label4);
            this.timesheetTabPage.Controls.Add(this.newestBubbleDateTimePicker);
            this.timesheetTabPage.Controls.Add(this.searchTimesheetTextBox);
            this.timesheetTabPage.Controls.Add(this.usernamesTimesheetListBox);
            this.timesheetTabPage.Controls.Add(this.label2);
            this.timesheetTabPage.Controls.Add(this.label1);
            this.timesheetTabPage.Controls.Add(this.timesheetChart);
            this.timesheetTabPage.Location = new System.Drawing.Point(4, 22);
            this.timesheetTabPage.Name = "timesheetTabPage";
            this.timesheetTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.timesheetTabPage.Size = new System.Drawing.Size(895, 614);
            this.timesheetTabPage.TabIndex = 0;
            this.timesheetTabPage.Text = "Timesheet";
            this.timesheetTabPage.UseVisualStyleBackColor = true;
            // 
            // shownMessageLabel
            // 
            this.shownMessageLabel.AutoSize = true;
            this.shownMessageLabel.BackColor = System.Drawing.Color.PowderBlue;
            this.shownMessageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shownMessageLabel.Location = new System.Drawing.Point(234, 570);
            this.shownMessageLabel.Name = "shownMessageLabel";
            this.shownMessageLabel.Size = new System.Drawing.Size(398, 13);
            this.shownMessageLabel.TabIndex = 24;
            this.shownMessageLabel.Text = "These sessions are displayed on the graph (some overlap may occur)";
            // 
            // missingMessageLabel
            // 
            this.missingMessageLabel.AutoSize = true;
            this.missingMessageLabel.BackColor = System.Drawing.Color.PowderBlue;
            this.missingMessageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.missingMessageLabel.Location = new System.Drawing.Point(453, 570);
            this.missingMessageLabel.Name = "missingMessageLabel";
            this.missingMessageLabel.Size = new System.Drawing.Size(407, 13);
            this.missingMessageLabel.TabIndex = 23;
            this.missingMessageLabel.Text = "These sessions are not shown on the chart given their short timestamp";
            // 
            // missingLabel
            // 
            this.missingLabel.AutoSize = true;
            this.missingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.missingLabel.Location = new System.Drawing.Point(597, 586);
            this.missingLabel.Name = "missingLabel";
            this.missingLabel.Size = new System.Drawing.Size(152, 13);
            this.missingLabel.TabIndex = 22;
            this.missingLabel.Text = "Sessions Under 1 Minute:";
            this.missingLabel.MouseLeave += new System.EventHandler(this.MissingLabel_MouseLeave);
            this.missingLabel.MouseHover += new System.EventHandler(this.MissingLabel_MouseHover);
            // 
            // shownLabel
            // 
            this.shownLabel.AutoSize = true;
            this.shownLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shownLabel.Location = new System.Drawing.Point(351, 586);
            this.shownLabel.Name = "shownLabel";
            this.shownLabel.Size = new System.Drawing.Size(154, 13);
            this.shownLabel.TabIndex = 21;
            this.shownLabel.Text = "Sessions Above 1 Minute:";
            this.shownLabel.MouseLeave += new System.EventHandler(this.shownLabel_MouseLeave);
            this.shownLabel.MouseHover += new System.EventHandler(this.shownLabel_MouseHover);
            // 
            // totalSessionsLabel
            // 
            this.totalSessionsLabel.AutoSize = true;
            this.totalSessionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalSessionsLabel.Location = new System.Drawing.Point(153, 586);
            this.totalSessionsLabel.Name = "totalSessionsLabel";
            this.totalSessionsLabel.Size = new System.Drawing.Size(94, 13);
            this.totalSessionsLabel.TabIndex = 20;
            this.totalSessionsLabel.Text = "Total Sessions:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(638, 491);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "since: ";
            // 
            // timeComboBox
            // 
            this.timeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeComboBox.FormattingEnabled = true;
            this.timeComboBox.Location = new System.Drawing.Point(511, 488);
            this.timeComboBox.Name = "timeComboBox";
            this.timeComboBox.Size = new System.Drawing.Size(121, 21);
            this.timeComboBox.TabIndex = 18;
            this.timeComboBox.SelectedIndexChanged += new System.EventHandler(this.TimeComboBox_SelectedIndexChanged);
            // 
            // printTimesheetButton
            // 
            this.printTimesheetButton.Location = new System.Drawing.Point(497, 551);
            this.printTimesheetButton.Name = "printTimesheetButton";
            this.printTimesheetButton.Size = new System.Drawing.Size(200, 23);
            this.printTimesheetButton.TabIndex = 17;
            this.printTimesheetButton.Text = "Print Timesheet Graph";
            this.printTimesheetButton.UseVisualStyleBackColor = true;
            this.printTimesheetButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GraphsAnalyticsForm_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(474, 491);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Last";
            // 
            // newestBubbleDateTimePicker
            // 
            this.newestBubbleDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newestBubbleDateTimePicker.Location = new System.Drawing.Point(497, 515);
            this.newestBubbleDateTimePicker.Name = "newestBubbleDateTimePicker";
            this.newestBubbleDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.newestBubbleDateTimePicker.TabIndex = 15;
            this.newestBubbleDateTimePicker.ValueChanged += new System.EventHandler(this.NewestBubbleDateTimePicker_ValueChanged);
            this.newestBubbleDateTimePicker.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GraphsAnalyticsForm_KeyDown);
            // 
            // searchTimesheetTextBox
            // 
            this.searchTimesheetTextBox.Location = new System.Drawing.Point(174, 488);
            this.searchTimesheetTextBox.Name = "searchTimesheetTextBox";
            this.searchTimesheetTextBox.Size = new System.Drawing.Size(132, 20);
            this.searchTimesheetTextBox.TabIndex = 4;
            this.searchTimesheetTextBox.TextChanged += new System.EventHandler(this.SearchTimesheetTextBox_TextChanged);
            // 
            // usernamesTimesheetListBox
            // 
            this.usernamesTimesheetListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernamesTimesheetListBox.FormattingEnabled = true;
            this.usernamesTimesheetListBox.Location = new System.Drawing.Point(156, 514);
            this.usernamesTimesheetListBox.Name = "usernamesTimesheetListBox";
            this.usernamesTimesheetListBox.Size = new System.Drawing.Size(274, 69);
            this.usernamesTimesheetListBox.TabIndex = 3;
            this.usernamesTimesheetListBox.Click += new System.EventHandler(this.UsernamesListBox_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(133, 491);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "User: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "User TimeSheet Bubble Chart";
            // 
            // timesheetChart
            // 
            this.timesheetChart.BackColor = System.Drawing.Color.Gainsboro;
            chartArea4.Name = "BubbleChartArea";
            this.timesheetChart.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.timesheetChart.Legends.Add(legend4);
            this.timesheetChart.Location = new System.Drawing.Point(42, 63);
            this.timesheetChart.Name = "timesheetChart";
            series4.ChartArea = "BubbleChartArea";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bubble;
            series4.Legend = "Legend1";
            series4.Name = "User";
            series4.YValuesPerPoint = 2;
            this.timesheetChart.Series.Add(series4);
            this.timesheetChart.Size = new System.Drawing.Size(818, 419);
            this.timesheetChart.TabIndex = 0;
            this.timesheetChart.Text = "Timesheet Graph";
            title4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            title4.Name = "Title1";
            title4.Text = "User Timesheet";
            this.timesheetChart.Titles.Add(title4);
            // 
            // salesTabPage
            // 
            this.salesTabPage.Controls.Add(this.userSalesChart);
            this.salesTabPage.Controls.Add(this.totalSalesLabel);
            this.salesTabPage.Controls.Add(this.numberSalesLabel);
            this.salesTabPage.Controls.Add(this.button1);
            this.salesTabPage.Controls.Add(this.label7);
            this.salesTabPage.Controls.Add(this.oldestSalesBarChartDateTimePicker);
            this.salesTabPage.Controls.Add(this.label6);
            this.salesTabPage.Controls.Add(this.newestSalesBarChartDateTimePicker);
            this.salesTabPage.Controls.Add(this.searchSalesTextBox);
            this.salesTabPage.Controls.Add(this.usernamesSalesListBox);
            this.salesTabPage.Controls.Add(this.label5);
            this.salesTabPage.Controls.Add(this.totalSalesChart);
            this.salesTabPage.Controls.Add(this.label13);
            this.salesTabPage.Location = new System.Drawing.Point(4, 22);
            this.salesTabPage.Name = "salesTabPage";
            this.salesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.salesTabPage.Size = new System.Drawing.Size(895, 614);
            this.salesTabPage.TabIndex = 1;
            this.salesTabPage.Text = "Sales";
            this.salesTabPage.UseVisualStyleBackColor = true;
            this.salesTabPage.Enter += new System.EventHandler(this.SalesTabPage_Enter);
            // 
            // userSalesChart
            // 
            this.userSalesChart.BackColor = System.Drawing.Color.Gainsboro;
            chartArea5.Name = "BarChartArea";
            this.userSalesChart.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.userSalesChart.Legends.Add(legend5);
            this.userSalesChart.Location = new System.Drawing.Point(42, 63);
            this.userSalesChart.Name = "userSalesChart";
            series5.ChartArea = "BarChartArea";
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.userSalesChart.Series.Add(series5);
            this.userSalesChart.Size = new System.Drawing.Size(818, 419);
            this.userSalesChart.TabIndex = 38;
            this.userSalesChart.Text = "chart1";
            title5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            title5.Name = "Title1";
            title5.Text = "Sales Generated By User";
            this.userSalesChart.Titles.Add(title5);
            // 
            // totalSalesLabel
            // 
            this.totalSalesLabel.AutoSize = true;
            this.totalSalesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalSalesLabel.Location = new System.Drawing.Point(687, 538);
            this.totalSalesLabel.Name = "totalSalesLabel";
            this.totalSalesLabel.Size = new System.Drawing.Size(51, 13);
            this.totalSalesLabel.TabIndex = 37;
            this.totalSalesLabel.Text = "Total: $";
            // 
            // numberSalesLabel
            // 
            this.numberSalesLabel.AutoSize = true;
            this.numberSalesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberSalesLabel.Location = new System.Drawing.Point(623, 497);
            this.numberSalesLabel.Name = "numberSalesLabel";
            this.numberSalesLabel.Size = new System.Drawing.Size(102, 13);
            this.numberSalesLabel.TabIndex = 36;
            this.numberSalesLabel.Text = "Total # of Sales:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(626, 575);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 23);
            this.button1.TabIndex = 35;
            this.button1.Text = "Print Sales Graph";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(384, 554);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 34;
            this.label7.Text = "And: ";
            // 
            // oldestSalesBarChartDateTimePicker
            // 
            this.oldestSalesBarChartDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oldestSalesBarChartDateTimePicker.Location = new System.Drawing.Point(407, 578);
            this.oldestSalesBarChartDateTimePicker.Name = "oldestSalesBarChartDateTimePicker";
            this.oldestSalesBarChartDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.oldestSalesBarChartDateTimePicker.TabIndex = 33;
            this.oldestSalesBarChartDateTimePicker.ValueChanged += new System.EventHandler(this.OldestSalesBarChartDateTimePicker_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(384, 497);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "Between: ";
            // 
            // newestSalesBarChartDateTimePicker
            // 
            this.newestSalesBarChartDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newestSalesBarChartDateTimePicker.Location = new System.Drawing.Point(407, 521);
            this.newestSalesBarChartDateTimePicker.Name = "newestSalesBarChartDateTimePicker";
            this.newestSalesBarChartDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.newestSalesBarChartDateTimePicker.TabIndex = 31;
            this.newestSalesBarChartDateTimePicker.ValueChanged += new System.EventHandler(this.NewestSalesBarChartDateTimePicker_ValueChanged);
            // 
            // searchSalesTextBox
            // 
            this.searchSalesTextBox.Location = new System.Drawing.Point(106, 494);
            this.searchSalesTextBox.Name = "searchSalesTextBox";
            this.searchSalesTextBox.Size = new System.Drawing.Size(132, 20);
            this.searchSalesTextBox.TabIndex = 30;
            this.searchSalesTextBox.TextChanged += new System.EventHandler(this.SearchSalesTextBox_TextChanged);
            // 
            // usernamesSalesListBox
            // 
            this.usernamesSalesListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernamesSalesListBox.FormattingEnabled = true;
            this.usernamesSalesListBox.Location = new System.Drawing.Point(88, 520);
            this.usernamesSalesListBox.Name = "usernamesSalesListBox";
            this.usernamesSalesListBox.Size = new System.Drawing.Size(274, 82);
            this.usernamesSalesListBox.TabIndex = 29;
            this.usernamesSalesListBox.Click += new System.EventHandler(this.UsernamesSalesListBox_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(65, 497);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "User: ";
            // 
            // totalSalesChart
            // 
            this.totalSalesChart.BackColor = System.Drawing.Color.Gainsboro;
            chartArea6.Name = "BarChartArea";
            this.totalSalesChart.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.totalSalesChart.Legends.Add(legend6);
            this.totalSalesChart.Location = new System.Drawing.Point(42, 63);
            this.totalSalesChart.Name = "totalSalesChart";
            series6.ChartArea = "BarChartArea";
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.totalSalesChart.Series.Add(series6);
            this.totalSalesChart.Size = new System.Drawing.Size(818, 419);
            this.totalSalesChart.TabIndex = 27;
            this.totalSalesChart.Text = "chart1";
            title6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            title6.Name = "Title1";
            title6.Text = "Total Generated Sales";
            this.totalSalesChart.Titles.Add(title6);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(38, 40);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(233, 20);
            this.label13.TabIndex = 26;
            this.label13.Text = "Generated Sales Bar Graph";
            // 
            // GraphsAnalyticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 679);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.viewCartLabel);
            this.Controls.Add(this.logOutLabel);
            this.Controls.Add(this.menuStrip1);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(943, 717);
            this.Name = "GraphsAnalyticsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Analytics --- Graphs";
            this.Load += new System.EventHandler(this.GraphsAnalyticsForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GraphsAnalyticsForm_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.timesheetTabPage.ResumeLayout(false);
            this.timesheetTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timesheetChart)).EndInit();
            this.salesTabPage.ResumeLayout(false);
            this.salesTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userSalesChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalSalesChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label viewCartLabel;
        private System.Windows.Forms.Label logOutLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem salesMenuOption;
        private System.Windows.Forms.ToolStripMenuItem viewSalesMenuSubOption;
        private System.Windows.Forms.ToolStripMenuItem makeSaleMenuSubOption;
        private System.Windows.Forms.ToolStripMenuItem adminMenuOption;
        private System.Windows.Forms.ToolStripMenuItem manageUsersMenuSubOption;
        private System.Windows.Forms.ToolStripMenuItem viewUsersOption;
        private System.Windows.Forms.ToolStripMenuItem registerNewUserOption;
        private System.Windows.Forms.ToolStripMenuItem viewReportsMenuSubOption;
        private System.Windows.Forms.ToolStripMenuItem logsMenuSubOption;
        private System.Windows.Forms.ToolStripMenuItem viewActivityLogsOption;
        private System.Windows.Forms.ToolStripMenuItem viewErrorLogsOption;
        private System.Windows.Forms.ToolStripMenuItem productsMenuOption;
        private System.Windows.Forms.ToolStripMenuItem browseProductsMenuSubOption;
        private System.Windows.Forms.ToolStripMenuItem registerNewProductMenuSubOption;
        private System.Windows.Forms.ToolStripMenuItem restockProductsMenuSubOption;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage timesheetTabPage;
        private System.Windows.Forms.TabPage salesTabPage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart timesheetChart;
        private System.Windows.Forms.ListBox usernamesTimesheetListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox searchTimesheetTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker newestBubbleDateTimePicker;
        private System.Windows.Forms.Button printTimesheetButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox timeComboBox;
        private System.Windows.Forms.Label missingLabel;
        private System.Windows.Forms.Label shownLabel;
        private System.Windows.Forms.Label totalSessionsLabel;
        private System.Windows.Forms.Label missingMessageLabel;
        private System.Windows.Forms.Label shownMessageLabel;
        private System.Windows.Forms.TextBox searchSalesTextBox;
        private System.Windows.Forms.ListBox usernamesSalesListBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataVisualization.Charting.Chart totalSalesChart;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker newestSalesBarChartDateTimePicker;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker oldestSalesBarChartDateTimePicker;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label totalSalesLabel;
        private System.Windows.Forms.Label numberSalesLabel;
        private System.Windows.Forms.DataVisualization.Charting.Chart userSalesChart;
    }
}