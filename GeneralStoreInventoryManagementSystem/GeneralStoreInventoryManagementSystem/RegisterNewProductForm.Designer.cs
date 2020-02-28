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
            this.menuStrip1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RegisterNewProductForm_KeyDown);
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
            this.restockProductsMenuSubOption});
            this.productsMenuOption.Name = "productsMenuOption";
            this.productsMenuOption.Size = new System.Drawing.Size(66, 20);
            this.productsMenuOption.Text = "Products";
            // 
            // browseProductsMenuSubOption
            // 
            this.browseProductsMenuSubOption.Name = "browseProductsMenuSubOption";
            this.browseProductsMenuSubOption.ShortcutKeyDisplayString = "F3";
            this.browseProductsMenuSubOption.Size = new System.Drawing.Size(184, 22);
            this.browseProductsMenuSubOption.Text = "Product Browser";
            this.browseProductsMenuSubOption.Click += new System.EventHandler(this.BrowseProductsMenuSubOption_Click);
            // 
            // restockProductsMenuSubOption
            // 
            this.restockProductsMenuSubOption.Name = "restockProductsMenuSubOption";
            this.restockProductsMenuSubOption.ShortcutKeyDisplayString = "F5";
            this.restockProductsMenuSubOption.Size = new System.Drawing.Size(184, 22);
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
            this.viewGraphsOption.ShortcutKeyDisplayString = "F8";
            this.viewGraphsOption.Size = new System.Drawing.Size(161, 22);
            this.viewGraphsOption.Text = "View Graphs";
            this.viewGraphsOption.Click += new System.EventHandler(this.ViewGraphsOption_Click);
            // 
            // viewReportsOption
            // 
            this.viewReportsOption.Name = "viewReportsOption";
            this.viewReportsOption.ShortcutKeyDisplayString = "F9";
            this.viewReportsOption.Size = new System.Drawing.Size(161, 22);
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
            // registerNewProductTitleLabel
            // 
            this.registerNewProductTitleLabel.AutoSize = true;
            this.registerNewProductTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerNewProductTitleLabel.Location = new System.Drawing.Point(357, 36);
            this.registerNewProductTitleLabel.Name = "registerNewProductTitleLabel";
            this.registerNewProductTitleLabel.Size = new System.Drawing.Size(183, 20);
            this.registerNewProductTitleLabel.TabIndex = 10;
            this.registerNewProductTitleLabel.Text = "Register New Product";
            // 
            // keyLabel
            // 
            this.keyLabel.AutoSize = true;
            this.keyLabel.Location = new System.Drawing.Point(180, 72);
            this.keyLabel.Name = "keyLabel";
            this.keyLabel.Size = new System.Drawing.Size(68, 13);
            this.keyLabel.TabIndex = 11;
            this.keyLabel.Text = "Product Key:";
            // 
            // keyTextBox
            // 
            this.keyTextBox.Location = new System.Drawing.Point(201, 88);
            this.keyTextBox.Name = "keyTextBox";
            this.keyTextBox.Size = new System.Drawing.Size(206, 20);
            this.keyTextBox.TabIndex = 12;
            this.keyTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RegisterNewProductForm_KeyDown);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(484, 72);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(82, 13);
            this.nameLabel.TabIndex = 13;
            this.nameLabel.Text = "Product Name:*";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(505, 88);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(206, 20);
            this.nameTextBox.TabIndex = 14;
            this.nameTextBox.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
            this.nameTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RegisterNewProductForm_KeyDown);
            // 
            // brandLabel
            // 
            this.brandLabel.AutoSize = true;
            this.brandLabel.Location = new System.Drawing.Point(180, 137);
            this.brandLabel.Name = "brandLabel";
            this.brandLabel.Size = new System.Drawing.Size(38, 13);
            this.brandLabel.TabIndex = 15;
            this.brandLabel.Text = "Brand:";
            // 
            // brandListBox
            // 
            this.brandListBox.FormattingEnabled = true;
            this.brandListBox.Location = new System.Drawing.Point(186, 162);
            this.brandListBox.Name = "brandListBox";
            this.brandListBox.Size = new System.Drawing.Size(221, 121);
            this.brandListBox.TabIndex = 16;
            // 
            // brandSearchBox
            // 
            this.brandSearchBox.Location = new System.Drawing.Point(221, 134);
            this.brandSearchBox.Name = "brandSearchBox";
            this.brandSearchBox.Size = new System.Drawing.Size(186, 20);
            this.brandSearchBox.TabIndex = 17;
            this.brandSearchBox.TextChanged += new System.EventHandler(this.BrandSearchBox_TextChanged);
            this.brandSearchBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RegisterNewProductForm_KeyDown);
            // 
            // addNewBrandButton
            // 
            this.addNewBrandButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewBrandButton.Location = new System.Drawing.Point(153, 204);
            this.addNewBrandButton.Name = "addNewBrandButton";
            this.addNewBrandButton.Size = new System.Drawing.Size(27, 23);
            this.addNewBrandButton.TabIndex = 18;
            this.addNewBrandButton.Text = "+";
            this.addNewBrandButton.UseVisualStyleBackColor = true;
            this.addNewBrandButton.Click += new System.EventHandler(this.AddNewBrandButton_Click);
            // 
            // supplierLabel
            // 
            this.supplierLabel.AutoSize = true;
            this.supplierLabel.Location = new System.Drawing.Point(484, 137);
            this.supplierLabel.Name = "supplierLabel";
            this.supplierLabel.Size = new System.Drawing.Size(48, 13);
            this.supplierLabel.TabIndex = 19;
            this.supplierLabel.Text = "Supplier:";
            // 
            // supplierListBox
            // 
            this.supplierListBox.FormattingEnabled = true;
            this.supplierListBox.Location = new System.Drawing.Point(487, 162);
            this.supplierListBox.Name = "supplierListBox";
            this.supplierListBox.Size = new System.Drawing.Size(224, 121);
            this.supplierListBox.TabIndex = 20;
            // 
            // supplierSearchBox
            // 
            this.supplierSearchBox.Location = new System.Drawing.Point(535, 134);
            this.supplierSearchBox.Name = "supplierSearchBox";
            this.supplierSearchBox.Size = new System.Drawing.Size(176, 20);
            this.supplierSearchBox.TabIndex = 21;
            this.supplierSearchBox.TextChanged += new System.EventHandler(this.SupplierSearchBox_TextChanged);
            this.supplierSearchBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RegisterNewProductForm_KeyDown);
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Location = new System.Drawing.Point(180, 307);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(52, 13);
            this.categoryLabel.TabIndex = 22;
            this.categoryLabel.Text = "Category:";
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(201, 324);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(206, 21);
            this.categoryComboBox.TabIndex = 23;
            this.categoryComboBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RegisterNewProductForm_KeyDown);
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Location = new System.Drawing.Point(484, 307);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(34, 13);
            this.typeLabel.TabIndex = 24;
            this.typeLabel.Text = "Type:";
            // 
            // typeComboBox
            // 
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Location = new System.Drawing.Point(505, 324);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(206, 21);
            this.typeComboBox.TabIndex = 25;
            this.typeComboBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RegisterNewProductForm_KeyDown);
            // 
            // addNewSupplierButton
            // 
            this.addNewSupplierButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewSupplierButton.Location = new System.Drawing.Point(454, 204);
            this.addNewSupplierButton.Name = "addNewSupplierButton";
            this.addNewSupplierButton.Size = new System.Drawing.Size(27, 23);
            this.addNewSupplierButton.TabIndex = 26;
            this.addNewSupplierButton.Text = "+";
            this.addNewSupplierButton.UseVisualStyleBackColor = true;
            this.addNewSupplierButton.Click += new System.EventHandler(this.AddNewSupplierButton_Click);
            // 
            // unitLabel
            // 
            this.unitLabel.AutoSize = true;
            this.unitLabel.Location = new System.Drawing.Point(180, 372);
            this.unitLabel.Name = "unitLabel";
            this.unitLabel.Size = new System.Drawing.Size(112, 13);
            this.unitLabel.TabIndex = 27;
            this.unitLabel.Text = "Unit of Measurement:*";
            // 
            // unitTextBox
            // 
            this.unitTextBox.Location = new System.Drawing.Point(201, 389);
            this.unitTextBox.Name = "unitTextBox";
            this.unitTextBox.Size = new System.Drawing.Size(136, 20);
            this.unitTextBox.TabIndex = 28;
            this.unitTextBox.TextChanged += new System.EventHandler(this.UnitTextBox_TextChanged);
            this.unitTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RegisterNewProductForm_KeyDown);
            // 
            // costLabel
            // 
            this.costLabel.AutoSize = true;
            this.costLabel.Location = new System.Drawing.Point(362, 371);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(53, 13);
            this.costLabel.TabIndex = 29;
            this.costLabel.Text = "Unit Cost:";
            // 
            // costNumericUpDown
            // 
            this.costNumericUpDown.DecimalPlaces = 2;
            this.costNumericUpDown.Location = new System.Drawing.Point(382, 387);
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
            this.costNumericUpDown.Size = new System.Drawing.Size(136, 20);
            this.costNumericUpDown.TabIndex = 30;
            this.costNumericUpDown.ThousandsSeparator = true;
            this.costNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.costNumericUpDown.ValueChanged += new System.EventHandler(this.CostNumericUpDown_ValueChanged);
            this.costNumericUpDown.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RegisterNewProductForm_KeyDown);
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(553, 370);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(56, 13);
            this.priceLabel.TabIndex = 31;
            this.priceLabel.Text = "Unit Price:";
            // 
            // priceNumericUpDown
            // 
            this.priceNumericUpDown.DecimalPlaces = 2;
            this.priceNumericUpDown.Location = new System.Drawing.Point(575, 387);
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
            this.priceNumericUpDown.Size = new System.Drawing.Size(136, 20);
            this.priceNumericUpDown.TabIndex = 32;
            this.priceNumericUpDown.ThousandsSeparator = true;
            this.priceNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.priceNumericUpDown.ValueChanged += new System.EventHandler(this.PriceNumericUpDown_ValueChanged);
            this.priceNumericUpDown.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RegisterNewProductForm_KeyDown);
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Location = new System.Drawing.Point(180, 434);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(49, 13);
            this.quantityLabel.TabIndex = 33;
            this.quantityLabel.Text = "Quantity:";
            // 
            // quantityNumericUpDown
            // 
            this.quantityNumericUpDown.DecimalPlaces = 1;
            this.quantityNumericUpDown.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.quantityNumericUpDown.Location = new System.Drawing.Point(201, 451);
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
            this.quantityNumericUpDown.Size = new System.Drawing.Size(136, 20);
            this.quantityNumericUpDown.TabIndex = 34;
            this.quantityNumericUpDown.ThousandsSeparator = true;
            this.quantityNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.quantityNumericUpDown.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RegisterNewProductForm_KeyDown);
            // 
            // minimumLabel
            // 
            this.minimumLabel.AutoSize = true;
            this.minimumLabel.Location = new System.Drawing.Point(365, 433);
            this.minimumLabel.Name = "minimumLabel";
            this.minimumLabel.Size = new System.Drawing.Size(111, 13);
            this.minimumLabel.TabIndex = 35;
            this.minimumLabel.Text = "Minimum Stock Level:";
            // 
            // minimumNumericUpDown
            // 
            this.minimumNumericUpDown.DecimalPlaces = 1;
            this.minimumNumericUpDown.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.minimumNumericUpDown.Location = new System.Drawing.Point(382, 451);
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
            this.minimumNumericUpDown.Size = new System.Drawing.Size(136, 20);
            this.minimumNumericUpDown.TabIndex = 36;
            this.minimumNumericUpDown.ThousandsSeparator = true;
            this.minimumNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.minimumNumericUpDown.ValueChanged += new System.EventHandler(this.MinimumNumericUpDown_ValueChanged);
            this.minimumNumericUpDown.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RegisterNewProductForm_KeyDown);
            // 
            // maximumLabel
            // 
            this.maximumLabel.AutoSize = true;
            this.maximumLabel.Location = new System.Drawing.Point(556, 433);
            this.maximumLabel.Name = "maximumLabel";
            this.maximumLabel.Size = new System.Drawing.Size(114, 13);
            this.maximumLabel.TabIndex = 37;
            this.maximumLabel.Text = "Maximum Stock Level:";
            // 
            // maximumNumericUpDown
            // 
            this.maximumNumericUpDown.DecimalPlaces = 1;
            this.maximumNumericUpDown.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.maximumNumericUpDown.Location = new System.Drawing.Point(575, 451);
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
            this.maximumNumericUpDown.Size = new System.Drawing.Size(136, 20);
            this.maximumNumericUpDown.TabIndex = 38;
            this.maximumNumericUpDown.ThousandsSeparator = true;
            this.maximumNumericUpDown.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.maximumNumericUpDown.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RegisterNewProductForm_KeyDown);
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(535, 510);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(176, 23);
            this.createButton.TabIndex = 39;
            this.createButton.Text = "Create New Product";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(382, 509);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(136, 23);
            this.clearButton.TabIndex = 40;
            this.clearButton.Text = "Clear Information";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // unitContributionMarginLabel
            // 
            this.unitContributionMarginLabel.AutoSize = true;
            this.unitContributionMarginLabel.Location = new System.Drawing.Point(717, 392);
            this.unitContributionMarginLabel.Name = "unitContributionMarginLabel";
            this.unitContributionMarginLabel.Size = new System.Drawing.Size(137, 13);
            this.unitContributionMarginLabel.TabIndex = 42;
            this.unitContributionMarginLabel.Text = "0% ($0 or 1x price increase)";
            this.unitContributionMarginLabel.MouseLeave += new System.EventHandler(this.UnitContributionMarginLabel_MouseLeave);
            this.unitContributionMarginLabel.MouseHover += new System.EventHandler(this.UnitContributionMarginLabel_MouseHover);
            // 
            // RegisterNewProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 562);
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
            this.MinimumSize = new System.Drawing.Size(943, 600);
            this.Name = "RegisterNewProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register New Product";
            this.Load += new System.EventHandler(this.RegisterNewProductForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RegisterNewProductForm_KeyDown);
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