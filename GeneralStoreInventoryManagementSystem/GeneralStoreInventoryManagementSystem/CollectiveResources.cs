using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Custom Libraries
using InventoryManagementBusinessLayer;
using InventoryManagementEntityLayer;

namespace GeneralStoreInventoryManagementSystem
{
    public static class CollectiveResources
    {
        private static UserProfile userInSession;

        // Function used to instantiate the session variable; must be executed once before every session 
        public static void BeginUserSession(String username)
        {
            userInSession = InventoryManagementBusinessLayer.ConsultInformation.FetchUserInformationByUsername(username);
        }

        // Function used to end the session variable; must be executed once before logging out of every session 
        public static void EndUserSession()
        {
            userInSession = null;
        }

        // Getters and setters
        public static UserProfile UserInSession
        {
            get
            {
                return userInSession;
            }
        }
    }
}
