namespace RasaMotorsManagementSystem.Finance
{
    partial class calculation
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
            this.btnLoad = new System.Windows.Forms.Button();
            this.dtPkr1 = new System.Windows.Forms.DateTimePicker();
            this.dtPckr = new System.Windows.Forms.DateTimePicker();
            this.txtCal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblProfit = new System.Windows.Forms.Label();
            this.txtUtilityPay = new System.Windows.Forms.TextBox();
            this.lbUtility = new System.Windows.Forms.Label();
            this.txtSal = new System.Windows.Forms.TextBox();
            this.lbSalary = new System.Windows.Forms.Label();
            this.lbExpen = new System.Windows.Forms.Label();
            this.lbIncome = new System.Windows.Forms.Label();
            this.txtOrder = new System.Windows.Forms.TextBox();
            this.lbOrder = new System.Windows.Forms.Label();
            this.txtInvenPay = new System.Windows.Forms.TextBox();
            this.lbInvenPay = new System.Windows.Forms.Label();
            this.btnView = new System.Windows.Forms.Button();
            this.txtInvenSales = new System.Windows.Forms.TextBox();
            this.lbInvenSales = new System.Windows.Forms.Label();
            this.txtTotIncome = new System.Windows.Forms.TextBox();
            this.lbTotIncome = new System.Windows.Forms.Label();
            this.btnCal = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.Location = new System.Drawing.Point(1066, 155);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(2);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(95, 48);
            this.btnLoad.TabIndex = 149;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // dtPkr1
            // 
            this.dtPkr1.Location = new System.Drawing.Point(870, 207);
            this.dtPkr1.Margin = new System.Windows.Forms.Padding(2);
            this.dtPkr1.Name = "dtPkr1";
            this.dtPkr1.Size = new System.Drawing.Size(151, 20);
            this.dtPkr1.TabIndex = 148;
            // 
            // dtPckr
            // 
            this.dtPckr.Location = new System.Drawing.Point(870, 142);
            this.dtPckr.Margin = new System.Windows.Forms.Padding(2);
            this.dtPckr.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtPckr.Name = "dtPckr";
            this.dtPckr.Size = new System.Drawing.Size(151, 20);
            this.dtPckr.TabIndex = 146;
            // 
            // txtCal
            // 
            this.txtCal.Location = new System.Drawing.Point(522, 550);
            this.txtCal.Margin = new System.Windows.Forms.Padding(2);
            this.txtCal.Name = "txtCal";
            this.txtCal.ReadOnly = true;
            this.txtCal.Size = new System.Drawing.Size(145, 20);
            this.txtCal.TabIndex = 145;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Maiandra GD", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Goldenrod;
            this.label1.Location = new System.Drawing.Point(490, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 57);
            this.label1.TabIndex = 147;
            this.label1.Text = "Finance";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Maroon;
            this.btnSave.Font = new System.Drawing.Font("Maiandra GD", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(670, 691);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(115, 69);
            this.btnSave.TabIndex = 143;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblProfit
            // 
            this.lblProfit.AutoSize = true;
            this.lblProfit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfit.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblProfit.Location = new System.Drawing.Point(278, 540);
            this.lblProfit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProfit.Name = "lblProfit";
            this.lblProfit.Size = new System.Drawing.Size(120, 26);
            this.lblProfit.TabIndex = 142;
            this.lblProfit.Text = "Net Profit ";
            // 
            // txtUtilityPay
            // 
            this.txtUtilityPay.Location = new System.Drawing.Point(522, 459);
            this.txtUtilityPay.Margin = new System.Windows.Forms.Padding(2);
            this.txtUtilityPay.Name = "txtUtilityPay";
            this.txtUtilityPay.Size = new System.Drawing.Size(145, 20);
            this.txtUtilityPay.TabIndex = 141;
            this.txtUtilityPay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUtilityPay_KeyPress);
            // 
            // lbUtility
            // 
            this.lbUtility.AutoSize = true;
            this.lbUtility.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUtility.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lbUtility.Location = new System.Drawing.Point(278, 448);
            this.lbUtility.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbUtility.Name = "lbUtility";
            this.lbUtility.Size = new System.Drawing.Size(126, 26);
            this.lbUtility.TabIndex = 140;
            this.lbUtility.Text = "Utility Bills";
            // 
            // txtSal
            // 
            this.txtSal.Location = new System.Drawing.Point(522, 491);
            this.txtSal.Margin = new System.Windows.Forms.Padding(2);
            this.txtSal.Name = "txtSal";
            this.txtSal.ReadOnly = true;
            this.txtSal.Size = new System.Drawing.Size(145, 20);
            this.txtSal.TabIndex = 139;
            this.txtSal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSal_KeyPress);
            // 
            // lbSalary
            // 
            this.lbSalary.AutoSize = true;
            this.lbSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSalary.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lbSalary.Location = new System.Drawing.Point(278, 479);
            this.lbSalary.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbSalary.Name = "lbSalary";
            this.lbSalary.Size = new System.Drawing.Size(80, 26);
            this.lbSalary.TabIndex = 138;
            this.lbSalary.Text = "Salary";
            // 
            // lbExpen
            // 
            this.lbExpen.AutoSize = true;
            this.lbExpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbExpen.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lbExpen.Location = new System.Drawing.Point(170, 325);
            this.lbExpen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbExpen.Name = "lbExpen";
            this.lbExpen.Size = new System.Drawing.Size(139, 26);
            this.lbExpen.TabIndex = 137;
            this.lbExpen.Text = "Expenditure";
            // 
            // lbIncome
            // 
            this.lbIncome.AutoSize = true;
            this.lbIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIncome.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lbIncome.Location = new System.Drawing.Point(170, 196);
            this.lbIncome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbIncome.Name = "lbIncome";
            this.lbIncome.Size = new System.Drawing.Size(90, 26);
            this.lbIncome.TabIndex = 136;
            this.lbIncome.Text = "Income";
            // 
            // txtOrder
            // 
            this.txtOrder.Location = new System.Drawing.Point(522, 376);
            this.txtOrder.Margin = new System.Windows.Forms.Padding(2);
            this.txtOrder.Name = "txtOrder";
            this.txtOrder.ReadOnly = true;
            this.txtOrder.Size = new System.Drawing.Size(145, 20);
            this.txtOrder.TabIndex = 135;
            this.txtOrder.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOrder_KeyPress);
            // 
            // lbOrder
            // 
            this.lbOrder.AutoSize = true;
            this.lbOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOrder.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lbOrder.Location = new System.Drawing.Point(278, 366);
            this.lbOrder.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbOrder.Name = "lbOrder";
            this.lbOrder.Size = new System.Drawing.Size(84, 26);
            this.lbOrder.TabIndex = 134;
            this.lbOrder.Text = "Orders";
            // 
            // txtInvenPay
            // 
            this.txtInvenPay.Location = new System.Drawing.Point(522, 419);
            this.txtInvenPay.Margin = new System.Windows.Forms.Padding(2);
            this.txtInvenPay.Name = "txtInvenPay";
            this.txtInvenPay.Size = new System.Drawing.Size(145, 20);
            this.txtInvenPay.TabIndex = 133;
            this.txtInvenPay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInvenPay_KeyPress);
            // 
            // lbInvenPay
            // 
            this.lbInvenPay.AutoSize = true;
            this.lbInvenPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInvenPay.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lbInvenPay.Location = new System.Drawing.Point(278, 407);
            this.lbInvenPay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbInvenPay.Name = "lbInvenPay";
            this.lbInvenPay.Size = new System.Drawing.Size(198, 26);
            this.lbInvenPay.TabIndex = 132;
            this.lbInvenPay.Text = "Inventry Payment";
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.Color.Maroon;
            this.btnView.Font = new System.Drawing.Font("Maiandra GD", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.ForeColor = System.Drawing.Color.White;
            this.btnView.Location = new System.Drawing.Point(1027, 692);
            this.btnView.Margin = new System.Windows.Forms.Padding(2);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(118, 69);
            this.btnView.TabIndex = 131;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // txtInvenSales
            // 
            this.txtInvenSales.Location = new System.Drawing.Point(522, 280);
            this.txtInvenSales.Margin = new System.Windows.Forms.Padding(2);
            this.txtInvenSales.Name = "txtInvenSales";
            this.txtInvenSales.Size = new System.Drawing.Size(145, 20);
            this.txtInvenSales.TabIndex = 130;
            this.txtInvenSales.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInvenSales_KeyPress);
            // 
            // lbInvenSales
            // 
            this.lbInvenSales.AutoSize = true;
            this.lbInvenSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInvenSales.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lbInvenSales.Location = new System.Drawing.Point(278, 266);
            this.lbInvenSales.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbInvenSales.Name = "lbInvenSales";
            this.lbInvenSales.Size = new System.Drawing.Size(160, 26);
            this.lbInvenSales.TabIndex = 129;
            this.lbInvenSales.Text = "Inventry sales";
            // 
            // txtTotIncome
            // 
            this.txtTotIncome.Location = new System.Drawing.Point(522, 245);
            this.txtTotIncome.Margin = new System.Windows.Forms.Padding(2);
            this.txtTotIncome.Name = "txtTotIncome";
            this.txtTotIncome.ReadOnly = true;
            this.txtTotIncome.Size = new System.Drawing.Size(145, 20);
            this.txtTotIncome.TabIndex = 128;
            this.txtTotIncome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTotIncome_KeyPress);
            // 
            // lbTotIncome
            // 
            this.lbTotIncome.AutoSize = true;
            this.lbTotIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotIncome.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lbTotIncome.Location = new System.Drawing.Point(278, 237);
            this.lbTotIncome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTotIncome.Name = "lbTotIncome";
            this.lbTotIncome.Size = new System.Drawing.Size(231, 26);
            this.lbTotIncome.TabIndex = 127;
            this.lbTotIncome.Text = "Total service income\r\n";
            // 
            // btnCal
            // 
            this.btnCal.BackColor = System.Drawing.Color.Maroon;
            this.btnCal.Font = new System.Drawing.Font("Maiandra GD", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCal.ForeColor = System.Drawing.Color.White;
            this.btnCal.Location = new System.Drawing.Point(853, 691);
            this.btnCal.Margin = new System.Windows.Forms.Padding(2);
            this.btnCal.Name = "btnCal";
            this.btnCal.Size = new System.Drawing.Size(116, 71);
            this.btnCal.TabIndex = 126;
            this.btnCal.Text = "Calculate";
            this.btnCal.UseVisualStyleBackColor = false;
            this.btnCal.Click += new System.EventHandler(this.btnCal_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RasaMotorsManagementSystem.Properties.Resources.Rasa_Motors_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(2, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(310, 147);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 144;
            this.pictureBox1.TabStop = false;
            // 
            // calculation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(1190, 806);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.dtPkr1);
            this.Controls.Add(this.dtPckr);
            this.Controls.Add(this.txtCal);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblProfit);
            this.Controls.Add(this.txtUtilityPay);
            this.Controls.Add(this.lbUtility);
            this.Controls.Add(this.txtSal);
            this.Controls.Add(this.lbSalary);
            this.Controls.Add(this.lbExpen);
            this.Controls.Add(this.lbIncome);
            this.Controls.Add(this.txtOrder);
            this.Controls.Add(this.lbOrder);
            this.Controls.Add(this.txtInvenPay);
            this.Controls.Add(this.lbInvenPay);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.txtInvenSales);
            this.Controls.Add(this.lbInvenSales);
            this.Controls.Add(this.txtTotIncome);
            this.Controls.Add(this.lbTotIncome);
            this.Controls.Add(this.btnCal);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "calculation";
            this.Text = "calculation";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.DateTimePicker dtPkr1;
        private System.Windows.Forms.DateTimePicker dtPckr;
        public System.Windows.Forms.TextBox txtCal;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblProfit;
        public System.Windows.Forms.TextBox txtUtilityPay;
        private System.Windows.Forms.Label lbUtility;
        public System.Windows.Forms.TextBox txtSal;
        private System.Windows.Forms.Label lbSalary;
        private System.Windows.Forms.Label lbExpen;
        private System.Windows.Forms.Label lbIncome;
        public System.Windows.Forms.TextBox txtOrder;
        private System.Windows.Forms.Label lbOrder;
        public System.Windows.Forms.TextBox txtInvenPay;
        private System.Windows.Forms.Label lbInvenPay;
        private System.Windows.Forms.Button btnView;
        public System.Windows.Forms.TextBox txtInvenSales;
        private System.Windows.Forms.Label lbInvenSales;
        public System.Windows.Forms.TextBox txtTotIncome;
        private System.Windows.Forms.Label lbTotIncome;
        private System.Windows.Forms.Button btnCal;
    }
}