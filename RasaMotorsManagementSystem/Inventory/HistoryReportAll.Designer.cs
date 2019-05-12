namespace RasaMotorsManagementSystem.Inventory
{
    partial class HistoryReportAll
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
            this.inventoryHistoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AllHistoryData = new RasaMotorsManagementSystem.Inventory.AllHistoryData();
            this.reportAllHistory = new Microsoft.Reporting.WinForms.ReportViewer();
            this.inventoryHistoryTableAdapter = new RasaMotorsManagementSystem.Inventory.AllHistoryDataTableAdapters.inventoryHistoryTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryHistoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AllHistoryData)).BeginInit();
            this.SuspendLayout();
            // 
            // inventoryHistoryBindingSource
            // 
            this.inventoryHistoryBindingSource.DataMember = "inventoryHistory";
            this.inventoryHistoryBindingSource.DataSource = this.AllHistoryData;
            // 
            // AllHistoryData
            // 
            this.AllHistoryData.DataSetName = "AllHistoryData";
            this.AllHistoryData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportAllHistory
            // 
            this.reportAllHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetAllHistory";
            reportDataSource1.Value = this.inventoryHistoryBindingSource;
            this.reportAllHistory.LocalReport.DataSources.Add(reportDataSource1);
            this.reportAllHistory.LocalReport.ReportEmbeddedResource = "RasaMotorsManagementSystem.Inventory.AllHistoryReport.rdlc";
            this.reportAllHistory.Location = new System.Drawing.Point(0, 0);
            this.reportAllHistory.Name = "reportAllHistory";
            this.reportAllHistory.ServerReport.BearerToken = null;
            this.reportAllHistory.Size = new System.Drawing.Size(800, 450);
            this.reportAllHistory.TabIndex = 0;
            // 
            // inventoryHistoryTableAdapter
            // 
            this.inventoryHistoryTableAdapter.ClearBeforeFill = true;
            // 
            // HistoryReportAll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportAllHistory);
            this.Name = "HistoryReportAll";
            this.Text = "HistoryReportAll";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.HistoryReportAll_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inventoryHistoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AllHistoryData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportAllHistory;
        private System.Windows.Forms.BindingSource inventoryHistoryBindingSource;
        private AllHistoryData AllHistoryData;
        private AllHistoryDataTableAdapters.inventoryHistoryTableAdapter inventoryHistoryTableAdapter;
    }
}