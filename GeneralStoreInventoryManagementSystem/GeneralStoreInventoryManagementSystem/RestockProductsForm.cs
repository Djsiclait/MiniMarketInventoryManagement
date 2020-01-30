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
    public partial class RestockProductsForm : Form
    {
        public RestockProductsForm()
        {
            InitializeComponent();
        }

////////// Load Form Logic
        private void RestockProductsForm_Load(object sender, EventArgs e)
        {
            // Limiting option according to current user's access level
            if (CollectiveResources.UserInSession.Role == "User")
            {
                // Disabling the other Products option 
                registerNewProductMenuSubOption.Visible = false;
                registerNewProductMenuSubOption.Enabled = false;

                // Disabling all admin options
                adminMenuOption.Visible = false;
                adminMenuOption.Enabled = false;
            }

            CollectiveResources.RecordActivity(
                CollectiveResources.UserInSession.Username,
                CollectiveResources.UserInSession.Role + ", " + CollectiveResources.UserInSession.Username + ", has accessed the form to restock products",
                "ADMIN ACCESS");
        }
////////// END Form Logic

////////// On Form Closing Override
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            // Log out of current session
            CollectiveResources.EndUserSession();
            FormsMenuList.loginForm.Show();

            // Closing form while freeing system resources
            FormsMenuList.restockProductsFrom.Dispose();
        }
////////// END On Form Closing Override

////////// Menu Bar Options
        private void ViewSalesMenuSubOption_Click(object sender, EventArgs e)
        {
            // Summon Sales Registry Form
            FormsMenuList.salesRecordForm = new SalesRecordForm();
            FormsMenuList.salesRecordForm.Show();

            // Closing form while freeing system resources
            FormsMenuList.restockProductsFrom.Dispose();
        }

        private void MakeSaleMenuSubOption_Click(object sender, EventArgs e)
        {
            // Summon Register New Sale Form
            FormsMenuList.registerNewSaleForm = new RegisterNewSaleFrom();
            FormsMenuList.registerNewSaleForm.Show();

            // Closing form while freeing system resources
            FormsMenuList.restockProductsFrom.Dispose();
        }

        private void BrowseProductsMenuSubOption_Click(object sender, EventArgs e)
        {
            // Summon Product Browser Form
            FormsMenuList.inventorySearchForm = new InventorySearchForm();
            FormsMenuList.inventorySearchForm.Show();

            // Closing form while freeing system resources
            FormsMenuList.restockProductsFrom.Dispose();
        }

        private void RegisterNewProductMenuSubOption_Click(object sender, EventArgs e)
        {
            // Summon Register New Product Form
            FormsMenuList.registerNewProduct = new RegisterNewProductForm();
            FormsMenuList.registerNewProduct.Show();

            // Closing form while freeing system resources
            FormsMenuList.restockProductsFrom.Dispose();
        }

        private void ViewUsersOption_Click(object sender, EventArgs e)
        {
            // Summon Users Registry Form
            FormsMenuList.usersRegistryForm = new UsersRegistryForm();
            FormsMenuList.usersRegistryForm.Show();

            // Closing form while freeing system resources
            FormsMenuList.restockProductsFrom.Dispose();
        }

        private void RegisterNewUserOption_Click(object sender, EventArgs e)
        {
            // Summon Register New User Form
            FormsMenuList.registerNewUserForm = new RegisterNewUserForm();
            FormsMenuList.registerNewUserForm.Show();

            // Closing form while freeing system resources
            FormsMenuList.restockProductsFrom.Dispose();
        }

        private void ViewGraphsOption_Click(object sender, EventArgs e)
        {
            // Summon Graphs Analytics Form
            FormsMenuList.graphsAnaliticsForm = new GraphsAnalyticsForm();
            FormsMenuList.graphsAnaliticsForm.Show();

            // Closing form while freeing system resources
            FormsMenuList.restockProductsFrom.Dispose();
        }

        private void ViewReportsOption_Click(object sender, EventArgs e)
        {
            // Summon Reports Analytics Form
            FormsMenuList.reportsAnalyticsForm = new ReportsAnalyticsForm();
            FormsMenuList.reportsAnalyticsForm.Show();

            // Closing form while freeing system resources
            FormsMenuList.restockProductsFrom.Dispose();
        }

        private void ViewActivityLogsOption_Click(object sender, EventArgs e)
        {
            // Summon Activity Logs Form
            FormsMenuList.activitiesLogForm = new ActivitiesLogForm();
            FormsMenuList.activitiesLogForm.Show();

            // Closing form while freeing system resources
            FormsMenuList.restockProductsFrom.Dispose();
        }

        private void ViewErrorLogsOption_Click(object sender, EventArgs e)
        {
            // Summon Error Logs Form
            FormsMenuList.errorsLogForm = new ErrorsLogForm();
            FormsMenuList.errorsLogForm.Show();

            // Closing form while freeing system resources
            FormsMenuList.restockProductsFrom.Dispose();
        }

        private void ViewCartLabel_Click(object sender, EventArgs e)
        {
            // Summon View Cart Form
            FormsMenuList.viewCartForm = new ViewCartForm();
            FormsMenuList.viewCartForm.Show();

            // Closing form while freeing system resources
            FormsMenuList.restockProductsFrom.Dispose();
        }

        private void ViewCartLabel_MouseHover(object sender, EventArgs e)
        {
            FormsMenuList.restockProductsFrom.viewCartLabel.ForeColor = Color.Blue;
        }

        private void ViewCartLabel_MouseLeave(object sender, EventArgs e)
        {
            FormsMenuList.restockProductsFrom.viewCartLabel.ForeColor = Color.Black;
        }

        private void LogOutLabel_Click(object sender, EventArgs e)
        {
            // Log out of current session
            CollectiveResources.EndUserSession();
            FormsMenuList.loginForm.Show();

            // Closing form while freeing system resources
            FormsMenuList.restockProductsFrom.Dispose();
        }

        private void LogOutLabel_MouseHover(object sender, EventArgs e)
        {
            FormsMenuList.restockProductsFrom.logOutLabel.ForeColor = Color.Red;
        }

        private void LogOutLabel_MouseLeave(object sender, EventArgs e)
        {
            FormsMenuList.restockProductsFrom.logOutLabel.ForeColor = Color.Black;
        }
////////// END Menubar Options
    }
}
