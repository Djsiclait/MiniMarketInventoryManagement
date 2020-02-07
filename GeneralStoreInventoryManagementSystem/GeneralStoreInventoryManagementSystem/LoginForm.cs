using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Custom Library
using InventoryManagementBusinessLayer;

namespace GeneralStoreInventoryManagementSystem
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

////////// Load Form Logic
        private void LoginForm_Load(object sender, EventArgs e)
        {
            // TEMPORARY
            // TODO: ancor the application to the splash page
            FormsMenuList.loginForm = this;
        }
////////// END Load Form Logic

////////// Login Protocols
        private void LogInButton_Click(object sender, EventArgs e)
        {
            // Executing credential validation protocols before triggering a session or being denied one
            String message = SystemProtocols.ApplyCredentialsValidationProtocol(usernameTextBox.Text, passwordTextBox.Text);

            if (message == "INVALID USER") // provided username was not registered in the system
            {
                ClearTextBoxBuffer();
                usernameTextBox.BackColor = Color.Red; // highlighting incorrect username
            }
            else if (message == "INACTIVE USER") // provided username belongs to an inactive/suspended account
            {
                MessageBox.Show("This user has been deacivated, please try with a different account.");
                ClearTextBoxBuffer();
            }
            else if (message == "INCORRECT") // provided credentials were incorrect for that username
            {
                passwordTextBox.Text = "";
                passwordTextBox.BackColor = Color.Red; // highlighting incorrect password
            }
            else // credentials were successfully validated
            {
                // Executing correct login protocols for new user session
                SystemProtocols.ApplyLogInProtocols(usernameTextBox.Text);
                ClearTextBoxBuffer();

                FormsMenuList.loginForm.Hide(); // TODO: replace this with close once program is ancored to splash page

                // Summon Product Browser Form
                FormsMenuList.inventorySearchForm = new InventorySearchForm();
                FormsMenuList.inventorySearchForm.Show();
            }
        }
////////// END Login Protocols

////////// Text Changed Logic
        private void UsernameTextBox_TextChanged(object sender, EventArgs e)
        {
            usernameTextBox.BackColor = Color.White;
        }

        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            passwordTextBox.BackColor = Color.White;
        }
////////// END Text Changed Logic

//////////Auxiliary Functions
        /// <summary>
        /// Funtion to clear user input buffers
        /// </summary>
        private void ClearTextBoxBuffer()
        {
            usernameTextBox.Text = "";
            passwordTextBox.Text = "";
        }
    }
}
