using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Custom Library
using InventoryManagementBusinessLayer.ProductInformation;
using InventoryManagementBusinessLayer.Resources;
using InventoryManagementBusinessLayer.SaleInformation;
using InventoryManagementBusinessLayer.UserInformation;
using InventoryManagementEntityLayer.Product;
using InventoryManagementEntityLayer.Sale;

namespace InventoryManagementBusinessLayer
{
    namespace Protocols
    {
        public static class SystemProtocols
        {
            /// <summary>
            /// Function to register systema and user activity durring an active session
            /// </summary>
            /// <param name="code">Code to execute and register correct activity</param>
            /// <param name="meta1">Auxiliary information for certain activities</param>
            public static void ApplyActivityProtocols(String code, String meta1, String meta2)
            {
                switch (code)
                {
                    #region Activity Codes

                    #region Activities
                    case "ACT1": // Registering user access to activity logs

                        SystemResources.RecordActivity(
                            SystemResources.UserInSession.Username, // username of user in session 
                            SystemResources.UserInSession.Role + ", " + SystemResources.UserInSession.Username + ", has accessed the activities logs", // description of activity
                            "ADMIN ACCESS"); // type of activity
                        break;
                    #endregion

                    #region Cart
                    case "CAR1": // Registering user access to cart

                        SystemResources.RecordActivity(
                            SystemResources.UserInSession.Username, // username of user in session
                            SystemResources.UserInSession.Role + ", " + SystemResources.UserInSession.Username + ", has accessed the cart view", // description of activity
                            "BASIC ACCESS"); // type of activity
                        break;
                    #endregion

                    #region Errors
                    case "ERR1": // Registering user access to error logs

                        SystemResources.RecordActivity(
                            SystemResources.UserInSession.Username, // username of user in session 
                            SystemResources.UserInSession.Role + ", " + SystemResources.UserInSession.Username + ", has accessed the errors logs", // description of activity
                            "ADMIN ACCESS"); // type of activity
                        break;

                    case "ERR2": // Registering user account creation error

                        SystemResources.RecordActivity(
                            SystemResources.UserInSession.Username, // username of user in session 
                            "System failed to create and register a new user profile", // description of activity
                            "CREATION ERROR"); // type of activity
                        break;
                    #endregion

                    #region Graphs
                    case "GRA1": // Registering user access to graphs analytics

                        SystemResources.RecordActivity(
                            SystemResources.UserInSession.Username, // username of user in session 
                            SystemResources.UserInSession.Role + ", " + SystemResources.UserInSession.Username + ", has accessed the graphs analytics", // description of activity
                            "ADMIN ACCESS"); // type of activity
                        break;
                    #endregion

                    #region Inventory
                    case "INV1": // Registering user access to the inventory view

                        SystemResources.RecordActivity(
                            SystemResources.UserInSession.Username, // username of user in session 
                            SystemResources.UserInSession.Role + ", " + SystemResources.UserInSession.Username + ", has accessed the inventory browser", // description of activity
                            "BASIC ACCESS"); // type of activity
                        break;
                    #endregion

                    #region Log In Failer
                    case "LOG0": // Registering a failed log in 

                        SystemResources.RecordActivity(
                            meta1, // provided username that failed the log in
                            "Deactivated account, " + meta1 + ", attemped to log into the system", // description of activity
                            "LOGIN FAILURE"); // type of activity
                        break;
                    #endregion

                    #region Products
                    case "PRO1": // Registering user access to product restock form

                        SystemResources.RecordActivity(
                            SystemResources.UserInSession.Username, // username of user in session 
                            SystemResources.UserInSession.Role + ", " + SystemResources.UserInSession.Username + ", has accessed the form to restock products", // description of activity
                            "ADMIN ACCESS"); // type of activity
                        break;

                    case "PRO2": // Registering user access to product registration form

                        SystemResources.RecordActivity(
                            SystemResources.UserInSession.Username, // username of user in session 
                            SystemResources.UserInSession.Role + ", " + SystemResources.UserInSession.Username + ", has accessed the form to register new products", // description of activity
                            "ADMIN ACCESS"); // type of activity
                        break;

                    case "PRO3": // Registering the creation of a new product brand

                        SystemResources.RecordActivity(
                            SystemResources.UserInSession.Username, // username of user in session 
                            SystemResources.UserInSession.Role + ", " + SystemResources.UserInSession.Username + ", has registered a new brand: " + meta1.ToUpper(), // description of activity
                            "BRAND CREATION"); // type of activity
                        break;

                    case "PRO4": // Registering the creation of a new product brand

                        SystemResources.RecordActivity(
                            SystemResources.UserInSession.Username, // username of user in session 
                            SystemResources.UserInSession.Role + ", " + SystemResources.UserInSession.Username + ", has registered a new product: " + meta1.ToUpper(), // description of activity
                            "PRODUCT CREATION"); // type of activity
                        break;

                    case "PRO5": // Editing product information

                        SystemResources.RecordActivity(
                            SystemResources.UserInSession.Username, // username of user in session 
                            SystemResources.UserInSession.Role + ", " + SystemResources.UserInSession.Username + ", has edited product: " + meta1.ToUpper(), // description of activity
                            "PRODUCT EDIT"); // type of activity
                        break;

                    case "PRO6": // Editing product information

                        SystemResources.RecordActivity(
                            SystemResources.UserInSession.Username, // username of user in session 
                            SystemResources.UserInSession.Role + ", " + SystemResources.UserInSession.Username + ", has managed the return of " + meta2 + " unit(s) of " + meta1.ToUpper(), // description of activity
                            "PRODUCT RETURNED"); // type of activity
                        break;

                    case "PRO7": // Editing product information

                        SystemResources.RecordActivity(
                            SystemResources.UserInSession.Username, // username of user in session 
                            SystemResources.UserInSession.Role + ", " + SystemResources.UserInSession.Username + ", has restocked " + meta2 + " unit(s) of " + meta1.ToUpper(), // description of activity
                            "PRODUCT RESTOCK"); // type of activity
                        break;
                    #endregion

                    #region Reports
                    case "REP1": // Registering user access to reports analytics

                        SystemResources.RecordActivity(
                            SystemResources.UserInSession.Username, // username of user in session 
                            SystemResources.UserInSession.Role + ", " + SystemResources.UserInSession.Username + ", has accessed the reports analytics", // description of activity
                            "ADMIN ACCESS"); // type of activity
                        break;
                    #endregion

                    #region Sales
                    case "SAL1": // Registering user access to the sales registration form as basic user

                        SystemResources.RecordActivity(
                            SystemResources.UserInSession.Username, // username of user in session 
                            SystemResources.UserInSession.Role + ", " + SystemResources.UserInSession.Username + ", has accessed the form to register new sales", // description of activity
                            "BASIC ACCESS"); // type of activity
                        break;

                    case "SAL2": // Registering user access to the sales registry form as basic user

                        SystemResources.RecordActivity(
                            SystemResources.UserInSession.Username, // username of user in session 
                            SystemResources.UserInSession.Role + ", " + SystemResources.UserInSession.Username + ", has accessed their sales records", // description of activity
                            "BASIC ACCESS"); // type of activity
                        break;

                    case "SAL3": // Registering user access to the sales registry form as admin user

                        SystemResources.RecordActivity(
                            SystemResources.UserInSession.Username, // username of user in session 
                            SystemResources.UserInSession.Role + ", " + SystemResources.UserInSession.Username + ", has accessed all sales records", // description of activity
                            "ADMIN ACCESS"); // type of activity
                        break;

                    case "SAL4": // Registering user access to the sales registration form as admin user

                        SystemResources.RecordActivity(
                            SystemResources.UserInSession.Username, // username of user in session 
                            SystemResources.UserInSession.Role + ", " + SystemResources.UserInSession.Username + ", has accessed the form to register new sales", // description of activity
                            "ADMIN ACCESS"); // type of activity
                        break;

                    case "SAL5": // Registering user access to the sales registration form as admin user

                        SystemResources.RecordActivity(
                            SystemResources.UserInSession.Username, // username of user in session 
                            SystemResources.UserInSession.Role + ", " + SystemResources.UserInSession.Username + ", has registered a new transaction: " + meta1, // description of activity
                            "NEW TRANSACTION"); // type of activity
                        break;

                    case "SAL6": // voiding a registered transaction

                        SystemResources.RecordActivity(
                            SystemResources.UserInSession.Username, // username of user in session 
                            SystemResources.UserInSession.Role + ", " + SystemResources.UserInSession.Username + ", has voided transaction: " + meta1, // description of activity
                            "VOID TRANSACTION"); // type of activity
                        break;

                    case "SAL7": // voiding a registered transaction

                        SystemResources.RecordActivity(
                            SystemResources.UserInSession.Username, // username of user in session 
                            SystemResources.UserInSession.Role + ", " + SystemResources.UserInSession.Username + ", has managed a return of transaction, " + meta1 + ", to new transaction, " + meta2, // description of activity
                            "RETURN TRANSACTION"); // type of activity
                        break;
                    #endregion

                    #region Special
                    case "SPE1": // Registering a password change

                        SystemResources.RecordActivity(
                            SystemResources.UserInSession.Username, // username of user in session
                            SystemResources.UserInSession.Role + ", " + SystemResources.UserInSession.Username + ", has changed their password", // description of activity
                            "PASSWORD CHANGE"); // type of activity
                        break;

                    case "SPE2": // Registering a user access level change

                        SystemResources.RecordActivity(
                            SystemResources.UserInSession.Username,
                            SystemResources.UserInSession.Role + ", " + SystemResources.UserInSession.Username + ", changed " + meta1 + "'s user access level to: " + meta2, // description of activity
                            meta2 == "Admin" ? "ADMIN PROMOTION" : "USER DEMOTION"); // type of activity
                        break;

                    case "SPE3": // Registering a user account status change

                        SystemResources.RecordActivity(
                            SystemResources.UserInSession.Username, // username of user in session 
                            SystemResources.UserInSession.Role + ", " + SystemResources.UserInSession.Username + ", " + (meta2 == "Active" ? "reinstated " : "suspended") + " user account, " + meta1, // description of activity
                            meta2 == "Active" ? "ACTIVATE " : "SUSPEND"); // type of activity
                        break;

                    case "SPE4": // Registering a new supplier with incomplete information

                        SystemResources.RecordActivity(
                            SystemResources.UserInSession.Username, // username of user in session 
                            SystemResources.UserInSession.Role + ", " + SystemResources.UserInSession.Username + ", has incompletly registered a new supplier: " + meta1.ToUpper(), // description of activity
                            "INCOMPLETE CREATION"); // type of activity
                        break;
                    #endregion

                    #region Supplier
                    case "SUP1": // Registering a new supplier with complete information

                        SystemResources.RecordActivity(
                            SystemResources.UserInSession.Username, // username of user in session 
                            SystemResources.UserInSession.Role + ", " + SystemResources.UserInSession.Username + ", has registered a new supplier: " + meta1.ToUpper(), // description of activity
                            "SUPPLIER CREATION"); // type of activity
                        break;
                    #endregion

                    #region Users
                    case "USE1": // Registering user access to the users registry form

                        SystemResources.RecordActivity(
                            SystemResources.UserInSession.Username, // username of user in session 
                            SystemResources.UserInSession.Role + ", " + SystemResources.UserInSession.Username + ", has accessed the user registry", // description of activity
                            "ADMIN ACCESS"); // type of activity
                        break;

                    case "USE2": // Registering user access to the user registration form

                        SystemResources.RecordActivity(
                            SystemResources.UserInSession.Username, // username of user in session 
                            SystemResources.UserInSession.Role + ", " + SystemResources.UserInSession.Username + ", has accessed the form to register new users", // description of activity
                            "ADMIN ACCESS"); // type of activity
                        break;

                    case "USE3": // Registering the creation of a new user account

                        SystemResources.RecordActivity(
                            SystemResources.UserInSession.Username, // username of user in session 
                            SystemResources.UserInSession.Role + ", " + SystemResources.UserInSession.Username + ", has created a new user account for, " + meta1, // description of activity
                            "USER CREATION"); // type of activity
                        break;
                    #endregion

                    #endregion

                    default:
                        break;
                }
            }

