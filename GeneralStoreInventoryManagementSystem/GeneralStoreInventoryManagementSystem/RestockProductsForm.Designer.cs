namespace GeneralStoreInventoryManagementSystem
{
    partial class RestockProductsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RestockProductsForm));
            this.viewCartLabel = new System.Windows.Forms.Label();
            this.logOutLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.salesMenuOption = new System.Windows.Forms.ToolStripMenuItem();
            this.viewSalesMenuSubOption = new System.Windows.Forms.ToolStripMenuItem();
            this.makeSaleMenuSubOption = new System.Windows.Forms.ToolStripMenuItem();
            this.productsMenuOption = new System.Windows.Forms.ToolStripMenuItem();
            this.browseProductsMenuSubOption = new System.Windows.Forms.ToolStripMenuItem();
            this.registerNewProductMenuSubOption = new System.Windows.Forms.ToolStripMenuItem();
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
            this.searchLabel = new System.Windows.Forms.Label();
            this.productList = new System.Windows.Forms.DataGridView();
            this.browserFormTitle = new System.Windows.Forms.Label();
            this.inventorySearchBox = new System.Windows.Forms.TextBox();
            this.unitContributionMarginLabel = new System.Windows.Forms.Label();
            this.nameDisplayLabel = new System.Windows.Forms.Label();
            this.maximumQuantityLabel = new System.Windows.Forms.Label();
            this.minimumQuantityLabel = new System.Windows.Forms.Label();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.unitPriceLabel = new System.Windows.Forms.Label();
            this.unitCostLabel = new System.Windows.Forms.Label();
            this.unitLabel = new System.Windows.Forms.Label();
            this.typeLabel = new System.Windows.Forms.Label();
            this.categoryLable = new System.Windows.Forms.Label();
            this.supplierLabel = new System.Windows.Forms.Label();
            this.brandLabel = new System.Windows.Forms.Label();
            this.keyLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.keyDisplayLabel = new System.Windows.Forms.Label();
            this.brandDisplayLabel = new System.Windows.Forms.Label();
            this.supplierDisplayLabel = new System.Windows.Forms.Label();
            this.categoryDisplayLabel = new System.Windows.Forms.Label();
            this.typeDisplayLabel = new System.Windows.Forms.Label();
            this.unitCostDisplayLabel = new System.Windows.Forms.Label();
            this.unitPriceDisplayLabel = new System.Windows.Forms.Label();
            this.unitDisplayLabel = new System.Windows.Forms.Label();
            this.quantityDisplayLabel = new System.Windows.Forms.Label();
            this.minimumDisplayLabel = new System.Windows.Forms.Label();
            this.maximumDisplayLabel = new System.Windows.Forms.Label();
            this.addedAmmountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.restockButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addedAmmountNumericUpDown)).BeginInit();
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
            this.menuStrip1.Size = new System.Drawing.Size(927, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RestockProductsForm_KeyDown);
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
            this.viewSalesMenuSubOption.ShortcutKeyDisplayString = "F1";
            this.viewSalesMenuSubOption.Size = new System.Drawing.Size(180, 22);
            this.viewSalesMenuSubOption.Text = "View Sales";
            this.viewSalesMenuSubOption.Click += new System.EventHandler(this.ViewSalesMenuSubOption_Click);
            // 
            // makeSaleMenuSubOption
            // 
            resources.ApplyResources(this.makeSaleMenuSubOption, "makeSaleMenuSubOption");
            this.makeSaleMenuSubOption.Name = "makeSaleMenuSubOption";
            this.makeSaleMenuSubOption.ShortcutKeyDisplayString = "F2";
            this.makeSaleMenuSubOption.Size = new System.Drawing.Size(180, 22);
            this.makeSaleMenuSubOption.Text = "Make Sales";
            this.makeSaleMenuSubOption.Click += new System.EventHandler(this.MakeSaleMenuSubOption_Click);
            // 
            // productsMenuOption
            // 
            resources.ApplyResources(this.productsMenuOption, "productsMenuOption");
            this.productsMenuOption.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.browseProductsMenuSubOption,
            this.registerNewProductMenuSubOption});
            this.productsMenuOption.Name = "productsMenuOption";
            // 
            // browseProductsMenuSubOption
            // 
            resources.ApplyResources(this.browseProductsMenuSubOption, "browseProductsMenuSubOption");
            this.browseProductsMenuSubOption.Name = "browseProductsMenuSubOption";
            this.browseProductsMenuSubOption.ShortcutKeyDisplayString = "F3";
            this.browseProductsMenuSubOption.Size = new System.Drawing.Size(207, 22);
            this.browseProductsMenuSubOption.Text = "Product Browser";
            this.browseProductsMenuSubOption.Click += new System.EventHandler(this.BrowseProductsMenuSubOption_Click);
            // 
            // registerNewProductMenuSubOption
            // 
            resources.ApplyResources(this.registerNewProductMenuSubOption, "registerNewProductMenuSubOption");
            this.registerNewProductMenuSubOption.Name = "registerNewProductMenuSubOption";
            this.registerNewProductMenuSubOption.ShortcutKeyDisplayString = "F4";
            this.registerNewProductMenuSubOption.Size = new System.Drawing.Size(207, 22);
            this.registerNewProductMenuSubOption.Text = "Register New Product";
            this.registerNewProductMenuSubOption.Click += new System.EventHandler(this.RegisterNewProductMenuSubOption_Click);
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
            this.manageUsersMenuSubOption.Size = new System.Drawing.Size(180, 22);
            this.manageUsersMenuSubOption.Text = "Manage Users";
            // 
            // viewUsersOption
            // 
            resources.ApplyResources(this.viewUsersOption, "viewUsersOption");
            this.viewUsersOption.Name = "viewUsersOption";
            this.viewUsersOption.ShortcutKeyDisplayString = "F6";
            this.viewUsersOption.Size = new System.Drawing.Size(188, 22);
            this.viewUsersOption.Text = "View Users";
            this.viewUsersOption.Click += new System.EventHandler(this.ViewUsersOption_Click);
            // 
            // registerNewUserOption
            // 
            resources.ApplyResources(this.registerNewUserOption, "registerNewUserOption");
            this.registerNewUserOption.Name = "registerNewUserOption";
            this.registerNewUserOption.ShortcutKeyDisplayString = "F7";
            this.registerNewUserOption.Size = new System.Drawing.Size(188, 22);
            this.registerNewUserOption.Text = "Register New User";
            this.registerNewUserOption.Click += new System.EventHandler(this.RegisterNewUserOption_Click);
            // 
            // statisticsMenuSubOption
            // 
            resources.ApplyResources(this.statisticsMenuSubOption, "statisticsMenuSubOption");
            this.statisticsMenuSubOption.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewGraphsOption,
            this.viewReportsOption});
            this.statisticsMenuSubOption.Name = "statisticsMenuSubOption";
            this.statisticsMenuSubOption.Size = new System.Drawing.Size(180, 22);
            this.statisticsMenuSubOption.Text = "Statistics";
            // 
            // viewGraphsOption
            // 
            resources.ApplyResources(this.viewGraphsOption, "viewGraphsOption");
            this.viewGraphsOption.Name = "viewGraphsOption";
            this.viewGraphsOption.ShortcutKeyDisplayString = "F8";
            this.viewGraphsOption.Size = new System.Drawing.Size(180, 22);
            this.viewGraphsOption.Text = "View Graphs";
            this.viewGraphsOption.Click += new System.EventHandler(this.ViewGraphsOption_Click);
            // 
            // viewReportsOption
            // 
            resources.ApplyResources(this.viewReportsOption, "viewReportsOption");
            this.viewReportsOption.Name = "viewReportsOption";
            this.viewReportsOption.ShortcutKeyDisplayString = "F9";
            this.viewReportsOption.Size = new System.Drawing.Size(180, 22);
            this.viewReportsOption.Text = "View Reports";
            this.viewReportsOption.Click += new System.EventHandler(this.ViewReportsOption_Click);
            // 
            // logsMenuSubOption
            // 
            resources.ApplyResources(this.logsMenuSubOption, "logsMenuSubOption");
            this.logsMenuSubOption.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewActivityLogsOption,
            this.viewErrorLogsOption});
            this.logsMenuSubOption.Name = "logsMenuSubOption";
            this.logsMenuSubOption.Size = new System.Drawing.Size(180, 22);
            this.logsMenuSubOption.Text = "Logs";
            // 
            // viewActivityLogsOption
            // 
            resources.ApplyResources(this.viewActivityLogsOption, "viewActivityLogsOption");
            this.viewActivityLogsOption.Name = "viewActivityLogsOption";
            this.viewActivityLogsOption.ShortcutKeyDisplayString = "F10";
            this.viewActivityLogsOption.Size = new System.Drawing.Size(198, 22);
            this.viewActivityLogsOption.Text = "View Activities Log";
            this.viewActivityLogsOption.Click += new System.EventHandler(this.ViewActivityLogsOption_Click);
            // 
            // viewErrorLogsOption
            // 
            resources.ApplyResources(this.viewErrorLogsOption, "viewErrorLogsOption");
            this.viewErrorLogsOption.Name = "viewErrorLogsOption";
            this.viewErrorLogsOption.ShortcutKeyDisplayString = "F11";
            this.viewErrorLogsOption.Size = new System.Drawing.Size(198, 22);
            this.viewErrorLogsOption.Text = "View Errors Log";
            this.viewErrorLogsOption.Click += new System.EventHandler(this.ViewErrorLogsOption_Click);
            // 
            // searchLabel
            // 
            resources.ApplyResources(this.searchLabel, "searchLabel");
            this.searchLabel.Name = "searchLabel";
            // 
            // productList
            // 
            resources.ApplyResources(this.productList, "productList");
            this.productList.AllowUserToAddRows = false;
            this.productList.AllowUserToDeleteRows = false;
            this.productList.AllowUserToResizeColumns = false;
            this.productList.AllowUserToResizeRows = false;
            this.productList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.productList.MultiSelect = false;
            this.productList.Name = "productList";
            this.productList.ReadOnly = true;
            this.productList.RowHeadersVisible = false;
            this.productList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductList_CellDoubleClick);
            // 
            // browserFormTitle
            // 
            resources.ApplyResources(this.browserFormTitle, "browserFormTitle");
            this.browserFormTitle.Name = "browserFormTitle";
            // 
            // inventorySearchBox
            // 
            resources.ApplyResources(this.inventorySearchBox, "inventorySearchBox");
            this.inventorySearchBox.Name = "inventorySearchBox";
            this.inventorySearchBox.TextChanged += new System.EventHandler(this.InventorySearchBox_TextChanged);
            this.inventorySearchBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RestockProductsForm_KeyDown);
            // 
            // unitContributionMarginLabel
            // 
            resources.ApplyResources(this.unitContributionMarginLabel, "unitContributionMarginLabel");
            this.unitContributionMarginLabel.Name = "unitContributionMarginLabel";
            // 
            // nameDisplayLabel
            // 
            resources.ApplyResources(this.nameDisplayLabel, "nameDisplayLabel");
            this.nameDisplayLabel.Name = "nameDisplayLabel";
            // 
            // maximumQuantityLabel
            // 
            resources.ApplyResources(this.maximumQuantityLabel, "maximumQuantityLabel");
            this.maximumQuantityLabel.Name = "maximumQuantityLabel";
            // 
            // minimumQuantityLabel
            // 
            resources.ApplyResources(this.minimumQuantityLabel, "minimumQuantityLabel");
            this.minimumQuantityLabel.Name = "minimumQuantityLabel";
            // 
            // quantityLabel
            // 
            resources.ApplyResources(this.quantityLabel, "quantityLabel");
            this.quantityLabel.Name = "quantityLabel";
            // 
            // unitPriceLabel
            // 
            resources.ApplyResources(this.unitPriceLabel, "unitPriceLabel");
            this.unitPriceLabel.Name = "unitPriceLabel";
            // 
            // unitCostLabel
            // 
            resources.ApplyResources(this.unitCostLabel, "unitCostLabel");
            this.unitCostLabel.Name = "unitCostLabel";
            // 
            // unitLabel
            // 
            resources.ApplyResources(this.unitLabel, "unitLabel");
            this.unitLabel.Name = "unitLabel";
            // 
            // typeLabel
            // 
            resources.ApplyResources(this.typeLabel, "typeLabel");
            this.typeLabel.Name = "typeLabel";
            // 
            // categoryLable
            // 
            resources.ApplyResources(this.categoryLable, "categoryLable");
            this.categoryLable.Name = "categoryLable";
            // 
            // supplierLabel
            // 
            resources.ApplyResources(this.supplierLabel, "supplierLabel");
            this.supplierLabel.Name = "supplierLabel";
            // 
            // brandLabel
            // 
            resources.ApplyResources(this.brandLabel, "brandLabel");
            this.brandLabel.Name = "brandLabel";
            // 
            // keyLabel
            // 
            resources.ApplyResources(this.keyLabel, "keyLabel");
            this.keyLabel.Name = "keyLabel";
            // 
            // nameLabel
            // 
            resources.ApplyResources(this.nameLabel, "nameLabel");
            this.nameLabel.Name = "nameLabel";
            // 
            // keyDisplayLabel
            // 
            resources.ApplyResources(this.keyDisplayLabel, "keyDisplayLabel");
            this.keyDisplayLabel.Name = "keyDisplayLabel";
            // 
            // brandDisplayLabel
            // 
            resources.ApplyResources(this.brandDisplayLabel, "brandDisplayLabel");
            this.brandDisplayLabel.Name = "brandDisplayLabel";
            // 
            // supplierDisplayLabel
            // 
            resources.ApplyResources(this.supplierDisplayLabel, "supplierDisplayLabel");
            this.supplierDisplayLabel.Name = "supplierDisplayLabel";
            // 
            // categoryDisplayLabel
            // 
            resources.ApplyResources(this.categoryDisplayLabel, "categoryDisplayLabel");
            this.categoryDisplayLabel.Name = "categoryDisplayLabel";
            // 
            // typeDisplayLabel
            // 
            resources.ApplyResources(this.typeDisplayLabel, "typeDisplayLabel");
            this.typeDisplayLabel.Name = "typeDisplayLabel";
            // 
            // unitCostDisplayLabel
            // 
            resources.ApplyResources(this.unitCostDisplayLabel, "unitCostDisplayLabel");
            this.unitCostDisplayLabel.Name = "unitCostDisplayLabel";
            // 
            // unitPriceDisplayLabel
            // 
            resources.ApplyResources(this.unitPriceDisplayLabel, "unitPriceDisplayLabel");
            this.unitPriceDisplayLabel.Name = "unitPriceDisplayLabel";
            // 
            // unitDisplayLabel
            // 
            resources.ApplyResources(this.unitDisplayLabel, "unitDisplayLabel");
            this.unitDisplayLabel.Name = "unitDisplayLabel";
            // 
            // quantityDisplayLabel
            // 
            resources.ApplyResources(this.quantityDisplayLabel, "quantityDisplayLabel");
            this.quantityDisplayLabel.Name = "quantityDisplayLabel";
            // 
            // minimumDisplayLabel
            // 
            resources.ApplyResources(this.minimumDisplayLabel, "minimumDisplayLabel");
            this.minimumDisplayLabel.Name = "minimumDisplayLabel";
            // 
            // maximumDisplayLabel
            // 
            resources.ApplyResources(this.maximumDisplayLabel, "maximumDisplayLabel");
            this.maximumDisplayLabel.Name = "maximumDisplayLabel";
            // 
            // addedAmmountNumericUpDown
            // 
            resources.ApplyResources(this.addedAmmountNumericUpDown, "addedAmmountNumericUpDown");
            this.addedAmmountNumericUpDown.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.addedAmmountNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.addedAmmountNumericUpDown.Name = "addedAmmountNumericUpDown";
            this.addedAmmountNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.addedAmmountNumericUpDown.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AddedAmmountNumericUpDown_KeyDown);
            // 
            // restockButton
            // 
            resources.ApplyResources(this.restockButton, "restockButton");
            this.restockButton.Name = "restockButton";
            this.restockButton.UseVisualStyleBackColor = true;
            this.restockButton.Click += new System.EventHandler(this.RestockButton_Click);
            this.restockButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RestockProductsForm_KeyDown);
            // 
            // RestockProductsForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.restockButton);
            this.Controls.Add(this.addedAmmountNumericUpDown);
            this.Controls.Add(this.minimumDisplayLabel);
            this.Controls.Add(this.maximumDisplayLabel);
            this.Controls.Add(this.unitDisplayLabel);
            this.Controls.Add(this.quantityDisplayLabel);
            this.Controls.Add(this.unitCostDisplayLabel);
            this.Controls.Add(this.unitPriceDisplayLabel);
            this.Controls.Add(this.categoryDisplayLabel);
            this.Controls.Add(this.typeDisplayLabel);
            this.Controls.Add(this.brandDisplayLabel);
            this.Controls.Add(this.supplierDisplayLabel);
            this.Controls.Add(this.keyDisplayLabel);
            this.Controls.Add(this.unitContributionMarginLabel);
            this.Controls.Add(this.nameDisplayLabel);
            this.Controls.Add(this.maximumQuantityLabel);
            this.Controls.Add(this.minimumQuantityLabel);
            this.Controls.Add(this.quantityLabel);
            this.Controls.Add(this.unitPriceLabel);
            this.Controls.Add(this.unitCostLabel);
            this.Controls.Add(this.unitLabel);
            this.Controls.Add(this.typeLabel);
            this.Controls.Add(this.categoryLable);
            this.Controls.Add(this.supplierLabel);
            this.Controls.Add(this.brandLabel);
            this.Controls.Add(this.keyLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.productList);
            this.Controls.Add(this.browserFormTitle);
            this.Controls.Add(this.inventorySearchBox);
            this.Controls.Add(this.viewCartLabel);
            this.Controls.Add(this.logOutLabel);
            this.Controls.Add(this.menuStrip1);
            this.MaximizeBox = false;
            this.Name = "RestockProductsForm";
            this.Load += new System.EventHandler(this.RestockProductsForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RestockProductsForm_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addedAmmountNumericUpDown)).EndInit();
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
        private System.Windows.Forms.ToolStripMenuItem logsMenuSubOption;
        private System.Windows.Forms.ToolStripMenuItem viewActivityLogsOption;
        private System.Windows.Forms.ToolStripMenuItem viewErrorLogsOption;
        private System.Windows.Forms.ToolStripMenuItem productsMenuOption;
        private System.Windows.Forms.ToolStripMenuItem browseProductsMenuSubOption;
        private System.Windows.Forms.ToolStripMenuItem registerNewProductMenuSubOption;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.DataGridView productList;
        private System.Windows.Forms.Label browserFormTitle;
        private System.Windows.Forms.TextBox inventorySearchBox;
        private System.Windows.Forms.Label unitContributionMarginLabel;
        private System.Windows.Forms.Label nameDisplayLabel;
        private System.Windows.Forms.Label maximumQuantityLabel;
        private System.Windows.Forms.Label minimumQuantityLabel;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.Label unitPriceLabel;
        private System.Windows.Forms.Label unitCostLabel;
        private System.Windows.Forms.Label unitLabel;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.Label categoryLable;
        private System.Windows.Forms.Label supplierLabel;
        private System.Windows.Forms.Label brandLabel;
        private System.Windows.Forms.Label keyLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label keyDisplayLabel;
        private System.Windows.Forms.Label brandDisplayLabel;
        private System.Windows.Forms.Label supplierDisplayLabel;
        private System.Windows.Forms.Label categoryDisplayLabel;
        private System.Windows.Forms.Label typeDisplayLabel;
        private System.Windows.Forms.Label unitCostDisplayLabel;
        private System.Windows.Forms.Label unitPriceDisplayLabel;
        private System.Windows.Forms.Label unitDisplayLabel;
        private System.Windows.Forms.Label quantityDisplayLabel;
        private System.Windows.Forms.Label minimumDisplayLabel;
        private System.Windows.Forms.Label maximumDisplayLabel;
        private System.Windows.Forms.NumericUpDown addedAmmountNumericUpDown;
        private System.Windows.Forms.Button restockButton;
    }
}