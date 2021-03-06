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
using InventoryManagementEntityLayer.Product;

namespace GeneralStoreInventoryManagementSystem
{
    public partial class RegisterNewProductForm : Form
    {
        int assistance = 0;

        public RegisterNewProductForm()
        {
            InitializeComponent();
        }

        #region Load Form Logic
        private void RegisterNewProductForm_Load(object sender, EventArgs e)
        {
            // Identifying correct protocol for current user in session
            if (SystemProtocols.ApplySessionsProtocols(1, null, null))
            {
                // Disabling the other Products option 
                restockProductsMenuSubOption.Visible = false;
                restockProductsMenuSubOption.Enabled = false;

                // Disabling all admin options
                adminMenuOption.Visible = false;
                adminMenuOption.Enabled = false;
            }

            PopulateBrandListBox();
            PopulateSupplierListBox();
            PopulateCategoryComboBox();
            PopulateTypeComboBox();

            // Executing correct activity according to given code
            SystemProtocols.ApplyActivityProtocols("PRO2", null, null);
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
            FormsMenuList.registerNewProduct.Dispose();
        }
        #endregion

        #region Menu Bar Options
        private void ViewSalesMenuSubOption_Click(object sender, EventArgs e)
        {
            // Summon Sales Registry Form
            FormsMenuList.salesRecordForm = new SalesRecordForm();
            FormsMenuList.salesRecordForm.Show();

            // Closing form while freeing system resources
            FormsMenuList.registerNewProduct.Dispose();
        }

        private void MakeSaleMenuSubOption_Click(object sender, EventArgs e)
        {
            // Summon Register New Sale Form
            FormsMenuList.registerNewSaleForm = new RegisterNewSaleFrom();
            FormsMenuList.registerNewSaleForm.Show();

            // Closing form while freeing system resources
            FormsMenuList.registerNewProduct.Dispose();
        }

        private void BrowseProductsMenuSubOption_Click(object sender, EventArgs e)
        {
            // Summon Product Browser Form
            FormsMenuList.inventorySearchForm = new InventorySearchForm();
            FormsMenuList.inventorySearchForm.Show();

            // Closing form while freeing system resources
            FormsMenuList.registerNewProduct.Dispose();
        }

        private void RestockProductsMenuSubOption_Click(object sender, EventArgs e)
        {
            // Summon Restock Products Form
            FormsMenuList.restockProductsFrom = new RestockProductsForm();
            FormsMenuList.restockProductsFrom.Show();

            // Closing form while freeing system resources
            FormsMenuList.registerNewProduct.Dispose();
        }

        private void ViewUsersOption_Click(object sender, EventArgs e)
        {
            // Summon Users Registry Form
            FormsMenuList.usersRegistryForm = new UsersRegistryForm();
            FormsMenuList.usersRegistryForm.Show();

            // Closing form while freeing system resources
            FormsMenuList.registerNewProduct.Dispose();
        }

        private void RegisterNewUserOption_Click(object sender, EventArgs e)
        {
            // Summon Register New User Form
            FormsMenuList.registerNewUserForm = new RegisterNewUserForm();
            FormsMenuList.registerNewUserForm.Show();

            // Closing form while freeing system resources
            FormsMenuList.registerNewProduct.Dispose();
        }

        private void ViewGraphsOption_Click(object sender, EventArgs e)
        {
            // Summon Graphs Analytics Form
            FormsMenuList.graphsAnaliticsForm = new GraphsAnalyticsForm();
            FormsMenuList.graphsAnaliticsForm.Show();

            // Closing form while freeing system resources
            FormsMenuList.registerNewProduct.Dispose();
        }

        private void ViewReportsOption_Click(object sender, EventArgs e)
        {
            // Summon Reports Analytics Form
            FormsMenuList.reportsAnalyticsForm = new ReportsAnalyticsForm();
            FormsMenuList.reportsAnalyticsForm.Show();

            // Closing form while freeing system resources
            FormsMenuList.registerNewProduct.Dispose();
        }

        private void ViewActivityLogsOption_Click(object sender, EventArgs e)
        {
            // Summon Activity Logs Form
            FormsMenuList.activitiesLogForm = new ActivitiesLogForm();
            FormsMenuList.activitiesLogForm.Show();

            // Closing form while freeing system resources
            FormsMenuList.registerNewProduct.Dispose();
        }

        private void ViewErrorLogsOption_Click(object sender, EventArgs e)
        {
            // Summon Error Logs Form
            FormsMenuList.errorsLogForm = new ErrorsLogForm();
            FormsMenuList.errorsLogForm.Show();

            // Closing form while freeing system resources
            FormsMenuList.registerNewProduct.Dispose();
        }

