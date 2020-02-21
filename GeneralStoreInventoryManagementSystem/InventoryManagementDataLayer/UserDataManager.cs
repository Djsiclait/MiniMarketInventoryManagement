﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

// Custom Library
using InventoryManagementEntityLayer.UserProfile;

namespace InventoryManagementDataLayer
{
    namespace UserData
    {
        public static class UserDataManager
        {
            #region Consults
            /// <summary>
            /// This funtion validates user's credentials data
            /// </summary>
            /// <param name="username">Username requesting validation</param>
            /// <param name="password">Password</param>
            /// <returns>A message that confirms or denies the validation process</returns>
            public static String ConsultUserCredentialsValidationData(String username, String password)
            {
                // Define which query command will be executed 
                SqlCommand cmd = new SqlCommand(
                        "SP_Validate_User_Credentials", // Stored procedure incharged of validating given data 
                        DatabaseManager.ActiveSqlConnection); // requesting an open active connection to the database from the manager 
                cmd.CommandType = CommandType.StoredProcedure; // Confirming that the previous command is a recognized stored procedure within the database

                #region Parameters
                // Declaring the parameters required by the stored procedure to execute it's pre defined command
                cmd.Parameters.Add("@username", SqlDbType.VarChar, 50).Value = username; // defining the username requesting validation
                cmd.Parameters.Add("@password", SqlDbType.VarChar, 30).Value = password; // defining the password credentials

                // Declaring an output variable
                SqlParameter message = new SqlParameter("@message", SqlDbType.VarChar, 300); // defining the output message variable
                message.Direction = ParameterDirection.Output; // Confirming the output direction
                cmd.Parameters.Add(message); // Adding output paramater to the command
                #endregion

                Int32 reply;
                reply = Convert.ToInt32(cmd.ExecuteNonQuery()); // executing the stored procedure

                // closing the opened database connection is ignored given an expected output, @message, will be used

                return cmd.Parameters["@message"].Value.ToString(); // returning the output message generated by the procedure
            }

            /// <summary>
            /// This function fetches the data of a specified user
            /// </summary>
            /// <param name="username">Target username</param>
            /// <returns>The user profile of the requested username</returns>
            public static UserProfile ConsultUserDataByUsername(String username)
            {
                UserProfile user = new UserProfile();

                // Define which query command will be executed 
                SqlCommand cmd = new SqlCommand(
                        "SP_Fetch_User_Data_By_Username", // Stored procedure incharged of fetching required data 
                        DatabaseManager.ActiveSqlConnection); // requesting an open active connection to the database from the manager 
                cmd.CommandType = CommandType.StoredProcedure; // Confirming that the previous command is a recognized stored procedure within the database

                #region Parameters
                // Declaring the parameters required by the stored procedure to execute it's pre defined command
                cmd.Parameters.Add("@username", SqlDbType.VarChar, 50).Value = username; // Target username
                #endregion

                // Creating port to database to import and read the resulting query; equivilente to how an sql cursor works 
                SqlDataReader sqlDataReader;
                sqlDataReader = cmd.ExecuteReader(); // Executing the corresponding stored procedure and saving the result into the reader

                // Running through the individual rows of the result set until done
                while (sqlDataReader.Read())
                {
                    #region Assigning the corresponding values to their variables
                    user.Username = sqlDataReader["fld_user_username"].ToString();
                    user.FirstName = sqlDataReader["fld_user_first_name"].ToString();
                    user.LastName = sqlDataReader["fld_user_last_name"].ToString();
                    user.Role = sqlDataReader["fld_user_role"].ToString();
                    user.Status = sqlDataReader["fld_user_status"].ToString();
                    user.Creator = sqlDataReader["fld_user_creator"].ToString();// Not required to convert to int given the variable's getter ans setter already have internal conversion
                    user.RegistrationDate = DateTime.Parse(sqlDataReader["fld_user_registration_date"].ToString());

                    // Verifying for null or empty dates to prevent errors
                    if (sqlDataReader["fld_user_last_login_timestamp"].ToString() != "")
                        user.LastLogin = DateTime.Parse(sqlDataReader["fld_user_last_login_timestamp"].ToString());
                    #endregion
                }

                DatabaseManager.DisconnectToDatabase(); // Closing the active connection to the database

                return user; // Returning requested user profile
            }

