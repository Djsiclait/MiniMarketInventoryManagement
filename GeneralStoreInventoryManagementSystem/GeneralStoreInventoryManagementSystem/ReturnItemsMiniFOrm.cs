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
using InventoryManagementEntityLayer.Product;
using InventoryManagementEntityLayer.Sale;

namespace GeneralStoreInventoryManagementSystem
{
    public partial class ReturnItemsMiniForm : Form
    {
        Sale sale; // Sale's object to host the current transaciton's information
        List<Product> purchasedItems = new List<Product>(); // list to host products that have been previoussly purchased
        List<Product> returnedItems = new List<Product>(); // list to host products to be returned

        bool trigger = true;

        public ReturnItemsMiniForm(String saleId)
        {
            InitializeComponent();

            sale = SaleInformationManager.ConsultTransactionInformationBySalesId(saleId);
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
                if (IsProductFoundInList(row.Cells[0].Value.ToString(), "R")) // Checking if at least one unit of the selected product has already been assigned to be returned
                {
                    foreach (Product item in returnedItems)
                        if (item.Id == row.Cells[0].Value.ToString())
                        {
                            item.Quantity++;
                            item.Total = item.UnitPrice * item.Quantity;
                        }

                    // this also udpates its corresponding list due to call by refrence; i.e. the original list also updates
                    // Also eleminate the need to have a nested for to find and update the correct row
                    row.Cells[10].Value = (FormatToInt(row.Cells[10].Value.ToString()) - 1);
                    row.Cells[18].Value = (FormatToDecimal(row.Cells[18].Value.ToString()) - FormatToDecimal(row.Cells[9].Value.ToString())); // reducing total by the unit price of one unit

                    if (row.Cells[10].Value.ToString() == "0") // When the quantity of an item is depleted; Quanity = 0
                        // purchasedItemsDataGridView.Rows.RemoveAt(row.Index); This requires an ibindinglist to work
                        // Necessary evil for now
                        foreach (Product item in purchasedItems)
                            if (item.Quantity == 0) // No need to compare the purchased item list with the row id of the modified item given that datagrid allows direct modification of variable (refrence) instead of a copy (parameter)
                            {
                                purchasedItems.Remove(item);
                                //trigger = false;
                                break;
                            }
                }
                else // no units of the selected product have been previously assigned for return 
                {
                    Product copy = new Product();

                    copy.Id = row.Cells[0].Value.ToString(); // identification number of the selected product
                    copy.Name = row.Cells[2].Value.ToString(); // name of the product not including company brand
                    copy.Brand = row.Cells[3].Value.ToString(); // product brand company
                    copy.Unit = row.Cells[5].Value.ToString();
                    copy.UnitPrice = FormatToDecimal(row.Cells[9].Value.ToString()); // sales price of an individual unit of the registered product
                    copy.Quantity = 1; // current available total quantity of units in stock
                    copy.Total = copy.UnitPrice; // total price of the amount of units purchased

                    // this also udpates its corresponding list due to call by refrence; i.e. the original list also updates
                    // Also eleminate the need to have a nested for to find and update the correct row
                    row.Cells[10].Value = (FormatToInt(row.Cells[10].Value.ToString()) - 1);
                    row.Cells[18].Value = (FormatToDecimal(row.Cells[18].Value.ToString()) - FormatToDecimal(row.Cells[9].Value.ToString())); ; // reducing total by the unit price of one unit

                    if (row.Cells[10].Value.ToString() == "0") // When the quantity of an item is depleted; Quanity = 0
                        // purchasedItemsDataGridView.Rows.RemoveAt(row.Index); This requires an ibindinglist to work
                        // Necessary evil for now
                        foreach (Product item in purchasedItems)
                            if (item.Quantity == 0) // No need to compare the purchased item list with the row id of the modified item given that datagrid allows direct modification of variable (refrence) instead of a copy (parameter)
                            {
                                purchasedItems.Remove(item);
                                trigger = false; // trigger to prevent the purchased list datagrid from reseting
                                break;
                            }

                    returnedItems.Add(copy);
                }

            // Updading both grids
            PopulatePurchasedItemsDataGrid();
            PopulateReturedItemsDataGrid();
        }

