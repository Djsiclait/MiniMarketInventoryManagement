using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Custom Libraries
using InventoryManagementDataLayer;
using InventoryManagementEntityLayer;

namespace InventoryManagementBusinessLayer
{
    public static class UpdateInformation
    {
        /// <summary>
        /// This function recieves an existing product that has been modified by the user and registers the new changes
        /// </summary>
        /// <param name="product">Product object with the new changes</param>
        /// <returns>A message detailing the success or failure of the update</returns>
        public static String UpdateRegisteredProductInformation(Product product)
        {
            // Requesting  an update of an existing product
            String message = UpdateData.UpdateRegisteredProductData(product, SystemResources.UserInSession.Username);

            if (message == "Product updated successfully!") // Update was succesful
            {
                // Executing correct activity according to given code
                SystemProtocols.ApplyActivityProtocols("PRO5", product.Name, null);
                return "SUCCESS";
            }
            else
                return "ERROR";
        }
    }
}
