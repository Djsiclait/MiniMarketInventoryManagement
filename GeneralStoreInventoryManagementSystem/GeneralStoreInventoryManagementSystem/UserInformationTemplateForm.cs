﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Custom Libraries 
using InventoryManagementBusinessLayer;
using InventoryManagementEntityLayer;

namespace GeneralStoreInventoryManagementSystem
{
    public partial class UserInformationTemplateForm : Form
    {
        UserProfile user;

        public UserInformationTemplateForm(String username)
        {
            InitializeComponent();

            user = InventoryManagementBusinessLayer.ConsultInformation.FetchUserInformationByUsername(username);

            userTitleLabel.Text += " " + username;
        }

        private void UserInformationTemplateForm_Load(object sender, EventArgs e)
        {
            usernameTextBox.Text = user.Username;
            firstNameTextBox.Text = user.FirstName;
            lastNameTextBox.Text = user.LastName;
            roleTextBox.Text = user.Role;
            creatorTextBox.Text = user.Creator;
            statusTextBox.Text = user.Status;
            registrationDateDateTimePicker.Text = user.RegistrationDate.ToString();
            lastLoginDateTimePicker.Text = user.LastLogin.ToString();

        }
    }
}
