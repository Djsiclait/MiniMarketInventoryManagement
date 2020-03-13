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
using InventoryManagementBusinessLayer.ProductInformation;
using InventoryManagementBusinessLayer.Protocols;
using InventoryManagementEntityLayer.Product;
using InventoryManagementEntityLayer.Sale;

namespace GeneralStoreInventoryManagementSystem
{
    public partial class RegisterNewSaleFrom : Form
    {
        int assistance = 0;

        public RegisterNewSaleFrom()
        {
            InitializeComponent();
        }

        #region Load Form Logic
        private void RegisterNewSaleFrom_Load(object sender, EventArgs e)
        {
            // Identifying correct protocol for current user in session
            if (SystemProtocols.ApplySessionsProtocols(1))
            {
                // Disabling the other Products option 
                registerNewProductMenuSubOption.Visible = false;
                registerNewProductMenuSubOption.Enabled = false;
                restockProductsMenuSubOption.Visible = false;
                restockProductsMenuSubOption.Enabled = false;

                // Disabling all admin options
                adminMenuOption.Visible = false;
                adminMenuOption.Enabled = false;

                SystemProtocols.ApplyActivityProtocols("SAL1");
            }
            else
                SystemProtocols.ApplyActivityProtocols("SAL4");

            PopulateProductDataGrid();
            UpdateCartSummaryDataGrid();
        }
        #endregion

        #region On Form Closing Override
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            // Executing correct log out processes
            SystemProtocols.ApplyLogOutProtocols();
            FormsMenuList.loginForm.Show();

            SystemProtocols.ApplyCartManagementProtocol(3, null, 0, null, 0); // clearing the cart before logging out

            // Closing form while freeing system resources
            FormsMenuList.registerNewSaleForm.Dispose();
        }
        #endregion

        #region Menu Bar Options
        private void ViewSalesMenuOption_Click(object sender, EventArgs e)
        {
            // Summon Sales Registry Form
            FormsMenuList.salesRecordForm = new SalesRecordForm();
            FormsMenuList.salesRecordForm.Show();

            // Closing form while freeing system resources
            FormsMenuList.registerNewSaleForm.Dispose();
        }

        private void BrowseProductsMenuSubOption_Click(object sender, EventArgs e)
        {
            // Summon Product Browser Form
            FormsMenuList.inventorySearchForm = new InventorySearchForm();
            FormsMenuList.inventorySearchForm.Show();

            // Closing form while freeing system resources
            FormsMenuList.registerNewSaleForm.Dispose();
        }

        private void RegisterNewProductMenuSubOption_Click(object sender, EventArgs e)
        {
            // Summon Register New Product Form
            FormsMenuList.registerNewProduct = new RegisterNewProductForm();
            FormsMenuList.registerNewProduct.Show();

            // Closing form while freeing system resources
            FormsMenuList.registerNewSaleForm.Dispose();
        }

        private void RestockProductsMenuSubOption_Click(object sender, EventArgs e)
        {
            // Summon Restock Products Form
            FormsMenuList.restockProductsFrom = new RestockProductsForm();
            FormsMenuList.restockProductsFrom.Show();

            // Closing form while freeing system resources
            FormsMenuList.registerNewSaleForm.Dispose();
        }

        private void ViewUsersOption_Click(object sender, EventArgs e)
        {
            // Summon Users Registry Form
            FormsMenuList.usersRegistryForm = new UsersRegistryForm();
            FormsMenuList.usersRegistryForm.Show();

            // Closing form while freeing system resources
            FormsMenuList.registerNewSaleForm.Dispose();
        }

        private void RegisterNewUserOption_Click(object sender, EventArgs e)
        {
            // Summon Register New User Form
            FormsMenuList.registerNewUserForm = new RegisterNewUserForm();
            FormsMenuList.registerNewUserForm.Show();

            // Closing form while freeing system resources
            FormsMenuList.registerNewSaleForm.Dispose();
        }