            /// <summary>
            /// Function to apply the correct protocols for all features associated with the cart system resource
            /// </summary>
            /// <param name="protocol">Identification of the desired protocol to execute</param>
            /// <param name="productId">If needed, this identifies the desired product to manipulate</param>
            /// <param name="productPrice">If needed, this indicates the price of a particular product</param>
            /// <param name="product">If needed, a product object that will be added, modifed, or removed from the cart</param>
            /// <param name="limit">If needed, this set's the maximum amount of units of an item exists in the inventory and thus can be added to the cart</param>
            /// <returns>If needed, the cart with it's list of products</returns>
            public static List<Product> ApplyCartManagementProtocol(int protocol, string productId, decimal productPrice, Product product, int limit)
            {
                switch (protocol)
                {
                    case 1: // Summarizing the contents of the cart

                        return SystemResources.Cart;

                    case 2: // Adding an item to the cart

                        if (IsProductIdPresent(product.Id)) // checking if a unit was already added before hand
                            SystemResources.AddUnitsToAnItem(product.Id, product.Unit, product.UnitPrice, product.Quantity, limit); // adding an additional unit to the item
                        else
                        {
                            product.UnitPrice *= product.Quantity;
                            SystemResources.Cart.Add(product); // adding the new item to the cart
                        }

                        return null;

                    case 3: // Clearing the cart

                        SystemResources.EmptyCart();

                        return null;

                    case 4: // Removing a specific product from the cart

                        SystemResources.RemoveItem(productId);

                        return null;

                    case 5: // Removing one unit from an item in the cart

                        SystemResources.RemoveOneFromAnItem(productId, productPrice);

                        return null;

                    default:
                        return null;
                }
            }

