namespace RasaMotorsManagementSystem.Inventory
{
    partial class DeleteHistoryReport
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportDeleteHistory = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DeleteHistoryData = new RasaMotorsManagementSystem.Inventory.DeleteHistoryData();
            this.inventoryHistoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventoryHistoryTableAdapter = new RasaMotorsManagementSystem.Inventory.DeleteHistoryDataTableAdapters.inventoryHistoryTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteHistoryData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryHistoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportDeleteHistory
            // 
            this.reportDeleteHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DeletedHistoryDataSet";
            reportDataSource2.Value = this.inventoryHistoryBindingSource;
            this.reportDeleteHistory.LocalReport.DataSources.Add(reportDataSource2);
            this.reportDeleteHistory.LocalReport.ReportEmbeddedResource = "RasaMotorsManagementSystem.Inventory.DeletedHistoryReport.rdlc";
            this.reportDeleteHistory.Location = new System.Drawing.Point(0, 0);
            this.reportDeleteHistory.Name = "reportDeleteHistory";
            this.reportDeleteHistory.ServerReport.BearerToken = null;
            this.reportDeleteHistory.Size = new System.Drawing.Size(800, 450);
            this.reportDeleteHistory.TabIndex = 0;
            this.reportDeleteHistory.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // DeleteHistoryData
            // 
            this.DeleteHistoryData.DataSetName = "DeleteHistoryData";
            this.DeleteHistoryData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // inventoryHistoryBindingSource
            // 
            this.inventoryHistoryBindingSource.DataMember = "inventoryHistory";
            this.inventoryHistoryBindingSource.DataSource = this.DeleteHistoryData;
            // 
            // inventoryHistoryTableAdapter
            // 
            this.inventoryHistoryTableAdapter.ClearBeforeFill = true;
            // 
            // DeleteHistoryReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportDeleteHistory);
            this.Name = "DeleteHistoryReport";
            this.Text = "DeleteHistoryReport";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DeleteHistoryReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DeleteHistoryData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryHistoryBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportDeleteHistory;
        private System.Windows.Forms.BindingSource inventoryHistoryBindingSource;
        private DeleteHistoryData DeleteHistoryData;
        private DeleteHistoryDataTableAdapters.inventoryHistoryTableAdapter inventoryHistoryTableAdapter;
    }
}