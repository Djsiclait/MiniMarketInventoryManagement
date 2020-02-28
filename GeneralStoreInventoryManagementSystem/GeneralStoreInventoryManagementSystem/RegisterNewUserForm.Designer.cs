namespace GeneralStoreInventoryManagementSystem
{
    partial class RegisterNewUserForm
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
            this.viewUsersMenuSubOption = new System.Windows.Forms.ToolStripMenuItem();
            this.statisticsMenuSubOption = new System.Windows.Forms.ToolStripMenuItem();
            this.viewGraphsOption = new System.Windows.Forms.ToolStripMenuItem();
            this.viewReportsOption = new System.Windows.Forms.ToolStripMenuItem();
            this.logsMenuSubOption = new System.Windows.Forms.ToolStripMenuItem();
            this.viewActivityLogsOption = new System.Windows.Forms.ToolStripMenuItem();
            this.viewErrorLogsOption = new System.Windows.Forms.ToolStripMenuItem();
            this.titleLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.confirmPasswordLabel = new System.Windows.Forms.Label();
            this.confirmPasswordTextBox = new System.Windows.Forms.TextBox();
            this.grantAdminCheckbox = new System.Windows.Forms.CheckBox();
            this.createNewUserButton = new System.Windows.Forms.Button();
            this.createAndReturnButton = new System.Windows.Forms.Button();
            this.messageLabel = new System.Windows.Forms.Label();
            this.usernameErrorLable = new System.Windows.Forms.Label();
            this.confirmationPasswordErrorLabel = new System.Windows.Forms.Label();
            this.passwordErrorLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // viewCartLabel
            // 
            this.viewCartLabel.AutoSize = true;
            this.viewCartLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.viewCartLabel.Location = new System.Drawing.Point(765, 9);
            this.viewCartLabel.Name = "viewCartLabel";
            this.viewCartLabel.Size = new System.Drawing.Size(52, 13);
            this.viewCartLabel.TabIndex = 12;
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
            this.LogOutLabel.TabIndex = 11;
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
            this.menuStrip1.TabIndex = 10;
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
            this.viewUsersMenuSubOption,
            this.statisticsMenuSubOption,
            this.logsMenuSubOption});
            this.adminMenuOption.Name = "adminMenuOption";
            this.adminMenuOption.Size = new System.Drawing.Size(55, 20);
            this.adminMenuOption.Text = "Admin";
            // 
            // viewUsersMenuSubOption
            // 
            this.viewUsersMenuSubOption.Name = "viewUsersMenuSubOption";
            this.viewUsersMenuSubOption.ShortcutKeyDisplayString = "F6";
            this.viewUsersMenuSubOption.Size = new System.Drawing.Size(180, 22);
            this.viewUsersMenuSubOption.Text = "View Users";
            this.viewUsersMenuSubOption.Click += new System.EventHandler(this.ViewUsersMenuSubOption_Click);
            // 
            // statisticsMenuSubOption
            // 
            this.statisticsMenuSubOption.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewGraphsOption,
            this.viewReportsOption});
            this.statisticsMenuSubOption.Name = "statisticsMenuSubOption";
            this.statisticsMenuSubOption.Size = new System.Drawing.Size(180, 22);
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
            this.logsMenuSubOption.Size = new System.Drawing.Size(180, 22);
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
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(356, 54);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(215, 20);
            this.titleLabel.TabIndex = 13;
            this.titleLabel.Text = "Register New User Profile";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(297, 97);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(61, 13);
            this.usernameLabel.TabIndex = 14;
            this.usernameLabel.Text = "Username: ";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(333, 113);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(261, 20);
            this.usernameTextBox.TabIndex = 15;
            this.usernameTextBox.TextChanged += new System.EventHandler(this.UsernameTextBox_TextChanged);
            this.usernameTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RegisterNewUserForm_KeyDown);
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(297, 156);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(63, 13);
            this.firstNameLabel.TabIndex = 16;
            this.firstNameLabel.Text = "First Name: ";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(333, 173);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(261, 20);
            this.firstNameTextBox.TabIndex = 17;
            this.firstNameTextBox.TextChanged += new System.EventHandler(this.FirstNameTextBox_TextChanged);
            this.firstNameTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RegisterNewUserForm_KeyDown);
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(297, 213);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(64, 13);
            this.lastNameLabel.TabIndex = 18;
            this.lastNameLabel.Text = "Last Name: ";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(333, 230);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(261, 20);
            this.lastNameTextBox.TabIndex = 19;
            this.lastNameTextBox.TextChanged += new System.EventHandler(this.LastNameTextBox_TextChanged);
            this.lastNameTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RegisterNewUserForm_KeyDown);
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(300, 267);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(56, 13);
            this.passwordLabel.TabIndex = 20;
            this.passwordLabel.Text = "Password:";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(333, 284);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(261, 20);
            this.passwordTextBox.TabIndex = 21;
            this.passwordTextBox.TextChanged += new System.EventHandler(this.PasswordTextBox_TextChanged);
            this.passwordTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RegisterNewUserForm_KeyDown);
            // 
            // confirmPasswordLabel
            // 
            this.confirmPasswordLabel.AutoSize = true;
            this.confirmPasswordLabel.Location = new System.Drawing.Point(303, 317);
            this.confirmPasswordLabel.Name = "confirmPasswordLabel";
            this.confirmPasswordLabel.Size = new System.Drawing.Size(94, 13);
            this.confirmPasswordLabel.TabIndex = 22;
            this.confirmPasswordLabel.Text = "Confirm Password:";
            // 
            // confirmPasswordTextBox
            // 
            this.confirmPasswordTextBox.Location = new System.Drawing.Point(333, 334);
            this.confirmPasswordTextBox.Name = "confirmPasswordTextBox";
            this.confirmPasswordTextBox.PasswordChar = '*';
            this.confirmPasswordTextBox.Size = new System.Drawing.Size(261, 20);
            this.confirmPasswordTextBox.TabIndex = 23;
            this.confirmPasswordTextBox.TextChanged += new System.EventHandler(this.ConfirmPasswordTextBox_TextChanged);
            this.confirmPasswordTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RegisterNewUserForm_KeyDown);
            // 
            // grantAdminCheckbox
            // 
            this.grantAdminCheckbox.AutoSize = true;
            this.grantAdminCheckbox.Location = new System.Drawing.Point(391, 377);
            this.grantAdminCheckbox.Name = "grantAdminCheckbox";
            this.grantAdminCheckbox.Size = new System.Drawing.Size(125, 17);
            this.grantAdminCheckbox.TabIndex = 24;
            this.grantAdminCheckbox.Text = "Grant Admin Controls";
            this.grantAdminCheckbox.UseVisualStyleBackColor = true;
            this.grantAdminCheckbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RegisterNewUserForm_KeyDown);
            // 
            // createNewUserButton
            // 
            this.createNewUserButton.Location = new System.Drawing.Point(333, 421);
            this.createNewUserButton.Name = "createNewUserButton";
            this.createNewUserButton.Size = new System.Drawing.Size(261, 23);
            this.createNewUserButton.TabIndex = 25;
            this.createNewUserButton.Text = "Create New User";
            this.createNewUserButton.UseVisualStyleBackColor = true;
            this.createNewUserButton.Click += new System.EventHandler(this.CreateNewUserButton_Click);
            this.createNewUserButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RegisterNewUserForm_KeyDown);
            // 
            // createAndReturnButton
            // 
            this.createAndReturnButton.Location = new System.Drawing.Point(333, 459);
            this.createAndReturnButton.Name = "createAndReturnButton";
            this.createAndReturnButton.Size = new System.Drawing.Size(261, 23);
            this.createAndReturnButton.TabIndex = 26;
            this.createAndReturnButton.Text = "Create and Return to User Registry";
            this.createAndReturnButton.UseVisualStyleBackColor = true;
            this.createAndReturnButton.Click += new System.EventHandler(this.CreateAndReturnButton_Click);
            this.createAndReturnButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RegisterNewUserForm_KeyDown);
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageLabel.Location = new System.Drawing.Point(330, 510);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(46, 17);
            this.messageLabel.TabIndex = 27;
            this.messageLabel.Text = "label1";
            // 
            // usernameErrorLable
            // 
            this.usernameErrorLable.AutoSize = true;
            this.usernameErrorLable.ForeColor = System.Drawing.Color.Red;
            this.usernameErrorLable.Location = new System.Drawing.Point(600, 116);
            this.usernameErrorLable.Name = "usernameErrorLable";
            this.usernameErrorLable.Size = new System.Drawing.Size(122, 13);
            this.usernameErrorLable.TabIndex = 28;
            this.usernameErrorLable.Text = "Username is unavailable";
            // 
            // confirmationPasswordErrorLabel
            // 
            this.confirmationPasswordErrorLabel.AutoSize = true;
            this.confirmationPasswordErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.confirmationPasswordErrorLabel.Location = new System.Drawing.Point(600, 337);
            this.confirmationPasswordErrorLabel.Name = "confirmationPasswordErrorLabel";
            this.confirmationPasswordErrorLabel.Size = new System.Drawing.Size(275, 13);
            this.confirmationPasswordErrorLabel.TabIndex = 29;
            this.confirmationPasswordErrorLabel.Text = "Confirmation password does not match chosen password";
            // 
            // passwordErrorLabel
            // 
            this.passwordErrorLabel.AutoSize = true;
            this.passwordErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.passwordErrorLabel.Location = new System.Drawing.Point(600, 287);
            this.passwordErrorLabel.Name = "passwordErrorLabel";
            this.passwordErrorLabel.Size = new System.Drawing.Size(87, 13);
            this.passwordErrorLabel.TabIndex = 30;
            this.passwordErrorLabel.Text = "Invalid Password";
            this.passwordErrorLabel.Visible = false;
            // 
            // RegisterNewUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 562);
            this.Controls.Add(this.passwordErrorLabel);
            this.Controls.Add(this.confirmationPasswordErrorLabel);
            this.Controls.Add(this.usernameErrorLable);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.createAndReturnButton);
            this.Controls.Add(this.createNewUserButton);
            this.Controls.Add(this.grantAdminCheckbox);
            this.Controls.Add(this.confirmPasswordTextBox);
            this.Controls.Add(this.confirmPasswordLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.viewCartLabel);
            this.Controls.Add(this.LogOutLabel);
            this.Controls.Add(this.menuStrip1);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(943, 600);
            this.Name = "RegisterNewUserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register New User";
            this.Load += new System.EventHandler(this.RegisterNewUserForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RegisterNewUserForm_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem productsMenuOption;
        private System.Windows.Forms.ToolStripMenuItem browseProductsMenuSubOption;
        private System.Windows.Forms.ToolStripMenuItem registerNewProductMenuSubOption;
        private System.Windows.Forms.ToolStripMenuItem restockProductsMenuSubOption;
        private System.Windows.Forms.ToolStripMenuItem adminMenuOption;
        private System.Windows.Forms.ToolStripMenuItem viewUsersMenuSubOption;
        private System.Windows.Forms.ToolStripMenuItem statisticsMenuSubOption;
        private System.Windows.Forms.ToolStripMenuItem viewGraphsOption;
        private System.Windows.Forms.ToolStripMenuItem viewReportsOption;
        private System.Windows.Forms.ToolStripMenuItem logsMenuSubOption;
        private System.Windows.Forms.ToolStripMenuItem viewActivityLogsOption;
        private System.Windows.Forms.ToolStripMenuItem viewErrorLogsOption;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label confirmPasswordLabel;
        private System.Windows.Forms.TextBox confirmPasswordTextBox;
        private System.Windows.Forms.CheckBox grantAdminCheckbox;
        private System.Windows.Forms.Button createNewUserButton;
        private System.Windows.Forms.Button createAndReturnButton;
        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.Label usernameErrorLable;
        private System.Windows.Forms.Label confirmationPasswordErrorLabel;
        private System.Windows.Forms.Label passwordErrorLabel;
    }
}