        private void ViewCartLabel_Click(object sender, EventArgs e)
        {
            // Summon View Cart Form
            FormsMenuList.viewCartForm = new ViewCartForm();
            FormsMenuList.viewCartForm.Show();

            // Closing form while freeing system resources
            FormsMenuList.registerNewProduct.Dispose();
        }

        private void ViewCartLabel_MouseHover(object sender, EventArgs e)
        {
            FormsMenuList.registerNewProduct.viewCartLabel.ForeColor = Color.Blue;
        }

        private void ViewCartLabel_MouseLeave(object sender, EventArgs e)
        {
            FormsMenuList.registerNewProduct.viewCartLabel.ForeColor = Color.Black;
        }

        #region Log Out
        private void LogOutLabel_Click(object sender, EventArgs e)
        {
            // Executing correct log out processes
            SystemProtocols.ApplyLogOutProtocols();
            FormsMenuList.loginForm.Show();

            SystemProtocols.ApplyCartManagementProtocol(3, null, 0, null, 0); // clearing the cart before logging out

            // Closing form while freeing system resources
            FormsMenuList.registerNewProduct.Dispose();
        }

        private void LogOutLabel_MouseHover(object sender, EventArgs e)
        {
            FormsMenuList.registerNewProduct.logOutLabel.ForeColor = Color.Red;
        }

        private void LogOutLabel_MouseLeave(object sender, EventArgs e)
        {
            FormsMenuList.registerNewProduct.logOutLabel.ForeColor = Color.Black;
        }
        #endregion

        #endregion

        #region Key Down Shortcut Logic
        private void RegisterNewProductForm_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F1:

                    #region View Sales
                    // Summon Sales Registry Form
                    FormsMenuList.salesRecordForm = new SalesRecordForm();
                    FormsMenuList.salesRecordForm.Show();

                    // Closing form while freeing system resources
                    FormsMenuList.registerNewProduct.Dispose();
                    #endregion

                    break;

                case Keys.F2:

                    #region Make Sales
                    // Summon Register New Sale Form
                    FormsMenuList.registerNewSaleForm = new RegisterNewSaleFrom();
                    FormsMenuList.registerNewSaleForm.Show();

                    // Closing form while freeing system resources
                    FormsMenuList.registerNewProduct.Dispose();
                    #endregion

                    break;

                case Keys.F3:

                    #region Product Browser
                    // Summon Product Browser Form
                    FormsMenuList.inventorySearchForm = new InventorySearchForm();
                    FormsMenuList.inventorySearchForm.Show();

                    // Closing form while freeing system resources
                    FormsMenuList.registerNewProduct.Dispose();
                    #endregion

                    break;

                case Keys.F4:

                    // The user is already viewing the desired page
                    if (assistance < 3)
                        assistance++;
                    else
                        MessageBox.Show("\t---Menu Shortcuts---\n\n" +
                            "View Sales\t\t(F1)\n" +
                            "Make Sales\t(F2)\n" +
                            "Product Browser\t(F3)\n" +
                            "Register Product\t(You are here!)\n" +
                            "Restock Products\t(F5)\n" +
                            "View Users\t(F6)\n" +
                            "Register New User\t(F7)\n" +
                            "View Graphs\t(F8)\n" +
                            "View Reports\t(F9)\n" +
                            "View Activities Log\t(F10)\n" +
                            "View Errors Log\t(F11)\n" +
                            "View Cart\t\t(F12)");

                    break;

                case Keys.F5:

                    #region Restock Product
                    // Identifying correct protocol for current user in session
                    if (!SystemProtocols.ApplySessionsProtocols(1, null, null))
                    {
                        // Summon Restock Products Form
                        FormsMenuList.restockProductsFrom = new RestockProductsForm();
                        FormsMenuList.restockProductsFrom.Show();

                        // Closing form while freeing system resources
                        FormsMenuList.registerNewProduct.Dispose();
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

                        // Closing form while freeing system resources
                        FormsMenuList.registerNewProduct.Dispose();
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

                        // Closing form while freeing system resources
                        FormsMenuList.registerNewProduct.Dispose();
                    }
                    #endregion

                    break;

                case Keys.F8:

                    #region View Graphs
                    // Identifying correct protocol for current user in session
                    if (!SystemProtocols.ApplySessionsProtocols(1, null, null))
                    {
                        // Summon Graphs Analytics Form
                        FormsMenuList.graphsAnaliticsForm = new GraphsAnalyticsForm();
                        FormsMenuList.graphsAnaliticsForm.Show();

                        // Closing form while freeing system resources
                        FormsMenuList.registerNewProduct.Dispose();
                    }
                    #endregion

