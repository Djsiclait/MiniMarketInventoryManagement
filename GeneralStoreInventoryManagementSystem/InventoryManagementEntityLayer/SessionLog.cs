using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementEntityLayer
{
    namespace Session
    {
        public class SessionLog
        {
            private DateTime logIn;
            private DateTime logOut;
            private Decimal totalSessionMinutes;

            #region Getters and Setters
            public DateTime LogIn { get => logIn; set => logIn = value; }
            public DateTime LogOut { get => logOut; set => logOut = value; }
            public decimal TotalSessionMinutes { get => totalSessionMinutes; set => totalSessionMinutes = value; }
            #endregion
        }
    }
}
