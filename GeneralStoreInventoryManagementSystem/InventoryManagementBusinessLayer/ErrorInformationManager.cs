using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Custom Library
using InventoryManagementDataLayer.ErrorData;
using InventoryManagementEntityLayer.Error;

namespace InventoryManagementBusinessLayer
{
    namespace ErrorInformation
    {
        public static class ErrorInformationManager
        {
            #region Consults
            /// <summary>
            /// THis function retrieves all registered errors 
            /// </summary>
            /// <param name="keyWord">Key word used to filter errors by code or username</param>
            /// <returns>A list of all registered errors</returns>
            public static List<Error> ConsultErrorListInformation(String keyWord)
            {
                return ErrorDataManager.ConsultErrorListData(keyWord);
            }
            #endregion

            #region Creates
            /// <summary>
            /// This function is in charge of registering all new error information generated during a session
            /// </summary>
            /// <param name="error">An error entity with all necessary information</param>
            public static void RegisterNewErrorInformation(Error error)
            {
                ErrorDataManager.RegisterNewErrorData(error);
            }
            #endregion

            #region Updates

            #endregion
        }
    }
}