            /// <summary>
            /// Function dedicated to validate a user's credentials before granting or denying access to the system
            /// </summary>
            /// <param name="username">Username requesting validation</param>
            /// <param name="password">Password associated to provided username</param>
            /// <returns>A message that indicates the proper protocol to execute depending on the validation results</returns>
            public static String ApplyCredentialsValidationProtocol(String username, String password)
            {
                // Using native class to initiate credentials validation with provided information
                String message = UserInformationManager.ConsultUserCredentialsValidationInformation(username, password);

                if (message == "Username does not exists")
                    return "INVALID USER";
                else if (message == "User profile is currently inactive")
                {
                    ApplyActivityProtocols("LOG0", username, null); // registering correct activity for given case
                    return "INACTIVE USER";
                }
                else if (message == "Password is incorrect")
                    return "INCORRECT";
                else
                    return ""; // Validation has been successful
            }

            /// <summary>
            /// Fucntion to initiate a new user session
            /// </summary>
            /// <param name="username">Username requesting a new session</param>
            public static void ApplyLogInProtocols(string username)
            {
                SystemResources.BeginUserSession(username); // opening a new user session
            }

            /// <summary>
            /// Funciton to terminate an active user session 
            /// </summary>
            public static void ApplyLogOutProtocols()
            {
                SystemResources.EndUserSession(); // closing a current active user session
            }

