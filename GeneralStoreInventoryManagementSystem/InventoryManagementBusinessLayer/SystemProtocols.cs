using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementBusinessLayer
{
    public static class SystemProtocols
    {
        /// <summary>
        /// Function to register systema and user activity durring an active session
        /// </summary>
        /// <param name="code">Code to execute and register correct activity</param>
        /// <param name="meta1">Auxiliary information for certain activities</param>
        public static void ApplyActivityProtocols(String code, String meta1, String meta2)
        {
            switch (code)
            {
                case "ACT1": // Registering user access to activity logs

                    SystemResources.RecordActivity(
                        SystemResources.UserInSession.Username, // username of user in session 
                        SystemResources.UserInSession.Role + ", " + SystemResources.UserInSession.Username + ", has accessed the activities logs", // description of activity
                        "ADMIN ACCESS"); // type of activity
                    break;

                case "CAR1": // Registering user access to cart

                    SystemResources.RecordActivity(
                        SystemResources.UserInSession.Username, // username of user in session
                        SystemResources.UserInSession.Role + ", " + SystemResources.UserInSession.Username + ", has accessed the cart view", // description of activity
                        "BASIC ACCESS"); // type of activity
                    break;

                case "ERR1": // Registering user access to error logs

                    SystemResources.RecordActivity(
                        SystemResources.UserInSession.Username, // username of user in session 
                        SystemResources.UserInSession.Role + ", " + SystemResources.UserInSession.Username + ", has accessed the errors logs", // description of activity
                        "ADMIN ACCESS"); // type of activity
                    break;

                case "ERR2": // Registering user account creation error

                    SystemResources.RecordActivity(
                        SystemResources.UserInSession.Username, // username of user in session 
                        SystemResources.UserInSession.Role + ", " + SystemResources.UserInSession.Username + ", has accessed the errors logs", // description of activity
                        "ADMIN ACCESS"); // type of activity
                    break;

                case "GRA1": // Registering user access to graphs analytics

                    SystemResources.RecordActivity(
                        SystemResources.UserInSession.Username, // username of user in session 
                        SystemResources.UserInSession.Role + ", " + SystemResources.UserInSession.Username + ", has accessed the graphs analytics", // description of activity
                        "ADMIN ACCESS"); // type of activity
                    break;

                case "INV1": // Registering user access to the inventory view

                    SystemResources.RecordActivity(
                        SystemResources.UserInSession.Username, // username of user in session 
                        SystemResources.UserInSession.Role + ", " + SystemResources.UserInSession.Username + ", has accessed the inventory browser", // description of activity
                        "BASIC ACCESS"); // type of activity
                    break;

                case "LOG0": // Registering a failed log in 

                    SystemResources.RecordActivity(
                        meta1, // provided username that failed the log in
                        "Deactivated account, " + meta1 + ", attemped to log into the system", // description of activity
                        "LOGIN FAILIER"); // type of activity
                    break;

                case "PRO1": // Registering user access to product restock form

                    SystemResources.RecordActivity(
                        SystemResources.UserInSession.Username, // username of user in session 
                        SystemResources.UserInSession.Role + ", " + SystemResources.UserInSession.Username + ", has accessed the form to restock products", // description of activity
                        "ADMIN ACCESS"); // type of activity
                    break;

                case "PRO2": // Registering user access to product registration form

                    SystemResources.RecordActivity(
                        SystemResources.UserInSession.Username, // username of user in session 
                        SystemResources.UserInSession.Role + ", " + SystemResources.UserInSession.Username + ", has accessed the for to register new products", // description of activity
                        "ADMIN ACCESS"); // type of activity
                    break;

                case "PRO3": // Registering the creation of a new product brand

                    SystemResources.RecordActivity(
                        SystemResources.UserInSession.Username, // username of user in session 
                        SystemResources.UserInSession.Role + ", " + SystemResources.UserInSession.Username + ", has registered a new brand: " + meta1, // description of activity
                        "BRAND CREATION"); // type of activity
                    break;

                case "REP1": // Registering user access to reports analytics

                    SystemResources.RecordActivity(
                        SystemResources.UserInSession.Username, // username of user in session 
                        SystemResources.UserInSession.Role + ", " + SystemResources.UserInSession.Username + ", has accessed the reports analytics", // description of activity
                        "ADMIN ACCESS"); // type of activity
                    break;

                case "SAL1": // Registering user access to the sales registration form as basic user

                    SystemResources.RecordActivity(
                        SystemResources.UserInSession.Username, // username of user in session 
                        SystemResources.UserInSession.Role + ", " + SystemResources.UserInSession.Username + ", has accessed the form to register new sales", // description of activity
                        "BASIC ACCESS"); // type of activity
                    break;

                case "SAL2": // Registering user access to the sales registry form as basic user

                    SystemResources.RecordActivity(
                        SystemResources.UserInSession.Username, // username of user in session 
                        SystemResources.UserInSession.Role + ", " + SystemResources.UserInSession.Username + ", has accessed their sales records", // description of activity
                        "BASIC ACCESS"); // type of activity
                    break;

                case "SAL3": // Registering user access to the sales registry form as admin user

                    SystemResources.RecordActivity(
                        SystemResources.UserInSession.Username, // username of user in session 
                        SystemResources.UserInSession.Role + ", " + SystemResources.UserInSession.Username + ", has accessed all sales records", // description of activity
                        "ADMIN ACCESS"); // type of activity
                    break;

                case "SAL4": // Registering user access to the sales registration form as admin user

                    SystemResources.RecordActivity(
                        SystemResources.UserInSession.Username, // username of user in session 
                        SystemResources.UserInSession.Role + ", " + SystemResources.UserInSession.Username + ", has accessed the form to register new sales", // description of activity
                        "ADMIN ACCESS"); // type of activity
                    break;

                case "SPE1": // Registering a password change

                    SystemResources.RecordActivity(
                        SystemResources.UserInSession.Username, // username of user in session
                        SystemResources.UserInSession.Role + ", " + SystemResources.UserInSession.Username + ", has changed their password", // description of activity
                        "PASSWORD CHANGE"); // type of activity
                    break;

                case "SPE2": // Registering a user access level change

                    SystemResources.RecordActivity(
                        SystemResources.UserInSession.Username,
                        SystemResources.UserInSession.Role + ", " + SystemResources.UserInSession.Username + ", changed " + meta1 + "'s user access level to: " + meta2, // description of activity
                        meta2 == "Admin" ? "ADMIN PROMOTION" : "USER DEMOTION"); // type of activity
                    break;

                case "SPE3": // Registering a user account status change

                    SystemResources.RecordActivity(
                        SystemResources.UserInSession.Username, // username of user in session 
                        SystemResources.UserInSession.Role + ", " + SystemResources.UserInSession.Username + ", " + (meta2 == "Active" ? "reinstated " : "suspended") + " user account, " + meta1, // description of activity
                        meta2 == "Active" ? "ACTIVATE " : "SUSPEND"); // type of activity
                    break;

                case "SPE4": // Registering a new supplier with incomplete information

                    SystemResources.RecordActivity(
                        SystemResources.UserInSession.Username, // username of user in session 
                        SystemResources.UserInSession.Role + ", " + SystemResources.UserInSession.Username + ", has incompletly registered a new supplier: " + meta1, // description of activity
                        "INCOMPLETE CREATION"); // type of activity
                    break;

                case "SUP1": // Registering a new supplier with complete information

                    SystemResources.RecordActivity(
                        SystemResources.UserInSession.Username, // username of user in session 
                        SystemResources.UserInSession.Role + ", " + SystemResources.UserInSession.Username + ", has registered a new supplier: " + meta1, // description of activity
                        "SUPPLIER CREATION"); // type of activity
                    break;

                case "USE1": // Registering user access to the users registry form

                    SystemResources.RecordActivity(
                        SystemResources.UserInSession.Username, // username of user in session 
                        SystemResources.UserInSession.Role + ", " + SystemResources.UserInSession.Username + ", has accessed the user registry", // description of activity
                        "ADMIN ACCESS"); // type of activity
                    break;

                case "USE2": // Registering user access to the user registration form

                    SystemResources.RecordActivity(
                        SystemResources.UserInSession.Username, // username of user in session 
                        SystemResources.UserInSession.Role + ", " + SystemResources.UserInSession.Username + ", has accessed the form to register new users", // description of activity
                        "ADMIN ACCESS"); // type of activity
                    break;

                case "USE3": // Registering the creation of a new user account

                    SystemResources.RecordActivity(
                        SystemResources.UserInSession.Username, // username of user in session 
                        SystemResources.UserInSession.Role + ", " + SystemResources.UserInSession.Username + ", has created a new user account for, " + meta1, // description of activity
                        "USER CREATION"); // type of activity
                    break;

                default:
                    break;
            }
        }

        /// <summary>
        /// Function dedicated to validate a user's credentials before granting or denying access to the system
        /// </summary>
        /// <param name="username">Username requesting validation</param>
        /// <param name="password">Password associated to provided username</param>
        /// <returns>A message that indicates the proper protocol to execute depending on the validation results</returns>
        public static String ApplyCredentialsValidationProtocol(String username, String password)
        {
            // Using native class to initiate credentials validation with provided information
            String message = ConsultInformation.ValidateUserCredentialsInformation(username, password);

            if (message == "Username does not exists")
                return "INVALID USER";
            else if (message == "User profile is currently inactive")
            {
                ApplyActivityProtocols("LOG0", username, null); // registering correct activity for given case
                return "INACTIVE USER";
            }
            else if (message == "Password is incorrect")
                return "INCORRECT";
            else
                return ""; // Validation has been successful
        }

        /// <summary>
        /// Fucntion to initiate a new user session
        /// </summary>
        /// <param name="username">Username requesting a new session</param>
        public static void ApplyLogInProtocols(string username)
        {
            SystemResources.BeginUserSession(username); // opening a new user session
        }

        /// <summary>
        /// Funciton to terminate an active user session 
        /// </summary>
        public static void ApplyLogOutProtocols()
        {
            SystemResources.EndUserSession(); // closing a current active user session
        }

        /// <summary>
        /// Function to restrict or activate certain features depending on the user's access level 
        /// </summary>
        /// <returns>True or False</returns>
        public static bool ApplySessionsProtocols()
        {
            // Limiting option according to current user's access level
            if (SystemResources.UserInSession.Role == "User")
                return true;
            else
                return false;
        }
    }
}
