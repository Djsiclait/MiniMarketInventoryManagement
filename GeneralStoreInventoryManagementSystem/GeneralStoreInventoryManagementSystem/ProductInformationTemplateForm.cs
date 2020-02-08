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
            product = ConsultInformation.FetchProductInformationByID(productId);

            this.Text += " " + product.Name; // Updating the header of the current form
        }

////////// Form Load Logic 
        private void ProductInformationTemplateForm_Load(object sender, EventArgs e)
        {
            if (SystemProtocols.ApplySessionsProtocols())
            {
                keyTextBox.Enabled = false;
                unitTextBox.Enabled = false;
                unitCostNumericUpDown.Enabled = false;
                unitPriceNumericUpDown.Enabled = false;
                quantityTextBox.Enabled = false;
                minimumQuantityTextBox.Enabled = false;
                maximumQuantityTextBox.Enabled = false;

                brandComboBox.Enabled = false;
                supplierComboBox.Enabled = false;
                categoryComboBox.Enabled = false;
                typeComboBox.Enabled = false;

                discontinuedCheckBox.Enabled = false;

                editButton.Enabled = false;
                editButton.Visible = false;
            }
            else
            {
                keyTextBox.Enabled = true;
                unitTextBox.Enabled = true;
                unitCostNumericUpDown.Enabled = true;
                unitPriceNumericUpDown.Enabled = true;
                quantityTextBox.Enabled = true;
                minimumQuantityTextBox.Enabled = true;
                maximumQuantityTextBox.Enabled = true;

                brandComboBox.Enabled = true;
                supplierComboBox.Enabled = true;
                categoryComboBox.Enabled = true;
                typeComboBox.Enabled = true;

                discontinuedCheckBox.Enabled = true;

                editButton.Enabled = false;
                editButton.Visible = false;
            }

            // Displaying the product's information in their respective fields
            nameDisplayLabel.Text = product.Name;

            keyTextBox.Text = product.Key;

            brandComboBox.DataSource = ConsultInformation.FetchBrandListInformation("");Console.WriteLine("\n\n\nYOLO: " + product.Brand);
            brandComboBox.Text = product.Brand == "" ? "<None>" : product.Brand;

            supplierComboBox.DataSource = ConsultInformation.FetchSupplierListInformation("");
            supplierComboBox.Text = product.Supplier == "" ? "<None>" : product.Supplier;

            categoryComboBox.DataSource = ConsultInformation.FetchCategoryComboBoxInformation();
            categoryComboBox.Text = product.Category;

            typeComboBox.DataSource = ConsultInformation.FetchTypeComboBoxInformation();
            typeComboBox.Text = product.Type;

            unitTextBox.Text = product.Unit;

            unitCostNumericUpDown.Value = product.UnitCost;

            unitPriceNumericUpDown.Value = product.UnitPrice;

            quantityTextBox.Text = product.Quantity.ToString();

            minimumQuantityTextBox.Text = product.MinimumQuantity.ToString();

            maximumQuantityTextBox.Text = product.MaximumQuantity.ToString();

            registeredByDisplayLabel.Text = product.RegisteredBy;

            registrationDateDisplayLabel.Text = product.RegistrationDate.ToString();

            modifiedByDisplayLabel.Text = product.ModifiedBy;

            modificationDateDisplayLabel.Text = product.ModificationDate.ToString();

            if (product.Discontinued)
                discontinuedCheckBox.CheckState = CheckState.Checked;
        }
////////// END Form Load Logic 

        // Text Changed Logic
        private void KeyTextBox_TextChanged(object sender, EventArgs e)
        {
            editButton.Enabled = !string.IsNullOrWhiteSpace(keyTextBox.Text);
            editButton.Visible = true;
        }

        private void UnitTextBox_TextChanged(object sender, EventArgs e)
        {
            editButton.Enabled = !string.IsNullOrWhiteSpace(unitTextBox.Text);
            editButton.Visible = true;
        }

        private void QuantityTextBox_TextChanged(object sender, EventArgs e)
        {
            editButton.Enabled = !string.IsNullOrWhiteSpace(quantityTextBox.Text);
            editButton.Visible = true;
        }

        private void MinimumQuantityTextBox_TextChanged(object sender, EventArgs e)
        {
            editButton.Enabled = !string.IsNullOrWhiteSpace(minimumQuantityTextBox.Text);
            editButton.Visible = true;
        }

        private void MaximumQuantityTextBox_TextChanged(object sender, EventArgs e)
        {
            editButton.Enabled = !string.IsNullOrWhiteSpace(maximumQuantityTextBox.Text);
            editButton.Visible = true;
        }
        // END Text Changed Logic

        // Index Changed Logic
        private void BrandComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            editButton.Enabled = true;
            editButton.Visible = true;
        }

        private void SupplierComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            editButton.Enabled = true;
            editButton.Visible = true;
        }

        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            editButton.Enabled = true;
            editButton.Visible = true;
        }

        private void TypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            editButton.Enabled = true;
            editButton.Visible = true;
        }
        // END Index Changed Logic

        // Value Changed Logic
        private void UnitCostNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            editButton.Enabled = true;
            editButton.Visible = true;
        }

        private void UnitPriceNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            editButton.Enabled = true;
            editButton.Visible = true;
        }

        private void discontinuedCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            editButton.Enabled = true;
            editButton.Visible = true;
        }
        // END Value Changed Logic
    }
}
