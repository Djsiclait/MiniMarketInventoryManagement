using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Custom Library
using InventoryManagementDataLayer;

namespace InventoryManagementBusinessLayer
{
    public static class UserInformationManager
    {
        /// <summary>
        /// Function used to change a target user's access level within the system
        /// </summary>
        /// <param name="targetUser">Username of target user</param>
        /// <param name="newAccessLevel">New access level protocol</param>
        public static void ChangeTargetUserAccessLevelInformation(String targetUser, String newAccessLevel)
        {
            // Requesting a change in a target user's access level
            UserDataManager.ChangeTargetUserAccessLevelData(targetUser, newAccessLevel);

            // Executing correct activity according to given code
            SystemProtocols.ApplyActivityProtocols("SPE2", targetUser, newAccessLevel);
        }

        /// <summary>
        /// Function used to change target user's status to activite, inactive, etc.
        /// </summary>
        /// <param name="targetUser">Username of target user</param>
        /// <param name="newStatus">New user status</param>
        public static void ChangeTargerUserStatusInformation(String targetUser, int newStatusCode, String newStatusName)
        {
            // Requesting a change in a target user's account status
            UserDataManager.ChangeTargerUserStatusData(targetUser, newStatusCode);

            // Executing correct activity according to given code
            SystemProtocols.ApplyActivityProtocols("SPE3", targetUser, newStatusName);
        }
    }
}
