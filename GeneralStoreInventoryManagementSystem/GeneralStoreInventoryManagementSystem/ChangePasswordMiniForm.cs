﻿using System;
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
    public partial class ChangePasswordMiniForm : Form
    {
        String username;

        public ChangePasswordMiniForm(String username)
        {
            InitializeComponent();

            this.username = username;
        }

        private void ChangePasswordMiniForm_Load(object sender, EventArgs e)
        {
            passwordErrorLabel.Text = "Invalid Password";
            passwordErrorLabel.Visible = false;
            confirmationPasswordErrorLabel.Visible = false;

        }

        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            passwordTextBox.BackColor = Color.White; // Formating color 

            if (passwordTextBox.Text.Count() < 8) // rejecting password due to length
            {
                passwordErrorLabel.Text = "Invalid Password: Must be at least 8 characters long";
                passwordErrorLabel.Visible = true;
            }
            else if (passwordTextBox.Text == "12345678") // rejecting passsword due to predictability
            {
                passwordErrorLabel.Text = "Invalid Password: Password too weak";
                passwordErrorLabel.Visible = true;
            }
            else if (passwordTextBox.Text == username) // rejecting passwords similar to he username
            {
                passwordErrorLabel.Text = "Invalid Password: Cannot be the same as chosen username";
                passwordErrorLabel.Visible = true;
            }
            else // Password correct and validated
            {
                passwordErrorLabel.Text = "Invalid Password";
                passwordErrorLabel.Visible = false;
            }

            // Verifying if password and confirmation password are the same
            if (passwordTextBox.Text != confirmPasswordTextBox.Text)
                confirmationPasswordErrorLabel.Visible = true; // Confirmation is incorrect
            else
                confirmationPasswordErrorLabel.Visible = false; // passwords are the same
        }

        private void ConfirmPasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            confirmPasswordTextBox.BackColor = Color.White; // Formating color

            // Verifying if password and confirmation password are the same
            if (passwordTextBox.Text != confirmPasswordTextBox.Text)
                confirmationPasswordErrorLabel.Visible = true; // Confirmation is incorrect
            else
                confirmationPasswordErrorLabel.Visible = false; // passwords are the same
        }

        private void ChangePasswordButton_Click(object sender, EventArgs e)
        {
            if (ValidateUserInput())
            {
                InventoryManagementBusinessLayer.UpdateInformation.UpdateUserPasswordInformation(username, passwordTextBox.Text);

                CollectiveResources.RecordActivity(
                    CollectiveResources.UserInSession.Username,
                    CollectiveResources.UserInSession.Role + ", " + CollectiveResources.UserInSession.Username + ", has changed their password", 
                    "PASSWORD CHANGE");

                MessageBox.Show("Password changed successfully!");

                this.Dispose();
            }
        }

        ////////// Validating user input for correct format and standards
        private bool ValidateUserInput()
        {
            bool validate = true; // No error has been detected

            if (passwordTextBox.Text == "") // password has been left empty
            {
                validate = false;
                passwordTextBox.BackColor = Color.Red;
            }

            if (passwordErrorLabel.Visible) // password format error has occured
            {
                validate = false;
                passwordTextBox.BackColor = Color.Red;
            }

            if (confirmPasswordTextBox.Text == "") // confirmation password has been left empty
            {
                validate = false;
                confirmPasswordTextBox.BackColor = Color.Red;
            }
            if (confirmationPasswordErrorLabel.Visible) // confirmation password format error has occured
            {
                validate = false;
                confirmPasswordTextBox.BackColor = Color.Red;
            }

            if (passwordTextBox.Text != confirmPasswordTextBox.Text) // password and confirmation password do not match
            {
                validate = false;
                passwordTextBox.BackColor = Color.Red;
                confirmPasswordTextBox.BackColor = Color.Red;
            }

            return validate; // returning respons to the validation analysis
        }
    }
}