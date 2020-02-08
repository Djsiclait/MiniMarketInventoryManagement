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

        #region Form Load Logic 
        private void ProductInformationTemplateForm_Load(object sender, EventArgs e)
        {
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

            quantityNumericUpDown.Value = product.Quantity;

            minimumQuantityNumericUpDown.Value = product.MinimumQuantity;

            maximumQuantityNumericUpDown.Value = product.MaximumQuantity;

            registeredByDisplayLabel.Text = product.RegisteredBy;

            registrationDateDisplayLabel.Text = product.RegistrationDate.ToString();

            modifiedByDisplayLabel.Text = product.ModifiedBy;

            modificationDateDisplayLabel.Text = product.ModificationDate.ToString();

            if (product.Discontinued)
                discontinuedCheckBox.CheckState = CheckState.Checked;

            if (SystemProtocols.ApplySessionsProtocols())
            {
                keyTextBox.Enabled = false;
                unitTextBox.Enabled = false;
                unitCostNumericUpDown.Enabled = false;
                unitPriceNumericUpDown.Enabled = false;
                quantityNumericUpDown.Enabled = false;
                minimumQuantityNumericUpDown.Enabled = false;
                maximumQuantityNumericUpDown.Enabled = false;

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
                quantityNumericUpDown.Enabled = true;
                minimumQuantityNumericUpDown.Enabled = true;
                maximumQuantityNumericUpDown.Enabled = true;

                brandComboBox.Enabled = true;
                supplierComboBox.Enabled = true;
                categoryComboBox.Enabled = true;
                typeComboBox.Enabled = true;

                discontinuedCheckBox.Enabled = true;

                editButton.Enabled = false;
            }
        }
        #endregion

        #region Text Changed Logic
        private void KeyTextBox_TextChanged(object sender, EventArgs e)
        {
            editButton.Enabled = !string.IsNullOrWhiteSpace(keyTextBox.Text);
        }

        private void UnitTextBox_TextChanged(object sender, EventArgs e)
        {
            editButton.Enabled = !string.IsNullOrWhiteSpace(unitTextBox.Text);
        }
        #endregion

        #region Index Changed Logic
        private void BrandComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            editButton.Enabled = true;
        }

        private void SupplierComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            editButton.Enabled = true;
        }

        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            editButton.Enabled = true;
        }

        private void TypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            editButton.Enabled = true;
        }
        #endregion

        #region Value Changed Logic
        private void UnitCostNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            editButton.Enabled = true;
            unitContributionMarginLabel.Text = CalculateUnitContributionMargin();
        }

        private void UnitPriceNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            editButton.Enabled = true;
            unitContributionMarginLabel.Text = CalculateUnitContributionMargin();

            if (unitPriceNumericUpDown.Value > unitCostNumericUpDown.Value)
                unitContributionMarginLabel.ForeColor = Color.Green;
            else if (unitPriceNumericUpDown.Value < unitCostNumericUpDown.Value)
                unitContributionMarginLabel.ForeColor = Color.Red;
            else
                unitContributionMarginLabel.ForeColor = Color.Black;
        }

        private void DiscontinuedCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            editButton.Enabled = true;
        }

        private void QuantityNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            editButton.Enabled = true;
        }

        private void MinimumQuantityNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            editButton.Enabled = true;
            maximumQuantityNumericUpDown.Minimum = minimumQuantityNumericUpDown.Value + 1;
        }

        private void MaximumQuantityNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            editButton.Enabled = true;
        }
        #endregion

        #region Mouse Hover and Leave
        private void UnitContributionMarginLabel_MouseHover(object sender, EventArgs e)
        {
            unitContributionMarginLabel.Text = "This is the unit contribution cost.";
        }

        private void UnitContributionMarginLabel_MouseLeave(object sender, EventArgs e)
        {
            unitContributionMarginLabel.Text = CalculateUnitContributionMargin();
        }
        #endregion

        #region Auxiliary Functions
        /// <summary>
        /// Function that calculates the unit contribution margin ratio of the product using the unit cost and price
        /// UPM = (UP - UC) / UP * 100
        /// </summary>
        /// <returns>The string result of the formula</returns>
        private String CalculateUnitContributionMargin()
        {
            // Applying unitary profit margin formula
            decimal contributionRatio = ((unitPriceNumericUpDown.Value - unitCostNumericUpDown.Value) / unitPriceNumericUpDown.Value) * 100;

            decimal contributionDollar = unitPriceNumericUpDown.Value - unitCostNumericUpDown.Value;

            decimal priceIncrease = unitPriceNumericUpDown.Value / unitCostNumericUpDown.Value;

            return contributionRatio.ToString("0.##") + "% ($" + contributionDollar.ToString("0.##") + " or " + (priceIncrease.ToString("0.##") == "1" ? "1" : priceIncrease.ToString("0.##")) + "x price increase)";
        }
        #endregion
    }
}
