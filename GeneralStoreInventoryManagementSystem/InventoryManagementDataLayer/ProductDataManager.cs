using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

// Custom Libraries
using InventoryManagementEntityLayer;

namespace InventoryManagementDataLayer
{
    public static class ProductDataManager
    {
        #region Consults
        /// <summary>
        /// This function retreives the dataset of registered brand names
        /// </summary>
        /// <param name="keyWord">Key word to enable specific filtered searhs</param>
        /// <returns>A list of all registered brand names</returns>
        public static List<String> ConsultProductBrandListData(String keyWord)
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
        public static List<String> ConsultProductCategoryComboBoxData()
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
        public static Product ConsultProductDataByID(String productId)
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
        /// <param name="format">Inventory management accounting system to organize the catalog according to LIFO and FIFO</param>
        /// <returns>a list of products registered with the system</returns>
        public static List<Product> ConsultProductListData(String userPermission, String keyWord, String format)
        {
            List<Product> inventory = new List<Product>(); // List to host the resulting products of the registred inventory

            // Define which query command will be executed 
            SqlCommand cmd = new SqlCommand(
                    "SP_Fetch_Product_List_For_Browsing", // Stored procedure incharged of fetching required data 
                    DatabaseManager.ActiveSqlConnection); // requesting an open active connection to the database from the manager 
            cmd.CommandType = CommandType.StoredProcedure; // Confirming that the previous command is a recognized stored procedure within the database

            #region Parameters
            // Declaring the parameters required by the stored procedure to execute it's pre defined command
            cmd.Parameters.Add("@user_permission", SqlDbType.VarChar, 100).Value = userPermission; // variable to verify the user's role
            cmd.Parameters.Add("@key_word", SqlDbType.VarChar, 300).Value = keyWord; // key word to filter the result set based on regular expressions
            cmd.Parameters.Add("@format", SqlDbType.VarChar, 10).Value = format;
            #endregion

            // Creating port to database to import and read the resulting query; equivilente to how an sql cursor works 
            SqlDataReader sqlDataReader;
            sqlDataReader = cmd.ExecuteReader(); // Executing the corresponding stored procedure and saving the result into the reader

            // Running through the individual rows of the result set until done
            while (sqlDataReader.Read())
            {
                Product product = new Product(); // Creating a new product

                #region Assigning the corresponding values to their variables
                // Data exclusive to higher level access users
                if (userPermission != "User")
                {
                    product.Id = sqlDataReader["fld_product_id"].ToString();
                    product.Key = sqlDataReader["fld_product_key"].ToString();
                    product.Name = sqlDataReader["fld_product_name"].ToString();
                    product.Brand = sqlDataReader["fld_brand_name"].ToString();
                    product.Supplier = sqlDataReader["fld_supplier_name"].ToString();
                    product.Unit = sqlDataReader["fld_product_unit"].ToString();
                    product.UnitCost = FormatToDecimal(sqlDataReader["fld_product_unit_cost"].ToString());
                    product.UnitPrice = FormatToDecimal(sqlDataReader["fld_product_unit_price"].ToString());
                    product.Quantity = FormatToInt(sqlDataReader["fld_product_quantity"].ToString());
                    product.Discontinued = FormatToBoolean(sqlDataReader["fld_product_discontinued"].ToString());
                    product.RegistrationDate = DateTime.Parse(sqlDataReader["fld_product_registration_date"].ToString());
                }
                else
                {
                    product.Id = sqlDataReader["product_id"].ToString();
                    product.Key = sqlDataReader["product_key"].ToString();
                    product.Name = sqlDataReader["fld_product_name"].ToString();
                    product.Brand = sqlDataReader["fld_brand_name"].ToString();
                    product.Unit = sqlDataReader["fld_product_unit"].ToString();
                    product.UnitPrice = FormatToDecimal(sqlDataReader["unit_price"].ToString());
                    product.Quantity = FormatToInt(sqlDataReader["quantity"].ToString());
                }
                #endregion

                inventory.Add(product); // Adding the new product to the inventory list
            }

            DatabaseManager.DisconnectToDatabase(); // Closing the active connection to the database

            return inventory; // returning the resulting inenvtory
        }

        /// <summary>
        /// This function retreives the dataset of registered supplier names
        /// </summary>
        /// <param name="keyWord">Key word to enable specific filtered searhs</param>
        /// <returns>A list of all registered supplier names</returns>
        public static List<String> ConsultProductSupplierListData(String keyWord)
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
        public static List<String> ConsultProductTypeComboBoxData()
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
        #endregion

