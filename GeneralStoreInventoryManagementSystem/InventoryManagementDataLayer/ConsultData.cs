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
                    DatabaseManager.ActiveSqlConnection // requesting an open active connection to the database from the manager 
                );
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
                product.Key = sqlDataReader["fld_product_key"].ToString();
                product.Name = sqlDataReader["fld_product_name"].ToString();
                product.Brand = sqlDataReader["fld_brand_name"].ToString();
                product.Unit = sqlDataReader["fld_product_unit"].ToString();
                product.UnitPrice = FormatToFloat(sqlDataReader["fld_product_unit_price"].ToString());
				product.Quantity = FormatToInt(sqlDataReader["fld_product_quantity"].ToString());

                // Data exclusive to higher level access users
                if (userPermission != "User"){
                    product.Supplier = sqlDataReader["fld_supplier_name"].ToString();
                    product.UnitCost = FormatToFloat(sqlDataReader["fld_product_unit_cost"].ToString());
                    product.Discontinued = FormatToBoolean(sqlDataReader["fld_product_discontinued"].ToString());
                }

                inventory.Add(product); // Adding the new product to the inventory list
            }
            
            DatabaseManager.DisconnectToDatabase(); // Closing the active connection to the database

            return inventory; // returning the resulting inenvtory
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
    }
}
