﻿namespace RasaMotorsManagementSystem.Supplier
{
    partial class orderAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(orderAdd));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.ordAmount = new System.Windows.Forms.Label();
            this.ordInType = new System.Windows.Forms.Label();
            this.ordDate = new System.Windows.Forms.Label();
            this.txtSupName = new System.Windows.Forms.TextBox();
            this.ordSupName = new System.Windows.Forms.Label();
            this.orderDate = new System.Windows.Forms.DateTimePicker();
            this.cmbInType = new System.Windows.Forms.ComboBox();
            this.labAmount = new System.Windows.Forms.Label();
            this.labSupName = new System.Windows.Forms.Label();
            this.btnView = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.ordADD = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Goldenrod;
            this.label1.Location = new System.Drawing.Point(491, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(362, 53);
            this.label1.TabIndex = 65;
            this.label1.Text = "Add New Order";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 14);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(215, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 64;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 579);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1021, 41);
            this.panel1.TabIndex = 73;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Black;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Rockwell", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox1.Location = new System.Drawing.Point(510, 16);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(307, 13);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "All right reserved by Valt Pack Software Solutions Company";
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.Location = new System.Drawing.Point(590, 354);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(158, 26);
            this.txtAmount.TabIndex = 79;
            this.txtAmount.TextChanged += new System.EventHandler(this.txtAmount_TextChanged);
            // 
            // ordAmount
            // 
            this.ordAmount.AutoSize = true;
            this.ordAmount.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ordAmount.Location = new System.Drawing.Point(454, 354);
            this.ordAmount.Name = "ordAmount";
            this.ordAmount.Size = new System.Drawing.Size(69, 18);
            this.ordAmount.TabIndex = 78;
            this.ordAmount.Text = "Amount:";
            // 
            // ordInType
            // 
            this.ordInType.AutoSize = true;
            this.ordInType.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ordInType.Location = new System.Drawing.Point(454, 287);
            this.ordInType.Name = "ordInType";
            this.ordInType.Size = new System.Drawing.Size(121, 18);
            this.ordInType.TabIndex = 77;
            this.ordInType.Text = "Inventory Type:";
            // 
            // ordDate
            // 
            this.ordDate.AutoSize = true;
            this.ordDate.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ordDate.Location = new System.Drawing.Point(454, 237);
            this.ordDate.Name = "ordDate";
            this.ordDate.Size = new System.Drawing.Size(95, 18);
            this.ordDate.TabIndex = 76;
            this.ordDate.Text = "Order Date:";
            // 
            // txtSupName
            // 
            this.txtSupName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSupName.Location = new System.Drawing.Point(590, 185);
            this.txtSupName.Multiline = true;
            this.txtSupName.Name = "txtSupName";
            this.txtSupName.Size = new System.Drawing.Size(158, 29);
            this.txtSupName.TabIndex = 75;
            this.txtSupName.TextChanged += new System.EventHandler(this.txtSupName_TextChanged);
            // 
            // ordSupName
            // 
            this.ordSupName.AutoSize = true;
            this.ordSupName.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ordSupName.Location = new System.Drawing.Point(454, 188);
            this.ordSupName.Name = "ordSupName";
            this.ordSupName.Size = new System.Drawing.Size(120, 18);
            this.ordSupName.TabIndex = 74;
            this.ordSupName.Text = "Supplier Name:";
            // 
            // orderDate
            // 
            this.orderDate.CustomFormat = "yyyy-MM-dd";
            this.orderDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.orderDate.Location = new System.Drawing.Point(590, 236);
            this.orderDate.Name = "orderDate";
            this.orderDate.Size = new System.Drawing.Size(158, 22);
            this.orderDate.TabIndex = 81;
            // 
            // cmbInType
            // 
            this.cmbInType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbInType.FormattingEnabled = true;
            this.cmbInType.Items.AddRange(new object[] {
            "Bumper",
            "Keys",
            "Mirror",
            "Head Lamp",
            "Bonnet",
            "Side Panel",
            "Door",
            "Door Handle",
            "Grill",
            "Radiator Support",
            "Seats"});
            this.cmbInType.Location = new System.Drawing.Point(590, 289);
            this.cmbInType.Name = "cmbInType";
            this.cmbInType.Size = new System.Drawing.Size(158, 28);
            this.cmbInType.TabIndex = 80;
            // 
            // labAmount
            // 
            this.labAmount.AutoSize = true;
            this.labAmount.BackColor = System.Drawing.Color.Maroon;
            this.labAmount.Font = new System.Drawing.Font("28 Days Later", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labAmount.ForeColor = System.Drawing.Color.White;
            this.labAmount.Location = new System.Drawing.Point(798, 360);
            this.labAmount.Name = "labAmount";
            this.labAmount.Size = new System.Drawing.Size(123, 20);
            this.labAmount.TabIndex = 89;
            this.labAmount.Text = "Invalid Input";
            this.labAmount.Visible = false;
            // 
            // labSupName
            // 
            this.labSupName.AutoSize = true;
            this.labSupName.BackColor = System.Drawing.Color.Maroon;
            this.labSupName.Font = new System.Drawing.Font("28 Days Later", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSupName.ForeColor = System.Drawing.Color.White;
            this.labSupName.Location = new System.Drawing.Point(798, 194);
            this.labSupName.Name = "labSupName";
            this.labSupName.Size = new System.Drawing.Size(123, 20);
            this.labSupName.TabIndex = 88;
            this.labSupName.Text = "Invalid Input";
            this.labSupName.Visible = false;
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.Color.Maroon;
            this.btnView.Font = new System.Drawing.Font("28 Days Later", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.ForeColor = System.Drawing.Color.White;
            this.btnView.Location = new System.Drawing.Point(725, 526);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(125, 37);
            this.btnView.TabIndex = 93;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Maroon;
            this.btnBack.Font = new System.Drawing.Font("28 Days Later", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(865, 526);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(125, 37);
            this.btnBack.TabIndex = 92;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Maroon;
            this.btnClear.Font = new System.Drawing.Font("28 Days Later", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(488, 525);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(86, 38);
            this.btnClear.TabIndex = 91;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click_1);
            // 
            // ordADD
            // 
            this.ordADD.BackColor = System.Drawing.Color.Maroon;
            this.ordADD.Font = new System.Drawing.Font("28 Days Later", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ordADD.ForeColor = System.Drawing.Color.White;
            this.ordADD.Location = new System.Drawing.Point(396, 525);
            this.ordADD.Name = "ordADD";
            this.ordADD.Size = new System.Drawing.Size(86, 38);
            this.ordADD.TabIndex = 90;
            this.ordADD.Text = "ADD";
            this.ordADD.UseVisualStyleBackColor = false;
            this.ordADD.Click += new System.EventHandler(this.ordADD_Click);
            // 
            // orderAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1021, 620);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.ordADD);
            this.Controls.Add(this.labAmount);
            this.Controls.Add(this.labSupName);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.ordAmount);
            this.Controls.Add(this.ordInType);
            this.Controls.Add(this.ordDate);
            this.Controls.Add(this.txtSupName);
            this.Controls.Add(this.ordSupName);
            this.Controls.Add(this.orderDate);
            this.Controls.Add(this.cmbInType);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "orderAdd";
            this.Text = "orderAdd";
            this.Load += new System.EventHandler(this.order_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label ordAmount;
        private System.Windows.Forms.Label ordInType;
        private System.Windows.Forms.Label ordDate;
        private System.Windows.Forms.TextBox txtSupName;
        private System.Windows.Forms.Label ordSupName;
        private System.Windows.Forms.DateTimePicker orderDate;
        private System.Windows.Forms.ComboBox cmbInType;
        private System.Windows.Forms.Label labAmount;
        private System.Windows.Forms.Label labSupName;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button ordADD;
    }
}