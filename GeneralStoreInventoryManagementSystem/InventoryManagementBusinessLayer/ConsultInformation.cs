﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Custom Libraries
using InventoryManagementDataLayer;
using InventoryManagementEntityLayer;

namespace InventoryManagementBusinessLayer
{
    public static class ConsultInformation
    {
        /// <summary>
        /// This function retrieves the information needed for the activity log list, according to the user's role
        /// It also allows the user to specify key words loosely to filter the information via username, description, and type
        /// </summary>
        /// <param name="keyWord">Key word to enable specific filtered searches</param>
        /// <param name="last24Hours">Indicator to specify if searches should be limmited to the last 24 hours of activity</param>
        /// <returns>A list of activities registered in the system</returns>
        public static List<Activity> FetchActivityListInformation(String keyWord, bool last24Hours)
        {
            // Verifying user's status before providing requested information
            if (SystemResources.UserInSession.Status == "Active")
                return ConsultData.FetchActivityListData(SystemResources.UserInSession.Role, keyWord, last24Hours);
            else
                return new List<Activity>(); // returning an empty list given invalid user status
        }
        
        /// <summary>
        /// This function fetches all information associated to a registered product 
        /// No verification/authentification/rejection is required at this point in developpement (This may be subject to change at a later date)
        /// </summary>
        /// <param name="productId">product's internal system identification number</param>
        /// <returns>A product object with all extracted information for that specific product id</returns>
        public static Product FetchProductInformationByID(String productId)
        {
            return ConsultData.FetchProductDataByID(productId); // Fetching and returning requested information for a product
        }

        /// <summary>
        /// This function retrieves the information needed for the product list, according to the user's role
        /// It also allows the user to specify key words loosely to filter the information via product key, product name, brand name, and supplier
        /// </summary>
        /// <param name="userPermission">User's role which defines his level of access to the data</param>
        /// <param name="keyWord">Key word to enable specific filtered searches</param>
        /// <returns>A list of products registered with the system</returns>
        public static List<Product> FetchProductListInformation(String keyWord)
        {
            // Verifying user's status before providing requested information
            if (SystemResources.UserInSession.Status == "Active")
                return ConsultData.FetchProductListData(SystemResources.UserInSession.Role, keyWord); // Fetching and returning the inventory product list information 
            else
                return new List<Product>(); // returning an empty list given invalid user status
        }


        /// <summary>
        /// This Function checks for the availability of a username 
        /// </summary>
        /// <param name="username">requested username</param>
        /// <returns>true or false depending if the username exists or not</returns>
        public static bool CheckUsernameAvailability(String username)
        {
            return InventoryManagementDataLayer.ConsultData.CheckUsernameAvailability(username);
        }

        public static List<UserProfile> FetchUserListInformation(String username, String userPermission, String keyWord)
        {
            return InventoryManagementDataLayer.ConsultData.FetchUserListData(username, userPermission, keyWord);
        }

        public static UserProfile FetchUserInformationByUsername(String username)
        {
            return InventoryManagementDataLayer.ConsultData.FetchUserDataByUsername(username);
        }

        public static String ValidateUserCredentialsInformation(String username, String password)
        {
            return InventoryManagementDataLayer.ConsultData.ValidateUserCredentialsData(username, password);
        }

        public static List<Activity> FetchActivityListInformationByUsername(String userPermission, String username, String keyWord)
        {
            return InventoryManagementDataLayer.ConsultData.FetchActivityListDataByUsername(userPermission, username, keyWord);
        }

        public static List<String> FetchBrandListInformation(String keyWord)
        {
            return InventoryManagementDataLayer.ConsultData.FetchBrandListData(keyWord);
        }

        public static List<String> FetchSupplierListInformation(String keyWord)
        {
            return InventoryManagementDataLayer.ConsultData.FetchSupplierListData(keyWord);
        }

        public static List<String> FetchCategoryComboBoxInformation()
        {
            return InventoryManagementDataLayer.ConsultData.FetchCategoryComboBoxData();
        }

        public static List<String> FetchTypeComboBoxInformation()
        {
            return InventoryManagementDataLayer.ConsultData.FetchTypeComboBoxData();
        }
    }
}
