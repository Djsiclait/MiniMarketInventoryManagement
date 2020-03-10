using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Custom Library
using InventoryManagementEntityLayer.GraphEssentials;

namespace InventoryManagementDataLayer
{
    namespace GraphData
    {
        public static class GraphDataManager
        {
            /// <summary>
            /// This function fetches all registered usernames
            /// </summary>
            /// <param name="userRole">Access level of the user soliciting this information</param>
            /// <param name="username">Possible username if filtering is desired</param>
            /// <returns>A list of usernames according to the access level</returns>
            public static List<String> ConsultAllRegisteredUsernameData(String userRole, String username)
            {
                List<String> usernames = new List<string>();
                usernames.Add("ALL");

                SqlCommand cmd = new SqlCommand(
                        "SP_Fetch_All_Username",
                        DatabaseManager.ActiveSqlConnection)
                {
                    CommandType = CommandType.StoredProcedure
                };

                #region Paramaters
                cmd.Parameters.AddWithValue("@user_role", userRole);
                cmd.Parameters.AddWithValue("@username", username);
                #endregion

                SqlDataReader sqlDataReader;
                sqlDataReader = cmd.ExecuteReader();

                while (sqlDataReader.Read())
                    usernames.Add(sqlDataReader["fld_user_username"].ToString());

                DatabaseManager.DisconnectToDatabase();

                return usernames;
            }

            #region Timesheet Bubble Chart
            /// <summary>
            /// This function fetches data to generate users' timesheet bubble chart
            /// </summary>
            /// <param name="username">Username of target user if opted for filtered search</param>
            /// <param name="newestDate">The newest date in the given time frame</param>
            /// <param name="oldestDate">The oldest date in the given time frame</param>
            /// <returns>A list of bubble point type class containing necessary data for charts</returns>
            public static List<BubblePoint> ConsultUserTimesheetBubbleChartData(String username, DateTime newestDate, DateTime oldestDate)
            {
                List<BubblePoint> bubblePoints = new List<BubblePoint>();

                SqlCommand cmd = new SqlCommand(
                        "SP_Generate_Bubble_Chart_Components",
                        DatabaseManager.ActiveSqlConnection)
                {
                    CommandType = CommandType.StoredProcedure
                };

                #region Paramaters
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@newest_date", newestDate);
                cmd.Parameters.AddWithValue("@oldest_date", oldestDate);
                #endregion

                SqlDataReader sqlDataReader;
                sqlDataReader = cmd.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    BubblePoint bubble = new BubblePoint()
                    {
                        Username = sqlDataReader["fld_user_activity_username"].ToString(),
                        LogInDate = sqlDataReader["Log In Date"].ToString(),
                        LogInTime = sqlDataReader["Log In Time"].ToString(),
                        Seconds = FormatToInt(sqlDataReader["Seconds"].ToString())
                    };

                    bubblePoints.Add(bubble);
                }

                DatabaseManager.DisconnectToDatabase();

                return bubblePoints;
            }
            #endregion

            #region Sales Bar Chart
            /// <summary>
            /// This function fetches all neccessary data to generate the sales bar graph achieved by all users within a period of time  
            /// </summary>
            /// <param name="userRole">User's access level</param>
            /// <param name="newestDate">The newest date in the given time frame</param>
            /// <param name="oldestDate">The oldest date in the given time frame</param>
            /// <returns>A list of sales records for all users duering the specified period of time</returns>
            public static List<Sale> ConsultSalesBarChartData(String userRole, DateTime newestDate, DateTime oldestDate)
            {
                List<Sale> sales = new List<Sale>();

                SqlCommand cmd = new SqlCommand()
                {
                    CommandText = "SP_Generate_Total_Sales_Bar_Chart_Components",
                    Connection = DatabaseManager.ActiveSqlConnection,
                    CommandType = CommandType.StoredProcedure
                };

                #region Parameters
                cmd.Parameters.AddWithValue("@user_role", userRole);
                cmd.Parameters.AddWithValue("@newest_date", newestDate);
                cmd.Parameters.AddWithValue("@oldest_date", oldestDate);
                #endregion

                SqlDataReader sqlDataReader;
                sqlDataReader = cmd.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    Sale sale = new Sale()
                    {
                        Username = sqlDataReader["fld_sold_by"].ToString(),
                        NumberOfSales = FormatToInt(sqlDataReader["Sales"].ToString()),
                        Total = FormatToDecimal(sqlDataReader["Total"].ToString())
                    };

                    sales.Add(sale);
                }

                DatabaseManager.DisconnectToDatabase();

                return sales;
            }

            /// <summary>
            /// This function fetches all neccessary data to generate the sales bar graph achieved by one specific target user within a period of time 
            /// </summary>
            /// <param name="userRole">User's access level</param>
            /// <param name="username">Username of target user</param>
            /// <param name="newestDate">The newest date in the given time frame</param>
            /// <param name="oldestDate">The oldest date in the given time frame</param>
            /// <returns>A list of sales records for target user during the specified period of time</returns>
            public static List<Sale> ConsultUserSalesBarChartData(String userRole, String username, DateTime newestDate, DateTime oldestDate)
            {
                List<Sale> sales = new List<Sale>();

                SqlCommand cmd = new SqlCommand()
                {
                    CommandText = "SP_Generate_User_Total_Sales_Bar_Chart_Components",
                    Connection = DatabaseManager.ActiveSqlConnection,
                    CommandType = CommandType.StoredProcedure
                };

                #region Parameters
                cmd.Parameters.AddWithValue("@user_role", userRole);
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
                        TransactionDate = DateTime.Parse(sqlDataReader["Transaction Date"].ToString()),
                        NumberOfSales = FormatToInt(sqlDataReader["Sales"].ToString()),
                        Total = FormatToDecimal(sqlDataReader["Total"].ToString())
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
                int.TryParse(value, out int result);

                return result;
            }
            #endregion
        }
    }
}
