﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Custom Libraries
using InventoryManagementBusinessLayer.ProductInformation;
using InventoryManagementBusinessLayer.Protocols;

namespace GeneralStoreInventoryManagementSystem
{
    public partial class InventorySearchForm : Form
    {
        List<ProductInformationTemplateForm> children = new List<ProductInformationTemplateForm>();

        int assistance = 0;

        public InventorySearchForm()
        {
            InitializeComponent();
        }

        #region Form Load Logic 
        private void InventorySearchForm_Load(object sender, EventArgs e)
        {
            // Identifying correct protocol for current user in session
            if (SystemProtocols.ApplySessionsProtocols(1, null, null))
            {
                // Disabling the entire Products option given the remainder of options are prohibited for a basic user
                productsMenuOption.Visible = false;
                productsMenuOption.Enabled = false;

                // Disabling all admin options
                adminMenuOption.Visible = false;
                adminMenuOption.Enabled = false;
            }

            PopulateProductListDataGrid(); // Initializing the data grid upon load

            // Executing correct activity according to given code
            SystemProtocols.ApplyActivityProtocols("INV1", null, null);
        }
        #endregion

        #region On Form Closing Override
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            // Disposing any open child
            DisposeAllChildren();

            // Executing correct log out processes
            SystemProtocols.ApplyLogOutProtocols();
            FormsMenuList.loginForm.Show();

            SystemProtocols.ApplyCartManagementProtocol(3, null, 0, null, 0); // clearing the cart before logging out

            // Closing form while freeing system resources
            FormsMenuList.inventorySearchForm.Dispose();
        }
        #endregion

        #region Menu Bar Options
        private void ViewSalesMenuSubOption_Click(object sender, EventArgs e)
        {
            // Summon Sales Registry Form
            FormsMenuList.salesRecordForm = new SalesRecordForm();
            FormsMenuList.salesRecordForm.Show();

            // Disposing any open child
            DisposeAllChildren();

            // Closing form while freeing system resources
            FormsMenuList.inventorySearchForm.Dispose();
        }

        private void MakeSaleMenuSubOption_Click(object sender, EventArgs e)
        {
            // Summon Register New Sale Form
            FormsMenuList.registerNewSaleForm = new RegisterNewSaleFrom();
            FormsMenuList.registerNewSaleForm.Show();

            // Disposing any open child
            DisposeAllChildren();

            // Closing form while freeing system resources
            FormsMenuList.inventorySearchForm.Dispose();
        }
        
        private void RegisterNewProductMenuSubOption_Click(object sender, EventArgs e)
        {
            // Summon Register New Product Form
            FormsMenuList.registerNewProduct = new RegisterNewProductForm();
            FormsMenuList.registerNewProduct.Show();

            // Disposing any open child
            DisposeAllChildren();

            // Closing form while freeing system resources
            FormsMenuList.inventorySearchForm.Dispose();
        }

        private void RestockProductsMenuSubOption_Click(object sender, EventArgs e)
        {
            // Summon Restock Products Form
            FormsMenuList.restockProductsFrom = new RestockProductsForm();
            FormsMenuList.restockProductsFrom.Show();

            // Disposing any open child
            DisposeAllChildren();

            // Closing form while freeing system resources
            FormsMenuList.inventorySearchForm.Dispose();
        }

        private void ViewUsersOption_Click(object sender, EventArgs e)
        {
            // Summon Users Registry Form
            FormsMenuList.usersRegistryForm = new UsersRegistryForm();
            FormsMenuList.usersRegistryForm.Show();

            // Disposing any open child
            DisposeAllChildren();

            // Closing form while freeing system resources
            FormsMenuList.inventorySearchForm.Dispose();
        }

        private void RegisterNewUserOption_Click(object sender, EventArgs e)
        {
            // Summon Register New User Form
            FormsMenuList.registerNewUserForm = new RegisterNewUserForm();
            FormsMenuList.registerNewUserForm.Show();

            // Disposing any open child
            DisposeAllChildren();

            // Closing form while freeing system resources
            FormsMenuList.inventorySearchForm.Dispose();
        }

