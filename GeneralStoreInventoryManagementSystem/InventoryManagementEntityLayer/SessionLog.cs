using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementEntityLayer
{
    namespace ReportEssentials
    {
        public class SessionLog
        {
            private DateTime logIn; // Timestamp of the moment a user logs in to begin a session
            private DateTime logOut; // Timestamp of the moment a user logs out to end a session 
            private Decimal totalSessionMinutes; // Total amount of minutes user spent during a session

            #region Getters and Setters
            public DateTime LogIn { get => logIn; set => logIn = value; }
            public DateTime LogOut { get => logOut; set => logOut = value; }
            public decimal TotalSessionMinutes { get => totalSessionMinutes; set => totalSessionMinutes = value; }
            #endregion
        }
    }
}