            /// <summary>
            /// This function manages the protocols conserning return policies
            /// </summary>
            /// <param name="sale">The original transaction requesting to be modified</param>
            /// <param name="remainingProducts">List of products that have not been returned</param>
            /// <param name="returnedProducts">List of products that have been returned</param>
            /// <returns>A message confirming the type of policy that was applied</returns>
            public static String ApplyReturnPolicyProtocols(Sale sale, List<Product> remainingProducts, List<Product> returnedProducts)
            {
                if (remainingProducts.Count > 0) // Verifying if only some products have been returned
                {
                    // 1. Create a new sale and get its id
                    String saleId = SaleInformationManager.CreateNewSalesTransactionInformation(sale);

                    // 2. Register the contents of new sale
                    if (saleId != null || saleId != "") // if the new sale was successfully created
                    {
                        foreach (Product item in remainingProducts)
                            SaleInformationManager.CreateNewSalesTransactionContentInformation(item, saleId);

                        ApplyActivityProtocols("SAL5", saleId, null);

                        // 3. Register old sale as returned (type of void)
                        SaleInformationManager.UpdateTransactionStatusDataToReturned(sale.Id, saleId);

                        // 4. Return selected products back to inventory
                        foreach (Product item in returnedProducts)
                            ProductInformationManager.UpdateRegisteredProductInformationForReturns(item.Id, item.Quantity);
                    }

                    return saleId; // returning the identification number of the new valid transaction
                }
                else // All products have been returned
                {
                    SaleInformationManager.UpdateTransactionStatusInformationToVoid(sale.Id); // If no products remain, equivalent to returning everything, then this process counts as voiding the original transaction
                    return "VOIDED"; // Confirms that returning all product is the equivalent of a voided transaction
                }
            }

