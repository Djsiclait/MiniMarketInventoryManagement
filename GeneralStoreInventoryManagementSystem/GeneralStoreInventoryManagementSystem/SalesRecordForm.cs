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

namespace GeneralStoreInventoryManagementSystem
{
    public partial class SalesRecordForm : Form
    {
        List<SaleInformationTemplateForm> children = new List<SaleInformationTemplateForm>();

        public SalesRecordForm()
        {
            InitializeComponent();
        }

        #region Load Form Logic
        private void SalesRecordForm_Load(object sender, EventArgs e)
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

                SystemProtocols.ApplyActivityProtocols("SAL2", null, null);
            }
            else
                SystemProtocols.ApplyActivityProtocols("SAL3", null, null);

            PopulateSalesDataGrid();

        }
        #endregion

        #region On Form Closing Override
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            // Disposing any open child
            DisposeAllChildren();

            // Executing correct log out processes
            SystemProtocols.ApplyLogOutProtocols();
            FormsMenuList.loginForm.Show();

            SystemProtocols.ApplyCartManagementProtocol(3, null, 0, null, 0); // clearing the cart before logging out

            // Closing form while freeing system resources
            FormsMenuList.salesRecordForm.Dispose();
        }
        #endregion

        #region Menu Bar Options
        private void MakeSaleMenuOption_Click(object sender, EventArgs e)
        {
            // Summon Register New Sale Form
            FormsMenuList.registerNewSaleForm = new RegisterNewSaleFrom();
            FormsMenuList.registerNewSaleForm.Show();

            // Disposing any open child
            DisposeAllChildren();

            // Closing form while freeing system resources
            FormsMenuList.salesRecordForm.Dispose();
        }

        private void BrowseProductsMenuSubOption_Click(object sender, EventArgs e)
        {
            // Summon Product Browser Form
            FormsMenuList.inventorySearchForm = new InventorySearchForm();
            FormsMenuList.inventorySearchForm.Show();

            // Disposing any open child
            DisposeAllChildren();

            // Closing form while freeing system resources
            FormsMenuList.salesRecordForm.Dispose();
        }

        private void RegisterNewProductMenuSubOption_Click(object sender, EventArgs e)
        {
            // Summon Register New Product Form
            FormsMenuList.registerNewProduct = new RegisterNewProductForm();
            FormsMenuList.registerNewProduct.Show();

            // Disposing any open child
            DisposeAllChildren();

            // Closing form while freeing system resources
            FormsMenuList.salesRecordForm.Dispose();
        }

        private void RestockProductsMenuSubOption_Click(object sender, EventArgs e)
        {
            // Summon Restock Products Form
            FormsMenuList.restockProductsFrom = new RestockProductsForm();
            FormsMenuList.restockProductsFrom.Show();

            // Disposing any open child
            DisposeAllChildren();

            // Closing form while freeing system resources
            FormsMenuList.salesRecordForm.Dispose();
        }

        private void ViewUsersOption_Click(object sender, EventArgs e)
        {
            // Summon Users Registry Form
            FormsMenuList.usersRegistryForm = new UsersRegistryForm();
            FormsMenuList.usersRegistryForm.Show();

            // Disposing any open child
            DisposeAllChildren();

            // Closing form while freeing system resources
            FormsMenuList.salesRecordForm.Dispose();
        }

        private void RegisterNewUserOption_Click(object sender, EventArgs e)
        {
            // Summon Register New User Form
            FormsMenuList.registerNewUserForm = new RegisterNewUserForm();
            FormsMenuList.registerNewUserForm.Show();

            // Disposing any open child
            DisposeAllChildren();

            // Closing form while freeing system resources
            FormsMenuList.salesRecordForm.Dispose();
        }

        private void ViewGraphsOption_Click(object sender, EventArgs e)
        {
            // Summon Graphs Analytics Form
            FormsMenuList.graphsAnaliticsForm = new GraphsAnalyticsForm();
            FormsMenuList.graphsAnaliticsForm.Show();

            // Disposing any open child
            DisposeAllChildren();

            // Closing form while freeing system resources
            FormsMenuList.salesRecordForm.Dispose();
        }

        private void ViewReportsOption_Click(object sender, EventArgs e)
        {
            // Summon Reports Analytics Form
            FormsMenuList.reportsAnalyticsForm = new ReportsAnalyticsForm();
            FormsMenuList.reportsAnalyticsForm.Show();

            // Disposing any open child
            DisposeAllChildren();

            // Closing form while freeing system resources
            FormsMenuList.salesRecordForm.Dispose();
        }

        private void ViewActivityLogsOption_Click(object sender, EventArgs e)
        {
            // Summon Activity Logs Form
            FormsMenuList.activitiesLogForm = new ActivitiesLogForm();
            FormsMenuList.activitiesLogForm.Show();

            // Disposing any open child
            DisposeAllChildren();

            // Closing form while freeing system resources
            FormsMenuList.salesRecordForm.Dispose();
        }

        private void ViewErrorLogsOption_Click(object sender, EventArgs e)
        {
            // Summon Error Logs Form
            FormsMenuList.errorsLogForm = new ErrorsLogForm();
            FormsMenuList.errorsLogForm.Show();

            // Disposing any open child
            DisposeAllChildren();

            // Closing form while freeing system resources
            FormsMenuList.salesRecordForm.Dispose();
        }

        private void ViewCartLabel_Click(object sender, EventArgs e)
        {
            // Summon View Cart Form
            FormsMenuList.viewCartForm = new ViewCartForm();
            FormsMenuList.viewCartForm.Show();

            // Disposing any open child
            DisposeAllChildren();

            // Closing form while freeing system resources
            FormsMenuList.salesRecordForm.Dispose();
        }

        private void ViewCartLabel_MouseHover(object sender, EventArgs e)
        {
            FormsMenuList.salesRecordForm.viewCartLabel.ForeColor = Color.Blue;
        }

        private void ViewCartLabel_MouseLeave(object sender, EventArgs e)
        {
            FormsMenuList.salesRecordForm.viewCartLabel.ForeColor = Color.Black;
        }

        #region Log Out
        private void LogOutLabel_Click(object sender, EventArgs e)
        {
            // Executing correct log out processes
            SystemProtocols.ApplyLogOutProtocols();
            FormsMenuList.loginForm.Show();

            // Disposing any open child
            DisposeAllChildren();

            SystemProtocols.ApplyCartManagementProtocol(3, null, 0, null, 0); // clearing the cart before logging out

            // Closing form while freeing system resources
            FormsMenuList.salesRecordForm.Dispose();
        }

        private void LogOutLabel_MouseHover(object sender, EventArgs e)
        {
            FormsMenuList.salesRecordForm.logOutLabel.ForeColor = Color.Red;
        }

        private void LogOutLabel_MouseLeave(object sender, EventArgs e)
        {
            FormsMenuList.salesRecordForm.logOutLabel.ForeColor = Color.Black;
        }
        #endregion

        #endregion

        #region Text Change Logic
        private void SalesSearchBox_TextChanged(object sender, EventArgs e)
        {
            PopulateSalesDataGrid();
        }
        #endregion

        #region Double Click Logic
        private void SalesList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SaleInformationTemplateForm child = new SaleInformationTemplateForm(salesList.SelectedCells[0].Value.ToString());
            child.Show(); Console.WriteLine("FUCK YOU!!!!");

            children.Add(child);
        }
        #endregion

        #region Auxiliary Function
        /// <summary>
        /// Funtion to populate the data grid
        /// </summary>
        private void PopulateSalesDataGrid()
        {
            salesList.DataSource = ConsultInformation.FetchSalesRecordsInformation(salesSearchBox.Text);

            // Formating the flieds
            salesList.Columns["TransactionDate"].Width = 350;
            salesList.Columns["Delivery"].Width = 50;
        }

        /// <summary>
        /// Function to dispose any opon children of this form
        /// </summary>
        private void DisposeAllChildren()
        {
            foreach (SaleInformationTemplateForm child in children)
                child.Dispose();
        }
        #endregion
    }
}
