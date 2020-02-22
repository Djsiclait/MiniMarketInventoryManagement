namespace GeneralStoreInventoryManagementSystem
{
    partial class SalesRecordForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesRecordForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.makeSaleMenuOption = new System.Windows.Forms.ToolStripMenuItem();
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
            this.logsMenuSubOption = new System.Windows.Forms.ToolStripMenuItem();
            this.viewActivityLogsOption = new System.Windows.Forms.ToolStripMenuItem();
            this.viewErrorLogsOption = new System.Windows.Forms.ToolStripMenuItem();
            this.viewCartLabel = new System.Windows.Forms.Label();
            this.logOutLabel = new System.Windows.Forms.Label();
            this.searchLabel = new System.Windows.Forms.Label();
            this.salesList = new System.Windows.Forms.DataGridView();
            this.browserFormTitle = new System.Windows.Forms.Label();
            this.salesSearchBox = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salesList)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.makeSaleMenuOption,
            this.productsMenuOption,
            this.adminMenuOption});
            this.menuStrip1.Name = "menuStrip1";
            // 
            // makeSaleMenuOption
            // 
            resources.ApplyResources(this.makeSaleMenuOption, "makeSaleMenuOption");
            this.makeSaleMenuOption.Name = "makeSaleMenuOption";
            this.makeSaleMenuOption.Click += new System.EventHandler(this.MakeSaleMenuOption_Click);
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
            this.statisticsMenuSubOption,
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
            // statisticsMenuSubOption
            // 
            resources.ApplyResources(this.statisticsMenuSubOption, "statisticsMenuSubOption");
            this.statisticsMenuSubOption.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewGraphsOption,
            this.viewReportsOption});
            this.statisticsMenuSubOption.Name = "statisticsMenuSubOption";
            // 
            // viewGraphsOption
            // 
            resources.ApplyResources(this.viewGraphsOption, "viewGraphsOption");
            this.viewGraphsOption.Name = "viewGraphsOption";
            this.viewGraphsOption.Click += new System.EventHandler(this.ViewGraphsOption_Click);
            // 
            // viewReportsOption
            // 
            resources.ApplyResources(this.viewReportsOption, "viewReportsOption");
            this.viewReportsOption.Name = "viewReportsOption";
            this.viewReportsOption.Click += new System.EventHandler(this.ViewReportsOption_Click);
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
            // searchLabel
            // 
            resources.ApplyResources(this.searchLabel, "searchLabel");
            this.searchLabel.Name = "searchLabel";
            // 
            // salesList
            // 
            resources.ApplyResources(this.salesList, "salesList");
            this.salesList.AllowUserToAddRows = false;
            this.salesList.AllowUserToDeleteRows = false;
            this.salesList.AllowUserToResizeColumns = false;
            this.salesList.AllowUserToResizeRows = false;
            this.salesList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.salesList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.salesList.MultiSelect = false;
            this.salesList.Name = "salesList";
            this.salesList.RowHeadersVisible = false;
            this.salesList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.salesList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SalesList_CellDoubleClick);
            // 
            // browserFormTitle
            // 
            resources.ApplyResources(this.browserFormTitle, "browserFormTitle");
            this.browserFormTitle.Name = "browserFormTitle";
            // 
            // salesSearchBox
            // 
            resources.ApplyResources(this.salesSearchBox, "salesSearchBox");
            this.salesSearchBox.Name = "salesSearchBox";
            this.salesSearchBox.TextChanged += new System.EventHandler(this.SalesSearchBox_TextChanged);
            // 
            // SalesRecordForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.salesList);
            this.Controls.Add(this.browserFormTitle);
            this.Controls.Add(this.salesSearchBox);
            this.Controls.Add(this.viewCartLabel);
            this.Controls.Add(this.logOutLabel);
            this.Controls.Add(this.menuStrip1);
            this.Name = "SalesRecordForm";
            this.Load += new System.EventHandler(this.SalesRecordForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salesList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem makeSaleMenuOption;
        private System.Windows.Forms.ToolStripMenuItem productsMenuOption;
        private System.Windows.Forms.ToolStripMenuItem browseProductsMenuSubOption;
        private System.Windows.Forms.ToolStripMenuItem registerNewProductMenuSubOption;
        private System.Windows.Forms.ToolStripMenuItem restockProductsMenuSubOption;
        private System.Windows.Forms.ToolStripMenuItem adminMenuOption;
        private System.Windows.Forms.ToolStripMenuItem manageUsersMenuSubOption;
        private System.Windows.Forms.ToolStripMenuItem viewUsersOption;
        private System.Windows.Forms.ToolStripMenuItem registerNewUserOption;
        private System.Windows.Forms.ToolStripMenuItem statisticsMenuSubOption;
        private System.Windows.Forms.ToolStripMenuItem viewGraphsOption;
        private System.Windows.Forms.ToolStripMenuItem viewReportsOption;
        private System.Windows.Forms.ToolStripMenuItem logsMenuSubOption;
        private System.Windows.Forms.ToolStripMenuItem viewActivityLogsOption;
        private System.Windows.Forms.ToolStripMenuItem viewErrorLogsOption;
        private System.Windows.Forms.Label viewCartLabel;
        private System.Windows.Forms.Label logOutLabel;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.DataGridView salesList;
        private System.Windows.Forms.Label browserFormTitle;
        private System.Windows.Forms.TextBox salesSearchBox;
    }
}