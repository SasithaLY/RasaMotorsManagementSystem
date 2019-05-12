namespace RasaMotorsManagementSystem.Salary
{
    partial class salaryreport
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
            this.DataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.EmpData = new RasaMotorsManagementSystem.Salary.EmpData();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dtpfrom = new System.Windows.Forms.DateTimePicker();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.FROM = new System.Windows.Forms.Label();
            this.TO = new System.Windows.Forms.Label();
            this.btnsearch = new System.Windows.Forms.Button();
            this.DataTable1TableAdapter = new RasaMotorsManagementSystem.Salary.EmpDataTableAdapters.DataTable1TableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmpData)).BeginInit();
            this.SuspendLayout();
            // 
            // DataTable1BindingSource
            // 
            this.DataTable1BindingSource.DataMember = "DataTable1";
            this.DataTable1BindingSource.DataSource = this.EmpData;
            // 
            // EmpData
            // 
            this.EmpData.DataSetName = "EmpData";
            this.EmpData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.DataTable1BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "RasaMotorsManagementSystem.Salary.salaryreport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(25, 86);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1051, 483);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // dtpfrom
            // 
            this.dtpfrom.Location = new System.Drawing.Point(415, 36);
            this.dtpfrom.Name = "dtpfrom";
            this.dtpfrom.Size = new System.Drawing.Size(200, 20);
            this.dtpfrom.TabIndex = 1;
            // 
            // dtpTo
            // 
            this.dtpTo.Location = new System.Drawing.Point(687, 35);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(200, 20);
            this.dtpTo.TabIndex = 2;
            // 
            // FROM
            // 
            this.FROM.AutoSize = true;
            this.FROM.ForeColor = System.Drawing.SystemColors.Control;
            this.FROM.Location = new System.Drawing.Point(359, 36);
            this.FROM.Name = "FROM";
            this.FROM.Size = new System.Drawing.Size(38, 13);
            this.FROM.TabIndex = 3;
            this.FROM.Text = "FROM";
            // 
            // TO
            // 
            this.TO.AutoSize = true;
            this.TO.ForeColor = System.Drawing.Color.White;
            this.TO.Location = new System.Drawing.Point(645, 37);
            this.TO.Name = "TO";
            this.TO.Size = new System.Drawing.Size(22, 13);
            this.TO.TabIndex = 4;
            this.TO.Text = "TO";
            // 
            // btnsearch
            // 
            this.btnsearch.BackColor = System.Drawing.Color.Maroon;
            this.btnsearch.ForeColor = System.Drawing.Color.White;
            this.btnsearch.Location = new System.Drawing.Point(907, 27);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(100, 34);
            this.btnsearch.TabIndex = 5;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = false;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // DataTable1TableAdapter
            // 
            this.DataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Maroon;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(965, 584);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 34);
            this.button1.TabIndex = 6;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // salaryreport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(1088, 641);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.TO);
            this.Controls.Add(this.FROM);
            this.Controls.Add(this.dtpTo);
            this.Controls.Add(this.dtpfrom);
            this.Controls.Add(this.reportViewer1);
            this.Name = "salaryreport";
            this.Text = "salaryreport";
            this.Load += new System.EventHandler(this.salaryreport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmpData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.DateTimePicker dtpfrom;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Label FROM;
        private System.Windows.Forms.Label TO;
        private System.Windows.Forms.BindingSource DataTable1BindingSource;
        private EmpData EmpData;
        private System.Windows.Forms.Button btnsearch;
        private EmpDataTableAdapters.DataTable1TableAdapter DataTable1TableAdapter;
        private System.Windows.Forms.Button button1;
    }
}