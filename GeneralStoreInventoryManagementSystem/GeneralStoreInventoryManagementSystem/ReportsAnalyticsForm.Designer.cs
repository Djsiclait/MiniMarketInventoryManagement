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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportsAnalyticsForm));
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
            resources.ApplyResources(this.viewCartLabel, "viewCartLabel");
            this.viewCartLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.viewCartLabel.Name = "viewCartLabel";
            this.viewCartLabel.Click += new System.EventHandler(this.ViewCartLabel_Click);
            this.viewCartLabel.MouseLeave += new System.EventHandler(this.ViewCartLabel_MouseLeave);
            this.viewCartLabel.MouseHover += new System.EventHandler(this.ViewCartLabel_MouseHover);
            // 
            // logOutLabel
            // 
            resources.ApplyResources(this.logOutLabel, "logOutLabel");
            this.logOutLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.logOutLabel.Name = "logOutLabel";
            this.logOutLabel.Click += new System.EventHandler(this.LogOutLabel_Click);
            this.logOutLabel.MouseLeave += new System.EventHandler(this.LogOutLabel_MouseLeave);
            this.logOutLabel.MouseHover += new System.EventHandler(this.LogOutLabel_MouseHover);
            // 
            // menuStrip1
            // 
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salesMenuOption,
            this.productsMenuOption,
            this.adminMenuOption});
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ReportsAnalyticsForm_KeyDown);
            // 
            // salesMenuOption
            // 
            resources.ApplyResources(this.salesMenuOption, "salesMenuOption");
            this.salesMenuOption.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewSalesMenuSubOption,
            this.makeSaleMenuSubOption});
            this.salesMenuOption.Name = "salesMenuOption";
            // 
            // viewSalesMenuSubOption
            // 
            resources.ApplyResources(this.viewSalesMenuSubOption, "viewSalesMenuSubOption");
            this.viewSalesMenuSubOption.Name = "viewSalesMenuSubOption";
            this.viewSalesMenuSubOption.Click += new System.EventHandler(this.ViewSalesMenuSubOption_Click);
            // 
            // makeSaleMenuSubOption
            // 
            resources.ApplyResources(this.makeSaleMenuSubOption, "makeSaleMenuSubOption");
            this.makeSaleMenuSubOption.Name = "makeSaleMenuSubOption";
            this.makeSaleMenuSubOption.Click += new System.EventHandler(this.MakeSaleMenuSubOption_Click);
            // 
            // productsMenuOption
            // 
            resources.ApplyResources(this.productsMenuOption, "productsMenuOption");
            this.productsMenuOption.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.browseProductsMenuSubOption,
            this.registerNewProductMenuSubOption,
            this.restockProductsMenuSubOption});
            this.productsMenuOption.Name = "productsMenuOption";
            // 
            // browseProductsMenuSubOption
            // 
            resources.ApplyResources(this.browseProductsMenuSubOption, "browseProductsMenuSubOption");
            this.browseProductsMenuSubOption.Name = "browseProductsMenuSubOption";
            this.browseProductsMenuSubOption.Click += new System.EventHandler(this.BrowseProductsMenuSubOption_Click);
            // 
            // registerNewProductMenuSubOption
            // 
            resources.ApplyResources(this.registerNewProductMenuSubOption, "registerNewProductMenuSubOption");
            this.registerNewProductMenuSubOption.Name = "registerNewProductMenuSubOption";
            this.registerNewProductMenuSubOption.Click += new System.EventHandler(this.RegisterNewProductMenuSubOption_Click);
            // 
            // restockProductsMenuSubOption
            // 
            resources.ApplyResources(this.restockProductsMenuSubOption, "restockProductsMenuSubOption");
            this.restockProductsMenuSubOption.Name = "restockProductsMenuSubOption";
            this.restockProductsMenuSubOption.Click += new System.EventHandler(this.RestockProductsMenuSubOption_Click);
            // 
            // adminMenuOption
            // 
            resources.ApplyResources(this.adminMenuOption, "adminMenuOption");
            this.adminMenuOption.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageUsersMenuSubOption,
            this.viewGraphsMenuSubOption,
            this.logsMenuSubOption});
            this.adminMenuOption.Name = "adminMenuOption";
            // 
            // manageUsersMenuSubOption
            // 
            resources.ApplyResources(this.manageUsersMenuSubOption, "manageUsersMenuSubOption");
            this.manageUsersMenuSubOption.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewUsersOption,
            this.registerNewUserOption});
            this.manageUsersMenuSubOption.Name = "manageUsersMenuSubOption";
            // 
            // viewUsersOption
            // 
            resources.ApplyResources(this.viewUsersOption, "viewUsersOption");
            this.viewUsersOption.Name = "viewUsersOption";
            this.viewUsersOption.Click += new System.EventHandler(this.ViewUsersOption_Click);
            // 
            // registerNewUserOption
            // 
            resources.ApplyResources(this.registerNewUserOption, "registerNewUserOption");
            this.registerNewUserOption.Name = "registerNewUserOption";
            this.registerNewUserOption.Click += new System.EventHandler(this.RegisterNewUserOption_Click);
            // 
            // viewGraphsMenuSubOption
            // 
            resources.ApplyResources(this.viewGraphsMenuSubOption, "viewGraphsMenuSubOption");
            this.viewGraphsMenuSubOption.Name = "viewGraphsMenuSubOption";
            this.viewGraphsMenuSubOption.Click += new System.EventHandler(this.ViewGraphsMenuSubOption_Click);
            // 
            // logsMenuSubOption
            // 
            resources.ApplyResources(this.logsMenuSubOption, "logsMenuSubOption");
            this.logsMenuSubOption.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewActivityLogsOption,
            this.viewErrorLogsOption});
            this.logsMenuSubOption.Name = "logsMenuSubOption";
            // 
            // viewActivityLogsOption
            // 
            resources.ApplyResources(this.viewActivityLogsOption, "viewActivityLogsOption");
            this.viewActivityLogsOption.Name = "viewActivityLogsOption";
            this.viewActivityLogsOption.Click += new System.EventHandler(this.ViewActivityLogsOption_Click);
            // 
            // viewErrorLogsOption
            // 
            resources.ApplyResources(this.viewErrorLogsOption, "viewErrorLogsOption");
            this.viewErrorLogsOption.Name = "viewErrorLogsOption";
            this.viewErrorLogsOption.Click += new System.EventHandler(this.ViewErrorLogsOption_Click);
            // 
            // reportTabControl
            // 
            resources.ApplyResources(this.reportTabControl, "reportTabControl");
            this.reportTabControl.Controls.Add(this.usersTimesheetTabPage);
            this.reportTabControl.Controls.Add(this.usersSalesRecordsTabPage);
            this.reportTabControl.Controls.Add(this.tabPage1);
            this.reportTabControl.Name = "reportTabControl";
            this.reportTabControl.SelectedIndex = 0;
            this.reportTabControl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ReportsAnalyticsForm_KeyDown);
            // 
            // usersTimesheetTabPage
            // 
            resources.ApplyResources(this.usersTimesheetTabPage, "usersTimesheetTabPage");
            this.usersTimesheetTabPage.Controls.Add(this.printYesterdayTimesheetButton);
            this.usersTimesheetTabPage.Controls.Add(this.printLastMonthTimesheetButton);
            this.usersTimesheetTabPage.Controls.Add(this.printTimesheetButton);
            this.usersTimesheetTabPage.Controls.Add(this.label3);
            this.usersTimesheetTabPage.Controls.Add(this.newestTimesheetDateTimePicker);
            this.usersTimesheetTabPage.Controls.Add(this.label2);
            this.usersTimesheetTabPage.Controls.Add(this.oldestTimesheetDateTimePicker);
            this.usersTimesheetTabPage.Controls.Add(this.timeSheetDataGridView);
            this.usersTimesheetTabPage.Controls.Add(this.label1);
            this.usersTimesheetTabPage.Name = "usersTimesheetTabPage";
            this.usersTimesheetTabPage.UseVisualStyleBackColor = true;
            // 
            // printYesterdayTimesheetButton
            // 
            resources.ApplyResources(this.printYesterdayTimesheetButton, "printYesterdayTimesheetButton");
            this.printYesterdayTimesheetButton.Name = "printYesterdayTimesheetButton";
            this.printYesterdayTimesheetButton.UseVisualStyleBackColor = true;
            this.printYesterdayTimesheetButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ReportsAnalyticsForm_KeyDown);
            // 
            // printLastMonthTimesheetButton
            // 
            resources.ApplyResources(this.printLastMonthTimesheetButton, "printLastMonthTimesheetButton");
            this.printLastMonthTimesheetButton.Name = "printLastMonthTimesheetButton";
            this.printLastMonthTimesheetButton.UseVisualStyleBackColor = true;
            this.printLastMonthTimesheetButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ReportsAnalyticsForm_KeyDown);
            // 
            // printTimesheetButton
            // 
            resources.ApplyResources(this.printTimesheetButton, "printTimesheetButton");
            this.printTimesheetButton.Name = "printTimesheetButton";
            this.printTimesheetButton.UseVisualStyleBackColor = true;
            this.printTimesheetButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ReportsAnalyticsForm_KeyDown);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // newestTimesheetDateTimePicker
            // 
            resources.ApplyResources(this.newestTimesheetDateTimePicker, "newestTimesheetDateTimePicker");
            this.newestTimesheetDateTimePicker.Name = "newestTimesheetDateTimePicker";
            this.newestTimesheetDateTimePicker.ValueChanged += new System.EventHandler(this.NewestTimesheetDateTimePicker_ValueChanged);
            this.newestTimesheetDateTimePicker.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ReportsAnalyticsForm_KeyDown);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // oldestTimesheetDateTimePicker
            // 
            resources.ApplyResources(this.oldestTimesheetDateTimePicker, "oldestTimesheetDateTimePicker");
            this.oldestTimesheetDateTimePicker.Name = "oldestTimesheetDateTimePicker";
            this.oldestTimesheetDateTimePicker.ValueChanged += new System.EventHandler(this.OldestTimesheetDateTimePicker_ValueChanged);
            this.oldestTimesheetDateTimePicker.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ReportsAnalyticsForm_KeyDown);
            // 
            // timeSheetDataGridView
            // 
            resources.ApplyResources(this.timeSheetDataGridView, "timeSheetDataGridView");
            this.timeSheetDataGridView.AllowUserToAddRows = false;
            this.timeSheetDataGridView.AllowUserToDeleteRows = false;
            this.timeSheetDataGridView.AllowUserToResizeColumns = false;
            this.timeSheetDataGridView.AllowUserToResizeRows = false;
            this.timeSheetDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.timeSheetDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.timeSheetDataGridView.MultiSelect = false;
            this.timeSheetDataGridView.Name = "timeSheetDataGridView";
            this.timeSheetDataGridView.ReadOnly = true;
            this.timeSheetDataGridView.RowHeadersVisible = false;
            this.timeSheetDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.timeSheetDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TimeSheetDataGridView_CellDoubleClick);
            this.timeSheetDataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ReportsAnalyticsForm_KeyDown);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // usersSalesRecordsTabPage
            // 
            resources.ApplyResources(this.usersSalesRecordsTabPage, "usersSalesRecordsTabPage");
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
            this.usersSalesRecordsTabPage.Name = "usersSalesRecordsTabPage";
            this.usersSalesRecordsTabPage.UseVisualStyleBackColor = true;
            this.usersSalesRecordsTabPage.Enter += new System.EventHandler(this.UsersSalesRecordsTabPage_Enter);
            // 
            // returnsTotalLabel
            // 
            resources.ApplyResources(this.returnsTotalLabel, "returnsTotalLabel");
            this.returnsTotalLabel.ForeColor = System.Drawing.Color.Red;
            this.returnsTotalLabel.Name = "returnsTotalLabel";
            // 
            // numberOfReturnsLabel
            // 
            resources.ApplyResources(this.numberOfReturnsLabel, "numberOfReturnsLabel");
            this.numberOfReturnsLabel.ForeColor = System.Drawing.Color.Red;
            this.numberOfReturnsLabel.Name = "numberOfReturnsLabel";
            // 
            // salesTotalLabel
            // 
            resources.ApplyResources(this.salesTotalLabel, "salesTotalLabel");
            this.salesTotalLabel.ForeColor = System.Drawing.Color.DarkGreen;
            this.salesTotalLabel.Name = "salesTotalLabel";
            // 
            // numberOfSalesLabel
            // 
            resources.ApplyResources(this.numberOfSalesLabel, "numberOfSalesLabel");
            this.numberOfSalesLabel.ForeColor = System.Drawing.Color.DarkGreen;
            this.numberOfSalesLabel.Name = "numberOfSalesLabel";
            // 
            // printYesterdayRecordsButton
            // 
            resources.ApplyResources(this.printYesterdayRecordsButton, "printYesterdayRecordsButton");
            this.printYesterdayRecordsButton.Name = "printYesterdayRecordsButton";
            this.printYesterdayRecordsButton.UseVisualStyleBackColor = true;
            // 
            // printLastMonthsRecordsButton
            // 
            resources.ApplyResources(this.printLastMonthsRecordsButton, "printLastMonthsRecordsButton");
            this.printLastMonthsRecordsButton.Name = "printLastMonthsRecordsButton";
            this.printLastMonthsRecordsButton.UseVisualStyleBackColor = true;
            // 
            // printSalesRecordsButton
            // 
            resources.ApplyResources(this.printSalesRecordsButton, "printSalesRecordsButton");
            this.printSalesRecordsButton.Name = "printSalesRecordsButton";
            this.printSalesRecordsButton.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // newestSalesRecordDateTimePicker
            // 
            resources.ApplyResources(this.newestSalesRecordDateTimePicker, "newestSalesRecordDateTimePicker");
            this.newestSalesRecordDateTimePicker.Name = "newestSalesRecordDateTimePicker";
            this.newestSalesRecordDateTimePicker.ValueChanged += new System.EventHandler(this.NewestSalesRecordDateTimePicker_ValueChanged);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // oldestSalesRecordDateTimePicker
            // 
            resources.ApplyResources(this.oldestSalesRecordDateTimePicker, "oldestSalesRecordDateTimePicker");
            this.oldestSalesRecordDateTimePicker.Name = "oldestSalesRecordDateTimePicker";
            this.oldestSalesRecordDateTimePicker.ValueChanged += new System.EventHandler(this.OldestSalesRecordDateTimePicker_ValueChanged);
            // 
            // salesRecordsDataGridView
            // 
            resources.ApplyResources(this.salesRecordsDataGridView, "salesRecordsDataGridView");
            this.salesRecordsDataGridView.AllowUserToAddRows = false;
            this.salesRecordsDataGridView.AllowUserToDeleteRows = false;
            this.salesRecordsDataGridView.AllowUserToResizeColumns = false;
            this.salesRecordsDataGridView.AllowUserToResizeRows = false;
            this.salesRecordsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.salesRecordsDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.salesRecordsDataGridView.MultiSelect = false;
            this.salesRecordsDataGridView.Name = "salesRecordsDataGridView";
            this.salesRecordsDataGridView.ReadOnly = true;
            this.salesRecordsDataGridView.RowHeadersVisible = false;
            this.salesRecordsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.salesRecordsDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.salesRecordsDataGridView_CellDoubleClick);
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // tabPage1
            // 
            resources.ApplyResources(this.tabPage1, "tabPage1");
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // ReportsAnalyticsForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.reportTabControl);
            this.Controls.Add(this.viewCartLabel);
            this.Controls.Add(this.logOutLabel);
            this.Controls.Add(this.menuStrip1);
            this.MaximizeBox = false;
            this.Name = "ReportsAnalyticsForm";
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