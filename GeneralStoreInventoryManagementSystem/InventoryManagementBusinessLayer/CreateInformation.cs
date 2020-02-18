using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Custom Library
using InventoryManagementDataLayer;
using InventoryManagementEntityLayer;

namespace InventoryManagementBusinessLayer
{
    public static class CreateInformation
    {
        /// <summary>
        /// This function registers all new transacions completed by a user
        /// </summary>
        /// <param name="sale">The Sale object with all necessary information</param>
        /// <returns>The identification number of the newly created transaction</returns>
        public static String RegisterNewSalesTransactionInformation(Sale sale)
        {
            return CreateData.RegisterNewSalesTransactionData(sale, SystemResources.UserInSession.Username);
        }

        /// <summary>
        /// This fucntion registeres all products that have been purchased in a sales transaction
        /// </summary>
        /// <param name="boughtProduct">A product object that has been placed in the cart and purchased</param>
        /// <param name="saleId">The sale treansaction id of the purchase</param>
        public static void RegisterSalesTransactionContentInformation(Product boughtProduct, String saleId)
        {
            // TODO: Implement inventory management accounting system 
            CreateData.RegisterSalesTransactionContentData(boughtProduct, saleId, "FIFO");
        }
    }
}
