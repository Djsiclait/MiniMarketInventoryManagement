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
            #endregion

            #region Creates
            public static void RegisterNewErrorData(Error error)
            {
                // Define which query command will be executed 
                SqlCommand cmd = new SqlCommand() {
                    CommandText = "SP_Register_New_Error",
                    Connection = DatabaseManager.ActiveSqlConnection,
                    CommandType = CommandType.StoredProcedure,
                };
            }
            #endregion

            #region Updates
            // No update protocol at this time of development
            #endregion
        }
    }
}
