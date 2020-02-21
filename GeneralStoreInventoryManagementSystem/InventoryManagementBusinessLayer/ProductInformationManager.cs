using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Custom Libraries;
using InventoryManagementDataLayer;
using InventoryManagementEntityLayer.Product;

namespace InventoryManagementBusinessLayer
{
    public static class ProductInformationManager
    {
        #region Consults
        /// <summary>
        /// This fucntion fetches the list of registered brands
        /// </summary>
        /// <param name="keyWord">Key word to enable specific filtered searches</param>
        /// <returns>A list  of all registered brands</returns>
        public static List<String> ConsultProductBrandListInformation(String keyWord)
        {
            // Verifying user's status before providing requested information
            if (SystemResources.UserInSession.Status == "Active")
                return ProductDataManager.ConsultProductBrandListData(keyWord);
            else
                return new List<string>(); // returning an empty list given invalid user status
        }

        /// <summary>
        /// This function fetches the list of categories
        /// </summary>
        /// <returns>A list of all categories</returns>
        public static List<String> ConsultProductCategoryComboBoxInformation()
        {
            // Verifying user's status before providing requested information
            if (SystemResources.UserInSession.Status == "Active")
                return ProductDataManager.ConsultProductCategoryComboBoxData();
            else
                return new List<string>(); // returning an empty list given invalid user status
        }

        /// <summary>
        /// This function fetches all information associated to a registered product 
        /// No verification/authentification/rejection is required at this point in developpement (This may be subject to change at a later date)
        /// </summary>
        /// <param name="productId">product's internal system identification number</param>
        /// <returns>A product object with all extracted information for that specific product id</returns>
        public static Product ConsultProductInformationByID(String productId)
        {
            return ProductDataManager.ConsultProductDataByID(productId); // Fetching and returning requested information for a product
        }

        /// <summary>
        /// This function retreives the information needed for the product list, according to the user's role
        /// It also allows the user to specify key words loosely to filter the information via product key, product name, brand name, and supplier
        /// </summary>
        /// <param name="keyWord">Key word to enable specific filtered searches</param>
        /// <returns>A list of products registered with the system</returns>
        public static List<Product> ConsultProductListInformation(String keyWord, bool forSale)
        {
            // Verifying user's status before providing requested information
            if (SystemResources.UserInSession.Status == "Active")
                if (forSale)
                    // TODO: Implement inventory management accounting system 
                    return ProductDataManager.ConsultProductListData("User", keyWord, "FIFO");
                else
                    // TODO: Implement inventory management accounting system 
                    return ProductDataManager.ConsultProductListData(SystemResources.UserInSession.Role, keyWord, "FIFO"); // Fetching and returning the inventory product list information 
            else
                return new List<Product>(); // returning an empty list given invalid user status
        }

        /// <summary>
        /// This function fetches the list of product suppliers
        /// </summary>
        /// <param name="keyWord">Key word to enable specific filtered searches</param>
        /// <returns>A list of all registered suppliers</returns>
        public static List<String> ConsultProductSupplierListInformation(String keyWord)
        {
            // Verifying user's status before providing requested information
            if (SystemResources.UserInSession.Status == "Active")
                return ProductDataManager.ConsultProductSupplierListData(keyWord);
            else
                return new List<string>(); // returning an empty list given invalid user status
        }

        /// <summary>
        /// This function retreives the list of registered types
        /// </summary>
        /// <returns>A list of all registered types</returns>
        public static List<String> ConsultProductTypeComboBoxInformation()
        {
            // Verifying user's status before providing requested information
            if (SystemResources.UserInSession.Status == "Active")
                return ProductDataManager.ConsultProductTypeComboBoxData();
            else
                return new List<string>(); // returning an empty list given invalid user status
        }
        #endregion

