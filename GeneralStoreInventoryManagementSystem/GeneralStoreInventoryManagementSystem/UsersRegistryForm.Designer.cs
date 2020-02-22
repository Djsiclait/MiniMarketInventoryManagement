namespace GeneralStoreInventoryManagementSystem
{
    partial class UsersRegistryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsersRegistryForm));
            this.viewCartLabel = new System.Windows.Forms.Label();
            this.LogOutLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.salesMenuOption = new System.Windows.Forms.ToolStripMenuItem();
            this.viewSalesMenuSubOption = new System.Windows.Forms.ToolStripMenuItem();
            this.makeSaleMenuSubOption = new System.Windows.Forms.ToolStripMenuItem();
            this.productsMenuOption = new System.Windows.Forms.ToolStripMenuItem();
            this.browseProductsMenuSubOption = new System.Windows.Forms.ToolStripMenuItem();
            this.registerNewProductMenuSubOption = new System.Windows.Forms.ToolStripMenuItem();
            this.restockProductsMenuSubOption = new System.Windows.Forms.ToolStripMenuItem();
            this.adminMenuOption = new System.Windows.Forms.ToolStripMenuItem();
            this.registerNewUserMenuSubOption = new System.Windows.Forms.ToolStripMenuItem();
            this.statisticsMenuSubOption = new System.Windows.Forms.ToolStripMenuItem();
            this.viewGraphsOption = new System.Windows.Forms.ToolStripMenuItem();
            this.viewReportsOption = new System.Windows.Forms.ToolStripMenuItem();
            this.logsMenuSubOption = new System.Windows.Forms.ToolStripMenuItem();
            this.viewActivityLogsOption = new System.Windows.Forms.ToolStripMenuItem();
            this.viewErrorLogsOption = new System.Windows.Forms.ToolStripMenuItem();
            this.searchLabel = new System.Windows.Forms.Label();
            this.userList = new System.Windows.Forms.DataGridView();
            this.browserFormTitle = new System.Windows.Forms.Label();
            this.userSearchBox = new System.Windows.Forms.TextBox();
            this.profileButton = new System.Windows.Forms.Button();
            this.activityList = new System.Windows.Forms.DataGridView();
            this.activityTitleLabel = new System.Windows.Forms.Label();
            this.searchActivityLabel = new System.Windows.Forms.Label();
            this.activitySearchBox = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userList)).BeginInit();
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
            // LogOutLabel
            // 
            resources.ApplyResources(this.LogOutLabel, "LogOutLabel");
            this.LogOutLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LogOutLabel.Name = "LogOutLabel";
            this.LogOutLabel.Click += new System.EventHandler(this.LogOutLabel_Click);
            this.LogOutLabel.MouseLeave += new System.EventHandler(this.LogOutLabel_MouseLeave);
            this.LogOutLabel.MouseHover += new System.EventHandler(this.LogOutLabel_MouseHover);
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
            this.registerNewUserMenuSubOption,
            this.statisticsMenuSubOption,
            this.logsMenuSubOption});
            this.adminMenuOption.Name = "adminMenuOption";
            // 
            // registerNewUserMenuSubOption
            // 
            resources.ApplyResources(this.registerNewUserMenuSubOption, "registerNewUserMenuSubOption");
            this.registerNewUserMenuSubOption.Name = "registerNewUserMenuSubOption";
            this.registerNewUserMenuSubOption.Click += new System.EventHandler(this.RegisterNewUserMenuSubOption_Click);
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
            // searchLabel
            // 
            resources.ApplyResources(this.searchLabel, "searchLabel");
            this.searchLabel.Name = "searchLabel";
            // 
            // userList
            // 
            resources.ApplyResources(this.userList, "userList");
            this.userList.AllowUserToAddRows = false;
            this.userList.AllowUserToDeleteRows = false;
            this.userList.AllowUserToResizeColumns = false;
            this.userList.AllowUserToResizeRows = false;
            this.userList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.userList.MultiSelect = false;
            this.userList.Name = "userList";
            this.userList.RowHeadersVisible = false;
            this.userList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.userList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UserList_CellDoubleClick);
            // 
            // browserFormTitle
            // 
            resources.ApplyResources(this.browserFormTitle, "browserFormTitle");
            this.browserFormTitle.Name = "browserFormTitle";
            // 
            // userSearchBox
            // 
            resources.ApplyResources(this.userSearchBox, "userSearchBox");
            this.userSearchBox.Name = "userSearchBox";
            this.userSearchBox.TextChanged += new System.EventHandler(this.UserSearchBox_TextChanged);
            // 
            // profileButton
            // 
            resources.ApplyResources(this.profileButton, "profileButton");
            this.profileButton.Name = "profileButton";
            this.profileButton.UseVisualStyleBackColor = true;
            this.profileButton.Click += new System.EventHandler(this.ProfileButton_Click);
            // 
            // activityList
            // 
            resources.ApplyResources(this.activityList, "activityList");
            this.activityList.AllowUserToAddRows = false;
            this.activityList.AllowUserToDeleteRows = false;
            this.activityList.AllowUserToResizeColumns = false;
            this.activityList.AllowUserToResizeRows = false;
            this.activityList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.activityList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.activityList.MultiSelect = false;
            this.activityList.Name = "activityList";
            this.activityList.RowHeadersVisible = false;
            this.activityList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // activityTitleLabel
            // 
            resources.ApplyResources(this.activityTitleLabel, "activityTitleLabel");
            this.activityTitleLabel.Name = "activityTitleLabel";
            // 
            // searchActivityLabel
            // 
            resources.ApplyResources(this.searchActivityLabel, "searchActivityLabel");
            this.searchActivityLabel.Name = "searchActivityLabel";
            // 
            // activitySearchBox
            // 
            resources.ApplyResources(this.activitySearchBox, "activitySearchBox");
            this.activitySearchBox.Name = "activitySearchBox";
            this.activitySearchBox.TextChanged += new System.EventHandler(this.activitySearchBox_TextChanged);
            // 
            // UsersRegistryForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.searchActivityLabel);
            this.Controls.Add(this.activitySearchBox);
            this.Controls.Add(this.activityTitleLabel);
            this.Controls.Add(this.activityList);
            this.Controls.Add(this.profileButton);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.userList);
            this.Controls.Add(this.browserFormTitle);
            this.Controls.Add(this.userSearchBox);
            this.Controls.Add(this.viewCartLabel);
            this.Controls.Add(this.LogOutLabel);
            this.Controls.Add(this.menuStrip1);
            this.MaximizeBox = false;
            this.Name = "UsersRegistryForm";
            this.Load += new System.EventHandler(this.UsersRegistryForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.activityList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label viewCartLabel;
        private System.Windows.Forms.Label LogOutLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem salesMenuOption;
        private System.Windows.Forms.ToolStripMenuItem viewSalesMenuSubOption;
        private System.Windows.Forms.ToolStripMenuItem makeSaleMenuSubOption;
        private System.Windows.Forms.ToolStripMenuItem adminMenuOption;
        private System.Windows.Forms.ToolStripMenuItem registerNewUserMenuSubOption;
        private System.Windows.Forms.ToolStripMenuItem statisticsMenuSubOption;
        private System.Windows.Forms.ToolStripMenuItem viewGraphsOption;
        private System.Windows.Forms.ToolStripMenuItem viewReportsOption;
        private System.Windows.Forms.ToolStripMenuItem logsMenuSubOption;
        private System.Windows.Forms.ToolStripMenuItem viewActivityLogsOption;
        private System.Windows.Forms.ToolStripMenuItem viewErrorLogsOption;
        private System.Windows.Forms.ToolStripMenuItem productsMenuOption;
        private System.Windows.Forms.ToolStripMenuItem browseProductsMenuSubOption;
        private System.Windows.Forms.ToolStripMenuItem registerNewProductMenuSubOption;
        private System.Windows.Forms.ToolStripMenuItem restockProductsMenuSubOption;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.DataGridView userList;
        private System.Windows.Forms.Label browserFormTitle;
        private System.Windows.Forms.TextBox userSearchBox;
        private System.Windows.Forms.Button profileButton;
        private System.Windows.Forms.DataGridView activityList;
        private System.Windows.Forms.Label activityTitleLabel;
        private System.Windows.Forms.Label searchActivityLabel;
        private System.Windows.Forms.TextBox activitySearchBox;
    }
}