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
        class ErrorInformationManager
        {
            #region Consults

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
