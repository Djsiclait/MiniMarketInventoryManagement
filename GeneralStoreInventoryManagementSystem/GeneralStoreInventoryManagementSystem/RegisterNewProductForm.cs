﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeneralStoreInventoryManagementSystem
{
    public partial class RegisterNewProductForm : Form
    {
        public RegisterNewProductForm()
        {
            InitializeComponent();
        }

        private void ViewSalesMenuSubOption_Click(object sender, EventArgs e)
        {
            // Closing form while freeing system resources
            FormsMenuList.registerNewProduct.Dispose();

            // Summon Sales Registry Form
            FormsMenuList.salesRecordForm = new SalesRecordForm();
            FormsMenuList.salesRecordForm.Show();
        }

        private void MakeSaleMenuSubOption_Click(object sender, EventArgs e)
        {
            // Closing form while freeing system resources
            FormsMenuList.registerNewProduct.Dispose();

            // Summon Register New Sale Form
            FormsMenuList.registerSaleForm = new RegisterSaleFrom();
            FormsMenuList.registerSaleForm.Show();
        }

        private void BrowseProductsMenuSubOption_Click(object sender, EventArgs e)
        {
            // Closing form while freeing system resources
            FormsMenuList.registerNewProduct.Dispose();

            // Summon Product Browser Form
            FormsMenuList.inventorySearchForm.Show(); // TODO: instanciate this form after removing the application ancor
        }

        private void RestockProductsMenuSubOption_Click(object sender, EventArgs e)
        {
            // Closing form while freeing system resources
            FormsMenuList.registerNewProduct.Dispose();

            // Summon Restock Products Form
            FormsMenuList.restockProductsFrom = new RestockProductsForm();
            FormsMenuList.restockProductsFrom.Show();
        }

        private void ViewUsersOption_Click(object sender, EventArgs e)
        {
            // Closing form while freeing system resources
            FormsMenuList.registerNewProduct.Dispose();

            // Summon Users Registry Form
            FormsMenuList.usersRegistryForm = new UsersRegistryForm();
            FormsMenuList.usersRegistryForm.Show();
        }

        private void RegisterNewUserOption_Click(object sender, EventArgs e)
        {
            // Closing form while freeing system resources
            FormsMenuList.registerNewProduct.Dispose();

            // Summon Register New User Form
            FormsMenuList.registerNewUserForm = new RegisterNewUserForm();
            FormsMenuList.registerNewUserForm.Show();
        }

        private void ViewGraphsOption_Click(object sender, EventArgs e)
        {
            // Closing form while freeing system resources
            FormsMenuList.registerNewProduct.Dispose();

            // Summon Graphs Analytics Form
            FormsMenuList.graphsAnaliticsForm = new GraphsAnalyticsForm();
            FormsMenuList.graphsAnaliticsForm.Show();
        }

        private void ViewReportsOption_Click(object sender, EventArgs e)
        {
            // Closing form while freeing system resources
            FormsMenuList.registerNewProduct.Dispose();

            // Summon Reports Analytics Form
            FormsMenuList.reportsAnalyticsForm = new ReportsAnalyticsForm();
            FormsMenuList.reportsAnalyticsForm.Show();
        }

        private void ViewActivityLogsOption_Click(object sender, EventArgs e)
        {
            // Closing form while freeing system resources
            FormsMenuList.registerNewProduct.Dispose();

            // Summon Activity Logs Form
            FormsMenuList.activitiesLogForm = new ActivitiesLogForm();
            FormsMenuList.activitiesLogForm.Show();
        }

        private void ViewErrorLogsOption_Click(object sender, EventArgs e)
        {
            // Closing form while freeing system resources
            FormsMenuList.registerNewProduct.Dispose();

            // Summon Error Logs Form
            FormsMenuList.errorsLogForm = new ErrorsLogForm();
            FormsMenuList.errorsLogForm.Show();
        }

        private void ViewCartLabel_Click(object sender, EventArgs e)
        {
            // Closing form while freeing system resources
            FormsMenuList.registerNewProduct.Dispose();

            // Summon View Cart Form
            FormsMenuList.viewCartForm = new ViewCartForm();
            FormsMenuList.viewCartForm.Show();
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
            // Closing form while freeing system resources
            FormsMenuList.registerNewProduct.Dispose();

            // Log out of current session
            FormsMenuList.loginForm = new LoginForm(); // TODO: Remove this instantiation and leave the Show() function
            FormsMenuList.loginForm.Show();
        }

        private void LogOutLabel_MouseHover(object sender, EventArgs e)
        {
            FormsMenuList.registerNewProduct.ForeColor = Color.Red;
        }

        private void LogOutLabel_MouseLeave(object sender, EventArgs e)
        {
            FormsMenuList.registerNewProduct.ForeColor = Color.Black;
        }
    }
}
