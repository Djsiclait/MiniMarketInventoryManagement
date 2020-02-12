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
using InventoryManagementBusinessLayer;
using InventoryManagementEntityLayer;

namespace GeneralStoreInventoryManagementSystem
{
    public partial class RegisterNewSaleFrom : Form
    {
        public RegisterNewSaleFrom()
        {
            InitializeComponent();
        }

        #region Load Form Logic
        private void RegisterNewSaleFrom_Load(object sender, EventArgs e)
        {
            // Identifying correct protocol for current user in session
            if (SystemProtocols.ApplySessionsProtocols(1, null, null))
            {
                // Disabling the other Products option 
                registerNewProductMenuSubOption.Visible = false;
                registerNewProductMenuSubOption.Enabled = false;
                restockProductsMenuSubOption.Visible = false;
                restockProductsMenuSubOption.Enabled = false;

                // Disabling all admin options
                adminMenuOption.Visible = false;
                adminMenuOption.Enabled = false;

                SystemProtocols.ApplyActivityProtocols("SAL1", null, null);
            }
            else
                SystemProtocols.ApplyActivityProtocols("SAL4", null, null);

            PopulateProductDataGrid();
            UpdateCartSummaryDataGrid();
        }
        #endregion

        #region On Form Closing Override
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            // Executing correct log out processes
            SystemProtocols.ApplyLogOutProtocols();
            FormsMenuList.loginForm.Show();

            // Closing form while freeing system resources
            FormsMenuList.registerNewSaleForm.Dispose();
        }
        #endregion

        #region Menu Bar Options
        private void ViewSalesMenuOption_Click(object sender, EventArgs e)
        {
            // Summon Sales Registry Form
            FormsMenuList.salesRecordForm = new SalesRecordForm();
            FormsMenuList.salesRecordForm.Show();

            // Closing form while freeing system resources
            FormsMenuList.registerNewSaleForm.Dispose();
        }

        private void BrowseProductsMenuSubOption_Click(object sender, EventArgs e)
        {
            // Summon Product Browser Form
            FormsMenuList.inventorySearchForm = new InventorySearchForm();
            FormsMenuList.inventorySearchForm.Show();

            // Closing form while freeing system resources
            FormsMenuList.registerNewSaleForm.Dispose();
        }

        private void RegisterNewProductMenuSubOption_Click(object sender, EventArgs e)
        {
            // Summon Register New Product Form
            FormsMenuList.registerNewProduct = new RegisterNewProductForm();
            FormsMenuList.registerNewProduct.Show();

            // Closing form while freeing system resources
            FormsMenuList.registerNewSaleForm.Dispose();
        }

        private void RestockProductsMenuSubOption_Click(object sender, EventArgs e)
        {
            // Summon Restock Products Form
            FormsMenuList.restockProductsFrom = new RestockProductsForm();
            FormsMenuList.restockProductsFrom.Show();

            // Closing form while freeing system resources
            FormsMenuList.registerNewSaleForm.Dispose();
        }

        private void ViewUsersOption_Click(object sender, EventArgs e)
        {
            // Summon Users Registry Form
            FormsMenuList.usersRegistryForm = new UsersRegistryForm();
            FormsMenuList.usersRegistryForm.Show();

            // Closing form while freeing system resources
            FormsMenuList.registerNewSaleForm.Dispose();
        }

        private void RegisterNewUserOption_Click(object sender, EventArgs e)
        {
            // Summon Register New User Form
            FormsMenuList.registerNewUserForm = new RegisterNewUserForm();
            FormsMenuList.registerNewUserForm.Show();

            // Closing form while freeing system resources
            FormsMenuList.registerNewSaleForm.Dispose();
        }

        private void ViewGraphsOption_Click(object sender, EventArgs e)
        {
            // Summon Graphs Analytics Form
            FormsMenuList.graphsAnaliticsForm = new GraphsAnalyticsForm();
            FormsMenuList.graphsAnaliticsForm.Show();

            // Closing form while freeing system resources
            FormsMenuList.registerNewSaleForm.Dispose();
        }

