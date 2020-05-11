using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Custom Library
using InventoryManagementBusinessLayer.Resources;

namespace InventoryManagementBusinessLayer
{
    namespace Errors
    {
        public static class SystemErrors
        {
            private static void RegisterErrorInActivitLog()
            {
                SystemResources.RecordActivity(
                    SystemResources.UserInSession.Username, // username of user in session 
                    SystemResources.UserInSession.Role + ", " + SystemResources.UserInSession.Username + ", has encountered an error during their session", // description of activity
                    "ERROR"); // type of activity
            }

            public static void ExecuteError1()
            { 
                // User registration error
                SystemResources.RecordActivity(
                    SystemResources.UserInSession.Username, // username of user in session 
                    "System failed to create and register a new user profile", // description of activity
                    "CREATION ERROR"); // type of activity

                RegisterErrorInActivitLog();
            }

            public static void ExecuteError2()
            {
                // Activity Datagrid IndexOutOfRangeException
                SystemResources.RecordActivity(
                    SystemResources.UserInSession.Username, // username of user in session 
                    "Activity datagrid has ceased to function due to an out of range index exception", // description of activity
                    "ACTIVITY ERROR"); // type of activity

                RegisterErrorInActivitLog();
            }

            public static void ExecuteError3()
            {
                // Activity Datagrid InsufficientMemoryException
                SystemResources.RecordActivity(
                    SystemResources.UserInSession.Username, // username of user in session 
                    "Activity datagrid has ceased to function due to an insufficient memmory exception", // description of activity
                    "ACTIVITY ERROR"); // type of activity

                RegisterErrorInActivitLog();
            }

            public static void ExecuteError4(String meta)
            {
                // Activity Datagrid Exception
                SystemResources.RecordActivity(
                    SystemResources.UserInSession.Username, // username of user in session 
                    meta, // description of activity
                    "ACTIVITY ERROR"); // type of activity

                RegisterErrorInActivitLog();
            }

            public static void ExecuteError5(String meta)
            {
                // Graph Analytics ListBox IndexOutOfRangeException
                SystemResources.RecordActivity(
                    SystemResources.UserInSession.Username, // username of user in session 
                    "Graph analytic's list box is unable to display usernames due to out of range index exception in tab: " + meta, // description of activity
                    "GRAPH ERROR"); // type of activity

                RegisterErrorInActivitLog();
            }
            
            public static void ExecuteError6(String meta)
            {
                // Graph Analytics ListBox InsufficientMemoryException
                SystemResources.RecordActivity(
                    SystemResources.UserInSession.Username, // username of user in session 
                    "Graph analytic's list box is unable to display usernames due to insufficient memory exception in tab: " + meta, // description of activity
                    "GRAPH ERROR"); // type of activity

                RegisterErrorInActivitLog();
            }

            public static void ExecuteError7(String meta)
            {
                // Graph Analytics ListBox OutOfMemoryException
                SystemResources.RecordActivity(
                    SystemResources.UserInSession.Username, // username of user in session 
                    "Graph analytic's list box is unable to display usernames due to out of memory exception in tab: " + meta, // description of activity
                    "GRAPH ERROR"); // type of activity

                RegisterErrorInActivitLog();
            }

            public static void ExecuteError8(String meta1, String meta2)
            {
                // Graph Analytics ListBox Exception
                SystemResources.RecordActivity(
                    SystemResources.UserInSession.Username, // username of user in session 
                    meta2 + "'s list box has caused: " + meta1, // description of activity
                    "GRAPH ERROR"); // type of activity

                RegisterErrorInActivitLog();
            }

            public static void ExecuteError9()
            {
                // Inventory Datagrid IndexOutOfRangeException
                SystemResources.RecordActivity(
                    SystemResources.UserInSession.Username, // username of user in session 
                    "Inventory datagrid has ceased to function due to an out of range index exception", // description of activity
                    "INVENTORY ERROR"); // type of activity

                RegisterErrorInActivitLog();
            }

            public static void ExecuteError10()
            {
                // Inventory Datagrid InsufficientMemoryException
                SystemResources.RecordActivity(
                    SystemResources.UserInSession.Username, // username of user in session 
                    "Inventory datagrid has ceased to function due to insufficient memory exception", // description of activity
                    "INVENTORY ERROR"); // type of activity

                RegisterErrorInActivitLog();
            }

            public static void ExecuteError11()
            {
                // Inventory Datagrid OutOfMemoryException
                SystemResources.RecordActivity(
                    SystemResources.UserInSession.Username, // username of user in session 
                    "Inventory datagrid has ceased to function due to out of memory exception", // description of activity
                    "INVENTORY ERROR"); // type of activity

                RegisterErrorInActivitLog();
            }

            public static void ExecuteError12(String meta)
            {
                // Inventory Datagrid Exception
                SystemResources.RecordActivity(
                    SystemResources.UserInSession.Username, // username of user in session 
                    meta, // description of activity
                    "INVENTORY ERROR"); // type of activity

                RegisterErrorInActivitLog();
            }

            public static void ExecuteError13(String meta)
            {
                // Register New Product ListBox IndexOutOfRangeException
                SystemResources.RecordActivity(
                    SystemResources.UserInSession.Username, // username of user in session 
                    "Register new product form's" + meta + " list box is unable to display information due to out of range index exception", // description of activity
                    "PRODUCT ERROR"); // type of activity

                RegisterErrorInActivitLog();
            }

