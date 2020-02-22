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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserInformationTemplateForm));
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
            this.lastLoginLabel = new System.Windows.Forms.Label();
            this.searchActivityLabel = new System.Windows.Forms.Label();
            this.activitySearchBox = new System.Windows.Forms.TextBox();
            this.activityList = new System.Windows.Forms.DataGridView();
            this.changePasswordButton = new System.Windows.Forms.Button();
            this.changeAccessLevelButtom = new System.Windows.Forms.Button();
            this.suspendUserButton = new System.Windows.Forms.Button();
            this.createdOnLabel = new System.Windows.Forms.Label();
            this.LastLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.activityList)).BeginInit();
            this.SuspendLayout();
            // 
            // userTitleLabel
            // 
            resources.ApplyResources(this.userTitleLabel, "userTitleLabel");
            this.userTitleLabel.Name = "userTitleLabel";
            // 
            // usernameLabel
            // 
            resources.ApplyResources(this.usernameLabel, "usernameLabel");
            this.usernameLabel.Name = "usernameLabel";
            // 
            // usernameTextBox
            // 
            resources.ApplyResources(this.usernameTextBox, "usernameTextBox");
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.ReadOnly = true;
            // 
            // firstNameLabel
            // 
            resources.ApplyResources(this.firstNameLabel, "firstNameLabel");
            this.firstNameLabel.Name = "firstNameLabel";
            // 
            // firstNameTextBox
            // 
            resources.ApplyResources(this.firstNameTextBox, "firstNameTextBox");
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.ReadOnly = true;
            // 
            // lastNameLabel
            // 
            resources.ApplyResources(this.lastNameLabel, "lastNameLabel");
            this.lastNameLabel.Name = "lastNameLabel";
            // 
            // lastNameTextBox
            // 
            resources.ApplyResources(this.lastNameTextBox, "lastNameTextBox");
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.ReadOnly = true;
            // 
            // roleLabel
            // 
            resources.ApplyResources(this.roleLabel, "roleLabel");
            this.roleLabel.Name = "roleLabel";
            // 
            // roleTextBox
            // 
            resources.ApplyResources(this.roleTextBox, "roleTextBox");
            this.roleTextBox.Name = "roleTextBox";
            this.roleTextBox.ReadOnly = true;
            // 
            // creatorLabel
            // 
            resources.ApplyResources(this.creatorLabel, "creatorLabel");
            this.creatorLabel.Name = "creatorLabel";
            // 
            // creatorTextBox
            // 
            resources.ApplyResources(this.creatorTextBox, "creatorTextBox");
            this.creatorTextBox.Name = "creatorTextBox";
            this.creatorTextBox.ReadOnly = true;
            // 
            // statusLabel
            // 
            resources.ApplyResources(this.statusLabel, "statusLabel");
            this.statusLabel.Name = "statusLabel";
            // 
            // statusTextBox
            // 
            resources.ApplyResources(this.statusTextBox, "statusTextBox");
            this.statusTextBox.Name = "statusTextBox";
            this.statusTextBox.ReadOnly = true;
            // 
            // registrationDateLabel
            // 
            resources.ApplyResources(this.registrationDateLabel, "registrationDateLabel");
            this.registrationDateLabel.Name = "registrationDateLabel";
            // 
            // lastLoginLabel
            // 
            resources.ApplyResources(this.lastLoginLabel, "lastLoginLabel");
            this.lastLoginLabel.Name = "lastLoginLabel";
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
            this.activitySearchBox.TextChanged += new System.EventHandler(this.ActivitySearchBox_TextChanged);
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
            // changePasswordButton
            // 
            resources.ApplyResources(this.changePasswordButton, "changePasswordButton");
            this.changePasswordButton.Name = "changePasswordButton";
            this.changePasswordButton.UseVisualStyleBackColor = true;
            this.changePasswordButton.Click += new System.EventHandler(this.ChangePasswordButton_Click);
            // 
            // changeAccessLevelButtom
            // 
            resources.ApplyResources(this.changeAccessLevelButtom, "changeAccessLevelButtom");
            this.changeAccessLevelButtom.Name = "changeAccessLevelButtom";
            this.changeAccessLevelButtom.UseVisualStyleBackColor = true;
            this.changeAccessLevelButtom.Click += new System.EventHandler(this.ChangeAccessLevelButtom_Click);
            // 
            // suspendUserButton
            // 
            resources.ApplyResources(this.suspendUserButton, "suspendUserButton");
            this.suspendUserButton.Name = "suspendUserButton";
            this.suspendUserButton.UseVisualStyleBackColor = true;
            this.suspendUserButton.Click += new System.EventHandler(this.SuspendUserButton_Click);
            // 
            // createdOnLabel
            // 
            resources.ApplyResources(this.createdOnLabel, "createdOnLabel");
            this.createdOnLabel.Name = "createdOnLabel";
            // 
            // LastLabel
            // 
            resources.ApplyResources(this.LastLabel, "LastLabel");
            this.LastLabel.Name = "LastLabel";
            // 
            // UserInformationTemplateForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LastLabel);
            this.Controls.Add(this.createdOnLabel);
            this.Controls.Add(this.suspendUserButton);
            this.Controls.Add(this.changeAccessLevelButtom);
            this.Controls.Add(this.changePasswordButton);
            this.Controls.Add(this.searchActivityLabel);
            this.Controls.Add(this.activitySearchBox);
            this.Controls.Add(this.activityList);
            this.Controls.Add(this.lastLoginLabel);
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
        private System.Windows.Forms.Label lastLoginLabel;
        private System.Windows.Forms.Label searchActivityLabel;
        private System.Windows.Forms.TextBox activitySearchBox;
        private System.Windows.Forms.DataGridView activityList;
        private System.Windows.Forms.Button changePasswordButton;
        private System.Windows.Forms.Button changeAccessLevelButtom;
        private System.Windows.Forms.Button suspendUserButton;
        private System.Windows.Forms.Label createdOnLabel;
        private System.Windows.Forms.Label LastLabel;
    }
}