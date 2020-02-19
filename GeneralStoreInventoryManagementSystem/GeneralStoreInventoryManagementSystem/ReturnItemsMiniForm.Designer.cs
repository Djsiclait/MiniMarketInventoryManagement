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
            this.purchasedItemsDataGridView.Location = new System.Drawing.Point(16, 29);
            this.purchasedItemsDataGridView.Name = "purchasedItemsDataGridView";
            this.purchasedItemsDataGridView.ReadOnly = true;
            this.purchasedItemsDataGridView.RowHeadersVisible = false;
            this.purchasedItemsDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.purchasedItemsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.purchasedItemsDataGridView.Size = new System.Drawing.Size(567, 253);
            this.purchasedItemsDataGridView.TabIndex = 24;
            // 
            // returnedItemsDataGridView
            // 
            this.returnedItemsDataGridView.AllowUserToAddRows = false;
            this.returnedItemsDataGridView.AllowUserToDeleteRows = false;
            this.returnedItemsDataGridView.AllowUserToResizeColumns = false;
            this.returnedItemsDataGridView.AllowUserToResizeRows = false;
            this.returnedItemsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.returnedItemsDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.returnedItemsDataGridView.Location = new System.Drawing.Point(122, 318);
            this.returnedItemsDataGridView.Name = "returnedItemsDataGridView";
            this.returnedItemsDataGridView.ReadOnly = true;
            this.returnedItemsDataGridView.RowHeadersVisible = false;
            this.returnedItemsDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.returnedItemsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.returnedItemsDataGridView.Size = new System.Drawing.Size(567, 253);
            this.returnedItemsDataGridView.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(395, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 17);
            this.label1.TabIndex = 26;
            this.label1.Text = "Items Purchased";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(118, 298);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 17);
            this.label2.TabIndex = 27;
            this.label2.Text = "Returned Items";
            // 
            // returnOneButton
            // 
            this.returnOneButton.Location = new System.Drawing.Point(589, 29);
            this.returnOneButton.Name = "returnOneButton";
            this.returnOneButton.Size = new System.Drawing.Size(100, 23);
            this.returnOneButton.TabIndex = 30;
            this.returnOneButton.Text = "Return One Unit";
            this.returnOneButton.UseVisualStyleBackColor = true;
            this.returnOneButton.Click += new System.EventHandler(this.ReturnOneButton_Click);
            // 
            // returnItemButton
            // 
            this.returnItemButton.Location = new System.Drawing.Point(589, 58);
            this.returnItemButton.Name = "returnItemButton";
            this.returnItemButton.Size = new System.Drawing.Size(100, 23);
            this.returnItemButton.TabIndex = 29;
            this.returnItemButton.Text = "Return An Item";
            this.returnItemButton.UseVisualStyleBackColor = true;
            this.returnItemButton.Click += new System.EventHandler(this.ReturnItemButton_Click);
            // 
            // removeOneButton
            // 
            this.removeOneButton.Location = new System.Drawing.Point(16, 318);
            this.removeOneButton.Name = "removeOneButton";
            this.removeOneButton.Size = new System.Drawing.Size(100, 23);
            this.removeOneButton.TabIndex = 33;
            this.removeOneButton.Text = "Remove One Unit";
            this.removeOneButton.UseVisualStyleBackColor = true;
            this.removeOneButton.Click += new System.EventHandler(this.RemoveOneButton_Click);
            // 
            // removeItemButton
            // 
            this.removeItemButton.Location = new System.Drawing.Point(16, 347);
            this.removeItemButton.Name = "removeItemButton";
            this.removeItemButton.Size = new System.Drawing.Size(100, 23);
            this.removeItemButton.TabIndex = 32;
            this.removeItemButton.Text = "Remove An Item";
            this.removeItemButton.UseVisualStyleBackColor = true;
            this.removeItemButton.Click += new System.EventHandler(this.RemoveItemButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(122, 582);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(143, 34);
            this.cancelButton.TabIndex = 35;
            this.cancelButton.Text = "Cancel Return";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // confirmButton
            // 
            this.confirmButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmButton.Location = new System.Drawing.Point(380, 582);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(143, 34);
            this.confirmButton.TabIndex = 36;
            this.confirmButton.Text = "Confirm Return";
            this.confirmButton.UseVisualStyleBackColor = true;
            // 
            // purchasedTotalLabel
            // 
            this.purchasedTotalLabel.AutoSize = true;
            this.purchasedTotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purchasedTotalLabel.Location = new System.Drawing.Point(179, 9);
            this.purchasedTotalLabel.Name = "purchasedTotalLabel";
            this.purchasedTotalLabel.Size = new System.Drawing.Size(96, 17);
            this.purchasedTotalLabel.TabIndex = 38;
            this.purchasedTotalLabel.Text = "Total: $0.00";
            // 
            // numberOfPurchasedItemsLabel
            // 
            this.numberOfPurchasedItemsLabel.AutoSize = true;
            this.numberOfPurchasedItemsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberOfPurchasedItemsLabel.Location = new System.Drawing.Point(13, 9);
            this.numberOfPurchasedItemsLabel.Name = "numberOfPurchasedItemsLabel";
            this.numberOfPurchasedItemsLabel.Size = new System.Drawing.Size(84, 17);
            this.numberOfPurchasedItemsLabel.TabIndex = 37;
            this.numberOfPurchasedItemsLabel.Text = "# of Items:";
            // 
            // returnTotalLabel
            // 
            this.returnTotalLabel.AutoSize = true;
            this.returnTotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnTotalLabel.Location = new System.Drawing.Point(469, 298);
            this.returnTotalLabel.Name = "returnTotalLabel";
            this.returnTotalLabel.Size = new System.Drawing.Size(96, 17);
            this.returnTotalLabel.TabIndex = 40;
            this.returnTotalLabel.Text = "Total: $0.00";
            // 
            // numberOfReturnsLabel
            // 
            this.numberOfReturnsLabel.AutoSize = true;
            this.numberOfReturnsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberOfReturnsLabel.Location = new System.Drawing.Point(303, 298);
            this.numberOfReturnsLabel.Name = "numberOfReturnsLabel";
            this.numberOfReturnsLabel.Size = new System.Drawing.Size(84, 17);
            this.numberOfReturnsLabel.TabIndex = 39;
            this.numberOfReturnsLabel.Text = "# of Items:";
            // 
            // ReturnItemsMiniForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 628);
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
            this.Text = "Returning Items";
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