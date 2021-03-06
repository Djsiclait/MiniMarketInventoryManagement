﻿namespace GeneralStoreInventoryManagementSystem
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
            // LogOutLabel
            // 
            this.LogOutLabel.AutoSize = true;
            this.LogOutLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LogOutLabel.Location = new System.Drawing.Point(870, 9);
            this.LogOutLabel.Name = "LogOutLabel";
            this.LogOutLabel.Size = new System.Drawing.Size(45, 13);
            this.LogOutLabel.TabIndex = 8;
            this.LogOutLabel.Text = "Log Out";
            this.LogOutLabel.Click += new System.EventHandler(this.LogOutLabel_Click);
            this.LogOutLabel.MouseLeave += new System.EventHandler(this.LogOutLabel_MouseLeave);
            this.LogOutLabel.MouseHover += new System.EventHandler(this.LogOutLabel_MouseHover);
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
            this.menuStrip1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UsersRegistryForm_KeyDown);
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
            this.viewSalesMenuSubOption.Size = new System.Drawing.Size(180, 22);
            this.viewSalesMenuSubOption.Text = "View Sales";
            this.viewSalesMenuSubOption.Click += new System.EventHandler(this.ViewSalesMenuSubOption_Click);
            // 
            // makeSaleMenuSubOption
            // 
            this.makeSaleMenuSubOption.Name = "makeSaleMenuSubOption";
            this.makeSaleMenuSubOption.ShortcutKeyDisplayString = "F2";
            this.makeSaleMenuSubOption.Size = new System.Drawing.Size(180, 22);
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
            this.registerNewUserMenuSubOption,
            this.statisticsMenuSubOption,
            this.logsMenuSubOption});
            this.adminMenuOption.Name = "adminMenuOption";
            this.adminMenuOption.Size = new System.Drawing.Size(55, 20);
            this.adminMenuOption.Text = "Admin";
            // 
            // registerNewUserMenuSubOption
            // 
            this.registerNewUserMenuSubOption.Name = "registerNewUserMenuSubOption";
            this.registerNewUserMenuSubOption.ShortcutKeyDisplayString = "F7";
            this.registerNewUserMenuSubOption.Size = new System.Drawing.Size(188, 22);
            this.registerNewUserMenuSubOption.Text = "Register New User";
            this.registerNewUserMenuSubOption.Click += new System.EventHandler(this.RegisterNewUserMenuSubOption_Click);
            // 
            // statisticsMenuSubOption
            // 
            this.statisticsMenuSubOption.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewGraphsOption,
            this.viewReportsOption});
            this.statisticsMenuSubOption.Name = "statisticsMenuSubOption";
            this.statisticsMenuSubOption.Size = new System.Drawing.Size(188, 22);
            this.statisticsMenuSubOption.Text = "Statistics";
            // 
            // viewGraphsOption
            // 
            this.viewGraphsOption.Name = "viewGraphsOption";
            this.viewGraphsOption.ShortcutKeyDisplayString = "F8";
            this.viewGraphsOption.Size = new System.Drawing.Size(180, 22);
            this.viewGraphsOption.Text = "View Graphs";
            this.viewGraphsOption.Click += new System.EventHandler(this.ViewGraphsOption_Click);
            // 
            // viewReportsOption
            // 
            this.viewReportsOption.Name = "viewReportsOption";
            this.viewReportsOption.ShortcutKeyDisplayString = "F9";
            this.viewReportsOption.Size = new System.Drawing.Size(180, 22);
            this.viewReportsOption.Text = "View Reports";
            this.viewReportsOption.Click += new System.EventHandler(this.ViewReportsOption_Click);
            // 
            // logsMenuSubOption
            // 
            this.logsMenuSubOption.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewActivityLogsOption,
            this.viewErrorLogsOption});
            this.logsMenuSubOption.Name = "logsMenuSubOption";
            this.logsMenuSubOption.Size = new System.Drawing.Size(188, 22);
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
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Location = new System.Drawing.Point(570, 49);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(66, 13);
            this.searchLabel.TabIndex = 13;
            this.searchLabel.Text = "Search User";
            // 
            // userList
            // 
            this.userList.AllowUserToAddRows = false;
            this.userList.AllowUserToDeleteRows = false;
            this.userList.AllowUserToResizeColumns = false;
            this.userList.AllowUserToResizeRows = false;
            this.userList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.userList.Location = new System.Drawing.Point(167, 72);
            this.userList.MultiSelect = false;
            this.userList.Name = "userList";
            this.userList.RowHeadersVisible = false;
            this.userList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.userList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.userList.Size = new System.Drawing.Size(603, 209);
            this.userList.TabIndex = 12;
            this.userList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UserList_CellDoubleClick);
            this.userList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UsersRegistryForm_KeyDown);
            // 
            // browserFormTitle
            // 
            this.browserFormTitle.AutoSize = true;
            this.browserFormTitle.Location = new System.Drawing.Point(164, 49);
            this.browserFormTitle.Name = "browserFormTitle";
            this.browserFormTitle.Size = new System.Drawing.Size(88, 13);
            this.browserFormTitle.TabIndex = 11;
            this.browserFormTitle.Text = "Registered Users";
            // 
            // userSearchBox
            // 
            this.userSearchBox.Location = new System.Drawing.Point(642, 46);
            this.userSearchBox.Name = "userSearchBox";
            this.userSearchBox.Size = new System.Drawing.Size(128, 20);
            this.userSearchBox.TabIndex = 10;
            this.userSearchBox.TextChanged += new System.EventHandler(this.UserSearchBox_TextChanged);
            this.userSearchBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UsersRegistryForm_KeyDown);
            // 
            // profileButton
            // 
            this.profileButton.Location = new System.Drawing.Point(30, 155);
            this.profileButton.Name = "profileButton";
            this.profileButton.Size = new System.Drawing.Size(117, 23);
            this.profileButton.TabIndex = 14;
            this.profileButton.Text = "View My Profile";
            this.profileButton.UseVisualStyleBackColor = true;
            this.profileButton.Click += new System.EventHandler(this.ProfileButton_Click);
            this.profileButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UsersRegistryForm_KeyDown);
            // 
            // activityList
            // 
            this.activityList.AllowUserToAddRows = false;
            this.activityList.AllowUserToDeleteRows = false;
            this.activityList.AllowUserToResizeColumns = false;
            this.activityList.AllowUserToResizeRows = false;
            this.activityList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.activityList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.activityList.Location = new System.Drawing.Point(12, 341);
            this.activityList.MultiSelect = false;
            this.activityList.Name = "activityList";
            this.activityList.RowHeadersVisible = false;
            this.activityList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.activityList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.activityList.Size = new System.Drawing.Size(903, 209);
            this.activityList.TabIndex = 15;
            this.activityList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UsersRegistryForm_KeyDown);
            // 
            // activityTitleLabel
            // 
            this.activityTitleLabel.AutoSize = true;
            this.activityTitleLabel.Location = new System.Drawing.Point(164, 318);
            this.activityTitleLabel.Name = "activityTitleLabel";
            this.activityTitleLabel.Size = new System.Drawing.Size(232, 13);
            this.activityTitleLabel.TabIndex = 16;
            this.activityTitleLabel.Text = "Recent User Activities Within the Last 24 Hours";
            // 
            // searchActivityLabel
            // 
            this.searchActivityLabel.AutoSize = true;
            this.searchActivityLabel.Location = new System.Drawing.Point(558, 318);
            this.searchActivityLabel.Name = "searchActivityLabel";
            this.searchActivityLabel.Size = new System.Drawing.Size(78, 13);
            this.searchActivityLabel.TabIndex = 18;
            this.searchActivityLabel.Text = "Search Activity";
            // 
            // activitySearchBox
            // 
            this.activitySearchBox.Location = new System.Drawing.Point(642, 315);
            this.activitySearchBox.Name = "activitySearchBox";
            this.activitySearchBox.Size = new System.Drawing.Size(273, 20);
            this.activitySearchBox.TabIndex = 17;
            this.activitySearchBox.TextChanged += new System.EventHandler(this.activitySearchBox_TextChanged);
            this.activitySearchBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UsersRegistryForm_KeyDown);
            // 
            // UsersRegistryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 562);
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
            this.MinimumSize = new System.Drawing.Size(943, 600);
            this.Name = "UsersRegistryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Registry";
            this.Load += new System.EventHandler(this.UsersRegistryForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UsersRegistryForm_KeyDown);
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