        private void RemoveOneButton_Click(object sender, EventArgs e)
        {
            // Capturing the data of multiple selected products
            foreach (DataGridViewRow row in returnedItemsDataGridView.SelectedRows)
            {
                if (IsProductFoundInList(row.Cells[0].Value.ToString(), "P")) // Checking if at least one unit of the selected product has already has yet to be returned
                {
                    foreach (Product item in purchasedItems)
                        if (item.Id == row.Cells[0].Value.ToString())
                        {
                            item.Quantity++;
                            item.Total = item.UnitPrice * item.Quantity;
                        }

                    // this also udpates its corresponding list due to call by refrence; i.e. the original list also updates
                    // Also eleminate the need to have a nested for to find and update the correct row
                    row.Cells[10].Value = (FormatToInt(row.Cells[10].Value.ToString()) - 1);
                    row.Cells[18].Value = (FormatToDecimal(row.Cells[18].Value.ToString()) - FormatToDecimal(row.Cells[9].Value.ToString())); // reducing total by the unit price of one unit

                    if (row.Cells[10].Value.ToString() == "0") // When the quantity of an item is depleted; Quanity = 0
                        // purchasedItemsDataGridView.Rows.RemoveAt(row.Index); This requires an ibindinglist to work
                        // Necessary evil for now
                        foreach (Product item in returnedItems)
                            if (item.Quantity == 0) // No need to compare the returned item list with the row id of the modified item given that datagrid allows direct modification of variable (refrence) instead of a copy (parameter)
                            {
                                returnedItems.Remove(item);
                                break;
                            }
                }
                else // All units of the selected product have been previously returned
                {
                    Product copy = new Product();

                    copy.Id = row.Cells[0].Value.ToString(); // identification number of the selected product
                    copy.Name = row.Cells[2].Value.ToString(); // name of the product not including company brand
                    copy.Brand = row.Cells[3].Value.ToString(); // product brand company
                    copy.Unit = row.Cells[5].Value.ToString();
                    copy.UnitPrice = FormatToDecimal(row.Cells[9].Value.ToString()); // sales price of an individual unit of the registered product
                    copy.Quantity = 1; // current available total quantity of units in stock
                    copy.Total = copy.UnitPrice; // total price of the amount of units purchased

                    // this also udpates its corresponding list due to call by refrence; i.e. the original list also updates
                    // Also eleminate the need to have a nested for to find and update the correct row
                    row.Cells[10].Value = (FormatToInt(row.Cells[10].Value.ToString()) - 1);
                    row.Cells[18].Value = (FormatToDecimal(row.Cells[18].Value.ToString()) - FormatToDecimal(row.Cells[9].Value.ToString())); ; // reducing total by the unit price of one unit

                    if (row.Cells[10].Value.ToString() == "0") // When the quantity of an item is depleted; Quanity = 0
                        // returnedItemsDataGridView.Rows.RemoveAt(row.Index); This requires an ibindinglist to work
                        // Necessary evil for now
                        foreach (Product item in returnedItems)
                            if (item.Quantity == 0) // No need to compare the purchased item list with the row id of the modified item given that datagrid allows direct modification of variable (refrence) instead of a copy (parameter)
                            {
                                returnedItems.Remove(item);
                                break;
                            }

                    purchasedItems.Add(copy);
                }
            }

            // Updading both grids
            PopulatePurchasedItemsDataGrid();
            PopulateReturedItemsDataGrid();
        }

