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
    public static class ConsultData
    {
        /// <summary>
        /// This function returns all products from the inventory, filtering the columns of data according to the user's role
        /// It also allows the use of specific key words to filter the inventory via loose regular expressions
        /// </summary>
        /// <param name="userPermission">User's role which defines his level of access to the data</param>
        /// <param name="keyWord">Key word to enable specific filtered searhs</param>
        /// <returns>a list of products registered with the system</returns>
        public static List<Product> FetchProductListData(String userPermission, String keyWord)
        {
            List<Product> inventory = new List<Product>(); // List to host the resulting products of the registred inventory

            // Define which query command will be executed 
            SqlCommand cmd = new SqlCommand(
                    "SP_Fetch_Product_List_Data", // Stored procedure incharged of fetching required data 
                    DatabaseManager.ActiveSqlConnection); // requesting an open active connection to the database from the manager 
            cmd.CommandType = CommandType.StoredProcedure; // Confirming that the previous command is a recognized stored procedure within the database

            // Declaring the parameters required by the stored procedure to execute it's pre defined command
            cmd.Parameters.Add("@user_permission", SqlDbType.VarChar, 100).Value = userPermission; // variable to verify the user's role
            cmd.Parameters.Add("@key_word", SqlDbType.VarChar, 300).Value = keyWord; // key word to filter the result set based on regular expressions

            // Creating port to database to import and read the resulting query; equivilente to how an sql cursor works 
            SqlDataReader sqlDataReader;
            sqlDataReader = cmd.ExecuteReader(); // Executing the corresponding stored procedure and saving the result into the reader

            // Running through the individual rows of the result set until done
            while (sqlDataReader.Read())
            {
                Product product = new Product(); // Creating a new product

                // Assigning the corresponding values to their variables
                product.Id = sqlDataReader["fld_product_id"].ToString();
                product.Key = sqlDataReader["fld_product_key"].ToString();
                product.Name = sqlDataReader["fld_product_name"].ToString();
                product.Brand = sqlDataReader["fld_brand_name"].ToString();
                product.Unit = sqlDataReader["fld_product_unit"].ToString();
                product.UnitPrice = FormatToFloat(sqlDataReader["fld_product_unit_price"].ToString());
                product.Quantity = FormatToInt(sqlDataReader["fld_product_quantity"].ToString());

                // Data exclusive to higher level access users
                if (userPermission != "User")
                {
                    product.Supplier = sqlDataReader["fld_supplier_name"].ToString();
                    product.UnitCost = FormatToFloat(sqlDataReader["fld_product_unit_cost"].ToString());
                    product.Discontinued = FormatToBoolean(sqlDataReader["fld_product_discontinued"].ToString());
                }

                inventory.Add(product); // Adding the new product to the inventory list
            }

            DatabaseManager.DisconnectToDatabase(); // Closing the active connection to the database

            return inventory; // returning the resulting inenvtory
        }

        /// <summary>
        /// This function fetches all data associated to a registered product 
        /// </summary>
        /// <param name="productId">product's internal system identification number</param>
        /// <returns>a product object with all extracted data for that specific product id</returns>
        public static Product FetchProductDataByID(String productId)
        {
            Product product = new Product(); // nuew product instance to save fethed data

            // Define which query command will be executed 
            SqlCommand cmd = new SqlCommand(
                    "SP_Fetch_Product_Information_By_ID", // Stored procedure incharged of fetching required data  
                    DatabaseManager.ActiveSqlConnection); // requesting an open active connection to the database from the manager 
            cmd.CommandType = CommandType.StoredProcedure; // Confirming that the previous command is a recognized stored procedure within the database

            // Declaring the parameters required by the stored procedure to execute it's pre defined command
            cmd.Parameters.Add("@product_id", SqlDbType.VarChar, 10).Value = productId; // variable that identifies the desired product to retreive its data

            // Creating port to database to import and read the resulting query; equivilente to how an sql cursor works 
            SqlDataReader sqlDataReader;
            sqlDataReader = cmd.ExecuteReader(); // Executing the corresponding stored procedure and saving the result into the reader

            // Running through the individual rows of the result set until done
            while (sqlDataReader.Read())
            {
                // Assigning the corresponding values to their variables
                product.Key = sqlDataReader["fld_product_key"].ToString();
                product.Name = sqlDataReader["fld_product_name"].ToString();
                product.Brand = sqlDataReader["fld_brand_name"].ToString();
                product.Supplier = sqlDataReader["fld_supplier_name"].ToString();
                product.Unit = sqlDataReader["fld_product_unit"].ToString();
                product.Category = sqlDataReader["fld_category_description"].ToString();
                product.Type = sqlDataReader["fld_type_description"].ToString();
                product.UnitCost = FormatToFloat(sqlDataReader["fld_product_unit_cost"].ToString());
                product.UnitPrice = FormatToFloat(sqlDataReader["fld_product_unit_price"].ToString());
                product.Quantity = FormatToInt(sqlDataReader["fld_product_quantity"].ToString());
                product.MinimumQuantity = FormatToInt(sqlDataReader["fld_product_minimum_quantity"].ToString());
                product.MaximumQuantity = FormatToInt(sqlDataReader["fld_product_maximum_quantity"].ToString());
                product.RegisteredBy = sqlDataReader["fld_product_registered_by"].ToString();
                product.RegistrationDate = DateTime.Parse(sqlDataReader["fld_product_registration_date"].ToString());
                product.ModifiedBy = sqlDataReader["fld_product_modified_by"].ToString();
                product.ModificationDate = DateTime.Parse(sqlDataReader["fld_product_modification_date"].ToString());
                product.Discontinued = FormatToBoolean(sqlDataReader["fld_product_discontinued"].ToString());
            }

            DatabaseManager.DisconnectToDatabase(); // Closing the active connection to the database

            return product; // returning the resulting product
        }

        /// <summary>
        /// This Function executes a query to check the availability of a username 
        /// </summary>
        /// <param name="username">requested username</param>
        /// <returns>true or false depending if the username exists or not</returns>
        public static bool CheckUsernameAvailability(String username)
        {
            // Define which query command will be executed 
            SqlCommand cmd = new SqlCommand(
                    "SP_Username_Exists", // Stored procedure incharged of fetching required data 
                    DatabaseManager.ActiveSqlConnection); // requesting an open active connection to the database from the manager 
            cmd.CommandType = CommandType.StoredProcedure; // Confirming that the previous command is a recognized stored procedure within the database

            // Declaring the parameters required by the stored procedure to execute it's pre defined command
            cmd.Parameters.Add("@username", SqlDbType.VarChar, 50).Value = username; // username requesting availability

            // Declaring an output variable
            SqlParameter result = new SqlParameter("@result", SqlDbType.Bit); // defining the output message variable
            result.Direction = ParameterDirection.Output; // Confirming the output direction
            cmd.Parameters.Add(result); // Confirming the output direction

            Int32 reply;
            reply = Convert.ToInt32(cmd.ExecuteNonQuery()); // executing the stored procedure

            // Given that the stored procedure only ask if the username exists, to answer the question of availability the result must be negated
            // Yes, the username exists = No, there is no availability
            // No, the username does not exists = Yes, there is availability
            return !FormatToBoolean(cmd.Parameters["@result"].Value.ToString()); 
        }

        public static List<UserProfile> FetchUserListData(String username, String userPermission, String keyWord)
        {
            List<UserProfile> userList = new List<UserProfile>();

            SqlCommand cmd = new SqlCommand(
                    "SP_Fetch_User_List_Data",
                    DatabaseManager.ActiveSqlConnection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@username", SqlDbType.VarChar, 50).Value = username;
            cmd.Parameters.Add("@user_permission", SqlDbType.VarChar, 100).Value = userPermission;
            cmd.Parameters.Add("@key_word", SqlDbType.VarChar, 100).Value = keyWord;

            SqlDataReader sqlDataReader;
            sqlDataReader = cmd.ExecuteReader();

            while (sqlDataReader.Read())
            {
                UserProfile user = new UserProfile();

                user.Username = sqlDataReader["fld_user_username"].ToString();
                user.FirstName = sqlDataReader["fld_user_first_name"].ToString();
                user.LastName = sqlDataReader["fld_user_last_name"].ToString();
                user.Role = sqlDataReader["fld_user_role"].ToString();
                user.Status = sqlDataReader["fld_user_status"].ToString(); // Not required to convert to int given the variable's getter ans setter already have internal conversion

                if (sqlDataReader["fld_user_last_login_timestamp"].ToString() != "")
                    user.LastLogin = DateTime.Parse(sqlDataReader["fld_user_last_login_timestamp"].ToString());

                userList.Add(user);
            }

            DatabaseManager.DisconnectToDatabase();

            return userList;
        }

        public static UserProfile FetchUserDataByUsername(String username)
        {
            UserProfile user = new UserProfile();

            SqlCommand cmd = new SqlCommand(
                    "SP_Fetch_User_Data_By_Username",
                    DatabaseManager.ActiveSqlConnection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@username", SqlDbType.VarChar, 50).Value = username;

            SqlDataReader sqlDataReader;
            sqlDataReader = cmd.ExecuteReader();

            while (sqlDataReader.Read())
            {
                user.Username = sqlDataReader["fld_user_username"].ToString();
                user.FirstName = sqlDataReader["fld_user_first_name"].ToString();
                user.LastName = sqlDataReader["fld_user_last_name"].ToString();
                user.Role = sqlDataReader["fld_user_role"].ToString();
                user.Status = sqlDataReader["fld_user_status"].ToString();
                user.Creator = sqlDataReader["fld_user_creator"].ToString();// Not required to convert to int given the variable's getter ans setter already have internal conversion
                user.RegistrationDate = DateTime.Parse(sqlDataReader["fld_user_registration_date"].ToString());

                if (sqlDataReader["fld_user_last_login_timestamp"].ToString() != "")
                    user.LastLogin = DateTime.Parse(sqlDataReader["fld_user_last_login_timestamp"].ToString());
            }

            DatabaseManager.DisconnectToDatabase();

            return user;
        }

        public static String ValidateUserCredentialsData(String username, String password)
        {
            SqlCommand cmd = new SqlCommand(
                    "SP_Validate_User_Credentials_Data",
                    DatabaseManager.ActiveSqlConnection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@username", SqlDbType.VarChar, 50).Value = username;
            cmd.Parameters.Add("@password", SqlDbType.VarChar, 30).Value = password;

            SqlParameter message = new SqlParameter("@message", SqlDbType.VarChar, 300);
            message.Direction = ParameterDirection.Output;

            cmd.Parameters.Add(message);

            Int32 reply;
            reply = Convert.ToInt32(cmd.ExecuteNonQuery());

            return cmd.Parameters["@message"].Value.ToString();
        }

        public static List<Activity> FetchActivityListData(String userPermission, String keyWord)
        {
            List<Activity> activities = new List<Activity>();

            SqlCommand cmd = new SqlCommand(
                    "SP_Fetch_Users_Activities_Data",
                    DatabaseManager.ActiveSqlConnection);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@user_permission", SqlDbType.VarChar, 100).Value = userPermission;
            cmd.Parameters.Add("@key_word", SqlDbType.VarChar, 100).Value = keyWord;

            SqlDataReader sqlDataReader;
            sqlDataReader = cmd.ExecuteReader();

            while (sqlDataReader.Read())
            {
                Activity activity = new Activity();

                activity.Username = sqlDataReader["fld_user_activity_username"].ToString();
                activity.Description = sqlDataReader["fld_user_activity_description"].ToString();
                activity.Type = sqlDataReader["fld_user_activity_type"].ToString();
                activity.Timestamp = DateTime.Parse(sqlDataReader["fld_user_activity_timestamp"].ToString()); 

                activities.Add(activity);
            }

            DatabaseManager.DisconnectToDatabase();

            return activities;
        }

        // Axiliary Functions
        // Function to convert strings to floats
        private static float FormatToFloat(String value)
        {
            float result;

            float.TryParse(value, out result);

            return result;
        }

        // Function to convert strings to ints
        private static int FormatToInt(String value)
        {
            int result;

            int.TryParse(value, out result);

            return result;
        }

        // Function to convert strings to booleans
        private static Boolean FormatToBoolean(String value)
        {
            Boolean result;

            Boolean.TryParse(value, out result);

            return result;
        }

        // Function to convert strings to longs
        private static long FormatToLong(String value)
        {
            long result;

            long.TryParse(value, out result);

            return result;
        }
    }
}
