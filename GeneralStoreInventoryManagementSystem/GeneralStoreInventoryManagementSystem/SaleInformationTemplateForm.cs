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

        }
        #endregion

        #region Auxiliary Functions
        private void DisplayTransactionInformation(String saleId)
        {
            sale = ConsultInformation.FetchTransactionInformationBySalesId(saleId);

            this.Name += " " + sale.Id;

            saleIdLabel.Text = sale.Id;
            saleDateLabel.Text = sale.TransactionDate.ToString();
            soldByLabel.Text = sale.SoldBy;
            statusLabel.Text = sale.Status;
            deliveryCheckBox.Checked = sale.Delivery;
        }
        #endregion
    }
}
