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
        Sale sale; // Sale object to host transaction information

        ReturnItemsMiniForm returnItemsMiniForm; // Child form to facilitate returns

        public SaleInformationTemplateForm(String saleId)
        {
            InitializeComponent();

            DisplayTransactionInformation(saleId); // Fetching and displaying the information of requested transaction
        }

        #region On Form Closing Logic
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            // Notifying parent that this process was killed  
            FormsMenuList.salesRecordForm.ChildWasKilled(); 

            // Disposing this form's child if and active
            DisposeOnlyChild();
        }
        #endregion

        #region Form Load Logic
        private void SaleInformationTemplateForm_Load(object sender, EventArgs e)
        {
            PopulateContentDataGrid(); 
        }
        #endregion

        #region Button Click Logic
        private void VoidSaleButton_Click(object sender, EventArgs e)
        {
            if (sale.Status == "Valid") // Confirming that the current transaction is valid
            {
                // Requesting to void the current transaction
                SaleInformationManager.UpdateTransactionStatusInformationToVoid(sale.Id);

                DisplayTransactionInformation(sale.Id); // Updating the sale's information

                FormsMenuList.salesRecordForm.RefreshSalesRecordsDataGrid(); // Notifying the parent to update its information

                MessageBox.Show("Transaction has been voided!");
            }
            else
                MessageBox.Show("This transaction has already been voided/returned");
        }

        private void ReturnItemsButton_Click(object sender, EventArgs e)
        {
            if (sale.Status == "Valid" && returnItemsMiniForm == null) // Confirming that the current transaction is valid and a child form hasn't been opened
            {
                returnItemsMiniForm = new ReturnItemsMiniForm(sale.Id); // calling child form
                returnItemsMiniForm.Show();
            }
            if (sale.Status == "Valid" && returnItemsMiniForm != null)
                returnItemsMiniForm.Focus(); // focusing on already opened child
            else
                MessageBox.Show("This transaction has already been voided/returned");
        }
        #endregion

        #region Auxiliary Functions
        /// <summary>
        /// Function to display a transaction's information
        /// </summary>
        /// <param name="saleId">Identification number of the desired transaction</param>
        private void DisplayTransactionInformation(String saleId)
        {
            // Requesting transaction information
            sale = SaleInformationManager.ConsultTransactionInformationBySalesId(saleId);

            this.Text = "Sale Information: " + sale.Id;

            saleIdLabel.Text = sale.Id;
            saleDateLabel.Text = sale.TransactionDate.ToString();
            soldByLabel.Text = sale.SoldBy;
            statusLabel.Text = sale.Status;
            deliveryCheckBox.Checked = sale.Delivery;
            parentIdLabel.Text = sale.Parent == "" ? "None" : sale.Parent;
            childIdLabel.Text = sale.Child == "" ? "None" : sale.Child;
            lastModifiedDateLabel.Text = sale.LastModified.ToString();
        }

        /// <summary>
        /// Function to dispose of any open residual minimforms
        /// </summary>
        public void DisposeOnlyChild()
        {
            if (returnItemsMiniForm != null)
                returnItemsMiniForm.Dispose(); // killing its opened child
        }

        /// <summary>
        /// Function to populate the transaction content grid
        /// </summary>
        private void PopulateContentDataGrid()
        {
            contentDataGridView.DataSource = new List<Product>();
            contentDataGridView.Refresh();

            #region Grid Formating
            // Hidding unnecessary fields
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
            contentDataGridView.Columns["Id"].Width = 60;
            contentDataGridView.Columns["Name"].Width = 150;
            contentDataGridView.Columns["Unit"].Width = 50;
            contentDataGridView.Columns["UnitPrice"].Width = 80;
            contentDataGridView.Columns["Brand"].Width = 70;
            contentDataGridView.Columns["Quantity"].Width = 60;
            #endregion

            // Fetching purchased products associated with this transaction
            List<Product> content = SaleInformationManager.ConsultTransactionContentInformation(sale.Id);

            if (content.Count > 0)
            {
                contentDataGridView.DataSource = content;
                contentDataGridView.Refresh();

                int quantity = 0;
                decimal total = 0;

                foreach (Product item in content)
                {
                    quantity += item.Quantity; // counting how manu units of products were previously purchased in this transaction
                    total += item.Total; // calculating total cost of transaction 
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

        /// <summary>
        /// Function used but this form's parent that notifies that its child has successfully made a return 
        /// so this form can update the current transaction's information
        /// </summary>
        public void UpdateSelfAfterSuccessfulReturn()
        {
            DisplayTransactionInformation(sale.Id);
            PopulateContentDataGrid();
        }
        #endregion
    }
}
