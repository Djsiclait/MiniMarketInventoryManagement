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
    public static class ConsultInformation
    {
        /// <summary>
        /// This Function binds to the data layer of the system to retrieve the information needed for the product list, according to the user's role
        /// No verification/authentification/rejection is required at this point in developpement (This may be subject to change at a later date)
        /// It also allows the user to specify key words loosely to filter the information via product key, product name, brand name, and supplier
        /// </summary>
        /// <param name="userPermission">User's role which defines his level of access to the data</param>
        /// <param name="keyWord">Key word to enable specific filtered searhs</param>
        /// <returns>a list of products registered with the system</returns>
        public static List<Product> FetchProductListInformation(String userPermission, String keyWord)
        {
            // TODO: separate results based on user role protocols

            return InventoryManagementDataLayer.ConsultData.FetchProductListData(userPermission, keyWord); // Fetching and returning the information from data layer og this system 
        }

        /// <summary>
        /// This function fetches all information associated to a registered product 
        /// No verification/authentification/rejection is required at this point in developpement (This may be subject to change at a later date)
        /// </summary>
        /// <param name="productId">product's internal system identification number</param>
        /// <returns>a product object with all extracted information for that specific product id</returns>
        public static Product FetchProductInformationByID(String productId)
        {
            return InventoryManagementDataLayer.ConsultData.FetchProductDataByID(productId); // Fetching and returning requested information for a product
        }

        public static bool CheckUsernameAvailability(String username)
        {
            return InventoryManagementDataLayer.ConsultData.CheckUsernameAvailability(username);
        }
    }
}
