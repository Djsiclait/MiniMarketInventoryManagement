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

        public static void ChangeUserPasswordData(String username, String newPassword)
        {
            SqlCommand cmd = new SqlCommand(
                    "SP_Change_User_Password",
                    DatabaseManager.ActiveSqlConnection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@username", SqlDbType.VarChar, 50).Value = username;
            cmd.Parameters.Add("@new_password", SqlDbType.VarChar, 30).Value = newPassword;

            Int32 reply;
            reply = Convert.ToInt32(cmd.ExecuteNonQuery());
        }

        public static void ChangeTargetUserAccessLevelData(String targetUser, String newAccessLevel)
        {
            SqlCommand cmd = new SqlCommand(
                    "SP_Change_User_Access_Level",
                    DatabaseManager.ActiveSqlConnection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@target_user", SqlDbType.VarChar, 50).Value = targetUser;
            cmd.Parameters.Add("@new_access_level", SqlDbType.VarChar, 100).Value = newAccessLevel;

            Int32 reply;
            reply = Convert.ToInt32(cmd.ExecuteNonQuery());
        }

        public static void ChangeTargerUserStatusData(String targetUser, int newStatus)
        {
            SqlCommand cmd = new SqlCommand(
                    "SP_Change_User_Status",
                    DatabaseManager.ActiveSqlConnection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@target_user", SqlDbType.VarChar, 50).Value = targetUser;
            cmd.Parameters.Add("@new_status", SqlDbType.TinyInt).Value = newStatus;

            Int32 reply;
            reply = Convert.ToInt32(cmd.ExecuteNonQuery());
        }

    }
}
