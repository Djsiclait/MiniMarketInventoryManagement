using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Custom Library
using InventoryManagementBusinessLayer;
using InventoryManagementEntityLayer;

namespace GeneralStoreInventoryManagementSystem
{
    public partial class ReturnItemsMiniForm : Form
    {
        String saleId;
        List<Product> purchasedItems = new List<Product>();
        List<Product> returnedItems = new List<Product>();

        bool trigger = true;

        public ReturnItemsMiniForm(String saleId)
        {
            InitializeComponent();

            this.saleId = saleId;
        }

        #region Load Form Logic
        private void ReturnItemsMiniForm_Load(object sender, EventArgs e)
        {
            PopulatePurchasedItemsDataGrid();
            PopulateReturedItemsDataGrid();
        }
        #endregion

        #region Button Click Logic
        private void ReturnOneButton_Click(object sender, EventArgs e)
        {
            // Capturing the data of multiple selected products
            foreach (DataGridViewRow row in purchasedItemsDataGridView.SelectedRows)
            {
                if (IsProductFoundInList(row.Cells[0].Value.ToString(), "R"))
                {

                }
                else
                {
                    Product copy = new Product();

                    copy.Id = row.Cells[0].Value.ToString();
                    //copy.Key = row.Cells[1].Value.ToString(); // User assigned product identification number for non accounting purposes
                    copy.Name = row.Cells[2].Value.ToString(); // name of the product not including company brand
                    copy.Brand = row.Cells[3].Value.ToString(); // product brand company
                    //copy.Supplier = row.Cells[4].Value.ToString(); // product supplier 
                    //copy.Unit = row.Cells[5].Value.ToString(); // Unit of measurment for product(i.e.unit, pack, 12oz, lb)
                    //copy.Category = row.Cells[6].Value.ToString(); // product cateory
                    //copy.Type = row.Cells[7].Value.ToString(); // product type
                    //copy.UnitCost = FormatToDecimal(row.Cells[8].Value.ToString()); // purchase cost of an individual unit of the registered product
                    copy.UnitPrice = FormatToDecimal(row.Cells[9].Value.ToString()); // sales price of an individual unit of the registered product
                    copy.Quantity = 1; // current available total quantity of units in stock
                    //copy.MinimumQuantity = FormatToInt(row.Cells[11].Value.ToString()); // miminum unit quantity needed to determine understock level of registered product
                    //copy.MaximumQuantity = FormatToInt(row.Cells[12].Value.ToString()); // maximum unit quantity needed to determine overstock level of registered product
                    //copy.RegisteredBy = row.Cells[13].Value.ToString(); // username of person responsible for registering the product for the first time
                    //copy.RegistrationDate = DateTime.Parse(row.Cells[14].Value.ToString()); // date product was first registered by a user
                    //copy.ModifiedBy = row.Cells[15].Value.ToString(); // username of last person to modify the product's information
                    //copy.ModificationDate = DateTime.Parse(row.Cells[16].Value.ToString()); // date the product's information was last modified
                    //copy.Discontinued = FormatToBoolean(row.Cells[17].Value.ToString()); // State of product within the general store
                    copy.Total = FormatToDecimal(row.Cells[18].Value.ToString());

                    row.Cells[10].Value = (FormatToInt(row.Cells[10].Value.ToString()) - 1); // this also udpates its corresponding list due to call by refrence; i.e. the original list also updates
                    Console.WriteLine("R:" + row.Cells[10].Value);

                    if (row.Cells[10].Value.ToString() == "0")
                    {
                        foreach (Product item in purchasedItems)
                            if (item.Quantity == 0) // No need to compare the purchased item list with the row id of the modified item given that datgrid allows direct modification of variable (refrence) instead of a copy (parameter)
                            {
                                purchasedItems.Remove(item);
                                trigger = false;
                                break;
                            }
                    }
                    //else
                    //{
                    //    foreach (Product item in purchasedItems)
                    //        if (item.Id == row.Cells[0].Value.ToString())
                    //        {
                    //            //item.Quantity--;
                    //            Console.WriteLine("I: " + item.Quantity);
                    //            break;
                    //        }
                    //}

                    returnedItems.Add(copy);

                    PopulatePurchasedItemsDataGrid();
                    PopulateReturedItemsDataGrid();
                }

            }
        }
        #endregion

        #region Auxiliary Functions
        /// <summary>
        /// Function to convert strings to booleans
        /// </summary>
        /// <param name="value">String value needed to be converted</param>
        /// <returns>A boolean equivalent of the provided string value</returns>
        private static Boolean FormatToBoolean(String value)
        {
            Boolean result;

            Boolean.TryParse(value, out result);

            return result;
        }

        /// <summary>
        /// Function to convert strings to decimals
        /// </summary>
        /// <param name="value">String value needed to be converted</param>
        /// <returns>A decimal equivalent of the provided string value</returns>
        private static decimal FormatToDecimal(String value)
        {
            decimal result;

            decimal.TryParse(value, out result);

            return result;
        }

