using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Custom Libraries
using InventoryManagementBusinessLayer;
using InventoryManagementEntityLayer;

namespace GeneralStoreInventoryManagementSystem
{
    public partial class RegisterNewProductForm : Form
    {
        public RegisterNewProductForm()
        {
            InitializeComponent();
        }

////////// Load Form Logic
        private void RegisterNewProductForm_Load(object sender, EventArgs e)
        {
            // Identifying correct protocol for current user in session
            if (SystemProtocols.ApplySessionsProtocols())
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
////////// END Load Form Logic

////////// On Form Closing Override
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            // Executing correct log out processes
            SystemProtocols.ApplyLogOutProtocols();
            FormsMenuList.loginForm.Show();

            // Closing form while freeing system resources
            FormsMenuList.registerNewProduct.Dispose();
        }
////////// END On Form Closing Override

////////// Menu Bar Options
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

        private void LogOutLabel_Click(object sender, EventArgs e)
        {
            // Executing correct log out processes
            SystemProtocols.ApplyLogOutProtocols();
            FormsMenuList.loginForm.Show();

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
////////// END Menubar Options

////////// Text Changed Logic
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

        private void UnitContributionMarginLabel_MouseHover(object sender, EventArgs e)
        {
            unitContributionMarginLabel.Text = "This is the unit contribution cost.";
        }

        private void UnitContributionMarginLabel_MouseLeave(object sender, EventArgs e)
        {
            unitContributionMarginLabel.Text = CalculateUnitContributionMargin();
        }

        private void SupplierSearchBox_TextChanged(object sender, EventArgs e)
        {
            PopulateSupplierListBox();
        }
////////// END Text Changed Logic

////////// Button Click Logic
        private void AddNewBrandButton_Click(object sender, EventArgs e)
        {
            // Registering new product brand
            String message = CreateInformation.RegisterNewProductBrandInformation(brandSearchBox.Text);

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
            String message = CreateInformation.RegisterNewProductSupplierInformation(supplierSearchBox.Text, "", "");

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
                String message = CreateInformation.RegisterNewProductInformation(CreateProductObject());

                if (message == "SUCCESS")
                {
                    MessageBox.Show("Product, " + nameTextBox.Text.ToUpper() + ", was successfully registered!");
                    ClearFormBuffer();
                }
                else
                    MessageBox.Show("Fatal Error!");
            }
            else
                MessageBox.Show("Plesae fill in all information correctly.");
        }
////////// END Button Click Logic

////////// Auxiliary Functions
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
            product.Supplier = supplierListBox.SelectedValue.ToString();
            product.Category = categoryComboBox.SelectedValue.ToString();
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
            brandListBox.DataSource = ConsultInformation.FetchBrandListInformation(brandSearchBox.Text);
        }

        /// <summary>
        /// Function that populates the category combo box 
        /// </summary>
        private void PopulateCategoryComboBox()
        {
            categoryComboBox.DataSource = ConsultInformation.FetchCategoryComboBoxInformation();
        }

        /// <summary>
        /// Function to populate the supplier list box
        /// </summary>
        private void PopulateSupplierListBox()
        {
            supplierListBox.DataSource = ConsultInformation.FetchSupplierListInformation(supplierSearchBox.Text);
        }

        /// <summary>
        /// Function to populate the type combo box
        /// </summary>
        private void PopulateTypeComboBox()
        {
            typeComboBox.DataSource = ConsultInformation.FetchTypeComboBoxInformation();
        }

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

            return contributionRatio.ToString("0.##") + "% ($" + contributionDollar.ToString("0.##") + " or " + (priceIncrease.ToString("0.##") == "1" ? "1" : priceIncrease.ToString("0.##")) + "x price increase)" ;
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
    }
}
