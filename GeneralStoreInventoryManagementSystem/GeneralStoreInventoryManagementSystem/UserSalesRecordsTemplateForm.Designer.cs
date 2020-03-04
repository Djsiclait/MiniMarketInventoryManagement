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
            this.printEntireButton.Location = new System.Drawing.Point(409, 440);
            this.printEntireButton.Name = "printEntireButton";
            this.printEntireButton.Size = new System.Drawing.Size(136, 23);
            this.printEntireButton.TabIndex = 31;
            this.printEntireButton.Text = "Print Entire Set ";
            this.printEntireButton.UseVisualStyleBackColor = true;
            // 
            // printCurrentButton
            // 
            this.printCurrentButton.Location = new System.Drawing.Point(551, 440);
            this.printCurrentButton.Name = "printCurrentButton";
            this.printCurrentButton.Size = new System.Drawing.Size(136, 23);
            this.printCurrentButton.TabIndex = 30;
            this.printCurrentButton.Text = "Print Current Set ";
            this.printCurrentButton.UseVisualStyleBackColor = true;
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.Location = new System.Drawing.Point(15, 420);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(51, 13);
            this.totalLabel.TabIndex = 29;
            this.totalLabel.Text = "Total: $";
            // 
            // salesContentDataGridView
            // 
            this.salesContentDataGridView.AllowUserToAddRows = false;
            this.salesContentDataGridView.AllowUserToDeleteRows = false;
            this.salesContentDataGridView.AllowUserToResizeColumns = false;
            this.salesContentDataGridView.AllowUserToResizeRows = false;
            this.salesContentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.salesContentDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.salesContentDataGridView.Location = new System.Drawing.Point(15, 238);
            this.salesContentDataGridView.MultiSelect = false;
            this.salesContentDataGridView.Name = "salesContentDataGridView";
            this.salesContentDataGridView.ReadOnly = true;
            this.salesContentDataGridView.RowHeadersVisible = false;
            this.salesContentDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.salesContentDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.salesContentDataGridView.Size = new System.Drawing.Size(672, 179);
            this.salesContentDataGridView.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(337, 17);
            this.label5.TabIndex = 27;
            this.label5.Text = "Activities Completed During Selected Session";
            // 
            // salesDataGridView
            // 
            this.salesDataGridView.AllowUserToAddRows = false;
            this.salesDataGridView.AllowUserToDeleteRows = false;
            this.salesDataGridView.AllowUserToResizeColumns = false;
            this.salesDataGridView.AllowUserToResizeRows = false;
            this.salesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.salesDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.salesDataGridView.Location = new System.Drawing.Point(195, 47);
            this.salesDataGridView.MultiSelect = false;
            this.salesDataGridView.Name = "salesDataGridView";
            this.salesDataGridView.ReadOnly = true;
            this.salesDataGridView.RowHeadersVisible = false;
            this.salesDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.salesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.salesDataGridView.Size = new System.Drawing.Size(492, 154);
            this.salesDataGridView.TabIndex = 26;
            this.salesDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SalesDataGridView_CellClick);
            this.salesDataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SalesDataGridView_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(444, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Up to:";
            // 
            // newestDateTimePicker
            // 
            this.newestDateTimePicker.Location = new System.Drawing.Point(487, 21);
            this.newestDateTimePicker.Name = "newestDateTimePicker";
            this.newestDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.newestDateTimePicker.TabIndex = 24;
            this.newestDateTimePicker.ValueChanged += new System.EventHandler(this.NewestDateTimePicker_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(192, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Starting From:";
            // 
            // oldestDateTimePicker
            // 
            this.oldestDateTimePicker.Location = new System.Drawing.Point(235, 21);
            this.oldestDateTimePicker.Name = "oldestDateTimePicker";
            this.oldestDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.oldestDateTimePicker.TabIndex = 22;
            this.oldestDateTimePicker.ValueChanged += new System.EventHandler(this.OldestDateTimePicker_ValueChanged);
            // 
            // roleLabel
            // 
            this.roleLabel.AutoSize = true;
            this.roleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roleLabel.Location = new System.Drawing.Point(40, 142);
            this.roleLabel.Name = "roleLabel";
            this.roleLabel.Size = new System.Drawing.Size(46, 17);
            this.roleLabel.TabIndex = 21;
            this.roleLabel.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "Access Level:";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.Location = new System.Drawing.Point(40, 84);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(46, 17);
            this.usernameLabel.TabIndex = 19;
            this.usernameLabel.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Username: ";
            // 
            // UserSalesRecordsTemplateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 481);
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
            this.MinimumSize = new System.Drawing.Size(719, 520);
            this.Name = "UserSalesRecordsTemplateForm";
            this.Text = "User\'s Sales Record";
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