        private void ReturnItemButton_Click(object sender, EventArgs e)
        {
            // Capturing the data of multiple selected products
            foreach (DataGridViewRow row in purchasedItemsDataGridView.SelectedRows)
                if (IsProductFoundInList(row.Cells[0].Value.ToString(), "R")) // Checking if at least one unit of the selected product has already been assigned to be returned
                {
                    foreach (Product item in returnedItems)
                        if (item.Id == row.Cells[0].Value.ToString())
                        {
                            item.Quantity += FormatToInt(row.Cells[10].Value.ToString());
                            item.Total = item.UnitPrice * item.Quantity;
                        }

                    // purchasedItemsDataGridView.Rows.RemoveAt(row.Index); This requires an ibindinglist to work
                    // Necessary evil for now
                    foreach (Product item in purchasedItems)
                        if (item.Id == row.Cells[0].Value.ToString()) // No need to compare the purchased item list with the row id of the modified item given that datagrid allows direct modification of variable (refrence) instead of a copy (parameter)
                        {
                            purchasedItems.Remove(item);
                            //trigger = false;
                            break;
                        }
                }
                else
                {
                    Product copy = new Product();

                    copy.Id = row.Cells[0].Value.ToString(); // identification number of the selected product
                    copy.Name = row.Cells[2].Value.ToString(); // name of the product not including company brand
                    copy.Brand = row.Cells[3].Value.ToString(); // product brand company
                    copy.Unit = row.Cells[5].Value.ToString();
                    copy.UnitPrice = FormatToDecimal(row.Cells[9].Value.ToString()); // sales price of an individual unit of the registered product
                    copy.Quantity = FormatToInt(row.Cells[10].Value.ToString()); // current available total quantity of units in stock
                    copy.Total = FormatToDecimal(row.Cells[18].Value.ToString()); // total price of the amount of units purchased

                    // purchasedItemsDataGridView.Rows.RemoveAt(row.Index); This requires an ibindinglist to work
                    // Necessary evil for now
                    foreach (Product item in purchasedItems)
                        if (item.Id == row.Cells[0].Value.ToString()) // No need to compare the purchased item list with the row id of the modified item given that datagrid allows direct modification of variable (refrence) instead of a copy (parameter)
                        {
                            purchasedItems.Remove(item);
                            trigger = false; // trigger to prevent the purchased list datagrid from reseting
                            break;
                        }

                    returnedItems.Add(copy);
                }

            // Updading both grids
            PopulatePurchasedItemsDataGrid();
            PopulateReturedItemsDataGrid();
        }