        private void ViewReportsOption_Click(object sender, EventArgs e)
        {
            // Summon Reports Analytics Form
            FormsMenuList.reportsAnalyticsForm = new ReportsAnalyticsForm();
            FormsMenuList.reportsAnalyticsForm.Show();

            // Closing form while freeing system resources
            FormsMenuList.registerNewSaleForm.Dispose();
        }

        private void ViewActivityLogsOption_Click(object sender, EventArgs e)
        {
            // Summon Activity Logs Form
            FormsMenuList.activitiesLogForm = new ActivitiesLogForm();
            FormsMenuList.activitiesLogForm.Show();

            // Closing form while freeing system resources
            FormsMenuList.registerNewSaleForm.Dispose();
        }

        private void ViewErrorLogsOption_Click(object sender, EventArgs e)
        {
            // Summon Error Logs Form
            FormsMenuList.errorsLogForm = new ErrorsLogForm();
            FormsMenuList.errorsLogForm.Show();

            // Closing form while freeing system resources
            FormsMenuList.registerNewSaleForm.Dispose();
        }

        private void ViewCartLabel_Click(object sender, EventArgs e)
        {
            // Summon View Cart Form
            FormsMenuList.viewCartForm = new ViewCartForm();
            FormsMenuList.viewCartForm.Show();

            // Closing form while freeing system resources
            FormsMenuList.registerNewSaleForm.Dispose();
        }

        private void ViewCartLabel_MouseHover(object sender, EventArgs e)
        {
            FormsMenuList.registerNewSaleForm.viewCartLabel.ForeColor = Color.Blue;
        }

        private void ViewCartLabel_MouseLeave(object sender, EventArgs e)
        {
            FormsMenuList.registerNewSaleForm.viewCartLabel.ForeColor = Color.Black;
        }

        #region Log Out
        private void LogOutLabel_Click(object sender, EventArgs e)
        {
            // Executing correct log out processes
            SystemProtocols.ApplyLogOutProtocols();
            FormsMenuList.loginForm.Show();

            // Closing form while freeing system resources
            FormsMenuList.registerNewSaleForm.Dispose();

        }

        private void LogOutLabel_MouseHover(object sender, EventArgs e)
        {
            FormsMenuList.registerNewSaleForm.logOutLabel.ForeColor = Color.Red;
        }

        private void LogOutLabel_MouseLeave(object sender, EventArgs e)
        {
            FormsMenuList.registerNewSaleForm.logOutLabel.ForeColor = Color.Black;
        }
        #endregion

        #endregion

