using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementEntityLayer
{
    namespace ReportEssentials
    {
        public class SalesRecord
        {
            private String username; // Username of user that has preformed the sales and returns
            private int returns; // Number of returns the user has preformed at a given time 
            private Decimal returnsTotal; // Total dollar amount of preformed returns durring the specified time 
            private int sales; // Number of sales the user has preformed at a given time
            private Decimal salesTotal; // Total dollar amount of preformed sales druing the specified time 

            #region Getters and Setters
            public string Username { get => username; set => username = value; }
            public int Returns { get => returns; set => returns = value; }
            public decimal ReturnsTotal { get => returnsTotal; set => returnsTotal = value; }
            public int Sales { get => sales; set => sales = value; }
            public decimal SalesTotal { get => salesTotal; set => salesTotal = value; }
            #endregion
        }
    }
}
