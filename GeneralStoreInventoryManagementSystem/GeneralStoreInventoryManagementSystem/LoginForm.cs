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
                //Console.WriteLine(CollectiveResources.UserInSession.Username);

                FormsMenuList.loginForm.Hide();

                // TODO: Initialize the homepage;
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
