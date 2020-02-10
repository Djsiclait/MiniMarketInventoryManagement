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
            DisplayProductInformation();

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
            unitTextBox.BackColor = Color.White;
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
            categoryComboBox.BackColor = Color.White;
        }

        private void TypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            editButton.Enabled = true;
            typeComboBox.BackColor = Color.White;
        }
        #endregion

        #region Value Changed Logic
        private void UnitCostNumericUpDown_ValueChanged(object sender, EventArgs e)
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

        #region Button Click Logic
        private void EditButton_Click(object sender, EventArgs e)
        {
            if (ValidateUserInput()) // Validating user inputs are correct
            {
                if (ConfirmInformationChange()) // confirming the user has made changes to the product to avoid unnecessary processes
                {
                    // TODO: EDIT product
                }
                else
                    MessageBox.Show("No changes have been made. Please check desired values.");
            }
            else
                MessageBox.Show("Please fill required values correctly.");
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

        /// <summary>
        /// Funtion to validate user input according to accepted formats and standards
        /// </summary>
        /// <returns>True or False based on the validation check</returns>
        private bool ValidateUserInput()
        {
            bool validated = true;

            if (unitTextBox.Text != product.Unit && unitTextBox.Text == "")
            {
                validated = false;
                unitTextBox.BackColor = Color.Red;
            }

            if (categoryComboBox.Text == "")
            {
                validated = false;
                categoryComboBox.BackColor = Color.Red;
            }

            if (typeComboBox.Text == "")
            {
                validated = false;
                typeComboBox.BackColor = Color.Red;
            }

            return validated;
        }

        /// <summary>
        /// Function dedicated to fill the correct fields with their corresponding information
        /// </summary>
        private void DisplayProductInformation()
        {
            // Filling text boxes
            keyTextBox.Text = product.Key;
            unitTextBox.Text = product.Unit;
            registeredByDisplayLabel.Text = product.RegisteredBy;
            modifiedByDisplayLabel.Text = product.ModifiedBy;

            // Filling combo boxes
            brandComboBox.DataSource = ConsultInformation.FetchBrandListInformation(""); Console.WriteLine("\n\n\nYOLO: " + product.Brand);
            brandComboBox.Text = product.Brand == "" ? "<None>" : product.Brand;

            supplierComboBox.DataSource = ConsultInformation.FetchSupplierListInformation("");
            supplierComboBox.Text = product.Supplier == "" ? "<None>" : product.Supplier;

            categoryComboBox.DataSource = ConsultInformation.FetchCategoryComboBoxInformation();
            categoryComboBox.Text = product.Category;

            typeComboBox.DataSource = ConsultInformation.FetchTypeComboBoxInformation();
            typeComboBox.Text = product.Type;

            // Filling numeric up downs
            unitCostNumericUpDown.Value = product.UnitCost;
            unitPriceNumericUpDown.Value = product.UnitPrice;
            quantityNumericUpDown.Value = product.Quantity;
            minimumQuantityNumericUpDown.Value = product.MinimumQuantity;
            maximumQuantityNumericUpDown.Value = product.MaximumQuantity;

            // Filling labels
            nameDisplayLabel.Text = product.Name;
            registrationDateDisplayLabel.Text = product.RegistrationDate.ToString();
            modificationDateDisplayLabel.Text = product.ModificationDate.ToString();

            // Filling check box
            if (product.Discontinued)
                discontinuedCheckBox.CheckState = CheckState.Checked;
        }

        /// <summary>
        /// Function that detects any change of information 
        /// </summary>
        /// <returns>True or False if any changes were detected</returns>
        private bool ConfirmInformationChange()
        {
            bool changes = false;

            if (keyTextBox.Text != product.Key)
            {
                product.Key = keyTextBox.Text;
                changes = true;
            }

            if (brandComboBox.Text == "<None>" && product.Brand != "") // User selected None but the product had a brand
            {
                product.Brand = brandComboBox.Text;
                changes = true;
            }
            else if (brandComboBox.Text == "" && product.Brand != "") // User selected nothing but the product had a brand
            {
                product.Brand = "<None>";
                changes = true;
            }
            else if (brandComboBox.Text != "<None>" && brandComboBox.Text != "" && brandComboBox.Text != product.Brand) // User selected something new regardless if the product had a brand
            {
                product.Brand = brandComboBox.Text;
                changes = true;
            }

            if (supplierComboBox.Text == "<None>" && product.Supplier != "") // User selected None but the product had a supplier
            {
                product.Supplier = supplierComboBox.Text;
                changes = true;
            }
            else if (supplierComboBox.Text == "" && product.Supplier != "") // User selected nothing but the product had a supplier
            {
                product.Supplier = "<None>";
                changes = true;
            }
            else if (supplierComboBox.Text != "<None>" && supplierComboBox.Text != "" && supplierComboBox.Text != product.Supplier) // User selected something new regardless if the product had a supplier
            {
                product.Supplier = supplierComboBox.Text;
                changes = true;
            }

            if (categoryComboBox.Text != product.Category)
            {
                product.Category = categoryComboBox.Text;
                changes = true;
            }

            if (typeComboBox.Text != product.Type)
            {
                product.Type = typeComboBox.Text;
                changes = true;
            }

            if (unitTextBox.Text != product.Unit)
            {
                product.Unit = unitTextBox.Text;
                changes = true;
            }

            if (unitCostNumericUpDown.Value != product.UnitCost)
            {
                product.UnitCost = unitCostNumericUpDown.Value;
                changes = true;
            }

            if (unitPriceNumericUpDown.Value != product.UnitPrice)
            {
                product.UnitPrice = unitPriceNumericUpDown.Value;
                changes = true;
            }

            if (quantityNumericUpDown.Value != product.Quantity)
            {
                product.Quantity = (int)quantityNumericUpDown.Value; // TODO: change database structure to consider fractions and halves i.e.: 0.5lbs of cheese
                changes = true;
            }

            if (minimumQuantityNumericUpDown.Value != product.MinimumQuantity)
            {
                product.MinimumQuantity = (int)minimumQuantityNumericUpDown.Value; // TODO: change database structure to consider fractions and halves i.e.: 0.5lbs of cheese
                changes = true;
            }

            if (maximumQuantityNumericUpDown.Value != product.MaximumQuantity)
            {
                product.MaximumQuantity = (int)maximumQuantityNumericUpDown.Value; // TODO: change database structure to consider fractions and halves i.e.: 0.5lbs of cheese
                changes = true;
            }

            if (discontinuedCheckBox.Checked != product.Discontinued)
            {
                product.Discontinued = discontinuedCheckBox.Checked;
                changes = true;
            }

            return changes;
        }
        #endregion
    }
}
