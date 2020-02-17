using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace InventoryManagementDataLayer
{
    public static class UserDataManager
    {
        /// <summary>
        /// This function changes a target user's system access level
        /// </summary>
        /// <param name="targetUser">Target username</param>
        /// <param name="newAccessLevel">New access level</param>
        public static void ChangeTargetUserAccessLevelData(String targetUser, String newAccessLevel)
        {
            // Generating query to execute the desired command
            SqlCommand cmd = new SqlCommand(
                    "SP_Change_User_Access_Level", // stored procedure to update the user's access level 
                    DatabaseManager.ActiveSqlConnection); // Opening an active connection with the database
            cmd.CommandType = CommandType.StoredProcedure; // confirming the command is a recognized stored procedure

            #region Parameters
            cmd.Parameters.Add("@target_user", SqlDbType.VarChar, 50).Value = targetUser; // supplying the target username to update the correct dataset
            cmd.Parameters.Add("@new_access_level", SqlDbType.VarChar, 100).Value = newAccessLevel; // supplying the new access level data
            #endregion

            // Executing command
            Int32 reply;
            reply = Convert.ToInt32(cmd.ExecuteNonQuery());

            DatabaseManager.DisconnectToDatabase(); // Closing the currect connection to the database
        }

        /// <summary>
        /// This function changes the target user's status
        /// </summary>
        /// <param name="targetUser">Target username</param>
        /// <param name="newStatus">New account status</param>
        public static void ChangeTargerUserStatusData(String targetUser, int newStatus)
        {
            // Generating query to execute the desired command
            SqlCommand cmd = new SqlCommand(
                    "SP_Change_User_Status", // stored procedure to update the user's status
                    DatabaseManager.ActiveSqlConnection); // Opening an active connection with the database
            cmd.CommandType = CommandType.StoredProcedure; // confirming the command is a recognized stored procedure

            #region Parameters
            cmd.Parameters.Add("@target_user", SqlDbType.VarChar, 50).Value = targetUser; // supplying the target username to update the correct dataset
            cmd.Parameters.Add("@new_status", SqlDbType.TinyInt).Value = newStatus; // supplying the new status data
            #endregion

            // Executing command
            Int32 reply;
            reply = Convert.ToInt32(cmd.ExecuteNonQuery());

            DatabaseManager.DisconnectToDatabase(); // Closing the currect connection to the database
        }
    }
}
