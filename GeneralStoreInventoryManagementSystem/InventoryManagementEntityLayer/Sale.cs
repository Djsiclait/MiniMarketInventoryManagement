using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementEntityLayer
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
                        return "Canceled";
                    case 2:
                        return "Void";
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
        #endregion
    }
}
