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
            FormsMenuList.registerNewProduct.ForeColor = Color.Red;
        }

        private void LogOutLabel_MouseLeave(object sender, EventArgs e)
        {
            FormsMenuList.registerNewProduct.ForeColor = Color.Black;
        }
////////// END Menubar Options

////////// Text Changed Logic
        private void BrandSearchBox_TextChanged(object sender, EventArgs e)
        {
            PopulateBrandListBox();
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
            categoryComboBox.Text = "";
            typeComboBox.Text = "";
            unitTextBox.Text = "";
            costNumericUpDown.Value = (decimal)0.01;
            priceNumericUpDown.Value = (decimal)0.01;
            quantityNumericUpDown.Value = 1;
            minimumNumericUpDown.Value = 1;
            maximumNumericUpDown.Value = 2;
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
    }
}