        private void ViewGraphsOption_Click(object sender, EventArgs e)
        {
            // Summon Graphs Analytics Form
            FormsMenuList.graphsAnaliticsForm = new GraphsAnalyticsForm();
            FormsMenuList.graphsAnaliticsForm.Show();

            // Disposing any open child
            DisposeAllChildren();

            // Closing form while freeing system resources
            FormsMenuList.inventorySearchForm.Dispose();
        }

        private void ViewReportsOption_Click(object sender, EventArgs e)
        {
            // Summon Reports Analytics Form
            FormsMenuList.reportsAnalyticsForm = new ReportsAnalyticsForm();
            FormsMenuList.reportsAnalyticsForm.Show();

            // Disposing any open child
            DisposeAllChildren();

            // Closing form while freeing system resources
            FormsMenuList.inventorySearchForm.Dispose();
        }

        private void ViewActivityLogsOption_Click(object sender, EventArgs e)
        {
            // Summon Activity Logs Form
            FormsMenuList.activitiesLogForm = new ActivitiesLogForm();
            FormsMenuList.activitiesLogForm.Show();

            // Disposing any open child
            DisposeAllChildren();

            // Closing form while freeing system resources
            FormsMenuList.inventorySearchForm.Dispose();
        }

        private void ViewErrorLogsOption_Click(object sender, EventArgs e)
        {
            // Summon Error Logs Form
            FormsMenuList.errorsLogForm = new ErrorsLogForm();
            FormsMenuList.errorsLogForm.Show();

            // Disposing any open child
            DisposeAllChildren();

            // Closing form while freeing system resources
            FormsMenuList.inventorySearchForm.Dispose();
        }

        private void ViewCartLabel_Click(object sender, EventArgs e)
        {
            // Summon View Cart Form
            FormsMenuList.viewCartForm = new ViewCartForm();
            FormsMenuList.viewCartForm.Show();

            // Disposing any open child
            DisposeAllChildren();

            // Closing form while freeing system resources
            FormsMenuList.inventorySearchForm.Dispose();
        }

        private void ViewCartLabel_MouseHover(object sender, EventArgs e)
        {
            viewCartLabel.ForeColor = System.Drawing.Color.Blue;
        }

        private void ViewCartLabel_MouseLeave(object sender, EventArgs e)
        {
            viewCartLabel.ForeColor = Color.Black;
        }

        #region Log Out
        private void LogOutLabel_Click(object sender, EventArgs e)
        {
            // Executing correct log out processes
            SystemProtocols.ApplyLogOutProtocols();
            FormsMenuList.loginForm.Show();

            SystemProtocols.ApplyCartManagementProtocol(3, null, 0, null, 0); // clearing the cart before logging out

            // Disposing any open child
            DisposeAllChildren();

            // Closing form while freeing system resources
            FormsMenuList.inventorySearchForm.Dispose();
        }

        private void LogOutLabel_MouseHover(object sender, EventArgs e)
        {
            logOutLabel.ForeColor = Color.Red;
        }

        private void LogOutLabel_MouseLeave(object sender, EventArgs e)
        {
            logOutLabel.ForeColor = Color.Black;
        }
        #endregion

        #endregion

        #region Key Down Shortcut Logic
        private void InventoryBrowserForm_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F1:

                    #region View Sales
                    // Summon Sales Registry Form
                    FormsMenuList.salesRecordForm = new SalesRecordForm();
                    FormsMenuList.salesRecordForm.Show();

                    // Disposing any open child
                    DisposeAllChildren();

                    // Closing form while freeing system resources
                    FormsMenuList.inventorySearchForm.Dispose();
                    #endregion

                    break;

                case Keys.F2:

                    #region Make a Sale
                    // Summon Register New Sale Form
                    FormsMenuList.registerNewSaleForm = new RegisterNewSaleFrom();
                    FormsMenuList.registerNewSaleForm.Show();

                    // Disposing any open child
                    DisposeAllChildren();

                    // Closing form while freeing system resources
                    FormsMenuList.inventorySearchForm.Dispose();
                    #endregion

