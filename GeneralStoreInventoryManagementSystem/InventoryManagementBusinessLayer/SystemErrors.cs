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
            public static void ExecuteError1()
            { 
                // User registration error
                SystemResources.RecordActivity(
                    SystemResources.UserInSession.Username, // username of user in session 
                    "System failed to create and register a new user profile", // description of activity
                    "CREATION ERROR"); // type of activity
            }

            public static void ExecuteError2()
            {
                // Activity Datagrid IndexOutOfRangeException
                SystemResources.RecordActivity(
                    SystemResources.UserInSession.Username, // username of user in session 
                    "Activity datagrid has ceased to function due to an out of range index exception", // description of activity
                    "ACTIVITY ERROR"); // type of activity
            }

            public static void ExecuteError3()
            {
                // Activity Datagrid InsufficientMemoryException
                SystemResources.RecordActivity(
                    SystemResources.UserInSession.Username, // username of user in session 
                    "Activity datagrid has ceased to function due to an insufficient memmory exception", // description of activity
                    "ACTIVITY ERROR"); // type of activity
            }

            public static void ExecuteError4(String meta)
            {
                // Activity Datagrid Exception
                SystemResources.RecordActivity(
                    SystemResources.UserInSession.Username, // username of user in session 
                    meta, // description of activity
                    "ACTIVITY ERROR"); // type of activity
            }

            public static void ExecuteError5(String meta)
            {
                // Graph Analytics ListBox IndexOutOfRangeException
                SystemResources.RecordActivity(
                    SystemResources.UserInSession.Username, // username of user in session 
                    "Graph analytic's list box is unable to display usernames due to out of range index exception in tab: " + meta, // description of activity
                    "GRAPH ERROR"); // type of activity
            }
            
            public static void ExecuteError6(String meta)
            {
                // Graph Analytics ListBox InsufficientMemoryException
                SystemResources.RecordActivity(
                    SystemResources.UserInSession.Username, // username of user in session 
                    "Graph analytic's list box is unable to display usernames due to insufficient memory exception in tab: " + meta, // description of activity
                    "GRAPH ERROR"); // type of activity
            }

            public static void ExecuteError7(String meta)
            {
                // Graph Analytics ListBox OutOfMemoryException
                SystemResources.RecordActivity(
                    SystemResources.UserInSession.Username, // username of user in session 
                    "Graph analytic's list box is unable to display usernames due to out of memory exception in tab: " + meta, // description of activity
                    "GRAPH ERROR"); // type of activity
            }

            public static void ExecuteError8(String meta1, String meta2)
            {
                // Graph Analytics ListBox Exception
                SystemResources.RecordActivity(
                    SystemResources.UserInSession.Username, // username of user in session 
                    meta2 + "'s list box has caused: " + meta1, // description of activity
                    "GRAPH ERROR"); // type of activity
            }

            public static void ExecuteError9()
            {
                // Inventory Datagrid IndexOutOfRangeException
                SystemResources.RecordActivity(
                    SystemResources.UserInSession.Username, // username of user in session 
                    "Inventory datagrid has ceased to function due to an out of range index exception", // description of activity
                    "INVENTORY ERROR"); // type of activity
            }

            public static void ExecuteError10()
            {
                // Inventory Datagrid InsufficientMemoryException
                SystemResources.RecordActivity(
                    SystemResources.UserInSession.Username, // username of user in session 
                    "Inventory datagrid has ceased to function due to insufficient memory exception", // description of activity
                    "INVENTORY ERROR"); // type of activity
            }

            public static void ExecuteError11()
            {
                // Inventory Datagrid OutOfMemoryException
                SystemResources.RecordActivity(
                    SystemResources.UserInSession.Username, // username of user in session 
                    "Inventory datagrid has ceased to function due to out of memory exception", // description of activity
                    "INVENTORY ERROR"); // type of activity
            }

            public static void ExecuteError12(String meta)
            {
                // Inventory Datagrid Exception
                SystemResources.RecordActivity(
                    SystemResources.UserInSession.Username, // username of user in session 
                    meta, // description of activity
                    "INVENTORY ERROR"); // type of activity
            }

            public static void ExecuteError13(String meta)
            {
                // Register New Product ListBox IndexOutOfRangeException
                SystemResources.RecordActivity(
                    SystemResources.UserInSession.Username, // username of user in session 
                    "Register new product form's" + meta + " list box is unable to display information due to out of range index exception", // description of activity
                    "PRODUCT ERROR"); // type of activity
            }

            public static void ExecuteError14(String meta)
            {
                // Register New Product ListBox InsufficientMemoryException
                SystemResources.RecordActivity(
                    SystemResources.UserInSession.Username, // username of user in session 
                    "Register new product form's" + meta + " list box is unable to display information due to insufficient memory exception", // description of activity
                    "PRODUCT ERROR"); // type of activity
            }

            public static void ExecuteError15(String meta)
            {
                // Register New Product ListBox OutOfMemoryException
                SystemResources.RecordActivity(
                    SystemResources.UserInSession.Username, // username of user in session 
                    "Register new product form's" + meta + " list box is unable to display information due to out of memory exception", // description of activity
                    "PRODUCT ERROR"); // type of activity
            }

            public static void ExecuteError16(String meta1, String meta2)
            {
                // Register New Product ListBox Exception
                SystemResources.RecordActivity(
                    SystemResources.UserInSession.Username, // username of user in session 
                    meta2 + " list box has caused: " + meta1, // description of activity
                    "PRODUCT ERROR"); // type of activity
            }
        }
    }
}
