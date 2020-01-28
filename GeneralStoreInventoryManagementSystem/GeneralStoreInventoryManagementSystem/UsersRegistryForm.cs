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
            PopulateUserResigtryDataGrid();

            PopulateActicityListDataGrid();
        }
////////// END Load Form Logic

////////// Menu Bar Options
        private void ViewSalesMenuSubOption_Click(object sender, EventArgs e)
        {
            // Closing form while freeing system resources
            FormsMenuList.usersRegistryForm.Dispose();

            // Summon Sales Registry Form
            FormsMenuList.salesRecordForm = new SalesRecordForm();
            FormsMenuList.salesRecordForm.Show();
        }

        private void MakeSaleMenuSubOption_Click(object sender, EventArgs e)
        {
            // Closing form while freeing system resources
            FormsMenuList.usersRegistryForm.Dispose();

            // Summon Register New Sale Form
            FormsMenuList.registerNewSaleForm = new RegisterNewSaleFrom();
            FormsMenuList.registerNewSaleForm.Show();
        }

        private void BrowseProductsMenuSubOption_Click(object sender, EventArgs e)
        {
            // Closing form while freeing system resources
            FormsMenuList.usersRegistryForm.Dispose();

            // Summon Product Browser Form
            FormsMenuList.inventorySearchForm.Show(); // TODO: instanciate this form after removing the application ancor
        }

        private void RegisterNewProductMenuSubOption_Click(object sender, EventArgs e)
        {
            // Closing form while freeing system resources
            FormsMenuList.usersRegistryForm.Dispose();

            // Summon Register New Product Form
            FormsMenuList.registerNewProduct = new RegisterNewProductForm();
            FormsMenuList.registerNewProduct.Show();
        }

        private void RestockProductsMenuSubOption_Click(object sender, EventArgs e)
        {
            // Closing form while freeing system resources
            FormsMenuList.usersRegistryForm.Dispose();

            // Summon Restock Products Form
            FormsMenuList.restockProductsFrom = new RestockProductsForm();
            FormsMenuList.restockProductsFrom.Show();
        }

        private void RegisterNewUserMenuSubOption_Click(object sender, EventArgs e)
        {
            // Closing form while freeing system resources
            FormsMenuList.usersRegistryForm.Dispose();

            // Summon Register New User Form
            FormsMenuList.registerNewUserForm = new RegisterNewUserForm();
            FormsMenuList.registerNewUserForm.Show();
        }

        private void ViewGraphsOption_Click(object sender, EventArgs e)
        {
            // Closing form while freeing system resources
            FormsMenuList.usersRegistryForm.Dispose();

            // Summon Graphs Analytics Form
            FormsMenuList.graphsAnaliticsForm = new GraphsAnalyticsForm();
            FormsMenuList.graphsAnaliticsForm.Show();
        }

        private void ViewReportsOption_Click(object sender, EventArgs e)
        {
            // Closing form while freeing system resources
            FormsMenuList.usersRegistryForm.Dispose();

            // Summon Reports Analytics Form
            FormsMenuList.reportsAnalyticsForm = new ReportsAnalyticsForm();
            FormsMenuList.reportsAnalyticsForm.Show();
        }

        private void ViewActivityLogsOption_Click(object sender, EventArgs e)
        {
            // Closing form while freeing system resources
            FormsMenuList.usersRegistryForm.Dispose();

            // Summon Activity Logs Form
            FormsMenuList.activitiesLogForm = new ActivitiesLogForm();
            FormsMenuList.activitiesLogForm.Show();
        }

        private void ViewErrorLogsOption_Click(object sender, EventArgs e)
        {
            // Closing form while freeing system resources
            FormsMenuList.usersRegistryForm.Dispose();

            // Summon Error Logs Form
            FormsMenuList.errorsLogForm = new ErrorsLogForm();
            FormsMenuList.errorsLogForm.Show();
        }

        private void ViewCartLabel_Click(object sender, EventArgs e)
        {
            // Closing form while freeing system resources
            FormsMenuList.usersRegistryForm.Dispose();

            // Summon View Cart Form
            FormsMenuList.viewCartForm = new ViewCartForm();
            FormsMenuList.viewCartForm.Show();
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
            // Closing form while freeing system resources
            FormsMenuList.usersRegistryForm.Dispose();

            // Log out of current session
            FormsMenuList.loginForm = new LoginForm(); // TODO: Remove this instantiation and leave the Show() function
            FormsMenuList.loginForm.Show();
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
            userList.DataSource = InventoryManagementBusinessLayer.ConsultInformation.FetchUserListInformation("super.admin", "Super", userSearchBox.Text); // TODO: replace static paramaters with session variables after implementation

            userList.Columns["Password"].Visible = false;
            userList.Columns["Creator"].Visible = false;
            userList.Columns["RegistrationDate"].Visible = false;
        }

        private void PopulateActicityListDataGrid()
        {
            // TODO: Populate the grid with user activity login/logout (etc.) for 24 hours after session and log implementations
        }

        private void ProfileButton_Click(object sender, EventArgs e)
        {
            // TODO: show user's personal profile information after session implementation
        }

        private void UserList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            UserInformationTemplateForm userInformationForm = new UserInformationTemplateForm(userList.SelectedCells[0].Value.ToString());
            userInformationForm.Show();
        }
    }
}
