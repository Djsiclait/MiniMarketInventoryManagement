namespace GeneralStoreInventoryManagementSystem
{
    partial class UserSalesRecordsTemplateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserSalesRecordsTemplateForm));
            this.printEntireButton = new System.Windows.Forms.Button();
            this.printCurrentButton = new System.Windows.Forms.Button();
            this.totalLabel = new System.Windows.Forms.Label();
            this.salesContentDataGridView = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.salesDataGridView = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.newestDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.oldestDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.roleLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.salesContentDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // printEntireButton
            // 
            resources.ApplyResources(this.printEntireButton, "printEntireButton");
            this.printEntireButton.Name = "printEntireButton";
            this.printEntireButton.UseVisualStyleBackColor = true;
            // 
            // printCurrentButton
            // 
            resources.ApplyResources(this.printCurrentButton, "printCurrentButton");
            this.printCurrentButton.Name = "printCurrentButton";
            this.printCurrentButton.UseVisualStyleBackColor = true;
            // 
            // totalLabel
            // 
            resources.ApplyResources(this.totalLabel, "totalLabel");
            this.totalLabel.Name = "totalLabel";
            // 
            // salesContentDataGridView
            // 
            resources.ApplyResources(this.salesContentDataGridView, "salesContentDataGridView");
            this.salesContentDataGridView.AllowUserToAddRows = false;
            this.salesContentDataGridView.AllowUserToDeleteRows = false;
            this.salesContentDataGridView.AllowUserToResizeColumns = false;
            this.salesContentDataGridView.AllowUserToResizeRows = false;
            this.salesContentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.salesContentDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.salesContentDataGridView.MultiSelect = false;
            this.salesContentDataGridView.Name = "salesContentDataGridView";
            this.salesContentDataGridView.ReadOnly = true;
            this.salesContentDataGridView.RowHeadersVisible = false;
            this.salesContentDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // salesDataGridView
            // 
            resources.ApplyResources(this.salesDataGridView, "salesDataGridView");
            this.salesDataGridView.AllowUserToAddRows = false;
            this.salesDataGridView.AllowUserToDeleteRows = false;
            this.salesDataGridView.AllowUserToResizeColumns = false;
            this.salesDataGridView.AllowUserToResizeRows = false;
            this.salesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.salesDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.salesDataGridView.MultiSelect = false;
            this.salesDataGridView.Name = "salesDataGridView";
            this.salesDataGridView.ReadOnly = true;
            this.salesDataGridView.RowHeadersVisible = false;
            this.salesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.salesDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SalesDataGridView_CellClick);
            this.salesDataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SalesDataGridView_KeyDown);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // newestDateTimePicker
            // 
            resources.ApplyResources(this.newestDateTimePicker, "newestDateTimePicker");
            this.newestDateTimePicker.Name = "newestDateTimePicker";
            this.newestDateTimePicker.ValueChanged += new System.EventHandler(this.NewestDateTimePicker_ValueChanged);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // oldestDateTimePicker
            // 
            resources.ApplyResources(this.oldestDateTimePicker, "oldestDateTimePicker");
            this.oldestDateTimePicker.Name = "oldestDateTimePicker";
            this.oldestDateTimePicker.ValueChanged += new System.EventHandler(this.OldestDateTimePicker_ValueChanged);
            // 
            // roleLabel
            // 
            resources.ApplyResources(this.roleLabel, "roleLabel");
            this.roleLabel.Name = "roleLabel";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // usernameLabel
            // 
            resources.ApplyResources(this.usernameLabel, "usernameLabel");
            this.usernameLabel.Name = "usernameLabel";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // UserSalesRecordsTemplateForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.printEntireButton);
            this.Controls.Add(this.printCurrentButton);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.salesContentDataGridView);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.salesDataGridView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.newestDateTimePicker);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.oldestDateTimePicker);
            this.Controls.Add(this.roleLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "UserSalesRecordsTemplateForm";
            this.Load += new System.EventHandler(this.UserSalesRecordsTemplateForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.salesContentDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button printEntireButton;
        private System.Windows.Forms.Button printCurrentButton;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.DataGridView salesContentDataGridView;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView salesDataGridView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker newestDateTimePicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker oldestDateTimePicker;
        private System.Windows.Forms.Label roleLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label label1;
    }
}