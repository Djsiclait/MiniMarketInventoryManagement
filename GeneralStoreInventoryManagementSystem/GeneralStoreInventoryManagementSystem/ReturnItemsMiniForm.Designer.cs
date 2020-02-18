﻿namespace GeneralStoreInventoryManagementSystem
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
            this.returnAllButton = new System.Windows.Forms.Button();
            this.returnOneButton = new System.Windows.Forms.Button();
            this.returnItemButton = new System.Windows.Forms.Button();
            this.removeAllButton = new System.Windows.Forms.Button();
            this.removeOneButton = new System.Windows.Forms.Button();
            this.removeItemButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.confirmButton = new System.Windows.Forms.Button();
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
            this.purchasedItemsDataGridView.Size = new System.Drawing.Size(507, 253);
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
            this.returnedItemsDataGridView.Size = new System.Drawing.Size(507, 253);
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
            // returnAllButton
            // 
            this.returnAllButton.Location = new System.Drawing.Point(529, 87);
            this.returnAllButton.Name = "returnAllButton";
            this.returnAllButton.Size = new System.Drawing.Size(100, 23);
            this.returnAllButton.TabIndex = 31;
            this.returnAllButton.Text = "Return All";
            this.returnAllButton.UseVisualStyleBackColor = true;
            // 
            // returnOneButton
            // 
            this.returnOneButton.Location = new System.Drawing.Point(529, 29);
            this.returnOneButton.Name = "returnOneButton";
            this.returnOneButton.Size = new System.Drawing.Size(100, 23);
            this.returnOneButton.TabIndex = 30;
            this.returnOneButton.Text = "Return One Unit";
            this.returnOneButton.UseVisualStyleBackColor = true;
            // 
            // returnItemButton
            // 
            this.returnItemButton.Location = new System.Drawing.Point(529, 58);
            this.returnItemButton.Name = "returnItemButton";
            this.returnItemButton.Size = new System.Drawing.Size(100, 23);
            this.returnItemButton.TabIndex = 29;
            this.returnItemButton.Text = "Return An Item";
            this.returnItemButton.UseVisualStyleBackColor = true;
            // 
            // removeAllButton
            // 
            this.removeAllButton.Location = new System.Drawing.Point(16, 376);
            this.removeAllButton.Name = "removeAllButton";
            this.removeAllButton.Size = new System.Drawing.Size(100, 23);
            this.removeAllButton.TabIndex = 34;
            this.removeAllButton.Text = "Remove All";
            this.removeAllButton.UseVisualStyleBackColor = true;
            // 
            // removeOneButton
            // 
            this.removeOneButton.Location = new System.Drawing.Point(16, 318);
            this.removeOneButton.Name = "removeOneButton";
            this.removeOneButton.Size = new System.Drawing.Size(100, 23);
            this.removeOneButton.TabIndex = 33;
            this.removeOneButton.Text = "Remove One Unit";
            this.removeOneButton.UseVisualStyleBackColor = true;
            // 
            // removeItemButton
            // 
            this.removeItemButton.Location = new System.Drawing.Point(16, 347);
            this.removeItemButton.Name = "removeItemButton";
            this.removeItemButton.Size = new System.Drawing.Size(100, 23);
            this.removeItemButton.TabIndex = 32;
            this.removeItemButton.Text = "Remove An Item";
            this.removeItemButton.UseVisualStyleBackColor = true;
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
            // ReturnItemsMiniForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 628);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.removeAllButton);
            this.Controls.Add(this.removeOneButton);
            this.Controls.Add(this.removeItemButton);
            this.Controls.Add(this.returnAllButton);
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
        private System.Windows.Forms.Button returnAllButton;
        private System.Windows.Forms.Button returnOneButton;
        private System.Windows.Forms.Button returnItemButton;
        private System.Windows.Forms.Button removeAllButton;
        private System.Windows.Forms.Button removeOneButton;
        private System.Windows.Forms.Button removeItemButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button confirmButton;
    }
}