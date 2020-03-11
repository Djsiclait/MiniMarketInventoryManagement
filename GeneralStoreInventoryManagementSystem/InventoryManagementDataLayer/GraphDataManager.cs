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
                List<String> usernames = new List<string>(); // Initializing list to host usernames
                usernames.Add("ALL"); // adding "All" options to list 

                // Creating SQL querry to execute the correct command
                SqlCommand cmd = new SqlCommand()
                {
                    CommandText = "SP_Fetch_All_Username", // Designated stored procedure to execute
                    Connection = DatabaseManager.ActiveSqlConnection, // Establishing an active connection with the database
                    CommandType = CommandType.StoredProcedure // Confirmin querry is a recognized stored procedure in the database
                };

                #region Paramaters
                cmd.Parameters.AddWithValue("@user_role", userRole); // User's access level
                cmd.Parameters.AddWithValue("@username", username); // target username for filtered searches
                #endregion

                // Creating a data reader to fetch corresponding data
                SqlDataReader sqlDataReader;
                sqlDataReader = cmd.ExecuteReader(); // executing command and retreiving results

                // Reading through the result set of the command
                while (sqlDataReader.Read())
                    usernames.Add(sqlDataReader["fld_user_username"].ToString()); // adding fetched usernames to list

                DatabaseManager.DisconnectToDatabase(); // Closing the active connection to the database 

                return usernames; // returning list of registered usernames
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
                List<BubblePoint> bubblePoints = new List<BubblePoint>(); // Initializing list to host bubble points

                // Creating SQL querry to execute the correct command
                SqlCommand cmd = new SqlCommand() 
                { 
                    CommandText = "SP_Generate_Bubble_Chart_Components", // Designated stored procedure to execute
                    Connection = DatabaseManager.ActiveSqlConnection, // Establishing an active connection with the database
                    CommandType = CommandType.StoredProcedure // Confirmin querry is a recognized stored procedure in the database
                };

                #region Paramaters
                cmd.Parameters.AddWithValue("@username", username); // Target usename
                cmd.Parameters.AddWithValue("@newest_date", newestDate); // latest date in the desired time interval
                cmd.Parameters.AddWithValue("@oldest_date", oldestDate); // earliest date in the desired time interval
                #endregion

                // Creating a data reader to fetch corresponding data
                SqlDataReader sqlDataReader;
                sqlDataReader = cmd.ExecuteReader(); // executing command and retreiving results

                // Reading through the result set of the command
                while (sqlDataReader.Read())
                {
                    // Creating new bubble object to host corresponding data
                    BubblePoint bubble = new BubblePoint()
                    {
                        Username = sqlDataReader["fld_user_activity_username"].ToString(),
                        LogInDate = sqlDataReader["Log In Date"].ToString(),
                        LogInTime = sqlDataReader["Log In Time"].ToString(),
                        Seconds = FormatToInt(sqlDataReader["Seconds"].ToString())
                    };

                    bubblePoints.Add(bubble); // adding new bubble to the list
                }

                DatabaseManager.DisconnectToDatabase(); // Closing the active connection to the database 

                return bubblePoints; // returning list of bubble points
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
                List<Sale> sales = new List<Sale>(); // Initializing list to host sales points

                // Creating SQL querry to execute the correct command
                SqlCommand cmd = new SqlCommand()
                {
                    CommandText = "SP_Generate_Total_Sales_Bar_Chart_Components", // Designated stored procedure to execute
                    Connection = DatabaseManager.ActiveSqlConnection, // Establishing an active connection with the database
                    CommandType = CommandType.StoredProcedure // Confirmin querry is a recognized stored procedure in the database
                };

                #region Parameters
                cmd.Parameters.AddWithValue("@user_role", userRole); // User's access level
                cmd.Parameters.AddWithValue("@newest_date", newestDate); // latest date in the desired time interval
                cmd.Parameters.AddWithValue("@oldest_date", oldestDate); // earliest date in the desired time interval
                #endregion

                // Creating a data reader to fetch corresponding data
                SqlDataReader sqlDataReader;
                sqlDataReader = cmd.ExecuteReader(); // executing command and retreiving results

                // Reading through the result set of the command
                while (sqlDataReader.Read())
                {
                    // Creating new sale object to host data
                    Sale sale = new Sale()
                    {
                        Username = sqlDataReader["fld_sold_by"].ToString(),
                        NumberOfSales = FormatToInt(sqlDataReader["Sales"].ToString()),
                        Total = FormatToDecimal(sqlDataReader["Total"].ToString())
                    };

                    sales.Add(sale); // Adding new sale point to list
                }

                DatabaseManager.DisconnectToDatabase(); // Closing the active connection to the database 

                return sales; // returning list of sales point
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
                List<Sale> sales = new List<Sale>(); // Initializing list to host sales points

                // Creating SQL querry to execute the correct command
                SqlCommand cmd = new SqlCommand()
                {
                    CommandText = "SP_Generate_User_Total_Sales_Bar_Chart_Components", // Designated stored procedure to execute
                    Connection = DatabaseManager.ActiveSqlConnection, // Establishing an active connection with the database
                    CommandType = CommandType.StoredProcedure // Confirmin querry is a recognized stored procedure in the database
                };

                #region Parameters
                cmd.Parameters.AddWithValue("@user_role", userRole); // User's access level
                cmd.Parameters.AddWithValue("@username", username); // Username of target user
                cmd.Parameters.AddWithValue("@newest_date", newestDate); // latest date in the desired time interval
                cmd.Parameters.AddWithValue("@oldest_date", oldestDate); // earliest date in the desired time interval
                #endregion

                // Creating a data reader to fetch corresponding data
                SqlDataReader sqlDataReader;
                sqlDataReader = cmd.ExecuteReader(); // executing command and retreiving results

                // Reading through the result set of the command
                while (sqlDataReader.Read())
                {
                    // Creating new alternative sale object to host data
                    Sale sale = new Sale()
                    {
                        TransactionDate = DateTime.Parse(sqlDataReader["Transaction Date"].ToString()),
                        NumberOfSales = FormatToInt(sqlDataReader["Sales"].ToString()),
                        Total = FormatToDecimal(sqlDataReader["Total"].ToString())
                    };

                    sales.Add(sale); // Adding new sale point to list
                }

                DatabaseManager.DisconnectToDatabase(); // Closing the active connection to the database 

                return sales; // returning list of sales point
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
