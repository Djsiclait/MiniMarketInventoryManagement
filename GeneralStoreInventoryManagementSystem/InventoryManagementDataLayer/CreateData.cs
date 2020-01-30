﻿using System;
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
        /// <summary>
        /// This function recieves a user profile object to insert its respective data into the database for prosperity
        /// </summary>
        /// <param name="newUser">The user object that stores the necessary data to create a new profile</param>
        /// <returns>A message that confirms or rejects the user profile creation process</returns>
        public static String CreateNewUserProfileData(UserProfile newUser)
        {
            // Define which query command will be executed 
            SqlCommand cmd = new SqlCommand(
                    "SP_Create_New_User", // Stored procedure dedicated to insert new data
                    DatabaseManager.ActiveSqlConnection); // requesting an open active connection to the database from the manager 
            cmd.CommandType = CommandType.StoredProcedure; // Confirming that the previous command is a recognized stored procedure within the database

            // Declaring the parameters required by the stored procedure to execute it's pre defined command
            cmd.Parameters.Add("@username", SqlDbType.VarChar, 50).Value = newUser.Username; // variable to define the username
            cmd.Parameters.Add("@password", SqlDbType.VarChar, 30).Value = newUser.Password; // defining the password
            cmd.Parameters.Add("@first_name", SqlDbType.VarChar, 100).Value = newUser.FirstName; // variable indicating the new user's first name
            cmd.Parameters.Add("@last_name", SqlDbType.VarChar, 100).Value = newUser.LastName; // variable indicating the new user's last name
            cmd.Parameters.Add("@role", SqlDbType.VarChar, 100).Value = newUser.Role; // defining the level of acces the new user is granted
            cmd.Parameters.Add("@creator", SqlDbType.VarChar, 50).Value = newUser.Creator; // variable to indicate the user that created this new profile

            // Declaring an output variable
            SqlParameter message = new SqlParameter("@message", SqlDbType.VarChar, 300); // defining the output message variable
            message.Direction = ParameterDirection.Output; // Confirming the output direction
            cmd.Parameters.Add(message); // Confirming the output direction

            Int32 reply;
            reply = Convert.ToInt32(cmd.ExecuteNonQuery()); // executing the stored procedure

            return cmd.Parameters["@message"].Value.ToString(); // returning the output message generated by the procedure
        }

        public static void RegisterNewUserActivityData(Activity activity)
        {
            SqlCommand cmd = new SqlCommand(
                    "SP_Register_New_Activity_Data",
                    DatabaseManager.ActiveSqlConnection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@username", SqlDbType.VarChar, 50).Value = activity.Username;
            cmd.Parameters.Add("@description", SqlDbType.VarChar, 300).Value = activity.Description;
            cmd.Parameters.Add("@type", SqlDbType.VarChar, 100).Value = activity.Type;

            Int32 reply;
            reply = Convert.ToInt32(cmd.ExecuteNonQuery());
        }
    }
}
