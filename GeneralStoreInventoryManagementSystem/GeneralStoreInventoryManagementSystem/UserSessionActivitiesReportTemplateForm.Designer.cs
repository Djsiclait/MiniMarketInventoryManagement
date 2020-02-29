namespace GeneralStoreInventoryManagementSystem
{
    partial class UserSessionActivitiesReportTemplateForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.roleLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.newestDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.oldestDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.sessionsDataGridView = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.activitiesDataGridView = new System.Windows.Forms.DataGridView();
            this.totalLabel = new System.Windows.Forms.Label();
            this.errorsLabel = new System.Windows.Forms.Label();
            this.salesLabel = new System.Windows.Forms.Label();
            this.printCurrentButton = new System.Windows.Forms.Button();
            this.printEntireButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sessionsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.activitiesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username: ";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.Location = new System.Drawing.Point(40, 90);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(46, 17);
            this.usernameLabel.TabIndex = 1;
            this.usernameLabel.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Access Level:";
            // 
            // roleLabel
            // 
            this.roleLabel.AutoSize = true;
            this.roleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roleLabel.Location = new System.Drawing.Point(40, 148);
            this.roleLabel.Name = "roleLabel";
            this.roleLabel.Size = new System.Drawing.Size(46, 17);
            this.roleLabel.TabIndex = 3;
            this.roleLabel.Text = "label3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(444, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Up to:";
            // 
            // newestDateTimePicker
            // 
            this.newestDateTimePicker.Location = new System.Drawing.Point(487, 27);
            this.newestDateTimePicker.Name = "newestDateTimePicker";
            this.newestDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.newestDateTimePicker.TabIndex = 8;
            this.newestDateTimePicker.ValueChanged += new System.EventHandler(this.NewestDateTimePicker_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(192, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Starting From:";
            // 
            // oldestDateTimePicker
            // 
            this.oldestDateTimePicker.Location = new System.Drawing.Point(235, 27);
            this.oldestDateTimePicker.Name = "oldestDateTimePicker";
            this.oldestDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.oldestDateTimePicker.TabIndex = 6;
            this.oldestDateTimePicker.ValueChanged += new System.EventHandler(this.OldestDateTimePicker_ValueChanged);
            // 
            // sessionsDataGridView
            // 
            this.sessionsDataGridView.AllowUserToAddRows = false;
            this.sessionsDataGridView.AllowUserToDeleteRows = false;
            this.sessionsDataGridView.AllowUserToResizeColumns = false;
            this.sessionsDataGridView.AllowUserToResizeRows = false;
            this.sessionsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sessionsDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.sessionsDataGridView.Location = new System.Drawing.Point(195, 53);
            this.sessionsDataGridView.MultiSelect = false;
            this.sessionsDataGridView.Name = "sessionsDataGridView";
            this.sessionsDataGridView.ReadOnly = true;
            this.sessionsDataGridView.RowHeadersVisible = false;
            this.sessionsDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.sessionsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.sessionsDataGridView.Size = new System.Drawing.Size(492, 154);
            this.sessionsDataGridView.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(337, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Activities Completed During Selected Session";
            // 
            // activitiesDataGridView
            // 
            this.activitiesDataGridView.AllowUserToAddRows = false;
            this.activitiesDataGridView.AllowUserToDeleteRows = false;
            this.activitiesDataGridView.AllowUserToResizeColumns = false;
            this.activitiesDataGridView.AllowUserToResizeRows = false;
            this.activitiesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.activitiesDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.activitiesDataGridView.Location = new System.Drawing.Point(15, 244);
            this.activitiesDataGridView.MultiSelect = false;
            this.activitiesDataGridView.Name = "activitiesDataGridView";
            this.activitiesDataGridView.ReadOnly = true;
            this.activitiesDataGridView.RowHeadersVisible = false;
            this.activitiesDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.activitiesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.activitiesDataGridView.Size = new System.Drawing.Size(672, 179);
            this.activitiesDataGridView.TabIndex = 12;
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.Location = new System.Drawing.Point(15, 426);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(44, 13);
            this.totalLabel.TabIndex = 13;
            this.totalLabel.Text = "Total: ";
            // 
            // errorsLabel
            // 
            this.errorsLabel.AutoSize = true;
            this.errorsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorsLabel.Location = new System.Drawing.Point(192, 426);
            this.errorsLabel.Name = "errorsLabel";
            this.errorsLabel.Size = new System.Drawing.Size(48, 13);
            this.errorsLabel.TabIndex = 14;
            this.errorsLabel.Text = "Errors: ";
            // 
            // salesLabel
            // 
            this.salesLabel.AutoSize = true;
            this.salesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesLabel.Location = new System.Drawing.Point(371, 426);
            this.salesLabel.Name = "salesLabel";
            this.salesLabel.Size = new System.Drawing.Size(46, 13);
            this.salesLabel.TabIndex = 15;
            this.salesLabel.Text = "Sales: ";
            // 
            // printCurrentButton
            // 
            this.printCurrentButton.Location = new System.Drawing.Point(551, 446);
            this.printCurrentButton.Name = "printCurrentButton";
            this.printCurrentButton.Size = new System.Drawing.Size(136, 23);
            this.printCurrentButton.TabIndex = 16;
            this.printCurrentButton.Text = "Print Current Set ";
            this.printCurrentButton.UseVisualStyleBackColor = true;
            // 
            // printEntireButton
            // 
            this.printEntireButton.Location = new System.Drawing.Point(409, 446);
            this.printEntireButton.Name = "printEntireButton";
            this.printEntireButton.Size = new System.Drawing.Size(136, 23);
            this.printEntireButton.TabIndex = 17;
            this.printEntireButton.Text = "Print Entire Set ";
            this.printEntireButton.UseVisualStyleBackColor = true;
            // 
            // UserSessionActivitiesReportTemplateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 481);
            this.Controls.Add(this.printEntireButton);
            this.Controls.Add(this.printCurrentButton);
            this.Controls.Add(this.salesLabel);
            this.Controls.Add(this.errorsLabel);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.activitiesDataGridView);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.sessionsDataGridView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.newestDateTimePicker);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.oldestDateTimePicker);
            this.Controls.Add(this.roleLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(719, 488);
            this.Name = "UserSessionActivitiesReportTemplateForm";
            this.Text = "User Activities Report";
            this.Load += new System.EventHandler(this.UserSessionActivitiesReportTemplateForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sessionsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.activitiesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label roleLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker newestDateTimePicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker oldestDateTimePicker;
        private System.Windows.Forms.DataGridView sessionsDataGridView;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView activitiesDataGridView;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label errorsLabel;
        private System.Windows.Forms.Label salesLabel;
        private System.Windows.Forms.Button printCurrentButton;
        private System.Windows.Forms.Button printEntireButton;
    }
}