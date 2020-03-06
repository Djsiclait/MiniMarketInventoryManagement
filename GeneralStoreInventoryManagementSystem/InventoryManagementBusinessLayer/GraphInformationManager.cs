using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Custom Library
using InventoryManagementBusinessLayer.Resources;
using InventoryManagementDataLayer.GraphData;
using InventoryManagementEntityLayer.GraphEssentials;

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

            /// <summary>
            /// This function fetches information to generate users' timesheet bubble chart
            /// </summary>
            /// <param name="username">Username of target user if opted for filtered search</param>
            /// <param name="newestDate">The newest date in the given time frame</param>
            /// <param name="oldestDate">The oldest date in the given time frame</param>
            /// <returns>A list of bubble point type class containing necessary information for charts</returns>
            public static List<BubblePoint> ConsultUserTimesheetBubbleChartInformation(String username, DateTime newestDate, DateTime oldestDate)
            {
                return GraphDataManager.ConsultUserTimesheetBubbleChartData(username, newestDate, oldestDate);
            }
            #endregion
        }
    }
}