            public static void ExecuteError14(String meta)
            {
                // Register New Product ListBox InsufficientMemoryException
                SystemResources.RecordActivity(
                    SystemResources.UserInSession.Username, // username of user in session 
                    "Register new product form's" + meta + " list box is unable to display information due to insufficient memory exception", // description of activity
                    "PRODUCT ERROR"); // type of activity

                RegisterErrorInActivitLog();
            }

            public static void ExecuteError15(String meta)
            {
                // Register New Product ListBox OutOfMemoryException
                SystemResources.RecordActivity(
                    SystemResources.UserInSession.Username, // username of user in session 
                    "Register new product form's" + meta + " list box is unable to display information due to out of memory exception", // description of activity
                    "PRODUCT ERROR"); // type of activity

                RegisterErrorInActivitLog();
            }

            public static void ExecuteError16(String meta1, String meta2)
            {
                // Register New Product ListBox Exception
                SystemResources.RecordActivity(
                    SystemResources.UserInSession.Username, // username of user in session 
                    meta2 + " list box has caused: " + meta1, // description of activity
                    "PRODUCT ERROR"); // type of activity

                RegisterErrorInActivitLog();
            }

            public static void ExecuteError17()
            {
                // Cart ArgumentNullException
                SystemResources.RecordActivity(
                    SystemResources.UserInSession.Username, // username of user in session 
                    "Cart has malfunctioned due to null argument exception while adding a product", // description of activity
                    "CART ERROR"); // type of activity

                RegisterErrorInActivitLog();
            }

            public static void ExecuteError18()
            {
                // Cart ArgumentOutOfRangeException
                SystemResources.RecordActivity(
                    SystemResources.UserInSession.Username, // username of user in session 
                    "Cart has malfunctioned due to argument out of range exception while adding a product", // description of activity
                    "CART ERROR"); // type of activity

                RegisterErrorInActivitLog();
            }

            public static void ExecuteError19()
            { 
                // Cart IndexOutOfRangeException
                SystemResources.RecordActivity(
                    SystemResources.UserInSession.Username, // username of user in session 
                    "Cart has malfunctioned due to index out of range exception while adding a product", // description of activity
                    "CART ERROR"); // type of activity

                RegisterErrorInActivitLog();
            }

            public static void ExecuteError20(String meta)
            {
                // Cart Exception
                SystemResources.RecordActivity(
                    SystemResources.UserInSession.Username, // username of user in session 
                    "Cart has malffunctioned while adding a product due to: " + meta, // description of activity
                    "CART ERROR"); // type of activity

                RegisterErrorInActivitLog();
            }

            public static void ExecuteError21()
            {
                // Product Datagrid IndexOutOfRangeException
                SystemResources.RecordActivity(
                    SystemResources.UserInSession.Username, // username of user in session 
                    "Product datagrid has ceased to function due to an out of range index exception", // description of activity
                    "NEW SALE ERROR"); // type of activity

                RegisterErrorInActivitLog();
            }

            public static void ExecuteError22()
            {
                // Product Datagrid InsufficientMemoryException
                SystemResources.RecordActivity(
                    SystemResources.UserInSession.Username, // username of user in session 
                    "Product datagrid has ceased to function due to insufficient memory exception", // description of activity
                    "NEW SALE ERROR"); // type of activity

                RegisterErrorInActivitLog();
            }

            public static void ExecuteError23()
            {
                // Product Datagrid OutOfMemoryException
                SystemResources.RecordActivity(
                    SystemResources.UserInSession.Username, // username of user in session 
                    "Product datagrid has ceased to function due to out of memory exception", // description of activity
                    "NEW SALE ERROR"); // type of activity

                RegisterErrorInActivitLog();
            }

            public static void ExecuteError24(String meta)
            {
                // Product Datagrid Exception
                SystemResources.RecordActivity(
                    SystemResources.UserInSession.Username, // username of user in session 
                    meta, // description of activity
                    "NEW SALE ERROR"); // type of activity

                RegisterErrorInActivitLog();
            }

            public static void ExecuteError25()
            {
                // Cart Summary Datagrid IndexOutOfRangeException
                SystemResources.RecordActivity(
                    SystemResources.UserInSession.Username, // username of user in session 
                    "Cart summary datagrid has ceased to function due to an out of range index exception", // description of activity
                    "NEW SALE ERROR"); // type of activity

                RegisterErrorInActivitLog();
            }

            public static void ExecuteError26()
            {
                // Cart Summary Datagrid InsufficientMemoryException
                SystemResources.RecordActivity(
                    SystemResources.UserInSession.Username, // username of user in session 
                    "Cart summary datagrid has ceased to function due to insufficient memory exception", // description of activity
                    "NEW SALE ERROR"); // type of activity

                RegisterErrorInActivitLog();
            }

            public static void ExecuteError27()
            {
                // Cart Summary Datagrid OutOfMemoryException
                SystemResources.RecordActivity(
                    SystemResources.UserInSession.Username, // username of user in session 
                    "Cart Summary datagrid has ceased to function due to out of memory exception", // description of activity
                    "NEW SALE ERROR"); // type of activity

                RegisterErrorInActivitLog();
            }

            public static void ExecuteError28(String meta)
            {
                // Cart Summary Datagrid Exception
                SystemResources.RecordActivity(
                    SystemResources.UserInSession.Username, // username of user in session 
                    meta, // description of activity
                    "NEW SALE ERROR"); // type of activity

                RegisterErrorInActivitLog();
            }
        }
    }
}
