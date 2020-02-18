using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

// Custom Library 
using InventoryManagementEntityLayer;

namespace InventoryManagementDataLayer
{
    public static class ActivityDataManager
    {
        #region Consults
        /// <summary>
        /// This function fetches the system and user activities registered in the system.
        /// Users are able to specify key words to filter searches and limit the resultset to the last 24 hours
        /// </summary>
        /// <param name="userPermission">User''s access level</param>
        /// <param name="keyWord">Key word to enable specific filtered searhs</param>
        /// <param name="last24Hours">Indicator to specify if searches should be limited to the last 24 hours</param>
        /// <returns>A list of registered activitiees based on the search paramaters</returns>
        public static List<Activity> ConsultActivityListData(String userPermission, String keyWord, bool last24Hours)
        {
            List<Activity> activities = new List<Activity>(); // List to host the resulting registered activities

            // Define which query command will be executed 
            SqlCommand cmd = new SqlCommand(
                    last24Hours ? "SP_Fetch_Last_24_Hours_Users_Activities" : "SP_Fetch_Users_Activities", // Stored procedure incharged of fetching required data 
                    DatabaseManager.ActiveSqlConnection); // requesting an open active connection to the database from the manager
            cmd.CommandType = CommandType.StoredProcedure; // Confirming that the previous command is a recognized stored procedure within the database

            #region Parameters
            // Declaring the parameters required by the stored procedure to execute it's pre defined command
            cmd.Parameters.Add("@user_permission", SqlDbType.VarChar, 100).Value = userPermission; // defining the user's access level
            cmd.Parameters.Add("@key_word", SqlDbType.VarChar, 100).Value = keyWord; // key word to filter the result set based on regular expressions
            #endregion

            // Creating port to database to import and read the resulting query; equivilente to how an sql cursor works 
            SqlDataReader sqlDataReader;
            sqlDataReader = cmd.ExecuteReader(); // Executing the corresponding stored procedure and saving the result into the reader

            // Running through the individual rows of the result set until done
            while (sqlDataReader.Read())
            {
                Activity activity = new Activity(); // Creating new activity 

                #region Assigning the corresponding values to their variables
                activity.Username = sqlDataReader["fld_user_activity_username"].ToString();
                activity.Description = sqlDataReader["fld_user_activity_description"].ToString();
                activity.Type = sqlDataReader["fld_user_activity_type"].ToString();
                activity.Timestamp = DateTime.Parse(sqlDataReader["fld_user_activity_timestamp"].ToString());
                #endregion

                activities.Add(activity); // Adding the new activity into the list
            }

            DatabaseManager.DisconnectToDatabase(); // Closing the active connection to the database

            return activities; // returning activities list
        }

        /// <summary>
        /// This function fetches all the activities of a specific username 
        /// </summary>
        /// <param name="userPermission">User's access level</param>
        /// <param name="username">Username to filter which activites are relevent</param>
        /// <param name="keyWord">Key word to enable specific filtered searhs</param>
        /// <returns>A list of registered activitiees of a singular user based on the search paramaters</returns>
        public static List<Activity> ConsultActivityListDataByUsername(String userPermission, String username, String keyWord)
        {
            List<Activity> activities = new List<Activity>(); // List to host the resulting registered activities

            // Define which query command will be executed 
            SqlCommand cmd = new SqlCommand(
                    "SP_Fetch_User_Activity_By_Username", // Stored procedure incharged of fetching required data 
                    DatabaseManager.ActiveSqlConnection); // requesting an open active connection to the database from the manager
            cmd.CommandType = CommandType.StoredProcedure; // Confirming that the previous command is a recognized stored procedure within the database

            #region Parameters
            // Declaring the parameters required by the stored procedure to execute it's pre defined command
            cmd.Parameters.Add("@user_permission", SqlDbType.VarChar, 100).Value = userPermission;// defining the user's access level
            cmd.Parameters.Add("@username", SqlDbType.VarChar, 50).Value = username; // Username to limit search
            cmd.Parameters.Add("@key_word", SqlDbType.VarChar, 100).Value = keyWord; // key word to filter the result set based on regular expressions
            #endregion

            // Creating port to database to import and read the resulting query; equivilente to how an sql cursor works 
            SqlDataReader sqlDataReader;
            sqlDataReader = cmd.ExecuteReader(); // Executing the corresponding stored procedure and saving the result into the reader

            // Running through the individual rows of the result set until done
            while (sqlDataReader.Read())
            {
                Activity activity = new Activity(); // Creating new activity

                #region Assigning the corresponding values to their variables
                activity.Description = sqlDataReader["fld_user_activity_description"].ToString();
                activity.Type = sqlDataReader["fld_user_activity_type"].ToString();
                activity.Timestamp = DateTime.Parse(sqlDataReader["fld_user_activity_timestamp"].ToString());
                #endregion

                activities.Add(activity); // Adding the new activity into the list
            }

            DatabaseManager.DisconnectToDatabase(); // Closing the active connection to the database

            return activities; // returning activities list
        }
        #endregion

        #region Creates
        /// <summary>
        /// This function receives an activity object to register a system or user activity
        /// </summary>
        /// <param name="activity">Activity object containing the assigned information for creation</param>
        public static void RegisterNewActivityData(Activity activity)
        {
            // Define which query command will be executed 
            SqlCommand cmd = new SqlCommand(
                    "SP_Register_New_Activity", // Stored procedure dedicated to insert new activity data
                    DatabaseManager.ActiveSqlConnection); // requesting an open active connection to the database from the manager 
            cmd.CommandType = CommandType.StoredProcedure; // Confirming that the previous command is a recognized stored procedure within the database

            #region Parameters
            // Declaring the parameters required by the stored procedure to execute it's pre defined command
            cmd.Parameters.Add("@username", SqlDbType.VarChar, 50).Value = activity.Username; // variable to define the username currently in session
            cmd.Parameters.Add("@description", SqlDbType.VarChar, 300).Value = activity.Description; // defining the description of the activity
            cmd.Parameters.Add("@type", SqlDbType.VarChar, 100).Value = activity.Type; // defining the type of activity
            #endregion

            Int32 reply;
            reply = Convert.ToInt32(cmd.ExecuteNonQuery()); // executing the stored procedure

            DatabaseManager.DisconnectToDatabase(); // Closing connection with database
        }
        #endregion

        #region Updates
        // No updates at this point
        #endregion
    }
}
