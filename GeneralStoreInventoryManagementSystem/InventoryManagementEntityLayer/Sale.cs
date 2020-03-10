using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementEntityLayer
{
    namespace Sale
    {
        public class Sale
        {
            private String id;
            private DateTime transactionDate;
            private int numberItems;
            private Decimal total;
            private String soldBy;
            private bool delivery;
            private int status;
            private String parent;
            private String child;
            private DateTime lastModified;

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

    namespace GraphEssentials
    {
        public class Sale
        {
            private String username;
            private int numberOfSales;
            private Decimal total;
            private DateTime transactionDate;

            #region Getters and Setters
            public string Username { get => username; set => username = value; }
            public int NumberOfSales { get => numberOfSales; set => numberOfSales = value; }
            public decimal Total { get => total; set => total = value; }
            public DateTime TransactionDate { get => transactionDate; set => transactionDate = value; }
            #endregion
        }
    }
}
