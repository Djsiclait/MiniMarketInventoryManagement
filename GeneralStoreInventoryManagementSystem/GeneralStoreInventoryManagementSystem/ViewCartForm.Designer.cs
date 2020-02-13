namespace GeneralStoreInventoryManagementSystem
{
    partial class ViewCartForm
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
            this.logsMenuSubOption = new System.Windows.Forms.ToolStripMenuItem();
            this.viewActivityLogsOption = new System.Windows.Forms.ToolStripMenuItem();
            this.viewErrorLogsOption = new System.Windows.Forms.ToolStripMenuItem();
            this.totalLabel = new System.Windows.Forms.Label();
            this.numberLabel = new System.Windows.Forms.Label();
            this.clearCartButton = new System.Windows.Forms.Button();
            this.removeOneButton = new System.Windows.Forms.Button();
            this.removeItemButton = new System.Windows.Forms.Button();
            this.cartSummaryLabel = new System.Windows.Forms.Label();
            this.cartSummaryDataGridView = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cartSummaryDataGridView)).BeginInit();
            this.SuspendLayout();
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
            this.viewSalesMenuSubOption.Size = new System.Drawing.Size(128, 22);
            this.viewSalesMenuSubOption.Text = "View Sales";
            this.viewSalesMenuSubOption.Click += new System.EventHandler(this.ViewSalesMenuSubOption_Click);
            // 
            // makeSaleMenuSubOption
            // 
            this.makeSaleMenuSubOption.Name = "makeSaleMenuSubOption";
            this.makeSaleMenuSubOption.Size = new System.Drawing.Size(128, 22);
            this.makeSaleMenuSubOption.Text = "Make Sale";
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
            this.browseProductsMenuSubOption.Size = new System.Drawing.Size(188, 22);
            this.browseProductsMenuSubOption.Text = "Browse Products";
            this.browseProductsMenuSubOption.Click += new System.EventHandler(this.BrowseProductsMenuSubOption_Click);
            // 
            // registerNewProductMenuSubOption
            // 
            this.registerNewProductMenuSubOption.Name = "registerNewProductMenuSubOption";
            this.registerNewProductMenuSubOption.Size = new System.Drawing.Size(188, 22);
            this.registerNewProductMenuSubOption.Text = "Register New Product";
            this.registerNewProductMenuSubOption.Click += new System.EventHandler(this.RegisterNewProductMenuSubOption_Click);
            // 
            // restockProductsMenuSubOption
            // 
            this.restockProductsMenuSubOption.Name = "restockProductsMenuSubOption";
            this.restockProductsMenuSubOption.Size = new System.Drawing.Size(188, 22);
            this.restockProductsMenuSubOption.Text = "Restock Products";
            this.restockProductsMenuSubOption.Click += new System.EventHandler(this.RestockProductsMenuSubOption_Click);
            // 
            // adminMenuOption
            // 
            this.adminMenuOption.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageUsersMenuSubOption,
            this.statisticsMenuSubOption,
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
            this.manageUsersMenuSubOption.Size = new System.Drawing.Size(148, 22);
            this.manageUsersMenuSubOption.Text = "Manage Users";
            // 
            // viewUsersOption
            // 
            this.viewUsersOption.Name = "viewUsersOption";
            this.viewUsersOption.Size = new System.Drawing.Size(169, 22);
            this.viewUsersOption.Text = "View Users";
            this.viewUsersOption.Click += new System.EventHandler(this.ViewUsersOption_Click);
            // 
            // registerNewUserOption
            // 
            this.registerNewUserOption.Name = "registerNewUserOption";
            this.registerNewUserOption.Size = new System.Drawing.Size(169, 22);
            this.registerNewUserOption.Text = "Register New User";
            this.registerNewUserOption.Click += new System.EventHandler(this.RegisterNewUserOption_Click);
            // 
            // statisticsMenuSubOption
            // 
            this.statisticsMenuSubOption.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewGraphsOption,
            this.viewReportsOption});
            this.statisticsMenuSubOption.Name = "statisticsMenuSubOption";
            this.statisticsMenuSubOption.Size = new System.Drawing.Size(148, 22);
            this.statisticsMenuSubOption.Text = "Statistics";
            // 
            // viewGraphsOption
            // 
            this.viewGraphsOption.Name = "viewGraphsOption";
            this.viewGraphsOption.Size = new System.Drawing.Size(142, 22);
            this.viewGraphsOption.Text = "View Graphs";
            this.viewGraphsOption.Click += new System.EventHandler(this.ViewGraphsOption_Click);
            // 
            // viewReportsOption
            // 
            this.viewReportsOption.Name = "viewReportsOption";
            this.viewReportsOption.Size = new System.Drawing.Size(142, 22);
            this.viewReportsOption.Text = "View Reports";
            this.viewReportsOption.Click += new System.EventHandler(this.ViewReportsOption_Click);
            // 
            // logsMenuSubOption
            // 
            this.logsMenuSubOption.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewActivityLogsOption,
            this.viewErrorLogsOption});
            this.logsMenuSubOption.Name = "logsMenuSubOption";
            this.logsMenuSubOption.Size = new System.Drawing.Size(148, 22);
            this.logsMenuSubOption.Text = "Logs";
            // 
            // viewActivityLogsOption
            // 
            this.viewActivityLogsOption.Name = "viewActivityLogsOption";
            this.viewActivityLogsOption.Size = new System.Drawing.Size(170, 22);
            this.viewActivityLogsOption.Text = "View Activity Logs";
            this.viewActivityLogsOption.Click += new System.EventHandler(this.ViewActivityLogsOption_Click);
            // 
            // viewErrorLogsOption
            // 
            this.viewErrorLogsOption.Name = "viewErrorLogsOption";
            this.viewErrorLogsOption.Size = new System.Drawing.Size(170, 22);
            this.viewErrorLogsOption.Text = "View Error Logs";
            this.viewErrorLogsOption.Click += new System.EventHandler(this.ViewErrorLogsOption_Click);
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.Location = new System.Drawing.Point(704, 334);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(96, 17);
            this.totalLabel.TabIndex = 29;
            this.totalLabel.Text = "Total: $0.00";
            // 
            // numberLabel
            // 
            this.numberLabel.AutoSize = true;
            this.numberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberLabel.Location = new System.Drawing.Point(704, 307);
            this.numberLabel.Name = "numberLabel";
            this.numberLabel.Size = new System.Drawing.Size(136, 17);
            this.numberLabel.TabIndex = 28;
            this.numberLabel.Text = "Number of Items: ";
            // 
            // clearCartButton
            // 
            this.clearCartButton.Location = new System.Drawing.Point(237, 524);
            this.clearCartButton.Name = "clearCartButton";
            this.clearCartButton.Size = new System.Drawing.Size(100, 23);
            this.clearCartButton.TabIndex = 27;
            this.clearCartButton.Text = "Clear Cart";
            this.clearCartButton.UseVisualStyleBackColor = true;
            // 
            // removeOneButton
            // 
            this.removeOneButton.Location = new System.Drawing.Point(399, 524);
            this.removeOneButton.Name = "removeOneButton";
            this.removeOneButton.Size = new System.Drawing.Size(100, 23);
            this.removeOneButton.TabIndex = 26;
            this.removeOneButton.Text = "Remove One";
            this.removeOneButton.UseVisualStyleBackColor = true;
            // 
            // removeItemButton
            // 
            this.removeItemButton.Location = new System.Drawing.Point(557, 524);
            this.removeItemButton.Name = "removeItemButton";
            this.removeItemButton.Size = new System.Drawing.Size(100, 23);
            this.removeItemButton.TabIndex = 25;
            this.removeItemButton.Text = "Remove Item";
            this.removeItemButton.UseVisualStyleBackColor = true;
            // 
            // cartSummaryLabel
            // 
            this.cartSummaryLabel.AutoSize = true;
            this.cartSummaryLabel.Location = new System.Drawing.Point(225, 47);
            this.cartSummaryLabel.Name = "cartSummaryLabel";
            this.cartSummaryLabel.Size = new System.Drawing.Size(72, 13);
            this.cartSummaryLabel.TabIndex = 24;
            this.cartSummaryLabel.Text = "Cart Summary";
            // 
            // cartSummaryDataGridView
            // 
            this.cartSummaryDataGridView.AllowUserToAddRows = false;
            this.cartSummaryDataGridView.AllowUserToDeleteRows = false;
            this.cartSummaryDataGridView.AllowUserToResizeColumns = false;
            this.cartSummaryDataGridView.AllowUserToResizeRows = false;
            this.cartSummaryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cartSummaryDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.cartSummaryDataGridView.Location = new System.Drawing.Point(191, 63);
            this.cartSummaryDataGridView.Name = "cartSummaryDataGridView";
            this.cartSummaryDataGridView.ReadOnly = true;
            this.cartSummaryDataGridView.RowHeadersVisible = false;
            this.cartSummaryDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.cartSummaryDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.cartSummaryDataGridView.Size = new System.Drawing.Size(507, 455);
            this.cartSummaryDataGridView.TabIndex = 23;
            // 
            // ViewCartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 562);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.numberLabel);
            this.Controls.Add(this.clearCartButton);
            this.Controls.Add(this.removeOneButton);
            this.Controls.Add(this.removeItemButton);
            this.Controls.Add(this.cartSummaryLabel);
            this.Controls.Add(this.cartSummaryDataGridView);
            this.Controls.Add(this.logOutLabel);
            this.Controls.Add(this.menuStrip1);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(943, 600);
            this.Name = "ViewCartForm";
            this.Text = "Cart Items";
            this.Load += new System.EventHandler(this.ViewCartForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cartSummaryDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.ToolStripMenuItem logsMenuSubOption;
        private System.Windows.Forms.ToolStripMenuItem viewActivityLogsOption;
        private System.Windows.Forms.ToolStripMenuItem viewErrorLogsOption;
        private System.Windows.Forms.ToolStripMenuItem productsMenuOption;
        private System.Windows.Forms.ToolStripMenuItem browseProductsMenuSubOption;
        private System.Windows.Forms.ToolStripMenuItem registerNewProductMenuSubOption;
        private System.Windows.Forms.ToolStripMenuItem restockProductsMenuSubOption;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label numberLabel;
        private System.Windows.Forms.Button clearCartButton;
        private System.Windows.Forms.Button removeOneButton;
        private System.Windows.Forms.Button removeItemButton;
        private System.Windows.Forms.Label cartSummaryLabel;
        private System.Windows.Forms.DataGridView cartSummaryDataGridView;
    }
}