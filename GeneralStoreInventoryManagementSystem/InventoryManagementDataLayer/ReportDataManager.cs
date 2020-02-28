using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Custom Library
using InventoryManagementEntityLayer.Timesheet;
using InventoryManagementEntityLayer.Session;

namespace InventoryManagementDataLayer
{
    namespace ReportData
    {
        public static class ReportDataManager
        {
            #region Timesheets Logics
            /// <summary>
            /// This function fetches all the users' timesheet data between a specified time frame
            /// </summary>
            /// <param name="newestDate">Latest date in the required timeframe</param>
            /// <param name="oldestDate">Earliest date in the required timeframe</param>
            /// <returns>A list of user timesheets with each ones log ins statistics</returns>
            public static List<Timesheet> ConsultTimesheetSummaryData(DateTime newestDate, DateTime oldestDate)
            {
                List<Timesheet> timesheets = new List<Timesheet>();

                SqlCommand cmd = new SqlCommand(
                        "SP_Generate_User_Timesheet",
                        DatabaseManager.ActiveSqlConnection);
                cmd.CommandType = CommandType.StoredProcedure;

                #region Parameters
                cmd.Parameters.Add("@newest_date", SqlDbType.DateTime).Value = newestDate;
                cmd.Parameters.Add("@oldest_date", SqlDbType.DateTime).Value = oldestDate;
                #endregion

                SqlDataReader sqlDataReader;
                sqlDataReader = cmd.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    Timesheet sheet = new Timesheet();

                    sheet.Username = sqlDataReader["fld_user_activity_username"].ToString();
                    sheet.FullName = sqlDataReader["Name"].ToString();
                    sheet.NumberOfLogIns = FormatToInt(sqlDataReader["Number of Log Ins"].ToString());
                    sheet.AverageMinutesPerSession = FormatToDecimal(sqlDataReader["Average Minutes"].ToString());

                    timesheets.Add(sheet);
                }

                DatabaseManager.DisconnectToDatabase();

                return timesheets;
            }
            #endregion

            #region Session Log Logic
            /// <summary>
            /// This function requests the session log data of a chosen user, specifying a time frame
            /// </summary>
            /// <param name="username">Username of desired user</param>
            /// <param name="oldestDate">The oldest date in the given time frame</param>
            /// <param name="newestDate">The newest date in the given time frame</param>
            /// <returns>A list of the user's session log</returns>
            public static List<SessionLog> ConsultUserSessionLogData(String username, DateTime oldestDate, DateTime newestDate)
            {
                List<SessionLog> sessionLogs = new List<SessionLog>();

                SqlCommand cmd = new SqlCommand(
                        "SP_Generate_User_Session_Log",
                        DatabaseManager.ActiveSqlConnection);
                cmd.CommandType = CommandType.StoredProcedure;

                #region Parameters
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.Add("@newest_date", SqlDbType.DateTime).Value = newestDate;
                cmd.Parameters.Add("@oldest_date", SqlDbType.DateTime).Value = oldestDate;
                #endregion

                SqlDataReader sqlDataReader;
                sqlDataReader = cmd.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    SessionLog session = new SessionLog
                    {
                        LogIn = DateTime.Parse(sqlDataReader["Log In"].ToString()),
                        LogOut = DateTime.Parse(sqlDataReader["Log Out"].ToString()),
                        TotalSessionMinutes = FormatToDecimal(sqlDataReader["Minutes"].ToString())
                    };

                    sessionLogs.Add(session);
                }

                DatabaseManager.DisconnectToDatabase();

                return sessionLogs;
            }
            #endregion

            #region Auxiliary Functions
            /// <summary>
            /// Function to convert strings to decimals
            /// </summary>
            /// <param name="value">String value needed to be converted</param>
            /// <returns>A decimal equivalent of the provided string value</returns>
            private static decimal FormatToDecimal(String value)
            {
                decimal result;

                decimal.TryParse(value, out result);

                return result;
            }

            /// <summary>
            /// Function to convert strings to ints
            /// </summary>
            /// <param name="value">String value needed to be converted</param>
            /// <returns>An int equivalent of the provided string value</returns>
            private static int FormatToInt(String value)
            {
                int result;

                int.TryParse(value, out result);

                return result;
            }
            #endregion
        }
    }
}
