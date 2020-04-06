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
        }
    }
}
