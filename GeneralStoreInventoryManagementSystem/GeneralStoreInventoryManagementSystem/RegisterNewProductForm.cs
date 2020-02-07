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
            // Limiting option according to current user's access level
            if (CollectiveResources.UserInSession.Role == "User")
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

            CollectiveResources.RecordActivity(
                CollectiveResources.UserInSession.Username,
                CollectiveResources.UserInSession.Role + ", " + CollectiveResources.UserInSession.Username + ", has accessed the for to register new products",
                "ADMIN ACCESS");
        }
////////// END Load Form Logic

////////// On Form Closing Override
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            // Log out of current session
            CollectiveResources.EndUserSession();
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
            // Log out of current session
            CollectiveResources.EndUserSession();
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

        private void priceLabel_Click(object sender, EventArgs e)
        {

        }
        ////////// END Menubar Options

        private void PopulateBrandListBox()
        {
            brandListBox.DataSource = InventoryManagementBusinessLayer.ConsultInformation.FetchBrandListInformation(brandSearchBox.Text);
        }

        private void BrandSearchBox_TextChanged(object sender, EventArgs e)
        {
            PopulateBrandListBox();
        }

        private void AddNewBrandButton_Click(object sender, EventArgs e)
        {
            String message = InventoryManagementBusinessLayer.CreateInformation.RegisterNewProductBrandInformation(brandSearchBox.Text);

            if (message == "Brand has been registered successfully!")
            {
                brandSearchBox.Text = "";
                PopulateBrandListBox();
            }
            else
                MessageBox.Show("This product already exists");
        }

        private void PopulateSupplierListBox()
        {
            supplierListBox.DataSource = InventoryManagementBusinessLayer.ConsultInformation.FetchSupplierListInformation(supplierSearchBox.Text);
        }

        private void SupplierSearchBox_TextChanged(object sender, EventArgs e)
        {
            PopulateSupplierListBox();
        }

        private void AddNewSupplierButton_Click(object sender, EventArgs e)
        {
            String message = InventoryManagementBusinessLayer.CreateInformation.RegisterNewProductSupplierInformation(supplierSearchBox.Text, "", "");

            if (message == "Supplier has been registered successfully!")
            {
                supplierSearchBox.Text = "";
                PopulateSupplierListBox();
            }
            else
                MessageBox.Show("This supplier already exists");
        }

        private void PopulateCategoryComboBox()
        {
            categoryComboBox.DataSource = InventoryManagementBusinessLayer.ConsultInformation.FetchCategoryComboBoxInformation();
        }

        private void PopulateTypeComboBox()
        {
            typeComboBox.DataSource = InventoryManagementBusinessLayer.ConsultInformation.FetchTypeComboBoxInformation();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ClearFormBuffer();
        }

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
    }
}
