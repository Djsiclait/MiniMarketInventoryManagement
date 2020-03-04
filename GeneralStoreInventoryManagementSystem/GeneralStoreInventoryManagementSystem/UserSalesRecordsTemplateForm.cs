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
using InventoryManagementBusinessLayer.ReportInformation;
using InventoryManagementBusinessLayer.SaleInformation;
using InventoryManagementBusinessLayer.UserInformation;
using InventoryManagementEntityLayer.Product;
using InventoryManagementEntityLayer.UserProfile;

namespace GeneralStoreInventoryManagementSystem
{
    public partial class UserSalesRecordsTemplateForm : Form
    {
        readonly UserProfile user;

        public UserSalesRecordsTemplateForm(String username)
        {
            InitializeComponent();

            user = UserInformationManager.ConsultUserInformationByUsername(username);
        }

        #region On Form Load Logic
        private void UserSalesRecordsTemplateForm_Load(object sender, EventArgs e)
        {
            usernameLabel.Text = user.Username;
            roleLabel.Text = user.Role;

            newestDateTimePicker.Value = DateTime.Now;
            newestDateTimePicker.MaxDate = DateTime.Today.AddDays(1);
            oldestDateTimePicker.Value = DateTime.Today.AddMonths(-1);
            oldestDateTimePicker.MaxDate = DateTime.Today.AddDays(-1);
        }
        #endregion

        #region Value Changed Logic
        private void NewestDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            oldestDateTimePicker.MaxDate = newestDateTimePicker.Value.AddDays(-1);
            oldestDateTimePicker.Value = newestDateTimePicker.Value.AddDays(-1);
        }

        private void OldestDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            PopulateSalesDataGrid();
            DisplaySelectedSalesContentDataGrid();
        }
        #endregion

        #region Cell Click Logic
        private void SalesDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DisplaySelectedSalesContentDataGrid();
        }
        #endregion

        #region Key Down Logic
        private void SalesDataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.Up)
                DisplaySelectedSalesContentDataGrid(); // there's a delaly in between the key down and the switch of the selected row
        }

        #endregion

        #region Auxiliary Functions
        private void PopulateSalesDataGrid()
        {
            salesDataGridView.DataSource = ReportInformationManager.ConsultSalesMadeByUserInformation(user.Username, oldestDateTimePicker.Value, newestDateTimePicker.Value);

            salesDataGridView.Columns["Delivery"].Visible = false;
            salesDataGridView.Columns["Status"].Visible = false;
            salesDataGridView.Columns["Child"].Visible = false;
            salesDataGridView.Columns["LastModified"].Visible = false;
            salesDataGridView.Columns["SoldBy"].Visible = false;
        }

        private void DisplaySelectedSalesContentDataGrid()
        {
            salesContentDataGridView.DataSource = new List<Product>();
            salesContentDataGridView.Refresh();

            #region Grid Formating
            salesContentDataGridView.Columns["Key"].Visible = false;
            salesContentDataGridView.Columns["Supplier"].Visible = false;
            salesContentDataGridView.Columns["Category"].Visible = false;
            salesContentDataGridView.Columns["Type"].Visible = false;
            salesContentDataGridView.Columns["UnitCost"].Visible = false;
            salesContentDataGridView.Columns["MinimumQuantity"].Visible = false;
            salesContentDataGridView.Columns["MaximumQuantity"].Visible = false;
            salesContentDataGridView.Columns["RegisteredBy"].Visible = false;
            salesContentDataGridView.Columns["RegistrationDate"].Visible = false;
            salesContentDataGridView.Columns["ModifiedBy"].Visible = false;
            salesContentDataGridView.Columns["ModificationDate"].Visible = false;
            salesContentDataGridView.Columns["Discontinued"].Visible = false;

            // Formationg columns
            salesContentDataGridView.Columns["Id"].Width = 60;
            salesContentDataGridView.Columns["Name"].Width = 200;
            salesContentDataGridView.Columns["Unit"].Width = 50;
            salesContentDataGridView.Columns["UnitPrice"].Width = 80;
            salesContentDataGridView.Columns["Quantity"].Width = 60;
            salesContentDataGridView.Columns["Brand"].Width = 150;
            #endregion

            List<Product> content = new List<Product>();

            if (salesDataGridView.Rows.Count > 0)
                content = SaleInformationManager.ConsultTransactionContentInformation(salesDataGridView.SelectedCells[0].Value.ToString());

            salesContentDataGridView.DataSource = content;
            salesContentDataGridView.Refresh();

            Decimal total = 0;

            foreach (Product product in content)
                total += product.Total;

            totalLabel.Text = totalLabel.Text.Split('$')[0]+ "$ " + total.ToString("0.00");
        }
        #endregion
    }
}
