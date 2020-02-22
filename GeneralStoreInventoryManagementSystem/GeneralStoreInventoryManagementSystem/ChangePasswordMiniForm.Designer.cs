namespace GeneralStoreInventoryManagementSystem
{
    partial class ChangePasswordMiniForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePasswordMiniForm));
            this.passwordErrorLabel = new System.Windows.Forms.Label();
            this.confirmationPasswordErrorLabel = new System.Windows.Forms.Label();
            this.confirmPasswordTextBox = new System.Windows.Forms.TextBox();
            this.confirmPasswordLabel = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.changePasswordButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // passwordErrorLabel
            // 
            resources.ApplyResources(this.passwordErrorLabel, "passwordErrorLabel");
            this.passwordErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.passwordErrorLabel.Name = "passwordErrorLabel";
            // 
            // confirmationPasswordErrorLabel
            // 
            resources.ApplyResources(this.confirmationPasswordErrorLabel, "confirmationPasswordErrorLabel");
            this.confirmationPasswordErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.confirmationPasswordErrorLabel.Name = "confirmationPasswordErrorLabel";
            // 
            // confirmPasswordTextBox
            // 
            resources.ApplyResources(this.confirmPasswordTextBox, "confirmPasswordTextBox");
            this.confirmPasswordTextBox.Name = "confirmPasswordTextBox";
            this.confirmPasswordTextBox.TextChanged += new System.EventHandler(this.ConfirmPasswordTextBox_TextChanged);
            this.confirmPasswordTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ConfirmPasswordTextBox_KeyDown);
            // 
            // confirmPasswordLabel
            // 
            resources.ApplyResources(this.confirmPasswordLabel, "confirmPasswordLabel");
            this.confirmPasswordLabel.Name = "confirmPasswordLabel";
            // 
            // passwordTextBox
            // 
            resources.ApplyResources(this.passwordTextBox, "passwordTextBox");
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.TextChanged += new System.EventHandler(this.PasswordTextBox_TextChanged);
            this.passwordTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PasswordTextBox_KeyDown);
            // 
            // passwordLabel
            // 
            resources.ApplyResources(this.passwordLabel, "passwordLabel");
            this.passwordLabel.Name = "passwordLabel";
            // 
            // changePasswordButton
            // 
            resources.ApplyResources(this.changePasswordButton, "changePasswordButton");
            this.changePasswordButton.Name = "changePasswordButton";
            this.changePasswordButton.UseVisualStyleBackColor = true;
            this.changePasswordButton.Click += new System.EventHandler(this.ChangePasswordButton_Click);
            // 
            // ChangePasswordMiniForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.changePasswordButton);
            this.Controls.Add(this.passwordErrorLabel);
            this.Controls.Add(this.confirmationPasswordErrorLabel);
            this.Controls.Add(this.confirmPasswordTextBox);
            this.Controls.Add(this.confirmPasswordLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.passwordLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChangePasswordMiniForm";
            this.Load += new System.EventHandler(this.ChangePasswordMiniForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label passwordErrorLabel;
        private System.Windows.Forms.Label confirmationPasswordErrorLabel;
        private System.Windows.Forms.TextBox confirmPasswordTextBox;
        private System.Windows.Forms.Label confirmPasswordLabel;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Button changePasswordButton;
    }
}