        private void ViewGraphsOption_Click(object sender, EventArgs e)
        {
            // Summon Graphs Analytics Form
            FormsMenuList.graphsAnaliticsForm = new GraphsAnalyticsForm();
            FormsMenuList.graphsAnaliticsForm.Show();

            // Closing form while freeing system resources
            FormsMenuList.registerNewSaleForm.Dispose();
        }

        private void ViewReportsOption_Click(object sender, EventArgs e)
        {
            // Summon Reports Analytics Form
            FormsMenuList.reportsAnalyticsForm = new ReportsAnalyticsForm();
            FormsMenuList.reportsAnalyticsForm.Show();

            // Closing form while freeing system resources
            FormsMenuList.registerNewSaleForm.Dispose();
        }

        private void ViewActivityLogsOption_Click(object sender, EventArgs e)
        {
            // Summon Activity Logs Form
            FormsMenuList.activitiesLogForm = new ActivitiesLogForm();
            FormsMenuList.activitiesLogForm.Show();

            // Closing form while freeing system resources
            FormsMenuList.registerNewSaleForm.Dispose();
        }

        private void ViewErrorLogsOption_Click(object sender, EventArgs e)
        {
            // Summon Error Logs Form
            FormsMenuList.errorsLogForm = new ErrorsLogForm();
            FormsMenuList.errorsLogForm.Show();

            // Closing form while freeing system resources
            FormsMenuList.registerNewSaleForm.Dispose();
        }

        private void ViewCartLabel_Click(object sender, EventArgs e)
        {
            // Summon View Cart Form
            FormsMenuList.viewCartForm = new ViewCartForm();
            FormsMenuList.viewCartForm.Show();

            // Closing form while freeing system resources
            FormsMenuList.registerNewSaleForm.Dispose();
        }

        private void ViewCartLabel_MouseHover(object sender, EventArgs e)
        {
            FormsMenuList.registerNewSaleForm.viewCartLabel.ForeColor = Color.Blue;
        }

        private void ViewCartLabel_MouseLeave(object sender, EventArgs e)
        {
            FormsMenuList.registerNewSaleForm.viewCartLabel.ForeColor = Color.Black;
        }

        #region Log Out
        private void LogOutLabel_Click(object sender, EventArgs e)
        {
            // Executing correct log out processes
            SystemProtocols.ApplyLogOutProtocols();
            FormsMenuList.loginForm.Show();

            SystemProtocols.ApplyCartManagementProtocol(3, null, 0, null, 0); // clearing the cart before logging out

            // Closing form while freeing system resources
            FormsMenuList.registerNewSaleForm.Dispose();

        }

        private void LogOutLabel_MouseHover(object sender, EventArgs e)
        {
            FormsMenuList.registerNewSaleForm.logOutLabel.ForeColor = Color.Red;
        }

        private void LogOutLabel_MouseLeave(object sender, EventArgs e)
        {
            FormsMenuList.registerNewSaleForm.logOutLabel.ForeColor = Color.Black;
        }
        #endregion

        #endregion

        #region Text Changed Logic
        private void ProductSearchTextBox_TextChanged(object sender, EventArgs e)
        {
            PopulateProductDataGrid();
        }

