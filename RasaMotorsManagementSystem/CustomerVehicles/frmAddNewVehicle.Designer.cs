namespace RasaMotorsManagementSystem.CustomerVehicles
{
    partial class frmAddNewVehicle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddNewVehicle));
            this.logoAddVeh = new System.Windows.Forms.PictureBox();
            this.pnlmidAddVeh = new System.Windows.Forms.Panel();
            this.headAddVeh = new System.Windows.Forms.Label();
            this.lblProdYearError = new System.Windows.Forms.Label();
            this.lblChassiNoError = new System.Windows.Forms.Label();
            this.lblEngineNoError = new System.Windows.Forms.Label();
            this.lblModelError = new System.Windows.Forms.Label();
            this.lblBrandError = new System.Windows.Forms.Label();
            this.lblVehicleNoError = new System.Windows.Forms.Label();
            this.btnClearAddVeh = new System.Windows.Forms.Button();
            this.textBoxVehNo = new System.Windows.Forms.TextBox();
            this.lblVehNo = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblGender = new System.Windows.Forms.Label();
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
            this.btnAddVehBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.logoAddVeh)).BeginInit();
            this.SuspendLayout();
            // 
            // logoAddVeh
            // 
            this.logoAddVeh.BackColor = System.Drawing.Color.Transparent;
            this.logoAddVeh.Image = ((System.Drawing.Image)(resources.GetObject("logoAddVeh.Image")));
            this.logoAddVeh.Location = new System.Drawing.Point(12, 12);
            this.logoAddVeh.Name = "logoAddVeh";
            this.logoAddVeh.Size = new System.Drawing.Size(228, 101);
            this.logoAddVeh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoAddVeh.TabIndex = 146;
            this.logoAddVeh.TabStop = false;
            // 
            // pnlmidAddVeh
            // 
            this.pnlmidAddVeh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlmidAddVeh.BackColor = System.Drawing.Color.Maroon;
            this.pnlmidAddVeh.Location = new System.Drawing.Point(-27, 122);
            this.pnlmidAddVeh.Name = "pnlmidAddVeh";
            this.pnlmidAddVeh.Size = new System.Drawing.Size(2367, 10);
            this.pnlmidAddVeh.TabIndex = 145;
            // 
            // headAddVeh
            // 
            this.headAddVeh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.headAddVeh.AutoSize = true;
            this.headAddVeh.Font = new System.Drawing.Font("Rockwell", 45F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headAddVeh.ForeColor = System.Drawing.Color.White;
            this.headAddVeh.Location = new System.Drawing.Point(363, 25);
            this.headAddVeh.Name = "headAddVeh";
            this.headAddVeh.Size = new System.Drawing.Size(535, 73);
            this.headAddVeh.TabIndex = 144;
            this.headAddVeh.Text = "Add New Vehicle";
            // 
            // lblProdYearError
            // 
            this.lblProdYearError.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblProdYearError.AutoSize = true;
            this.lblProdYearError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdYearError.ForeColor = System.Drawing.Color.Red;
            this.lblProdYearError.Location = new System.Drawing.Point(828, 417);
            this.lblProdYearError.Name = "lblProdYearError";
            this.lblProdYearError.Size = new System.Drawing.Size(210, 16);
            this.lblProdYearError.TabIndex = 143;
            this.lblProdYearError.Text = "Invalid Production Year Try Again!";
            this.lblProdYearError.Visible = false;
            // 
            // lblChassiNoError
            // 
            this.lblChassiNoError.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblChassiNoError.AutoSize = true;
            this.lblChassiNoError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChassiNoError.ForeColor = System.Drawing.Color.Red;
            this.lblChassiNoError.Location = new System.Drawing.Point(828, 369);
            this.lblChassiNoError.Name = "lblChassiNoError";
            this.lblChassiNoError.Size = new System.Drawing.Size(209, 16);
            this.lblChassiNoError.TabIndex = 142;
            this.lblChassiNoError.Text = "Invalid Chassi Number. Try Again!";
            this.lblChassiNoError.Visible = false;
            // 
            // lblEngineNoError
            // 
            this.lblEngineNoError.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblEngineNoError.AutoSize = true;
            this.lblEngineNoError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEngineNoError.ForeColor = System.Drawing.Color.Red;
            this.lblEngineNoError.Location = new System.Drawing.Point(828, 319);
            this.lblEngineNoError.Name = "lblEngineNoError";
            this.lblEngineNoError.Size = new System.Drawing.Size(210, 16);
            this.lblEngineNoError.TabIndex = 141;
            this.lblEngineNoError.Text = "Invalid Engine Number. Try Again!";
            this.lblEngineNoError.Visible = false;
            // 
            // lblModelError
            // 
            this.lblModelError.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblModelError.AutoSize = true;
            this.lblModelError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModelError.ForeColor = System.Drawing.Color.Red;
            this.lblModelError.Location = new System.Drawing.Point(828, 274);
            this.lblModelError.Name = "lblModelError";
            this.lblModelError.Size = new System.Drawing.Size(155, 16);
            this.lblModelError.TabIndex = 140;
            this.lblModelError.Text = "Invalid Model. Try Again!";
            this.lblModelError.Visible = false;
            // 
            // lblBrandError
            // 
            this.lblBrandError.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblBrandError.AutoSize = true;
            this.lblBrandError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrandError.ForeColor = System.Drawing.Color.Red;
            this.lblBrandError.Location = new System.Drawing.Point(828, 228);
            this.lblBrandError.Name = "lblBrandError";
            this.lblBrandError.Size = new System.Drawing.Size(153, 16);
            this.lblBrandError.TabIndex = 139;
            this.lblBrandError.Text = "Invalid Brand. Try Again!";
            this.lblBrandError.Visible = false;
            // 
            // lblVehicleNoError
            // 
            this.lblVehicleNoError.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblVehicleNoError.AutoSize = true;
            this.lblVehicleNoError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehicleNoError.ForeColor = System.Drawing.Color.Red;
            this.lblVehicleNoError.Location = new System.Drawing.Point(828, 178);
            this.lblVehicleNoError.Name = "lblVehicleNoError";
            this.lblVehicleNoError.Size = new System.Drawing.Size(213, 16);
            this.lblVehicleNoError.TabIndex = 138;
            this.lblVehicleNoError.Text = "Invalid Vehicle Number. Try Again!";
            this.lblVehicleNoError.Visible = false;
            // 
            // btnClearAddVeh
            // 
            this.btnClearAddVeh.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnClearAddVeh.BackColor = System.Drawing.Color.Maroon;
            this.btnClearAddVeh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClearAddVeh.FlatAppearance.BorderSize = 0;
            this.btnClearAddVeh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearAddVeh.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearAddVeh.ForeColor = System.Drawing.Color.White;
            this.btnClearAddVeh.Location = new System.Drawing.Point(252, 529);
            this.btnClearAddVeh.Name = "btnClearAddVeh";
            this.btnClearAddVeh.Size = new System.Drawing.Size(82, 32);
            this.btnClearAddVeh.TabIndex = 137;
            this.btnClearAddVeh.Text = "Clear";
            this.btnClearAddVeh.UseVisualStyleBackColor = false;
            this.btnClearAddVeh.Click += new System.EventHandler(this.btnClearAddVeh_Click);
            // 
            // textBoxVehNo
            // 
            this.textBoxVehNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxVehNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxVehNo.ForeColor = System.Drawing.Color.Gray;
            this.textBoxVehNo.Location = new System.Drawing.Point(404, 172);
            this.textBoxVehNo.Name = "textBoxVehNo";
            this.textBoxVehNo.Size = new System.Drawing.Size(414, 26);
            this.textBoxVehNo.TabIndex = 136;
            this.textBoxVehNo.Text = "ABC-1234";
            this.textBoxVehNo.TextChanged += new System.EventHandler(this.textBoxVehNo_TextChanged);
            this.textBoxVehNo.Enter += new System.EventHandler(this.textBoxVehNo_Enter);
            this.textBoxVehNo.Leave += new System.EventHandler(this.textBoxVehNo_Leave);
            // 
            // lblVehNo
            // 
            this.lblVehNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVehNo.AutoSize = true;
            this.lblVehNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehNo.ForeColor = System.Drawing.Color.White;
            this.lblVehNo.Location = new System.Drawing.Point(248, 179);
            this.lblVehNo.Name = "lblVehNo";
            this.lblVehNo.Size = new System.Drawing.Size(95, 20);
            this.lblVehNo.TabIndex = 135;
            this.lblVehNo.Text = "Vehicle No";
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
            this.btnAdd.Location = new System.Drawing.Point(469, 528);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(249, 33);
            this.btnAdd.TabIndex = 134;
            this.btnAdd.Text = "Add Vehicle";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblGender
            // 
            this.lblGender.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.ForeColor = System.Drawing.Color.White;
            this.lblGender.Location = new System.Drawing.Point(248, 466);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(47, 20);
            this.lblGender.TabIndex = 133;
            this.lblGender.Text = "Type";
            // 
            // comboBoxType
            // 
            this.comboBoxType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxType.ForeColor = System.Drawing.Color.Gray;
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "Car",
            "Van",
            "Lorry",
            "SUV"});
            this.comboBoxType.Location = new System.Drawing.Point(404, 464);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(414, 28);
            this.comboBoxType.TabIndex = 132;
            // 
            // textBoxProdYear
            // 
            this.textBoxProdYear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxProdYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxProdYear.ForeColor = System.Drawing.Color.Gray;
            this.textBoxProdYear.Location = new System.Drawing.Point(404, 411);
            this.textBoxProdYear.Name = "textBoxProdYear";
            this.textBoxProdYear.Size = new System.Drawing.Size(414, 26);
            this.textBoxProdYear.TabIndex = 131;
            this.textBoxProdYear.Text = "2005";
            this.textBoxProdYear.TextChanged += new System.EventHandler(this.textBoxProdYear_TextChanged);
            this.textBoxProdYear.Enter += new System.EventHandler(this.textBoxProdYear_Enter);
            this.textBoxProdYear.Leave += new System.EventHandler(this.textBoxProdYear_Leave);
            // 
            // lblProdYear
            // 
            this.lblProdYear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProdYear.AutoSize = true;
            this.lblProdYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdYear.ForeColor = System.Drawing.Color.White;
            this.lblProdYear.Location = new System.Drawing.Point(248, 418);
            this.lblProdYear.Name = "lblProdYear";
            this.lblProdYear.Size = new System.Drawing.Size(138, 20);
            this.lblProdYear.TabIndex = 130;
            this.lblProdYear.Text = "Production Year";
            // 
            // textBoxChassiNo
            // 
            this.textBoxChassiNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxChassiNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxChassiNo.ForeColor = System.Drawing.Color.Gray;
            this.textBoxChassiNo.Location = new System.Drawing.Point(404, 363);
            this.textBoxChassiNo.Name = "textBoxChassiNo";
            this.textBoxChassiNo.Size = new System.Drawing.Size(414, 26);
            this.textBoxChassiNo.TabIndex = 129;
            this.textBoxChassiNo.Text = "WAUZZZ8R8AA042836";
            this.textBoxChassiNo.TextChanged += new System.EventHandler(this.textBoxChassiNo_TextChanged);
            this.textBoxChassiNo.Enter += new System.EventHandler(this.textBoxChassiNo_Enter);
            this.textBoxChassiNo.Leave += new System.EventHandler(this.textBoxChassiNo_Leave);
            // 
            // lblChassiNo
            // 
            this.lblChassiNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblChassiNo.AutoSize = true;
            this.lblChassiNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChassiNo.ForeColor = System.Drawing.Color.White;
            this.lblChassiNo.Location = new System.Drawing.Point(248, 370);
            this.lblChassiNo.Name = "lblChassiNo";
            this.lblChassiNo.Size = new System.Drawing.Size(90, 20);
            this.lblChassiNo.TabIndex = 128;
            this.lblChassiNo.Text = "Chassi No";
            // 
            // textBoxEngNo
            // 
            this.textBoxEngNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxEngNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEngNo.ForeColor = System.Drawing.Color.Gray;
            this.textBoxEngNo.Location = new System.Drawing.Point(404, 313);
            this.textBoxEngNo.Name = "textBoxEngNo";
            this.textBoxEngNo.Size = new System.Drawing.Size(414, 26);
            this.textBoxEngNo.TabIndex = 127;
            this.textBoxEngNo.Text = "1HGBH41JXMN109186";
            this.textBoxEngNo.TextChanged += new System.EventHandler(this.textBoxEngNo_TextChanged);
            this.textBoxEngNo.Enter += new System.EventHandler(this.textBoxEngNo_Enter);
            this.textBoxEngNo.Leave += new System.EventHandler(this.textBoxEngNo_Leave);
            // 
            // lblEngineNo
            // 
            this.lblEngineNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEngineNo.AutoSize = true;
            this.lblEngineNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEngineNo.ForeColor = System.Drawing.Color.White;
            this.lblEngineNo.Location = new System.Drawing.Point(248, 320);
            this.lblEngineNo.Name = "lblEngineNo";
            this.lblEngineNo.Size = new System.Drawing.Size(92, 20);
            this.lblEngineNo.TabIndex = 126;
            this.lblEngineNo.Text = "Engine No";
            // 
            // textBoxModel
            // 
            this.textBoxModel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxModel.ForeColor = System.Drawing.Color.Gray;
            this.textBoxModel.Location = new System.Drawing.Point(404, 268);
            this.textBoxModel.Name = "textBoxModel";
            this.textBoxModel.Size = new System.Drawing.Size(414, 26);
            this.textBoxModel.TabIndex = 125;
            this.textBoxModel.Text = "Civic";
            this.textBoxModel.TextChanged += new System.EventHandler(this.textBoxModel_TextChanged);
            this.textBoxModel.Enter += new System.EventHandler(this.textBoxModel_Enter);
            this.textBoxModel.Leave += new System.EventHandler(this.textBoxModel_Leave);
            // 
            // lblModel
            // 
            this.lblModel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblModel.AutoSize = true;
            this.lblModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModel.ForeColor = System.Drawing.Color.White;
            this.lblModel.Location = new System.Drawing.Point(248, 275);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(57, 20);
            this.lblModel.TabIndex = 124;
            this.lblModel.Text = "Model";
            // 
            // TextBoxBrand
            // 
            this.TextBoxBrand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxBrand.ForeColor = System.Drawing.Color.Gray;
            this.TextBoxBrand.Location = new System.Drawing.Point(404, 222);
            this.TextBoxBrand.Name = "TextBoxBrand";
            this.TextBoxBrand.Size = new System.Drawing.Size(414, 26);
            this.TextBoxBrand.TabIndex = 123;
            this.TextBoxBrand.Text = "Honda";
            this.TextBoxBrand.TextChanged += new System.EventHandler(this.TextBoxBrand_TextChanged);
            this.TextBoxBrand.Enter += new System.EventHandler(this.TextBoxBrand_Enter);
            this.TextBoxBrand.Leave += new System.EventHandler(this.TextBoxBrand_Leave);
            // 
            // lblBrand
            // 
            this.lblBrand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBrand.AutoSize = true;
            this.lblBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrand.ForeColor = System.Drawing.Color.White;
            this.lblBrand.Location = new System.Drawing.Point(248, 229);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(57, 20);
            this.lblBrand.TabIndex = 122;
            this.lblBrand.Text = "Brand";
            // 
            // btnAddVehBack
            // 
            this.btnAddVehBack.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnAddVehBack.BackColor = System.Drawing.Color.Maroon;
            this.btnAddVehBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAddVehBack.FlatAppearance.BorderSize = 0;
            this.btnAddVehBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddVehBack.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddVehBack.ForeColor = System.Drawing.Color.White;
            this.btnAddVehBack.Location = new System.Drawing.Point(117, 528);
            this.btnAddVehBack.Name = "btnAddVehBack";
            this.btnAddVehBack.Size = new System.Drawing.Size(82, 32);
            this.btnAddVehBack.TabIndex = 147;
            this.btnAddVehBack.Text = "Back";
            this.btnAddVehBack.UseVisualStyleBackColor = false;
            this.btnAddVehBack.Click += new System.EventHandler(this.btnAddVehBack_Click);
            // 
            // frmAddNewVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1105, 585);
            this.Controls.Add(this.btnAddVehBack);
            this.Controls.Add(this.logoAddVeh);
            this.Controls.Add(this.pnlmidAddVeh);
            this.Controls.Add(this.headAddVeh);
            this.Controls.Add(this.lblProdYearError);
            this.Controls.Add(this.lblChassiNoError);
            this.Controls.Add(this.lblEngineNoError);
            this.Controls.Add(this.lblModelError);
            this.Controls.Add(this.lblBrandError);
            this.Controls.Add(this.lblVehicleNoError);
            this.Controls.Add(this.btnClearAddVeh);
            this.Controls.Add(this.textBoxVehNo);
            this.Controls.Add(this.lblVehNo);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblGender);
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
            this.Name = "frmAddNewVehicle";
            this.Text = "frmAddNewVehicle";
            this.Load += new System.EventHandler(this.frmAddNewVehicle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logoAddVeh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logoAddVeh;
        private System.Windows.Forms.Panel pnlmidAddVeh;
        private System.Windows.Forms.Label headAddVeh;
        private System.Windows.Forms.Label lblProdYearError;
        private System.Windows.Forms.Label lblChassiNoError;
        private System.Windows.Forms.Label lblEngineNoError;
        private System.Windows.Forms.Label lblModelError;
        private System.Windows.Forms.Label lblBrandError;
        private System.Windows.Forms.Label lblVehicleNoError;
        private System.Windows.Forms.Button btnClearAddVeh;
        private System.Windows.Forms.TextBox textBoxVehNo;
        private System.Windows.Forms.Label lblVehNo;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.TextBox textBoxProdYear;
        private System.Windows.Forms.Label lblProdYear;
        private System.Windows.Forms.TextBox textBoxChassiNo;
        private System.Windows.Forms.Label lblChassiNo;
        private System.Windows.Forms.TextBox textBoxEngNo;
        private System.Windows.Forms.Label lblEngineNo;
        private System.Windows.Forms.TextBox textBoxModel;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.TextBox TextBoxBrand;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Button btnAddVehBack;
    }
}