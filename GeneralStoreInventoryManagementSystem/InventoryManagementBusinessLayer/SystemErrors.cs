using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Custom Library
using InventoryManagementBusinessLayer.Resources;
using InventoryManagementBusinessLayer.ErrorInformation;
using InventoryManagementEntityLayer.Error;

namespace InventoryManagementBusinessLayer
{
    namespace Errors
    {
        public static class SystemErrors
        {
            /// <summary>
            /// Funtion used to record system errors during a session
            /// </summary>
            /// <param name="code">Error code for filtered search</param>
            /// <param name="description">Description of error</param>
            private static void RecordError(String code, String description)
            {
                // Registering new error via the business layer
                ErrorInformationManager.RegisterNewErrorInformation(new Error(code, description, SystemResources.UserInSession.Username));

                // Requesting the erro activity to be registered as well
                SystemResources.RecordActivity(
                    SystemResources.UserInSession.Username, // username of user in session 
                    SystemResources.UserInSession.Role + ", " + SystemResources.UserInSession.Username + ", has encountered an error during their session", // description of error
                    "ERROR"); // type of activity
            }

            #region Misc Errors
            public static void ExecuteError1()
            { 
                // User registration error
                RecordError(
                    "CREATION ERROR", // error code
                    "System failed to create and register a new user profile"); // description of error
            }
            #endregion

            #region Activity Errors
            public static void ExecuteError2()
            {
                // Activity Datagrid IndexOutOfRangeException
                RecordError(
                    "ACTIVITY ERROR", // error code
                    "Activity datagrid has ceased to function due to an out of range index exception"); // description of error
            }

            public static void ExecuteError3()
            {
                // Activity Datagrid InsufficientMemoryException
                RecordError(
                    "ACTIVITY ERROR", // error code
                    "Activity datagrid has ceased to function due to an insufficient memmory exception"); // description of error
            }

            public static void ExecuteError4(String meta)
            {
                // Activity Datagrid Exception
                RecordError(
                    "ACTIVITY ERROR", // error code
                    meta); // description of error
            }
            #endregion

            #region Graphs Errors
            public static void ExecuteError5(String meta)
            {
                // Graph Analytics ListBox IndexOutOfRangeException
                RecordError(
                    "GRAPH ERROR", // error code 
                    "Graph analytic's list box is unable to display usernames due to out of range index exception in tab: " + meta); // description of error
            }
            
            public static void ExecuteError6(String meta)
            {
                // Graph Analytics ListBox InsufficientMemoryException
                RecordError(
                    "GRAPH ERROR", // error code 
                    "Graph analytic's list box is unable to display usernames due to insufficient memory exception in tab: " + meta); // description of error
            }

            public static void ExecuteError7(String meta)
            {
                // Graph Analytics ListBox OutOfMemoryException
                RecordError(
                    "GRAPH ERROR", // error code  
                    "Graph analytic's list box is unable to display usernames due to out of memory exception in tab: " + meta); // description of error
            }

            public static void ExecuteError8(String meta1, String meta2)
            {
                // Graph Analytics ListBox Exception
                RecordError(
                    "GRAPH ERROR", // error code  
                    meta2 + "'s list box has caused: " + meta1); // description of error
            }
            #endregion

            #region Inventory Errors
            public static void ExecuteError9()
            {
                // Inventory Datagrid IndexOutOfRangeException
                RecordError(
                    "INVENTORY ERROR", // error code  
                    "Inventory datagrid has ceased to function due to an out of range index exception"); // description of error
            }

            public static void ExecuteError10()
            {
                // Inventory Datagrid InsufficientMemoryException
                RecordError(
                    "INVENTORY ERROR", // error code  
                    "Inventory datagrid has ceased to function due to insufficient memory exception"); // description of error
            }

            public static void ExecuteError11()
            {
                // Inventory Datagrid OutOfMemoryException
                RecordError(
                    "INVENTORY ERROR", // error code  
                    "Inventory datagrid has ceased to function due to out of memory exception"); // description of error
            }

