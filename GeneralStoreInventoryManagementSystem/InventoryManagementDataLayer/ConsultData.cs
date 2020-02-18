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
        /// <param name="format">Inventory management accounting system to organize the catalog according to LIFO and FIFO</param>
        /// <returns>a list of products registered with the system</returns>
        public static List<Product> FetchProductListData(String userPermission, String keyWord, String format)
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
        /// This function fetches the contes of a completed transaction
        /// </summary>
        /// <param name="saleId">Identification number of the transaction</param>
        /// <returns>A list of the content of said transaction</returns>
        public static List<Product> FetchTransactionContentData(String saleId)
        {
            List<Product> content = new List<Product>(); // List to host the resulting products included in the transaction

            // Define which query command will be executed 
            SqlCommand cmd = new SqlCommand(
                    "SP_Fetch_Transaction_Content_By_Sales_Id", // Stored procedure incharged of fetching required data 
                    DatabaseManager.ActiveSqlConnection); // requesting an open active connection to the database from the manager 
            cmd.CommandType = CommandType.StoredProcedure; // Confirming that the previous command is a recognized stored procedure within the database

            #region Parameters
            // Declaring the parameters required by the stored procedure to execute it's pre defined command
            cmd.Parameters.Add("@sale_id", SqlDbType.VarChar, 10).Value = saleId;
            #endregion

            // Creating port to database to import and read the resulting query; equivilente to how an sql cursor works 
            SqlDataReader sqlDataReader;
            sqlDataReader = cmd.ExecuteReader(); // Executing the corresponding stored procedure and saving the result into the reader

            // Running through the individual rows of the result set until done
            while (sqlDataReader.Read())
            {
                Product product = new Product();

                #region Assigning the corresponding values to their variables
                product.Name = sqlDataReader["fld_product_name"].ToString();
                product.Unit = sqlDataReader["fld_product_unit"].ToString();
                product.Brand = sqlDataReader["fld_brand_name"].ToString();
                product.Quantity = FormatToInt(sqlDataReader["fld_product_quantity"].ToString());
                product.UnitPrice = FormatToDecimal(sqlDataReader["fld_product_unit_price"].ToString());
                product.Total = FormatToDecimal(sqlDataReader["total"].ToString());
                #endregion

                content.Add(product);
            }

            DatabaseManager.DisconnectToDatabase(); // Closing the active connection to the database

            return content;
        }

        /// <summary>
        /// This function fetech the data of a completed transaction
        /// </summary>
        /// <param name="saleId">Identification number of the transaction</param>
        /// <returns>A sale object with all needed information</returns>
        public static Sale FetchTransactionDataBySalesId(String saleId)
        {
            Sale sale = new Sale();

            SqlCommand cmd = new SqlCommand(
                    "SP_Fetch_Transaction_Information_By_Sales_Id", // Stored procedure incharged of fetching required data  
                    DatabaseManager.ActiveSqlConnection); // requesting an open active connection to the database from the manager 
            cmd.CommandType = CommandType.StoredProcedure; // Confirming that the previous command is a recognized stored procedure within the database

            #region Parameters
            // Declaring the parameters required by the stored procedure to execute it's pre defined command
            cmd.Parameters.Add("@sale_id", SqlDbType.VarChar, 10).Value = saleId;
            #endregion

            // Creating port to database to import and read the resulting query; equivilente to how an sql cursor works 
            SqlDataReader sqlDataReader;
            sqlDataReader = cmd.ExecuteReader(); // Executing the corresponding stored procedure and saving the result into the reader

            // Running through the individual rows of the result set until done
            while (sqlDataReader.Read())
            {
                #region Assigning the corresponding values to their variables
                sale.Id = sqlDataReader["fld_sale_id"].ToString();
                sale.TransactionDate = DateTime.Parse(sqlDataReader["fld_sale_date"].ToString());
                sale.NumberItems = FormatToInt(sqlDataReader["fld_sale_quantity_items"].ToString());
                sale.Total = FormatToDecimal(sqlDataReader["fld_sale_total"].ToString());
                sale.Delivery = FormatToBoolean(sqlDataReader["fld_sale_delivery"].ToString());
                sale.Status = sqlDataReader["fld_sale_status"].ToString();
                sale.SoldBy = sqlDataReader["fld_sold_by"].ToString();
                #endregion
            }

            DatabaseManager.DisconnectToDatabase(); // Closing the active connection to the database

            return sale;
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
