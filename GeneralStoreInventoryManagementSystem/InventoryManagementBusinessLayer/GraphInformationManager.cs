using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Custom Library
using InventoryManagementBusinessLayer.Resources;
using InventoryManagementDataLayer.GraphData;

namespace InventoryManagementBusinessLayer
{
    namespace GraphInformation
    {
        public static class GraphInformationManager
        {
            #region Timesheet
            /// <summary>
            /// This function fetches all registered usernames
            /// </summary>
            /// <param name="username">Possible username if filtering is desired</param>
            /// <returns>A list of usernames according to the access level</returns>
            public static List<String> ConsultAllRegisteredUsernameInformation(String username)
            {
                return GraphDataManager.ConsultAllRegisteredUsernameData(SystemResources.UserInSession.Role, username);
            }
            #endregion
        }
    }
}
