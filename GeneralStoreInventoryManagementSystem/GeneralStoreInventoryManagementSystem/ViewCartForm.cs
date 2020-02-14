﻿using System;
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
    public partial class ViewCartForm : Form
    {
        public ViewCartForm()
        {
            InitializeComponent();
        }

        #region Load Form Logic
        private void ViewCartForm_Load(object sender, EventArgs e)
        {
            // Identifying correct protocol for current user in session
            if (SystemProtocols.ApplySessionsProtocols(1, null, null))
            {
                // Disabling the other Products option 
                registerNewProductMenuSubOption.Visible = false;
                registerNewProductMenuSubOption.Enabled = false;
                restockProductsMenuSubOption.Visible = false;
                restockProductsMenuSubOption.Enabled = false;

                // Disabling all admin options
                adminMenuOption.Visible = false;
                adminMenuOption.Enabled = false;
            }

            PopulateCartSummaryDataGrid();

            SystemProtocols.ApplyActivityProtocols("CAR1", null, null);
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
            FormsMenuList.viewCartForm.Dispose();
        }
        #endregion

        #region Menu Bar Options
        private void ViewSalesMenuSubOption_Click(object sender, EventArgs e)
        {
            // Summon Sales Registry Form
            FormsMenuList.salesRecordForm = new SalesRecordForm();
            FormsMenuList.salesRecordForm.Show();

            // Closing form while freeing system resources
            FormsMenuList.viewCartForm.Dispose();
        }

        private void MakeSaleMenuSubOption_Click(object sender, EventArgs e)
        {
            // Summon Register New Sale Form
            FormsMenuList.registerNewSaleForm = new RegisterNewSaleFrom();
            FormsMenuList.registerNewSaleForm.Show();

            // Closing form while freeing system resources
            FormsMenuList.viewCartForm.Dispose();
        }

        private void BrowseProductsMenuSubOption_Click(object sender, EventArgs e)
        {
            // Summon Product Browser Form
            FormsMenuList.inventorySearchForm = new InventorySearchForm();
            FormsMenuList.inventorySearchForm.Show();

            // Closing form while freeing system resources
            FormsMenuList.viewCartForm.Dispose();
        }

        private void RegisterNewProductMenuSubOption_Click(object sender, EventArgs e)
        {
            // Summon Register New Product Form
            FormsMenuList.registerNewProduct = new RegisterNewProductForm();
            FormsMenuList.registerNewProduct.Show();

            // Closing form while freeing system resources
            FormsMenuList.viewCartForm.Dispose();
        }

        private void RestockProductsMenuSubOption_Click(object sender, EventArgs e)
        {
            // Summon Restock Products Form
            FormsMenuList.restockProductsFrom = new RestockProductsForm();
            FormsMenuList.restockProductsFrom.Show();

            // Closing form while freeing system resources
            FormsMenuList.viewCartForm.Dispose();
        }

        private void ViewUsersOption_Click(object sender, EventArgs e)
        {
            // Summon Users Registry Form
            FormsMenuList.usersRegistryForm = new UsersRegistryForm();
            FormsMenuList.usersRegistryForm.Show();

            // Closing form while freeing system resources
            FormsMenuList.viewCartForm.Dispose();
        }

        private void RegisterNewUserOption_Click(object sender, EventArgs e)
        {
            // Summon Register New User Form
            FormsMenuList.registerNewUserForm = new RegisterNewUserForm();
            FormsMenuList.registerNewUserForm.Show();

            // Closing form while freeing system resources
            FormsMenuList.viewCartForm.Dispose();
        }

        private void ViewGraphsOption_Click(object sender, EventArgs e)
        {
            // Summon Graphs Analytics Form
            FormsMenuList.graphsAnaliticsForm = new GraphsAnalyticsForm();
            FormsMenuList.graphsAnaliticsForm.Show();

            // Closing form while freeing system resources
            FormsMenuList.viewCartForm.Dispose();
        }

        private void ViewReportsOption_Click(object sender, EventArgs e)
        {
            // Summon Reports Analytics Form
            FormsMenuList.reportsAnalyticsForm = new ReportsAnalyticsForm();
            FormsMenuList.reportsAnalyticsForm.Show();

            // Closing form while freeing system resources
            FormsMenuList.viewCartForm.Dispose();
        }

        private void ViewActivityLogsOption_Click(object sender, EventArgs e)
        {
            // Summon Activity Logs Form
            FormsMenuList.activitiesLogForm = new ActivitiesLogForm();
            FormsMenuList.activitiesLogForm.Show();

            // Closing form while freeing system resources
            FormsMenuList.viewCartForm.Dispose();
        }

        private void ViewErrorLogsOption_Click(object sender, EventArgs e)
        {
            // Summon Error Logs Form
            FormsMenuList.errorsLogForm = new ErrorsLogForm();
            FormsMenuList.errorsLogForm.Show();

            // Closing form while freeing system resources
            FormsMenuList.viewCartForm.Dispose();
        }

        #region Log Out
        private void LogOutLabel_Click(object sender, EventArgs e)
        {
            // Executing correct log out processes
            SystemProtocols.ApplyLogOutProtocols();
            FormsMenuList.loginForm.Show();

            SystemProtocols.ApplyCartManagementProtocol(3, null, 0, null, 0); // clearing the cart before logging out

            // Closing form while freeing system resources
            FormsMenuList.viewCartForm.Dispose();
        }

        private void LogOutLabel_MouseHover(object sender, EventArgs e)
        {
            FormsMenuList.viewCartForm.logOutLabel.ForeColor = Color.Red;
        }

        private void LogOutLabel_MouseLeave(object sender, EventArgs e)
        {
            FormsMenuList.viewCartForm.logOutLabel.ForeColor = Color.Black;
        }
        #endregion

        #endregion

        #region Button Click Logic
        private void ClearCartButton_Click(object sender, EventArgs e)
        {
            SystemProtocols.ApplyCartManagementProtocol(3, null, 0, null, 0); // clearing the cart

            PopulateCartSummaryDataGrid();
        }

        private void RemoveOneButton_Click(object sender, EventArgs e)
        {
            // Capturing the data of multiple selected products
            foreach (DataGridViewRow row in cartSummaryDataGridView.SelectedRows)
                // Adding product to cart or updating the amount of units of already added product
                SystemProtocols.ApplyCartManagementProtocol(4, row.Cells[0].Value.ToString(), 0, null, 0);

            PopulateCartSummaryDataGrid();
        }

        private void RemoveItemButton_Click(object sender, EventArgs e)
        {
            // Capturing the data of multiple selected products
            foreach (DataGridViewRow row in cartSummaryDataGridView.SelectedRows)
                // Adding product to cart or updating the amount of units of already added product
                SystemProtocols.ApplyCartManagementProtocol(4, row.Cells[0].Value.ToString(), 0, null, 0);

            PopulateCartSummaryDataGrid();
        }

        private void CompleteSaleButton_Click(object sender, EventArgs e)
        {
            // Requesting the creation of a new transaction
            String message = SystemProtocols.ApplySalesTransactionProtocols(1, CreateSalesObject());

            if (message == "SUCCESS")
            {
                MessageBox.Show("This transaction has been completed successfully!");

                // Updating grid
                PopulateCartSummaryDataGrid();
            }
            else
                MessageBox.Show("FATEL ERROR!"); // TODO: manage errors and exceptions
        }
        #endregion

        #region Auxiliary Function
        private void PopulateCartSummaryDataGrid()
        {
            List<Product> summary = SystemProtocols.ApplyCartManagementProtocol(1, null, 0, null, 0); // fetching the cart            
            if (summary.Count() > 0)
            {
                cartSummaryDataGridView.DataSource = summary; // feeding the grid view with the new information on the cart summary
                cartSummaryDataGridView.Refresh(); // refreshing the data grid to clean any old information an update it with the new one

                // Hidding unnecessary fields
                cartSummaryDataGridView.Columns["Id"].Visible = false;
                cartSummaryDataGridView.Columns["Key"].Visible = false;
                //cartSummaryDataGridView.Columns["Brand"].Visible = false;
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

                // Formationg columns
                cartSummaryDataGridView.Columns["Name"].Width = 210;
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
        /// Function that creates a sales object
        /// </summary>
        /// <returns>A sales object with user submitted input</returns>
        private Sale CreateSalesObject()
        {
            Sale sale = new Sale();

            sale.NumberItems = FormatToInt(numberLabel.Text.Split(':')[1]);
            sale.Total = FormatToDecimal(totalLabel.Text.Split('$')[1]);
            sale.Delivery = deliveryCheckBox.Checked;

            return sale;
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
        #endregion
    }
}