        /// <summary>
        /// Function to convert strings to ints
        /// </summary>
        /// <param name="value">String value needed to be converted</param>
        /// <returns>An int equivalent of the provided string value</returns>
        private static int FormatToInt(String value)
        {
            int result;

            int.TryParse(value, out result);

            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="productId"></param>
        /// <param name="list"></param>
        /// <returns></returns>
        private bool IsProductFoundInList(String productId, String list)
        {
            switch (list)
            {
                case "P":

                    foreach (Product item in purchasedItems)
                        if (item.Id == productId)
                            return true;

                    return false;

                case "R":

                    foreach (Product item in returnedItems)
                        if (item.Id == productId)
                            return true;

                    return false;

                default:
                    return false;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private void PopulatePurchasedItemsDataGrid()
        {
            purchasedItemsDataGridView.DataSource = new List<Product>();
            purchasedItemsDataGridView.Refresh();

            #region Grid Formating
            // Hidding unnecessary fields
            purchasedItemsDataGridView.Columns["Key"].Visible = false;
            purchasedItemsDataGridView.Columns["Supplier"].Visible = false;
            purchasedItemsDataGridView.Columns["Category"].Visible = false;
            purchasedItemsDataGridView.Columns["Type"].Visible = false;
            purchasedItemsDataGridView.Columns["UnitCost"].Visible = false;
            purchasedItemsDataGridView.Columns["MinimumQuantity"].Visible = false;
            purchasedItemsDataGridView.Columns["MaximumQuantity"].Visible = false;
            purchasedItemsDataGridView.Columns["RegisteredBy"].Visible = false;
            purchasedItemsDataGridView.Columns["RegistrationDate"].Visible = false;
            purchasedItemsDataGridView.Columns["ModifiedBy"].Visible = false;
            purchasedItemsDataGridView.Columns["ModificationDate"].Visible = false;
            purchasedItemsDataGridView.Columns["Discontinued"].Visible = false;

            // Formating columns
            purchasedItemsDataGridView.Columns["Id"].Width = 60;
            purchasedItemsDataGridView.Columns["Name"].Width = 150;
            purchasedItemsDataGridView.Columns["Unit"].Width = 50;
            purchasedItemsDataGridView.Columns["UnitPrice"].Width = 80;
            purchasedItemsDataGridView.Columns["Brand"].Width = 70;
            purchasedItemsDataGridView.Columns["Quantity"].Width = 60;
            #endregion

            if (purchasedItems.Count == 0 && trigger)
                purchasedItems = SaleInformationManager.ConsultTransactionContentInformation(saleId);

            if (purchasedItems.Count > 0)
            {
                purchasedItemsDataGridView.DataSource = purchasedItems;
                purchasedItemsDataGridView.Refresh();

                int quantity = 0;
                decimal total = 0;

                foreach (Product item in purchasedItems)
                {
                    quantity += item.Quantity;
                    total += item.Total;
                }

                numberOfPurchasedItemsLabel.Text = "# of Items: " + quantity.ToString();
                purchasedTotalLabel.Text = "Total: $" + total.ToString("0.00");
            }
            else
            {
                numberOfPurchasedItemsLabel.Text = "# of Items: 0";
                purchasedTotalLabel.Text = "Total: $0.00";
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private void PopulateReturedItemsDataGrid()
        {
            returnedItemsDataGridView.DataSource = new List<Product>();
            returnedItemsDataGridView.Refresh();

            #region Grid Formating
            // Hidding unnecessary fields
            returnedItemsDataGridView.Columns["Key"].Visible = false;
            returnedItemsDataGridView.Columns["Supplier"].Visible = false;
            returnedItemsDataGridView.Columns["Category"].Visible = false;
            returnedItemsDataGridView.Columns["Type"].Visible = false;
            returnedItemsDataGridView.Columns["UnitCost"].Visible = false;
            returnedItemsDataGridView.Columns["MinimumQuantity"].Visible = false;
            returnedItemsDataGridView.Columns["MaximumQuantity"].Visible = false;
            returnedItemsDataGridView.Columns["RegisteredBy"].Visible = false;
            returnedItemsDataGridView.Columns["RegistrationDate"].Visible = false;
            returnedItemsDataGridView.Columns["ModifiedBy"].Visible = false;
            returnedItemsDataGridView.Columns["ModificationDate"].Visible = false;
            returnedItemsDataGridView.Columns["Discontinued"].Visible = false;

            // Formationg columns
            returnedItemsDataGridView.Columns["Id"].Width = 60;
            returnedItemsDataGridView.Columns["Name"].Width = 150;
            returnedItemsDataGridView.Columns["Unit"].Width = 50;
            returnedItemsDataGridView.Columns["UnitPrice"].Width = 80;
            returnedItemsDataGridView.Columns["Brand"].Width = 70;
            returnedItemsDataGridView.Columns["Quantity"].Width = 60;
            #endregion

            //purchasedItems = SaleInformationManager.ConsultTransactionContentInformation(saleId);

            if (returnedItems.Count > 0)
            {
                returnedItemsDataGridView.DataSource = returnedItems;
                returnedItemsDataGridView.Refresh();

                int quantity = 0;
                decimal total = 0;

                foreach (Product item in returnedItems)
                {
                    quantity += item.Quantity;
                    total += item.Total;
                }

                numberOfReturnsLabel.Text = "# of Items: " + quantity.ToString();
                returnTotalLabel.Text = "Total: $" + total.ToString("0.00");
            }
            else
            {
                numberOfReturnsLabel.Text = "# of Items: 0";
                returnTotalLabel.Text = "Total: $0.00";
            }
        }
        #endregion
    }
}
