using System;
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
        /// This function registers all new transacions completed by a user
        /// </summary>
        /// <param name="sale">The Sale object with all necessary information</param>
        /// <param name="username"></param>
        /// <returns>The identification number of the newly created transaction</returns>
        public static String RegisterNewSalesTransactionData(Sale sale, String username)
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
        
        /// <summary>
        /// This fucntion registeres all products that have been purchased in a sales transaction
        /// </summary>
        /// <param name="boughtProduct">A product object that has been placed in the cart and purchased</param>
        /// <param name="saleId">The sale transaction id of the purchase</param>
        /// <param name="format">Inventory management accounting system to organize the catalog according to LIFO and FIFO</param>
        public static void RegisterSalesTransactionContentData(Product boughtProduct, String saleId, string format)
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
    }
}
