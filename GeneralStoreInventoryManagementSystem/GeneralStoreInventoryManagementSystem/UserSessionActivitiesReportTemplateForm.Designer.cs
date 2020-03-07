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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserSessionActivitiesReportTemplateForm));
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
            this.returnsLabel = new System.Windows.Forms.Label();
            this.saleMessageLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sessionsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.activitiesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // usernameLabel
            // 
            resources.ApplyResources(this.usernameLabel, "usernameLabel");
            this.usernameLabel.Name = "usernameLabel";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // roleLabel
            // 
            resources.ApplyResources(this.roleLabel, "roleLabel");
            this.roleLabel.Name = "roleLabel";
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
            // sessionsDataGridView
            // 
            resources.ApplyResources(this.sessionsDataGridView, "sessionsDataGridView");
            this.sessionsDataGridView.AllowUserToAddRows = false;
            this.sessionsDataGridView.AllowUserToDeleteRows = false;
            this.sessionsDataGridView.AllowUserToResizeColumns = false;
            this.sessionsDataGridView.AllowUserToResizeRows = false;
            this.sessionsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sessionsDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.sessionsDataGridView.MultiSelect = false;
            this.sessionsDataGridView.Name = "sessionsDataGridView";
            this.sessionsDataGridView.ReadOnly = true;
            this.sessionsDataGridView.RowHeadersVisible = false;
            this.sessionsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.sessionsDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SessionsDataGridView_CellClick);
            this.sessionsDataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SessionsDataGridView_KeyDown);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // activitiesDataGridView
            // 
            resources.ApplyResources(this.activitiesDataGridView, "activitiesDataGridView");
            this.activitiesDataGridView.AllowUserToAddRows = false;
            this.activitiesDataGridView.AllowUserToDeleteRows = false;
            this.activitiesDataGridView.AllowUserToResizeColumns = false;
            this.activitiesDataGridView.AllowUserToResizeRows = false;
            this.activitiesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.activitiesDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.activitiesDataGridView.MultiSelect = false;
            this.activitiesDataGridView.Name = "activitiesDataGridView";
            this.activitiesDataGridView.ReadOnly = true;
            this.activitiesDataGridView.RowHeadersVisible = false;
            this.activitiesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // totalLabel
            // 
            resources.ApplyResources(this.totalLabel, "totalLabel");
            this.totalLabel.Name = "totalLabel";
            // 
            // errorsLabel
            // 
            resources.ApplyResources(this.errorsLabel, "errorsLabel");
            this.errorsLabel.Name = "errorsLabel";
            // 
            // salesLabel
            // 
            resources.ApplyResources(this.salesLabel, "salesLabel");
            this.salesLabel.Name = "salesLabel";
            this.salesLabel.MouseLeave += new System.EventHandler(this.SalesLabel_MouseLeave);
            this.salesLabel.MouseHover += new System.EventHandler(this.SalesLabel_MouseHover);
            // 
            // printCurrentButton
            // 
            resources.ApplyResources(this.printCurrentButton, "printCurrentButton");
            this.printCurrentButton.Name = "printCurrentButton";
            this.printCurrentButton.UseVisualStyleBackColor = true;
            // 
            // printEntireButton
            // 
            resources.ApplyResources(this.printEntireButton, "printEntireButton");
            this.printEntireButton.Name = "printEntireButton";
            this.printEntireButton.UseVisualStyleBackColor = true;
            // 
            // returnsLabel
            // 
            resources.ApplyResources(this.returnsLabel, "returnsLabel");
            this.returnsLabel.Name = "returnsLabel";
            // 
            // saleMessageLabel
            // 
            resources.ApplyResources(this.saleMessageLabel, "saleMessageLabel");
            this.saleMessageLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.saleMessageLabel.Name = "saleMessageLabel";
            // 
            // UserSessionActivitiesReportTemplateForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.saleMessageLabel);
            this.Controls.Add(this.returnsLabel);
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
            this.Name = "UserSessionActivitiesReportTemplateForm";
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
        private System.Windows.Forms.Label returnsLabel;
        private System.Windows.Forms.Label saleMessageLabel;
    }
}