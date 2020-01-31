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
        public static void UpdateUserLastLoginInformation(String username)
        {
            InventoryManagementDataLayer.UpdateData.UpdateUserLastLoginData(username);
        }

        public static void ChangeUserPasswordInformation(String username, String newPassword)
        {
            InventoryManagementDataLayer.UpdateData.ChangeUserPasswordData(username, newPassword);
        }

        public static void ChangeTargetUserAccessLevelData(String targetUser, String newAccessLevel)
        {
            InventoryManagementDataLayer.UpdateData.ChangeTargetUserAccessLevelData(targetUser, newAccessLevel);
        }

        public static void ChangeTargerUserStatusInformation(String targetUser, int newStatus)
        {
            InventoryManagementDataLayer.UpdateData.ChangeTargerUserStatusData(targetUser, newStatus);
        }
    }
}
