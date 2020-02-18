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
    public partial class SaleInformationTemplateForm : Form
    {
        Sale sale;

        public SaleInformationTemplateForm(String saleId)
        {
            InitializeComponent();

            DisplayTransactionInformation(saleId);
        }

        #region Form Load Logic
        private void SaleInformationTemplateForm_Load(object sender, EventArgs e)
        {
            PopulateContentDataGrid(); 
        }
        #endregion

        #region Auxiliary Functions
        /// <summary>
        /// Function to display a transaction's information
        /// </summary>
        /// <param name="saleId">Identification number of the desired transaction</param>
        private void DisplayTransactionInformation(String saleId)
        {
            sale = SaleInformationManager.ConsultTransactionInformationBySalesId(saleId);

            this.Text += " " + sale.Id;

            saleIdLabel.Text = sale.Id;
            saleDateLabel.Text = sale.TransactionDate.ToString();
            soldByLabel.Text = sale.SoldBy;
            statusLabel.Text = sale.Status;
            deliveryCheckBox.Checked = sale.Delivery;
        }

        private void PopulateContentDataGrid()
        {
            contentDataGridView.DataSource = new List<Product>();
            contentDataGridView.Refresh();

            List<Product> content = SaleInformationManager.ConsultTransactionContentInformation(sale.Id);

            if (content.Count > 0)
            {
                contentDataGridView.DataSource = content;
                contentDataGridView.Refresh();

                // Hidding unnecessary fields
                contentDataGridView.Columns["Id"].Visible = false;
                contentDataGridView.Columns["Key"].Visible = false;
                contentDataGridView.Columns["Supplier"].Visible = false;
                contentDataGridView.Columns["Category"].Visible = false;
                contentDataGridView.Columns["Type"].Visible = false;
                contentDataGridView.Columns["UnitCost"].Visible = false;
                contentDataGridView.Columns["MinimumQuantity"].Visible = false;
                contentDataGridView.Columns["MaximumQuantity"].Visible = false;
                contentDataGridView.Columns["RegisteredBy"].Visible = false;
                contentDataGridView.Columns["RegistrationDate"].Visible = false;
                contentDataGridView.Columns["ModifiedBy"].Visible = false;
                contentDataGridView.Columns["ModificationDate"].Visible = false;
                contentDataGridView.Columns["Discontinued"].Visible = false;

                // Formationg columns
                contentDataGridView.Columns["Name"].Width = 150;
                contentDataGridView.Columns["Unit"].Width = 50;
                contentDataGridView.Columns["UnitPrice"].Width = 80;
                contentDataGridView.Columns["Brand"].Width = 70;
                contentDataGridView.Columns["Quantity"].Width = 60;
                //contentDataGridView.Columns["Total"].Width = 50;

                int quantity = 0;
                decimal total = 0;

                foreach (Product item in content)
                {
                    quantity += item.Quantity;
                    total += item.Total;
                }

                numberOfItemsLabel.Text = "Number of Items: " + quantity.ToString();
                totalLabel.Text = "Total: $" + total.ToString("0.00");
            }
            else
            {
                numberOfItemsLabel.Text = "Number of Items: 0";
                totalLabel.Text = "Total: $0.00";
            }
        }
        #endregion
    }
}
