using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementDataLayer
{
    namespace GraphData
    {
        public static class GraphDataManager
        {
            #region Timesheet
            /// <summary>
            /// This function fetches all registered usernames
            /// </summary>
            /// <param name="userRole">Access level of the user soliciting this information</param>
            /// <returns>A list of usernames according to the access level</returns>
            public static List<String> ConsultAllRegisteredUsernameData(String userRole)
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
                #endregion

                SqlDataReader sqlDataReader;
                sqlDataReader = cmd.ExecuteReader();

                while (sqlDataReader.Read())
                    usernames.Add(sqlDataReader["fld_user_username"].ToString());

                DatabaseManager.DisconnectToDatabase();

                return usernames;
            }
            #endregion
        }
    }
}
