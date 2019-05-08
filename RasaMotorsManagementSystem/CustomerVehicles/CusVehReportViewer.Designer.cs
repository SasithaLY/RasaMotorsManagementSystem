namespace RasaMotorsManagementSystem.CustomerVehicles
{
    partial class CusVehReportViewer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CusVehReportViewer));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.pnlmidCusVehReport = new System.Windows.Forms.Panel();
            this.headCusVehReport = new System.Windows.Forms.Label();
            this.logoCusVehReport = new System.Windows.Forms.PictureBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.lblTo = new System.Windows.Forms.Label();
            this.lblFrom = new System.Windows.Forms.Label();
            this.dtpCusVehTo = new System.Windows.Forms.DateTimePicker();
            this.dtpCusVehFrom = new System.Windows.Forms.DateTimePicker();
            this.reportViewerCusVeh = new Microsoft.Reporting.WinForms.ReportViewer();
            this.CustomerVehicleDataSet = new RasaMotorsManagementSystem.CustomerVehicles.CustomerVehicleDataSet();
            this.DataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataTable1TableAdapter = new RasaMotorsManagementSystem.CustomerVehicles.CustomerVehicleDataSetTableAdapters.DataTable1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.logoCusVehReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerVehicleDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlmidCusVehReport
            // 
            this.pnlmidCusVehReport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlmidCusVehReport.BackColor = System.Drawing.Color.Maroon;
            this.pnlmidCusVehReport.Location = new System.Drawing.Point(-34, 124);
            this.pnlmidCusVehReport.Name = "pnlmidCusVehReport";
            this.pnlmidCusVehReport.Size = new System.Drawing.Size(2852, 10);
            this.pnlmidCusVehReport.TabIndex = 137;
            // 
            // headCusVehReport
            // 
            this.headCusVehReport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.headCusVehReport.AutoSize = true;
            this.headCusVehReport.Font = new System.Drawing.Font("Rockwell", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headCusVehReport.ForeColor = System.Drawing.Color.White;
            this.headCusVehReport.Location = new System.Drawing.Point(276, 25);
            this.headCusVehReport.Name = "headCusVehReport";
            this.headCusVehReport.Size = new System.Drawing.Size(1028, 77);
            this.headCusVehReport.TabIndex = 136;
            this.headCusVehReport.Text = "Customers and Vehicles Report";
            // 
            // logoCusVehReport
            // 
            this.logoCusVehReport.BackColor = System.Drawing.Color.Transparent;
            this.logoCusVehReport.Image = ((System.Drawing.Image)(resources.GetObject("logoCusVehReport.Image")));
            this.logoCusVehReport.Location = new System.Drawing.Point(12, 12);
            this.logoCusVehReport.Name = "logoCusVehReport";
            this.logoCusVehReport.Size = new System.Drawing.Size(228, 101);
            this.logoCusVehReport.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoCusVehReport.TabIndex = 138;
            this.logoCusVehReport.TabStop = false;
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.Maroon;
            this.btnLoad.FlatAppearance.BorderSize = 0;
            this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoad.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.ForeColor = System.Drawing.Color.White;
            this.btnLoad.Location = new System.Drawing.Point(938, 184);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(117, 31);
            this.btnLoad.TabIndex = 143;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTo.ForeColor = System.Drawing.Color.White;
            this.lblTo.Location = new System.Drawing.Point(615, 193);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(35, 20);
            this.lblTo.TabIndex = 142;
            this.lblTo.Text = "To :";
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrom.ForeColor = System.Drawing.Color.White;
            this.lblFrom.Location = new System.Drawing.Point(306, 194);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(54, 20);
            this.lblFrom.TabIndex = 141;
            this.lblFrom.Text = "From :";
            // 
            // dtpCusVehTo
            // 
            this.dtpCusVehTo.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpCusVehTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpCusVehTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCusVehTo.Location = new System.Drawing.Point(675, 188);
            this.dtpCusVehTo.Name = "dtpCusVehTo";
            this.dtpCusVehTo.Size = new System.Drawing.Size(200, 26);
            this.dtpCusVehTo.TabIndex = 140;
            // 
            // dtpCusVehFrom
            // 
            this.dtpCusVehFrom.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpCusVehFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpCusVehFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCusVehFrom.Location = new System.Drawing.Point(379, 189);
            this.dtpCusVehFrom.Name = "dtpCusVehFrom";
            this.dtpCusVehFrom.Size = new System.Drawing.Size(200, 26);
            this.dtpCusVehFrom.TabIndex = 139;
            // 
            // reportViewerCusVeh
            // 
            this.reportViewerCusVeh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource2.Name = "CustomerVehicleData";
            reportDataSource2.Value = this.DataTable1BindingSource;
            this.reportViewerCusVeh.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewerCusVeh.LocalReport.ReportEmbeddedResource = "RasaMotorsManagementSystem.CustomerVehicles.CustomerVehicleReport.rdlc";
            this.reportViewerCusVeh.Location = new System.Drawing.Point(77, 254);
            this.reportViewerCusVeh.Name = "reportViewerCusVeh";
            
            this.reportViewerCusVeh.Size = new System.Drawing.Size(1227, 376);
            this.reportViewerCusVeh.TabIndex = 144;
            // 
            // CustomerVehicleDataSet
            // 
            this.CustomerVehicleDataSet.DataSetName = "CustomerVehicleDataSet";
            this.CustomerVehicleDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DataTable1BindingSource
            // 
            this.DataTable1BindingSource.DataMember = "DataTable1";
            this.DataTable1BindingSource.DataSource = this.CustomerVehicleDataSet;
            // 
            // DataTable1TableAdapter
            // 
            this.DataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // CusVehReportViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1422, 669);
            this.Controls.Add(this.reportViewerCusVeh);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.lblFrom);
            this.Controls.Add(this.dtpCusVehTo);
            this.Controls.Add(this.dtpCusVehFrom);
            this.Controls.Add(this.logoCusVehReport);
            this.Controls.Add(this.pnlmidCusVehReport);
            this.Controls.Add(this.headCusVehReport);
            this.Name = "CusVehReportViewer";
            this.Text = "CusVehReportViewer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CusVehReportViewer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logoCusVehReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerVehicleDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logoCusVehReport;
        private System.Windows.Forms.Panel pnlmidCusVehReport;
        private System.Windows.Forms.Label headCusVehReport;
        private System.Windows.Forms.Button btnLoad;
        public System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label lblFrom;
        public System.Windows.Forms.DateTimePicker dtpCusVehTo;
        public System.Windows.Forms.DateTimePicker dtpCusVehFrom;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerCusVeh;
        private System.Windows.Forms.BindingSource DataTable1BindingSource;
        private CustomerVehicleDataSet CustomerVehicleDataSet;
        private CustomerVehicleDataSetTableAdapters.DataTable1TableAdapter DataTable1TableAdapter;
    }
}