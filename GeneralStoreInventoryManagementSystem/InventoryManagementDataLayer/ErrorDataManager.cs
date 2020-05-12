using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


// Custom Library
using InventoryManagementEntityLayer.Error;

namespace InventoryManagementDataLayer
{
    namespace ErrorData
    {
        public static class ErrorDataManager
        {
            #region Consults
            /// <summary>
            /// THis function retrieves all registered errors 
            /// </summary>
            /// <param name="keyWord">Key word used to filter errors by code or username</param>
            /// <returns>A list of all registered errors</returns>
            public static List<Error> ConsultErrorListData(String keyWord)
            {
                List<Error> errors = new List<Error>();

                SqlCommand cmd = new SqlCommand()
                {
                    CommandText = "SP_Fetch_Error_Logs",
                    Connection = DatabaseManager.ActiveSqlConnection,
                    CommandType = CommandType.StoredProcedure,
                };

                #region Parameters
                cmd.Parameters.AddWithValue("@key_word", keyWord);
                #endregion

                SqlDataReader sqlDataReader;
                sqlDataReader = cmd.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    Error error = new Error() {
                        Code = sqlDataReader["fld_error_code"].ToString(),
                        Description = sqlDataReader["fld_error_description"].ToString(),
                        Username = sqlDataReader["fld_error_username"].ToString(),
                        Timestamp = DateTime.Parse(sqlDataReader["fld_error_timestamp"].ToString()), 
                    };

                    errors.Add(error);
                }

                // Closing connection with database
                DatabaseManager.DisconnectToDatabase();

                return errors;
            }
            #endregion

            #region Creates
            /// <summary>
            /// This function is in charge of registering all new error data generated during a session
            /// </summary>
            /// <param name="error">An error entity with all necessary data</param>
            public static void RegisterNewErrorData(Error error)
            {
                // Define which query command will be executed 
                SqlCommand cmd = new SqlCommand() {
                    CommandText = "SP_Register_New_Error",
                    Connection = DatabaseManager.ActiveSqlConnection,
                    CommandType = CommandType.StoredProcedure,
                };

                #region Parameters
                cmd.Parameters.AddWithValue("@code", error.Code);
                cmd.Parameters.AddWithValue("@description", error.Description);
                cmd.Parameters.AddWithValue("@username", error.Username);
                #endregion

                // executing the stored procedure
                Convert.ToInt32(cmd.ExecuteNonQuery());

                // Closing connection with database
                DatabaseManager.DisconnectToDatabase(); 
            }
            #endregion

            #region Updates
            // No update protocol at this time of development
            #endregion
        }
    }
}
