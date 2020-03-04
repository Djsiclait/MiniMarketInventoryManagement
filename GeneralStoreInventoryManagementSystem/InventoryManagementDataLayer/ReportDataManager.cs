using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Custom Library
using InventoryManagementEntityLayer.Activity;
using InventoryManagementEntityLayer.ReportEssentials;
using InventoryManagementEntityLayer.Sale;

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

            /// <summary>
            /// This function fetches all user activities registered during a user's session
            /// </summary>
            /// <param name="username">Username of the target user</param>
            /// <param name="sessionStart">Log in time of the session</param>
            /// <param name="sessionEnd">Log out time of the session</param>
            /// <returns>A list of all activities generated durring the given time interval</returns>
            public static List<Activity> ConsultUserActivitiesDuringSessionData(String username, DateTime sessionStart, DateTime sessionEnd)
            {
                List<Activity> activities = new List<Activity>();

                SqlCommand cmd = new SqlCommand(
                        "SP_Fetch_Activities_For_Session",
                        DatabaseManager.ActiveSqlConnection);
                cmd.CommandType = CommandType.StoredProcedure;

                #region Parameters
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@session_start", sessionStart);
                cmd.Parameters.AddWithValue("@session_end", sessionEnd);
                #endregion

                SqlDataReader sqlDataReader;
                sqlDataReader = cmd.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    Activity activity = new Activity
                    {
                        Description = sqlDataReader["fld_user_activity_description"].ToString(),
                        Type = sqlDataReader["fld_user_activity_type"].ToString(),
                        Timestamp = DateTime.Parse(sqlDataReader["fld_user_activity_timestamp"].ToString())
                    };

                    activities.Add(activity);
                }

                DatabaseManager.DisconnectToDatabase();

                return activities;
            }
            #endregion

            #region Sales Records Logic
            /// <summary>
            /// This function fetches the sales records of every user for a specific time frame
            /// </summary>
            /// <param name="oldestDate">The oldest date in the given time frame</param>
            /// <param name="newestDate">The newest date in the given time frame</param>
            /// <returns> A list of the sales record for chosen time interval</returns>
            public static List<SalesRecord> ConsultUsersSalesRecordsData(DateTime oldestDate, DateTime newestDate)
            {
                List<SalesRecord> salesRecords = new List<SalesRecord>();

                SqlCommand cmd = new SqlCommand(
                        "SP_Generate_Users_Sales_Records",
                        DatabaseManager.ActiveSqlConnection)
                {
                    CommandType = CommandType.StoredProcedure
                };

                #region Parameters
                cmd.Parameters.AddWithValue("@newest_date", newestDate);
                cmd.Parameters.AddWithValue("@oldest_date", oldestDate);
                #endregion

                SqlDataReader sqlDataReader;
                sqlDataReader = cmd.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    SalesRecord salesRecord = new SalesRecord()
                    {
                        Username = sqlDataReader["fld_sold_by"].ToString(),
                        Returns = FormatToInt(sqlDataReader["Returns"].ToString()),
                        ReturnsTotal = FormatToDecimal(sqlDataReader["Returns Total"].ToString()),
                        Sales = FormatToInt(sqlDataReader["Sales"].ToString()),
                        SalesTotal = FormatToDecimal(sqlDataReader["Sales Total"].ToString())
                    };

                    salesRecords.Add(salesRecord);
                }

                DatabaseManager.DisconnectToDatabase();

                return salesRecords;
            }

            /// <summary>
            /// This function fetches a all sales made by a target user durring a specified time frame
            /// </summary>
            /// <param name="username">Username of target user</param>
            /// <param name="oldestDate">The oldest date in the given time frame</param>
            /// <param name="newestDate">The newest date in the given time frame</param>
            /// <returns>A list of all sales made by a user during a given time period</returns>
            public static List<Sale> ConsultSalesMadeByUserData(String username, DateTime oldestDate, DateTime newestDate)
            {
                List<Sale> sales = new List<Sale>();

                SqlCommand cmd = new SqlCommand(
                        "SP_Fetch_Sales_Made_By_User",
                        DatabaseManager.ActiveSqlConnection)
                {
                    CommandType = CommandType.StoredProcedure
                };

                #region Parameters
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@newest_date", newestDate);
                cmd.Parameters.AddWithValue("@oldest_date", oldestDate);
                #endregion

                SqlDataReader sqlDataReader;
                sqlDataReader = cmd.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    Sale sale = new Sale()
                    {
                        Id = sqlDataReader["fld_sale_id"].ToString(),
                        TransactionDate = DateTime.Parse(sqlDataReader["fld_sale_date"].ToString()),
                        NumberItems = FormatToInt(sqlDataReader["fld_sale_quantity_items"].ToString()),
                        Total = FormatToDecimal(sqlDataReader["fld_sale_total"].ToString()),
                        Parent = sqlDataReader["fld_sale_parent"].ToString()
                    };

                    sales.Add(sale);
                }

                DatabaseManager.DisconnectToDatabase();

                return sales;
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
