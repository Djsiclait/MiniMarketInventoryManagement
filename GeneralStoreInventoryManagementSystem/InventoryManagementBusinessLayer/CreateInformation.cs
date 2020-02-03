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
        /// <summary>
        /// This function recieves a user profile object to create its respective information for prosperity
        /// </summary>
        /// <param name="newUser">The user object that houses the necessary information to create a new profile</param>
        /// <returns>A message that confirms or denies the user profile creation process</returns>
        public static String CreateNewUserProfileInformation(UserProfile newUser)
        {
            return InventoryManagementDataLayer.CreateData.CreateNewUserProfileData(newUser);
        }

        public static void RegisterNewUserActivityInformation(Activity activity)
        {
            InventoryManagementDataLayer.CreateData.RegisterNewUserActivityData(activity);
        }

        public static String RegisterNewProductBrandInformation(String name)
        {
            return InventoryManagementDataLayer.CreateData.RegisterNewProductBrandData(name);
        }

        public static String RegisterNewProductSupplierInformation(String name, String phoneNumber, String email)
        {
            return InventoryManagementDataLayer.CreateData.RegisterNewProductSupplierData(name, phoneNumber, email);
        }
    }
}
