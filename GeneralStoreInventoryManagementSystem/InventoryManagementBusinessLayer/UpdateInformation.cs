using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Custom Libraries
using InventoryManagementDataLayer;

namespace InventoryManagementBusinessLayer
{
    public static class UpdateInformation
    {
        /// <summary>
        /// Funtion used to change a user's credentials
        /// </summary>
        /// <param name="username">Username of target user</param>
        /// <param name="newPassword">New password to change credentials</param>
        public static void ChangeUserPasswordInformation(String username, String newPassword)
        {
            UpdateData.ChangeUserPasswordData(username, newPassword); // Changing the credentials of the provided username

            // Executing correct activity according to given code
            SystemProtocols.ApplyActivityProtocols("SPE1", null, null);
        }

        /// <summary>
        /// Function used to change a target user's access level within the system
        /// </summary>
        /// <param name="targetUser">Username of target user</param>
        /// <param name="newAccessLevel">New access level protocol</param>
        public static void ChangeTargetUserAccessLevelData(String targetUser, String newAccessLevel)
        {
            UpdateData.ChangeTargetUserAccessLevelData(targetUser, newAccessLevel);
        }

        /// <summary>
        /// FUnction used to change target user's status to activite, inactive, etc.
        /// </summary>
        /// <param name="targetUser">Username of target user</param>
        /// <param name="newStatus">New user status</param>
        public static void ChangeTargerUserStatusInformation(String targetUser, int newStatus)
        {
            UpdateData.ChangeTargerUserStatusData(targetUser, newStatus);
        }

        /// <summary>
        /// FUnction used to log a user's last log in timestamp
        /// </summary>
        /// <param name="username">Username of target user</param>
        public static void UpdateUserLastLoginInformation(String username)
        {
            UpdateData.UpdateUserLastLoginData(username);
        }
    }
}
