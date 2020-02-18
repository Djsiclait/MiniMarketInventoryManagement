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
    public static class UpdateData
    {
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
    }
}
