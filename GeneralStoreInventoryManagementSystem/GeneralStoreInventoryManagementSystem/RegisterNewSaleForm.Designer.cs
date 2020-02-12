namespace GeneralStoreInventoryManagementSystem
{
    partial class RegisterNewSaleFrom
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
            this.viewSalesMenuOption = new System.Windows.Forms.ToolStripMenuItem();
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
            this.productDataGridView = new System.Windows.Forms.DataGridView();
            this.browserLabel = new System.Windows.Forms.Label();
            this.cartSummaryLabel = new System.Windows.Forms.Label();
            this.addItemButton = new System.Windows.Forms.Button();
            this.removeItemButton = new System.Windows.Forms.Button();
            this.removeOneButton = new System.Windows.Forms.Button();
            this.clearCartButton = new System.Windows.Forms.Button();
            this.numberLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.deliveryCheckBox = new System.Windows.Forms.CheckBox();
            this.completeSaleButton = new System.Windows.Forms.Button();
            this.productSearchTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cartSummaryDataGridView = new System.Windows.Forms.DataGridView();
            this.quantityNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartSummaryDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantityNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // viewCartLabel
            // 
            this.viewCartLabel.AutoSize = true;
            this.viewCartLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.viewCartLabel.Location = new System.Drawing.Point(765, 9);
            this.viewCartLabel.Name = "viewCartLabel";
            this.viewCartLabel.Size = new System.Drawing.Size(52, 13);
            this.viewCartLabel.TabIndex = 11;
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
            this.logOutLabel.TabIndex = 10;
            this.logOutLabel.Text = "Log Out";
            this.logOutLabel.Click += new System.EventHandler(this.LogOutLabel_Click);
            this.logOutLabel.MouseLeave += new System.EventHandler(this.LogOutLabel_MouseLeave);
            this.logOutLabel.MouseHover += new System.EventHandler(this.LogOutLabel_MouseHover);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewSalesMenuOption,
            this.productsMenuOption,
            this.adminMenuOption});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(927, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // viewSalesMenuOption
            // 
            this.viewSalesMenuOption.Name = "viewSalesMenuOption";
            this.viewSalesMenuOption.Size = new System.Drawing.Size(73, 20);
            this.viewSalesMenuOption.Text = "View Sales";
            this.viewSalesMenuOption.Click += new System.EventHandler(this.ViewSalesMenuOption_Click);
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
            // productDataGridView
            // 
            this.productDataGridView.AllowUserToAddRows = false;
            this.productDataGridView.AllowUserToDeleteRows = false;
            this.productDataGridView.AllowUserToResizeColumns = false;
            this.productDataGridView.AllowUserToResizeRows = false;
            this.productDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.productDataGridView.Location = new System.Drawing.Point(12, 66);
            this.productDataGridView.Name = "productDataGridView";
            this.productDataGridView.ReadOnly = true;
            this.productDataGridView.RowHeadersVisible = false;
            this.productDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.productDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productDataGridView.Size = new System.Drawing.Size(507, 455);
            this.productDataGridView.TabIndex = 12;
            this.productDataGridView.Click += new System.EventHandler(this.ProductDataGridView_Click);
            // 
            // browserLabel
            // 
            this.browserLabel.AutoSize = true;
            this.browserLabel.Location = new System.Drawing.Point(12, 47);
            this.browserLabel.Name = "browserLabel";
            this.browserLabel.Size = new System.Drawing.Size(85, 13);
            this.browserLabel.TabIndex = 13;
            this.browserLabel.Text = "Product Browser";
            // 
            // cartSummaryLabel
            // 
            this.cartSummaryLabel.AutoSize = true;
            this.cartSummaryLabel.Location = new System.Drawing.Point(533, 47);
            this.cartSummaryLabel.Name = "cartSummaryLabel";
            this.cartSummaryLabel.Size = new System.Drawing.Size(72, 13);
            this.cartSummaryLabel.TabIndex = 15;
            this.cartSummaryLabel.Text = "Cart Summary";
            // 
            // addItemButton
            // 
            this.addItemButton.Location = new System.Drawing.Point(444, 527);
            this.addItemButton.Name = "addItemButton";
            this.addItemButton.Size = new System.Drawing.Size(75, 23);
            this.addItemButton.TabIndex = 16;
            this.addItemButton.Text = "Add Item";
            this.addItemButton.UseVisualStyleBackColor = true;
            this.addItemButton.Click += new System.EventHandler(this.AddItemButton_Click);
            // 
            // removeItemButton
            // 
            this.removeItemButton.Location = new System.Drawing.Point(815, 286);
            this.removeItemButton.Name = "removeItemButton";
            this.removeItemButton.Size = new System.Drawing.Size(100, 23);
            this.removeItemButton.TabIndex = 18;
            this.removeItemButton.Text = "Remove Item";
            this.removeItemButton.UseVisualStyleBackColor = true;
            this.removeItemButton.Click += new System.EventHandler(this.RemoveItemButton_Click);
            // 
            // removeOneButton
            // 
            this.removeOneButton.Location = new System.Drawing.Point(709, 286);
            this.removeOneButton.Name = "removeOneButton";
            this.removeOneButton.Size = new System.Drawing.Size(100, 23);
            this.removeOneButton.TabIndex = 19;
            this.removeOneButton.Text = "Remove One";
            this.removeOneButton.UseVisualStyleBackColor = true;
            this.removeOneButton.Click += new System.EventHandler(this.RemoveOneButton_Click);
            // 
            // clearCartButton
            // 
            this.clearCartButton.Location = new System.Drawing.Point(603, 286);
            this.clearCartButton.Name = "clearCartButton";
            this.clearCartButton.Size = new System.Drawing.Size(100, 23);
            this.clearCartButton.TabIndex = 20;
            this.clearCartButton.Text = "Clear Cart";
            this.clearCartButton.UseVisualStyleBackColor = true;
            this.clearCartButton.Click += new System.EventHandler(this.ClearCartButton_Click);
            // 
            // numberLabel
            // 
            this.numberLabel.AutoSize = true;
            this.numberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberLabel.Location = new System.Drawing.Point(600, 331);
            this.numberLabel.Name = "numberLabel";
            this.numberLabel.Size = new System.Drawing.Size(136, 17);
            this.numberLabel.TabIndex = 21;
            this.numberLabel.Text = "Number of Items: ";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.Location = new System.Drawing.Point(682, 379);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(96, 17);
            this.totalLabel.TabIndex = 22;
            this.totalLabel.Text = "Total: $0.00";
            // 
            // deliveryCheckBox
            // 
            this.deliveryCheckBox.AutoSize = true;
            this.deliveryCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deliveryCheckBox.Location = new System.Drawing.Point(603, 434);
            this.deliveryCheckBox.Name = "deliveryCheckBox";
            this.deliveryCheckBox.Size = new System.Drawing.Size(157, 21);
            this.deliveryCheckBox.TabIndex = 23;
            this.deliveryCheckBox.Text = "Mark as Delivery?";
            this.deliveryCheckBox.UseVisualStyleBackColor = true;
            // 
            // completeSaleButton
            // 
            this.completeSaleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.completeSaleButton.Location = new System.Drawing.Point(652, 481);
            this.completeSaleButton.Name = "completeSaleButton";
            this.completeSaleButton.Size = new System.Drawing.Size(165, 40);
            this.completeSaleButton.TabIndex = 24;
            this.completeSaleButton.Text = "Complete Sale";
            this.completeSaleButton.UseVisualStyleBackColor = true;
            // 
            // productSearchTextBox
            // 
            this.productSearchTextBox.Location = new System.Drawing.Point(363, 40);
            this.productSearchTextBox.Name = "productSearchTextBox";
            this.productSearchTextBox.Size = new System.Drawing.Size(156, 20);
            this.productSearchTextBox.TabIndex = 25;
            this.productSearchTextBox.TextChanged += new System.EventHandler(this.ProductSearchTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(316, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Search";
            // 
            // cartSummaryDataGridView
            // 
            this.cartSummaryDataGridView.AllowUserToAddRows = false;
            this.cartSummaryDataGridView.AllowUserToDeleteRows = false;
            this.cartSummaryDataGridView.AllowUserToResizeColumns = false;
            this.cartSummaryDataGridView.AllowUserToResizeRows = false;
            this.cartSummaryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cartSummaryDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.cartSummaryDataGridView.Location = new System.Drawing.Point(536, 66);
            this.cartSummaryDataGridView.Name = "cartSummaryDataGridView";
            this.cartSummaryDataGridView.ReadOnly = true;
            this.cartSummaryDataGridView.RowHeadersVisible = false;
            this.cartSummaryDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.cartSummaryDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.cartSummaryDataGridView.Size = new System.Drawing.Size(379, 214);
            this.cartSummaryDataGridView.TabIndex = 27;
            // 
            // quantityNumericUpDown
            // 
            this.quantityNumericUpDown.Location = new System.Drawing.Point(363, 528);
            this.quantityNumericUpDown.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.quantityNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.quantityNumericUpDown.Name = "quantityNumericUpDown";
            this.quantityNumericUpDown.Size = new System.Drawing.Size(75, 20);
            this.quantityNumericUpDown.TabIndex = 28;
            this.quantityNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.quantityNumericUpDown.ThousandsSeparator = true;
            this.quantityNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.quantityNumericUpDown.ValueChanged += new System.EventHandler(this.QuantityNumericUpDown_ValueChanged);
            // 
            // RegisterNewSaleFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 562);
            this.Controls.Add(this.quantityNumericUpDown);
            this.Controls.Add(this.cartSummaryDataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.productSearchTextBox);
            this.Controls.Add(this.completeSaleButton);
            this.Controls.Add(this.deliveryCheckBox);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.numberLabel);
            this.Controls.Add(this.clearCartButton);
            this.Controls.Add(this.removeOneButton);
            this.Controls.Add(this.removeItemButton);
            this.Controls.Add(this.addItemButton);
            this.Controls.Add(this.cartSummaryLabel);
            this.Controls.Add(this.browserLabel);
            this.Controls.Add(this.productDataGridView);
            this.Controls.Add(this.viewCartLabel);
            this.Controls.Add(this.logOutLabel);
            this.Controls.Add(this.menuStrip1);
            this.MinimumSize = new System.Drawing.Size(943, 600);
            this.Name = "RegisterNewSaleFrom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register New Sale";
            this.Load += new System.EventHandler(this.RegisterNewSaleFrom_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartSummaryDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantityNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label viewCartLabel;
        private System.Windows.Forms.Label logOutLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem viewSalesMenuOption;
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
        private System.Windows.Forms.DataGridView productDataGridView;
        private System.Windows.Forms.Label browserLabel;
        private System.Windows.Forms.Label cartSummaryLabel;
        private System.Windows.Forms.Button addItemButton;
        private System.Windows.Forms.Button removeItemButton;
        private System.Windows.Forms.Button removeOneButton;
        private System.Windows.Forms.Button clearCartButton;
        private System.Windows.Forms.Label numberLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.CheckBox deliveryCheckBox;
        private System.Windows.Forms.Button completeSaleButton;
        private System.Windows.Forms.TextBox productSearchTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView cartSummaryDataGridView;
        private System.Windows.Forms.NumericUpDown quantityNumericUpDown;
    }
}