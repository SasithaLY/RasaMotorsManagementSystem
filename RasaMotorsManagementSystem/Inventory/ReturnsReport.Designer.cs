namespace RasaMotorsManagementSystem.Inventory
{
    partial class ReturnsReport
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
            this.reportViewerReturns = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ReturnsDataSet = new RasaMotorsManagementSystem.Inventory.ReturnsDataSet();
            this.returnItemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.returnItemsTableAdapter = new RasaMotorsManagementSystem.Inventory.ReturnsDataSetTableAdapters.returnItemsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ReturnsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnItemsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewerReturns
            // 
            this.reportViewerReturns.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet";
            reportDataSource1.Value = this.returnItemsBindingSource;
            this.reportViewerReturns.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewerReturns.LocalReport.ReportEmbeddedResource = "RasaMotorsManagementSystem.Inventory.ReturnsReport.rdlc";
            this.reportViewerReturns.Location = new System.Drawing.Point(0, 0);
            this.reportViewerReturns.Name = "reportViewerReturns";
            
            this.reportViewerReturns.Size = new System.Drawing.Size(755, 456);
            this.reportViewerReturns.TabIndex = 0;
            // 
            // ReturnsDataSet
            // 
            this.ReturnsDataSet.DataSetName = "ReturnsDataSet";
            this.ReturnsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // returnItemsBindingSource
            // 
            this.returnItemsBindingSource.DataMember = "returnItems";
            this.returnItemsBindingSource.DataSource = this.ReturnsDataSet;
            // 
            // returnItemsTableAdapter
            // 
            this.returnItemsTableAdapter.ClearBeforeFill = true;
            // 
            // ReturnsReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 456);
            this.Controls.Add(this.reportViewerReturns);
            this.Name = "ReturnsReport";
            this.Text = "Returns Report";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ReturnsReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ReturnsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.returnItemsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerReturns;
        private System.Windows.Forms.BindingSource returnItemsBindingSource;
        private ReturnsDataSet ReturnsDataSet;
        private ReturnsDataSetTableAdapters.returnItemsTableAdapter returnItemsTableAdapter;
    }
}