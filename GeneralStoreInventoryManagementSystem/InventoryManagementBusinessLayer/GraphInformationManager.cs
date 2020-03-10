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
            /// <summary>
            /// This function fetches all registered usernames
            /// </summary>
            /// <param name="username">Possible username if filtering is desired</param>
            /// <returns>A list of usernames according to the access level</returns>
            public static List<String> ConsultAllRegisteredUsernameInformation(String username)
            {
                return GraphDataManager.ConsultAllRegisteredUsernameData(SystemResources.UserInSession.Role, username);
            }

            #region Timesheet Bubble Chart
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

            #region Sales Bar Graph 
            /// <summary>
            /// This function fetches all neccessary information to generate the sales bar graph achieved buy all users within a peiod of time  
            /// </summary>
            /// <param name="userRole">User's access level</param>
            /// <param name="newestDate">The newest date in the given time frame</param>
            /// <param name="oldestDate">The oldest date in the given time frame</param>
            /// <returns>A list of sales records for all users duering the specified period of time</returns>
            public static List<Sale> ConsultSalesBarChartInformation(DateTime newestDate, DateTime oldestDate)
            {
                return GraphDataManager.ConsultSalesBarChartData(SystemResources.UserInSession.Role, newestDate, oldestDate);
            }
            #endregion
        }
    }
}