            /// <summary>
            /// This function fetches the registered data of the user list given a search filter
            /// </summary>
            /// <param name="username">Username currently in session to exclude him form the list</param>
            /// <param name="userPermission">Username's access level</param>
            /// <param name="keyWord">Key word to enable specific filtered searhs</param>
            /// <returns>A list os user profiles</returns>
            public static List<UserProfile> ConsultUserListData(String username, String userPermission, String keyWord)
            {
                List<UserProfile> userList = new List<UserProfile>(); // List to host the resulting users

                // Define which query command will be executed 
                SqlCommand cmd = new SqlCommand(
                        "SP_Fetch_User_List", // Stored procedure incharged of fetching required data 
                        DatabaseManager.ActiveSqlConnection); // requesting an open active connection to the database from the manager 
                cmd.CommandType = CommandType.StoredProcedure; // Confirming that the previous command is a recognized stored procedure within the database

                #region Parameters
                // Declaring the parameters required by the stored procedure to execute it's pre defined command
                cmd.Parameters.Add("@username", SqlDbType.VarChar, 50).Value = username; // defining the username to exclude in the dataset
                cmd.Parameters.Add("@user_permission", SqlDbType.VarChar, 100).Value = userPermission; // user's access level
                cmd.Parameters.Add("@key_word", SqlDbType.VarChar, 100).Value = keyWord; // key word to filter the result set based on regular expressions 
                #endregion

                // Creating port to database to import and read the resulting query; equivilente to how an sql cursor works 
                SqlDataReader sqlDataReader;
                sqlDataReader = cmd.ExecuteReader(); // Executing the corresponding stored procedure and saving the result into the reader

                // Running through the individual rows of the result set until done
                while (sqlDataReader.Read())
                {
                    UserProfile user = new UserProfile(); // Creating new user profile

                    #region Assigning the corresponding values to their variables
                    user.Username = sqlDataReader["fld_user_username"].ToString();
                    user.FirstName = sqlDataReader["fld_user_first_name"].ToString();
                    user.LastName = sqlDataReader["fld_user_last_name"].ToString();
                    user.Role = sqlDataReader["fld_user_role"].ToString();
                    user.Status = sqlDataReader["fld_user_status"].ToString(); // Not required to convert to int given the variable's getter ans setter already have internal conversion

                    // Verifying for null or empty dates to prevent errors
                    if (sqlDataReader["fld_user_last_login_timestamp"].ToString() != "")
                        user.LastLogin = DateTime.Parse(sqlDataReader["fld_user_last_login_timestamp"].ToString());
                    #endregion

                    userList.Add(user); // Adding the new user profile
                }

                DatabaseManager.DisconnectToDatabase(); // Closing the active connection to the database

                return userList; // returning the list of users
            }

            /// <summary>
            /// This Function executes a query to check the availability of a username 
            /// </summary>
            /// <param name="username">requested username</param>
            /// <returns>true or false depending if the username exists or not</returns>
            public static bool ConsultUsernameAvailability(String username)
            {
                // Define which query command will be executed 
                SqlCommand cmd = new SqlCommand(
                        "SP_Username_Exists", // Stored procedure incharged of fetching required data 
                        DatabaseManager.ActiveSqlConnection); // requesting an open active connection to the database from the manager 
                cmd.CommandType = CommandType.StoredProcedure; // Confirming that the previous command is a recognized stored procedure within the database

                #region Parameters
                // Declaring the parameters required by the stored procedure to execute it's pre defined command
                cmd.Parameters.Add("@username", SqlDbType.VarChar, 50).Value = username; // username requesting availability

                // Declaring an output variable
                SqlParameter result = new SqlParameter("@result", SqlDbType.Bit); // defining the output message variable
                result.Direction = ParameterDirection.Output; // Confirming the output direction
                cmd.Parameters.Add(result); // Confirming the output direction
                #endregion

                Int32 reply;
                reply = Convert.ToInt32(cmd.ExecuteNonQuery()); // executing the stored procedure

                // Given that the stored procedure only ask if the username exists, to answer the question of availability the result must be negated
                // Yes, the username exists = No, there is no availability
                // No, the username does not exists = Yes, there is availability
                return !FormatToBoolean(cmd.Parameters["@result"].Value.ToString());
            }
            #endregion