                    break;

                case Keys.F3:

                    // The user is already viewing the desired page
                    if (assistance < 3)
                        assistance++;
                    else
                        MessageBox.Show("\t---Menu Shortcuts---\n\n" +
                            "View Sales\t\t(F1)\n" +
                            "Make Sales\t(F2)\n" +
                            "Product Browser\t(You are here!)\n" +
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

                case Keys.F4:

                    #region Register New Product
                    // Identifying correct protocol for current user in session
                    if (!SystemProtocols.ApplySessionsProtocols(1, null, null))
                    {
                        // Summon Register New Product Form
                        FormsMenuList.registerNewProduct = new RegisterNewProductForm();
                        FormsMenuList.registerNewProduct.Show();

                        // Disposing any open child
                        DisposeAllChildren();

                        // Closing form while freeing system resources
                        FormsMenuList.inventorySearchForm.Dispose();
                    }
                    #endregion

                    break;

                case Keys.F5:

                    #region Restock Products
                    // Identifying correct protocol for current user in session
                    if (!SystemProtocols.ApplySessionsProtocols(1, null, null))
                    {
                        // Summon Restock Products Form
                        FormsMenuList.restockProductsFrom = new RestockProductsForm();
                        FormsMenuList.restockProductsFrom.Show();

                        // Disposing any open child
                        DisposeAllChildren();

                        // Closing form while freeing system resources
                        FormsMenuList.inventorySearchForm.Dispose();
                    }
                    #endregion

                    break;

                case Keys.F6:

                    #region View Users
                    // Identifying correct protocol for current user in session
                    if (!SystemProtocols.ApplySessionsProtocols(1, null, null))
                    {
                        // Summon Users Registry Form
                        FormsMenuList.usersRegistryForm = new UsersRegistryForm();
                        FormsMenuList.usersRegistryForm.Show();

                        // Disposing any open child
                        DisposeAllChildren();

                        // Closing form while freeing system resources
                        FormsMenuList.inventorySearchForm.Dispose();
                    }
                    #endregion

                    break;

                case Keys.F7:

                    #region Register New User
                    // Identifying correct protocol for current user in session
                    if (!SystemProtocols.ApplySessionsProtocols(1, null, null))
                    {
                        // Summon Register New User Form
                        FormsMenuList.registerNewUserForm = new RegisterNewUserForm();
                        FormsMenuList.registerNewUserForm.Show();

                        // Disposing any open child
                        DisposeAllChildren();

                        // Closing form while freeing system resources
                        FormsMenuList.inventorySearchForm.Dispose();
                    }
                    #endregion

                    break;

                case Keys.F8:

                    #region Graphs Analytics
                    // Identifying correct protocol for current user in session
                    if (!SystemProtocols.ApplySessionsProtocols(1, null, null))
                    {
                        // Summon Graphs Analytics Form
                        FormsMenuList.graphsAnaliticsForm = new GraphsAnalyticsForm();
                        FormsMenuList.graphsAnaliticsForm.Show();

                        // Disposing any open child
                        DisposeAllChildren();

                        // Closing form while freeing system resources
                        FormsMenuList.inventorySearchForm.Dispose();
                    }
                    #endregion

                    break;

                case Keys.F9:

                    #region Reports Analytics
                    // Identifying correct protocol for current user in session
                    if (!SystemProtocols.ApplySessionsProtocols(1, null, null))
                    {
                        // Summon Reports Analytics Form
                        FormsMenuList.reportsAnalyticsForm = new ReportsAnalyticsForm();
                        FormsMenuList.reportsAnalyticsForm.Show();

                        // Disposing any open child
                        DisposeAllChildren();

                        // Closing form while freeing system resources
                        FormsMenuList.inventorySearchForm.Dispose();
                    }
                    #endregion

                    break;

                case Keys.F10:

                    #region Activity Logs
                    // Identifying correct protocol for current user in session
                    if (!SystemProtocols.ApplySessionsProtocols(1, null, null))
                    {
                        // Summon Activity Logs Form
                        FormsMenuList.activitiesLogForm = new ActivitiesLogForm();
                        FormsMenuList.activitiesLogForm.Show();

                        // Disposing any open child
                        DisposeAllChildren();

                        // Closing form while freeing system resources
                        FormsMenuList.inventorySearchForm.Dispose();
                    }
                    #endregion

                    break;

                case Keys.F11:

                    #region Error Logs
                    // Identifying correct protocol for current user in session
                    if (!SystemProtocols.ApplySessionsProtocols(1, null, null))
                    {
                        // Summon Error Logs Form
                        FormsMenuList.errorsLogForm = new ErrorsLogForm();
                        FormsMenuList.errorsLogForm.Show();

                        // Disposing any open child
                        DisposeAllChildren();

                        // Closing form while freeing system resources
                        FormsMenuList.inventorySearchForm.Dispose();
                    }
                    #endregion

                    break;

                case Keys.F12:

                    #region View Cart
                    // Summon View Cart Form
                    FormsMenuList.viewCartForm = new ViewCartForm();
                    FormsMenuList.viewCartForm.Show();

                    // Disposing any open child
                    DisposeAllChildren();

                    // Closing form while freeing system resources
                    FormsMenuList.inventorySearchForm.Dispose();
                    #endregion

                    break;

                default:
                    break;
            }
        }
        #endregion

        #region Inventory Seach Text Box Logic
        private void InventorySearchBox_TextChanged(object sender, EventArgs e)
        {
            PopulateProductListDataGrid();
        }
        #endregion

        #region Function that allows users to view the quick summary of a selected product
        private void ProductList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!SystemProtocols.ApplySessionsProtocols(1, null, null))
            {
                // Declare an non oficial auxiliary form to display product information, given a product's internal identification number
                ProductInformationTemplateForm child = new ProductInformationTemplateForm(productList.SelectedCells[0].Value.ToString());
                child.Show(); // Summon the temporary summary form 

                children.Add(child); // adding product to list of children
            }
        }
        #endregion

        #region Auxiliary Functions
        /// <summary>
        /// Function used to populate the data grid with products from the registered inventory
        /// </summary>
        private void PopulateProductListDataGrid()
        {
            // Requesting information to populate the product list 
            productList.DataSource = ProductInformationManager.ConsultProductListInformation(inventorySearchBox.Text, false);

            //productList.Sort(productList.Columns["Key"], ListSortDirection.Ascending);
            //productList.Columns["Key"].SortMode = DataGridViewColumnSortMode.Automatic;
            //productList.Columns["Name"].SortMode = DataGridViewColumnSortMode.Automatic;
            //productList.Columns["Brand"].SortMode = DataGridViewColumnSortMode.Automatic;
            //productList.Columns["Supplier"].SortMode = DataGridViewColumnSortMode.Automatic;

            // TODO: Fix sortable mode on inventory browser
            foreach (DataGridViewColumn column in productList.Columns)
                column.SortMode = DataGridViewColumnSortMode.Automatic;

            // Remove unnecesary information from the datagrid display
            productList.Columns["Id"].Visible = false;
            productList.Columns["Category"].Visible = false;
            productList.Columns["Type"].Visible = false;
            productList.Columns["MinimumQuantity"].Visible = false;
            productList.Columns["MaximumQuantity"].Visible = false;
            productList.Columns["RegisteredBy"].Visible = false;
            productList.Columns["RegistrationDate"].Visible = false;
            productList.Columns["ModifiedBy"].Visible = false;
            productList.Columns["ModificationDate"].Visible = false;
            productList.Columns["Total"].Visible = false;

        }

        /// <summary>
        /// Function that allows children from to updat this parent's information
        /// </summary>
        public void RefreshInventoryInformation()
        {
            PopulateProductListDataGrid();
        }

        /// <summary>
        /// Function that disposes any children of this form that have been left open
        /// </summary>
        private void DisposeAllChildren()
        {
            // Closing all open children form
            foreach (ProductInformationTemplateForm child in children)
                child.Dispose();
        }
        #endregion
    }
}
