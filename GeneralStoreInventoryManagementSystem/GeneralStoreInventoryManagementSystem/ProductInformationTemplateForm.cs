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
    public partial class ProductInformationTemplateForm : Form
    {
        Product product; // Object to store and display a products information

        public ProductInformationTemplateForm(String productId)
        {
            InitializeComponent();

            // Retreiving the information of a product with it's internal identification number
            product = InventoryManagementBusinessLayer.ConsultInformation.FetchProductInformationByID(productId);

            this.Text += " " + product.Name; // Updating the header of the current form
        }

////////// Form Load Logic 
        private void ProductInformationTemplateForm_Load(object sender, EventArgs e)
        {
            // Displaying the product's information in their respective fields
            nameTextBox.Text = product.Name;
            keyTextBox.Text = product.Key;
            brandTextBox.Text = product.Brand;
            supplierTextBox.Text = product.Supplier;
            categoryTextBox.Text = product.Category;
            typeTextBox.Text = product.Type;
            unitTextBox.Text = product.Unit;
            unitCostTextBox.Text = product.UnitCost.ToString();
            unitPriceTextBox.Text = product.UnitPrice.ToString();
            quantityTextBox.Text = product.Quantity.ToString();
            minimumQuantityTextBox.Text = product.MinimumQuantity.ToString();
            maximumQuantityTextBox.Text = product.MaximumQuantity.ToString();
            registeredByTextBox.Text = product.RegisteredBy;
            registrationDateDateTimePicker.Text = product.RegistrationDate.ToString();
            modifiedByTextBox.Text = product.ModifiedBy;
            modificationDateDateTimePicker.Text = product.ModificationDate.ToString();

            if (product.Discontinued)
                discontinuedCheckBox.CheckState = CheckState.Checked;
        }
////////// END Form Load Logic 
    }
}
