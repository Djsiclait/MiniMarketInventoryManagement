using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Custom Libraries
using InventoryManagementDataLayer.SaleData;
using InventoryManagementEntityLayer.Product;
using InventoryManagementEntityLayer.Sale;

namespace InventoryManagementBusinessLayer
{
    public static class SaleInformationManager
    {
        #region Consults
        /// <summary>
        /// This function returns a record of all transactions registered in the system
        /// </summary>
        /// <param name="keyWord">Key word to filter through the sales record</param>
        /// <returns>A list of the sales record according to the filtered key word</returns>
        public static List<Sale> ConsultSalesRecordsInformation(String keyWord)
        {
            // Verifying user's status before providing requested information
            if (SystemResources.UserInSession.Status == "Active")
                return SaleDataManager.ConsultSalesRecordsData(SystemResources.UserInSession.Role, keyWord);
            else
                return new List<Sale>(); // returning an empty list given invalid user status
        }

        /// <summary>
        /// This function fetches the contes of a completed transaction
        /// </summary>
        /// <param name="saleId">Identification number of the transaction</param>
        /// <returns>A list of the content of said transaction</returns>
        public static List<Product> ConsultTransactionContentInformation(String saleId)
        {
            return SaleDataManager.ConsultTransactionContentData(saleId);
        }

        /// <summary>
        /// This function fetech the information of a completed transaction
        /// </summary>
        /// <param name="saleId">Identification number of the transaction</param>
        /// <returns>A sale object with all needed information</returns>
        public static Sale ConsultTransactionInformationBySalesId(String saleId)
        {
            return SaleDataManager.ConsultTransactionDataBySalesId(saleId);
        }
        #endregion

        #region Creates
        /// <summary>
        /// This fucntion registeres all products that have been purchased in a sales transaction
        /// </summary>
        /// <param name="boughtProduct">A product object that has been placed in the cart and purchased</param>
        /// <param name="saleId">The sale treansaction id of the purchase</param>
        public static void CreateNewSalesTransactionContentInformation(Product boughtProduct, String saleId)
        {
            // TODO: Implement inventory management accounting system 
            SaleDataManager.CreateNewSalesTransactionContentData(boughtProduct, saleId, "FIFO");
        }

        /// <summary>
        /// This function registers all new transacions completed by a user
        /// </summary>
        /// <param name="sale">The Sale object with all necessary information</param>
        /// <returns>The identification number of the newly created transaction</returns>
        public static String CreateNewSalesTransactionInformation(Sale sale)
        {
            return SaleDataManager.CreateNewSalesTransactionData(sale, SystemResources.UserInSession.Username);
        }
        #endregion

        #region Updates
        /// <summary>
        /// This function modifies the status of a transaction from valid to returned
        /// </summary>
        /// <param name="oldSaleId">Identification of the original transaction</param>
        /// <param name="newSaleId">Identification number of the resulting transaction</param>
        public static void UpdateTransactionStatusDataToReturned(String oldSaleId, String newSaleId)
        {
            SaleDataManager.UpdateTransactionStatusDataToReturned(oldSaleId, newSaleId, SystemResources.UserInSession.Username);

            SystemProtocols.ApplyActivityProtocols("SAL7", oldSaleId, newSaleId);
        }

        /// <summary>
        /// This function allows a user to void a registered transaction and cancel the sale
        /// </summary>
        /// <param name="salesId">Identification number of the registered transaction</param>
        public static void UpdateTransactionStatusInformationToVoid(String salesId)
        {
            SaleDataManager.UpdateTransactionStatusDataToVoid(salesId, SystemResources.UserInSession.Username);

            SystemProtocols.ApplyActivityProtocols("SAL6", salesId, null);
        }
        #endregion
    }
}
