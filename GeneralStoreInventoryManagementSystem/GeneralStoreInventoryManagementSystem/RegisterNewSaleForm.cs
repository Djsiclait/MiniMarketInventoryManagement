using System;
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
    public partial class RegisterNewSaleFrom : Form
    {
        public RegisterNewSaleFrom()
        {
            InitializeComponent();
        }

        // Menu Bar Options
        private void ViewSalesMenuOption_Click(object sender, EventArgs e)
        {
            // Closing form while freeing system resources
            FormsMenuList.registerNewSaleForm.Dispose();

            // Summon Sales Registry Form
            FormsMenuList.salesRecordForm = new SalesRecordForm();
            FormsMenuList.salesRecordForm.Show();
        }

        private void BrowseProductsMenuSubOption_Click(object sender, EventArgs e)
        {
            // Closing form while freeing system resources
            FormsMenuList.registerNewSaleForm.Dispose();

            // Summon Product Browser Form
            FormsMenuList.inventorySearchForm = new InventorySearchForm();
            FormsMenuList.inventorySearchForm.Show();
        }

        private void RegisterNewProductMenuSubOption_Click(object sender, EventArgs e)
        {
            // Closing form while freeing system resources
            FormsMenuList.registerNewSaleForm.Dispose();

            // Summon Register New Product Form
            FormsMenuList.registerNewProduct = new RegisterNewProductForm();
            FormsMenuList.registerNewProduct.Show();
        }

        private void RestockProductsMenuSubOption_Click(object sender, EventArgs e)
        {
            // Closing form while freeing system resources
            FormsMenuList.registerNewSaleForm.Dispose();

            // Summon Restock Products Form
            FormsMenuList.restockProductsFrom = new RestockProductsForm();
            FormsMenuList.restockProductsFrom.Show();
        }

        private void ViewUsersOption_Click(object sender, EventArgs e)
        {
            // Closing form while freeing system resources
            FormsMenuList.registerNewSaleForm.Dispose();

            // Summon Users Registry Form
            FormsMenuList.usersRegistryForm = new UsersRegistryForm();
            FormsMenuList.usersRegistryForm.Show();
        }

        private void RegisterNewUserOption_Click(object sender, EventArgs e)
        {
            // Closing form while freeing system resources
            FormsMenuList.registerNewSaleForm.Dispose();

            // Summon Register New User Form
            FormsMenuList.registerNewUserForm = new RegisterNewUserForm();
            FormsMenuList.registerNewUserForm.Show();
        }

        private void ViewGraphsOption_Click(object sender, EventArgs e)
        {
            // Closing form while freeing system resources
            FormsMenuList.registerNewSaleForm.Dispose();

            // Summon Graphs Analytics Form
            FormsMenuList.graphsAnaliticsForm = new GraphsAnalyticsForm();
            FormsMenuList.graphsAnaliticsForm.Show();
        }

        private void ViewReportsOption_Click(object sender, EventArgs e)
        {
            // Closing form while freeing system resources
            FormsMenuList.registerNewSaleForm.Dispose();

            // Summon Reports Analytics Form
            FormsMenuList.reportsAnalyticsForm = new ReportsAnalyticsForm();
            FormsMenuList.reportsAnalyticsForm.Show();
        }

        private void ViewActivityLogsOption_Click(object sender, EventArgs e)
        {
            // Closing form while freeing system resources
            FormsMenuList.registerNewSaleForm.Dispose();

            // Summon Activity Logs Form
            FormsMenuList.activitiesLogForm = new ActivitiesLogForm();
            FormsMenuList.activitiesLogForm.Show();
        }

        private void ViewErrorLogsOption_Click(object sender, EventArgs e)
        {
            // Closing form while freeing system resources
            FormsMenuList.registerNewSaleForm.Dispose();

            // Summon Error Logs Form
            FormsMenuList.errorsLogForm = new ErrorsLogForm();
            FormsMenuList.errorsLogForm.Show();
        }

        private void ViewCartLabel_Click(object sender, EventArgs e)
        {
            // Closing form while freeing system resources
            FormsMenuList.registerNewSaleForm.Dispose();

            // Summon View Cart Form
            FormsMenuList.viewCartForm = new ViewCartForm();
            FormsMenuList.viewCartForm.Show();
        }

        private void ViewCartLabel_MouseHover(object sender, EventArgs e)
        {
            FormsMenuList.registerNewSaleForm.viewCartLabel.ForeColor = Color.Blue;
        }

        private void ViewCartLabel_MouseLeave(object sender, EventArgs e)
        {
            FormsMenuList.registerNewSaleForm.viewCartLabel.ForeColor = Color.Black;
        }

        private void LogOutLabel_Click(object sender, EventArgs e)
        {
            // Closing form while freeing system resources
            FormsMenuList.registerNewSaleForm.Dispose();

            // Log out of current session
            CollectiveResources.EndUserSession();
            FormsMenuList.loginForm.Show();
        }

        private void LogOutLabel_MouseHover(object sender, EventArgs e)
        {
            FormsMenuList.registerNewSaleForm.ForeColor = Color.Red;
        }

        private void LogOutLabel_MouseLeave(object sender, EventArgs e)
        {
            FormsMenuList.registerNewSaleForm.ForeColor = Color.Black;
        }
    }
}