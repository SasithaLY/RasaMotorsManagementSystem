namespace RasaMotorsManagementSystem.Salary
{
    partial class Salaryform
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
            this.labbon = new System.Windows.Forms.Label();
            this.errorProviderOT = new System.Windows.Forms.ErrorProvider(this.components);
            this.Edit_details = new System.Windows.Forms.Button();
            this.btnGreport = new System.Windows.Forms.Button();
            this.Time = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labot = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.txtEpf = new System.Windows.Forms.TextBox();
            this.Etf = new System.Windows.Forms.Label();
            this.otRate = new System.Windows.Forms.Label();
            this.combo = new System.Windows.Forms.ComboBox();
            this.btnView = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.txtBasic = new System.Windows.Forms.TextBox();
            this.lblBasic = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTot = new System.Windows.Forms.TextBox();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.LBLOT = new System.Windows.Forms.Label();
            this.lblBonus = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.txtOT = new System.Windows.Forms.TextBox();
            this.TxtBonus = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderOT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labbon
            // 
            this.labbon.AutoSize = true;
            this.labbon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labbon.Location = new System.Drawing.Point(459, 369);
            this.labbon.Name = "labbon";
            this.labbon.Size = new System.Drawing.Size(85, 13);
            this.labbon.TabIndex = 118;
            this.labbon.Text = "INVALID INPUT";
            this.labbon.Visible = false;
            // 
            // errorProviderOT
            // 
            this.errorProviderOT.ContainerControl = this;
            // 
            // Edit_details
            // 
            this.Edit_details.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Edit_details.BackColor = System.Drawing.Color.Maroon;
            this.Edit_details.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Edit_details.Font = new System.Drawing.Font("Cambria", 9.75F);
            this.Edit_details.ForeColor = System.Drawing.Color.White;
            this.Edit_details.Location = new System.Drawing.Point(549, 190);
            this.Edit_details.Name = "Edit_details";
            this.Edit_details.Size = new System.Drawing.Size(90, 31);
            this.Edit_details.TabIndex = 116;
            this.Edit_details.Text = "Edit Details";
            this.Edit_details.UseVisualStyleBackColor = false;
            this.Edit_details.Click += new System.EventHandler(this.Edit_details_Click);
            // 
            // btnGreport
            // 
            this.btnGreport.BackColor = System.Drawing.Color.Maroon;
            this.btnGreport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGreport.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGreport.Location = new System.Drawing.Point(549, 405);
            this.btnGreport.Name = "btnGreport";
            this.btnGreport.Size = new System.Drawing.Size(113, 33);
            this.btnGreport.TabIndex = 115;
            this.btnGreport.Text = "Generate Report";
            this.btnGreport.UseVisualStyleBackColor = false;
            // 
            // Time
            // 
            this.Time.AutoSize = true;
            this.Time.Location = new System.Drawing.Point(527, 19);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(30, 13);
            this.Time.TabIndex = 114;
            this.Time.Text = "Time";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labot
            // 
            this.labot.AutoSize = true;
            this.labot.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labot.Location = new System.Drawing.Point(459, 328);
            this.labot.Name = "labot";
            this.labot.Size = new System.Drawing.Size(85, 13);
            this.labot.TabIndex = 117;
            this.labot.Text = "INVALID INPUT";
            this.labot.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::RasaMotorsManagementSystem.Properties.Resources.Rasa_Motors_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(28, 19);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(227, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 113;
            this.pictureBox1.TabStop = false;
            // 
            // txtRate
            // 
            this.txtRate.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtRate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtRate.Location = new System.Drawing.Point(284, 237);
            this.txtRate.Margin = new System.Windows.Forms.Padding(0);
            this.txtRate.Multiline = true;
            this.txtRate.Name = "txtRate";
            this.txtRate.ReadOnly = true;
            this.txtRate.Size = new System.Drawing.Size(172, 22);
            this.txtRate.TabIndex = 95;
            this.txtRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtRate.TextChanged += new System.EventHandler(this.txtRate_TextChanged);
            // 
            // txtEpf
            // 
            this.txtEpf.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtEpf.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEpf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtEpf.Location = new System.Drawing.Point(284, 278);
            this.txtEpf.Margin = new System.Windows.Forms.Padding(0);
            this.txtEpf.Multiline = true;
            this.txtEpf.Name = "txtEpf";
            this.txtEpf.ReadOnly = true;
            this.txtEpf.Size = new System.Drawing.Size(172, 22);
            this.txtEpf.TabIndex = 96;
            this.txtEpf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Etf
            // 
            this.Etf.AutoSize = true;
            this.Etf.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Etf.Font = new System.Drawing.Font("Iskoola Pota", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Etf.ForeColor = System.Drawing.Color.White;
            this.Etf.Location = new System.Drawing.Point(132, 279);
            this.Etf.Name = "Etf";
            this.Etf.Padding = new System.Windows.Forms.Padding(2);
            this.Etf.Size = new System.Drawing.Size(76, 23);
            this.Etf.TabIndex = 112;
            this.Etf.Text = "ETF& Epf";
            // 
            // otRate
            // 
            this.otRate.AutoSize = true;
            this.otRate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.otRate.Font = new System.Drawing.Font("Iskoola Pota", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.otRate.ForeColor = System.Drawing.Color.White;
            this.otRate.Location = new System.Drawing.Point(132, 238);
            this.otRate.Name = "otRate";
            this.otRate.Padding = new System.Windows.Forms.Padding(2);
            this.otRate.Size = new System.Drawing.Size(75, 23);
            this.otRate.TabIndex = 111;
            this.otRate.Text = "OT Rate";
            // 
            // combo
            // 
            this.combo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.combo.ForeColor = System.Drawing.Color.Black;
            this.combo.FormattingEnabled = true;
            this.combo.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.combo.Location = new System.Drawing.Point(284, 152);
            this.combo.Margin = new System.Windows.Forms.Padding(0);
            this.combo.Name = "combo";
            this.combo.Size = new System.Drawing.Size(172, 21);
            this.combo.TabIndex = 93;
            this.combo.SelectedIndexChanged += new System.EventHandler(this.combo_SelectedIndexChanged);
            // 
            // btnView
            // 
            this.btnView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnView.BackColor = System.Drawing.Color.Maroon;
            this.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnView.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.Location = new System.Drawing.Point(549, 355);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(90, 31);
            this.btnView.TabIndex = 103;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.SystemColors.ControlLight;
            this.dateTimePicker1.Font = new System.Drawing.Font("Poor Richard", 9.75F);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(83, 98);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(172, 22);
            this.dateTimePicker1.TabIndex = 99;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblDate.Font = new System.Drawing.Font("Iskoola Pota", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.White;
            this.lblDate.Location = new System.Drawing.Point(29, 97);
            this.lblDate.Name = "lblDate";
            this.lblDate.Padding = new System.Windows.Forms.Padding(2);
            this.lblDate.Size = new System.Drawing.Size(48, 23);
            this.lblDate.TabIndex = 110;
            this.lblDate.Text = "Date";
            // 
            // txtBasic
            // 
            this.txtBasic.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtBasic.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBasic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtBasic.ForeColor = System.Drawing.Color.Black;
            this.txtBasic.Location = new System.Drawing.Point(284, 194);
            this.txtBasic.Margin = new System.Windows.Forms.Padding(0);
            this.txtBasic.Multiline = true;
            this.txtBasic.Name = "txtBasic";
            this.txtBasic.ReadOnly = true;
            this.txtBasic.Size = new System.Drawing.Size(172, 22);
            this.txtBasic.TabIndex = 94;
            this.txtBasic.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblBasic
            // 
            this.lblBasic.AutoSize = true;
            this.lblBasic.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblBasic.Font = new System.Drawing.Font("Iskoola Pota", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBasic.ForeColor = System.Drawing.Color.White;
            this.lblBasic.Location = new System.Drawing.Point(132, 192);
            this.lblBasic.Name = "lblBasic";
            this.lblBasic.Padding = new System.Windows.Forms.Padding(2);
            this.lblBasic.Size = new System.Drawing.Size(100, 23);
            this.lblBasic.TabIndex = 109;
            this.lblBasic.Text = "Basic Salary";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblTotal.Font = new System.Drawing.Font("Iskoola Pota", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.White;
            this.lblTotal.Location = new System.Drawing.Point(132, 410);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Padding = new System.Windows.Forms.Padding(2);
            this.lblTotal.Size = new System.Drawing.Size(52, 23);
            this.lblTotal.TabIndex = 108;
            this.lblTotal.Text = "Total";
            // 
            // txtTot
            // 
            this.txtTot.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTot.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtTot.Location = new System.Drawing.Point(284, 413);
            this.txtTot.Multiline = true;
            this.txtTot.Name = "txtTot";
            this.txtTot.ReadOnly = true;
            this.txtTot.Size = new System.Drawing.Size(172, 22);
            this.txtTot.TabIndex = 100;
            this.txtTot.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BtnAdd
            // 
            this.BtnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAdd.BackColor = System.Drawing.Color.Maroon;
            this.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnAdd.Font = new System.Drawing.Font("Cambria", 9.75F);
            this.BtnAdd.ForeColor = System.Drawing.Color.White;
            this.BtnAdd.Location = new System.Drawing.Point(549, 246);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(90, 31);
            this.BtnAdd.TabIndex = 101;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.BackColor = System.Drawing.Color.Maroon;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClear.Font = new System.Drawing.Font("Cambria", 9.75F);
            this.btnClear.Location = new System.Drawing.Point(549, 302);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(90, 31);
            this.btnClear.TabIndex = 102;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label4.Location = new System.Drawing.Point(287, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(319, 35);
            this.label4.TabIndex = 107;
            this.label4.Text = "Salary Management";
            // 
            // LBLOT
            // 
            this.LBLOT.AutoSize = true;
            this.LBLOT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LBLOT.Font = new System.Drawing.Font("Iskoola Pota", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLOT.ForeColor = System.Drawing.Color.White;
            this.LBLOT.Location = new System.Drawing.Point(132, 318);
            this.LBLOT.Name = "LBLOT";
            this.LBLOT.Padding = new System.Windows.Forms.Padding(2);
            this.LBLOT.Size = new System.Drawing.Size(87, 23);
            this.LBLOT.TabIndex = 106;
            this.LBLOT.Text = "OT Hours";
            // 
            // lblBonus
            // 
            this.lblBonus.AutoSize = true;
            this.lblBonus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblBonus.Font = new System.Drawing.Font("Iskoola Pota", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBonus.ForeColor = System.Drawing.Color.White;
            this.lblBonus.Location = new System.Drawing.Point(132, 358);
            this.lblBonus.Name = "lblBonus";
            this.lblBonus.Padding = new System.Windows.Forms.Padding(2);
            this.lblBonus.Size = new System.Drawing.Size(58, 23);
            this.lblBonus.TabIndex = 105;
            this.lblBonus.Text = "Bonus";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblID.Font = new System.Drawing.Font("Iskoola Pota", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.Color.White;
            this.lblID.Location = new System.Drawing.Point(132, 153);
            this.lblID.Name = "lblID";
            this.lblID.Padding = new System.Windows.Forms.Padding(2);
            this.lblID.Size = new System.Drawing.Size(108, 23);
            this.lblID.TabIndex = 104;
            this.lblID.Text = "Employee ID";
            // 
            // txtOT
            // 
            this.txtOT.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtOT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtOT.Location = new System.Drawing.Point(284, 319);
            this.txtOT.Margin = new System.Windows.Forms.Padding(0);
            this.txtOT.Multiline = true;
            this.txtOT.Name = "txtOT";
            this.txtOT.Size = new System.Drawing.Size(172, 22);
            this.txtOT.TabIndex = 97;
            this.txtOT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtOT.TextChanged += new System.EventHandler(this.txtOT_TextChanged);
            // 
            // TxtBonus
            // 
            this.TxtBonus.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TxtBonus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtBonus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TxtBonus.ForeColor = System.Drawing.Color.Black;
            this.TxtBonus.Location = new System.Drawing.Point(284, 360);
            this.TxtBonus.Margin = new System.Windows.Forms.Padding(0);
            this.TxtBonus.Multiline = true;
            this.TxtBonus.Name = "TxtBonus";
            this.TxtBonus.Size = new System.Drawing.Size(172, 22);
            this.TxtBonus.TabIndex = 98;
            this.TxtBonus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtBonus.TextChanged += new System.EventHandler(this.TxtBonus_TextChanged);
            // 
            // Salaryform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(690, 457);
            this.Controls.Add(this.labbon);
            this.Controls.Add(this.Edit_details);
            this.Controls.Add(this.btnGreport);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.labot);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtRate);
            this.Controls.Add(this.txtEpf);
            this.Controls.Add(this.Etf);
            this.Controls.Add(this.otRate);
            this.Controls.Add(this.combo);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.txtBasic);
            this.Controls.Add(this.lblBasic);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.txtTot);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LBLOT);
            this.Controls.Add(this.lblBonus);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.txtOT);
            this.Controls.Add(this.TxtBonus);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Salaryform";
            this.Text = "Salaryform";
            this.Load += new System.EventHandler(this.Salaryform_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Salaryform_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderOT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labbon;
        private System.Windows.Forms.ErrorProvider errorProviderOT;
        private System.Windows.Forms.Button Edit_details;
        private System.Windows.Forms.Button btnGreport;
        private System.Windows.Forms.Label Time;
        private System.Windows.Forms.Label labot;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.TextBox txtRate;
        public System.Windows.Forms.TextBox txtEpf;
        private System.Windows.Forms.Label Etf;
        private System.Windows.Forms.Label otRate;
        private System.Windows.Forms.ComboBox combo;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblDate;
        public System.Windows.Forms.TextBox txtBasic;
        private System.Windows.Forms.Label lblBasic;
        private System.Windows.Forms.Label lblTotal;
        public System.Windows.Forms.TextBox txtTot;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LBLOT;
        private System.Windows.Forms.Label lblBonus;
        private System.Windows.Forms.Label lblID;
        public System.Windows.Forms.TextBox txtOT;
        public System.Windows.Forms.TextBox TxtBonus;
        private System.Windows.Forms.Timer timer1;
    }
}