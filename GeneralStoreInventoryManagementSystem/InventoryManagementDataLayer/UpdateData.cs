using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace InventoryManagementDataLayer
{
    public static class UpdateData
    {
        public static void UpdateUserLastLoginData(String username)
        {
            SqlCommand cmd = new SqlCommand(
                    "SP_Register_Last_Login_Data",
                    DatabaseManager.ActiveSqlConnection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@username", SqlDbType.VarChar, 50).Value = username;

            Int32 reply;
            reply = Convert.ToInt32(cmd.ExecuteNonQuery());
        }

    }
}
