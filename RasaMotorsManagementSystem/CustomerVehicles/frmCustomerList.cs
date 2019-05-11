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
    public partial class frmCustomerList : Form
    {
        public frmCustomerList()
        {
            InitializeComponent();
        }

        CustomerClass c = new CustomerClass();

        private void frmCustomerList_Load(object sender, EventArgs e)
        {
            DataTable dt = c.select();
            ViewGridCustomers.DataSource = dt;
        }

        private void btnAddNewCustomer_Click(object sender, EventArgs e)
        {
            frmAddNewCustomer f1 = new frmAddNewCustomer();
            f1.ShowDialog();

            DataTable dt = c.select();
            ViewGridCustomers.DataSource = dt;
        }

        private void ViewGridCustomers_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            frmCusUpdateDelete f2 = new frmCusUpdateDelete();

            // get data from data grid view to text fields

            int rowIndex = e.RowIndex;

            f2.textBoxId.Text = this.ViewGridCustomers.Rows[rowIndex].Cells[0].Value.ToString();
            f2.TextBoxName.Text = this.ViewGridCustomers.Rows[rowIndex].Cells[1].Value.ToString();
            f2.textBoxNIC.Text = this.ViewGridCustomers.Rows[rowIndex].Cells[2].Value.ToString();
            f2.textBoxAddress.Text = this.ViewGridCustomers.Rows[rowIndex].Cells[3].Value.ToString();
            f2.textBoxPhone.Text = this.ViewGridCustomers.Rows[rowIndex].Cells[4].Value.ToString();
            f2.textBoxMail.Text = this.ViewGridCustomers.Rows[rowIndex].Cells[5].Value.ToString();
            f2.comboBoxGender.Text = this.ViewGridCustomers.Rows[rowIndex].Cells[6].Value.ToString();

            f2.ShowDialog();

            DataTable dt = c.select();
            ViewGridCustomers.DataSource = dt;

        }

        private void ViewGridCustomers_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            String customerID = this.ViewGridCustomers.SelectedRows[0].Cells[0].Value.ToString();
            Console.Write(customerID);

            frmVehicleList v1 = new frmVehicleList(customerID);
            v1.ShowDialog();
        }

        static string myconnstr = Common.Utils.ConnectionString;

        private void txtBoxSearchCus_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtBoxSearchCus.Text;

            if (keyword == "Search by Name...")
            {
                DataTable dt = c.select();
                ViewGridCustomers.DataSource = dt;
            }
            else
            {
                SqlConnection conn = new SqlConnection(myconnstr);
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM CusDetails WHERE Name like '%" + keyword + "%'", conn);

                DataTable dt = new DataTable();
                sda.Fill(dt);
                ViewGridCustomers.DataSource = dt;
            }
        }

        private void txtBoxSearchCus_Enter(object sender, EventArgs e)
        {
            if (txtBoxSearchCus.Text == "Search by Name...")
            {
                txtBoxSearchCus.Text = "";
                txtBoxSearchCus.ForeColor = Color.Black;
            }
        }

        private void txtBoxSearchCus_Leave(object sender, EventArgs e)
        {
            if (txtBoxSearchCus.Text == "")
            {
                txtBoxSearchCus.Text = "Search by Name";
                txtBoxSearchCus.ForeColor = Color.Gray;
            }
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            CusVehReportViewer cusVehReport = new CusVehReportViewer();
            cusVehReport.Show();
        }

        private void headCusList_Click(object sender, EventArgs e)
        {

        }
    }
}
