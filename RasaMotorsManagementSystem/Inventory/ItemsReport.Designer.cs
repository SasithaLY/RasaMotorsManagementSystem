namespace RasaMotorsManagementSystem.Inventory
{
    partial class ItemsReport
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
            this.reportViewerItems = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Items = new RasaMotorsManagementSystem.Inventory.Items();
            this.inventoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventoryTableAdapter = new RasaMotorsManagementSystem.Inventory.ItemsTableAdapters.inventoryTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Items)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewerItems
            // 
            this.reportViewerItems.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "ItemDataSet";
            reportDataSource1.Value = this.inventoryBindingSource;
            this.reportViewerItems.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewerItems.LocalReport.ReportEmbeddedResource = "RasaMotorsManagementSystem.Inventory.Items.rdlc";
            this.reportViewerItems.Location = new System.Drawing.Point(0, 0);
            this.reportViewerItems.Name = "reportViewerItems";
            this.reportViewerItems.Size = new System.Drawing.Size(800, 450);
            this.reportViewerItems.TabIndex = 0;
            // 
            // Items
            // 
            this.Items.DataSetName = "Items";
            this.Items.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // inventoryBindingSource
            // 
            this.inventoryBindingSource.DataMember = "inventory";
            this.inventoryBindingSource.DataSource = this.Items;
            // 
            // inventoryTableAdapter
            // 
            this.inventoryTableAdapter.ClearBeforeFill = true;
            // 
            // ItemsReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewerItems);
            this.Name = "ItemsReport";
            this.Text = "ItemsReport";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ItemsReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Items)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public Microsoft.Reporting.WinForms.ReportViewer reportViewerItems;
        private System.Windows.Forms.BindingSource inventoryBindingSource;
        private Items Items;
        private ItemsTableAdapters.inventoryTableAdapter inventoryTableAdapter;
    }
}