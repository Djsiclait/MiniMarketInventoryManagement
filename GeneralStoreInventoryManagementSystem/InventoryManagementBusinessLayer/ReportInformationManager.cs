using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Custom Library
using InventoryManagementDataLayer.ReportData;
using InventoryManagementEntityLayer.Timesheet;
using InventoryManagementEntityLayer.Session;

namespace InventoryManagementBusinessLayer
{
    namespace ReportInformation
    {
        public class ReportInformationManager
        {
            #region Timesheets Logic
            /// <summary>
            /// This function fetches all the users' timesheet between a specified time frame
            /// </summary>
            /// <param name="newestDate">Latest date in the required timeframe</param>
            /// <param name="oldestDate">Earliest date in the required timeframe</param>
            /// <returns>A list of user timesheets with each ones log ins statistics</returns>
            public static List<Timesheet> ConsultTimesheetSummaryInformation(DateTime newestDate, DateTime oldestDate)
            {
                return ReportDataManager.ConsultTimesheetSummaryData(newestDate, oldestDate);
            }
            #endregion

            #region Session Log Logic
            /// <summary>
            /// This function requests the session log information of a chosen user, specifying a time frame
            /// </summary>
            /// <param name="username">Username of desired user</param>
            /// <param name="oldestDate">The oldest date in the given time frame</param>
            /// <param name="newestDate">The newest date in the given time frame</param>
            /// <returns>A list of the user's session log</returns>
            public static List<SessionLog> ConsultUserSessionLogInformation(String username, DateTime oldestDate, DateTime newestDate)
            {
                return ReportDataManager.ConsultUserSessionLogData(username, oldestDate, newestDate);
            }
            #endregion
        }
    }
}
