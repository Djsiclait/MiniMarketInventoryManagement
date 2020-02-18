using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

// Custome Library
using InventoryManagementEntityLayer;

namespace InventoryManagementDataLayer
{
    public static class SaleDataManager
    {
        #region Consults
        /// <summary>
        /// This function returns a record of all transactions registered in the system
        /// </summary>
        /// <param name="userPermission">User's role which defines his level of access to the data</param>
        /// <param name="keyWord">Key word to filter through the sales record</param>
        /// <returns>A list of the sales record according to the filtered key word</returns>
        public static List<Sale> ConsultSalesRecordsData(String userPermission, String keyWord)
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
                sale.Id = sqlDataReader["fld_sale_id"].ToString();
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
        /// This function fetches the contes of a completed transaction
        /// </summary>
        /// <param name="saleId">Identification number of the transaction</param>
        /// <returns>A list of the content of said transaction</returns>
        public static List<Product> ConsultTransactionContentData(String saleId)
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
                product.Id = sqlDataReader["fld_product_id"].ToString();
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
        public static Sale ConsultTransactionDataBySalesId(String saleId)
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
        #endregion

        #region Creates
        /// <summary>
        /// This fucntion registeres all products that have been purchased in a sales transaction
        /// </summary>
        /// <param name="boughtProduct">A product object that has been placed in the cart and purchased</param>
        /// <param name="saleId">The sale transaction id of the purchase</param>
        /// <param name="format">Inventory management accounting system to organize the catalog according to LIFO and FIFO</param>
        public static void CreateNewSalesTransactionContentData(Product boughtProduct, String saleId, string format)
        {
            SqlCommand cmd = new SqlCommand(
                    "SP_Register_Sales_Content_FIFO_LIFO", // Stored procedure dedicated to insert new data
                    DatabaseManager.ActiveSqlConnection); // requesting an open active connection to the database from the manager
            cmd.CommandType = CommandType.StoredProcedure; // Confirming that the previous command is a recognized stored procedure within the database

            #region Parameters
            // Declaring an output variable
            cmd.Parameters.Add("@product_id", SqlDbType.VarChar, 10).Value = boughtProduct.Id;
            cmd.Parameters.Add("@sale_id", SqlDbType.VarChar, 10).Value = saleId;
            cmd.Parameters.Add("@brand", SqlDbType.VarChar, 100).Value = boughtProduct.Brand;
            cmd.Parameters.Add("@unit", SqlDbType.VarChar, 30).Value = boughtProduct.Unit;
            cmd.Parameters.Add("@quantity", SqlDbType.Int).Value = boughtProduct.Quantity;
            cmd.Parameters.Add("@unit_price", SqlDbType.Decimal).Value = boughtProduct.UnitPrice / boughtProduct.Quantity;
            cmd.Parameters.Add("@format", SqlDbType.VarChar, 10).Value = format;
            #endregion

            Int32 reply;
            reply = Convert.ToInt32(cmd.ExecuteNonQuery()); // executing the stored procedure

            DatabaseManager.DisconnectToDatabase(); // Closing connection with database
        }

        /// <summary>
        /// This function registers all new transacions completed by a user
        /// </summary>
        /// <param name="sale">The Sale object with all necessary information</param>
        /// <param name="username"></param>
        /// <returns>The identification number of the newly created transaction</returns>
        public static String CreateNewSalesTransactionData(Sale sale, String username)
        {
            SqlCommand cmd = new SqlCommand(
                    "SP_Register_New_Sales_Transaction", // Stored procedure dedicated to insert new data
                    DatabaseManager.ActiveSqlConnection); // requesting an open active connection to the database from the manager
            cmd.CommandType = CommandType.StoredProcedure; // Confirming that the previous command is a recognized stored procedure within the database

            #region Parameters
            // Declaring an output variable
            cmd.Parameters.Add("@number_of_items", SqlDbType.Int).Value = sale.NumberItems;
            cmd.Parameters.Add("@total", SqlDbType.Decimal).Value = sale.Total;
            cmd.Parameters.Add("@was_delivery", SqlDbType.Bit).Value = sale.Delivery;
            cmd.Parameters.Add("@username", SqlDbType.VarChar, 50).Value = username;

            // Declaring an output variable
            SqlParameter saleID = new SqlParameter("@sale_id", SqlDbType.VarChar, 300); // defining the output message variable
            saleID.Direction = ParameterDirection.Output; // Confirming the output direction
            cmd.Parameters.Add(saleID); // Adding output paramater to the command
            #endregion

            Int32 reply;
            reply = Convert.ToInt32(cmd.ExecuteNonQuery()); // executing the stored procedure

            // closing the opened database connection is ignored given an expected output, @message, will be used

            return cmd.Parameters["@sale_id"].Value.ToString(); // returning the new sales identification of the transaction
        }
        #endregion

        #region Updates
        // No updates at this point
        #endregion

        #region Auxiliary 
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
