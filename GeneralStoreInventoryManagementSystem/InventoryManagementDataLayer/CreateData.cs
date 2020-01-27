using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

// Using Custom Library
using InventoryManagementEntityLayer;

namespace InventoryManagementDataLayer
{
    public static class CreateData
    {
        public static String CreateNewUserProfileData(UserProfile newUser)
        {
            SqlCommand cmd = new SqlCommand(
                    "SP_Create_New_User",
                    DatabaseManager.ActiveSqlConnection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@username", SqlDbType.VarChar, 50).Value = newUser.Username;
            cmd.Parameters.Add("@password", SqlDbType.VarChar, 30).Value = newUser.Password;
            cmd.Parameters.Add("@first_name", SqlDbType.VarChar, 100).Value = newUser.FirstName;
            cmd.Parameters.Add("@last_name", SqlDbType.VarChar, 100).Value = newUser.LastName;
            cmd.Parameters.Add("@role", SqlDbType.VarChar, 100).Value = newUser.Role;
            cmd.Parameters.Add("@creator", SqlDbType.VarChar, 50).Value = newUser.Creator;

            SqlParameter message = new SqlParameter("@message", SqlDbType.VarChar, 300);
            message.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(message);

            Int32 reply;
            reply = Convert.ToInt32(cmd.ExecuteNonQuery());

            return cmd.Parameters["@message"].Value.ToString();
        }
    }
}
