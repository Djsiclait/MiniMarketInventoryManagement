using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Custom Library
using InventoryManagementDataLayer;
using InventoryManagementEntityLayer;

namespace InventoryManagementBusinessLayer
{
    public static class CreateInformation
    {
        public static String CreateNewUserProfileInformation(UserProfile newUser)
        {
            return InventoryManagementDataLayer.CreateData.CreateNewUserProfileData(newUser);
        }
    }
}
