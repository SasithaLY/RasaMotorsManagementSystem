namespace RasaMotorsManagementSystem.Finance
{
    partial class reportViewer
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
            this.tbl_ProfitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.profitData = new RasaMotorsManagementSystem.Finance.profitData();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tbl_ProfitTableAdapter = new RasaMotorsManagementSystem.Finance.profitDataTableAdapters.tbl_ProfitTableAdapter();
            this.dteFrm = new System.Windows.Forms.DateTimePicker();
            this.dteTo = new System.Windows.Forms.DateTimePicker();
            this.btnSearch = new System.Windows.Forms.Button();
            this.From = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnChart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_ProfitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profitData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbl_ProfitBindingSource
            // 
            this.tbl_ProfitBindingSource.DataMember = "tbl_Profit";
            this.tbl_ProfitBindingSource.DataSource = this.profitData;
            // 
            // profitData
            // 
            this.profitData.DataSetName = "profitData";
            this.profitData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.tbl_ProfitBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "RasaMotorsManagementSystem.Finance.financeReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(192, 271);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(986, 473);
            this.reportViewer1.TabIndex = 0;
            // 
            // tbl_ProfitTableAdapter
            // 
            this.tbl_ProfitTableAdapter.ClearBeforeFill = true;
            // 
            // dteFrm
            // 
            this.dteFrm.Location = new System.Drawing.Point(301, 192);
            this.dteFrm.Name = "dteFrm";
            this.dteFrm.Size = new System.Drawing.Size(200, 20);
            this.dteFrm.TabIndex = 3;
            // 
            // dteTo
            // 
            this.dteTo.Location = new System.Drawing.Point(610, 193);
            this.dteTo.Name = "dteTo";
            this.dteTo.Size = new System.Drawing.Size(200, 20);
            this.dteTo.TabIndex = 4;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Maroon;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSearch.Location = new System.Drawing.Point(881, 190);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(83, 29);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // From
            // 
            this.From.AutoSize = true;
            this.From.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.From.ForeColor = System.Drawing.Color.Goldenrod;
            this.From.Location = new System.Drawing.Point(221, 193);
            this.From.Name = "From";
            this.From.Size = new System.Drawing.Size(50, 20);
            this.From.TabIndex = 6;
            this.From.Text = "From";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Goldenrod;
            this.label1.Location = new System.Drawing.Point(562, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "To";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Maroon;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(34, 314);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 53);
            this.button2.TabIndex = 9;
            this.button2.Text = "Home";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Maroon;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.Location = new System.Drawing.Point(34, 583);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 53);
            this.button3.TabIndex = 10;
            this.button3.Text = "Back";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Goldenrod;
            this.label2.Location = new System.Drawing.Point(524, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(371, 50);
            this.label2.TabIndex = 12;
            this.label2.Text = "Financial Report";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RasaMotorsManagementSystem.Properties.Resources.Rasa_Motors_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(3, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(388, 148);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // btnChart
            // 
            this.btnChart.BackColor = System.Drawing.Color.Maroon;
            this.btnChart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChart.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnChart.Location = new System.Drawing.Point(34, 448);
            this.btnChart.Name = "btnChart";
            this.btnChart.Size = new System.Drawing.Size(100, 53);
            this.btnChart.TabIndex = 13;
            this.btnChart.Text = "Chart";
            this.btnChart.UseVisualStyleBackColor = false;
            this.btnChart.Click += new System.EventHandler(this.btnChart_Click);
            // 
            // reportViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(1190, 806);
            this.Controls.Add(this.btnChart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.From);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dteTo);
            this.Controls.Add(this.dteFrm);
            this.Controls.Add(this.reportViewer1);
            this.Name = "reportViewer";
            this.Text = "reportViewer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.reportViewer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbl_ProfitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profitData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource tbl_ProfitBindingSource;
        private profitData profitData;
        private profitDataTableAdapters.tbl_ProfitTableAdapter tbl_ProfitTableAdapter;
        private System.Windows.Forms.DateTimePicker dteFrm;
        private System.Windows.Forms.DateTimePicker dteTo;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label From;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnChart;
    }
}