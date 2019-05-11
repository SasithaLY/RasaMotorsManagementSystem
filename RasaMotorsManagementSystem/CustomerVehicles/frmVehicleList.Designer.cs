namespace RasaMotorsManagementSystem.CustomerVehicles
{
    partial class frmVehicleList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVehicleList));
            this.logoVehList = new System.Windows.Forms.PictureBox();
            this.pnlmidVehList = new System.Windows.Forms.Panel();
            this.headVehList = new System.Windows.Forms.Label();
            this.lblSearchVeh = new System.Windows.Forms.Label();
            this.btnAddNewVehicle = new System.Windows.Forms.Button();
            this.txtBoxSearchVeh = new System.Windows.Forms.TextBox();
            this.ViewGridVehicles = new System.Windows.Forms.DataGridView();
            this.btnVehListBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.logoVehList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ViewGridVehicles)).BeginInit();
            this.SuspendLayout();
            // 
            // logoVehList
            // 
            this.logoVehList.BackColor = System.Drawing.Color.Transparent;
            this.logoVehList.Image = ((System.Drawing.Image)(resources.GetObject("logoVehList.Image")));
            this.logoVehList.Location = new System.Drawing.Point(12, 12);
            this.logoVehList.Name = "logoVehList";
            this.logoVehList.Size = new System.Drawing.Size(228, 101);
            this.logoVehList.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoVehList.TabIndex = 128;
            this.logoVehList.TabStop = false;
            // 
            // pnlmidVehList
            // 
            this.pnlmidVehList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlmidVehList.BackColor = System.Drawing.Color.Maroon;
            this.pnlmidVehList.Location = new System.Drawing.Point(-34, 124);
            this.pnlmidVehList.Name = "pnlmidVehList";
            this.pnlmidVehList.Size = new System.Drawing.Size(2893, 10);
            this.pnlmidVehList.TabIndex = 127;
            // 
            // headVehList
            // 
            this.headVehList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.headVehList.AutoSize = true;
            this.headVehList.Font = new System.Drawing.Font("Rockwell", 42F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headVehList.ForeColor = System.Drawing.Color.White;
            this.headVehList.Location = new System.Drawing.Point(453, 30);
            this.headVehList.Name = "headVehList";
            this.headVehList.Size = new System.Drawing.Size(808, 68);
            this.headVehList.TabIndex = 126;
            this.headVehList.Text = "Vehicle List of the Customer";
            // 
            // lblSearchVeh
            // 
            this.lblSearchVeh.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblSearchVeh.AutoSize = true;
            this.lblSearchVeh.BackColor = System.Drawing.Color.Transparent;
            this.lblSearchVeh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchVeh.ForeColor = System.Drawing.Color.White;
            this.lblSearchVeh.Location = new System.Drawing.Point(38, 284);
            this.lblSearchVeh.Name = "lblSearchVeh";
            this.lblSearchVeh.Size = new System.Drawing.Size(81, 20);
            this.lblSearchVeh.TabIndex = 125;
            this.lblSearchVeh.Text = "Search...";
            // 
            // btnAddNewVehicle
            // 
            this.btnAddNewVehicle.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAddNewVehicle.BackColor = System.Drawing.Color.Maroon;
            this.btnAddNewVehicle.FlatAppearance.BorderSize = 0;
            this.btnAddNewVehicle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewVehicle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewVehicle.ForeColor = System.Drawing.Color.Transparent;
            this.btnAddNewVehicle.Location = new System.Drawing.Point(1351, 275);
            this.btnAddNewVehicle.Name = "btnAddNewVehicle";
            this.btnAddNewVehicle.Size = new System.Drawing.Size(105, 28);
            this.btnAddNewVehicle.TabIndex = 124;
            this.btnAddNewVehicle.Text = "Add New";
            this.btnAddNewVehicle.UseVisualStyleBackColor = false;
            this.btnAddNewVehicle.Click += new System.EventHandler(this.btnAddNewVehicle_Click);
            // 
            // txtBoxSearchVeh
            // 
            this.txtBoxSearchVeh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxSearchVeh.BackColor = System.Drawing.Color.White;
            this.txtBoxSearchVeh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxSearchVeh.ForeColor = System.Drawing.Color.Gray;
            this.txtBoxSearchVeh.Location = new System.Drawing.Point(125, 277);
            this.txtBoxSearchVeh.Name = "txtBoxSearchVeh";
            this.txtBoxSearchVeh.Size = new System.Drawing.Size(1206, 26);
            this.txtBoxSearchVeh.TabIndex = 123;
            this.txtBoxSearchVeh.Text = "Search by Brand or Model...";
            this.txtBoxSearchVeh.TextChanged += new System.EventHandler(this.txtBoxSearchVeh_TextChanged);
            this.txtBoxSearchVeh.Enter += new System.EventHandler(this.txtBoxSearchVeh_Enter);
            this.txtBoxSearchVeh.Leave += new System.EventHandler(this.txtBoxSearchVeh_Leave);
            // 
            // ViewGridVehicles
            // 
            this.ViewGridVehicles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ViewGridVehicles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ViewGridVehicles.BackgroundColor = System.Drawing.Color.White;
            this.ViewGridVehicles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ViewGridVehicles.Location = new System.Drawing.Point(42, 342);
            this.ViewGridVehicles.Name = "ViewGridVehicles";
            this.ViewGridVehicles.Size = new System.Drawing.Size(1414, 409);
            this.ViewGridVehicles.TabIndex = 122;
            this.ViewGridVehicles.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ViewGridVehicles_RowHeaderMouseClick);
            // 
            // btnVehListBack
            // 
            this.btnVehListBack.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnVehListBack.BackColor = System.Drawing.Color.Maroon;
            this.btnVehListBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnVehListBack.FlatAppearance.BorderSize = 0;
            this.btnVehListBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVehListBack.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVehListBack.ForeColor = System.Drawing.Color.White;
            this.btnVehListBack.Location = new System.Drawing.Point(42, 789);
            this.btnVehListBack.Name = "btnVehListBack";
            this.btnVehListBack.Size = new System.Drawing.Size(82, 32);
            this.btnVehListBack.TabIndex = 148;
            this.btnVehListBack.Text = "Back";
            this.btnVehListBack.UseVisualStyleBackColor = false;
            this.btnVehListBack.Click += new System.EventHandler(this.btnVehListBack_Click);
            // 
            // frmVehicleList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1490, 880);
            this.Controls.Add(this.btnVehListBack);
            this.Controls.Add(this.logoVehList);
            this.Controls.Add(this.pnlmidVehList);
            this.Controls.Add(this.headVehList);
            this.Controls.Add(this.lblSearchVeh);
            this.Controls.Add(this.btnAddNewVehicle);
            this.Controls.Add(this.txtBoxSearchVeh);
            this.Controls.Add(this.ViewGridVehicles);
            this.Name = "frmVehicleList";
            this.Text = "frmVehicleList";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmVehicleList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logoVehList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ViewGridVehicles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logoVehList;
        private System.Windows.Forms.Panel pnlmidVehList;
        private System.Windows.Forms.Label headVehList;
        private System.Windows.Forms.Label lblSearchVeh;
        private System.Windows.Forms.Button btnAddNewVehicle;
        private System.Windows.Forms.TextBox txtBoxSearchVeh;
        private System.Windows.Forms.DataGridView ViewGridVehicles;
        private System.Windows.Forms.Button btnVehListBack;
    }
}