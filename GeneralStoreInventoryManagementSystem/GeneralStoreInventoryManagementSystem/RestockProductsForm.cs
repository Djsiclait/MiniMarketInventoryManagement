using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Custom Library
using InventoryManagementBusinessLayer.ProductInformation;
using InventoryManagementBusinessLayer.Protocols;
using InventoryManagementEntityLayer.Product;

namespace GeneralStoreInventoryManagementSystem
{
    public partial class RestockProductsForm : Form
    {
        public RestockProductsForm()
        {
            InitializeComponent();
        }

        #region Load Form Logic
        private void RestockProductsForm_Load(object sender, EventArgs e)
        {
            // Identifying correct protocol for current user in session
            if (SystemProtocols.ApplySessionsProtocols(1, null, null))
            {
                // Disabling the other Products option 
                registerNewProductMenuSubOption.Visible = false;
                registerNewProductMenuSubOption.Enabled = false;

                // Disabling all admin options
                adminMenuOption.Visible = false;
                adminMenuOption.Enabled = false;
            }

            SystemProtocols.ApplyActivityProtocols("PRO1", null, null);

            PopulateProductListDataGrid();
            UpdateDisplayLabels();
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
            FormsMenuList.restockProductsFrom.Dispose();
        }
        #endregion

        #region Menu Bar Options
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

        #region Log Out
        private void LogOutLabel_Click(object sender, EventArgs e)
        {
            // Executing correct log out processes
            SystemProtocols.ApplyLogOutProtocols();
            FormsMenuList.loginForm.Show();

            SystemProtocols.ApplyCartManagementProtocol(3, null, 0, null, 0); // clearing the cart before logging out

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
        #endregion

        #endregion

        #region Text Changed Logic
        private void InventorySearchBox_TextChanged(object sender, EventArgs e)
        {
            PopulateProductListDataGrid();
            UpdateDisplayLabels();
        }
        #endregion

        #region Click Logic
        private void RestockButton_Click(object sender, EventArgs e)
        {
            String message = ProductInformationManager.updateRegisteredProductInformationForRestock(productList.SelectedCells[0].Value.ToString(), (int)addedAmmountNumericUpDown.Value);

            if (message == "SUCCESS")
            {
                addedAmmountNumericUpDown.Value = 1;

                inventorySearchBox.Text = productList.SelectedCells[2].Value.ToString();
                UpdateDisplayLabels();

                MessageBox.Show("Successful restock!");
            }
            else
                MessageBox.Show("FATAL ERROR");
        }

        private void ProductList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            UpdateDisplayLabels();
            // TODO: introduce inventory chart for the product
        }
        #endregion

        #region Auxiliary Functions
        /// <summary>
        /// Function that calculates the unit contribution margin ratio of the product using the unit cost and price
        /// UPM = (UP - UC) / UP * 100
        /// </summary>
        /// <returns>The string result of the formula</returns>
        private String CalculateUnitContributionMargin(decimal cost, decimal price)
        {
            // Applying unitary profit margin formula
            decimal contributionRatio = ((price - cost) / price) * 100; // Ratio form

            decimal contributionDollar = price - cost; // Dollar form

            decimal priceIncrease = price / cost; // Price multiplier

            return contributionRatio.ToString("0.##") + "% ($" + contributionDollar.ToString("0.##") + " or " + (priceIncrease.ToString("0.##") == "1" ? "1" : priceIncrease.ToString("0.##")) + "x price increase)";
        }

        /// <summary>
        /// Function used to populate the data grid with products from the registered inventory
        /// </summary>
        private void PopulateProductListDataGrid()
        {
            // Requesting information to populate the product list 
            productList.DataSource = ProductInformationManager.ConsultProductListInformation(inventorySearchBox.Text, false); 

            //productList.Sort(productList.Columns["Key"], ListSortDirection.Ascending);
            //productList.Columns["Key"].SortMode = DataGridViewColumnSortMode.Automatic;
            //productList.Columns["Name"].SortMode = DataGridViewColumnSortMode.Automatic;
            //productList.Columns["Brand"].SortMode = DataGridViewColumnSortMode.Automatic;
            //productList.Columns["Supplier"].SortMode = DataGridViewColumnSortMode.Automatic;

            // TODO: Fix sortable mode on inventory browser
            foreach (DataGridViewColumn column in productList.Columns)
                column.SortMode = DataGridViewColumnSortMode.Automatic;

            // Removing unnecesary information from the datagrid display
            productList.Columns["Id"].Visible = false;
            productList.Columns["Category"].Visible = false;
            productList.Columns["Type"].Visible = false;
            productList.Columns["MinimumQuantity"].Visible = false;
            productList.Columns["MaximumQuantity"].Visible = false;
            productList.Columns["RegisteredBy"].Visible = false;
            productList.Columns["RegistrationDate"].Visible = false;
            productList.Columns["ModifiedBy"].Visible = false;
            productList.Columns["ModificationDate"].Visible = false;
            productList.Columns["Total"].Visible = false;
        }

        /// <summary>
        /// Function that updates all display labels
        /// </summary>
        private void UpdateDisplayLabels()
        {
            Product product = ProductInformationManager.ConsultProductInformationByID(productList.SelectedCells[0].Value.ToString());

            keyDisplayLabel.Text = product.Key;
            nameDisplayLabel.Text = product.Name;
            brandDisplayLabel.Text = product.Brand;
            supplierDisplayLabel.Text = product.Supplier;
            categoryDisplayLabel.Text = product.Category;
            typeDisplayLabel.Text = product.Type;
            unitDisplayLabel.Text = product.Unit;
            unitCostDisplayLabel.Text = "RD$" + product.UnitCost.ToString();
            unitPriceDisplayLabel.Text = "RD$" + product.UnitPrice.ToString();
            quantityDisplayLabel.Text = product.Quantity.ToString() + " units";
            minimumDisplayLabel.Text = product.MinimumQuantity.ToString();
            maximumDisplayLabel.Text = product.MaximumQuantity.ToString();

            unitContributionMarginLabel.Text = CalculateUnitContributionMargin(product.UnitCost, product.UnitPrice);

            if (product.UnitPrice > product.UnitCost)
                unitContributionMarginLabel.ForeColor = Color.Green;
            else if (product.UnitPrice < product.UnitCost)
                unitContributionMarginLabel.ForeColor = Color.Red;
            else
                unitContributionMarginLabel.ForeColor = Color.Black;
        }
        #endregion
    }
}