        #region Creates
        /// <summary>
        /// This function registers new product suppliers
        /// </summary>
        /// <param name="name">Name of product supplier</param>
        /// <param name="phoneNumber">Phone number of supplier</param>
        /// <param name="email">email of supplier</param>
        /// <returns>A message that confirms or rejects the supplier creation process</returns>
        public static String CreateNewIncompleteProductSupplierData(String name)
        {
            // Define which query command will be executed 
            SqlCommand cmd = new SqlCommand(
                    "SP_Register_New_Supplier", // Stored procedure dedicated to insert new data
                    DatabaseManager.ActiveSqlConnection); // requesting an open active connection to the database from the manager
            cmd.CommandType = CommandType.StoredProcedure; // Confirming that the previous command is a recognized stored procedure within the database

            #region Parameters
            // Declaring an output variable
            cmd.Parameters.Add("@name", SqlDbType.VarChar, 100).Value = name; // Defining the supplier name
            cmd.Parameters.Add("@phone_number", SqlDbType.VarChar, 100).Value = ""; // defining the phone number
            cmd.Parameters.Add("@email", SqlDbType.VarChar, 200).Value = ""; // defining supplier's email

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
        /// This function registers new product brands
        /// </summary>
        /// <param name="name">Name of product brand</param>
        /// <returns>A message that confirms or rejects the brand creation process</returns>
        public static String CreateNewProductBrandData(String name)
        {
            // Define which query command will be executed 
            SqlCommand cmd = new SqlCommand(
                    "SP_Register_New_Brand", // Stored procedure dedicated to insert new data
                    DatabaseManager.ActiveSqlConnection); // requesting an open active connection to the database from the manager 
            cmd.CommandType = CommandType.StoredProcedure; // Confirming that the previous command is a recognized stored procedure within the database

            #region Parameters
            // Declaring an output variable
            cmd.Parameters.Add("@name", SqlDbType.VarChar, 100).Value = name; // Defining the brand name

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
        /// This function receives a product object to insert its data into the database
        /// </summary>
        /// <param name="product">Product object which contains necessary information</param>
        /// <returns>A message that confirms or denies the creation process</returns>
        public static String CreateNewProductData(Product product)
        {
            // Define which query command will be executed 
            SqlCommand cmd = new SqlCommand(
                    "SP_Register_New_Product", // Stored procedure dedicated to insert new data
                    DatabaseManager.ActiveSqlConnection); // requesting an open active connection to the database from the manager 
            cmd.CommandType = CommandType.StoredProcedure; // Confirming that the previous command is a recognized stored procedure within the database

            #region Parameters
            // Declaring the parameters required by the stored procedure to execute it's pre defined command
            cmd.Parameters.Add("@key", SqlDbType.VarChar, 100).Value = product.Key;
            cmd.Parameters.Add("@name", SqlDbType.VarChar, 300).Value = product.Name;
            cmd.Parameters.Add("@brand", SqlDbType.VarChar, 100).Value = product.Brand == "<None>" ? "" : product.Brand;
            cmd.Parameters.Add("@supplier", SqlDbType.VarChar, 100).Value = product.Supplier == "<None>" ? "" : product.Supplier;
            cmd.Parameters.Add("@unit", SqlDbType.VarChar, 30).Value = product.Unit;
            cmd.Parameters.Add("@category", SqlDbType.VarChar, 50).Value = product.Category;
            cmd.Parameters.Add("@type", SqlDbType.VarChar, 50).Value = product.Type;
            cmd.Parameters.Add("@cost", SqlDbType.Decimal).Value = product.UnitCost;
            cmd.Parameters.Add("@price", SqlDbType.Decimal).Value = product.UnitPrice;
            cmd.Parameters.Add("@quantity", SqlDbType.Int).Value = product.Quantity;
            cmd.Parameters.Add("@minimum", SqlDbType.Int).Value = product.MinimumQuantity;
            cmd.Parameters.Add("@maximum", SqlDbType.Int).Value = product.MaximumQuantity;
            cmd.Parameters.Add("@username", SqlDbType.VarChar, 50).Value = product.RegisteredBy;

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
        /// This function recieves an existing product that has been modified by the user and registers the new changes
        /// </summary>
        /// <param name="product">Product object with the new changes</param>
        /// <param name="username">User responsible for changes</param>
        /// <returns>A message detailing the success or failure of the update</returns>
        public static String UpdateRegisteredProductData(Product product, String username)
        {
            // Generating query to execute the desired command
            SqlCommand cmd = new SqlCommand(
                    "SP_Edit_Product", // stored procedure to update the user's last login 
                    DatabaseManager.ActiveSqlConnection); // Opening an active connection with the database
            cmd.CommandType = CommandType.StoredProcedure; // confirming the command is a recognized stored procedure

            #region Parameters
            cmd.Parameters.Add("@product_id", SqlDbType.VarChar, 10).Value = product.Id;
            cmd.Parameters.Add("@new_key", SqlDbType.VarChar, 100).Value = product.Key;
            cmd.Parameters.Add("@new_brand", SqlDbType.VarChar, 100).Value = product.Brand == "<None>" ? "" : product.Brand;
            cmd.Parameters.Add("@new_supplier", SqlDbType.VarChar, 100).Value = product.Supplier == "<None>" ? "" : product.Supplier;
            cmd.Parameters.Add("@new_category", SqlDbType.VarChar, 50).Value = product.Category;
            cmd.Parameters.Add("@new_type", SqlDbType.VarChar, 50).Value = product.Type;
            cmd.Parameters.Add("@new_unit", SqlDbType.VarChar, 30).Value = product.Unit;
            cmd.Parameters.Add("@new_cost", SqlDbType.Decimal).Value = product.UnitCost;
            cmd.Parameters.Add("@new_price", SqlDbType.Decimal).Value = product.UnitPrice;
            cmd.Parameters.Add("@new_quantity", SqlDbType.Int).Value = product.Quantity;
            cmd.Parameters.Add("@new_minimum", SqlDbType.Int).Value = product.MinimumQuantity;
            cmd.Parameters.Add("@new_maximum", SqlDbType.Int).Value = product.MaximumQuantity;
            cmd.Parameters.Add("@new_discontinued", SqlDbType.Bit).Value = product.Discontinued;
            cmd.Parameters.Add("@username", SqlDbType.VarChar, 50).Value = username;

            SqlParameter message = new SqlParameter("@message", SqlDbType.VarChar, 100);
            message.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(message);
            #endregion

            // Executing command
            Int32 reply;
            reply = Convert.ToInt32(cmd.ExecuteNonQuery());

            return cmd.Parameters["@message"].Value.ToString(); // returning the result of the query
        }

        /// <summary>
        /// This fucntion allows users to restock registered products
        /// </summary>
        /// <param name="productId">Identification number of product to restock</param>
        /// <param name="addedAmount">Amount to be added to the current stock of products</param>
        /// <param name="username">Username of user managing the restock</param>
        /// <returns>A message to confirm or deny the restock process</returns>
        public static String updateRegisteredProductDataForRestock(String productId, int addedAmount, String username)
        {
            SqlCommand cmd = new SqlCommand(
                    "SP_Restock_Registered_Product", // stored procedure to update the user's last login 
                    DatabaseManager.ActiveSqlConnection); // Opening an active connection with the database
            cmd.CommandType = CommandType.StoredProcedure; // confirming the command is a recognized stored procedure

            #region Parameters
            cmd.Parameters.Add("@product_id", SqlDbType.VarChar, 10).Value = productId;
            cmd.Parameters.Add("@added_units", SqlDbType.Int).Value = addedAmount;
            cmd.Parameters.Add("@username", SqlDbType.VarChar, 50).Value = username;

            SqlParameter message = new SqlParameter("@message", SqlDbType.VarChar, 100);
            message.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(message);
            #endregion

            // Executing command
            Int32 reply;
            reply = Convert.ToInt32(cmd.ExecuteNonQuery());

            return cmd.Parameters["@message"].Value.ToString(); // returning the result of the query
        }

        /// <summary>
        /// This function updates the inventory after a return has been made
        /// </summary>
        /// <param name="productId">Identification number of the product being returned</param>
        /// <param name="quantity">Quantity of units being returned</param>
        /// <param name="username">Username of user managing the return</param>
        public static void UpdateRegisteredProductDataForReturns(String productId, int quantity, String username)
        {
            // Generating query to execute the desired command
            SqlCommand cmd = new SqlCommand(
                    "SP_Return_Purchased_Items", // stored procedure to update the user's last login 
                    DatabaseManager.ActiveSqlConnection); // Opening an active connection with the database
            cmd.CommandType = CommandType.StoredProcedure; // confirming the command is a recognized stored procedure

            #region Parameters
            cmd.Parameters.Add("@product_id", SqlDbType.VarChar, 10).Value = productId;
            cmd.Parameters.Add("@quantity", SqlDbType.Int).Value = quantity;
            cmd.Parameters.Add("@username", SqlDbType.VarChar, 50).Value = username;
            #endregion

            // Executing command
            Int32 reply;
            reply = Convert.ToInt32(cmd.ExecuteNonQuery());

            DatabaseManager.DisconnectToDatabase();
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
        #endregion
    }
}
