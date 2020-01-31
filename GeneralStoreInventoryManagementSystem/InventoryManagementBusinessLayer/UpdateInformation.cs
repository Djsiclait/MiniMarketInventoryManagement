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

        public static void UpdateUserPasswordInformation(String username, String newPassword)
        {
            InventoryManagementDataLayer.UpdateData.UpdateUserPasswordData(username, newPassword);
        }
    }
}