            #region Creates
            /// <summary>
            /// This function receives a user profile object to insert its respective data into the database for prosperity
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

                #region Parameters
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
                cmd.Parameters.Add(message); // Adding output paramater to the command
                #endregion

                Int32 reply;
                reply = Convert.ToInt32(cmd.ExecuteNonQuery()); // executing the stored procedure

                // closing the opened database connection is ignored given an expected output, @message, will be used

                return cmd.Parameters["@message"].Value.ToString(); // returning the output message generated by the procedure
            }
            #endregion

            #region Updates
            /// <summary>
            /// This function changes a target user's system access level
            /// </summary>
            /// <param name="targetUser">Target username</param>
            /// <param name="newAccessLevel">New access level</param>
            public static void UpdateTargetUserAccessLevelData(String targetUser, String newAccessLevel)
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
            public static void UpdateTargerUserStatusData(String targetUser, int newStatus)
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

            /// <summary>
            /// This function registred the last timestamp a user was loggef inot the system
            /// </summary>
            /// <param name="username">Username currently in session</param>
            public static void UpdateUserLastLoginData(String username)
            {
                // Generating query to execute the desired command
                SqlCommand cmd = new SqlCommand(
                        "SP_Register_Last_Login", // stored procedure to update the user's last login 
                        DatabaseManager.ActiveSqlConnection); // Opening an active connection with the database
                cmd.CommandType = CommandType.StoredProcedure; // confirming the command is a recognized stored procedure

                #region Parameters
                cmd.Parameters.Add("@username", SqlDbType.VarChar, 50).Value = username; // supplying the username to update the correct dataset
                #endregion

                // Executing command
                Int32 reply;
                reply = Convert.ToInt32(cmd.ExecuteNonQuery());

                DatabaseManager.DisconnectToDatabase(); // Closing the currect connection to the database
            }

            /// <summary>
            /// This function changes a user's password information
            /// </summary>
            /// <param name="username">Username</param>
            /// <param name="newPassword">New password</param>
            public static void UpdateUserPasswordData(String username, String newPassword)
            {
                // Generating query to execute the desired command
                SqlCommand cmd = new SqlCommand(
                        "SP_Change_User_Password", // stored procedure to update the user's password 
                        DatabaseManager.ActiveSqlConnection); // Opening an active connection with the database
                cmd.CommandType = CommandType.StoredProcedure; // confirming the command is a recognized stored procedure

                #region Parameters
                cmd.Parameters.Add("@username", SqlDbType.VarChar, 50).Value = username; // supplying the username to update the correct dataset
                cmd.Parameters.Add("@new_password", SqlDbType.VarChar, 30).Value = newPassword; // supplying the new password data
                #endregion

                // Executing command
                Int32 reply;
                reply = Convert.ToInt32(cmd.ExecuteNonQuery());

                DatabaseManager.DisconnectToDatabase(); // Closing the currect connection to the database
            }
            #endregion

            #region Auxiliary Functions
            /// <summary>
            /// Function to convert strings to booleans
            /// </summary>
            /// <param name="value">String value needed to be converted</param>
            /// <returns>A boolean equivalent of the provided string value</returns>
            private static Boolean FormatToBoolean(String value)
            {
                Boolean result;

                Boolean.TryParse(value, out result);

                return result;
            }
            #endregion
        }
    }
}
