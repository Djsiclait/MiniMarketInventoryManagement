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
    public partial class InventorySearchForm : Form
    {
        public InventorySearchForm()
        {
            InitializeComponent();
        }

////////// Form Load Logic 
        private void InventorySearchForm_Load(object sender, EventArgs e)
        {
            // TEMPORARY
            // TODO: ancor the application to the splash page
            FormsMenuList.inventorySearchForm = this; // Ancorging this form as the application instance 

            PopulateProductListDataGrid(); // Initializing the data grid upon load
        }
////////// END Form Load Logic

////////// Menu Bar Options
        private void ViewSalesMenuSubOption_Click(object sender, EventArgs e)
        {
            // TEMPORARY
            // TODO: hide the application using the splash page; replace this hid with a Dispose()
            FormsMenuList.inventorySearchForm.Hide(); // hiding the application ancor to avoid ending the system

            // Summon Sales Registry Form
            FormsMenuList.salesRecordForm = new SalesRecordForm();
            FormsMenuList.salesRecordForm.Show();
        }

        private void MakeSaleMenuSubOption_Click(object sender, EventArgs e)
        {
            // TEMPORARY
            // TODO: hide the application using the splash page; replace this hid with a Dispose()
            FormsMenuList.inventorySearchForm.Hide(); // hiding the application ancor to avoid ending the system

            // Summon Register New Sale Form
            FormsMenuList.registerNewSaleForm = new RegisterNewSaleFrom();
            FormsMenuList.registerNewSaleForm.Show();
        }
        
        private void RegisterNewProductMenuSubOption_Click(object sender, EventArgs e)
        {
            // TEMPORARY
            // TODO: hide the application using the splash page; replace this hid with a Dispose()
            FormsMenuList.inventorySearchForm.Hide(); // hiding the application ancor to avoid ending the system

            // Summon Register New Product Form
            FormsMenuList.registerNewProduct = new RegisterNewProductForm();
            FormsMenuList.registerNewProduct.Show();
        }

        private void RestockProductsMenuSubOption_Click(object sender, EventArgs e)
        {
            // TEMPORARY
            // TODO: hide the application using the splash page; replace this hid with a Dispose()
            FormsMenuList.inventorySearchForm.Hide(); // hiding the application ancor to avoid ending the system

            // Summon Restock Products Form
            FormsMenuList.restockProductsFrom = new RestockProductsForm();
            FormsMenuList.restockProductsFrom.Show();
        }

        private void ViewUsersOption_Click(object sender, EventArgs e)
        {
            // TEMPORARY
            // TODO: hide the application using the splash page; replace this hid with a Dispose()
            FormsMenuList.inventorySearchForm.Hide(); // hiding the application ancor to avoid ending the system

            // Summon Users Registry Form
            FormsMenuList.usersRegistryForm = new UsersRegistryForm();
            FormsMenuList.usersRegistryForm.Show();
        }

        private void RegisterNewUserOption_Click(object sender, EventArgs e)
        {
            // TEMPORARY
            // TODO: hide the application using the splash page; replace this hid with a Dispose()
            FormsMenuList.inventorySearchForm.Hide(); // hiding the application ancor to avoid ending the system

            // Summon Register New User Form
            FormsMenuList.registerNewUserForm = new RegisterNewUserForm();
            FormsMenuList.registerNewUserForm.Show();
        }

        private void ViewGraphsOption_Click(object sender, EventArgs e)
        {
            // TEMPORARY
            // TODO: hide the application using the splash page; replace this hid with a Dispose()
            FormsMenuList.inventorySearchForm.Hide(); // hiding the application ancor to avoid ending the system

            // Summon Graphs Analytics Form
            FormsMenuList.graphsAnaliticsForm = new GraphsAnalyticsForm();
            FormsMenuList.graphsAnaliticsForm.Show();
        }

        private void ViewReportsOption_Click(object sender, EventArgs e)
        {
            // TEMPORARY
            // TODO: hide the application using the splash page; replace this hid with a Dispose()
            FormsMenuList.inventorySearchForm.Hide(); // hiding the application ancor to avoid ending the system

            // Summon Reports Analytics Form
            FormsMenuList.reportsAnalyticsForm = new ReportsAnalyticsForm();
            FormsMenuList.reportsAnalyticsForm.Show();
        }

        private void ViewActivityLogsOption_Click(object sender, EventArgs e)
        {
            // TEMPORARY
            // TODO: hide the application using the splash page; replace this hid with a Dispose()
            FormsMenuList.inventorySearchForm.Hide(); // hiding the application ancor to avoid ending the system

            // Summon Activity Logs Form
            FormsMenuList.activitiesLogForm = new ActivitiesLogForm();
            FormsMenuList.activitiesLogForm.Show();
        }

        private void ViewErrorLogsOption_Click(object sender, EventArgs e)
        {
            // TEMPORARY
            // TODO: hide the application using the splash page; replace this hid with a Dispose()
            FormsMenuList.inventorySearchForm.Hide(); // hiding the application ancor to avoid ending the system

            // Summon Error Logs Form
            FormsMenuList.errorsLogForm = new ErrorsLogForm();
            FormsMenuList.errorsLogForm.Show();
        }

        private void ViewCartLabel_Click(object sender, EventArgs e)
        {
            // TEMPORARY
            // TODO: hide the application using the splash page; replace this hid with a Dispose()
            FormsMenuList.inventorySearchForm.Hide(); // hiding the application ancor to avoid ending the system

            // Summon View Cart Form
            FormsMenuList.viewCartForm = new ViewCartForm();
            FormsMenuList.viewCartForm.Show();
        }

        private void ViewCartLabel_MouseHover(object sender, EventArgs e)
        {
            viewCartLabel.ForeColor = System.Drawing.Color.Blue;
        }

        private void ViewCartLabel_MouseLeave(object sender, EventArgs e)
        {
            viewCartLabel.ForeColor = Color.Black;
        }

        private void LogOutLabel_Click(object sender, EventArgs e)
        {
            // TEMPORARY
            // TODO: hide the application using the splash page; replace this hid with a Dispose()
            FormsMenuList.inventorySearchForm.Hide(); // hiding the application ancor to avoid ending the system

            // Log out of current session
            FormsMenuList.loginForm = new LoginForm(); // TODO: Remove this instantiation and leave the Show() function
            FormsMenuList.loginForm.Show();
        }

        private void LogOutLabel_MouseHover(object sender, EventArgs e)
        {
            logOutLabel.ForeColor = Color.Red;
        }

        private void LogOutLabel_MouseLeave(object sender, EventArgs e)
        {
            logOutLabel.ForeColor = Color.Black;
        }
////////// END Menu Bar Options

////////// Inventory Seach Text Box Logic
        private void InventorySearchBox_TextChanged(object sender, EventArgs e)
        {
            PopulateProductListDataGrid();
        }
////////// END Inventory Seach Text Box Logic

////////// Function used to populate the data grid with products from the registered inventory
        private void PopulateProductListDataGrid()
        {
            // TODO: Filter data grid columns based on user's role
            productList.DataSource = InventoryManagementBusinessLayer.ConsultInformation.FetchProductListInformation("Admin", inventorySearchBox.Text);

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

        }
////////// END Function PopulateProductListDataGrid

////////// Function that allows users to view the quick summary of a selected product
        private void ProductList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Declare an non oficial auxiliary form to display product information, given a product's internal identification number
            ProductInformationTemplateForm productInformationForm = new ProductInformationTemplateForm(productList.SelectedCells[0].Value.ToString());
            productInformationForm.Show(); // Summon the temporary summary form 
        }
////////// END Function ProductList_CellDoubleClick
    }
}
