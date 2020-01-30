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
    public partial class UsersRegistryForm : Form
    {
        public UsersRegistryForm()
        {
            InitializeComponent();
        }
    
////////// Load Form Logic
        private void UsersRegistryForm_Load(object sender, EventArgs e)
        {
            // Limiting option according to current user's access level
            if (CollectiveResources.UserInSession.Role == "User")
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

            PopulateUserResigtryDataGrid();

            PopulateActicityListDataGrid();

            CollectiveResources.RecordActivity(
                CollectiveResources.UserInSession.Username,
                CollectiveResources.UserInSession.Role + ", " + CollectiveResources.UserInSession.Username + ", has accessed the user registry",
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
            FormsMenuList.usersRegistryForm.Dispose();
        }
////////// END On Form Closing Override

////////// Menu Bar Options
        private void ViewSalesMenuSubOption_Click(object sender, EventArgs e)
        {
            // Summon Sales Registry Form
            FormsMenuList.salesRecordForm = new SalesRecordForm();
            FormsMenuList.salesRecordForm.Show();

            // Closing form while freeing system resources
            FormsMenuList.usersRegistryForm.Dispose();
        }

        private void MakeSaleMenuSubOption_Click(object sender, EventArgs e)
        {
            // Summon Register New Sale Form
            FormsMenuList.registerNewSaleForm = new RegisterNewSaleFrom();
            FormsMenuList.registerNewSaleForm.Show();

            // Closing form while freeing system resources
            FormsMenuList.usersRegistryForm.Dispose();
        }

        private void BrowseProductsMenuSubOption_Click(object sender, EventArgs e)
        {
            // Summon Product Browser Form
            FormsMenuList.inventorySearchForm = new InventorySearchForm();
            FormsMenuList.inventorySearchForm.Show();

            // Closing form while freeing system resources
            FormsMenuList.usersRegistryForm.Dispose();
        }

        private void RegisterNewProductMenuSubOption_Click(object sender, EventArgs e)
        {
            // Summon Register New Product Form
            FormsMenuList.registerNewProduct = new RegisterNewProductForm();
            FormsMenuList.registerNewProduct.Show();

            // Closing form while freeing system resources
            FormsMenuList.usersRegistryForm.Dispose();
        }

        private void RestockProductsMenuSubOption_Click(object sender, EventArgs e)
        {
            // Summon Restock Products Form
            FormsMenuList.restockProductsFrom = new RestockProductsForm();
            FormsMenuList.restockProductsFrom.Show();

            // Closing form while freeing system resources
            FormsMenuList.usersRegistryForm.Dispose();
        }

        private void RegisterNewUserMenuSubOption_Click(object sender, EventArgs e)
        {
            // Summon Register New User Form
            FormsMenuList.registerNewUserForm = new RegisterNewUserForm();
            FormsMenuList.registerNewUserForm.Show();

            // Closing form while freeing system resources
            FormsMenuList.usersRegistryForm.Dispose();
        }

        private void ViewGraphsOption_Click(object sender, EventArgs e)
        {
            // Summon Graphs Analytics Form
            FormsMenuList.graphsAnaliticsForm = new GraphsAnalyticsForm();
            FormsMenuList.graphsAnaliticsForm.Show();

            // Closing form while freeing system resources
            FormsMenuList.usersRegistryForm.Dispose();
        }

        private void ViewReportsOption_Click(object sender, EventArgs e)
        {
            // Summon Reports Analytics Form
            FormsMenuList.reportsAnalyticsForm = new ReportsAnalyticsForm();
            FormsMenuList.reportsAnalyticsForm.Show();

            // Closing form while freeing system resources
            FormsMenuList.usersRegistryForm.Dispose();
        }

        private void ViewActivityLogsOption_Click(object sender, EventArgs e)
        {
            // Summon Activity Logs Form
            FormsMenuList.activitiesLogForm = new ActivitiesLogForm();
            FormsMenuList.activitiesLogForm.Show();

            // Closing form while freeing system resources
            FormsMenuList.usersRegistryForm.Dispose();
        }

        private void ViewErrorLogsOption_Click(object sender, EventArgs e)
        {
            // Summon Error Logs Form
            FormsMenuList.errorsLogForm = new ErrorsLogForm();
            FormsMenuList.errorsLogForm.Show();

            // Closing form while freeing system resources
            FormsMenuList.usersRegistryForm.Dispose();
        }

        private void ViewCartLabel_Click(object sender, EventArgs e)
        {
            // Summon View Cart Form
            FormsMenuList.viewCartForm = new ViewCartForm();
            FormsMenuList.viewCartForm.Show();

            // Closing form while freeing system resources
            FormsMenuList.usersRegistryForm.Dispose();
        }

        private void ViewCartLabel_MouseHover(object sender, EventArgs e)
        {
            FormsMenuList.usersRegistryForm.viewCartLabel.ForeColor = Color.Blue;
        }

        private void ViewCartLabel_MouseLeave(object sender, EventArgs e)
        {
            FormsMenuList.usersRegistryForm.viewCartLabel.ForeColor = Color.Black;
        }

        private void LogOutLabel_Click(object sender, EventArgs e)
        {
            // Log out of current session
            CollectiveResources.EndUserSession();
            FormsMenuList.loginForm.Show();

            // Closing form while freeing system resources
            FormsMenuList.usersRegistryForm.Dispose();
        }

        private void LogOutLabel_MouseHover(object sender, EventArgs e)
        {
            FormsMenuList.usersRegistryForm.LogOutLabel.ForeColor = Color.Red;
        }

        private void LogOutLabel_MouseLeave(object sender, EventArgs e)
        {
            FormsMenuList.usersRegistryForm.LogOutLabel.ForeColor = Color.Black;
        }
////////// Menu Bar Options

        private void UserSearchBox_TextChanged(object sender, EventArgs e)
        {
            PopulateUserResigtryDataGrid(); // REMINDER, to search for active and inactive useres use 0, 1, etc.
        }

        private void PopulateUserResigtryDataGrid()
        {
            userList.DataSource = InventoryManagementBusinessLayer.ConsultInformation.FetchUserListInformation(CollectiveResources.UserInSession.Username, CollectiveResources.UserInSession.Role, userSearchBox.Text);

            userList.Columns["Password"].Visible = false;
            userList.Columns["Creator"].Visible = false;
            userList.Columns["RegistrationDate"].Visible = false;
        }

        private void PopulateActicityListDataGrid()
        {
            activityList.DataSource = InventoryManagementBusinessLayer.ConsultInformation.FetchActivityListInformation(CollectiveResources.UserInSession.Role, activitySearchBox.Text, true);

            activityList.Columns["Description"].Width = 550;
            activityList.Columns["Timestamp"].Width = 200;
        }

        private void ProfileButton_Click(object sender, EventArgs e)
        {
            UserInformationTemplateForm userInformationForm = new UserInformationTemplateForm(CollectiveResources.UserInSession.Username);
            userInformationForm.Show();
        }

        private void UserList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            UserInformationTemplateForm userInformationForm = new UserInformationTemplateForm(userList.SelectedCells[0].Value.ToString());
            userInformationForm.Show();
        }

        private void activitySearchBox_TextChanged(object sender, EventArgs e)
        {
            PopulateActicityListDataGrid();
        }
    }
}
