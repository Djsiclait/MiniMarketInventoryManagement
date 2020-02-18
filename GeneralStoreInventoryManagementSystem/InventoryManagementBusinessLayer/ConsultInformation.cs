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
    public static class ConsultInformation
    {
        /// <summary>
        /// This function returns a record of all transactions registered in the system
        /// </summary>
        /// <param name="keyWord">Key word to filter through the sales record</param>
        /// <returns>A list of the sales record according to the filtered key word</returns>
        public static List<Sale> FetchSalesRecordsInformation(String keyWord)
        {
            // Verifying user's status before providing requested information
            if (SystemResources.UserInSession.Status == "Active")
                return ConsultData.FetchSalesRecordsData(SystemResources.UserInSession.Role, keyWord);
            else
                return new List<Sale>(); // returning an empty list given invalid user status
        }

        /// <summary>
        /// This function fetches the contes of a completed transaction
        /// </summary>
        /// <param name="saleId">Identification number of the transaction</param>
        /// <returns>A list of the content of said transaction</returns>
        public static List<Product> FetchTransactionContentInformation(String saleId)
        {
            return ConsultData.FetchTransactionContentData(saleId);
        }

        /// <summary>
        /// This function fetech the information of a completed transaction
        /// </summary>
        /// <param name="saleId">Identification number of the transaction</param>
        /// <returns>A sale object with all needed information</returns>
        public static Sale FetchTransactionInformationBySalesId(String saleId)
        {
            return ConsultData.FetchTransactionDataBySalesId(saleId); 
        }
    }
}
