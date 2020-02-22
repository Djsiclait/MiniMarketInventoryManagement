namespace GeneralStoreInventoryManagementSystem
{
    partial class ActivitiesLogForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActivitiesLogForm));
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
            this.statisticsMenuSubOption = new System.Windows.Forms.ToolStripMenuItem();
            this.viewGraphsOption = new System.Windows.Forms.ToolStripMenuItem();
            this.viewReportsOption = new System.Windows.Forms.ToolStripMenuItem();
            this.viewErrorLogsMenuSubOption = new System.Windows.Forms.ToolStripMenuItem();
            this.searchLabel = new System.Windows.Forms.Label();
            this.activityList = new System.Windows.Forms.DataGridView();
            this.activityFormTitle = new System.Windows.Forms.Label();
            this.activitySearchBox = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.activityList)).BeginInit();
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
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salesMenuOption,
            this.productsMenuOption,
            this.adminMenuOption});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // salesMenuOption
            // 
            this.salesMenuOption.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewSalesMenuSubOption,
            this.makeSaleMenuSubOption});
            this.salesMenuOption.Name = "salesMenuOption";
            resources.ApplyResources(this.salesMenuOption, "salesMenuOption");
            // 
            // viewSalesMenuSubOption
            // 
            this.viewSalesMenuSubOption.Name = "viewSalesMenuSubOption";
            resources.ApplyResources(this.viewSalesMenuSubOption, "viewSalesMenuSubOption");
            this.viewSalesMenuSubOption.Click += new System.EventHandler(this.ViewSalesMenuSubOption_Click);
            // 
            // makeSaleMenuSubOption
            // 
            this.makeSaleMenuSubOption.Name = "makeSaleMenuSubOption";
            resources.ApplyResources(this.makeSaleMenuSubOption, "makeSaleMenuSubOption");
            this.makeSaleMenuSubOption.Click += new System.EventHandler(this.MakeSaleMenuSubOption_Click);
            // 
            // productsMenuOption
            // 
            this.productsMenuOption.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.browseProductsMenuSubOption,
            this.registerNewProductMenuSubOption,
            this.restockProductsMenuSubOption});
            this.productsMenuOption.Name = "productsMenuOption";
            resources.ApplyResources(this.productsMenuOption, "productsMenuOption");
            // 
            // browseProductsMenuSubOption
            // 
            this.browseProductsMenuSubOption.Name = "browseProductsMenuSubOption";
            resources.ApplyResources(this.browseProductsMenuSubOption, "browseProductsMenuSubOption");
            this.browseProductsMenuSubOption.Click += new System.EventHandler(this.BrowseProductsMenuSubOption_Click);
            // 
            // registerNewProductMenuSubOption
            // 
            this.registerNewProductMenuSubOption.Name = "registerNewProductMenuSubOption";
            resources.ApplyResources(this.registerNewProductMenuSubOption, "registerNewProductMenuSubOption");
            this.registerNewProductMenuSubOption.Click += new System.EventHandler(this.RegisterNewProductMenuSubOption_Click);
            // 
            // restockProductsMenuSubOption
            // 
            this.restockProductsMenuSubOption.Name = "restockProductsMenuSubOption";
            resources.ApplyResources(this.restockProductsMenuSubOption, "restockProductsMenuSubOption");
            this.restockProductsMenuSubOption.Click += new System.EventHandler(this.RestockProductsMenuSubOption_Click);
            // 
            // adminMenuOption
            // 
            this.adminMenuOption.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageUsersMenuSubOption,
            this.statisticsMenuSubOption,
            this.viewErrorLogsMenuSubOption});
            this.adminMenuOption.Name = "adminMenuOption";
            resources.ApplyResources(this.adminMenuOption, "adminMenuOption");
            // 
            // manageUsersMenuSubOption
            // 
            this.manageUsersMenuSubOption.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewUsersOption,
            this.registerNewUserOption});
            this.manageUsersMenuSubOption.Name = "manageUsersMenuSubOption";
            resources.ApplyResources(this.manageUsersMenuSubOption, "manageUsersMenuSubOption");
            // 
            // viewUsersOption
            // 
            this.viewUsersOption.Name = "viewUsersOption";
            resources.ApplyResources(this.viewUsersOption, "viewUsersOption");
            this.viewUsersOption.Click += new System.EventHandler(this.ViewUsersOption_Click);
            // 
            // registerNewUserOption
            // 
            this.registerNewUserOption.Name = "registerNewUserOption";
            resources.ApplyResources(this.registerNewUserOption, "registerNewUserOption");
            this.registerNewUserOption.Click += new System.EventHandler(this.RegisterNewUserOption_Click);
            // 
            // statisticsMenuSubOption
            // 
            this.statisticsMenuSubOption.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewGraphsOption,
            this.viewReportsOption});
            this.statisticsMenuSubOption.Name = "statisticsMenuSubOption";
            resources.ApplyResources(this.statisticsMenuSubOption, "statisticsMenuSubOption");
            // 
            // viewGraphsOption
            // 
            this.viewGraphsOption.Name = "viewGraphsOption";
            resources.ApplyResources(this.viewGraphsOption, "viewGraphsOption");
            this.viewGraphsOption.Click += new System.EventHandler(this.ViewGraphsOption_Click);
            // 
            // viewReportsOption
            // 
            this.viewReportsOption.Name = "viewReportsOption";
            resources.ApplyResources(this.viewReportsOption, "viewReportsOption");
            this.viewReportsOption.Click += new System.EventHandler(this.ViewReportsOption_Click);
            // 
            // viewErrorLogsMenuSubOption
            // 
            this.viewErrorLogsMenuSubOption.Name = "viewErrorLogsMenuSubOption";
            resources.ApplyResources(this.viewErrorLogsMenuSubOption, "viewErrorLogsMenuSubOption");
            this.viewErrorLogsMenuSubOption.Click += new System.EventHandler(this.ViewErrorLogsMenuSubOption_Click);
            // 
            // searchLabel
            // 
            resources.ApplyResources(this.searchLabel, "searchLabel");
            this.searchLabel.Name = "searchLabel";
            // 
            // activityList
            // 
            this.activityList.AllowUserToAddRows = false;
            this.activityList.AllowUserToDeleteRows = false;
            this.activityList.AllowUserToResizeColumns = false;
            this.activityList.AllowUserToResizeRows = false;
            this.activityList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.activityList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            resources.ApplyResources(this.activityList, "activityList");
            this.activityList.MultiSelect = false;
            this.activityList.Name = "activityList";
            this.activityList.RowHeadersVisible = false;
            this.activityList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // activityFormTitle
            // 
            resources.ApplyResources(this.activityFormTitle, "activityFormTitle");
            this.activityFormTitle.Name = "activityFormTitle";
            // 
            // activitySearchBox
            // 
            resources.ApplyResources(this.activitySearchBox, "activitySearchBox");
            this.activitySearchBox.Name = "activitySearchBox";
            this.activitySearchBox.TextChanged += new System.EventHandler(this.ActivitySearchBox_TextChanged);
            // 
            // ActivitiesLogForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.activityList);
            this.Controls.Add(this.activityFormTitle);
            this.Controls.Add(this.activitySearchBox);
            this.Controls.Add(this.viewCartLabel);
            this.Controls.Add(this.logOutLabel);
            this.Controls.Add(this.menuStrip1);
            this.Name = "ActivitiesLogForm";
            this.Load += new System.EventHandler(this.ActivitiesLogForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.activityList)).EndInit();
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
        private System.Windows.Forms.ToolStripMenuItem statisticsMenuSubOption;
        private System.Windows.Forms.ToolStripMenuItem viewGraphsOption;
        private System.Windows.Forms.ToolStripMenuItem viewReportsOption;
        private System.Windows.Forms.ToolStripMenuItem viewErrorLogsMenuSubOption;
        private System.Windows.Forms.ToolStripMenuItem productsMenuOption;
        private System.Windows.Forms.ToolStripMenuItem browseProductsMenuSubOption;
        private System.Windows.Forms.ToolStripMenuItem registerNewProductMenuSubOption;
        private System.Windows.Forms.ToolStripMenuItem restockProductsMenuSubOption;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.DataGridView activityList;
        private System.Windows.Forms.Label activityFormTitle;
        private System.Windows.Forms.TextBox activitySearchBox;
    }
}