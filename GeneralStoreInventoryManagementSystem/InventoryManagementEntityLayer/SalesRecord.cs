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
            private String username;
            private int returns;
            private Decimal returnsTotal;
            private int sales;
            private Decimal salesTotal;

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
