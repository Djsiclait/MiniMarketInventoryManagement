using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeneralStoreInventoryManagementSystem
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

            // TEMPORARY
            // TODO: ancor the application to the splash page
            FormsMenuList.loginForm = this;
        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            String message = InventoryManagementBusinessLayer.ConsultInformation.ValidateUserCredentialsInformation(usernameTextBox.Text, passwordTextBox.Text);

            if (message == "Username does not exists")
            {
                ClearTextBoxBuffer();
                usernameTextBox.BackColor = Color.Red;
            }
            else if (message == "User profile is currently inactive")
            {
                // TODO: Add a prompt
                ClearTextBoxBuffer();
            }
            else if (message == "Password is incorrect")
            {
                passwordTextBox.BackColor = Color.Red;
                passwordTextBox.Text = "";
            }
            else
            {
                CollectiveResources.BeginUserSession(usernameTextBox.Text);
                ClearTextBoxBuffer();

                FormsMenuList.loginForm.Hide();

                // Summon Product Browser Form
                FormsMenuList.inventorySearchForm = new InventorySearchForm();
                FormsMenuList.inventorySearchForm.Show();
            }
        }

        private void ClearTextBoxBuffer()
        {
            usernameTextBox.Text = "";
            passwordTextBox.Text = "";
        }

        private void UsernameTextBox_TextChanged(object sender, EventArgs e)
        {
            usernameTextBox.BackColor = Color.White;
        }

        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            passwordTextBox.BackColor = Color.White;
        }
    }
}