        #region Text Changed Logic
        private void productSearchTextBox_TextChanged(object sender, EventArgs e)
        {
            PopulateProductDataGrid();
        }
        private void quantityNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in productDataGridView.SelectedRows)
                if (quantityNumericUpDown.Maximum < FormatToInt(row.Cells[10].Value.ToString()))
                    quantityNumericUpDown.Maximum = FormatToInt(row.Cells[10].Value.ToString());
        }
        #endregion

        #region Button Click Logic
        private void addItemButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in productDataGridView.SelectedRows)
            {
                if (FormatToInt(row.Cells[10].Value.ToString()) > 0)
                {
                    Product product = new Product();

                    product.Id = row.Cells[0].Value.ToString();
                    product.Name = row.Cells[2].Value.ToString();
                    product.Unit = row.Cells[5].Value.ToString();
                    product.UnitPrice = FormatToDecimal(row.Cells[9].Value.ToString());
                    product.Quantity = quantityNumericUpDown.Value < FormatToInt(row.Cells[10].Value.ToString()) ? (int)quantityNumericUpDown.Value : FormatToInt(row.Cells[10].Value.ToString());

                    SystemProtocols.ApplyCartManagementProtocol(2, null, product, FormatToInt(row.Cells[10].Value.ToString()));
                }
            }

            quantityNumericUpDown.Value = 1;
            quantityNumericUpDown.Maximum = 2;

            UpdateCartSummaryDataGrid();
        }
        private void productDataGridView_Click(object sender, EventArgs e)
        {
            quantityNumericUpDown.Value = 1;
            quantityNumericUpDown.Maximum = 2;
        }
        #endregion

        #region Auxiliary Functions
        /// <summary>
        /// Function to populate the product list data grid
        /// </summary>
        private void PopulateProductDataGrid()
        {
            // TODO: Create a separate fetchproduct list for this form
            productDataGridView.DataSource = ConsultInformation.FetchProductListInformation(productSearchTextBox.Text);

            // Hidding unnecessary fields
            productDataGridView.Columns["Id"].Visible = false;
            productDataGridView.Columns["Supplier"].Visible = false;
            productDataGridView.Columns["Category"].Visible = false;
            productDataGridView.Columns["Type"].Visible = false;
            productDataGridView.Columns["UnitCost"].Visible = false;
            productDataGridView.Columns["MinimumQuantity"].Visible = false;
            productDataGridView.Columns["MaximumQuantity"].Visible = false;
            productDataGridView.Columns["RegisteredBy"].Visible = false;
            productDataGridView.Columns["RegistrationDate"].Visible = false;
            productDataGridView.Columns["ModifiedBy"].Visible = false;
            productDataGridView.Columns["ModificationDate"].Visible = false;
            productDataGridView.Columns["Discontinued"].Visible = false;

            // Formationg columns
            productDataGridView.Columns["Brand"].Width = 70;
            productDataGridView.Columns["Unit"].Width = 70;
        }

        private void UpdateCartSummaryDataGrid()
        {
            List<Product> summary = SystemProtocols.ApplyCartManagementProtocol(1, null, null, 0);

            cartSummaryDataGridView.DataSource = null;
            cartSummaryDataGridView.DataSource = summary;

            // Hidding unnecessary fields
            cartSummaryDataGridView.Columns["Id"].Visible = false;
            cartSummaryDataGridView.Columns["Key"].Visible = false;
            cartSummaryDataGridView.Columns["Brand"].Visible = false;
            cartSummaryDataGridView.Columns["Supplier"].Visible = false;
            cartSummaryDataGridView.Columns["Category"].Visible = false;
            cartSummaryDataGridView.Columns["Type"].Visible = false;
            cartSummaryDataGridView.Columns["UnitCost"].Visible = false;
            cartSummaryDataGridView.Columns["MinimumQuantity"].Visible = false;
            cartSummaryDataGridView.Columns["MaximumQuantity"].Visible = false;
            cartSummaryDataGridView.Columns["RegisteredBy"].Visible = false;
            cartSummaryDataGridView.Columns["RegistrationDate"].Visible = false;
            cartSummaryDataGridView.Columns["ModifiedBy"].Visible = false;
            cartSummaryDataGridView.Columns["ModificationDate"].Visible = false;
            cartSummaryDataGridView.Columns["Discontinued"].Visible = false;

            // Formationg columns
            cartSummaryDataGridView.Columns["Name"].Width = 200;
            cartSummaryDataGridView.Columns["Unit"].Width = 50;
            cartSummaryDataGridView.Columns["UnitPrice"].Width = 70;
            cartSummaryDataGridView.Columns["Quantity"].Width = 80;

            int quantity = 0;
            decimal total = 0;
            foreach (Product item in summary)
            {
                quantity += item.Quantity;
                total += item.UnitPrice;
            }

            numberLabel.Text = "Number of Item: " + quantity;
            totalLabel.Text = "Total: $" + total.ToString("0.00"); 
        }

        /// <summary>
        /// Function to convert strings to decimals
        /// </summary>
        /// <param name="value">String value needed to be converted</param>
        /// <returns>A decimal equivalent of the provided string value</returns>
        private static decimal FormatToDecimal(String value)
        {
            decimal result;

            decimal.TryParse(value, out result);

            return result;
        }

        /// <summary>
        /// Function to convert strings to ints
        /// </summary>
        /// <param name="value">String value needed to be converted</param>
        /// <returns>An int equivalent of the provided string value</returns>
        private static int FormatToInt(String value)
        {
            int result;

            int.TryParse(value, out result);

            return result;
        }
        #endregion

    }
}