namespace RasaMotorsManagementSystem.CustomerVehicles
{
    partial class frmCustomerList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustomerList));
            this.pnlmidCusList = new System.Windows.Forms.Panel();
            this.headCusList = new System.Windows.Forms.Label();
            this.lblSearchCus = new System.Windows.Forms.Label();
            this.btnAddNewCustomer = new System.Windows.Forms.Button();
            this.txtBoxSearchCus = new System.Windows.Forms.TextBox();
            this.ViewGridCustomers = new System.Windows.Forms.DataGridView();
            this.btnReport = new System.Windows.Forms.Button();
            this.logoCusList = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ViewGridCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoCusList)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlmidCusList
            // 
            this.pnlmidCusList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlmidCusList.BackColor = System.Drawing.Color.Maroon;
            this.pnlmidCusList.Location = new System.Drawing.Point(-34, 124);
            this.pnlmidCusList.Name = "pnlmidCusList";
            this.pnlmidCusList.Size = new System.Drawing.Size(2666, 10);
            this.pnlmidCusList.TabIndex = 134;
            // 
            // headCusList
            // 
            this.headCusList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.headCusList.AutoSize = true;
            this.headCusList.Font = new System.Drawing.Font("Rockwell", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headCusList.ForeColor = System.Drawing.Color.White;
            this.headCusList.Location = new System.Drawing.Point(513, 24);
            this.headCusList.Name = "headCusList";
            this.headCusList.Size = new System.Drawing.Size(512, 77);
            this.headCusList.TabIndex = 133;
            this.headCusList.Text = "Customers List";
            this.headCusList.Click += new System.EventHandler(this.headCusList_Click);
            // 
            // lblSearchCus
            // 
            this.lblSearchCus.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblSearchCus.AutoSize = true;
            this.lblSearchCus.BackColor = System.Drawing.Color.Transparent;
            this.lblSearchCus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchCus.ForeColor = System.Drawing.Color.White;
            this.lblSearchCus.Location = new System.Drawing.Point(38, 187);
            this.lblSearchCus.Name = "lblSearchCus";
            this.lblSearchCus.Size = new System.Drawing.Size(81, 20);
            this.lblSearchCus.TabIndex = 132;
            this.lblSearchCus.Text = "Search...";
            // 
            // btnAddNewCustomer
            // 
            this.btnAddNewCustomer.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAddNewCustomer.BackColor = System.Drawing.Color.Maroon;
            this.btnAddNewCustomer.FlatAppearance.BorderSize = 0;
            this.btnAddNewCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewCustomer.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewCustomer.ForeColor = System.Drawing.Color.Transparent;
            this.btnAddNewCustomer.Location = new System.Drawing.Point(1124, 178);
            this.btnAddNewCustomer.Name = "btnAddNewCustomer";
            this.btnAddNewCustomer.Size = new System.Drawing.Size(105, 28);
            this.btnAddNewCustomer.TabIndex = 131;
            this.btnAddNewCustomer.Text = "Add New";
            this.btnAddNewCustomer.UseVisualStyleBackColor = false;
            this.btnAddNewCustomer.Click += new System.EventHandler(this.btnAddNewCustomer_Click);
            // 
            // txtBoxSearchCus
            // 
            this.txtBoxSearchCus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxSearchCus.BackColor = System.Drawing.Color.White;
            this.txtBoxSearchCus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxSearchCus.ForeColor = System.Drawing.Color.Gray;
            this.txtBoxSearchCus.Location = new System.Drawing.Point(125, 180);
            this.txtBoxSearchCus.Name = "txtBoxSearchCus";
            this.txtBoxSearchCus.Size = new System.Drawing.Size(823, 26);
            this.txtBoxSearchCus.TabIndex = 130;
            this.txtBoxSearchCus.Text = "Search by Name...";
            this.txtBoxSearchCus.TextChanged += new System.EventHandler(this.txtBoxSearchCus_TextChanged);
            this.txtBoxSearchCus.Enter += new System.EventHandler(this.txtBoxSearchCus_Enter);
            this.txtBoxSearchCus.Leave += new System.EventHandler(this.txtBoxSearchCus_Leave);
            // 
            // ViewGridCustomers
            // 
            this.ViewGridCustomers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ViewGridCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ViewGridCustomers.BackgroundColor = System.Drawing.Color.White;
            this.ViewGridCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ViewGridCustomers.Location = new System.Drawing.Point(42, 245);
            this.ViewGridCustomers.Name = "ViewGridCustomers";
            this.ViewGridCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ViewGridCustomers.Size = new System.Drawing.Size(1187, 409);
            this.ViewGridCustomers.TabIndex = 129;
            this.ViewGridCustomers.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ViewGridCustomers_CellContentDoubleClick);
            this.ViewGridCustomers.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ViewGridCustomers_RowHeaderMouseClick);
            // 
            // btnReport
            // 
            this.btnReport.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnReport.BackColor = System.Drawing.Color.Maroon;
            this.btnReport.FlatAppearance.BorderSize = 0;
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReport.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.ForeColor = System.Drawing.Color.Transparent;
            this.btnReport.Location = new System.Drawing.Point(964, 178);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(147, 28);
            this.btnReport.TabIndex = 136;
            this.btnReport.Text = "Generate Report";
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // logoCusList
            // 
            this.logoCusList.BackColor = System.Drawing.Color.Transparent;
            this.logoCusList.Image = ((System.Drawing.Image)(resources.GetObject("logoCusList.Image")));
            this.logoCusList.Location = new System.Drawing.Point(12, 12);
            this.logoCusList.Name = "logoCusList";
            this.logoCusList.Size = new System.Drawing.Size(228, 101);
            this.logoCusList.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoCusList.TabIndex = 135;
            this.logoCusList.TabStop = false;
            // 
            // frmCustomerList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1263, 686);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.logoCusList);
            this.Controls.Add(this.pnlmidCusList);
            this.Controls.Add(this.headCusList);
            this.Controls.Add(this.lblSearchCus);
            this.Controls.Add(this.btnAddNewCustomer);
            this.Controls.Add(this.txtBoxSearchCus);
            this.Controls.Add(this.ViewGridCustomers);
            this.Name = "frmCustomerList";
            this.Text = "frmCustomerList";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmCustomerList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ViewGridCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoCusList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logoCusList;
        private System.Windows.Forms.Panel pnlmidCusList;
        private System.Windows.Forms.Label headCusList;
        private System.Windows.Forms.Label lblSearchCus;
        private System.Windows.Forms.Button btnAddNewCustomer;
        private System.Windows.Forms.TextBox txtBoxSearchCus;
        public System.Windows.Forms.DataGridView ViewGridCustomers;
        private System.Windows.Forms.Button btnReport;
    }
}