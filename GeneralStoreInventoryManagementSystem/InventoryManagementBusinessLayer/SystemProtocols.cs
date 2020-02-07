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
        /// <param name="meta">Auxiliary information for certain activities</param>
        public static void ApplyActivityProtocols(String code, String meta)
        {
            switch (code)
            {
                case "ACT1": // Registering user access to activity logs

                    SystemResources.RecordActivity(
                        SystemResources.UserInSession.Username, // username of user in session 
                        SystemResources.UserInSession.Role + ", " + SystemResources.UserInSession.Username + ", has accessed the activities logs", // description of activity
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
                        meta, // provided username that failed the lof in
                        "Deactivated account, " + meta + ", attemped to log into the system", // description of activity
                        "LOGIN FAILIER"); // type of activity
                    break;

                case "SEP1": // Registering a password change

                    SystemResources.RecordActivity(
                        SystemResources.UserInSession.Username, // username of user in session
                        SystemResources.UserInSession.Role + ", " + SystemResources.UserInSession.Username + ", has changed their password", // description of activity
                        "PASSWORD CHANGE"); // type of activity
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
                ApplyActivityProtocols("LOG0", username); // registering correct activity for given case
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
