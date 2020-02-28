using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementEntityLayer
{
    namespace Product
    {
        public class Product
        {
            private String id; // System generated identification number for product for internal use
            private String key; // User assigned product identification number for non accounting purposes
            private String name; // name of the product not including company brand
            private String brand; // product brand company
            private String supplier; // product supplier 
            private String unit; // Unit of measurment for product(i.e.unit, pack, 12oz, lb)
            private String category; // product cateory
            private String type; // product type
            private decimal unitCost; // purchase cost of an individual unit of the registered product
            private decimal unitPrice; // sales price of an individual unit of the registered product
            private int quantity; // current available total quantity of units in stock
            private int minimumQuantity; // miminum unit quantity needed to determine understock level of registered product
            private int maximumQuantity; // maximum unit quantity needed to determine overstock level of registered product
            private String registeredBy; // username of person responsible for registering the product for the first time
            private DateTime registrationDate; // date product was first registered by a user
            private String modifiedBy; // username of last person to modify the product's information
            private DateTime modificationDate; // date the product's information was last modified
            private Boolean discontinued; // State of product within the general store
            private Decimal total;

            #region Gets and Sets
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

            public string Key
            {
                get
                {
                    return key;
                }

                set
                {
                    key = value;
                }
            }

            public string Name
            {
                get
                {
                    return name;
                }

                set
                {
                    name = value;
                }
            }

            public string Brand
            {
                get
                {
                    return brand;
                }

                set
                {
                    brand = value;
                }
            }

            public string Supplier
            {
                get
                {
                    return supplier;
                }

                set
                {
                    supplier = value;
                }
            }

            public string Unit
            {
                get
                {
                    return unit;
                }

                set
                {
                    unit = value;
                }
            }

            public string Category
            {
                get
                {
                    return category;
                }

                set
                {
                    category = value;
                }
            }

            public string Type
            {
                get
                {
                    return type;
                }

                set
                {
                    type = value;
                }
            }

            public decimal UnitCost
            {
                get
                {
                    return unitCost;
                }

                set
                {
                    unitCost = value;
                }
            }

            public decimal UnitPrice
            {
                get
                {
                    return unitPrice;
                }

                set
                {
                    unitPrice = value;
                }
            }

            public int Quantity
            {
                get
                {
                    return quantity;
                }

                set
                {
                    quantity = value;
                }
            }

            public int MinimumQuantity
            {
                get
                {
                    return minimumQuantity;
                }

                set
                {
                    minimumQuantity = value;
                }
            }

            public int MaximumQuantity
            {
                get
                {
                    return maximumQuantity;
                }

                set
                {
                    maximumQuantity = value;
                }
            }

            public string RegisteredBy
            {
                get
                {
                    return registeredBy;
                }

                set
                {
                    registeredBy = value;
                }
            }

            public DateTime RegistrationDate
            {
                get
                {
                    return registrationDate;
                }

                set
                {
                    registrationDate = value;
                }
            }

            public string ModifiedBy
            {
                get
                {
                    return modifiedBy;
                }

                set
                {
                    modifiedBy = value;
                }
            }

            public DateTime ModificationDate
            {
                get
                {
                    return modificationDate;
                }

                set
                {
                    modificationDate = value;
                }
            }

            public bool Discontinued
            {
                get
                {
                    return discontinued;
                }

                set
                {
                    discontinued = value;
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
            #endregion
        }
    }
}
