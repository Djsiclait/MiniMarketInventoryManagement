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
            this.userTimesheetTabPage = new System.Windows.Forms.TabPage();
            this.printYesterdayButton = new System.Windows.Forms.Button();
            this.printLastMonthButton = new System.Windows.Forms.Button();
            this.printTimesheetButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.newestDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.oldestDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.timeSheetDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.menuStrip1.SuspendLayout();
            this.reportTabControl.SuspendLayout();
            this.userTimesheetTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeSheetDataGridView)).BeginInit();
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
            this.reportTabControl.Controls.Add(this.userTimesheetTabPage);
            this.reportTabControl.Controls.Add(this.tabPage2);
            this.reportTabControl.Location = new System.Drawing.Point(12, 27);
            this.reportTabControl.Name = "reportTabControl";
            this.reportTabControl.SelectedIndex = 0;
            this.reportTabControl.Size = new System.Drawing.Size(903, 523);
            this.reportTabControl.TabIndex = 13;
            this.reportTabControl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ReportsAnalyticsForm_KeyDown);
            // 
            // userTimesheetTabPage
            // 
            this.userTimesheetTabPage.Controls.Add(this.printYesterdayButton);
            this.userTimesheetTabPage.Controls.Add(this.printLastMonthButton);
            this.userTimesheetTabPage.Controls.Add(this.printTimesheetButton);
            this.userTimesheetTabPage.Controls.Add(this.label3);
            this.userTimesheetTabPage.Controls.Add(this.newestDateTimePicker);
            this.userTimesheetTabPage.Controls.Add(this.label2);
            this.userTimesheetTabPage.Controls.Add(this.oldestDateTimePicker);
            this.userTimesheetTabPage.Controls.Add(this.timeSheetDataGridView);
            this.userTimesheetTabPage.Controls.Add(this.label1);
            this.userTimesheetTabPage.Location = new System.Drawing.Point(4, 22);
            this.userTimesheetTabPage.Name = "userTimesheetTabPage";
            this.userTimesheetTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.userTimesheetTabPage.Size = new System.Drawing.Size(895, 497);
            this.userTimesheetTabPage.TabIndex = 0;
            this.userTimesheetTabPage.Text = "User Timesheets";
            this.userTimesheetTabPage.UseVisualStyleBackColor = true;
            // 
            // printYesterdayButton
            // 
            this.printYesterdayButton.Location = new System.Drawing.Point(158, 379);
            this.printYesterdayButton.Name = "printYesterdayButton";
            this.printYesterdayButton.Size = new System.Drawing.Size(194, 23);
            this.printYesterdayButton.TabIndex = 8;
            this.printYesterdayButton.Text = "Print Yesterday\'s Report";
            this.printYesterdayButton.UseVisualStyleBackColor = true;
            this.printYesterdayButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ReportsAnalyticsForm_KeyDown);
            // 
            // printLastMonthButton
            // 
            this.printLastMonthButton.Location = new System.Drawing.Point(358, 379);
            this.printLastMonthButton.Name = "printLastMonthButton";
            this.printLastMonthButton.Size = new System.Drawing.Size(194, 23);
            this.printLastMonthButton.TabIndex = 7;
            this.printLastMonthButton.Text = "Print Last Month\'s Report";
            this.printLastMonthButton.UseVisualStyleBackColor = true;
            this.printLastMonthButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ReportsAnalyticsForm_KeyDown);
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
            this.label3.Location = new System.Drawing.Point(601, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Up to:";
            // 
            // newestDateTimePicker
            // 
            this.newestDateTimePicker.Location = new System.Drawing.Point(644, 234);
            this.newestDateTimePicker.Name = "newestDateTimePicker";
            this.newestDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.newestDateTimePicker.TabIndex = 4;
            this.newestDateTimePicker.ValueChanged += new System.EventHandler(this.newestDateTimePicker_ValueChanged);
            this.newestDateTimePicker.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ReportsAnalyticsForm_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(601, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Starting From:";
            // 
            // oldestDateTimePicker
            // 
            this.oldestDateTimePicker.Location = new System.Drawing.Point(644, 185);
            this.oldestDateTimePicker.Name = "oldestDateTimePicker";
            this.oldestDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.oldestDateTimePicker.TabIndex = 2;
            this.oldestDateTimePicker.ValueChanged += new System.EventHandler(this.oldestDateTimePicker_ValueChanged);
            this.oldestDateTimePicker.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ReportsAnalyticsForm_KeyDown);
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
            this.label1.Size = new System.Drawing.Size(140, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Timesheet ";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(895, 497);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            this.Name = "ReportsAnalyticsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Analytics --- Reports";
            this.Load += new System.EventHandler(this.ReportsAnalyticsForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ReportsAnalyticsForm_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.reportTabControl.ResumeLayout(false);
            this.userTimesheetTabPage.ResumeLayout(false);
            this.userTimesheetTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeSheetDataGridView)).EndInit();
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
        private System.Windows.Forms.TabPage userTimesheetTabPage;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button printLastMonthButton;
        private System.Windows.Forms.Button printTimesheetButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker newestDateTimePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker oldestDateTimePicker;
        private System.Windows.Forms.DataGridView timeSheetDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button printYesterdayButton;
    }
}