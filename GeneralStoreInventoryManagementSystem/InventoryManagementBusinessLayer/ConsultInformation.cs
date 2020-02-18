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
        /// This fucntion fetches the activities of a specific user
        /// </summary>
        /// <param name="username">Target username</param>
        /// <param name="keyWord">Key word to enable specific filtered searches</param>
        /// <returns>A list of activities registered in the system by the target user</returns>
        public static List<Activity> FetchActivityListInformationByUsername(String username, String keyWord)
        {
            // Verifying user's status before providing requested information
            if (SystemResources.UserInSession.Status == "Active")
                return ConsultData.FetchActivityListDataByUsername(SystemResources.UserInSession.Role, username, keyWord);
            else
                return new List<Activity>(); // returning an empty list given invalid user status
        }

        /// <summary>
        /// This fucntion fetches the list of registered brands
        /// </summary>
        /// <param name="keyWord">Key word to enable specific filtered searches</param>
        /// <returns>A list  of all registered brands</returns>
        public static List<String> FetchBrandListInformation(String keyWord)
        {
            // Verifying user's status before providing requested information
            if (SystemResources.UserInSession.Status == "Active")
                return ConsultData.FetchBrandListData(keyWord);
            else
                return new List<string>(); // returning an empty list given invalid user status
        }

        /// <summary>
        /// This function fetches the list of categories
        /// </summary>
        /// <returns>A list of all categories</returns>
        public static List<String> FetchCategoryComboBoxInformation()
        {
            // Verifying user's status before providing requested information
            if (SystemResources.UserInSession.Status == "Active")
                return ConsultData.FetchCategoryComboBoxData();
            else
                return new List<string>(); // returning an empty list given invalid user status
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
        /// This function retreives the information needed for the product list, according to the user's role
        /// It also allows the user to specify key words loosely to filter the information via product key, product name, brand name, and supplier
        /// </summary>
        /// <param name="keyWord">Key word to enable specific filtered searches</param>
        /// <returns>A list of products registered with the system</returns>
        public static List<Product> FetchProductListInformation(String keyWord)//, bool forSale)
        {
            // Verifying user's status before providing requested information
            if (SystemResources.UserInSession.Status == "Active")
                //if (forSale)
                    // TODO: Implement inventory management accounting system 
                    //return ConsultData.FetchProductListData("User", keyWord, "FIFO");
                //else
                    // TODO: Implement inventory management accounting system 
                    return ConsultData.FetchProductListData(SystemResources.UserInSession.Role, keyWord, "FIFO"); // Fetching and returning the inventory product list information 
            else
                return new List<Product>(); // returning an empty list given invalid user status
        }

        /// <summary>
        /// This function returns a record of all transactions registered in the system
        /// </summary>
        /// <param name="keyWord">Key word to filter through the sales record</param>
        /// <returns>A list of the sales record according to the filtered key word</returns>
        public static List<Sale> FetchSalesRecordsInformation(String keyWord)
        {
            // Verifying user's status before providing requested information
            if (SystemResources.UserInSession.Status == "Active")
                return ConsultData.FetchSalesRecordsData(SystemResources.UserInSession.Role, keyWord);
            else
                return new List<Sale>(); // returning an empty list given invalid user status
        }

        /// <summary>
        /// This function fetches the list of product suppliers
        /// </summary>
        /// <param name="keyWord">Key word to enable specific filtered searches</param>
        /// <returns>A list of all registered suppliers</returns>
        public static List<String> FetchSupplierListInformation(String keyWord)
        {
            // Verifying user's status before providing requested information
            if (SystemResources.UserInSession.Status == "Active")
                return ConsultData.FetchSupplierListData(keyWord);
            else
                return new List<string>(); // returning an empty list given invalid user status
        }

        /// <summary>
        /// This function fetches the contes of a completed transaction
        /// </summary>
        /// <param name="saleId">Identification number of the transaction</param>
        /// <returns>A list of the content of said transaction</returns>
        public static List<Product> FetchTransactionContentInformation(String saleId)
        {
            return ConsultData.FetchTransactionContentData(saleId);
        }

        /// <summary>
        /// This function fetech the information of a completed transaction
        /// </summary>
        /// <param name="saleId">Identification number of the transaction</param>
        /// <returns>A sale object with all needed information</returns>
        public static Sale FetchTransactionInformationBySalesId(String saleId)
        {
            return ConsultData.FetchTransactionDataBySalesId(saleId); 
        }

        /// <summary>
        /// This function retreives the list of registered types
        /// </summary>
        /// <returns>A list of all registered types</returns>
        public static List<String> FetchTypeComboBoxInformation()
        {
            // Verifying user's status before providing requested information
            if (SystemResources.UserInSession.Status == "Active")
                return ConsultData.FetchTypeComboBoxData();
            else
                return new List<string>(); // returning an empty list given invalid user status
        }
    }
}
