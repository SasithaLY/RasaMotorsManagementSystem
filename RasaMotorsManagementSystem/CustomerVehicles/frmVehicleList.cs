using RasaMotorsManagementSystem.CustomerVehicles.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RasaMotorsManagementSystem.CustomerVehicles
{
    public partial class frmVehicleList : Form
    {
        private string customerID;
        VehicleClass v = new VehicleClass();

        public frmVehicleList()
        {
            InitializeComponent();
        }

        public frmVehicleList(string customerID)
        {
            this.customerID = customerID;
            InitializeComponent();
        }

        private void btnAddNewVehicle_Click(object sender, EventArgs e)
        {
            frmAddNewVehicle v1 = new frmAddNewVehicle(customerID);
            v1.ShowDialog();
            ViewGridVehicles.DataSource = loadData();
        }

        private void frmVehicleList_Load(object sender, EventArgs e)
        {
            ViewGridVehicles.DataSource = loadData();
        }

        private DataTable loadData()
        {
            DataTable dt = v.select("where CustomerID = '" + customerID + "'");
            return dt;

        }

        private void ViewGridVehicles_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            frmVehUpdateDelete vehFrm = new frmVehUpdateDelete();

            // get data from data grid view to text fields

            int rowIndex = e.RowIndex;

            vehFrm.textBoxId.Text = this.ViewGridVehicles.Rows[rowIndex].Cells[0].Value.ToString();
            vehFrm.TextBoxBrand.Text = this.ViewGridVehicles.Rows[rowIndex].Cells[1].Value.ToString();
            vehFrm.textBoxModel.Text = this.ViewGridVehicles.Rows[rowIndex].Cells[2].Value.ToString();
            vehFrm.textBoxEngNo.Text = this.ViewGridVehicles.Rows[rowIndex].Cells[3].Value.ToString();
            vehFrm.textBoxChassiNo.Text = this.ViewGridVehicles.Rows[rowIndex].Cells[4].Value.ToString();
            vehFrm.textBoxProdYear.Text = this.ViewGridVehicles.Rows[rowIndex].Cells[5].Value.ToString();
            vehFrm.comboBoxType.Text = this.ViewGridVehicles.Rows[rowIndex].Cells[6].Value.ToString();

            vehFrm.ShowDialog();
        }

        static string myconnstr = Common.Utils.ConnectionString;

        private void txtBoxSearchVeh_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtBoxSearchVeh.Text;

            if (keyword == "Search by Brand or Model...")
            {
                DataTable dt = v.select();
                ViewGridVehicles.DataSource = dt;
            }
            else
            {
                SqlConnection conn = new SqlConnection(myconnstr);
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM VehDetails WHERE Model like '%" + keyword + "%' OR Brand like '%" + keyword + "%'", conn);

                DataTable dt = new DataTable();
                sda.Fill(dt);
                ViewGridVehicles.DataSource = dt;
            }
        }

        private void txtBoxSearchVeh_Enter(object sender, EventArgs e)
        {
            if (txtBoxSearchVeh.Text == "Search by Brand or Model...")
            {
                txtBoxSearchVeh.Text = "";
                txtBoxSearchVeh.ForeColor = Color.Black;
            }
        }

        private void txtBoxSearchVeh_Leave(object sender, EventArgs e)
        {
            if (txtBoxSearchVeh.Text == "")
            {
                txtBoxSearchVeh.Text = "Search by Brand or Model...";
                txtBoxSearchVeh.ForeColor = Color.Gray;
            }
        }

        private void btnVehListBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
