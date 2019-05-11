namespace RasaMotorsManagementSystem.CustomerVehicles
{
    partial class frmVehUpdateDelete
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVehUpdateDelete));
            this.lblProdYearError = new System.Windows.Forms.Label();
            this.lblChassiNoError = new System.Windows.Forms.Label();
            this.lblEngineNoError = new System.Windows.Forms.Label();
            this.lblModelError = new System.Windows.Forms.Label();
            this.lblBrandError = new System.Windows.Forms.Label();
            this.lblVehicleNoError = new System.Windows.Forms.Label();
            this.textBoxVehNo = new System.Windows.Forms.TextBox();
            this.lblVehNo = new System.Windows.Forms.Label();
            this.logoUpdDelVeh = new System.Windows.Forms.PictureBox();
            this.pnlmidUpdDelVeh = new System.Windows.Forms.Panel();
            this.headUpdDelVeh = new System.Windows.Forms.Label();
            this.btnDeleteVehicle = new System.Windows.Forms.Button();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.lblVehID = new System.Windows.Forms.Label();
            this.btnUpdateVehicle = new System.Windows.Forms.Button();
            this.lblVehType = new System.Windows.Forms.Label();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.textBoxProdYear = new System.Windows.Forms.TextBox();
            this.lblProdYear = new System.Windows.Forms.Label();
            this.textBoxChassiNo = new System.Windows.Forms.TextBox();
            this.lblChassiNo = new System.Windows.Forms.Label();
            this.textBoxEngNo = new System.Windows.Forms.TextBox();
            this.lblEngineNo = new System.Windows.Forms.Label();
            this.textBoxModel = new System.Windows.Forms.TextBox();
            this.lblModel = new System.Windows.Forms.Label();
            this.TextBoxBrand = new System.Windows.Forms.TextBox();
            this.lblBrand = new System.Windows.Forms.Label();
            this.btnBackAddVeh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.logoUpdDelVeh)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProdYearError
            // 
            this.lblProdYearError.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblProdYearError.AutoSize = true;
            this.lblProdYearError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdYearError.ForeColor = System.Drawing.Color.Red;
            this.lblProdYearError.Location = new System.Drawing.Point(924, 464);
            this.lblProdYearError.Name = "lblProdYearError";
            this.lblProdYearError.Size = new System.Drawing.Size(210, 16);
            this.lblProdYearError.TabIndex = 156;
            this.lblProdYearError.Text = "Invalid Production Year Try Again!";
            this.lblProdYearError.Visible = false;
            // 
            // lblChassiNoError
            // 
            this.lblChassiNoError.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblChassiNoError.AutoSize = true;
            this.lblChassiNoError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChassiNoError.ForeColor = System.Drawing.Color.Red;
            this.lblChassiNoError.Location = new System.Drawing.Point(924, 418);
            this.lblChassiNoError.Name = "lblChassiNoError";
            this.lblChassiNoError.Size = new System.Drawing.Size(209, 16);
            this.lblChassiNoError.TabIndex = 155;
            this.lblChassiNoError.Text = "Invalid Chassi Number. Try Again!";
            this.lblChassiNoError.Visible = false;
            // 
            // lblEngineNoError
            // 
            this.lblEngineNoError.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblEngineNoError.AutoSize = true;
            this.lblEngineNoError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEngineNoError.ForeColor = System.Drawing.Color.Red;
            this.lblEngineNoError.Location = new System.Drawing.Point(924, 373);
            this.lblEngineNoError.Name = "lblEngineNoError";
            this.lblEngineNoError.Size = new System.Drawing.Size(210, 16);
            this.lblEngineNoError.TabIndex = 154;
            this.lblEngineNoError.Text = "Invalid Engine Number. Try Again!";
            this.lblEngineNoError.Visible = false;
            // 
            // lblModelError
            // 
            this.lblModelError.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblModelError.AutoSize = true;
            this.lblModelError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModelError.ForeColor = System.Drawing.Color.Red;
            this.lblModelError.Location = new System.Drawing.Point(925, 328);
            this.lblModelError.Name = "lblModelError";
            this.lblModelError.Size = new System.Drawing.Size(155, 16);
            this.lblModelError.TabIndex = 153;
            this.lblModelError.Text = "Invalid Model. Try Again!";
            this.lblModelError.Visible = false;
            // 
            // lblBrandError
            // 
            this.lblBrandError.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblBrandError.AutoSize = true;
            this.lblBrandError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrandError.ForeColor = System.Drawing.Color.Red;
            this.lblBrandError.Location = new System.Drawing.Point(925, 282);
            this.lblBrandError.Name = "lblBrandError";
            this.lblBrandError.Size = new System.Drawing.Size(153, 16);
            this.lblBrandError.TabIndex = 152;
            this.lblBrandError.Text = "Invalid Brand. Try Again!";
            this.lblBrandError.Visible = false;
            // 
            // lblVehicleNoError
            // 
            this.lblVehicleNoError.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblVehicleNoError.AutoSize = true;
            this.lblVehicleNoError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehicleNoError.ForeColor = System.Drawing.Color.Red;
            this.lblVehicleNoError.Location = new System.Drawing.Point(925, 236);
            this.lblVehicleNoError.Name = "lblVehicleNoError";
            this.lblVehicleNoError.Size = new System.Drawing.Size(213, 16);
            this.lblVehicleNoError.TabIndex = 151;
            this.lblVehicleNoError.Text = "Invalid Vehicle Number. Try Again!";
            this.lblVehicleNoError.Visible = false;
            // 
            // textBoxVehNo
            // 
            this.textBoxVehNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxVehNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxVehNo.ForeColor = System.Drawing.Color.Black;
            this.textBoxVehNo.Location = new System.Drawing.Point(505, 229);
            this.textBoxVehNo.Name = "textBoxVehNo";
            this.textBoxVehNo.Size = new System.Drawing.Size(414, 26);
            this.textBoxVehNo.TabIndex = 150;
            this.textBoxVehNo.TextChanged += new System.EventHandler(this.textBoxVehNo_TextChanged);
            // 
            // lblVehNo
            // 
            this.lblVehNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVehNo.AutoSize = true;
            this.lblVehNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehNo.ForeColor = System.Drawing.Color.White;
            this.lblVehNo.Location = new System.Drawing.Point(349, 232);
            this.lblVehNo.Name = "lblVehNo";
            this.lblVehNo.Size = new System.Drawing.Size(95, 20);
            this.lblVehNo.TabIndex = 149;
            this.lblVehNo.Text = "Vehicle No";
            // 
            // logoUpdDelVeh
            // 
            this.logoUpdDelVeh.BackColor = System.Drawing.Color.Transparent;
            this.logoUpdDelVeh.Image = ((System.Drawing.Image)(resources.GetObject("logoUpdDelVeh.Image")));
            this.logoUpdDelVeh.Location = new System.Drawing.Point(12, 12);
            this.logoUpdDelVeh.Name = "logoUpdDelVeh";
            this.logoUpdDelVeh.Size = new System.Drawing.Size(228, 101);
            this.logoUpdDelVeh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoUpdDelVeh.TabIndex = 148;
            this.logoUpdDelVeh.TabStop = false;
            // 
            // pnlmidUpdDelVeh
            // 
            this.pnlmidUpdDelVeh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlmidUpdDelVeh.BackColor = System.Drawing.Color.Maroon;
            this.pnlmidUpdDelVeh.Location = new System.Drawing.Point(-27, 124);
            this.pnlmidUpdDelVeh.Name = "pnlmidUpdDelVeh";
            this.pnlmidUpdDelVeh.Size = new System.Drawing.Size(2643, 10);
            this.pnlmidUpdDelVeh.TabIndex = 147;
            // 
            // headUpdDelVeh
            // 
            this.headUpdDelVeh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.headUpdDelVeh.AutoSize = true;
            this.headUpdDelVeh.Font = new System.Drawing.Font("Rockwell", 45F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headUpdDelVeh.ForeColor = System.Drawing.Color.White;
            this.headUpdDelVeh.Location = new System.Drawing.Point(340, 24);
            this.headUpdDelVeh.Name = "headUpdDelVeh";
            this.headUpdDelVeh.Size = new System.Drawing.Size(700, 73);
            this.headUpdDelVeh.TabIndex = 146;
            this.headUpdDelVeh.Text = "Update/Delete Vehicle";
            // 
            // btnDeleteVehicle
            // 
            this.btnDeleteVehicle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnDeleteVehicle.BackColor = System.Drawing.Color.Maroon;
            this.btnDeleteVehicle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDeleteVehicle.FlatAppearance.BorderSize = 0;
            this.btnDeleteVehicle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteVehicle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteVehicle.ForeColor = System.Drawing.Color.White;
            this.btnDeleteVehicle.Location = new System.Drawing.Point(353, 576);
            this.btnDeleteVehicle.Name = "btnDeleteVehicle";
            this.btnDeleteVehicle.Size = new System.Drawing.Size(145, 32);
            this.btnDeleteVehicle.TabIndex = 145;
            this.btnDeleteVehicle.Text = "Delete Vehicle";
            this.btnDeleteVehicle.UseVisualStyleBackColor = false;
            this.btnDeleteVehicle.Click += new System.EventHandler(this.btnDeleteVehicle_Click);
            // 
            // textBoxId
            // 
            this.textBoxId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxId.Location = new System.Drawing.Point(505, 186);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.ReadOnly = true;
            this.textBoxId.Size = new System.Drawing.Size(414, 26);
            this.textBoxId.TabIndex = 144;
            // 
            // lblVehID
            // 
            this.lblVehID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVehID.AutoSize = true;
            this.lblVehID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehID.ForeColor = System.Drawing.Color.White;
            this.lblVehID.Location = new System.Drawing.Point(349, 189);
            this.lblVehID.Name = "lblVehID";
            this.lblVehID.Size = new System.Drawing.Size(92, 20);
            this.lblVehID.TabIndex = 143;
            this.lblVehID.Text = "Vehicle ID";
            // 
            // btnUpdateVehicle
            // 
            this.btnUpdateVehicle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdateVehicle.BackColor = System.Drawing.Color.Maroon;
            this.btnUpdateVehicle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnUpdateVehicle.FlatAppearance.BorderSize = 0;
            this.btnUpdateVehicle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateVehicle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateVehicle.ForeColor = System.Drawing.Color.White;
            this.btnUpdateVehicle.Location = new System.Drawing.Point(642, 575);
            this.btnUpdateVehicle.Name = "btnUpdateVehicle";
            this.btnUpdateVehicle.Size = new System.Drawing.Size(153, 33);
            this.btnUpdateVehicle.TabIndex = 142;
            this.btnUpdateVehicle.Text = "Update Vehicle";
            this.btnUpdateVehicle.UseVisualStyleBackColor = false;
            this.btnUpdateVehicle.Click += new System.EventHandler(this.btnUpdateVehicle_Click);
            // 
            // lblVehType
            // 
            this.lblVehType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVehType.AutoSize = true;
            this.lblVehType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehType.ForeColor = System.Drawing.Color.White;
            this.lblVehType.Location = new System.Drawing.Point(349, 507);
            this.lblVehType.Name = "lblVehType";
            this.lblVehType.Size = new System.Drawing.Size(47, 20);
            this.lblVehType.TabIndex = 141;
            this.lblVehType.Text = "Type";
            // 
            // comboBoxType
            // 
            this.comboBoxType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "Car",
            "Van",
            "Lorry",
            "SUV"});
            this.comboBoxType.Location = new System.Drawing.Point(503, 504);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(414, 28);
            this.comboBoxType.TabIndex = 140;
            // 
            // textBoxProdYear
            // 
            this.textBoxProdYear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxProdYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxProdYear.Location = new System.Drawing.Point(505, 458);
            this.textBoxProdYear.Name = "textBoxProdYear";
            this.textBoxProdYear.Size = new System.Drawing.Size(414, 26);
            this.textBoxProdYear.TabIndex = 139;
            this.textBoxProdYear.TextChanged += new System.EventHandler(this.textBoxProdYear_TextChanged);
            // 
            // lblProdYear
            // 
            this.lblProdYear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProdYear.AutoSize = true;
            this.lblProdYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdYear.ForeColor = System.Drawing.Color.White;
            this.lblProdYear.Location = new System.Drawing.Point(349, 461);
            this.lblProdYear.Name = "lblProdYear";
            this.lblProdYear.Size = new System.Drawing.Size(138, 20);
            this.lblProdYear.TabIndex = 138;
            this.lblProdYear.Text = "Production Year";
            // 
            // textBoxChassiNo
            // 
            this.textBoxChassiNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxChassiNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxChassiNo.Location = new System.Drawing.Point(505, 411);
            this.textBoxChassiNo.Name = "textBoxChassiNo";
            this.textBoxChassiNo.Size = new System.Drawing.Size(414, 26);
            this.textBoxChassiNo.TabIndex = 137;
            this.textBoxChassiNo.TextChanged += new System.EventHandler(this.textBoxChassiNo_TextChanged);
            // 
            // lblChassiNo
            // 
            this.lblChassiNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblChassiNo.AutoSize = true;
            this.lblChassiNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChassiNo.ForeColor = System.Drawing.Color.White;
            this.lblChassiNo.Location = new System.Drawing.Point(349, 414);
            this.lblChassiNo.Name = "lblChassiNo";
            this.lblChassiNo.Size = new System.Drawing.Size(90, 20);
            this.lblChassiNo.TabIndex = 136;
            this.lblChassiNo.Text = "Chassi No";
            // 
            // textBoxEngNo
            // 
            this.textBoxEngNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxEngNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEngNo.Location = new System.Drawing.Point(505, 366);
            this.textBoxEngNo.Name = "textBoxEngNo";
            this.textBoxEngNo.Size = new System.Drawing.Size(414, 26);
            this.textBoxEngNo.TabIndex = 135;
            this.textBoxEngNo.TextChanged += new System.EventHandler(this.textBoxEngNo_TextChanged);
            // 
            // lblEngineNo
            // 
            this.lblEngineNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEngineNo.AutoSize = true;
            this.lblEngineNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEngineNo.ForeColor = System.Drawing.Color.White;
            this.lblEngineNo.Location = new System.Drawing.Point(349, 369);
            this.lblEngineNo.Name = "lblEngineNo";
            this.lblEngineNo.Size = new System.Drawing.Size(92, 20);
            this.lblEngineNo.TabIndex = 134;
            this.lblEngineNo.Text = "Engine No";
            // 
            // textBoxModel
            // 
            this.textBoxModel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxModel.Location = new System.Drawing.Point(505, 321);
            this.textBoxModel.Name = "textBoxModel";
            this.textBoxModel.Size = new System.Drawing.Size(414, 26);
            this.textBoxModel.TabIndex = 133;
            this.textBoxModel.TextChanged += new System.EventHandler(this.textBoxModel_TextChanged);
            // 
            // lblModel
            // 
            this.lblModel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblModel.AutoSize = true;
            this.lblModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModel.ForeColor = System.Drawing.Color.White;
            this.lblModel.Location = new System.Drawing.Point(349, 324);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(57, 20);
            this.lblModel.TabIndex = 132;
            this.lblModel.Text = "Model";
            // 
            // TextBoxBrand
            // 
            this.TextBoxBrand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxBrand.Location = new System.Drawing.Point(505, 275);
            this.TextBoxBrand.Name = "TextBoxBrand";
            this.TextBoxBrand.Size = new System.Drawing.Size(414, 26);
            this.TextBoxBrand.TabIndex = 131;
            this.TextBoxBrand.TextChanged += new System.EventHandler(this.TextBoxBrand_TextChanged);
            // 
            // lblBrand
            // 
            this.lblBrand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBrand.AutoSize = true;
            this.lblBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrand.ForeColor = System.Drawing.Color.White;
            this.lblBrand.Location = new System.Drawing.Point(349, 278);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(57, 20);
            this.lblBrand.TabIndex = 130;
            this.lblBrand.Text = "Brand";
            // 
            // btnBackAddVeh
            // 
            this.btnBackAddVeh.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnBackAddVeh.BackColor = System.Drawing.Color.Maroon;
            this.btnBackAddVeh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBackAddVeh.FlatAppearance.BorderSize = 0;
            this.btnBackAddVeh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackAddVeh.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackAddVeh.ForeColor = System.Drawing.Color.White;
            this.btnBackAddVeh.Location = new System.Drawing.Point(194, 576);
            this.btnBackAddVeh.Name = "btnBackAddVeh";
            this.btnBackAddVeh.Size = new System.Drawing.Size(82, 32);
            this.btnBackAddVeh.TabIndex = 157;
            this.btnBackAddVeh.Text = "Back";
            this.btnBackAddVeh.UseVisualStyleBackColor = false;
            this.btnBackAddVeh.Click += new System.EventHandler(this.btnBackAddVeh_Click);
            // 
            // frmVehUpdateDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1197, 619);
            this.Controls.Add(this.btnBackAddVeh);
            this.Controls.Add(this.lblProdYearError);
            this.Controls.Add(this.lblChassiNoError);
            this.Controls.Add(this.lblEngineNoError);
            this.Controls.Add(this.lblModelError);
            this.Controls.Add(this.lblBrandError);
            this.Controls.Add(this.lblVehicleNoError);
            this.Controls.Add(this.textBoxVehNo);
            this.Controls.Add(this.lblVehNo);
            this.Controls.Add(this.logoUpdDelVeh);
            this.Controls.Add(this.pnlmidUpdDelVeh);
            this.Controls.Add(this.headUpdDelVeh);
            this.Controls.Add(this.btnDeleteVehicle);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.lblVehID);
            this.Controls.Add(this.btnUpdateVehicle);
            this.Controls.Add(this.lblVehType);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.textBoxProdYear);
            this.Controls.Add(this.lblProdYear);
            this.Controls.Add(this.textBoxChassiNo);
            this.Controls.Add(this.lblChassiNo);
            this.Controls.Add(this.textBoxEngNo);
            this.Controls.Add(this.lblEngineNo);
            this.Controls.Add(this.textBoxModel);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.TextBoxBrand);
            this.Controls.Add(this.lblBrand);
            this.Name = "frmVehUpdateDelete";
            this.Text = "frmVehUpdateDelete";
            ((System.ComponentModel.ISupportInitialize)(this.logoUpdDelVeh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProdYearError;
        private System.Windows.Forms.Label lblChassiNoError;
        private System.Windows.Forms.Label lblEngineNoError;
        private System.Windows.Forms.Label lblModelError;
        private System.Windows.Forms.Label lblBrandError;
        private System.Windows.Forms.Label lblVehicleNoError;
        private System.Windows.Forms.TextBox textBoxVehNo;
        private System.Windows.Forms.Label lblVehNo;
        private System.Windows.Forms.PictureBox logoUpdDelVeh;
        private System.Windows.Forms.Panel pnlmidUpdDelVeh;
        private System.Windows.Forms.Label headUpdDelVeh;
        private System.Windows.Forms.Button btnDeleteVehicle;
        public System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label lblVehID;
        private System.Windows.Forms.Button btnUpdateVehicle;
        private System.Windows.Forms.Label lblVehType;
        public System.Windows.Forms.ComboBox comboBoxType;
        public System.Windows.Forms.TextBox textBoxProdYear;
        private System.Windows.Forms.Label lblProdYear;
        public System.Windows.Forms.TextBox textBoxChassiNo;
        private System.Windows.Forms.Label lblChassiNo;
        public System.Windows.Forms.TextBox textBoxEngNo;
        private System.Windows.Forms.Label lblEngineNo;
        public System.Windows.Forms.TextBox textBoxModel;
        private System.Windows.Forms.Label lblModel;
        public System.Windows.Forms.TextBox TextBoxBrand;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Button btnBackAddVeh;
    }
}