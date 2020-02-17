using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Custom Libraries
using InventoryManagementDataLayer;
using InventoryManagementEntityLayer;

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
            // Changing the credentials of the provided username
            UpdateData.ChangeUserPasswordData(username, newPassword);

            // Executing correct activity according to given code
            SystemProtocols.ApplyActivityProtocols("SPE1", null, null);
        }

        /// <summary>
        /// Function used to log a user's last log in timestamp
        /// </summary>
        /// <param name="username">Username of target user</param>
        public static void UpdateUserLastLoginInformation(String username)
        {
            // Requesting  an update on a user's last log in timestamp
            UpdateData.UpdateUserLastLoginData(username);

            // No recorded activity is needed given this is a hidden encapsulated auxiliary activity 
        }

        /// <summary>
        /// This function recieves an existing product that has been modified by the user and registers the new changes
        /// </summary>
        /// <param name="product">Product object with the new changes</param>
        /// <returns>A message detailing the success or failure of the update</returns>
        public static String UpdateRegisteredProductInformation(Product product)
        {
            // Requesting  an update of an existing product
            String message = UpdateData.UpdateRegisteredProductData(product, SystemResources.UserInSession.Username);

            if (message == "Product updated successfully!") // Update was succesful
            {
                // Executing correct activity according to given code
                SystemProtocols.ApplyActivityProtocols("PRO5", product.Name, null);
                return "SUCCESS";
            }
            else
                return "ERROR";
        }
    }
}