        private void RemoveItemButton_Click(object sender, EventArgs e)
        {
            // Capturing the data of multiple selected products
            foreach (DataGridViewRow row in returnedItemsDataGridView.SelectedRows)
                if (IsProductFoundInList(row.Cells[0].Value.ToString(), "P")) // Checking if at least one unit of the selected product has already been assigned to be returned
                {
                    foreach (Product item in purchasedItems)
                        if (item.Id == row.Cells[0].Value.ToString())
                        {
                            item.Quantity += FormatToInt(row.Cells[10].Value.ToString());
                            item.Total = item.UnitPrice * item.Quantity;
                        }

                    // purchasedItemsDataGridView.Rows.RemoveAt(row.Index); This requires an ibindinglist to work
                    // Necessary evil for now
                    foreach (Product item in returnedItems)
                        if (item.Id == row.Cells[0].Value.ToString()) // No need to compare the purchased item list with the row id of the modified item given that datagrid allows direct modification of variable (refrence) instead of a copy (parameter)
                        {
                            returnedItems.Remove(item);
                            break;
                        }
                }
                else
                {
                    Product copy = new Product();

                    copy.Id = row.Cells[0].Value.ToString(); // identification number of the selected product
                    copy.Name = row.Cells[2].Value.ToString(); // name of the product not including company brand
                    copy.Brand = row.Cells[3].Value.ToString(); // product brand company
                    copy.Unit = row.Cells[5].Value.ToString();
                    copy.UnitPrice = FormatToDecimal(row.Cells[9].Value.ToString()); // sales price of an individual unit of the registered product
                    copy.Quantity = FormatToInt(row.Cells[10].Value.ToString()); // current available total quantity of units in stock
                    copy.Total = FormatToDecimal(row.Cells[18].Value.ToString()); // total price of the amount of units purchased

                    // purchasedItemsDataGridView.Rows.RemoveAt(row.Index); This requires an ibindinglist to work
                    // Necessary evil for now
                    foreach (Product item in returnedItems)
                        if (item.Id == row.Cells[0].Value.ToString()) // No need to compare the purchased item list with the row id of the modified item given that datagrid allows direct modification of variable (refrence) instead of a copy (parameter)
                        {
                            returnedItems.Remove(item);
                            break;
                        }

                    purchasedItems.Add(copy);
                }

            // Updading both grids
            PopulatePurchasedItemsDataGrid();
            PopulateReturedItemsDataGrid();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            if (sale.NumberItems != purchasedItems.Count) // Confirming at least one item has been returned
            {
                // No need to change or nullify the old sales id, given that a new one will be assigned to the resulting transaction
                // and the old id will still be needed for future refrence.

                sale.NumberItems = FormatToInt(numberOfPurchasedItemsLabel.Text.Split(':')[1]); // updating the new amount of item that have not been returned
                sale.Total = FormatToDecimal(purchasedTotalLabel.Text.Split('$')[1]); // updating the new total of the transaction

                // Requesting a return policy
                String message = SystemProtocols.ApplyReturnPolicyProtocols(sale, purchasedItems, returnedItems);

                if (message == "VOIDED") // all products have been returned thus creating a void transaction instead of a partial return
                {
                    MessageBox.Show("Transaction voided successfully!");
                    this.Dispose();
                }
                else // Return request has been approved
                {
                    MessageBox.Show("Products have successfully been returned to the inventory!");

                    FormsMenuList.salesRecordForm.RefreshSalesRecordsDataGrid(); // updating grandparent form
                    FormsMenuList.salesRecordForm.ShowNewReturnedTransactionInformation(message); // requesting the grandparent to show the new resulting transaction child form
                    FormsMenuList.salesRecordForm.UpdateChildAfterSuccessfulReturn(sale.Id); // requesting grandparent to update this form's parent as well 

                    this.Dispose();
                }
            }
            else
                MessageBox.Show("Nothing was returned, please check form or cancel process.");
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
        /// Function to detect if a product is included in one of the designated lists
        /// </summary>
        /// <param name="productId">Identification number of the product</param>
        /// <param name="list">The code to specify the correct list of products</param>
        /// <returns>True or False depending if the product is included or not</returns>
        private bool IsProductFoundInList(String productId, String list)
        {
            switch (list) // Indicating which list is required
            {
                case "P": // purchased items

                    foreach (Product item in purchasedItems)
                        if (item.Id == productId)
                            return true;

                    return false;

                case "R": // returned items

                    foreach (Product item in returnedItems)
                        if (item.Id == productId)
                            return true;

                    return false;

                default:
                    return false;
            }
        }

        /// <summary>
        /// Function to populate the purchased item data grid
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

            if (purchasedItems.Count == 0 && trigger) // requesting purchased items once to avoid reseting the list once changes have been made
                purchasedItems = SaleInformationManager.ConsultTransactionContentInformation(sale.Id);

            if (purchasedItems.Count > 0)
            {
                purchasedItemsDataGridView.DataSource = purchasedItems;
                purchasedItemsDataGridView.Refresh();

                int quantity = 0;
                decimal total = 0;

                foreach (Product item in purchasedItems)
                {
                    quantity += item.Quantity; // counting units of items
                    total += item.Total; // calculating total of purchased items
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
        /// Function to populate the returned item data grid
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

            // No need to request for a returned list given this list is generated en vivo

            if (returnedItems.Count > 0)
            {
                returnedItemsDataGridView.DataSource = returnedItems;
                returnedItemsDataGridView.Refresh();

                int quantity = 0;
                decimal total = 0;

                foreach (Product item in returnedItems)
                {
                    quantity += item.Quantity; // counting units of items
                    total += item.Total; // calculating total of purchased items
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
