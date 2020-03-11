using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementEntityLayer
{
    namespace Sale // Library used for basic system fucntions like preform, view, and edit sales
    {
        public class Sale
        {
            private String id; // Automatic system generated identification number for a transaction
            private DateTime transactionDate; // Date transaction was preformed
            private int numberItems; // Number of items purchased in this transaction
            private Decimal total; // Total dollar amount of the transaction
            private String soldBy; // Username of the user that preformed the transaction
            private bool delivery; // Signifier if the transaction was designated as a delivery or in store sale
            private int status; // Status of transaction: Valid, Void, Returned
            private String parent; // Original transaction that was voided (Returned) to produce current transaction
            private String child; // The resulting transaction after the current transaction has been voided (Returned)
            private DateTime lastModified; // Last date the transaction was modified

            #region Getters and Setters
            public string Id
            {
                get
                {
                    return id;
                }

                set
                {
                    id = value;
                }
            }

            public DateTime TransactionDate
            {
                get
                {
                    return transactionDate;
                }

                set
                {
                    transactionDate = value;
                }
            }

            public int NumberItems
            {
                get
                {
                    return numberItems;
                }

                set
                {
                    numberItems = value;
                }
            }

            public decimal Total
            {
                get
                {
                    return total;
                }

                set
                {
                    total = value;
                }
            }

            public string SoldBy
            {
                get
                {
                    return soldBy;
                }

                set
                {
                    soldBy = value;
                }
            }

            public bool Delivery
            {
                get
                {
                    return delivery;
                }

                set
                {
                    delivery = value;
                }
            }

            public String Status
            {
                get
                {
                    switch (status)
                    {
                        case 0:
                            return "Valid";
                        case 1:
                            return "Void";
                        case 2:
                            return "Returned";
                        default:
                            return "";
                    }
                }

                set
                {
                    int num;

                    int.TryParse(value, out num);

                    status = num;
                }
            }

            public string Parent
            {
                get
                {
                    return parent;
                }

                set
                {
                    parent = value;
                }
            }

            public string Child
            {
                get
                {
                    return child;
                }

                set
                {
                    child = value;
                }
            }

            public DateTime LastModified
            {
                get
                {
                    return lastModified;
                }

                set
                {
                    lastModified = value;
                }
            }
            #endregion
        }
    }

    namespace GraphEssentials // Library used for analytic functions of the system: Reports and Graphs
    {
        public class Sale
        {
            private String username; // Username of user that has preformed the sales
            private int numberOfSales; // Number of sales the user has preformed at a period of time
            private Decimal total; // Total dollar amount of all sales preformed during the given time period
            private DateTime transactionDate; // Date (excluding time) transactiones were preformed

            #region Getters and Setters
            public string Username { get => username; set => username = value; }
            public int NumberOfSales { get => numberOfSales; set => numberOfSales = value; }
            public decimal Total { get => total; set => total = value; }
            public DateTime TransactionDate { get => transactionDate; set => transactionDate = value; }
            #endregion
        }
    }
}
