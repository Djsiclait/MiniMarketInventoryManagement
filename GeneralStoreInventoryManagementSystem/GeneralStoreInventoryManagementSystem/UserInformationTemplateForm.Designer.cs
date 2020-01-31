namespace GeneralStoreInventoryManagementSystem
{
    partial class UserInformationTemplateForm
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
            this.userTitleLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.roleLabel = new System.Windows.Forms.Label();
            this.roleTextBox = new System.Windows.Forms.TextBox();
            this.creatorLabel = new System.Windows.Forms.Label();
            this.creatorTextBox = new System.Windows.Forms.TextBox();
            this.statusLabel = new System.Windows.Forms.Label();
            this.statusTextBox = new System.Windows.Forms.TextBox();
            this.registrationDateLabel = new System.Windows.Forms.Label();
            this.registrationDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.lastLoginLabel = new System.Windows.Forms.Label();
            this.lastLoginDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.searchActivityLabel = new System.Windows.Forms.Label();
            this.activitySearchBox = new System.Windows.Forms.TextBox();
            this.activityList = new System.Windows.Forms.DataGridView();
            this.changePasswordButton = new System.Windows.Forms.Button();
            this.changeAccessLevelButtom = new System.Windows.Forms.Button();
            this.suspendUserButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.activityList)).BeginInit();
            this.SuspendLayout();
            // 
            // userTitleLabel
            // 
            this.userTitleLabel.AutoSize = true;
            this.userTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userTitleLabel.Location = new System.Drawing.Point(299, 9);
            this.userTitleLabel.Name = "userTitleLabel";
            this.userTitleLabel.Size = new System.Drawing.Size(47, 17);
            this.userTitleLabel.TabIndex = 0;
            this.userTitleLabel.Text = "User:";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(13, 39);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(58, 13);
            this.usernameLabel.TabIndex = 1;
            this.usernameLabel.Text = "Username:";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(49, 55);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.ReadOnly = true;
            this.usernameTextBox.Size = new System.Drawing.Size(165, 20);
            this.usernameTextBox.TabIndex = 2;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(13, 93);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(60, 13);
            this.firstNameLabel.TabIndex = 3;
            this.firstNameLabel.Text = "First Name:";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(49, 109);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.ReadOnly = true;
            this.firstNameTextBox.Size = new System.Drawing.Size(247, 20);
            this.firstNameTextBox.TabIndex = 4;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(13, 145);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(64, 13);
            this.lastNameLabel.TabIndex = 5;
            this.lastNameLabel.Text = "Last Name: ";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(49, 161);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.ReadOnly = true;
            this.lastNameTextBox.Size = new System.Drawing.Size(247, 20);
            this.lastNameTextBox.TabIndex = 6;
            // 
            // roleLabel
            // 
            this.roleLabel.AutoSize = true;
            this.roleLabel.Location = new System.Drawing.Point(13, 199);
            this.roleLabel.Name = "roleLabel";
            this.roleLabel.Size = new System.Drawing.Size(74, 13);
            this.roleLabel.TabIndex = 7;
            this.roleLabel.Text = "Access Level:";
            // 
            // roleTextBox
            // 
            this.roleTextBox.Location = new System.Drawing.Point(49, 215);
            this.roleTextBox.Name = "roleTextBox";
            this.roleTextBox.ReadOnly = true;
            this.roleTextBox.Size = new System.Drawing.Size(165, 20);
            this.roleTextBox.TabIndex = 8;
            // 
            // creatorLabel
            // 
            this.creatorLabel.AutoSize = true;
            this.creatorLabel.Location = new System.Drawing.Point(13, 253);
            this.creatorLabel.Name = "creatorLabel";
            this.creatorLabel.Size = new System.Drawing.Size(44, 13);
            this.creatorLabel.TabIndex = 9;
            this.creatorLabel.Text = "Creator:";
            // 
            // creatorTextBox
            // 
            this.creatorTextBox.Location = new System.Drawing.Point(49, 269);
            this.creatorTextBox.Name = "creatorTextBox";
            this.creatorTextBox.ReadOnly = true;
            this.creatorTextBox.Size = new System.Drawing.Size(165, 20);
            this.creatorTextBox.TabIndex = 10;
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(13, 304);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(40, 13);
            this.statusLabel.TabIndex = 11;
            this.statusLabel.Text = "Status:";
            // 
            // statusTextBox
            // 
            this.statusTextBox.Location = new System.Drawing.Point(49, 320);
            this.statusTextBox.Name = "statusTextBox";
            this.statusTextBox.ReadOnly = true;
            this.statusTextBox.Size = new System.Drawing.Size(165, 20);
            this.statusTextBox.TabIndex = 12;
            // 
            // registrationDateLabel
            // 
            this.registrationDateLabel.AutoSize = true;
            this.registrationDateLabel.Location = new System.Drawing.Point(170, 364);
            this.registrationDateLabel.Name = "registrationDateLabel";
            this.registrationDateLabel.Size = new System.Drawing.Size(65, 13);
            this.registrationDateLabel.TabIndex = 13;
            this.registrationDateLabel.Text = "Created on: ";
            // 
            // registrationDateDateTimePicker
            // 
            this.registrationDateDateTimePicker.Enabled = false;
            this.registrationDateDateTimePicker.Location = new System.Drawing.Point(173, 380);
            this.registrationDateDateTimePicker.Name = "registrationDateDateTimePicker";
            this.registrationDateDateTimePicker.Size = new System.Drawing.Size(172, 20);
            this.registrationDateDateTimePicker.TabIndex = 14;
            // 
            // lastLoginLabel
            // 
            this.lastLoginLabel.AutoSize = true;
            this.lastLoginLabel.Location = new System.Drawing.Point(361, 364);
            this.lastLoginLabel.Name = "lastLoginLabel";
            this.lastLoginLabel.Size = new System.Drawing.Size(59, 13);
            this.lastLoginLabel.TabIndex = 15;
            this.lastLoginLabel.Text = "Last Login:";
            // 
            // lastLoginDateTimePicker
            // 
            this.lastLoginDateTimePicker.Enabled = false;
            this.lastLoginDateTimePicker.Location = new System.Drawing.Point(364, 380);
            this.lastLoginDateTimePicker.Name = "lastLoginDateTimePicker";
            this.lastLoginDateTimePicker.Size = new System.Drawing.Size(172, 20);
            this.lastLoginDateTimePicker.TabIndex = 16;
            // 
            // searchActivityLabel
            // 
            this.searchActivityLabel.AutoSize = true;
            this.searchActivityLabel.Location = new System.Drawing.Point(458, 42);
            this.searchActivityLabel.Name = "searchActivityLabel";
            this.searchActivityLabel.Size = new System.Drawing.Size(78, 13);
            this.searchActivityLabel.TabIndex = 21;
            this.searchActivityLabel.Text = "Search Activity";
            // 
            // activitySearchBox
            // 
            this.activitySearchBox.Location = new System.Drawing.Point(542, 39);
            this.activitySearchBox.Name = "activitySearchBox";
            this.activitySearchBox.Size = new System.Drawing.Size(153, 20);
            this.activitySearchBox.TabIndex = 20;
            this.activitySearchBox.TextChanged += new System.EventHandler(this.ActivitySearchBox_TextChanged);
            // 
            // activityList
            // 
            this.activityList.AllowUserToAddRows = false;
            this.activityList.AllowUserToDeleteRows = false;
            this.activityList.AllowUserToResizeColumns = false;
            this.activityList.AllowUserToResizeRows = false;
            this.activityList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.activityList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.activityList.Location = new System.Drawing.Point(302, 65);
            this.activityList.MultiSelect = false;
            this.activityList.Name = "activityList";
            this.activityList.RowHeadersVisible = false;
            this.activityList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.activityList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.activityList.Size = new System.Drawing.Size(393, 249);
            this.activityList.TabIndex = 19;
            // 
            // changePasswordButton
            // 
            this.changePasswordButton.Location = new System.Drawing.Point(302, 320);
            this.changePasswordButton.Name = "changePasswordButton";
            this.changePasswordButton.Size = new System.Drawing.Size(136, 23);
            this.changePasswordButton.TabIndex = 22;
            this.changePasswordButton.Text = "Change Password";
            this.changePasswordButton.UseVisualStyleBackColor = true;
            this.changePasswordButton.Click += new System.EventHandler(this.ChangePasswordButton_Click);
            // 
            // changeAccessLevelButtom
            // 
            this.changeAccessLevelButtom.Location = new System.Drawing.Point(560, 320);
            this.changeAccessLevelButtom.Name = "changeAccessLevelButtom";
            this.changeAccessLevelButtom.Size = new System.Drawing.Size(135, 23);
            this.changeAccessLevelButtom.TabIndex = 23;
            this.changeAccessLevelButtom.Text = "Change Access Level";
            this.changeAccessLevelButtom.UseVisualStyleBackColor = true;
            this.changeAccessLevelButtom.Click += new System.EventHandler(this.ChangeAccessLevelButtom_Click);
            // 
            // suspendUserButton
            // 
            this.suspendUserButton.Location = new System.Drawing.Point(444, 320);
            this.suspendUserButton.Name = "suspendUserButton";
            this.suspendUserButton.Size = new System.Drawing.Size(110, 23);
            this.suspendUserButton.TabIndex = 24;
            this.suspendUserButton.Text = "Suspend User";
            this.suspendUserButton.UseVisualStyleBackColor = true;
            this.suspendUserButton.Click += new System.EventHandler(this.suspendUserButton_Click);
            // 
            // UserInformationTemplateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 412);
            this.Controls.Add(this.suspendUserButton);
            this.Controls.Add(this.changeAccessLevelButtom);
            this.Controls.Add(this.changePasswordButton);
            this.Controls.Add(this.searchActivityLabel);
            this.Controls.Add(this.activitySearchBox);
            this.Controls.Add(this.activityList);
            this.Controls.Add(this.lastLoginDateTimePicker);
            this.Controls.Add(this.lastLoginLabel);
            this.Controls.Add(this.registrationDateDateTimePicker);
            this.Controls.Add(this.registrationDateLabel);
            this.Controls.Add(this.statusTextBox);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.creatorTextBox);
            this.Controls.Add(this.creatorLabel);
            this.Controls.Add(this.roleTextBox);
            this.Controls.Add(this.roleLabel);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.userTitleLabel);
            this.MaximizeBox = false;
            this.Name = "UserInformationTemplateForm";
            this.Text = "User Profile";
            this.Load += new System.EventHandler(this.UserInformationTemplateForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.activityList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userTitleLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.Label roleLabel;
        private System.Windows.Forms.TextBox roleTextBox;
        private System.Windows.Forms.Label creatorLabel;
        private System.Windows.Forms.TextBox creatorTextBox;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.TextBox statusTextBox;
        private System.Windows.Forms.Label registrationDateLabel;
        private System.Windows.Forms.DateTimePicker registrationDateDateTimePicker;
        private System.Windows.Forms.Label lastLoginLabel;
        private System.Windows.Forms.DateTimePicker lastLoginDateTimePicker;
        private System.Windows.Forms.Label searchActivityLabel;
        private System.Windows.Forms.TextBox activitySearchBox;
        private System.Windows.Forms.DataGridView activityList;
        private System.Windows.Forms.Button changePasswordButton;
        private System.Windows.Forms.Button changeAccessLevelButtom;
        private System.Windows.Forms.Button suspendUserButton;
    }
}