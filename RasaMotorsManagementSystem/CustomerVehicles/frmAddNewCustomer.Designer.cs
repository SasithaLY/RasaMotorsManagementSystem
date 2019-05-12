namespace RasaMotorsManagementSystem.CustomerVehicles
{
    partial class frmAddNewCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddNewCustomer));
            this.logoAddCus = new System.Windows.Forms.PictureBox();
            this.pnlmidAddCus = new System.Windows.Forms.Panel();
            this.headAddCus = new System.Windows.Forms.Label();
            this.lblMailError = new System.Windows.Forms.Label();
            this.lblPhoneError = new System.Windows.Forms.Label();
            this.lblAddressError = new System.Windows.Forms.Label();
            this.lblNicError = new System.Windows.Forms.Label();
            this.lblNameError = new System.Windows.Forms.Label();
            this.btnAddCusClear = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblGender = new System.Windows.Forms.Label();
            this.comboBoxGender = new System.Windows.Forms.ComboBox();
            this.textBoxMail = new System.Windows.Forms.TextBox();
            this.lblMail = new System.Windows.Forms.Label();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.textBoxNIC = new System.Windows.Forms.TextBox();
            this.lblNIC = new System.Windows.Forms.Label();
            this.TextBoxName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.btnAddCusBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.logoAddCus)).BeginInit();
            this.SuspendLayout();
            // 
            // logoAddCus
            // 
            this.logoAddCus.BackColor = System.Drawing.Color.Transparent;
            this.logoAddCus.Image = ((System.Drawing.Image)(resources.GetObject("logoAddCus.Image")));
            this.logoAddCus.Location = new System.Drawing.Point(12, 12);
            this.logoAddCus.Name = "logoAddCus";
            this.logoAddCus.Size = new System.Drawing.Size(228, 101);
            this.logoAddCus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoAddCus.TabIndex = 140;
            this.logoAddCus.TabStop = false;
            // 
            // pnlmidAddCus
            // 
            this.pnlmidAddCus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlmidAddCus.BackColor = System.Drawing.Color.Maroon;
            this.pnlmidAddCus.Location = new System.Drawing.Point(-27, 124);
            this.pnlmidAddCus.Name = "pnlmidAddCus";
            this.pnlmidAddCus.Size = new System.Drawing.Size(2480, 10);
            this.pnlmidAddCus.TabIndex = 139;
            // 
            // headAddCus
            // 
            this.headAddCus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.headAddCus.AutoSize = true;
            this.headAddCus.Font = new System.Drawing.Font("Rockwell", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headAddCus.ForeColor = System.Drawing.Color.White;
            this.headAddCus.Location = new System.Drawing.Point(335, 23);
            this.headAddCus.Name = "headAddCus";
            this.headAddCus.Size = new System.Drawing.Size(641, 77);
            this.headAddCus.TabIndex = 138;
            this.headAddCus.Text = "Add New Customer";
            // 
            // lblMailError
            // 
            this.lblMailError.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblMailError.AutoSize = true;
            this.lblMailError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMailError.ForeColor = System.Drawing.Color.Red;
            this.lblMailError.Location = new System.Drawing.Point(919, 392);
            this.lblMailError.Name = "lblMailError";
            this.lblMailError.Size = new System.Drawing.Size(155, 16);
            this.lblMailError.TabIndex = 137;
            this.lblMailError.Text = "Invalid E-Mail. Try Again!";
            this.lblMailError.Visible = false;
            // 
            // lblPhoneError
            // 
            this.lblPhoneError.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblPhoneError.AutoSize = true;
            this.lblPhoneError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneError.ForeColor = System.Drawing.Color.Red;
            this.lblPhoneError.Location = new System.Drawing.Point(919, 344);
            this.lblPhoneError.Name = "lblPhoneError";
            this.lblPhoneError.Size = new System.Drawing.Size(207, 16);
            this.lblPhoneError.TabIndex = 136;
            this.lblPhoneError.Text = "Invalid Phone Number. Try Again!";
            this.lblPhoneError.Visible = false;
            // 
            // lblAddressError
            // 
            this.lblAddressError.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblAddressError.AutoSize = true;
            this.lblAddressError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddressError.ForeColor = System.Drawing.Color.Red;
            this.lblAddressError.Location = new System.Drawing.Point(919, 294);
            this.lblAddressError.Name = "lblAddressError";
            this.lblAddressError.Size = new System.Drawing.Size(168, 16);
            this.lblAddressError.TabIndex = 135;
            this.lblAddressError.Text = "Invalid Address. Try Again!";
            this.lblAddressError.Visible = false;
            // 
            // lblNicError
            // 
            this.lblNicError.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblNicError.AutoSize = true;
            this.lblNicError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNicError.ForeColor = System.Drawing.Color.Red;
            this.lblNicError.Location = new System.Drawing.Point(919, 249);
            this.lblNicError.Name = "lblNicError";
            this.lblNicError.Size = new System.Drawing.Size(139, 16);
            this.lblNicError.TabIndex = 134;
            this.lblNicError.Text = "Invalid NIC. Try Again!";
            this.lblNicError.Visible = false;
            // 
            // lblNameError
            // 
            this.lblNameError.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblNameError.AutoSize = true;
            this.lblNameError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameError.ForeColor = System.Drawing.Color.Red;
            this.lblNameError.Location = new System.Drawing.Point(919, 203);
            this.lblNameError.Name = "lblNameError";
            this.lblNameError.Size = new System.Drawing.Size(154, 16);
            this.lblNameError.TabIndex = 133;
            this.lblNameError.Text = "Invalid Name. Try Again!";
            this.lblNameError.Visible = false;
            // 
            // btnAddCusClear
            // 
            this.btnAddCusClear.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnAddCusClear.BackColor = System.Drawing.Color.Maroon;
            this.btnAddCusClear.FlatAppearance.BorderSize = 0;
            this.btnAddCusClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCusClear.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCusClear.ForeColor = System.Drawing.Color.White;
            this.btnAddCusClear.Location = new System.Drawing.Point(348, 511);
            this.btnAddCusClear.Name = "btnAddCusClear";
            this.btnAddCusClear.Size = new System.Drawing.Size(82, 32);
            this.btnAddCusClear.TabIndex = 132;
            this.btnAddCusClear.Text = "Clear";
            this.btnAddCusClear.UseVisualStyleBackColor = false;
            this.btnAddCusClear.Click += new System.EventHandler(this.btnAddCusClear_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.BackColor = System.Drawing.Color.Maroon;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(604, 511);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(154, 32);
            this.btnAdd.TabIndex = 131;
            this.btnAdd.Text = "Add Customer";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblGender
            // 
            this.lblGender.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.ForeColor = System.Drawing.Color.White;
            this.lblGender.Location = new System.Drawing.Point(344, 446);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(69, 20);
            this.lblGender.TabIndex = 130;
            this.lblGender.Text = "Gender";
            // 
            // comboBoxGender
            // 
            this.comboBoxGender.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxGender.ForeColor = System.Drawing.Color.Black;
            this.comboBoxGender.FormattingEnabled = true;
            this.comboBoxGender.Items.AddRange(new object[] {
            "Female",
            "Male"});
            this.comboBoxGender.Location = new System.Drawing.Point(498, 444);
            this.comboBoxGender.Name = "comboBoxGender";
            this.comboBoxGender.Size = new System.Drawing.Size(414, 28);
            this.comboBoxGender.Sorted = true;
            this.comboBoxGender.TabIndex = 129;
            // 
            // textBoxMail
            // 
            this.textBoxMail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMail.ForeColor = System.Drawing.Color.Gray;
            this.textBoxMail.Location = new System.Drawing.Point(500, 386);
            this.textBoxMail.Name = "textBoxMail";
            this.textBoxMail.Size = new System.Drawing.Size(414, 26);
            this.textBoxMail.TabIndex = 128;
            this.textBoxMail.Text = "rasamotors@gmail.com";
            this.textBoxMail.TextChanged += new System.EventHandler(this.textBoxMail_TextChanged);
            this.textBoxMail.Enter += new System.EventHandler(this.textBoxMail_Enter);
            this.textBoxMail.Leave += new System.EventHandler(this.textBoxMail_Leave);
            // 
            // lblMail
            // 
            this.lblMail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMail.AutoSize = true;
            this.lblMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMail.ForeColor = System.Drawing.Color.White;
            this.lblMail.Location = new System.Drawing.Point(344, 393);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(69, 20);
            this.lblMail.TabIndex = 127;
            this.lblMail.Text = "E - mail";
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPhone.ForeColor = System.Drawing.Color.Gray;
            this.textBoxPhone.Location = new System.Drawing.Point(500, 338);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(414, 26);
            this.textBoxPhone.TabIndex = 126;
            this.textBoxPhone.Text = "0771234567";
            this.textBoxPhone.TextChanged += new System.EventHandler(this.textBoxPhone_TextChanged);
            this.textBoxPhone.Enter += new System.EventHandler(this.textBoxPhone_Enter);
            this.textBoxPhone.Leave += new System.EventHandler(this.textBoxPhone_Leave);
            // 
            // lblPhone
            // 
            this.lblPhone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.ForeColor = System.Drawing.Color.White;
            this.lblPhone.Location = new System.Drawing.Point(344, 345);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(127, 20);
            this.lblPhone.TabIndex = 125;
            this.lblPhone.Text = "Phone Number";
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAddress.ForeColor = System.Drawing.Color.Gray;
            this.textBoxAddress.Location = new System.Drawing.Point(500, 288);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(414, 26);
            this.textBoxAddress.TabIndex = 124;
            this.textBoxAddress.Text = "15, New Kandy Road, Kothalawala";
            this.textBoxAddress.TextChanged += new System.EventHandler(this.textBoxAddress_TextChanged);
            this.textBoxAddress.Enter += new System.EventHandler(this.textBoxAddress_Enter);
            this.textBoxAddress.Leave += new System.EventHandler(this.textBoxAddress_Leave);
            // 
            // lblAddress
            // 
            this.lblAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.ForeColor = System.Drawing.Color.White;
            this.lblAddress.Location = new System.Drawing.Point(344, 295);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(75, 20);
            this.lblAddress.TabIndex = 123;
            this.lblAddress.Text = "Address";
            // 
            // textBoxNIC
            // 
            this.textBoxNIC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNIC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNIC.ForeColor = System.Drawing.Color.Gray;
            this.textBoxNIC.Location = new System.Drawing.Point(500, 243);
            this.textBoxNIC.Name = "textBoxNIC";
            this.textBoxNIC.Size = new System.Drawing.Size(414, 26);
            this.textBoxNIC.TabIndex = 122;
            this.textBoxNIC.Text = "123456789v";
            this.textBoxNIC.TextChanged += new System.EventHandler(this.textBoxNIC_TextChanged);
            this.textBoxNIC.Enter += new System.EventHandler(this.textBoxNIC_Enter);
            this.textBoxNIC.Leave += new System.EventHandler(this.textBoxNIC_Leave);
            // 
            // lblNIC
            // 
            this.lblNIC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNIC.AutoSize = true;
            this.lblNIC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNIC.ForeColor = System.Drawing.Color.White;
            this.lblNIC.Location = new System.Drawing.Point(344, 250);
            this.lblNIC.Name = "lblNIC";
            this.lblNIC.Size = new System.Drawing.Size(39, 20);
            this.lblNIC.TabIndex = 121;
            this.lblNIC.Text = "NIC";
            // 
            // TextBoxName
            // 
            this.TextBoxName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxName.ForeColor = System.Drawing.Color.Gray;
            this.TextBoxName.Location = new System.Drawing.Point(500, 197);
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.Size = new System.Drawing.Size(414, 26);
            this.TextBoxName.TabIndex = 120;
            this.TextBoxName.Text = "Rajitha Vithana";
            this.TextBoxName.TextChanged += new System.EventHandler(this.TextBoxName_TextChanged);
            this.TextBoxName.Enter += new System.EventHandler(this.TextBoxName_Enter);
            this.TextBoxName.Leave += new System.EventHandler(this.TextBoxName_Leave);
            // 
            // lblName
            // 
            this.lblName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(344, 204);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(55, 20);
            this.lblName.TabIndex = 119;
            this.lblName.Text = "Name";
            // 
            // btnAddCusBack
            // 
            this.btnAddCusBack.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnAddCusBack.BackColor = System.Drawing.Color.Maroon;
            this.btnAddCusBack.FlatAppearance.BorderSize = 0;
            this.btnAddCusBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCusBack.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCusBack.ForeColor = System.Drawing.Color.White;
            this.btnAddCusBack.Location = new System.Drawing.Point(201, 511);
            this.btnAddCusBack.Name = "btnAddCusBack";
            this.btnAddCusBack.Size = new System.Drawing.Size(82, 32);
            this.btnAddCusBack.TabIndex = 141;
            this.btnAddCusBack.Text = "Back";
            this.btnAddCusBack.UseVisualStyleBackColor = false;
            this.btnAddCusBack.Click += new System.EventHandler(this.btnAddCusBack_Click);
            // 
            // frmAddNewCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1197, 619);
            this.Controls.Add(this.btnAddCusBack);
            this.Controls.Add(this.logoAddCus);
            this.Controls.Add(this.pnlmidAddCus);
            this.Controls.Add(this.headAddCus);
            this.Controls.Add(this.lblMailError);
            this.Controls.Add(this.lblPhoneError);
            this.Controls.Add(this.lblAddressError);
            this.Controls.Add(this.lblNicError);
            this.Controls.Add(this.lblNameError);
            this.Controls.Add(this.btnAddCusClear);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.comboBoxGender);
            this.Controls.Add(this.textBoxMail);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.textBoxNIC);
            this.Controls.Add(this.lblNIC);
            this.Controls.Add(this.TextBoxName);
            this.Controls.Add(this.lblName);
            this.Name = "frmAddNewCustomer";
            this.Text = "frmAddNewCustomer";
            this.Load += new System.EventHandler(this.frmAddNewCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logoAddCus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logoAddCus;
        private System.Windows.Forms.Panel pnlmidAddCus;
        private System.Windows.Forms.Label headAddCus;
        private System.Windows.Forms.Label lblMailError;
        private System.Windows.Forms.Label lblPhoneError;
        private System.Windows.Forms.Label lblAddressError;
        private System.Windows.Forms.Label lblNicError;
        private System.Windows.Forms.Label lblNameError;
        private System.Windows.Forms.Button btnAddCusClear;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.ComboBox comboBoxGender;
        private System.Windows.Forms.TextBox textBoxMail;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox textBoxNIC;
        private System.Windows.Forms.Label lblNIC;
        private System.Windows.Forms.TextBox TextBoxName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnAddCusBack;
    }
}