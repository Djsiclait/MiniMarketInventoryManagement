namespace GeneralStoreInventoryManagementSystem
{
    partial class ReturnItemsMiniForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReturnItemsMiniForm));
            this.purchasedItemsDataGridView = new System.Windows.Forms.DataGridView();
            this.returnedItemsDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.returnOneButton = new System.Windows.Forms.Button();
            this.returnItemButton = new System.Windows.Forms.Button();
            this.removeOneButton = new System.Windows.Forms.Button();
            this.removeItemButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.confirmButton = new System.Windows.Forms.Button();
            this.purchasedTotalLabel = new System.Windows.Forms.Label();
            this.numberOfPurchasedItemsLabel = new System.Windows.Forms.Label();
            this.returnTotalLabel = new System.Windows.Forms.Label();
            this.numberOfReturnsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.purchasedItemsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnedItemsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // purchasedItemsDataGridView
            // 
            this.purchasedItemsDataGridView.AllowUserToAddRows = false;
            this.purchasedItemsDataGridView.AllowUserToDeleteRows = false;
            this.purchasedItemsDataGridView.AllowUserToResizeColumns = false;
            this.purchasedItemsDataGridView.AllowUserToResizeRows = false;
            this.purchasedItemsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.purchasedItemsDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            resources.ApplyResources(this.purchasedItemsDataGridView, "purchasedItemsDataGridView");
            this.purchasedItemsDataGridView.Name = "purchasedItemsDataGridView";
            this.purchasedItemsDataGridView.ReadOnly = true;
            this.purchasedItemsDataGridView.RowHeadersVisible = false;
            this.purchasedItemsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // returnedItemsDataGridView
            // 
            this.returnedItemsDataGridView.AllowUserToAddRows = false;
            this.returnedItemsDataGridView.AllowUserToDeleteRows = false;
            this.returnedItemsDataGridView.AllowUserToResizeColumns = false;
            this.returnedItemsDataGridView.AllowUserToResizeRows = false;
            this.returnedItemsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.returnedItemsDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            resources.ApplyResources(this.returnedItemsDataGridView, "returnedItemsDataGridView");
            this.returnedItemsDataGridView.Name = "returnedItemsDataGridView";
            this.returnedItemsDataGridView.ReadOnly = true;
            this.returnedItemsDataGridView.RowHeadersVisible = false;
            this.returnedItemsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // returnOneButton
            // 
            resources.ApplyResources(this.returnOneButton, "returnOneButton");
            this.returnOneButton.Name = "returnOneButton";
            this.returnOneButton.UseVisualStyleBackColor = true;
            this.returnOneButton.Click += new System.EventHandler(this.ReturnOneButton_Click);
            // 
            // returnItemButton
            // 
            resources.ApplyResources(this.returnItemButton, "returnItemButton");
            this.returnItemButton.Name = "returnItemButton";
            this.returnItemButton.UseVisualStyleBackColor = true;
            this.returnItemButton.Click += new System.EventHandler(this.ReturnItemButton_Click);
            // 
            // removeOneButton
            // 
            resources.ApplyResources(this.removeOneButton, "removeOneButton");
            this.removeOneButton.Name = "removeOneButton";
            this.removeOneButton.UseVisualStyleBackColor = true;
            this.removeOneButton.Click += new System.EventHandler(this.RemoveOneButton_Click);
            // 
            // removeItemButton
            // 
            resources.ApplyResources(this.removeItemButton, "removeItemButton");
            this.removeItemButton.Name = "removeItemButton";
            this.removeItemButton.UseVisualStyleBackColor = true;
            this.removeItemButton.Click += new System.EventHandler(this.RemoveItemButton_Click);
            // 
            // cancelButton
            // 
            resources.ApplyResources(this.cancelButton, "cancelButton");
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // confirmButton
            // 
            resources.ApplyResources(this.confirmButton, "confirmButton");
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // purchasedTotalLabel
            // 
            resources.ApplyResources(this.purchasedTotalLabel, "purchasedTotalLabel");
            this.purchasedTotalLabel.Name = "purchasedTotalLabel";
            // 
            // numberOfPurchasedItemsLabel
            // 
            resources.ApplyResources(this.numberOfPurchasedItemsLabel, "numberOfPurchasedItemsLabel");
            this.numberOfPurchasedItemsLabel.Name = "numberOfPurchasedItemsLabel";
            // 
            // returnTotalLabel
            // 
            resources.ApplyResources(this.returnTotalLabel, "returnTotalLabel");
            this.returnTotalLabel.Name = "returnTotalLabel";
            // 
            // numberOfReturnsLabel
            // 
            resources.ApplyResources(this.numberOfReturnsLabel, "numberOfReturnsLabel");
            this.numberOfReturnsLabel.Name = "numberOfReturnsLabel";
            // 
            // ReturnItemsMiniForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.returnTotalLabel);
            this.Controls.Add(this.numberOfReturnsLabel);
            this.Controls.Add(this.purchasedTotalLabel);
            this.Controls.Add(this.numberOfPurchasedItemsLabel);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.removeOneButton);
            this.Controls.Add(this.removeItemButton);
            this.Controls.Add(this.returnOneButton);
            this.Controls.Add(this.returnItemButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.returnedItemsDataGridView);
            this.Controls.Add(this.purchasedItemsDataGridView);
            this.MaximizeBox = false;
            this.Name = "ReturnItemsMiniForm";
            this.Load += new System.EventHandler(this.ReturnItemsMiniForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.purchasedItemsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnedItemsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView purchasedItemsDataGridView;
        private System.Windows.Forms.DataGridView returnedItemsDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button returnOneButton;
        private System.Windows.Forms.Button returnItemButton;
        private System.Windows.Forms.Button removeOneButton;
        private System.Windows.Forms.Button removeItemButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Label purchasedTotalLabel;
        private System.Windows.Forms.Label numberOfPurchasedItemsLabel;
        private System.Windows.Forms.Label returnTotalLabel;
        private System.Windows.Forms.Label numberOfReturnsLabel;
    }
}