        #region Creates
        /// <summary>
        /// This function registers new suppliers
        /// </summary>
        /// <param name="name">Name of new supplier</param>
        /// <param name="phoneNumber">Phone number of new supplier</param>
        /// <param name="email">Email of new supplier</param>
        /// <returns>A message that confirms or denies the supplier creation process</returns>
        public static String CreateNewIncompleteProductSupplierInformation(String name)
        {
            // Requesting creation of new product supplier
            String message = ProductDataManager.CreateNewIncompleteProductSupplierData(name);

            if (message == "Supplier has been registered successfully!")
            {
                SystemProtocols.ApplyActivityProtocols("SPE4", name, null); // Quick (incomplete) registration of new supplier

                return "SUCCESS";
            }
            else
                return "";
        }

        /// <summary>
        /// This function registers new brands for product classification
        /// </summary>
        /// <param name="name">Name of new brand</param>
        /// <returns>A message that confirms or denies the brand creation process</returns>
        public static String CreateNewProductBrandInformation(String name)
        {
            // Requesting creation of a new brand
            String message = ProductDataManager.CreateNewProductBrandData(name);

            if (message == "Brand has been registered successfully!")
            {
                // Executing correct activity according to given code
                SystemProtocols.ApplyActivityProtocols("PRO3", name, null);
                return "SUCCESS";
            }
            else
                return "";
        }

        /// <summary>
        /// This function receives a product object to register its information
        /// </summary>
        /// <param name="product">Product object which contains necessary information</param>
        /// <returns>A message that confirms or denies the creation process</returns>
        public static String CreateNewProductInformation(Product product)
        {
            // Identifying the user that is requesting the product registration 
            product.RegisteredBy = SystemResources.UserInSession.Username;

            // Requesting creation of new product
            String message = ProductDataManager.CreateNewProductData(product);

            if (message == "Product created successfully!")
            {
                // Executing correct activity according to given code
                SystemProtocols.ApplyActivityProtocols("PRO4", product.Name, null);
                return "SUCCESS";
            }
            else
                return "";
        }
        #endregion

        #region Updates
        /// <summary>
        /// This function recieves an existing product that has been modified by the user and registers the new changes
        /// </summary>
        /// <param name="product">Product object with the new changes</param>
        /// <returns>A message detailing the success or failure of the update</returns>
        public static String UpdateRegisteredProductInformation(Product product)
        {
            // Requesting  an update of an existing product
            String message = ProductDataManager.UpdateRegisteredProductData(product, SystemResources.UserInSession.Username);

            if (message == "Product updated successfully!") // Update was succesful
            {
                // Executing correct activity according to given code
                SystemProtocols.ApplyActivityProtocols("PRO5", product.Name, null);
                return "SUCCESS";
            }
            else
                return "ERROR";
        }

        /// <summary>
        /// This fucntion allows users to restock registered products
        /// </summary>
        /// <param name="productId">Identification number of product to restock</param>
        /// <param name="addedAmount">Amount to be added to the current stock of products</param>
        /// <returns>A message to confirm or deny the restock process</returns>
        public static String updateRegisteredProductInformationForRestock(String productId, int addedAmount)
        {
            String message = ProductDataManager.updateRegisteredProductDataForRestock(productId, addedAmount, SystemResources.UserInSession.Username);

            if (message == "Product has been restocked successfully!")
            {
                SystemProtocols.ApplyActivityProtocols("PRO7", productId, addedAmount.ToString());
                return "SUCCESS";
            }
            else
                return "ERROR";
        }

        /// <summary>
        /// This function updates the inventory after a return has been made
        /// </summary>
        /// <param name="productId">Identification number of the product being returned</param>
        /// <param name="quantity">Quantity of units being returned</param>
        public static void UpdateRegisteredProductInformationForReturns(String productId, int quantity)
        {
            ProductDataManager.UpdateRegisteredProductDataForReturns(productId, quantity, SystemResources.UserInSession.Username);

            SystemProtocols.ApplyActivityProtocols("PRO6", productId, quantity.ToString());
        }
        #endregion
    }
}
