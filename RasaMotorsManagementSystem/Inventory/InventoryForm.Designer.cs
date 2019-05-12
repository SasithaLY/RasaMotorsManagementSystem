namespace RasaMotorsManagementSystem.Inventory
{
    partial class InventoryForm
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
            this.lblErrorQty = new System.Windows.Forms.Label();
            this.lblErrorBuy = new System.Windows.Forms.Label();
            this.lblErrorSell = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddSup = new System.Windows.Forms.Button();
            this.cmbBoxSupplier = new System.Windows.Forms.ComboBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
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
            this.lblInventory = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rASADataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.supplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblErrorMinQty = new System.Windows.Forms.Label();
            this.txtboxMinQty = new System.Windows.Forms.TextBox();
            this.lblMinQty = new System.Windows.Forms.Label();
            this.btnDemo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rASADataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblErrorQty
            // 
            this.lblErrorQty.AutoSize = true;
            this.lblErrorQty.Font = new System.Drawing.Font("Gotham", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorQty.ForeColor = System.Drawing.Color.Red;
            this.lblErrorQty.Location = new System.Drawing.Point(856, 477);
            this.lblErrorQty.Name = "lblErrorQty";
            this.lblErrorQty.Size = new System.Drawing.Size(227, 15);
            this.lblErrorQty.TabIndex = 136;
            this.lblErrorQty.Text = "Invalid Input! Enter Numbers Only";
            this.lblErrorQty.Visible = false;
            // 
            // lblErrorBuy
            // 
            this.lblErrorBuy.AutoSize = true;
            this.lblErrorBuy.Font = new System.Drawing.Font("Gotham", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorBuy.ForeColor = System.Drawing.Color.Red;
            this.lblErrorBuy.Location = new System.Drawing.Point(856, 382);
            this.lblErrorBuy.Name = "lblErrorBuy";
            this.lblErrorBuy.Size = new System.Drawing.Size(167, 15);
            this.lblErrorBuy.TabIndex = 134;
            this.lblErrorBuy.Text = "Invalid Input! Enter Price";
            this.lblErrorBuy.Visible = false;
            // 
            // lblErrorSell
            // 
            this.lblErrorSell.AutoSize = true;
            this.lblErrorSell.Font = new System.Drawing.Font("Gotham", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorSell.ForeColor = System.Drawing.Color.Red;
            this.lblErrorSell.Location = new System.Drawing.Point(856, 431);
            this.lblErrorSell.Name = "lblErrorSell";
            this.lblErrorSell.Size = new System.Drawing.Size(167, 15);
            this.lblErrorSell.TabIndex = 135;
            this.lblErrorSell.Text = "Invalid Input! Enter Price";
            this.lblErrorSell.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Location = new System.Drawing.Point(-16, 169);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1284, 10);
            this.panel1.TabIndex = 133;
            // 
            // btnAddSup
            // 
            this.btnAddSup.BackColor = System.Drawing.Color.Maroon;
            this.btnAddSup.FlatAppearance.BorderSize = 0;
            this.btnAddSup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddSup.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSup.ForeColor = System.Drawing.Color.White;
            this.btnAddSup.Location = new System.Drawing.Point(880, 559);
            this.btnAddSup.Name = "btnAddSup";
            this.btnAddSup.Size = new System.Drawing.Size(166, 32);
            this.btnAddSup.TabIndex = 132;
            this.btnAddSup.Text = "Add New Suplier";
            this.btnAddSup.UseVisualStyleBackColor = false;
            this.btnAddSup.Click += new System.EventHandler(this.btnAddSup_Click_1);
            // 
            // cmbBoxSupplier
            // 
            this.cmbBoxSupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxSupplier.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBoxSupplier.FormattingEnabled = true;
            this.cmbBoxSupplier.Location = new System.Drawing.Point(625, 563);
            this.cmbBoxSupplier.Name = "cmbBoxSupplier";
            this.cmbBoxSupplier.Size = new System.Drawing.Size(215, 27);
            this.cmbBoxSupplier.TabIndex = 131;
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClear.BackColor = System.Drawing.Color.Maroon;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(700, 660);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(103, 40);
            this.btnClear.TabIndex = 129;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAdd.BackColor = System.Drawing.Color.Maroon;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(517, 660);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(103, 40);
            this.btnAdd.TabIndex = 128;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtBoxItemName
            // 
            this.txtBoxItemName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxItemName.Location = new System.Drawing.Point(625, 270);
            this.txtBoxItemName.Name = "txtBoxItemName";
            this.txtBoxItemName.Size = new System.Drawing.Size(215, 27);
            this.txtBoxItemName.TabIndex = 127;
            // 
            // lblItemName
            // 
            this.lblItemName.AutoSize = true;
            this.lblItemName.BackColor = System.Drawing.Color.Transparent;
            this.lblItemName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemName.ForeColor = System.Drawing.Color.White;
            this.lblItemName.Location = new System.Drawing.Point(471, 273);
            this.lblItemName.Name = "lblItemName";
            this.lblItemName.Size = new System.Drawing.Size(96, 19);
            this.lblItemName.TabIndex = 126;
            this.lblItemName.Text = "Item Name";
            // 
            // txtBoxItemType
            // 
            this.txtBoxItemType.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxItemType.Location = new System.Drawing.Point(625, 323);
            this.txtBoxItemType.Name = "txtBoxItemType";
            this.txtBoxItemType.Size = new System.Drawing.Size(215, 27);
            this.txtBoxItemType.TabIndex = 125;
            // 
            // lblItemType
            // 
            this.lblItemType.AutoSize = true;
            this.lblItemType.BackColor = System.Drawing.Color.Transparent;
            this.lblItemType.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemType.ForeColor = System.Drawing.Color.White;
            this.lblItemType.Location = new System.Drawing.Point(471, 326);
            this.lblItemType.Name = "lblItemType";
            this.lblItemType.Size = new System.Drawing.Size(84, 19);
            this.lblItemType.TabIndex = 124;
            this.lblItemType.Text = "Item Type";
            // 
            // txtBoxBuyPrice
            // 
            this.txtBoxBuyPrice.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxBuyPrice.Location = new System.Drawing.Point(625, 375);
            this.txtBoxBuyPrice.Name = "txtBoxBuyPrice";
            this.txtBoxBuyPrice.Size = new System.Drawing.Size(215, 27);
            this.txtBoxBuyPrice.TabIndex = 123;
            this.txtBoxBuyPrice.TextChanged += new System.EventHandler(this.txtBoxBuyPrice_TextChanged);
            // 
            // lblBuyPrice
            // 
            this.lblBuyPrice.AutoSize = true;
            this.lblBuyPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblBuyPrice.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuyPrice.ForeColor = System.Drawing.Color.White;
            this.lblBuyPrice.Location = new System.Drawing.Point(471, 378);
            this.lblBuyPrice.Name = "lblBuyPrice";
            this.lblBuyPrice.Size = new System.Drawing.Size(104, 19);
            this.lblBuyPrice.TabIndex = 122;
            this.lblBuyPrice.Text = "Buying Price";
            // 
            // txtBoxSellPrice
            // 
            this.txtBoxSellPrice.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxSellPrice.Location = new System.Drawing.Point(625, 424);
            this.txtBoxSellPrice.Name = "txtBoxSellPrice";
            this.txtBoxSellPrice.Size = new System.Drawing.Size(215, 27);
            this.txtBoxSellPrice.TabIndex = 121;
            this.txtBoxSellPrice.TextChanged += new System.EventHandler(this.txtBoxSellPrice_TextChanged);
            // 
            // lblSellPrice
            // 
            this.lblSellPrice.AutoSize = true;
            this.lblSellPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblSellPrice.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSellPrice.ForeColor = System.Drawing.Color.White;
            this.lblSellPrice.Location = new System.Drawing.Point(471, 427);
            this.lblSellPrice.Name = "lblSellPrice";
            this.lblSellPrice.Size = new System.Drawing.Size(102, 19);
            this.lblSellPrice.TabIndex = 120;
            this.lblSellPrice.Text = "Selling Price";
            // 
            // txtBoxQnt
            // 
            this.txtBoxQnt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxQnt.Location = new System.Drawing.Point(625, 470);
            this.txtBoxQnt.Name = "txtBoxQnt";
            this.txtBoxQnt.Size = new System.Drawing.Size(215, 27);
            this.txtBoxQnt.TabIndex = 119;
            this.txtBoxQnt.TextChanged += new System.EventHandler(this.txtBoxQnt_TextChanged);
            // 
            // lblQnt
            // 
            this.lblQnt.AutoSize = true;
            this.lblQnt.BackColor = System.Drawing.Color.Transparent;
            this.lblQnt.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQnt.ForeColor = System.Drawing.Color.White;
            this.lblQnt.Location = new System.Drawing.Point(471, 473);
            this.lblQnt.Name = "lblQnt";
            this.lblQnt.Size = new System.Drawing.Size(74, 19);
            this.lblQnt.TabIndex = 118;
            this.lblQnt.Text = "Quantity";
            // 
            // lblSupplier
            // 
            this.lblSupplier.AutoSize = true;
            this.lblSupplier.BackColor = System.Drawing.Color.Transparent;
            this.lblSupplier.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplier.ForeColor = System.Drawing.Color.White;
            this.lblSupplier.Location = new System.Drawing.Point(471, 566);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(72, 19);
            this.lblSupplier.TabIndex = 117;
            this.lblSupplier.Text = "Supplier";
            // 
            // txtBoxItemID
            // 
            this.txtBoxItemID.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxItemID.Location = new System.Drawing.Point(625, 223);
            this.txtBoxItemID.Name = "txtBoxItemID";
            this.txtBoxItemID.ReadOnly = true;
            this.txtBoxItemID.Size = new System.Drawing.Size(215, 27);
            this.txtBoxItemID.TabIndex = 116;
            this.txtBoxItemID.Visible = false;
            // 
            // lblItemId
            // 
            this.lblItemId.AutoSize = true;
            this.lblItemId.BackColor = System.Drawing.Color.Transparent;
            this.lblItemId.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemId.ForeColor = System.Drawing.Color.White;
            this.lblItemId.Location = new System.Drawing.Point(471, 226);
            this.lblItemId.Name = "lblItemId";
            this.lblItemId.Size = new System.Drawing.Size(62, 19);
            this.lblItemId.TabIndex = 115;
            this.lblItemId.Text = "Item ID";
            this.lblItemId.Visible = false;
            // 
            // lblInventory
            // 
            this.lblInventory.BackColor = System.Drawing.Color.Transparent;
            this.lblInventory.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblInventory.Font = new System.Drawing.Font("Rockwell", 45F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInventory.ForeColor = System.Drawing.Color.White;
            this.lblInventory.Location = new System.Drawing.Point(0, 0);
            this.lblInventory.Name = "lblInventory";
            this.lblInventory.Size = new System.Drawing.Size(1264, 166);
            this.lblInventory.TabIndex = 130;
            this.lblInventory.Text = "Add New Item";
            this.lblInventory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::RasaMotorsManagementSystem.Properties.Resources.Rasa_Motors_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(38, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(228, 101);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 114;
            this.pictureBox1.TabStop = false;
            // 
            // supplierBindingSource
            // 
            this.supplierBindingSource.DataMember = "supplier";
            // 
            // lblErrorMinQty
            // 
            this.lblErrorMinQty.AutoSize = true;
            this.lblErrorMinQty.Font = new System.Drawing.Font("Gotham", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorMinQty.ForeColor = System.Drawing.Color.Red;
            this.lblErrorMinQty.Location = new System.Drawing.Point(856, 523);
            this.lblErrorMinQty.Name = "lblErrorMinQty";
            this.lblErrorMinQty.Size = new System.Drawing.Size(227, 15);
            this.lblErrorMinQty.TabIndex = 139;
            this.lblErrorMinQty.Text = "Invalid Input! Enter Numbers Only";
            this.lblErrorMinQty.Visible = false;
            this.lblErrorMinQty.Click += new System.EventHandler(this.lblErrorMinQty_Click);
            // 
            // txtboxMinQty
            // 
            this.txtboxMinQty.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxMinQty.Location = new System.Drawing.Point(625, 516);
            this.txtboxMinQty.Name = "txtboxMinQty";
            this.txtboxMinQty.Size = new System.Drawing.Size(215, 27);
            this.txtboxMinQty.TabIndex = 138;
            // 
            // lblMinQty
            // 
            this.lblMinQty.AutoSize = true;
            this.lblMinQty.BackColor = System.Drawing.Color.Transparent;
            this.lblMinQty.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinQty.ForeColor = System.Drawing.Color.White;
            this.lblMinQty.Location = new System.Drawing.Point(471, 519);
            this.lblMinQty.Name = "lblMinQty";
            this.lblMinQty.Size = new System.Drawing.Size(110, 19);
            this.lblMinQty.TabIndex = 137;
            this.lblMinQty.Text = "Min. Quantity";
            // 
            // btnDemo
            // 
            this.btnDemo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDemo.BackColor = System.Drawing.Color.Maroon;
            this.btnDemo.FlatAppearance.BorderSize = 0;
            this.btnDemo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDemo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDemo.ForeColor = System.Drawing.Color.White;
            this.btnDemo.Location = new System.Drawing.Point(890, 660);
            this.btnDemo.Name = "btnDemo";
            this.btnDemo.Size = new System.Drawing.Size(103, 40);
            this.btnDemo.TabIndex = 140;
            this.btnDemo.Text = "DEMO";
            this.btnDemo.UseVisualStyleBackColor = false;
            // 
            // InventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(1264, 750);
            this.Controls.Add(this.btnDemo);
            this.Controls.Add(this.lblErrorMinQty);
            this.Controls.Add(this.txtboxMinQty);
            this.Controls.Add(this.lblMinQty);
            this.Controls.Add(this.lblErrorQty);
            this.Controls.Add(this.lblErrorBuy);
            this.Controls.Add(this.lblErrorSell);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAddSup);
            this.Controls.Add(this.cmbBoxSupplier);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAdd);
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
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblInventory);
            this.Name = "InventoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InventoryForm";
            this.Activated += new System.EventHandler(this.InventoryForm_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.InventoryForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rASADataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblErrorQty;
        private System.Windows.Forms.Label lblErrorBuy;
        private System.Windows.Forms.BindingSource rASADataSetBindingSource;
        private System.Windows.Forms.BindingSource supplierBindingSource;
        private System.Windows.Forms.Label lblErrorSell;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAddSup;
        private System.Windows.Forms.ComboBox cmbBoxSupplier;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtBoxItemName;
        private System.Windows.Forms.Label lblItemName;
        private System.Windows.Forms.TextBox txtBoxItemType;
        private System.Windows.Forms.Label lblItemType;
        private System.Windows.Forms.TextBox txtBoxBuyPrice;
        private System.Windows.Forms.Label lblBuyPrice;
        private System.Windows.Forms.TextBox txtBoxSellPrice;
        private System.Windows.Forms.Label lblSellPrice;
        private System.Windows.Forms.TextBox txtBoxQnt;
        private System.Windows.Forms.Label lblQnt;
        private System.Windows.Forms.Label lblSupplier;
        private System.Windows.Forms.TextBox txtBoxItemID;
        private System.Windows.Forms.Label lblItemId;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblInventory;
        private System.Windows.Forms.Label lblErrorMinQty;
        private System.Windows.Forms.TextBox txtboxMinQty;
        private System.Windows.Forms.Label lblMinQty;
        private System.Windows.Forms.Button btnDemo;
    }
}