            /// <summary>
            /// Funtion in charge of managint all types of transactions from purchase, to returns, to cancelations
            /// </summary>
            /// <param name="protocol">Identification of the desired protocol to execute</param>
            /// <param name="sale">The sale object and all necessary information</param>
            /// <returns>A message to indicate the success or failure of the protocol</returns>
            public static String ApplySalesTransactionProtocols(int protocol, Sale sale)
            {
                switch (protocol)
                {
                    case 1: // Registering a new transaction

                        String saleId = SaleInformationManager.CreateNewSalesTransactionInformation(sale);

                        if (saleId != null || saleId != "")
                        {
                            foreach (Product item in SystemResources.Cart)
                                SaleInformationManager.CreateNewSalesTransactionContentInformation(item, saleId);

                            SystemResources.EmptyCart();

                            ApplyActivityProtocols("SAL5", saleId, null);

                            return "SUCCESS";
                        }
                        else
                            return "ERROR";

                    default:
                        return "";
                }
            }

            /// <summary>
            /// Function to restrict or activate certain features depending on the user's access level 
            /// </summary>
            /// <returns>True or False</returns>
            public static bool ApplySessionsProtocols(int protocol, String meta1, String meta2)
            {
                switch (protocol)
                {
                    case 1:

                        // Limiting option according to current user's access level
                        if (SystemResources.UserInSession.Role == "User")
                            return true;
                        else
                            return false;

                    case 2:

                        // If the target user is of a different account and access level is equals to the current user in session
                        if (meta1 != SystemResources.UserInSession.Username && meta2 == SystemResources.UserInSession.Role)
                            return true;
                        else
                            return false;

                    case 3:

                        // If the target user the one with the current open sesison
                        if (meta1 == SystemResources.UserInSession.Username)
                            return true;
                        else
                            return false;

                    default:
                        return false;
                }
            }

            #region Auxiliary Function 
            /// <summary>
            /// Function to verify if a product id is included amongst the items in the cart
            /// </summary>
            /// <param name="productId">Product id requiring the verification</param>
            /// <returns>True or False</returns>
            private static bool IsProductIdPresent(String productId)
            {
                foreach (Product item in SystemResources.Cart)
                    if (item.Id == productId)
                        return true; // this product is included in the cart thus having a matching id

                return false; // no item has been found to match the given product id
            }
            #endregion
        }
    }
}