                    break;

                case Keys.F9:

                    #region View Reports
                    // Identifying correct protocol for current user in session
                    if (!SystemProtocols.ApplySessionsProtocols(1, null, null))
                    {
                        // Summon Reports Analytics Form
                        FormsMenuList.reportsAnalyticsForm = new ReportsAnalyticsForm();
                        FormsMenuList.reportsAnalyticsForm.Show();

                        // Closing form while freeing system resources
                        FormsMenuList.registerNewProduct.Dispose();
                    }
                    #endregion

                    break;

                case Keys.F10:

                    #region View Activities Log
                    // Identifying correct protocol for current user in session
                    if (!SystemProtocols.ApplySessionsProtocols(1, null, null))
                    {
                        // Summon Activity Logs Form
                        FormsMenuList.activitiesLogForm = new ActivitiesLogForm();
                        FormsMenuList.activitiesLogForm.Show();

                        // Closing form while freeing system resources
                        FormsMenuList.registerNewProduct.Dispose();
                    }
                    #endregion

                    break;

                case Keys.F11:

                    #region View Errors Log
                    // Identifying correct protocol for current user in session
                    if (!SystemProtocols.ApplySessionsProtocols(1, null, null))
                    {
                        // Summon Error Logs Form
                        FormsMenuList.errorsLogForm = new ErrorsLogForm();
                        FormsMenuList.errorsLogForm.Show();

                        // Closing form while freeing system resources
                        FormsMenuList.registerNewProduct.Dispose();
                    }
                    #endregion

                    break;

                case Keys.F12:

                    #region View Cart
                    // Summon View Cart Form
                    FormsMenuList.viewCartForm = new ViewCartForm();
                    FormsMenuList.viewCartForm.Show();

                    // Closing form while freeing system resources
                    FormsMenuList.registerNewProduct.Dispose();
                    #endregion

                    break;

