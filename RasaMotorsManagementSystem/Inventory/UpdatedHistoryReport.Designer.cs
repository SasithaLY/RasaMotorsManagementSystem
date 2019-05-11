namespace RasaMotorsManagementSystem.Inventory
{
    partial class UpdatedHistoryReport
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportUpdated = new Microsoft.Reporting.WinForms.ReportViewer();
            this.UpdateHistoryData = new RasaMotorsManagementSystem.Inventory.UpdateHistoryData();
            this.inventoryHistoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventoryHistoryTableAdapter = new RasaMotorsManagementSystem.Inventory.UpdateHistoryDataTableAdapters.inventoryHistoryTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.UpdateHistoryData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryHistoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportUpdated
            // 
            this.reportUpdated.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "UpdatedHistoryDataSet";
            reportDataSource1.Value = this.inventoryHistoryBindingSource;
            this.reportUpdated.LocalReport.DataSources.Add(reportDataSource1);
            this.reportUpdated.LocalReport.ReportEmbeddedResource = "RasaMotorsManagementSystem.Inventory.UpdatedHistoryReport.rdlc";
            this.reportUpdated.Location = new System.Drawing.Point(0, 0);
            this.reportUpdated.Name = "reportUpdated";
            this.reportUpdated.ServerReport.BearerToken = null;
            this.reportUpdated.Size = new System.Drawing.Size(800, 450);
            this.reportUpdated.TabIndex = 0;
            // 
            // UpdateHistoryData
            // 
            this.UpdateHistoryData.DataSetName = "UpdateHistoryData";
            this.UpdateHistoryData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // inventoryHistoryBindingSource
            // 
            this.inventoryHistoryBindingSource.DataMember = "inventoryHistory";
            this.inventoryHistoryBindingSource.DataSource = this.UpdateHistoryData;
            // 
            // inventoryHistoryTableAdapter
            // 
            this.inventoryHistoryTableAdapter.ClearBeforeFill = true;
            // 
            // UpdatedHistoryReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportUpdated);
            this.Name = "UpdatedHistoryReport";
            this.Text = "UpdatedHistoryReport";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.UpdatedHistoryReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UpdateHistoryData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryHistoryBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportUpdated;
        private System.Windows.Forms.BindingSource inventoryHistoryBindingSource;
        private UpdateHistoryData UpdateHistoryData;
        private UpdateHistoryDataTableAdapters.inventoryHistoryTableAdapter inventoryHistoryTableAdapter;
    }
}