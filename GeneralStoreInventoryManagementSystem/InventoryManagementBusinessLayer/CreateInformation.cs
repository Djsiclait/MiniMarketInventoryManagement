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
            // Requesting creation of new user account
            String message = CreateData.CreateNewUserProfileData(newUser);

            if (message == "User created")
            {
                // Executing correct activity according to given code
                SystemProtocols.ApplyActivityProtocols("USE3", newUser.Username, null);
                return "SUCCESS";
            }
            else
                return "";
        }

        /// <summary>
        /// This function registeres any system or user activity
        /// </summary>
        /// <param name="activity">Activity entity with necessary information</param>
        public static void RegisterNewUserActivityInformation(Activity activity)
        {
            CreateData.RegisterNewUserActivityData(activity);
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
