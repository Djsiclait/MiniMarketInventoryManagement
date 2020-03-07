namespace GeneralStoreInventoryManagementSystem
{
    partial class ReportsAnalyticsForm
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
            this.viewGraphsMenuSubOption = new System.Windows.Forms.ToolStripMenuItem();
            this.logsMenuSubOption = new System.Windows.Forms.ToolStripMenuItem();
            this.viewActivityLogsOption = new System.Windows.Forms.ToolStripMenuItem();
            this.viewErrorLogsOption = new System.Windows.Forms.ToolStripMenuItem();
            this.reportTabControl = new System.Windows.Forms.TabControl();
            this.usersTimesheetTabPage = new System.Windows.Forms.TabPage();
            this.printYesterdayTimesheetButton = new System.Windows.Forms.Button();
            this.printLastMonthTimesheetButton = new System.Windows.Forms.Button();
            this.printTimesheetButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.newestTimesheetDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.oldestTimesheetDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.timeSheetDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.usersSalesRecordsTabPage = new System.Windows.Forms.TabPage();
            this.returnsTotalLabel = new System.Windows.Forms.Label();
            this.numberOfReturnsLabel = new System.Windows.Forms.Label();
            this.salesTotalLabel = new System.Windows.Forms.Label();
            this.numberOfSalesLabel = new System.Windows.Forms.Label();
            this.printYesterdayRecordsButton = new System.Windows.Forms.Button();
            this.printLastMonthsRecordsButton = new System.Windows.Forms.Button();
            this.printSalesRecordsButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.newestSalesRecordDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.oldestSalesRecordDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.salesRecordsDataGridView = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.menuStrip1.SuspendLayout();
            this.reportTabControl.SuspendLayout();
            this.usersTimesheetTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeSheetDataGridView)).BeginInit();
            this.usersSalesRecordsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salesRecordsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // viewCartLabel
            // 
            this.viewCartLabel.AutoSize = true;
            this.viewCartLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.viewCartLabel.Location = new System.Drawing.Point(765, 9);
            this.viewCartLabel.Name = "viewCartLabel";
            this.viewCartLabel.Size = new System.Drawing.Size(52, 13);
            this.viewCartLabel.TabIndex = 12;
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
            this.logOutLabel.TabIndex = 11;
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
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ReportsAnalyticsForm_KeyDown);
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
            this.viewGraphsMenuSubOption,
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
            this.manageUsersMenuSubOption.Size = new System.Drawing.Size(158, 22);
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
            // viewGraphsMenuSubOption
            // 
            this.viewGraphsMenuSubOption.Name = "viewGraphsMenuSubOption";
            this.viewGraphsMenuSubOption.ShortcutKeyDisplayString = "F8";
            this.viewGraphsMenuSubOption.Size = new System.Drawing.Size(158, 22);
            this.viewGraphsMenuSubOption.Text = "View Graphs";
            this.viewGraphsMenuSubOption.Click += new System.EventHandler(this.ViewGraphsMenuSubOption_Click);
            // 
            // logsMenuSubOption
            // 
            this.logsMenuSubOption.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewActivityLogsOption,
            this.viewErrorLogsOption});
            this.logsMenuSubOption.Name = "logsMenuSubOption";
            this.logsMenuSubOption.Size = new System.Drawing.Size(158, 22);
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
            // reportTabControl
            // 
            this.reportTabControl.Controls.Add(this.usersTimesheetTabPage);
            this.reportTabControl.Controls.Add(this.usersSalesRecordsTabPage);
            this.reportTabControl.Controls.Add(this.tabPage1);
            this.reportTabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportTabControl.Location = new System.Drawing.Point(12, 27);
            this.reportTabControl.Name = "reportTabControl";
            this.reportTabControl.SelectedIndex = 0;
            this.reportTabControl.Size = new System.Drawing.Size(903, 523);
            this.reportTabControl.TabIndex = 13;
            this.reportTabControl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ReportsAnalyticsForm_KeyDown);
            // 
            // usersTimesheetTabPage
            // 
            this.usersTimesheetTabPage.Controls.Add(this.printYesterdayTimesheetButton);
            this.usersTimesheetTabPage.Controls.Add(this.printLastMonthTimesheetButton);
            this.usersTimesheetTabPage.Controls.Add(this.printTimesheetButton);
            this.usersTimesheetTabPage.Controls.Add(this.label3);
            this.usersTimesheetTabPage.Controls.Add(this.newestTimesheetDateTimePicker);
            this.usersTimesheetTabPage.Controls.Add(this.label2);
            this.usersTimesheetTabPage.Controls.Add(this.oldestTimesheetDateTimePicker);
            this.usersTimesheetTabPage.Controls.Add(this.timeSheetDataGridView);
            this.usersTimesheetTabPage.Controls.Add(this.label1);
            this.usersTimesheetTabPage.Location = new System.Drawing.Point(4, 22);
            this.usersTimesheetTabPage.Name = "usersTimesheetTabPage";
            this.usersTimesheetTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.usersTimesheetTabPage.Size = new System.Drawing.Size(895, 497);
            this.usersTimesheetTabPage.TabIndex = 0;
            this.usersTimesheetTabPage.Text = "Timesheets";
            this.usersTimesheetTabPage.UseVisualStyleBackColor = true;
            // 
            // printYesterdayTimesheetButton
            // 
            this.printYesterdayTimesheetButton.Location = new System.Drawing.Point(158, 379);
            this.printYesterdayTimesheetButton.Name = "printYesterdayTimesheetButton";
            this.printYesterdayTimesheetButton.Size = new System.Drawing.Size(194, 23);
            this.printYesterdayTimesheetButton.TabIndex = 8;
            this.printYesterdayTimesheetButton.Text = "Print Yesterday\'s Report";
            this.printYesterdayTimesheetButton.UseVisualStyleBackColor = true;
            this.printYesterdayTimesheetButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ReportsAnalyticsForm_KeyDown);
            // 
            // printLastMonthTimesheetButton
            // 
            this.printLastMonthTimesheetButton.Location = new System.Drawing.Point(358, 379);
            this.printLastMonthTimesheetButton.Name = "printLastMonthTimesheetButton";
            this.printLastMonthTimesheetButton.Size = new System.Drawing.Size(194, 23);
            this.printLastMonthTimesheetButton.TabIndex = 7;
            this.printLastMonthTimesheetButton.Text = "Print Last Month\'s Report";
            this.printLastMonthTimesheetButton.UseVisualStyleBackColor = true;
            this.printLastMonthTimesheetButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ReportsAnalyticsForm_KeyDown);
            // 
            // printTimesheetButton
            // 
            this.printTimesheetButton.Location = new System.Drawing.Point(644, 273);
            this.printTimesheetButton.Name = "printTimesheetButton";
            this.printTimesheetButton.Size = new System.Drawing.Size(200, 23);
            this.printTimesheetButton.TabIndex = 6;
            this.printTimesheetButton.Text = "Print Timesheet Report";
            this.printTimesheetButton.UseVisualStyleBackColor = true;
            this.printTimesheetButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ReportsAnalyticsForm_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(601, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Up to:";
            // 
            // newestTimesheetDateTimePicker
            // 
            this.newestTimesheetDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newestTimesheetDateTimePicker.Location = new System.Drawing.Point(644, 234);
            this.newestTimesheetDateTimePicker.Name = "newestTimesheetDateTimePicker";
            this.newestTimesheetDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.newestTimesheetDateTimePicker.TabIndex = 4;
            this.newestTimesheetDateTimePicker.ValueChanged += new System.EventHandler(this.NewestTimesheetDateTimePicker_ValueChanged);
            this.newestTimesheetDateTimePicker.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ReportsAnalyticsForm_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(601, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Starting From:";
            // 
            // oldestTimesheetDateTimePicker
            // 
            this.oldestTimesheetDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oldestTimesheetDateTimePicker.Location = new System.Drawing.Point(644, 185);
            this.oldestTimesheetDateTimePicker.Name = "oldestTimesheetDateTimePicker";
            this.oldestTimesheetDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.oldestTimesheetDateTimePicker.TabIndex = 2;
            this.oldestTimesheetDateTimePicker.ValueChanged += new System.EventHandler(this.OldestTimesheetDateTimePicker_ValueChanged);
            this.oldestTimesheetDateTimePicker.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ReportsAnalyticsForm_KeyDown);
            // 
            // timeSheetDataGridView
            // 
            this.timeSheetDataGridView.AllowUserToAddRows = false;
            this.timeSheetDataGridView.AllowUserToDeleteRows = false;
            this.timeSheetDataGridView.AllowUserToResizeColumns = false;
            this.timeSheetDataGridView.AllowUserToResizeRows = false;
            this.timeSheetDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.timeSheetDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.timeSheetDataGridView.Location = new System.Drawing.Point(61, 119);
            this.timeSheetDataGridView.MultiSelect = false;
            this.timeSheetDataGridView.Name = "timeSheetDataGridView";
            this.timeSheetDataGridView.ReadOnly = true;
            this.timeSheetDataGridView.RowHeadersVisible = false;
            this.timeSheetDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.timeSheetDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.timeSheetDataGridView.Size = new System.Drawing.Size(491, 254);
            this.timeSheetDataGridView.TabIndex = 1;
            this.timeSheetDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TimeSheetDataGridView_CellDoubleClick);
            this.timeSheetDataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ReportsAnalyticsForm_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Users\' Timesheets";
            // 
            // usersSalesRecordsTabPage
            // 
            this.usersSalesRecordsTabPage.Controls.Add(this.returnsTotalLabel);
            this.usersSalesRecordsTabPage.Controls.Add(this.numberOfReturnsLabel);
            this.usersSalesRecordsTabPage.Controls.Add(this.salesTotalLabel);
            this.usersSalesRecordsTabPage.Controls.Add(this.numberOfSalesLabel);
            this.usersSalesRecordsTabPage.Controls.Add(this.printYesterdayRecordsButton);
            this.usersSalesRecordsTabPage.Controls.Add(this.printLastMonthsRecordsButton);
            this.usersSalesRecordsTabPage.Controls.Add(this.printSalesRecordsButton);
            this.usersSalesRecordsTabPage.Controls.Add(this.label4);
            this.usersSalesRecordsTabPage.Controls.Add(this.newestSalesRecordDateTimePicker);
            this.usersSalesRecordsTabPage.Controls.Add(this.label5);
            this.usersSalesRecordsTabPage.Controls.Add(this.oldestSalesRecordDateTimePicker);
            this.usersSalesRecordsTabPage.Controls.Add(this.salesRecordsDataGridView);
            this.usersSalesRecordsTabPage.Controls.Add(this.label6);
            this.usersSalesRecordsTabPage.Location = new System.Drawing.Point(4, 22);
            this.usersSalesRecordsTabPage.Name = "usersSalesRecordsTabPage";
            this.usersSalesRecordsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.usersSalesRecordsTabPage.Size = new System.Drawing.Size(895, 497);
            this.usersSalesRecordsTabPage.TabIndex = 1;
            this.usersSalesRecordsTabPage.Text = "Sales Records";
            this.usersSalesRecordsTabPage.UseVisualStyleBackColor = true;
            this.usersSalesRecordsTabPage.Enter += new System.EventHandler(this.UsersSalesRecordsTabPage_Enter);
            // 
            // returnsTotalLabel
            // 
            this.returnsTotalLabel.AutoSize = true;
            this.returnsTotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnsTotalLabel.ForeColor = System.Drawing.Color.Red;
            this.returnsTotalLabel.Location = new System.Drawing.Point(275, 379);
            this.returnsTotalLabel.Name = "returnsTotalLabel";
            this.returnsTotalLabel.Size = new System.Drawing.Size(126, 17);
            this.returnsTotalLabel.TabIndex = 21;
            this.returnsTotalLabel.Text = "Returns Total: $";
            // 
            // numberOfReturnsLabel
            // 
            this.numberOfReturnsLabel.AutoSize = true;
            this.numberOfReturnsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberOfReturnsLabel.ForeColor = System.Drawing.Color.Red;
            this.numberOfReturnsLabel.Location = new System.Drawing.Point(62, 379);
            this.numberOfReturnsLabel.Name = "numberOfReturnsLabel";
            this.numberOfReturnsLabel.Size = new System.Drawing.Size(150, 17);
            this.numberOfReturnsLabel.TabIndex = 20;
            this.numberOfReturnsLabel.Text = "Number of Returns:";
            // 
            // salesTotalLabel
            // 
            this.salesTotalLabel.AutoSize = true;
            this.salesTotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesTotalLabel.ForeColor = System.Drawing.Color.DarkGreen;
            this.salesTotalLabel.Location = new System.Drawing.Point(292, 334);
            this.salesTotalLabel.Name = "salesTotalLabel";
            this.salesTotalLabel.Size = new System.Drawing.Size(109, 17);
            this.salesTotalLabel.TabIndex = 19;
            this.salesTotalLabel.Text = "Sales Total: $";
            // 
            // numberOfSalesLabel
            // 
            this.numberOfSalesLabel.AutoSize = true;
            this.numberOfSalesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberOfSalesLabel.ForeColor = System.Drawing.Color.DarkGreen;
            this.numberOfSalesLabel.Location = new System.Drawing.Point(79, 334);
            this.numberOfSalesLabel.Name = "numberOfSalesLabel";
            this.numberOfSalesLabel.Size = new System.Drawing.Size(133, 17);
            this.numberOfSalesLabel.TabIndex = 18;
            this.numberOfSalesLabel.Text = "Number of Sales:";
            // 
            // printYesterdayRecordsButton
            // 
            this.printYesterdayRecordsButton.Location = new System.Drawing.Point(150, 413);
            this.printYesterdayRecordsButton.Name = "printYesterdayRecordsButton";
            this.printYesterdayRecordsButton.Size = new System.Drawing.Size(200, 23);
            this.printYesterdayRecordsButton.TabIndex = 17;
            this.printYesterdayRecordsButton.Text = "Print Yesterday\'s Records";
            this.printYesterdayRecordsButton.UseVisualStyleBackColor = true;
            // 
            // printLastMonthsRecordsButton
            // 
            this.printLastMonthsRecordsButton.Location = new System.Drawing.Point(356, 413);
            this.printLastMonthsRecordsButton.Name = "printLastMonthsRecordsButton";
            this.printLastMonthsRecordsButton.Size = new System.Drawing.Size(200, 23);
            this.printLastMonthsRecordsButton.TabIndex = 16;
            this.printLastMonthsRecordsButton.Text = "Print Last Month\'s Records";
            this.printLastMonthsRecordsButton.UseVisualStyleBackColor = true;
            // 
            // printSalesRecordsButton
            // 
            this.printSalesRecordsButton.Location = new System.Drawing.Point(648, 231);
            this.printSalesRecordsButton.Name = "printSalesRecordsButton";
            this.printSalesRecordsButton.Size = new System.Drawing.Size(200, 23);
            this.printSalesRecordsButton.TabIndex = 15;
            this.printSalesRecordsButton.Text = "Print Sales Records";
            this.printSalesRecordsButton.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(605, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Up to:";
            // 
            // newestSalesRecordDateTimePicker
            // 
            this.newestSalesRecordDateTimePicker.Location = new System.Drawing.Point(648, 192);
            this.newestSalesRecordDateTimePicker.Name = "newestSalesRecordDateTimePicker";
            this.newestSalesRecordDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.newestSalesRecordDateTimePicker.TabIndex = 13;
            this.newestSalesRecordDateTimePicker.ValueChanged += new System.EventHandler(this.NewestSalesRecordDateTimePicker_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(605, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Starting From:";
            // 
            // oldestSalesRecordDateTimePicker
            // 
            this.oldestSalesRecordDateTimePicker.Location = new System.Drawing.Point(648, 143);
            this.oldestSalesRecordDateTimePicker.Name = "oldestSalesRecordDateTimePicker";
            this.oldestSalesRecordDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.oldestSalesRecordDateTimePicker.TabIndex = 11;
            this.oldestSalesRecordDateTimePicker.ValueChanged += new System.EventHandler(this.OldestSalesRecordDateTimePicker_ValueChanged);
            // 
            // salesRecordsDataGridView
            // 
            this.salesRecordsDataGridView.AllowUserToAddRows = false;
            this.salesRecordsDataGridView.AllowUserToDeleteRows = false;
            this.salesRecordsDataGridView.AllowUserToResizeColumns = false;
            this.salesRecordsDataGridView.AllowUserToResizeRows = false;
            this.salesRecordsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.salesRecordsDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.salesRecordsDataGridView.Location = new System.Drawing.Point(65, 77);
            this.salesRecordsDataGridView.MultiSelect = false;
            this.salesRecordsDataGridView.Name = "salesRecordsDataGridView";
            this.salesRecordsDataGridView.ReadOnly = true;
            this.salesRecordsDataGridView.RowHeadersVisible = false;
            this.salesRecordsDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.salesRecordsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.salesRecordsDataGridView.Size = new System.Drawing.Size(491, 254);
            this.salesRecordsDataGridView.TabIndex = 10;
            this.salesRecordsDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.salesRecordsDataGridView_CellDoubleClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(45, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(182, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Users\' Sales Records";
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(895, 497);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // ReportsAnalyticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 562);
            this.Controls.Add(this.reportTabControl);
            this.Controls.Add(this.viewCartLabel);
            this.Controls.Add(this.logOutLabel);
            this.Controls.Add(this.menuStrip1);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(943, 601);
            this.Name = "ReportsAnalyticsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Analytics --- Reports";
            this.Load += new System.EventHandler(this.ReportsAnalyticsForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ReportsAnalyticsForm_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.reportTabControl.ResumeLayout(false);
            this.usersTimesheetTabPage.ResumeLayout(false);
            this.usersTimesheetTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeSheetDataGridView)).EndInit();
            this.usersSalesRecordsTabPage.ResumeLayout(false);
            this.usersSalesRecordsTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salesRecordsDataGridView)).EndInit();
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
        private System.Windows.Forms.ToolStripMenuItem productsMenuOption;
        private System.Windows.Forms.ToolStripMenuItem browseProductsMenuSubOption;
        private System.Windows.Forms.ToolStripMenuItem registerNewProductMenuSubOption;
        private System.Windows.Forms.ToolStripMenuItem restockProductsMenuSubOption;
        private System.Windows.Forms.ToolStripMenuItem adminMenuOption;
        private System.Windows.Forms.ToolStripMenuItem manageUsersMenuSubOption;
        private System.Windows.Forms.ToolStripMenuItem viewUsersOption;
        private System.Windows.Forms.ToolStripMenuItem registerNewUserOption;
        private System.Windows.Forms.ToolStripMenuItem viewGraphsMenuSubOption;
        private System.Windows.Forms.ToolStripMenuItem logsMenuSubOption;
        private System.Windows.Forms.ToolStripMenuItem viewActivityLogsOption;
        private System.Windows.Forms.ToolStripMenuItem viewErrorLogsOption;
        private System.Windows.Forms.TabControl reportTabControl;
        private System.Windows.Forms.TabPage usersTimesheetTabPage;
        private System.Windows.Forms.TabPage usersSalesRecordsTabPage;
        private System.Windows.Forms.Button printLastMonthTimesheetButton;
        private System.Windows.Forms.Button printTimesheetButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker newestTimesheetDateTimePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker oldestTimesheetDateTimePicker;
        private System.Windows.Forms.DataGridView timeSheetDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button printYesterdayTimesheetButton;
        private System.Windows.Forms.Button printYesterdayRecordsButton;
        private System.Windows.Forms.Button printLastMonthsRecordsButton;
        private System.Windows.Forms.Button printSalesRecordsButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker newestSalesRecordDateTimePicker;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker oldestSalesRecordDateTimePicker;
        private System.Windows.Forms.DataGridView salesRecordsDataGridView;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label numberOfSalesLabel;
        private System.Windows.Forms.Label salesTotalLabel;
        private System.Windows.Forms.Label returnsTotalLabel;
        private System.Windows.Forms.Label numberOfReturnsLabel;
        private System.Windows.Forms.TabPage tabPage1;
    }
}