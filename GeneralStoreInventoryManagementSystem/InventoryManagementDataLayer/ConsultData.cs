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

        /// <summary>
        /// This function fetches the system and user activities registered in the system.
        /// Users are able to specify key words to filter searches and limit the resultset to the last 24 hours
        /// </summary>
        /// <param name="userPermission">User''s access level</param>
        /// <param name="keyWord">Key word to enable specific filtered searhs</param>
        /// <param name="last24Hours">Indicator to specify if searches should be limited to the last 24 hours</param>
        /// <returns>A list of registered activitiees based on the search paramaters</returns>
        public static List<Activity> FetchActivityListData(String userPermission, String keyWord, bool last24Hours)
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
        public static List<Activity> FetchActivityListDataByUsername(String userPermission, String username, String keyWord)
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

        /// <summary>
        /// This function retreives the dataset of registered brand names
        /// </summary>
        /// <param name="keyWord">Key word to enable specific filtered searhs</param>
        /// <returns>A list of all registered brand names</returns>
        public static List<String> FetchBrandListData(String keyWord)
        {
            List<String> brands = new List<String>(); // creating list to host registered brand names
            brands.Add("<None>"); // adding the default value for products that are not associated with a brand

            // Define which query command will be executed 
            SqlCommand cmd = new SqlCommand(
                    "SP_Fetch_Registered_Brand_Names", // Stored procedure incharged of fetching required data
                    DatabaseManager.ActiveSqlConnection); // requesting an open active connection to the database from the manager
            cmd.CommandType = CommandType.StoredProcedure; // Confirming that the previous command is a recognized stored procedure within the database

            #region Parameters
            // Declaring the parameters required by the stored procedure to execute it's pre defined command
            cmd.Parameters.Add("@key_word", SqlDbType.VarChar, 100).Value = keyWord; // key word to filter the result set based on regular expressions
            #endregion

            // Creating port to database to import and read the resulting query; equivilente to how an sql cursor works 
            SqlDataReader sqlDataReader;
            sqlDataReader = cmd.ExecuteReader(); // Executing the corresponding stored procedure and saving the result into the reader

            // Running through the individual rows of the result set until done
            while (sqlDataReader.Read())
            {
                String brandName; // Creating brand name class with string given this function doesn't use the brand object rather just the name of the brands

                #region Assigning the corresponding values to their variables
                brandName = sqlDataReader["fld_brand_name"].ToString();
                #endregion

                brands.Add(brandName); // adding brand name to list
            }

            DatabaseManager.DisconnectToDatabase(); // Closing the active connection to the database

            return brands; // returning the brand name list
        }

        /// <summary>
        /// This fucntion fetches the category names data
        /// </summary>
        /// <returns>A list of registered category names</returns>
        public static List<String> FetchCategoryComboBoxData()
        {
            List<String> categories = new List<string>(); // creating list to host registered brand names

            // Define which query command will be executed 
            SqlCommand cmd = new SqlCommand(
                    "SP_Fetch_Product_Category", // Stored procedure incharged of fetching required data
                    DatabaseManager.ActiveSqlConnection); // requesting an open active connection to the database from the manager
            cmd.CommandType = CommandType.StoredProcedure; // Confirming that the previous command is a recognized stored procedure within the database

            // Creating port to database to import and read the resulting query; equivilente to how an sql cursor works
            SqlDataReader sqlDataReader;
            sqlDataReader = cmd.ExecuteReader(); // Executing the corresponding stored procedure and saving the result into the reader

            // Running through the individual rows of the result set until done
            while (sqlDataReader.Read())
            {
                // Assigning the corresponding values to their variables
                String categoryName = sqlDataReader["fld_category_description"].ToString();

                categories.Add(categoryName); // adding category name to list
            }

            DatabaseManager.DisconnectToDatabase(); // Closing the active connection to the database

            return categories; // returning the category name list
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

            #region Parameters
            // Declaring the parameters required by the stored procedure to execute it's pre defined command
            cmd.Parameters.Add("@product_id", SqlDbType.VarChar, 10).Value = productId; // variable that identifies the desired product to retreive its data
            #endregion

            // Creating port to database to import and read the resulting query; equivilente to how an sql cursor works 
            SqlDataReader sqlDataReader;
            sqlDataReader = cmd.ExecuteReader(); // Executing the corresponding stored procedure and saving the result into the reader

            // Running through the individual rows of the result set until done
            while (sqlDataReader.Read())
            {
                #region Assigning the corresponding values to their variables
                product.Key = sqlDataReader["fld_product_key"].ToString();
                product.Name = sqlDataReader["fld_product_name"].ToString();
                product.Brand = sqlDataReader["fld_brand_name"].ToString();
                product.Supplier = sqlDataReader["fld_supplier_name"].ToString();
                product.Unit = sqlDataReader["fld_product_unit"].ToString();
                product.Category = sqlDataReader["fld_category_description"].ToString();
                product.Type = sqlDataReader["fld_type_description"].ToString();
                product.UnitCost = FormatToDecimal(sqlDataReader["fld_product_unit_cost"].ToString());
                product.UnitPrice = FormatToDecimal(sqlDataReader["fld_product_unit_price"].ToString());
                product.Quantity = FormatToInt(sqlDataReader["fld_product_quantity"].ToString());
                product.MinimumQuantity = FormatToInt(sqlDataReader["fld_product_minimum_quantity"].ToString());
                product.MaximumQuantity = FormatToInt(sqlDataReader["fld_product_maximum_quantity"].ToString());
                product.RegisteredBy = sqlDataReader["fld_product_registered_by"].ToString();
                product.RegistrationDate = DateTime.Parse(sqlDataReader["fld_product_registration_date"].ToString());
                product.ModifiedBy = sqlDataReader["fld_product_modified_by"].ToString();
                product.ModificationDate = DateTime.Parse(sqlDataReader["fld_product_modification_date"].ToString());
                product.Discontinued = FormatToBoolean(sqlDataReader["fld_product_discontinued"].ToString());
                #endregion
            }

            DatabaseManager.DisconnectToDatabase(); // Closing the active connection to the database

            return product; // returning the resulting product
        }

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
                    "SP_Fetch_Product_List", // Stored procedure incharged of fetching required data 
                    DatabaseManager.ActiveSqlConnection); // requesting an open active connection to the database from the manager 
            cmd.CommandType = CommandType.StoredProcedure; // Confirming that the previous command is a recognized stored procedure within the database

            #region Parameters
            // Declaring the parameters required by the stored procedure to execute it's pre defined command
            cmd.Parameters.Add("@user_permission", SqlDbType.VarChar, 100).Value = userPermission; // variable to verify the user's role
            cmd.Parameters.Add("@key_word", SqlDbType.VarChar, 300).Value = keyWord; // key word to filter the result set based on regular expressions
            #endregion

            // Creating port to database to import and read the resulting query; equivilente to how an sql cursor works 
            SqlDataReader sqlDataReader;
            sqlDataReader = cmd.ExecuteReader(); // Executing the corresponding stored procedure and saving the result into the reader

            // Running through the individual rows of the result set until done
            while (sqlDataReader.Read())
            {
                Product product = new Product(); // Creating a new product

                #region Assigning the corresponding values to their variables
                product.Id = sqlDataReader["fld_product_id"].ToString();
                product.Key = sqlDataReader["fld_product_key"].ToString();
                product.Name = sqlDataReader["fld_product_name"].ToString();
                product.Brand = sqlDataReader["fld_brand_name"].ToString();
                product.Unit = sqlDataReader["fld_product_unit"].ToString();
                product.UnitPrice = FormatToDecimal(sqlDataReader["fld_product_unit_price"].ToString());
                product.Quantity = FormatToInt(sqlDataReader["fld_product_quantity"].ToString());

                // Data exclusive to higher level access users
                if (userPermission != "User")
                {
                    product.Supplier = sqlDataReader["fld_supplier_name"].ToString();
                    product.UnitCost = FormatToDecimal(sqlDataReader["fld_product_unit_cost"].ToString());
                    product.Discontinued = FormatToBoolean(sqlDataReader["fld_product_discontinued"].ToString());
                }
                #endregion

                inventory.Add(product); // Adding the new product to the inventory list
            }

            DatabaseManager.DisconnectToDatabase(); // Closing the active connection to the database

            return inventory; // returning the resulting inenvtory
        }

        /// <summary>
        /// This function returns a record of all transactions registered in the system
        /// </summary>
        /// <param name="userPermission">User's role which defines his level of access to the data</param>
        /// <param name="keyWord">Key word to filter through the sales record</param>
        /// <returns>A list of the sales record according to the filtered key word</returns>
        public static List<Sale> FetchSalesRecordsData(String userPermission, String keyWord)
        {
            List<Sale> sales = new List<Sale>(); // List to host the resulting sales

            SqlCommand cmd = new SqlCommand(
                    "SP_Fetch_Sales_Records", // Stored procedure incharged of fetching required data 
                    DatabaseManager.ActiveSqlConnection); // requesting an open active connection to the database from the manager 
            cmd.CommandType = CommandType.StoredProcedure; // Confirming that the previous command is a recognized stored procedure within the database

            #region Parameters
            // Declaring the parameters required by the stored procedure to execute it's pre defined command
            cmd.Parameters.Add("@user_permission", SqlDbType.VarChar, 100).Value = userPermission;
            cmd.Parameters.Add("@key_word", SqlDbType.VarChar, 100).Value = keyWord;
            #endregion

            // Creating port to database to import and read the resulting query; equivilente to how an sql cursor works 
            SqlDataReader sqlDataReader;
            sqlDataReader = cmd.ExecuteReader(); // Executing the corresponding stored procedure and saving the result into the reader

            // Running through the individual rows of the result set until done
            while (sqlDataReader.Read())
            {
                Sale sale = new Sale(); // Creatig a new sale

                #region Assigning the corresponding values to their variables
                sale.Id = sqlDataReader[ "fld_sale_id"].ToString();
                sale.NumberItems = FormatToInt(sqlDataReader["fld_sale_quantity_items"].ToString());
                sale.Total = FormatToDecimal(sqlDataReader["fld_sale_total"].ToString());
                sale.SoldBy = sqlDataReader["fld_sold_by"].ToString();
                sale.TransactionDate = DateTime.Parse(sqlDataReader["fld_sale_date"].ToString());
                sale.Delivery = FormatToBoolean(sqlDataReader["fld_sale_delivery"].ToString());

                if (userPermission != "User")
                    sale.Status = sqlDataReader["fld_sale_status"].ToString(); // no need tio conver to int given the getter and setter of status does automatic conversion
                #endregion

                sales.Add(sale);
            }

            DatabaseManager.DisconnectToDatabase(); // Closing the active connection to the database

            return sales; // returning sales record
        }

        /// <summary>
        /// This function retreives the dataset of registered supplier names
        /// </summary>
        /// <param name="keyWord">Key word to enable specific filtered searhs</param>
        /// <returns>A list of all registered supplier names</returns>
        public static List<String> FetchSupplierListData(String keyWord)
        {
            List<String> suppliers = new List<string>(); // creating list to host registered supplier names
            suppliers.Add("<None>"); // adding the default value for products that are not associated with a supplier

            // Define which query command will be executed 
            SqlCommand cmd = new SqlCommand(
                    "SP_Fetch_Registered_Supplier_Names", // Stored procedure incharged of fetching required data
                    DatabaseManager.ActiveSqlConnection); // requesting an open active connection to the database from the manager
            cmd.CommandType = CommandType.StoredProcedure; // Confirming that the previous command is a recognized stored procedure within the database

            #region Parameters
            // Declaring the parameters required by the stored procedure to execute it's pre defined command
            cmd.Parameters.Add("@key_word", SqlDbType.VarChar, 100).Value = keyWord; // key word to filter the result set based on regular expressions
            #endregion

            // Creating port to database to import and read the resulting query; equivilente to how an sql cursor works
            SqlDataReader sqlDataReader;
            sqlDataReader = cmd.ExecuteReader(); // Executing the corresponding stored procedure and saving the result into the reader

            // Running through the individual rows of the result set until done
            while (sqlDataReader.Read())
            {
                String supplierName; // Creating supplier name class with string given this function doesn't use the brand object rather just the name of the brands

                // Assigning the corresponding values to their variables
                supplierName = sqlDataReader["fld_supplier_name"].ToString();

                suppliers.Add(supplierName); // adding supplier name to list
            }

            DatabaseManager.DisconnectToDatabase(); // Closing the active connection to the database

            return suppliers; // returning the supplier name list
        }

        /// <summary>
        /// This function fetches all registered type names
        /// </summary>
        /// <returns>A list of all registered type names</returns>
        public static List<String> FetchTypeComboBoxData()
        {
            List<String> types = new List<string>(); // creating list to host registered supplier names

            // Define which query command will be executed 
            SqlCommand cmd = new SqlCommand(
                    "SP_Fetch_Product_Type", // Stored procedure incharged of fetching required data
                    DatabaseManager.ActiveSqlConnection); // requesting an open active connection to the database from the manager
            cmd.CommandType = CommandType.StoredProcedure; // Confirming that the previous command is a recognized stored procedure within the database

            // Creating port to database to import and read the resulting query; equivilente to how an sql cursor works
            SqlDataReader sqlDataReader;
            sqlDataReader = cmd.ExecuteReader(); // Executing the corresponding stored procedure and saving the result into the reader

            // Running through the individual rows of the result set until done
            while (sqlDataReader.Read())
            {
                // Assigning the corresponding values to their variables
                String typeName = sqlDataReader["fld_type_description"].ToString();

                types.Add(typeName); // adding type name to list
            }

            DatabaseManager.DisconnectToDatabase(); // Closing the active connection to the database

            return types; // returning the type name list
        }

        /// <summary>
        /// This function fetches the data of a specified user
        /// </summary>
        /// <param name="username">Target username</param>
        /// <returns>The user profile of the requested username</returns>
        public static UserProfile FetchUserDataByUsername(String username)
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
        public static List<UserProfile> FetchUserListData(String username, String userPermission, String keyWord)
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
        /// This funtion validates user's credentials data
        /// </summary>
        /// <param name="username">Username requesting validation</param>
        /// <param name="password">Password</param>
        /// <returns>A message that confirms or denies the validation process</returns>
        public static String ValidateUserCredentialsData(String username, String password)
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

        #region Axiliary Functions 
        /// <summary>
        /// Function to convert strings to floats
        /// </summary>
        /// <param name="value">String value needed to be converted</param>
        /// <returns>The float equivalent of the given string value</returns>
        private static float FormatToFloat(String value)
        {
            float result;

            float.TryParse(value, out result);

            return result;
        }

        /// <summary>
        /// Function to convert strings to ints
        /// </summary>
        /// <param name="value">String value needed to be converted</param>
        /// <returns>An int equivalent of the provided string value</returns>
        private static int FormatToInt(String value)
        {
            int result;

            int.TryParse(value, out result);

            return result;
        }

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

        /// <summary>
        /// Function to convert strings to longs
        /// </summary>
        /// <param name="value">String value needed to be converted</param>
        /// <returns>A long equivalent of the provided string value</returns>
        private static long FormatToLong(String value)
        {
            long result;

            long.TryParse(value, out result);

            return result;
        }

        /// <summary>
        /// Function to convert strings to decimals
        /// </summary>
        /// <param name="value">String value needed to be converted</param>
        /// <returns>A decimal equivalent of the provided string value</returns>
        private static decimal FormatToDecimal(String value)
        {
            decimal result;

            decimal.TryParse(value, out result);

            return result;
        }
        #endregion
    }
}
