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
using InventoryManagementBusinessLayer.Protocols;
using InventoryManagementBusinessLayer.SaleInformation;

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

        #region  Key Down Shortcut Logic
        private void SalesRecordForm_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F1:

                    // The user is already viewing the desired page

                    break;

                case Keys.F2:

                    #region Make Sales
                    // Summon Register New Sale Form
                    FormsMenuList.registerNewSaleForm = new RegisterNewSaleFrom();
                    FormsMenuList.registerNewSaleForm.Show();

                    // Disposing any open child
                    DisposeAllChildren();

                    // Closing form while freeing system resources
                    FormsMenuList.salesRecordForm.Dispose();
                    #endregion

                    break;

                case Keys.F3:

                    #region Product Browser
                    // Summon Product Browser Form
                    FormsMenuList.inventorySearchForm = new InventorySearchForm();
                    FormsMenuList.inventorySearchForm.Show();

                    // Disposing any open child
                    DisposeAllChildren();

                    // Closing form while freeing system resources
                    FormsMenuList.salesRecordForm.Dispose();
                    #endregion

                    break;

                case Keys.F4:

                    #region Register New Product
                    // Identifying correct protocol for current user in session
                    if (!SystemProtocols.ApplySessionsProtocols(1, null, null))
                    {
                        // Summon Register New Product Form
                        FormsMenuList.registerNewProduct = new RegisterNewProductForm();
                        FormsMenuList.registerNewProduct.Show();

                        // Disposing any open child
                        DisposeAllChildren();

                        // Closing form while freeing system resources
                        FormsMenuList.salesRecordForm.Dispose();
                    }
                    #endregion

                    break;

                case Keys.F5:

                    #region Restock Products
                    // Identifying correct protocol for current user in session
                    if (!SystemProtocols.ApplySessionsProtocols(1, null, null))
                    {
                        // Summon Restock Products Form
                        FormsMenuList.restockProductsFrom = new RestockProductsForm();
                        FormsMenuList.restockProductsFrom.Show();

                        // Disposing any open child
                        DisposeAllChildren();

                        // Closing form while freeing system resources
                        FormsMenuList.salesRecordForm.Dispose();
                    }
                    #endregion

                    break;

                case Keys.F6:

                    #region View Users
                    // Identifying correct protocol for current user in session
                    if (!SystemProtocols.ApplySessionsProtocols(1, null, null))
                    {
                        // Summon Users Registry Form
                        FormsMenuList.usersRegistryForm = new UsersRegistryForm();
                        FormsMenuList.usersRegistryForm.Show();

                        // Disposing any open child
                        DisposeAllChildren();

                        // Closing form while freeing system resources
                        FormsMenuList.salesRecordForm.Dispose();
                    }
                    #endregion

                    break;

                case Keys.F7:

                    #region Register New User
                    // Identifying correct protocol for current user in session
                    if (!SystemProtocols.ApplySessionsProtocols(1, null, null))
                    {
                        // Summon Register New User Form
                        FormsMenuList.registerNewUserForm = new RegisterNewUserForm();
                        FormsMenuList.registerNewUserForm.Show();

                        // Disposing any open child
                        DisposeAllChildren();

                        // Closing form while freeing system resources
                        FormsMenuList.salesRecordForm.Dispose();
                    }
                    #endregion

                    break;

                case Keys.F8:

                    #region View Graphs
                    // Identifying correct protocol for current user in session
                    if (!SystemProtocols.ApplySessionsProtocols(1, null, null))
                    {
                        // Summon Graphs Analytics Form
                        FormsMenuList.graphsAnaliticsForm = new GraphsAnalyticsForm();
                        FormsMenuList.graphsAnaliticsForm.Show();

                        // Disposing any open child
                        DisposeAllChildren();

                        // Closing form while freeing system resources
                        FormsMenuList.salesRecordForm.Dispose();
                    }
                    #endregion

                    break;

                case Keys.F9:

                    #region View Reports
                    // Identifying correct protocol for current user in session
                    if (!SystemProtocols.ApplySessionsProtocols(1, null, null))
                    {
                        // Summon Reports Analytics Form
                        FormsMenuList.reportsAnalyticsForm = new ReportsAnalyticsForm();
                        FormsMenuList.reportsAnalyticsForm.Show();

                        // Disposing any open child
                        DisposeAllChildren();

                        // Closing form while freeing system resources
                        FormsMenuList.salesRecordForm.Dispose();
                    }
                    #endregion

                    break;

                case Keys.F10:

                    #region View Activities Log
                    // Identifying correct protocol for current user in session
                    if (!SystemProtocols.ApplySessionsProtocols(1, null, null))
                    {
                        // Summon Activity Logs Form
                        FormsMenuList.activitiesLogForm = new ActivitiesLogForm();
                        FormsMenuList.activitiesLogForm.Show();

                        // Disposing any open child
                        DisposeAllChildren();

                        // Closing form while freeing system resources
                        FormsMenuList.salesRecordForm.Dispose();
                    }
                    #endregion

                    break;

                case Keys.F11:

                    #region View Errors Log
                    // Identifying correct protocol for current user in session
                    if (!SystemProtocols.ApplySessionsProtocols(1, null, null))
                    {
                        // Summon Error Logs Form
                        FormsMenuList.errorsLogForm = new ErrorsLogForm();
                        FormsMenuList.errorsLogForm.Show();

                        // Disposing any open child
                        DisposeAllChildren();

                        // Closing form while freeing system resources
                        FormsMenuList.salesRecordForm.Dispose();
                    }
                    #endregion

                    break;

                case Keys.F12:

                    #region View Cart
                    // Summon View Cart Form
                    FormsMenuList.viewCartForm = new ViewCartForm();
                    FormsMenuList.viewCartForm.Show();

                    // Disposing any open child
                    DisposeAllChildren();

                    // Closing form while freeing system resources
                    FormsMenuList.salesRecordForm.Dispose();
                    #endregion

                    break;

                default:
                    break;
            }
        }
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
            if (!SystemProtocols.ApplySessionsProtocols(1, null, null)) // option only available for non basic users
            {
                if (!IsChildAlive(salesList.SelectedCells[0].Value.ToString())) // Verifying that requested child is killed or active before proceeding
                {
                    // Starting or resecusating child
                    SaleInformationTemplateForm child = new SaleInformationTemplateForm(salesList.SelectedCells[0].Value.ToString());
                    child.Show();

                    children.Add(child); // adding child to the list of children to keep track of opened auxiliary forms
                }
            }
        }
        #endregion

        #region Auxiliary Function
        /// <summary>
        /// Funtion to populate the data grid
        /// </summary>
        private void PopulateSalesDataGrid()
        {
            salesList.DataSource = SaleInformationManager.ConsultSalesRecordsInformation(salesSearchBox.Text);

            // Formating the flieds
            salesList.Columns["Id"].Width = 50;
            salesList.Columns["TransactionDate"].Width = 180;
            salesList.Columns["Delivery"].Width = 50;
            salesList.Columns["Status"].Width = 70;
            salesList.Columns["Parent"].Width = 50;
            salesList.Columns["Child"].Width = 50;
            salesList.Columns["LastModified"].Width = 180;
        }

        /// <summary>
        /// Function to dispose any opon children of this form
        /// </summary>
        private void DisposeAllChildren()
        {
            foreach (SaleInformationTemplateForm child in children)
            {
                child.DisposeOnlyChild(); // disposing of any potential grandchildren
                child.Dispose(); // disposing all the living child
            }
        }

        /// <summary>
        /// Function to allow children and grandchildren to notify this form to update its information
        /// </summary>
        public void RefreshSalesRecordsDataGrid()
        {
            PopulateSalesDataGrid();
        }

        /// <summary>
        /// Function used by grandchild to notify when a new transaction has originated from a successfull return
        /// </summary>
        /// <param name="newSaleId">Identification number of the new transaction</param>
        public void ShowNewReturnedTransactionInformation(String newSaleId)
        {
            if (!SystemProtocols.ApplySessionsProtocols(1, null, null)) // option only available for non basic users
            {
                // Creating a new child given the new information available
                SaleInformationTemplateForm child = new SaleInformationTemplateForm(newSaleId);
                child.Show();

                children.Add(child); // adding that new child to the list of living children
            }
        }

        /// <summary>
        /// Function that notifies that a child has successfully made a return so the parent 
        /// can update the current transaction's information
        /// </summary>
        public void UpdateChildAfterSuccessfulReturn(String childId)
        {
            foreach (SaleInformationTemplateForm child in children)
                if (child.Text.Split(' ')[2] == childId) // Identifying which child has updated information
                {
                    child.UpdateSelfAfterSuccessfulReturn(); // Notifying the child to update itself
                    break;
                }
        }

        /// <summary>
        /// Function to prevent the user form opening multiple forms for the same sale transaction
        /// </summary>
        /// <param name="childId"></param>
        /// <returns>True or False if the child form is active and open</returns>
        private bool IsChildAlive(String childId)
        {
            foreach (SaleInformationTemplateForm child in children)
                if (child.Text.Split(' ')[2] == childId) // Identifying which child is needed
                    if (child != null) // verifying that it has not been killed
                    {
                        // Bring focus to child if it is still alive;
                        child.Show();
                        child.Focus();

                        return true; // Confirming its activity
                    }

            return false; // Requested child is not amongst the living children 
        }

        /// <summary>
        /// Function to signify that a child was recently killed
        /// </summary>
        public void ChildWasKilled()
        {
            foreach (SaleInformationTemplateForm child in children)
                if (child != null) // Searching which child has recently been disposed of
                {
                    children.Remove(child); // remove said child from amongst the living
                    break;
                }
        }
        #endregion
    }
}
