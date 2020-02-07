using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Custom Library
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

            InventoryManagementBusinessLayer.UpdateInformation.UpdateUserLastLoginInformation(userInSession.Username);

            RecordActivity(
                userInSession.Username,
                userInSession.Role + ", " + userInSession.Username + ", has successfully logged in",
                "LOG IN");
        }

        // Function used to end the session variable; must be executed once before logging out of every session 
        public static void EndUserSession()
        {
            RecordActivity(
                userInSession.Username,
                userInSession.Role + ", " + userInSession.Username + ", has successfully logged out",
                "LOG OUT");

            InventoryManagementBusinessLayer.UpdateInformation.UpdateUserLastLoginInformation(userInSession.Username);

            userInSession = null;
        }

        public static void RecordActivity(String username, String Description, String Type)
        {
            InventoryManagementBusinessLayer.CreateInformation.RegisterNewUserActivityInformation(new Activity(username, Description, Type));
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
