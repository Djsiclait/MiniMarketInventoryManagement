﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementEntityLayer
{
    public class User
    {
        private String username; // username of user profile
        private String password; // password associated to the profile
        private String firstName; // first name of the owner of the user profile
        private String lastName; // last name of the owner of the user profile
        private String role; // level of access granted to this user profile
        private String creator; // user (mother) that created this profile
        private DateTime registrationDate; // date the user profile was created
        private int status; // Status of the profile; Active, Inactive, etc.
        private DateTime lastLogin; // last date and time the user has accessed the system

        // Getters and Setters
        public string Username
        {
            get
            {
                return username;
            }

            set
            {
                username = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }

        public string FirstName
        {
            get
            {
                return firstName;
            }

            set
            {
                firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }

            set
            {
                lastName = value;
            }
        }

        public string Role
        {
            get
            {
                return role;
            }

            set
            {
                role = value;
            }
        }

        public string Creator
        {
            get
            {
                return creator;
            }

            set
            {
                creator = value;
            }
        }

        public DateTime RegistrationDate
        {
            get
            {
                return registrationDate;
            }

            set
            {
                registrationDate = value;
            }
        }

        public int Status
        {
            get
            {
                return status;
            }

            set
            {
                status = value;
            }
        }

        public DateTime LastLogin
        {
            get
            {
                return lastLogin;
            }

            set
            {
                lastLogin = value;
            }
        }
    }
}
