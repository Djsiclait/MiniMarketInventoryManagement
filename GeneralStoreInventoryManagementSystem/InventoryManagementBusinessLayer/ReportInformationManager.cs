using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Custom Library
using InventoryManagementDataLayer.ReportData;
using InventoryManagementEntityLayer.Timesheet;

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
        }
    }
}
