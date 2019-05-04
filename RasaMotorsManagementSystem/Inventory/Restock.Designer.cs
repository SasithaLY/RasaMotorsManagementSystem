namespace RasaMotorsManagementSystem.Inventory
{
    partial class Restock
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
            this.lblID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.labelItem = new System.Windows.Forms.Label();
            this.txtBoxRestockQty = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.txtBoxUnitPrice = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.Color.White;
            this.lblID.Location = new System.Drawing.Point(183, 122);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(43, 20);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(353, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Item Name :";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID.ForeColor = System.Drawing.Color.Red;
            this.labelID.Location = new System.Drawing.Point(232, 122);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(39, 20);
            this.labelID.TabIndex = 2;
            this.labelID.Text = "000";
            // 
            // labelItem
            // 
            this.labelItem.AutoSize = true;
            this.labelItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelItem.ForeColor = System.Drawing.Color.Red;
            this.labelItem.Location = new System.Drawing.Point(474, 122);
            this.labelItem.Name = "labelItem";
            this.labelItem.Size = new System.Drawing.Size(96, 20);
            this.labelItem.TabIndex = 3;
            this.labelItem.Text = "Item Name";
            // 
            // txtBoxRestockQty
            // 
            this.txtBoxRestockQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxRestockQty.Location = new System.Drawing.Point(263, 196);
            this.txtBoxRestockQty.Name = "txtBoxRestockQty";
            this.txtBoxRestockQty.Size = new System.Drawing.Size(99, 26);
            this.txtBoxRestockQty.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(100, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Restock Quantity :";
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAdd.BackColor = System.Drawing.Color.Maroon;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(325, 271);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(103, 40);
            this.btnAdd.TabIndex = 71;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnRestock_Click);
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Rockwell", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(772, 74);
            this.label3.TabIndex = 82;
            this.label3.Text = "Restock Item";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnitPrice.ForeColor = System.Drawing.Color.White;
            this.lblUnitPrice.Location = new System.Drawing.Point(400, 199);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(97, 20);
            this.lblUnitPrice.TabIndex = 84;
            this.lblUnitPrice.Text = "Unit Price :";
            // 
            // txtBoxUnitPrice
            // 
            this.txtBoxUnitPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxUnitPrice.Location = new System.Drawing.Point(503, 196);
            this.txtBoxUnitPrice.Name = "txtBoxUnitPrice";
            this.txtBoxUnitPrice.Size = new System.Drawing.Size(110, 26);
            this.txtBoxUnitPrice.TabIndex = 83;
            // 
            // Restock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(772, 345);
            this.Controls.Add(this.lblUnitPrice);
            this.Controls.Add(this.txtBoxUnitPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBoxRestockQty);
            this.Controls.Add(this.labelItem);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Restock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Restock";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Restock_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxRestockQty;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAdd;
        public System.Windows.Forms.Label labelID;
        public System.Windows.Forms.Label labelItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.TextBox txtBoxUnitPrice;
    }
}