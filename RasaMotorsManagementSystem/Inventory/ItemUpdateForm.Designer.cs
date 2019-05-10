namespace RasaMotorsManagementSystem.Inventory
{
    partial class ItemUpdateForm
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
            this.lblErrorQty = new System.Windows.Forms.Label();
            this.lblErrorSell = new System.Windows.Forms.Label();
            this.lblErrorBuy = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddSup = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblUpdateItem = new System.Windows.Forms.Label();
            this.cmbBoxSupplier = new System.Windows.Forms.ComboBox();
            this.txtBoxItemName = new System.Windows.Forms.TextBox();
            this.lblItemName = new System.Windows.Forms.Label();
            this.txtBoxItemType = new System.Windows.Forms.TextBox();
            this.lblItemType = new System.Windows.Forms.Label();
            this.txtBoxBuyPrice = new System.Windows.Forms.TextBox();
            this.lblBuyPrice = new System.Windows.Forms.Label();
            this.txtBoxSellPrice = new System.Windows.Forms.TextBox();
            this.lblSellPrice = new System.Windows.Forms.Label();
            this.txtBoxQnt = new System.Windows.Forms.TextBox();
            this.lblQnt = new System.Windows.Forms.Label();
            this.lblSupplier = new System.Windows.Forms.Label();
            this.txtBoxItemID = new System.Windows.Forms.TextBox();
            this.lblItemId = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblErrorMinQty = new System.Windows.Forms.Label();
            this.txtboxMinQty = new System.Windows.Forms.TextBox();
            this.lblMinQty = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblErrorQty
            // 
            this.lblErrorQty.AutoSize = true;
            this.lblErrorQty.Font = new System.Drawing.Font("Gotham", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorQty.ForeColor = System.Drawing.Color.Red;
            this.lblErrorQty.Location = new System.Drawing.Point(854, 445);
            this.lblErrorQty.Name = "lblErrorQty";
            this.lblErrorQty.Size = new System.Drawing.Size(227, 15);
            this.lblErrorQty.TabIndex = 134;
            this.lblErrorQty.Text = "Invalid Input! Enter Numbers Only";
            this.lblErrorQty.Visible = false;
            // 
            // lblErrorSell
            // 
            this.lblErrorSell.AutoSize = true;
            this.lblErrorSell.Font = new System.Drawing.Font("Gotham", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorSell.ForeColor = System.Drawing.Color.Red;
            this.lblErrorSell.Location = new System.Drawing.Point(854, 399);
            this.lblErrorSell.Name = "lblErrorSell";
            this.lblErrorSell.Size = new System.Drawing.Size(167, 15);
            this.lblErrorSell.TabIndex = 133;
            this.lblErrorSell.Text = "Invalid Input! Enter Price";
            this.lblErrorSell.Visible = false;
            // 
            // lblErrorBuy
            // 
            this.lblErrorBuy.AutoSize = true;
            this.lblErrorBuy.Font = new System.Drawing.Font("Gotham", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorBuy.ForeColor = System.Drawing.Color.Red;
            this.lblErrorBuy.Location = new System.Drawing.Point(854, 350);
            this.lblErrorBuy.Name = "lblErrorBuy";
            this.lblErrorBuy.Size = new System.Drawing.Size(167, 15);
            this.lblErrorBuy.TabIndex = 132;
            this.lblErrorBuy.Text = "Invalid Input! Enter Price";
            this.lblErrorBuy.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Location = new System.Drawing.Point(-2, 137);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1278, 10);
            this.panel1.TabIndex = 131;
            // 
            // btnAddSup
            // 
            this.btnAddSup.BackColor = System.Drawing.Color.Maroon;
            this.btnAddSup.FlatAppearance.BorderSize = 0;
            this.btnAddSup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSup.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSup.ForeColor = System.Drawing.Color.White;
            this.btnAddSup.Location = new System.Drawing.Point(867, 534);
            this.btnAddSup.Name = "btnAddSup";
            this.btnAddSup.Size = new System.Drawing.Size(154, 32);
            this.btnAddSup.TabIndex = 129;
            this.btnAddSup.Text = "Add New Suplier";
            this.btnAddSup.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Maroon;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(726, 644);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(103, 40);
            this.btnClear.TabIndex = 128;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.Maroon;
            this.btnRemove.FlatAppearance.BorderSize = 0;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.Color.White;
            this.btnRemove.Location = new System.Drawing.Point(585, 644);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(103, 40);
            this.btnRemove.TabIndex = 127;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Maroon;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(446, 644);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(103, 40);
            this.btnUpdate.TabIndex = 126;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblUpdateItem
            // 
            this.lblUpdateItem.BackColor = System.Drawing.Color.Transparent;
            this.lblUpdateItem.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblUpdateItem.Font = new System.Drawing.Font("Rockwell", 45F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateItem.ForeColor = System.Drawing.Color.White;
            this.lblUpdateItem.Location = new System.Drawing.Point(0, 0);
            this.lblUpdateItem.Name = "lblUpdateItem";
            this.lblUpdateItem.Size = new System.Drawing.Size(1275, 134);
            this.lblUpdateItem.TabIndex = 125;
            this.lblUpdateItem.Text = "Update Item";
            this.lblUpdateItem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbBoxSupplier
            // 
            this.cmbBoxSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBoxSupplier.FormattingEnabled = true;
            this.cmbBoxSupplier.Location = new System.Drawing.Point(582, 538);
            this.cmbBoxSupplier.Name = "cmbBoxSupplier";
            this.cmbBoxSupplier.Size = new System.Drawing.Size(257, 28);
            this.cmbBoxSupplier.TabIndex = 124;
            // 
            // txtBoxItemName
            // 
            this.txtBoxItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxItemName.Location = new System.Drawing.Point(582, 238);
            this.txtBoxItemName.Name = "txtBoxItemName";
            this.txtBoxItemName.Size = new System.Drawing.Size(257, 26);
            this.txtBoxItemName.TabIndex = 123;
            // 
            // lblItemName
            // 
            this.lblItemName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblItemName.AutoSize = true;
            this.lblItemName.BackColor = System.Drawing.Color.Transparent;
            this.lblItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemName.ForeColor = System.Drawing.Color.White;
            this.lblItemName.Location = new System.Drawing.Point(428, 241);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(96, 20);
            this.lblItemName.TabIndex = 122;
            this.lblItemName.Text = "Item Name";
            // 
            // txtBoxItemType
            // 
            this.txtBoxItemType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxItemType.Location = new System.Drawing.Point(582, 291);
            this.txtBoxItemType.Name = "txtBoxItemType";
            this.txtBoxItemType.Size = new System.Drawing.Size(257, 26);
            this.txtBoxItemType.TabIndex = 121;
            // 
            // lblItemType
            // 
            this.lblItemType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblItemType.AutoSize = true;
            this.lblItemType.BackColor = System.Drawing.Color.Transparent;
            this.lblItemType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemType.ForeColor = System.Drawing.Color.White;
            this.lblItemType.Location = new System.Drawing.Point(428, 294);
            this.lblItemType.Name = "lblItemType";
            this.lblItemType.Size = new System.Drawing.Size(88, 20);
            this.lblItemType.TabIndex = 120;
            this.lblItemType.Text = "Item Type";
            // 
            // txtBoxBuyPrice
            // 
            this.txtBoxBuyPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxBuyPrice.Location = new System.Drawing.Point(582, 343);
            this.txtBoxBuyPrice.Name = "txtBoxBuyPrice";
            this.txtBoxBuyPrice.Size = new System.Drawing.Size(257, 26);
            this.txtBoxBuyPrice.TabIndex = 119;
            this.txtBoxBuyPrice.TextChanged += new System.EventHandler(this.txtBoxBuyPrice_TextChanged);
            // 
            // lblBuyPrice
            // 
            this.lblBuyPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBuyPrice.AutoSize = true;
            this.lblBuyPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblBuyPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuyPrice.ForeColor = System.Drawing.Color.White;
            this.lblBuyPrice.Location = new System.Drawing.Point(428, 346);
            this.lblBuyPrice.Name = "lblBuyPrice";
            this.lblBuyPrice.Size = new System.Drawing.Size(108, 20);
            this.lblBuyPrice.TabIndex = 118;
            this.lblBuyPrice.Text = "Buying Price";
            // 
            // txtBoxSellPrice
            // 
            this.txtBoxSellPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxSellPrice.Location = new System.Drawing.Point(582, 392);
            this.txtBoxSellPrice.Name = "txtBoxSellPrice";
            this.txtBoxSellPrice.Size = new System.Drawing.Size(257, 26);
            this.txtBoxSellPrice.TabIndex = 117;
            this.txtBoxSellPrice.TextChanged += new System.EventHandler(this.txtBoxSellPrice_TextChanged);
            // 
            // lblSellPrice
            // 
            this.lblSellPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSellPrice.AutoSize = true;
            this.lblSellPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblSellPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSellPrice.ForeColor = System.Drawing.Color.White;
            this.lblSellPrice.Location = new System.Drawing.Point(428, 395);
            this.lblSellPrice.Name = "lblSellPrice";
            this.lblSellPrice.Size = new System.Drawing.Size(108, 20);
            this.lblSellPrice.TabIndex = 116;
            this.lblSellPrice.Text = "Selling Price";
            // 
            // txtBoxQnt
            // 
            this.txtBoxQnt.Enabled = false;
            this.txtBoxQnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxQnt.Location = new System.Drawing.Point(582, 438);
            this.txtBoxQnt.Name = "txtBoxQnt";
            this.txtBoxQnt.ReadOnly = true;
            this.txtBoxQnt.Size = new System.Drawing.Size(257, 26);
            this.txtBoxQnt.TabIndex = 115;
            this.txtBoxQnt.TextChanged += new System.EventHandler(this.txtBoxQnt_TextChanged);
            // 
            // lblQnt
            // 
            this.lblQnt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblQnt.AutoSize = true;
            this.lblQnt.BackColor = System.Drawing.Color.Transparent;
            this.lblQnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQnt.ForeColor = System.Drawing.Color.White;
            this.lblQnt.Location = new System.Drawing.Point(428, 441);
            this.lblQnt.Name = "lblQnt";
            this.lblQnt.Size = new System.Drawing.Size(76, 20);
            this.lblQnt.TabIndex = 114;
            this.lblQnt.Text = "Quantity";
            // 
            // lblSupplier
            // 
            this.lblSupplier.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSupplier.AutoSize = true;
            this.lblSupplier.BackColor = System.Drawing.Color.Transparent;
            this.lblSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplier.ForeColor = System.Drawing.Color.White;
            this.lblSupplier.Location = new System.Drawing.Point(428, 541);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(75, 20);
            this.lblSupplier.TabIndex = 113;
            this.lblSupplier.Text = "Supplier";
            // 
            // txtBoxItemID
            // 
            this.txtBoxItemID.Enabled = false;
            this.txtBoxItemID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxItemID.Location = new System.Drawing.Point(582, 191);
            this.txtBoxItemID.Name = "txtBoxItemID";
            this.txtBoxItemID.ReadOnly = true;
            this.txtBoxItemID.Size = new System.Drawing.Size(257, 26);
            this.txtBoxItemID.TabIndex = 112;
            // 
            // lblItemId
            // 
            this.lblItemId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblItemId.AutoSize = true;
            this.lblItemId.BackColor = System.Drawing.Color.Transparent;
            this.lblItemId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemId.ForeColor = System.Drawing.Color.White;
            this.lblItemId.Location = new System.Drawing.Point(428, 194);
            this.lblItemId.Name = "lblItemId";
            this.lblItemId.Size = new System.Drawing.Size(69, 20);
            this.lblItemId.TabIndex = 111;
            this.lblItemId.Text = "Item ID";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::RasaMotorsManagementSystem.Properties.Resources.Rasa_Motors_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(63, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(216, 104);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 130;
            this.pictureBox1.TabStop = false;
            // 
            // lblErrorMinQty
            // 
            this.lblErrorMinQty.AutoSize = true;
            this.lblErrorMinQty.Font = new System.Drawing.Font("Gotham", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorMinQty.ForeColor = System.Drawing.Color.Red;
            this.lblErrorMinQty.Location = new System.Drawing.Point(854, 495);
            this.lblErrorMinQty.Name = "lblErrorMinQty";
            this.lblErrorMinQty.Size = new System.Drawing.Size(227, 15);
            this.lblErrorMinQty.TabIndex = 142;
            this.lblErrorMinQty.Text = "Invalid Input! Enter Numbers Only";
            this.lblErrorMinQty.Visible = false;
            // 
            // txtboxMinQty
            // 
            this.txtboxMinQty.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxMinQty.Location = new System.Drawing.Point(582, 488);
            this.txtboxMinQty.Name = "txtboxMinQty";
            this.txtboxMinQty.Size = new System.Drawing.Size(257, 27);
            this.txtboxMinQty.TabIndex = 141;
            this.txtboxMinQty.TextChanged += new System.EventHandler(this.txtboxMinQty_TextChanged);
            // 
            // lblMinQty
            // 
            this.lblMinQty.AutoSize = true;
            this.lblMinQty.BackColor = System.Drawing.Color.Transparent;
            this.lblMinQty.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinQty.ForeColor = System.Drawing.Color.White;
            this.lblMinQty.Location = new System.Drawing.Point(428, 491);
            this.lblMinQty.Name = "lblMinQty";
            this.lblMinQty.Size = new System.Drawing.Size(110, 19);
            this.lblMinQty.TabIndex = 140;
            this.lblMinQty.Text = "Min. Quantity";
            // 
            // ItemUpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(1275, 758);
            this.Controls.Add(this.lblErrorMinQty);
            this.Controls.Add(this.txtboxMinQty);
            this.Controls.Add(this.lblMinQty);
            this.Controls.Add(this.lblErrorQty);
            this.Controls.Add(this.lblErrorSell);
            this.Controls.Add(this.lblErrorBuy);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnAddSup);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblUpdateItem);
            this.Controls.Add(this.cmbBoxSupplier);
            this.Controls.Add(this.txtBoxItemName);
            this.Controls.Add(this.lblItemName);
            this.Controls.Add(this.txtBoxItemType);
            this.Controls.Add(this.lblItemType);
            this.Controls.Add(this.txtBoxBuyPrice);
            this.Controls.Add(this.lblBuyPrice);
            this.Controls.Add(this.txtBoxSellPrice);
            this.Controls.Add(this.lblSellPrice);
            this.Controls.Add(this.txtBoxQnt);
            this.Controls.Add(this.lblQnt);
            this.Controls.Add(this.lblSupplier);
            this.Controls.Add(this.txtBoxItemID);
            this.Controls.Add(this.lblItemId);
            this.Name = "ItemUpdateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ItemUpdateForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ItemUpdateForm_FormClosed);
            this.Load += new System.EventHandler(this.ItemUpdateForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblErrorQty;
        private System.Windows.Forms.Label lblErrorSell;
        private System.Windows.Forms.Label lblErrorBuy;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAddSup;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblUpdateItem;
        public System.Windows.Forms.ComboBox cmbBoxSupplier;
        public System.Windows.Forms.TextBox txtBoxItemName;
        private System.Windows.Forms.Label lblItemName;
        public System.Windows.Forms.TextBox txtBoxItemType;
        private System.Windows.Forms.Label lblItemType;
        public System.Windows.Forms.TextBox txtBoxBuyPrice;
        private System.Windows.Forms.Label lblBuyPrice;
        public System.Windows.Forms.TextBox txtBoxSellPrice;
        private System.Windows.Forms.Label lblSellPrice;
        public System.Windows.Forms.TextBox txtBoxQnt;
        private System.Windows.Forms.Label lblQnt;
        private System.Windows.Forms.Label lblSupplier;
        public System.Windows.Forms.TextBox txtBoxItemID;
        private System.Windows.Forms.Label lblItemId;
        private System.Windows.Forms.Label lblErrorMinQty;
        private System.Windows.Forms.Label lblMinQty;
        public System.Windows.Forms.TextBox txtboxMinQty;
    }
}