        private void QuantityNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in productDataGridView.SelectedRows)
                if (quantityNumericUpDown.Maximum < FormatToInt(row.Cells[10].Value.ToString()))
                    quantityNumericUpDown.Maximum = FormatToInt(row.Cells[10].Value.ToString()); // update the numeric up down's maximum according to the selected items max quantity
        }
        #endregion

        #region Quantity Numeric Up Down Key Down Logic
        private void QuantityNumericUpDown_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                AddItemsToCart();
            else
                RegisterNewSaleFrom_KeyDown(sender, e);
        }
        #endregion

        #region Key Down Shortcut Logic
        private void RegisterNewSaleFrom_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F1:

                    #region View Sales
                    // Summon Sales Registry Form
                    FormsMenuList.salesRecordForm = new SalesRecordForm();
                    FormsMenuList.salesRecordForm.Show();

                    // Closing form while freeing system resources
                    FormsMenuList.registerNewSaleForm.Dispose();
                    #endregion

                    break;

                case Keys.F2:

                    // The user is already viewing the desired page
                    if (assistance < 3)
                        assistance++;
                    else
                        MessageBox.Show("\t---Menu Shortcuts---\n\n" +
                            "View Sales\t\t(F1)\n" +
                            "Make Sales\t(You are here!)\n" +
                            "Product Browser\t(F3)\n" +
                            "Register Product\t(F4)\n" +
                            "Restock Products\t(F5)\n" +
                            "View Users\t(F6)\n" +
                            "Register New User\t(F7)\n" +
                            "View Graphs\t(F8)\n" +
                            "View Reports\t(F9)\n" +
                            "View Activities Log\t(F10)\n" +
                            "View Errors Log\t(F11)\n" +
                            "View Cart\t\t(F12)");

                    break;

                case Keys.F3:

                    #region Product Browser
                    // Summon Product Browser Form
                    FormsMenuList.inventorySearchForm = new InventorySearchForm();
                    FormsMenuList.inventorySearchForm.Show();

                    // Closing form while freeing system resources
                    FormsMenuList.registerNewSaleForm.Dispose();
                    #endregion

                    break;

                case Keys.F4:

                    #region Register New Product
                    // Identifying correct protocol for current user in session
                    if (!SystemProtocols.ApplySessionsProtocols(1))
                    {
                        // Summon Register New Product Form
                        FormsMenuList.registerNewProduct = new RegisterNewProductForm();
                        FormsMenuList.registerNewProduct.Show();

                        // Closing form while freeing system resources
                        FormsMenuList.registerNewSaleForm.Dispose();
                    }
                    #endregion

                    break;

                case Keys.F5:

                    #region Restock Products 
                    if (!SystemProtocols.ApplySessionsProtocols(1))
                    {
                        // Summon Restock Products Form
                        FormsMenuList.restockProductsFrom = new RestockProductsForm();
                        FormsMenuList.restockProductsFrom.Show();

                        // Closing form while freeing system resources
                        FormsMenuList.registerNewSaleForm.Dispose();
                    }
                    #endregion

                    break;

                case Keys.F6:

                    #region View Users
                    if (!SystemProtocols.ApplySessionsProtocols(1))
                    {
                        // Summon Users Registry Form
                        FormsMenuList.usersRegistryForm = new UsersRegistryForm();
                        FormsMenuList.usersRegistryForm.Show();

                        // Closing form while freeing system resources
                        FormsMenuList.registerNewSaleForm.Dispose();
                    }
                    #endregion

                    break;

                case Keys.F7:

                    #region Register New User
                    if (!SystemProtocols.ApplySessionsProtocols(1))
                    {
                        // Summon Register New User Form
                        FormsMenuList.registerNewUserForm = new RegisterNewUserForm();
                        FormsMenuList.registerNewUserForm.Show();

                        // Closing form while freeing system resources
                        FormsMenuList.registerNewSaleForm.Dispose();
                    }
                    #endregion

                    break;

                case Keys.F8:

                    #region View Graphs
                    if (!SystemProtocols.ApplySessionsProtocols(1))
                    {
                        // Summon Graphs Analytics Form
                        FormsMenuList.graphsAnaliticsForm = new GraphsAnalyticsForm();
                        FormsMenuList.graphsAnaliticsForm.Show();

                        // Closing form while freeing system resources
                        FormsMenuList.registerNewSaleForm.Dispose();
                    }
                    #endregion

                    break;

                case Keys.F9:

                    #region View Reports
                    if (!SystemProtocols.ApplySessionsProtocols(1))
                    {
                        // Summon Reports Analytics Form
                        FormsMenuList.reportsAnalyticsForm = new ReportsAnalyticsForm();
                        FormsMenuList.reportsAnalyticsForm.Show();

                        // Closing form while freeing system resources
                        FormsMenuList.registerNewSaleForm.Dispose();
                    }
                    #endregion

                    break;

                case Keys.F10:

                    #region View Activities Log
                    if (!SystemProtocols.ApplySessionsProtocols(1))
                    {
                        // Summon Activity Logs Form
                        FormsMenuList.activitiesLogForm = new ActivitiesLogForm();
                        FormsMenuList.activitiesLogForm.Show();

                        // Closing form while freeing system resources
                        FormsMenuList.registerNewSaleForm.Dispose();
                    }
                    #endregion

                    break;

                case Keys.F11:

                    #region View Errors Log
                    if (!SystemProtocols.ApplySessionsProtocols(1))
                    {
                        // Summon Error Logs Form
                        FormsMenuList.errorsLogForm = new ErrorsLogForm();
                        FormsMenuList.errorsLogForm.Show();

                        // Closing form while freeing system resources
                        FormsMenuList.registerNewSaleForm.Dispose();
                    }
                    #endregion

                    break;

                case Keys.F12:

                    #region View Cart
                    // Summon View Cart Form
                    FormsMenuList.viewCartForm = new ViewCartForm();
                    FormsMenuList.viewCartForm.Show();

                    // Closing form while freeing system resources
                    FormsMenuList.registerNewSaleForm.Dispose();
                    #endregion

                    break;

                default:
                    break;
            }
        }
        #endregion

        #region Click Logic
        private void AddItemButton_Click(object sender, EventArgs e)
        {
            AddItemsToCart(); // adding items to cart
        }

        private void ClearCartButton_Click(object sender, EventArgs e)
        {
            SystemProtocols.ApplyCartManagementProtocol(3, null, 0, null, 0); // clearing the cart

            UpdateCartSummaryDataGrid(); // updating the cart summary
        }

        private void RemoveItemButton_Click(object sender, EventArgs e)
        {
            // Capturing the data of multiple selected products
            foreach (DataGridViewRow row in cartSummaryDataGridView.SelectedRows)
                // Adding product to cart or updating the amount of units of already added product
                SystemProtocols.ApplyCartManagementProtocol(4, row.Cells[0].Value.ToString(), 0, null, 0);

            UpdateCartSummaryDataGrid(); // updating the cart summary
        }

        private void RemoveOneButton_Click(object sender, EventArgs e)
        {
            // Capturing the data of multiple selected products
            foreach (DataGridViewRow row in cartSummaryDataGridView.SelectedRows)
                // Removing one unit from a product in the cart
                SystemProtocols.ApplyCartManagementProtocol(5, row.Cells[0].Value.ToString(), FormatToDecimal(row.Cells[9].Value.ToString()) / FormatToInt(row.Cells[10].Value.ToString()), null, 0);

            UpdateCartSummaryDataGrid(); // updating the cart summary
        }

        private void CompleteSaleButton_Click(object sender, EventArgs e)
        {
            if (SystemProtocols.ApplyCartManagementProtocol(1, null, 0, null, 0).Count > 0)
            {
                // Requesting the creation of a new transaction
                String message = SystemProtocols.ApplySalesTransactionProtocols(1, CreateSalesObject());

                if (message == "SUCCESS")
                {
                    MessageBox.Show("This transaction has been completed successfully!");

                    // Updating grids
                    PopulateProductDataGrid();
                    UpdateCartSummaryDataGrid();
                }
                else
                    MessageBox.Show("FATEL ERROR!"); // TODO: manage errors and exceptions
            }
            else
                MessageBox.Show("Please add items to complete a purchase.");
        }

        private void ProductDataGridView_Click(object sender, EventArgs e)
        {
            // Reseting the numeric up down
            quantityNumericUpDown.Value = 1;
            quantityNumericUpDown.Maximum = 2;
        }
        #endregion

        #region Auxiliary Functions
        /// <summary>
        /// Funtion to add one or more selected products into the cart
        /// </summary>
        private void AddItemsToCart()
        {
            try
            {
                // Capturing the data of multiple selected products
                foreach (DataGridViewRow row in productDataGridView.SelectedRows)
                    if (FormatToInt(row.Cells[10].Value.ToString()) > 0) // only works if the product in the inventory has atleast 1 unit in existence
                    {
                        Product product = new Product() // creating new product
                        {
                            Id = row.Cells[0].Value.ToString(), // getting the selected product's id
                            Name = row.Cells[2].Value.ToString(), // getting the selected product's name
                            Brand = row.Cells[3].Value.ToString(), // getting the selected product's brand
                            Unit = row.Cells[5].Value.ToString(), // getting the selected product's unit
                            UnitPrice = FormatToDecimal(row.Cells[9].Value.ToString()), // getting the selected product's price
                            Quantity = quantityNumericUpDown.Value < FormatToInt(row.Cells[10].Value.ToString()) ?  // getting the desired quantity of the selected product
                            (int)quantityNumericUpDown.Value : // the client desires less units than the limit in existence
                            FormatToInt(row.Cells[10].Value.ToString()) // the client wants all units in existence
                        };

                        // Adding product to cart or updating the amount of units of already added product
                        SystemProtocols.ApplyCartManagementProtocol(2, null, 0, product, FormatToInt(row.Cells[10].Value.ToString()));
                    }
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("Error: ERR18");

                // Recording error 
                SystemProtocols.ApplyActivityProtocols("ERR18");
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Error: ERR19");

                // Recording error 
                SystemProtocols.ApplyActivityProtocols("ERR19");
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("Error: ERR20");

                // Recording error 
                SystemProtocols.ApplyActivityProtocols("ERR20");
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: ERR21");

                // Recording error 
                SystemProtocols.ApplyActivityProtocols("ERR21", e.Message);
            }

            // Updating numeric up down
            quantityNumericUpDown.Value = 1;
            quantityNumericUpDown.Maximum = 2;

            UpdateCartSummaryDataGrid(); // updating the cart summary
        }

        /// <summary>
        /// Function that creates a sales object
        /// </summary>
        /// <returns>A sales object with user submitted input</returns>
        private Sale CreateSalesObject()
        {
            Sale sale = new Sale()
            {
                NumberItems = FormatToInt(numberLabel.Text.Split(':')[1]),
                Total = FormatToDecimal(totalLabel.Text.Split('$')[1]),
                Delivery = deliveryCheckBox.Checked
            };
            
            return sale;
        }

        /// <summary>
        /// Function to populate the product list data grid
        /// </summary>
        private void PopulateProductDataGrid()
        {
            // TODO: Create a separate fetchproduct list for this form
            productDataGridView.DataSource = ProductInformationManager.ConsultProductListInformation(productSearchTextBox.Text, true);

            // Hidding unnecessary fields
            productDataGridView.Columns["Id"].Visible = false;
            productDataGridView.Columns["Supplier"].Visible = false;
            productDataGridView.Columns["Category"].Visible = false;
            productDataGridView.Columns["Type"].Visible = false;
            productDataGridView.Columns["UnitCost"].Visible = false;
            productDataGridView.Columns["MinimumQuantity"].Visible = false;
            productDataGridView.Columns["MaximumQuantity"].Visible = false;
            productDataGridView.Columns["RegisteredBy"].Visible = false;
            productDataGridView.Columns["RegistrationDate"].Visible = false;
            productDataGridView.Columns["ModifiedBy"].Visible = false;
            productDataGridView.Columns["ModificationDate"].Visible = false;
            productDataGridView.Columns["Discontinued"].Visible = false;
            productDataGridView.Columns["Total"].Visible = false;

            // Formationg columns
            productDataGridView.Columns["Brand"].Width = 70;
            productDataGridView.Columns["Unit"].Width = 70;
        }

        /// <summary>
        /// Function to populate the cart summary data grid
        /// </summary>
        private void UpdateCartSummaryDataGrid()
        {
            // Code needed to refresh the cart summary
            cartSummaryDataGridView.DataSource = new List<Product>(); // reseting the datasource as a clean and empty list
            cartSummaryDataGridView.Refresh(); // refreshing the data grid to clean any old information an update it with the new one

            List<Product> summary = SystemProtocols.ApplyCartManagementProtocol(1, null, 0, null, 0); // fetching the cart            
            if (summary.Count > 0)
            {
                cartSummaryDataGridView.DataSource = summary; // feeding the grid view with the new information on the cart summary
                cartSummaryDataGridView.Refresh(); // refreshing the data grid to clean any old information an update it with the new one

                // Hidding unnecessary fields
                cartSummaryDataGridView.Columns["Id"].Visible = false;
                cartSummaryDataGridView.Columns["Key"].Visible = false;
                cartSummaryDataGridView.Columns["Brand"].Visible = false;
                cartSummaryDataGridView.Columns["Supplier"].Visible = false;
                cartSummaryDataGridView.Columns["Category"].Visible = false;
                cartSummaryDataGridView.Columns["Type"].Visible = false;
                cartSummaryDataGridView.Columns["UnitCost"].Visible = false;
                cartSummaryDataGridView.Columns["MinimumQuantity"].Visible = false;
                cartSummaryDataGridView.Columns["MaximumQuantity"].Visible = false;
                cartSummaryDataGridView.Columns["RegisteredBy"].Visible = false;
                cartSummaryDataGridView.Columns["RegistrationDate"].Visible = false;
                cartSummaryDataGridView.Columns["ModifiedBy"].Visible = false;
                cartSummaryDataGridView.Columns["ModificationDate"].Visible = false;
                cartSummaryDataGridView.Columns["Discontinued"].Visible = false;
                cartSummaryDataGridView.Columns["Total"].Visible = false;

                // Formationg columns
                cartSummaryDataGridView.Columns["Name"].Width = 180;
                cartSummaryDataGridView.Columns["Unit"].Width = 50;
                cartSummaryDataGridView.Columns["UnitPrice"].Width = 70;
                cartSummaryDataGridView.Columns["Quantity"].Width = 80;

                int quantity = 0; // variable to track the amount of items requested
                decimal total = 0; // variable to track the total of the entire purchase
                foreach (Product item in summary)
                {
                    quantity += item.Quantity; // counting how many products are in the cart
                    total += item.UnitPrice; // calculating the total price
                }

                // publishing the purchase information of a full cart
                numberLabel.Text = "Number of Item: " + quantity;
                totalLabel.Text = "Total: $" + total.ToString("0.00");
            }
            else
            {
                // publishing the purchase information of an empty cart
                numberLabel.Text = "Number of Item: 0";
                totalLabel.Text = "Total: $0.00";
            }
        }

        /// <summary>
        /// Function to convert strings to decimals
        /// </summary>
        /// <param name="value">String value needed to be converted</param>
        /// <returns>A decimal equivalent of the provided string value</returns>
        private static decimal FormatToDecimal(String value)
        {
            _ = decimal.TryParse(value, out decimal result);

            return result;
        }

        /// <summary>
        /// Function to convert strings to ints
        /// </summary>
        /// <param name="value">String value needed to be converted</param>
        /// <returns>An int equivalent of the provided string value</returns>
        private static int FormatToInt(String value)
        {
            _ = int.TryParse(value, out int result);

            return result;
        }
        #endregion
    }
}