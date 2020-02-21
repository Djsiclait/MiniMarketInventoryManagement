using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Custom Library
using InventoryManagementDataLayer.UserData;
using InventoryManagementEntityLayer.UserProfile;

namespace InventoryManagementBusinessLayer
{
    public static class UserInformationManager
    {
        #region Consults
        /// <summary>
        /// This function access the system to confirm or deny the validation of of a user's credentials 
        /// </summary>
        /// <param name="username">Username requesting validation</param>
        /// <param name="password">Passwiord of user</param>
        /// <returns>A message that indicates successful or failed validation results</returns>
        public static String ConsultUserCredentialsValidationInformation(String username, String password)
        {
            return UserDataManager.ConsultUserCredentialsValidationData(username, password); // No need to take into account user status given no current user has logged in at this point
        }

        /// <summary>
        /// This function fetches the information of a target user
        /// </summary>
        /// <param name="username">Target username</param>
        /// <returns></returns>
        public static UserProfile ConsultUserInformationByUsername(String username)
        {
            return UserDataManager.ConsultUserDataByUsername(username); // No need to take into account user status given no current user has logged in at this point
        }
        
        /// <summary>
        /// This function fetches the information of all registered users in the system
        /// </summary>
        /// <param name="keyWord">Key word to enable specific filtered searches</param>
        /// <returns>A list of users registered with the system</returns>
        public static List<UserProfile> ConsultUserListInformation(String keyWord)
        {
            // Verifying user's status before providing requested information
            if (SystemResources.UserInSession.Status == "Active")
                return UserDataManager.ConsultUserListData(SystemResources.UserInSession.Username, SystemResources.UserInSession.Role, keyWord);
            else
                return new List<UserProfile>(); // returning an empty list given invalid user status
        }

        /// <summary>
        /// This Function checks for the availability of a username 
        /// </summary>
        /// <param name="username">requested username</param>
        /// <returns>true or false depending if the username exists or not</returns>
        public static bool ConsultUsernameAvailability(String username)
        {
            return UserDataManager.ConsultUsernameAvailability(username);
        }
        #endregion

        #region Creates
        /// <summary>
        /// This function recieves a user profile object to create its respective information for prosperity
        /// </summary>
        /// <param name="newUser">The user object that houses the necessary information to create a new profile</param>
        /// <returns>A message that confirms or denies the user profile creation process</returns>
        public static String CreateNewUserProfileInformation(UserProfile newUser)
        {
            // Requesting creation of new user account
            String message = UserDataManager.CreateNewUserProfileData(newUser);

            if (message == "User created")
            {
                // Executing correct activity according to given code
                SystemProtocols.ApplyActivityProtocols("USE3", newUser.Username, null);
                return "SUCCESS";
            }
            else
                return "";
        }
        #endregion

        #region Updates
        /// <summary>
        /// Function used to change a target user's access level within the system
        /// </summary>
        /// <param name="targetUser">Username of target user</param>
        /// <param name="newAccessLevel">New access level protocol</param>
        public static void UpdateTargetUserAccessLevelInformation(String targetUser, String newAccessLevel)
        {
            // Requesting a change in a target user's access level
            UserDataManager.UpdateTargetUserAccessLevelData(targetUser, newAccessLevel);

            // Executing correct activity according to given code
            SystemProtocols.ApplyActivityProtocols("SPE2", targetUser, newAccessLevel);
        }

        /// <summary>
        /// Function used to change target user's status to activite, inactive, etc.
        /// </summary>
        /// <param name="targetUser">Username of target user</param>
        /// <param name="newStatus">New user status</param>
        public static void UpdateTargerUserStatusInformation(String targetUser, int newStatusCode, String newStatusName)
        {
            // Requesting a change in a target user's account status
            UserDataManager.UpdateTargerUserStatusData(targetUser, newStatusCode);

            // Executing correct activity according to given code
            SystemProtocols.ApplyActivityProtocols("SPE3", targetUser, newStatusName);
        }

        /// <summary>
        /// Function used to log a user's last log in timestamp
        /// </summary>
        /// <param name="username">Username of target user</param>
        public static void UpdateUserLastLoginInformation(String username)
        {
            // Requesting  an update on a user's last log in timestamp
            UserDataManager.UpdateUserLastLoginData(username);

            // No recorded activity is needed given this is a hidden encapsulated auxiliary activity 
        }

        /// <summary>
        /// Funtion used to change a user's credentials
        /// </summary>
        /// <param name="username">Username of target user</param>
        /// <param name="newPassword">New password to change credentials</param>
        public static void UpdateUserPasswordInformation(String username, String newPassword)
        {
            // Changing the credentials of the provided username
            UserDataManager.UpdateUserPasswordData(username, newPassword);

            // Executing correct activity according to given code
            SystemProtocols.ApplyActivityProtocols("SPE1", null, null);
        }
        #endregion
    }
}