                default:
                    break;
            }
        }
        #endregion

        #region Text Changed Logic
        private void BrandSearchBox_TextChanged(object sender, EventArgs e)
        {
            PopulateBrandListBox();
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            nameTextBox.BackColor = Color.White;
        }

        private void UnitTextBox_TextChanged(object sender, EventArgs e)
        {
            unitTextBox.BackColor = Color.White;
        }

        private void CostNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            priceNumericUpDown.Value = costNumericUpDown.Value;

            unitContributionMarginLabel.Text = CalculateUnitContributionMargin();
        }

        private void PriceNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            unitContributionMarginLabel.Text = CalculateUnitContributionMargin();

            if (priceNumericUpDown.Value > costNumericUpDown.Value)
                unitContributionMarginLabel.ForeColor = Color.Green;
            else if (priceNumericUpDown.Value < costNumericUpDown.Value)
                unitContributionMarginLabel.ForeColor = Color.Red;
            else
                unitContributionMarginLabel.ForeColor = Color.Black;
        }

        private void MinimumNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            maximumNumericUpDown.Minimum = minimumNumericUpDown.Value;
            maximumNumericUpDown.Value = minimumNumericUpDown.Value + 1;
        }

        private void SupplierSearchBox_TextChanged(object sender, EventArgs e)
        {
            PopulateSupplierListBox();
        }
        #endregion

        #region Mouse Hover and Leave Logic
        private void UnitContributionMarginLabel_MouseHover(object sender, EventArgs e)
        {
            unitContributionMarginLabel.Text = "This is the unit contribution cost.";
        }

        private void UnitContributionMarginLabel_MouseLeave(object sender, EventArgs e)
        {
            unitContributionMarginLabel.Text = CalculateUnitContributionMargin();
        }
        #endregion

        #region Button Click Logic
        private void AddNewBrandButton_Click(object sender, EventArgs e)
        {
            // Registering new product brand
            String message = ProductInformationManager.CreateNewProductBrandInformation(brandSearchBox.Text);

            if (message == "SUCCESS")
            {
                brandSearchBox.Text = "";
                PopulateBrandListBox();
            }
            else
                MessageBox.Show("This product already exists");
        }

        private void AddNewSupplierButton_Click(object sender, EventArgs e)
        {
            // Incomplete registration of new supplier
            String message = ProductInformationManager.CreateNewIncompleteProductSupplierInformation(supplierSearchBox.Text);

            if (message == "SUCCESS")
            {
                supplierSearchBox.Text = "";
                PopulateSupplierListBox();
            }
            else
                MessageBox.Show("This supplier already exists");
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ClearFormBuffer();
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            if (ValidateUserInput())
            {
                // Requesting registration of a new product in the inventory
                String message = ProductInformationManager.CreateNewProductInformation(CreateProductObject());

                if (message == "SUCCESS")
                {
                    MessageBox.Show("Product, " + nameTextBox.Text.ToUpper() + ", was successfully registered!");
                    ClearFormBuffer();
                }
                else
                    MessageBox.Show("Product, " + nameTextBox.Text.ToUpper() + ", was already registered with the same information.");
            }
            else
                MessageBox.Show("Plesae fill in all information correctly.");
        }
        #endregion

        #region Auxiliary Functions
        /// <summary>
        /// Function that calculates the unit contribution margin ratio of the product using the unit cost and price
        /// UPM = (UP - UC) / UP * 100
        /// </summary>
        /// <returns>The string result of the formula</returns>
        private String CalculateUnitContributionMargin()
        {
            // Applying unitary profit margin formula
            decimal contributionRatio = ((priceNumericUpDown.Value - costNumericUpDown.Value) / priceNumericUpDown.Value) * 100;

            decimal contributionDollar = priceNumericUpDown.Value - costNumericUpDown.Value;

            decimal priceIncrease = priceNumericUpDown.Value / costNumericUpDown.Value;

            return contributionRatio.ToString("0.##") + "% ($" + contributionDollar.ToString("0.##") + " or " + (priceIncrease.ToString("0.##") == "1" ? "1" : priceIncrease.ToString("0.##")) + "x price increase)";
        }

        /// <summary>
        /// Function that cleans user input buffers
        /// </summary>
        private void ClearFormBuffer()
        {
            keyTextBox.Text = "";
            nameTextBox.Text = "";
            brandSearchBox.Text = "";
            supplierSearchBox.Text = "";
            unitTextBox.Text = "";
            costNumericUpDown.Value = (decimal)0.01;
            priceNumericUpDown.Value = (decimal)0.01;
            quantityNumericUpDown.Value = 1;
            minimumNumericUpDown.Value = 1;
            maximumNumericUpDown.Value = 2;
        }

        /// <summary>
        /// Function that creates a project oobject based on user's input
        /// </summary>
        /// <returns>A product object</returns>
        private Product CreateProductObject()
        {
            Product product = new Product(); // Create new product object 

            // Assigning values to object
            product.Key = keyTextBox.Text;
            product.Name = nameTextBox.Text;
            product.Brand = brandListBox.SelectedValue.ToString();
            product.Supplier = supplierListBox.Text;
            product.Category = categoryComboBox.Text;
            product.Type = typeComboBox.SelectedValue.ToString();
            product.Unit = unitTextBox.Text;
            product.UnitCost = costNumericUpDown.Value;
            product.UnitPrice = priceNumericUpDown.Value;
            product.Quantity = (int)quantityNumericUpDown.Value; // TODO: change database structure to consider fractions and halves i.e.: 0.5lbs of cheese
            product.MinimumQuantity = (int)minimumNumericUpDown.Value; // TODO: change database structure to consider fractions and halves i.e.: 0.5lbs of cheese
            product.MaximumQuantity = (int)maximumNumericUpDown.Value; // TODO: change database structure to consider fractions and halves i.e.: 0.5lbs of cheese

            return product; // returning new product with all necessary information 
        }

        /// <summary>
        /// Function to populate the brand list box
        /// </summary>
        private void PopulateBrandListBox()
        {
            brandListBox.DataSource = ProductInformationManager.ConsultProductBrandListInformation(brandSearchBox.Text);
        }

        /// <summary>
        /// Function that populates the category combo box 
        /// </summary>
        private void PopulateCategoryComboBox()
        {
            categoryComboBox.DataSource = ProductInformationManager.ConsultProductCategoryComboBoxInformation();
        }

        /// <summary>
        /// Function to populate the supplier list box
        /// </summary>
        private void PopulateSupplierListBox()
        {
            supplierListBox.DataSource = ProductInformationManager.ConsultProductSupplierListInformation(supplierSearchBox.Text);
        }

        /// <summary>
        /// Function to populate the type combo box
        /// </summary>
        private void PopulateTypeComboBox()
        {
            typeComboBox.DataSource = ProductInformationManager.ConsultProductTypeComboBoxInformation();
        }

        /// <summary>
        /// Function used to validade the user inputs provided in the form
        /// </summary>
        /// <returns>True or False</returns>
        private bool ValidateUserInput()
        {
            bool validated = true;

            if (nameTextBox.Text == "")
            {
                validated = false;
                nameTextBox.BackColor = Color.Red;
            }

            if (unitTextBox.Text == "")
            {
                validated = false;
                unitTextBox.BackColor = Color.Red;
            }

            return validated;
        }
        #endregion
    }
}
