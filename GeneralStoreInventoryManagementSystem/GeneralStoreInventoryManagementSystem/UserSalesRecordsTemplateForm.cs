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
using InventoryManagementBusinessLayer.UserInformation;
using InventoryManagementEntityLayer.UserProfile;

namespace GeneralStoreInventoryManagementSystem
{
    public partial class UserSalesRecordsTemplateForm : Form
    {
        readonly UserProfile user;

        public UserSalesRecordsTemplateForm(String username)
        {
            InitializeComponent();

            user = UserInformationManager.ConsultUserInformationByUsername(username);
        }

        #region On Form Load Logic
        private void UserSalesRecordsTemplateForm_Load(object sender, EventArgs e)
        {
            usernameLabel.Text = user.Username;
            roleLabel.Text = user.Role;
        }
        #endregion
    }
}