            public static void ExecuteError12(String meta)
            {
                // Inventory Datagrid Exception
                RecordError(
                    "INVENTORY ERROR", // error code  
                    meta); // description of error
            }
            #endregion

            #region Product Errors
            public static void ExecuteError13(String meta)
            {
                // Register New Product ListBox IndexOutOfRangeException
                RecordError(
                    "PRODUCT ERROR", // error code
                    "Register new product form's" + meta + " list box is unable to display information due to out of range index exception"); // description of error
            }

            public static void ExecuteError14(String meta)
            {
                // Register New Product ListBox InsufficientMemoryException
                RecordError(
                    "PRODUCT ERROR", // error code
                    "Register new product form's" + meta + " list box is unable to display information due to insufficient memory exception"); // description of error
            }

            public static void ExecuteError15(String meta)
            {
                // Register New Product ListBox OutOfMemoryException
                RecordError(
                    "PRODUCT ERROR", // error code
                    "Register new product form's" + meta + " list box is unable to display information due to out of memory exception"); // description of error
            }

            public static void ExecuteError16(String meta1, String meta2)
            {
                // Register New Product ListBox Exception
                RecordError(
                    "PRODUCT ERROR", // error code
                    meta2 + " list box has caused: " + meta1); // description of error
            }
            #endregion

            #region Cart Errors
            public static void ExecuteError17()
            {
                // Cart ArgumentNullException
                RecordError(
                    "CART ERROR", // error code
                    "Cart has malfunctioned due to null argument exception while adding a product"); // description of error
            }

            public static void ExecuteError18()
            {
                // Cart ArgumentOutOfRangeException
                RecordError(
                    "CART ERROR", // error code
                    "Cart has malfunctioned due to argument out of range exception while adding a product"); // description of error
            }

            public static void ExecuteError19()
            { 
                // Cart IndexOutOfRangeException
                RecordError(
                    "CART ERROR", // error code
                    "Cart has malfunctioned due to index out of range exception while adding a product"); // description of error
            }

            public static void ExecuteError20(String meta)
            {
                // Cart Exception
                RecordError(
                    "CART ERROR", // error code
                    "Cart has malffunctioned while adding a product due to: " + meta); // description of error
            }
            #endregion

            #region Sales Errors
            public static void ExecuteError21()
            {
                // Product Datagrid IndexOutOfRangeException
                RecordError(
                    "NEW SALE ERROR", // error code
                    "Product datagrid has ceased to function due to an out of range index exception"); // description of error
            }

            public static void ExecuteError22()
            {
                // Product Datagrid InsufficientMemoryException
                RecordError(
                    "NEW SALE ERROR", // error code
                    "Product datagrid has ceased to function due to insufficient memory exception"); // description of error
            }

            public static void ExecuteError23()
            {
                // Product Datagrid OutOfMemoryException
                RecordError(
                    "NEW SALE ERROR", // error code
                    "Product datagrid has ceased to function due to out of memory exception"); // description of error
            }

            public static void ExecuteError24(String meta)
            {
                // Product Datagrid Exception
                RecordError(
                    "NEW SALE ERROR", // error code
                    meta); // description of error
            }

            public static void ExecuteError25()
            {
                // Cart Summary Datagrid IndexOutOfRangeException
                RecordError(
                    "NEW SALE ERROR", // error code
                    "Cart summary datagrid has ceased to function due to an out of range index exception"); // description of error
            }

            public static void ExecuteError26()
            {
                // Cart Summary Datagrid InsufficientMemoryException
                RecordError(
                    "NEW SALE ERROR", // error code
                    "Cart summary datagrid has ceased to function due to insufficient memory exception"); // description of error
            }

            public static void ExecuteError27()
            {
                // Cart Summary Datagrid OutOfMemoryException
                RecordError(
                    "NEW SALE ERROR", // error code
                    "Cart Summary datagrid has ceased to function due to out of memory exception"); // description of error
            }

            public static void ExecuteError28(String meta)
            {
                // Cart Summary Datagrid Exception
                RecordError(
                    "NEW SALE ERROR", // error code
                    meta); // description of error
            }
            #endregion
        }
    }
}
