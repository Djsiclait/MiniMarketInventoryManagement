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
            this.registerNewProductMenuSubOption});
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
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Location = new System.Drawing.Point(550, 49);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(86, 13);
            this.searchLabel.TabIndex = 13;
            this.searchLabel.Text = "Search Products";
            // 
            // productList
            // 
            this.productList.AllowUserToAddRows = false;
            this.productList.AllowUserToDeleteRows = false;
            this.productList.AllowUserToResizeColumns = false;
            this.productList.AllowUserToResizeRows = false;
            this.productList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.productList.Location = new System.Drawing.Point(12, 73);
            this.productList.MultiSelect = false;
            this.productList.Name = "productList";
            this.productList.ReadOnly = true;
            this.productList.RowHeadersVisible = false;
            this.productList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.productList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productList.Size = new System.Drawing.Size(903, 145);
            this.productList.TabIndex = 12;
            this.productList.SelectionChanged += new System.EventHandler(this.ProductList_SelectionChanged);
            // 
            // browserFormTitle
            // 
            this.browserFormTitle.AutoSize = true;
            this.browserFormTitle.Location = new System.Drawing.Point(66, 49);
            this.browserFormTitle.Name = "browserFormTitle";
            this.browserFormTitle.Size = new System.Drawing.Size(92, 13);
            this.browserFormTitle.TabIndex = 11;
            this.browserFormTitle.Text = "Inventory Browser";
            // 
            // inventorySearchBox
            // 
            this.inventorySearchBox.Location = new System.Drawing.Point(642, 46);
            this.inventorySearchBox.Name = "inventorySearchBox";
            this.inventorySearchBox.Size = new System.Drawing.Size(273, 20);
            this.inventorySearchBox.TabIndex = 10;
            this.inventorySearchBox.TextChanged += new System.EventHandler(this.InventorySearchBox_TextChanged);
            // 
            // unitContributionMarginLabel
            // 
            this.unitContributionMarginLabel.AutoSize = true;
            this.unitContributionMarginLabel.Location = new System.Drawing.Point(462, 416);
            this.unitContributionMarginLabel.Name = "unitContributionMarginLabel";
            this.unitContributionMarginLabel.Size = new System.Drawing.Size(137, 13);
            this.unitContributionMarginLabel.TabIndex = 72;
            this.unitContributionMarginLabel.Text = "0% ($0 or 1x price increase)";
            // 
            // nameDisplayLabel
            // 
            this.nameDisplayLabel.AutoSize = true;
            this.nameDisplayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameDisplayLabel.Location = new System.Drawing.Point(401, 251);
            this.nameDisplayLabel.Name = "nameDisplayLabel";
            this.nameDisplayLabel.Size = new System.Drawing.Size(57, 20);
            this.nameDisplayLabel.TabIndex = 71;
            this.nameDisplayLabel.Text = "label1";
            // 
            // maximumQuantityLabel
            // 
            this.maximumQuantityLabel.AutoSize = true;
            this.maximumQuantityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maximumQuantityLabel.Location = new System.Drawing.Point(623, 474);
            this.maximumQuantityLabel.Name = "maximumQuantityLabel";
            this.maximumQuantityLabel.Size = new System.Drawing.Size(127, 17);
            this.maximumQuantityLabel.TabIndex = 68;
            this.maximumQuantityLabel.Text = "Maximum Quantity:";
            // 
            // minimumQuantityLabel
            // 
            this.minimumQuantityLabel.AutoSize = true;
            this.minimumQuantityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimumQuantityLabel.Location = new System.Drawing.Point(358, 474);
            this.minimumQuantityLabel.Name = "minimumQuantityLabel";
            this.minimumQuantityLabel.Size = new System.Drawing.Size(124, 17);
            this.minimumQuantityLabel.TabIndex = 67;
            this.minimumQuantityLabel.Text = "Minimum Quantity:";
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityLabel.Location = new System.Drawing.Point(93, 474);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(65, 17);
            this.quantityLabel.TabIndex = 66;
            this.quantityLabel.Text = "Quantity:";
            // 
            // unitPriceLabel
            // 
            this.unitPriceLabel.AutoSize = true;
            this.unitPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unitPriceLabel.Location = new System.Drawing.Point(623, 414);
            this.unitPriceLabel.Name = "unitPriceLabel";
            this.unitPriceLabel.Size = new System.Drawing.Size(73, 17);
            this.unitPriceLabel.TabIndex = 65;
            this.unitPriceLabel.Text = "Unit Price:";
            // 
            // unitCostLabel
            // 
            this.unitCostLabel.AutoSize = true;
            this.unitCostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unitCostLabel.Location = new System.Drawing.Point(358, 414);
            this.unitCostLabel.Name = "unitCostLabel";
            this.unitCostLabel.Size = new System.Drawing.Size(69, 17);
            this.unitCostLabel.TabIndex = 64;
            this.unitCostLabel.Text = "Unit Cost:";
            // 
            // unitLabel
            // 
            this.unitLabel.AutoSize = true;
            this.unitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unitLabel.Location = new System.Drawing.Point(93, 414);
            this.unitLabel.Name = "unitLabel";
            this.unitLabel.Size = new System.Drawing.Size(37, 17);
            this.unitLabel.TabIndex = 63;
            this.unitLabel.Text = "Unit:";
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeLabel.Location = new System.Drawing.Point(358, 354);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(44, 17);
            this.typeLabel.TabIndex = 62;
            this.typeLabel.Text = "Type:";
            // 
            // categoryLable
            // 
            this.categoryLable.AutoSize = true;
            this.categoryLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryLable.Location = new System.Drawing.Point(93, 354);
            this.categoryLable.Name = "categoryLable";
            this.categoryLable.Size = new System.Drawing.Size(69, 17);
            this.categoryLable.TabIndex = 61;
            this.categoryLable.Text = "Category:";
            // 
            // supplierLabel
            // 
            this.supplierLabel.AutoSize = true;
            this.supplierLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplierLabel.Location = new System.Drawing.Point(358, 294);
            this.supplierLabel.Name = "supplierLabel";
            this.supplierLabel.Size = new System.Drawing.Size(64, 17);
            this.supplierLabel.TabIndex = 60;
            this.supplierLabel.Text = "Supplier:";
            // 
            // brandLabel
            // 
            this.brandLabel.AutoSize = true;
            this.brandLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brandLabel.Location = new System.Drawing.Point(93, 294);
            this.brandLabel.Name = "brandLabel";
            this.brandLabel.Size = new System.Drawing.Size(50, 17);
            this.brandLabel.TabIndex = 59;
            this.brandLabel.Text = "Brand:";
            // 
            // keyLabel
            // 
            this.keyLabel.AutoSize = true;
            this.keyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keyLabel.Location = new System.Drawing.Point(93, 234);
            this.keyLabel.Name = "keyLabel";
            this.keyLabel.Size = new System.Drawing.Size(36, 17);
            this.keyLabel.TabIndex = 58;
            this.keyLabel.Text = "Key:";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(358, 234);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(49, 17);
            this.nameLabel.TabIndex = 57;
            this.nameLabel.Text = "Name:";
            // 
            // keyDisplayLabel
            // 
            this.keyDisplayLabel.AutoSize = true;
            this.keyDisplayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keyDisplayLabel.Location = new System.Drawing.Point(122, 251);
            this.keyDisplayLabel.Name = "keyDisplayLabel";
            this.keyDisplayLabel.Size = new System.Drawing.Size(57, 20);
            this.keyDisplayLabel.TabIndex = 73;
            this.keyDisplayLabel.Text = "label1";
            // 
            // brandDisplayLabel
            // 
            this.brandDisplayLabel.AutoSize = true;
            this.brandDisplayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brandDisplayLabel.Location = new System.Drawing.Point(122, 311);
            this.brandDisplayLabel.Name = "brandDisplayLabel";
            this.brandDisplayLabel.Size = new System.Drawing.Size(57, 20);
            this.brandDisplayLabel.TabIndex = 75;
            this.brandDisplayLabel.Text = "label1";
            // 
            // supplierDisplayLabel
            // 
            this.supplierDisplayLabel.AutoSize = true;
            this.supplierDisplayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplierDisplayLabel.Location = new System.Drawing.Point(401, 311);
            this.supplierDisplayLabel.Name = "supplierDisplayLabel";
            this.supplierDisplayLabel.Size = new System.Drawing.Size(57, 20);
            this.supplierDisplayLabel.TabIndex = 74;
            this.supplierDisplayLabel.Text = "label1";
            // 
            // categoryDisplayLabel
            // 
            this.categoryDisplayLabel.AutoSize = true;
            this.categoryDisplayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryDisplayLabel.Location = new System.Drawing.Point(122, 371);
            this.categoryDisplayLabel.Name = "categoryDisplayLabel";
            this.categoryDisplayLabel.Size = new System.Drawing.Size(57, 20);
            this.categoryDisplayLabel.TabIndex = 77;
            this.categoryDisplayLabel.Text = "label1";
            // 
            // typeDisplayLabel
            // 
            this.typeDisplayLabel.AutoSize = true;
            this.typeDisplayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeDisplayLabel.Location = new System.Drawing.Point(401, 371);
            this.typeDisplayLabel.Name = "typeDisplayLabel";
            this.typeDisplayLabel.Size = new System.Drawing.Size(57, 20);
            this.typeDisplayLabel.TabIndex = 76;
            this.typeDisplayLabel.Text = "label1";
            // 
            // unitCostDisplayLabel
            // 
            this.unitCostDisplayLabel.AutoSize = true;
            this.unitCostDisplayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unitCostDisplayLabel.Location = new System.Drawing.Point(401, 431);
            this.unitCostDisplayLabel.Name = "unitCostDisplayLabel";
            this.unitCostDisplayLabel.Size = new System.Drawing.Size(57, 20);
            this.unitCostDisplayLabel.TabIndex = 79;
            this.unitCostDisplayLabel.Text = "label3";
            // 
            // unitPriceDisplayLabel
            // 
            this.unitPriceDisplayLabel.AutoSize = true;
            this.unitPriceDisplayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unitPriceDisplayLabel.Location = new System.Drawing.Point(680, 431);
            this.unitPriceDisplayLabel.Name = "unitPriceDisplayLabel";
            this.unitPriceDisplayLabel.Size = new System.Drawing.Size(57, 20);
            this.unitPriceDisplayLabel.TabIndex = 78;
            this.unitPriceDisplayLabel.Text = "label1";
            // 
            // unitDisplayLabel
            // 
            this.unitDisplayLabel.AutoSize = true;
            this.unitDisplayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unitDisplayLabel.Location = new System.Drawing.Point(122, 431);
            this.unitDisplayLabel.Name = "unitDisplayLabel";
            this.unitDisplayLabel.Size = new System.Drawing.Size(57, 20);
            this.unitDisplayLabel.TabIndex = 81;
            this.unitDisplayLabel.Text = "label3";
            // 
            // quantityDisplayLabel
            // 
            this.quantityDisplayLabel.AutoSize = true;
            this.quantityDisplayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityDisplayLabel.Location = new System.Drawing.Point(122, 491);
            this.quantityDisplayLabel.Name = "quantityDisplayLabel";
            this.quantityDisplayLabel.Size = new System.Drawing.Size(57, 20);
            this.quantityDisplayLabel.TabIndex = 80;
            this.quantityDisplayLabel.Text = "label1";
            // 
            // minimumDisplayLabel
            // 
            this.minimumDisplayLabel.AutoSize = true;
            this.minimumDisplayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimumDisplayLabel.Location = new System.Drawing.Point(401, 491);
            this.minimumDisplayLabel.Name = "minimumDisplayLabel";
            this.minimumDisplayLabel.Size = new System.Drawing.Size(57, 20);
            this.minimumDisplayLabel.TabIndex = 84;
            this.minimumDisplayLabel.Text = "label3";
            // 
            // maximumDisplayLabel
            // 
            this.maximumDisplayLabel.AutoSize = true;
            this.maximumDisplayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maximumDisplayLabel.Location = new System.Drawing.Point(680, 491);
            this.maximumDisplayLabel.Name = "maximumDisplayLabel";
            this.maximumDisplayLabel.Size = new System.Drawing.Size(57, 20);
            this.maximumDisplayLabel.TabIndex = 83;
            this.maximumDisplayLabel.Text = "label1";
            // 
            // addedAmmountNumericUpDown
            // 
            this.addedAmmountNumericUpDown.Location = new System.Drawing.Point(361, 530);
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
            this.addedAmmountNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.addedAmmountNumericUpDown.TabIndex = 85;
            this.addedAmmountNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.addedAmmountNumericUpDown.ThousandsSeparator = true;
            this.addedAmmountNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // restockButton
            // 
            this.restockButton.Location = new System.Drawing.Point(487, 527);
            this.restockButton.Name = "restockButton";
            this.restockButton.Size = new System.Drawing.Size(75, 23);
            this.restockButton.TabIndex = 86;
            this.restockButton.Text = "Restock";
            this.restockButton.UseVisualStyleBackColor = true;
            // 
            // RestockProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 562);
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
            this.MinimumSize = new System.Drawing.Size(943, 600);
            this.Name = "RestockProductsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Restock Products";
            this.Load += new System.EventHandler(this.RestockProductsForm_Load);
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