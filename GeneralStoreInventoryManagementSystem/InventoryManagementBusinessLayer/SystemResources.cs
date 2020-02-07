using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Custom Library
using InventoryManagementBusinessLayer;
using InventoryManagementEntityLayer;

namespace InventoryManagementBusinessLayer
{
    public static class SystemResources
    {
        private static UserProfile userInSession; // object used to track open active session

        /// <summary>
        /// Function used to instantiate the session variable
        /// Must be executed once before every session  
        /// </summary>
        /// <param name="username">Username requesting to log in</param>
        public static void BeginUserSession(String username)
        {
            userInSession = ConsultInformation.FetchUserInformationByUsername(username); // opening an active session

            // Updating the user's last loggin information before finalizing process
            UpdateInformation.UpdateUserLastLoginInformation(userInSession.Username);

            // Recording log in activity for user logging in
            RecordActivity(
                userInSession.Username, // username of user in session 
                userInSession.Role + ", " + userInSession.Username + ", has successfully logged in", // description of activity
                "LOG IN"); // type of activity
        }
        
        /// <summary>
        /// Function used to end the session variable
        /// Must be executed once before logging out of every session  
        /// </summary>
        public static void EndUserSession()
        {
            // Recording log out activity for user logging out
            RecordActivity(
                userInSession.Username, // username of user in session 
                userInSession.Role + ", " + userInSession.Username + ", has successfully logged out", // description of activity
                "LOG OUT"); // type of activity

            // Updating the user's last loggin information before finalizing process
            UpdateInformation.UpdateUserLastLoginInformation(userInSession.Username);

            userInSession = null; // closing the current session
        }

        /// <summary>
        /// Function used to record system and user activities 
        /// </summary>
        /// <param name="username">Username of user responsible for the activity</param>
        /// <param name="description">Description of the activity</param>
        /// <param name="type">Type of activity</param>
        public static void RecordActivity(String username, String description, String type)
        {
            // Registering new activity
            CreateInformation.RegisterNewUserActivityInformation(new Activity(username, description, type));
        }

        // Getters and setters
        public static UserProfile UserInSession
        {
            get
            {
                return userInSession;
            }
        }
    }
}
