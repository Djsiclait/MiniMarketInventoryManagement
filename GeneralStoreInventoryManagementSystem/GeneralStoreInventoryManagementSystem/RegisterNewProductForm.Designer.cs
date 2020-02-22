namespace GeneralStoreInventoryManagementSystem
{
    partial class RegisterNewProductForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterNewProductForm));
            this.viewCartLabel = new System.Windows.Forms.Label();
            this.logOutLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.salesMenuOption = new System.Windows.Forms.ToolStripMenuItem();
            this.viewSalesMenuSubOption = new System.Windows.Forms.ToolStripMenuItem();
            this.makeSaleMenuSubOption = new System.Windows.Forms.ToolStripMenuItem();
            this.productsMenuOption = new System.Windows.Forms.ToolStripMenuItem();
            this.browseProductsMenuSubOption = new System.Windows.Forms.ToolStripMenuItem();
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
            this.registerNewProductTitleLabel = new System.Windows.Forms.Label();
            this.keyLabel = new System.Windows.Forms.Label();
            this.keyTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.brandLabel = new System.Windows.Forms.Label();
            this.brandListBox = new System.Windows.Forms.ListBox();
            this.brandSearchBox = new System.Windows.Forms.TextBox();
            this.addNewBrandButton = new System.Windows.Forms.Button();
            this.supplierLabel = new System.Windows.Forms.Label();
            this.supplierListBox = new System.Windows.Forms.ListBox();
            this.supplierSearchBox = new System.Windows.Forms.TextBox();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.typeLabel = new System.Windows.Forms.Label();
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.addNewSupplierButton = new System.Windows.Forms.Button();
            this.unitLabel = new System.Windows.Forms.Label();
            this.unitTextBox = new System.Windows.Forms.TextBox();
            this.costLabel = new System.Windows.Forms.Label();
            this.costNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.priceLabel = new System.Windows.Forms.Label();
            this.priceNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.quantityNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.minimumLabel = new System.Windows.Forms.Label();
            this.minimumNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.maximumLabel = new System.Windows.Forms.Label();
            this.maximumNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.createButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.unitContributionMarginLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.costNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantityNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimumNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximumNumericUpDown)).BeginInit();
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
            this.restockProductsMenuSubOption});
            this.productsMenuOption.Name = "productsMenuOption";
            // 
            // browseProductsMenuSubOption
            // 
            resources.ApplyResources(this.browseProductsMenuSubOption, "browseProductsMenuSubOption");
            this.browseProductsMenuSubOption.Name = "browseProductsMenuSubOption";
            this.browseProductsMenuSubOption.Click += new System.EventHandler(this.BrowseProductsMenuSubOption_Click);
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
            // registerNewProductTitleLabel
            // 
            resources.ApplyResources(this.registerNewProductTitleLabel, "registerNewProductTitleLabel");
            this.registerNewProductTitleLabel.Name = "registerNewProductTitleLabel";
            // 
            // keyLabel
            // 
            resources.ApplyResources(this.keyLabel, "keyLabel");
            this.keyLabel.Name = "keyLabel";
            // 
            // keyTextBox
            // 
            resources.ApplyResources(this.keyTextBox, "keyTextBox");
            this.keyTextBox.Name = "keyTextBox";
            // 
            // nameLabel
            // 
            resources.ApplyResources(this.nameLabel, "nameLabel");
            this.nameLabel.Name = "nameLabel";
            // 
            // nameTextBox
            // 
            resources.ApplyResources(this.nameTextBox, "nameTextBox");
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
            // 
            // brandLabel
            // 
            resources.ApplyResources(this.brandLabel, "brandLabel");
            this.brandLabel.Name = "brandLabel";
            // 
            // brandListBox
            // 
            resources.ApplyResources(this.brandListBox, "brandListBox");
            this.brandListBox.FormattingEnabled = true;
            this.brandListBox.Name = "brandListBox";
            // 
            // brandSearchBox
            // 
            resources.ApplyResources(this.brandSearchBox, "brandSearchBox");
            this.brandSearchBox.Name = "brandSearchBox";
            this.brandSearchBox.TextChanged += new System.EventHandler(this.BrandSearchBox_TextChanged);
            // 
            // addNewBrandButton
            // 
            resources.ApplyResources(this.addNewBrandButton, "addNewBrandButton");
            this.addNewBrandButton.Name = "addNewBrandButton";
            this.addNewBrandButton.UseVisualStyleBackColor = true;
            this.addNewBrandButton.Click += new System.EventHandler(this.AddNewBrandButton_Click);
            // 
            // supplierLabel
            // 
            resources.ApplyResources(this.supplierLabel, "supplierLabel");
            this.supplierLabel.Name = "supplierLabel";
            // 
            // supplierListBox
            // 
            resources.ApplyResources(this.supplierListBox, "supplierListBox");
            this.supplierListBox.FormattingEnabled = true;
            this.supplierListBox.Name = "supplierListBox";
            // 
            // supplierSearchBox
            // 
            resources.ApplyResources(this.supplierSearchBox, "supplierSearchBox");
            this.supplierSearchBox.Name = "supplierSearchBox";
            this.supplierSearchBox.TextChanged += new System.EventHandler(this.SupplierSearchBox_TextChanged);
            // 
            // categoryLabel
            // 
            resources.ApplyResources(this.categoryLabel, "categoryLabel");
            this.categoryLabel.Name = "categoryLabel";
            // 
            // categoryComboBox
            // 
            resources.ApplyResources(this.categoryComboBox, "categoryComboBox");
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Name = "categoryComboBox";
            // 
            // typeLabel
            // 
            resources.ApplyResources(this.typeLabel, "typeLabel");
            this.typeLabel.Name = "typeLabel";
            // 
            // typeComboBox
            // 
            resources.ApplyResources(this.typeComboBox, "typeComboBox");
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Name = "typeComboBox";
            // 
            // addNewSupplierButton
            // 
            resources.ApplyResources(this.addNewSupplierButton, "addNewSupplierButton");
            this.addNewSupplierButton.Name = "addNewSupplierButton";
            this.addNewSupplierButton.UseVisualStyleBackColor = true;
            this.addNewSupplierButton.Click += new System.EventHandler(this.AddNewSupplierButton_Click);
            // 
            // unitLabel
            // 
            resources.ApplyResources(this.unitLabel, "unitLabel");
            this.unitLabel.Name = "unitLabel";
            // 
            // unitTextBox
            // 
            resources.ApplyResources(this.unitTextBox, "unitTextBox");
            this.unitTextBox.Name = "unitTextBox";
            this.unitTextBox.TextChanged += new System.EventHandler(this.UnitTextBox_TextChanged);
            // 
            // costLabel
            // 
            resources.ApplyResources(this.costLabel, "costLabel");
            this.costLabel.Name = "costLabel";
            // 
            // costNumericUpDown
            // 
            resources.ApplyResources(this.costNumericUpDown, "costNumericUpDown");
            this.costNumericUpDown.DecimalPlaces = 2;
            this.costNumericUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.costNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.costNumericUpDown.Name = "costNumericUpDown";
            this.costNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.costNumericUpDown.ValueChanged += new System.EventHandler(this.CostNumericUpDown_ValueChanged);
            // 
            // priceLabel
            // 
            resources.ApplyResources(this.priceLabel, "priceLabel");
            this.priceLabel.Name = "priceLabel";
            // 
            // priceNumericUpDown
            // 
            resources.ApplyResources(this.priceNumericUpDown, "priceNumericUpDown");
            this.priceNumericUpDown.DecimalPlaces = 2;
            this.priceNumericUpDown.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.priceNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.priceNumericUpDown.Name = "priceNumericUpDown";
            this.priceNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.priceNumericUpDown.ValueChanged += new System.EventHandler(this.PriceNumericUpDown_ValueChanged);
            // 
            // quantityLabel
            // 
            resources.ApplyResources(this.quantityLabel, "quantityLabel");
            this.quantityLabel.Name = "quantityLabel";
            // 
            // quantityNumericUpDown
            // 
            resources.ApplyResources(this.quantityNumericUpDown, "quantityNumericUpDown");
            this.quantityNumericUpDown.DecimalPlaces = 1;
            this.quantityNumericUpDown.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.quantityNumericUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.quantityNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.quantityNumericUpDown.Name = "quantityNumericUpDown";
            this.quantityNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // minimumLabel
            // 
            resources.ApplyResources(this.minimumLabel, "minimumLabel");
            this.minimumLabel.Name = "minimumLabel";
            // 
            // minimumNumericUpDown
            // 
            resources.ApplyResources(this.minimumNumericUpDown, "minimumNumericUpDown");
            this.minimumNumericUpDown.DecimalPlaces = 1;
            this.minimumNumericUpDown.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.minimumNumericUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.minimumNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.minimumNumericUpDown.Name = "minimumNumericUpDown";
            this.minimumNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.minimumNumericUpDown.ValueChanged += new System.EventHandler(this.MinimumNumericUpDown_ValueChanged);
            // 
            // maximumLabel
            // 
            resources.ApplyResources(this.maximumLabel, "maximumLabel");
            this.maximumLabel.Name = "maximumLabel";
            // 
            // maximumNumericUpDown
            // 
            resources.ApplyResources(this.maximumNumericUpDown, "maximumNumericUpDown");
            this.maximumNumericUpDown.DecimalPlaces = 1;
            this.maximumNumericUpDown.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.maximumNumericUpDown.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.maximumNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.maximumNumericUpDown.Name = "maximumNumericUpDown";
            this.maximumNumericUpDown.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // createButton
            // 
            resources.ApplyResources(this.createButton, "createButton");
            this.createButton.Name = "createButton";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // clearButton
            // 
            resources.ApplyResources(this.clearButton, "clearButton");
            this.clearButton.Name = "clearButton";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // unitContributionMarginLabel
            // 
            resources.ApplyResources(this.unitContributionMarginLabel, "unitContributionMarginLabel");
            this.unitContributionMarginLabel.Name = "unitContributionMarginLabel";
            this.unitContributionMarginLabel.MouseLeave += new System.EventHandler(this.UnitContributionMarginLabel_MouseLeave);
            this.unitContributionMarginLabel.MouseHover += new System.EventHandler(this.UnitContributionMarginLabel_MouseHover);
            // 
            // RegisterNewProductForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.unitContributionMarginLabel);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.maximumNumericUpDown);
            this.Controls.Add(this.maximumLabel);
            this.Controls.Add(this.minimumNumericUpDown);
            this.Controls.Add(this.minimumLabel);
            this.Controls.Add(this.quantityNumericUpDown);
            this.Controls.Add(this.quantityLabel);
            this.Controls.Add(this.priceNumericUpDown);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.costNumericUpDown);
            this.Controls.Add(this.costLabel);
            this.Controls.Add(this.unitTextBox);
            this.Controls.Add(this.unitLabel);
            this.Controls.Add(this.addNewSupplierButton);
            this.Controls.Add(this.typeComboBox);
            this.Controls.Add(this.typeLabel);
            this.Controls.Add(this.categoryComboBox);
            this.Controls.Add(this.categoryLabel);
            this.Controls.Add(this.supplierSearchBox);
            this.Controls.Add(this.supplierListBox);
            this.Controls.Add(this.supplierLabel);
            this.Controls.Add(this.addNewBrandButton);
            this.Controls.Add(this.brandSearchBox);
            this.Controls.Add(this.brandListBox);
            this.Controls.Add(this.brandLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.keyTextBox);
            this.Controls.Add(this.keyLabel);
            this.Controls.Add(this.registerNewProductTitleLabel);
            this.Controls.Add(this.viewCartLabel);
            this.Controls.Add(this.logOutLabel);
            this.Controls.Add(this.menuStrip1);
            this.Name = "RegisterNewProductForm";
            this.Load += new System.EventHandler(this.RegisterNewProductForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.costNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quantityNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimumNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maximumNumericUpDown)).EndInit();
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
        private System.Windows.Forms.Label registerNewProductTitleLabel;
        private System.Windows.Forms.Label keyLabel;
        private System.Windows.Forms.TextBox keyTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label brandLabel;
        private System.Windows.Forms.ListBox brandListBox;
        private System.Windows.Forms.TextBox brandSearchBox;
        private System.Windows.Forms.Button addNewBrandButton;
        private System.Windows.Forms.Label supplierLabel;
        private System.Windows.Forms.ListBox supplierListBox;
        private System.Windows.Forms.TextBox supplierSearchBox;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.ComboBox typeComboBox;
        private System.Windows.Forms.Button addNewSupplierButton;
        private System.Windows.Forms.Label unitLabel;
        private System.Windows.Forms.TextBox unitTextBox;
        private System.Windows.Forms.Label costLabel;
        private System.Windows.Forms.NumericUpDown costNumericUpDown;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.NumericUpDown priceNumericUpDown;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.NumericUpDown quantityNumericUpDown;
        private System.Windows.Forms.Label minimumLabel;
        private System.Windows.Forms.NumericUpDown minimumNumericUpDown;
        private System.Windows.Forms.Label maximumLabel;
        private System.Windows.Forms.NumericUpDown maximumNumericUpDown;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label unitContributionMarginLabel;
    }
}