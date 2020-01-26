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
        Product product; 

        public ProductInformationTemplateForm(String productId)
        {
            InitializeComponent();

        }

        private void ProductInformationTemplateForm_Load(object sender, EventArgs e)
        {

        }
    }
}
