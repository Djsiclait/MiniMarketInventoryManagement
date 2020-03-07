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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GraphsAnalyticsForm));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
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
            this.totalLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timeComboBox = new System.Windows.Forms.ComboBox();
            this.printTimesheetButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.newestBubbleDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.usernamesListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timesheetChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.timesheetTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timesheetChart)).BeginInit();
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
            this.menuStrip1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GraphsAnalyticsForm_KeyDown);
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
            this.viewReportsMenuSubOption,
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
            // viewReportsMenuSubOption
            // 
            resources.ApplyResources(this.viewReportsMenuSubOption, "viewReportsMenuSubOption");
            this.viewReportsMenuSubOption.Name = "viewReportsMenuSubOption";
            this.viewReportsMenuSubOption.Click += new System.EventHandler(this.ViewReportsMenuSubOption_Click);
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
            // tabControl1
            // 
            resources.ApplyResources(this.tabControl1, "tabControl1");
            this.tabControl1.Controls.Add(this.timesheetTabPage);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GraphsAnalyticsForm_KeyDown);
            // 
            // timesheetTabPage
            // 
            resources.ApplyResources(this.timesheetTabPage, "timesheetTabPage");
            this.timesheetTabPage.Controls.Add(this.shownMessageLabel);
            this.timesheetTabPage.Controls.Add(this.missingMessageLabel);
            this.timesheetTabPage.Controls.Add(this.missingLabel);
            this.timesheetTabPage.Controls.Add(this.shownLabel);
            this.timesheetTabPage.Controls.Add(this.totalLabel);
            this.timesheetTabPage.Controls.Add(this.label3);
            this.timesheetTabPage.Controls.Add(this.timeComboBox);
            this.timesheetTabPage.Controls.Add(this.printTimesheetButton);
            this.timesheetTabPage.Controls.Add(this.label4);
            this.timesheetTabPage.Controls.Add(this.newestBubbleDateTimePicker);
            this.timesheetTabPage.Controls.Add(this.searchTextBox);
            this.timesheetTabPage.Controls.Add(this.usernamesListBox);
            this.timesheetTabPage.Controls.Add(this.label2);
            this.timesheetTabPage.Controls.Add(this.label1);
            this.timesheetTabPage.Controls.Add(this.timesheetChart);
            this.timesheetTabPage.Name = "timesheetTabPage";
            this.timesheetTabPage.UseVisualStyleBackColor = true;
            // 
            // shownMessageLabel
            // 
            resources.ApplyResources(this.shownMessageLabel, "shownMessageLabel");
            this.shownMessageLabel.BackColor = System.Drawing.Color.PowderBlue;
            this.shownMessageLabel.Name = "shownMessageLabel";
            // 
            // missingMessageLabel
            // 
            resources.ApplyResources(this.missingMessageLabel, "missingMessageLabel");
            this.missingMessageLabel.BackColor = System.Drawing.Color.PowderBlue;
            this.missingMessageLabel.Name = "missingMessageLabel";
            // 
            // missingLabel
            // 
            resources.ApplyResources(this.missingLabel, "missingLabel");
            this.missingLabel.Name = "missingLabel";
            this.missingLabel.MouseLeave += new System.EventHandler(this.MissingLabel_MouseLeave);
            this.missingLabel.MouseHover += new System.EventHandler(this.MissingLabel_MouseHover);
            // 
            // shownLabel
            // 
            resources.ApplyResources(this.shownLabel, "shownLabel");
            this.shownLabel.Name = "shownLabel";
            this.shownLabel.MouseLeave += new System.EventHandler(this.ShownLabel_MouseLeave);
            this.shownLabel.MouseHover += new System.EventHandler(this.ShownLabel_MouseHover);
            // 
            // totalLabel
            // 
            resources.ApplyResources(this.totalLabel, "totalLabel");
            this.totalLabel.Name = "totalLabel";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // timeComboBox
            // 
            resources.ApplyResources(this.timeComboBox, "timeComboBox");
            this.timeComboBox.FormattingEnabled = true;
            this.timeComboBox.Name = "timeComboBox";
            this.timeComboBox.SelectedIndexChanged += new System.EventHandler(this.TimeComboBox_SelectedIndexChanged);
            // 
            // printTimesheetButton
            // 
            resources.ApplyResources(this.printTimesheetButton, "printTimesheetButton");
            this.printTimesheetButton.Name = "printTimesheetButton";
            this.printTimesheetButton.UseVisualStyleBackColor = true;
            this.printTimesheetButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GraphsAnalyticsForm_KeyDown);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // newestBubbleDateTimePicker
            // 
            resources.ApplyResources(this.newestBubbleDateTimePicker, "newestBubbleDateTimePicker");
            this.newestBubbleDateTimePicker.Name = "newestBubbleDateTimePicker";
            this.newestBubbleDateTimePicker.ValueChanged += new System.EventHandler(this.NewestBubbleDateTimePicker_ValueChanged);
            this.newestBubbleDateTimePicker.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GraphsAnalyticsForm_KeyDown);
            // 
            // searchTextBox
            // 
            resources.ApplyResources(this.searchTextBox, "searchTextBox");
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.TextChanged += new System.EventHandler(this.SearchTextBox_TextChanged);
            // 
            // usernamesListBox
            // 
            resources.ApplyResources(this.usernamesListBox, "usernamesListBox");
            this.usernamesListBox.FormattingEnabled = true;
            this.usernamesListBox.Name = "usernamesListBox";
            this.usernamesListBox.Click += new System.EventHandler(this.UsernamesListBox_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // timesheetChart
            // 
            resources.ApplyResources(this.timesheetChart, "timesheetChart");
            this.timesheetChart.BackColor = System.Drawing.Color.Gainsboro;
            chartArea1.Name = "BubbleChartArea";
            this.timesheetChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.timesheetChart.Legends.Add(legend1);
            this.timesheetChart.Name = "timesheetChart";
            series1.ChartArea = "BubbleChartArea";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bubble;
            series1.Legend = "Legend1";
            series1.Name = "User";
            series1.YValuesPerPoint = 2;
            this.timesheetChart.Series.Add(series1);
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            title1.Name = "Title1";
            title1.Text = "User Timesheet";
            this.timesheetChart.Titles.Add(title1);
            // 
            // tabPage2
            // 
            resources.ApplyResources(this.tabPage2, "tabPage2");
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // GraphsAnalyticsForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.viewCartLabel);
            this.Controls.Add(this.logOutLabel);
            this.Controls.Add(this.menuStrip1);
            this.MaximizeBox = false;
            this.Name = "GraphsAnalyticsForm";
            this.Load += new System.EventHandler(this.GraphsAnalyticsForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GraphsAnalyticsForm_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.timesheetTabPage.ResumeLayout(false);
            this.timesheetTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timesheetChart)).EndInit();
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
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart timesheetChart;
        private System.Windows.Forms.ListBox usernamesListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker newestBubbleDateTimePicker;
        private System.Windows.Forms.Button printTimesheetButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox timeComboBox;
        private System.Windows.Forms.Label missingLabel;
        private System.Windows.Forms.Label shownLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label missingMessageLabel;
        private System.Windows.Forms.Label shownMessageLabel;
    }
}