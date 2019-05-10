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
using RasaMotorsManagementSystem.Finance.serviceCenterClasses;

namespace RasaMotorsManagementSystem.Finance
{
    public partial class financialView : Form
    {
        string connString = Common.Utils.ConnectionString;
        public financialView()
        {
            InitializeComponent();
        }

        netProfit f = new netProfit();

        private void btnBack_Click(object sender, EventArgs e)
        {
            new calculation().Show();
            this.Close();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            this.Hide();
            reportViewer manager = new reportViewer();

            manager.ShowDialog();
            this.Close();
        }

       
        private void dgvFinancial_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            financeUpDel cus = new financeUpDel();
            cus.txtID.Text = this.dgvFinancial.CurrentRow.Cells[0].Value.ToString();
            cus.txtTotIncome.Text = this.dgvFinancial.CurrentRow.Cells[1].Value.ToString();
            cus.txtInvenSales.Text = this.dgvFinancial.CurrentRow.Cells[2].Value.ToString();
            cus.txtOrder.Text = this.dgvFinancial.CurrentRow.Cells[3].Value.ToString();
            cus.txtInvenPay.Text = this.dgvFinancial.CurrentRow.Cells[4].Value.ToString();
            cus.txtUtilityPay.Text = this.dgvFinancial.CurrentRow.Cells[5].Value.ToString();
            cus.txtSal.Text = this.dgvFinancial.CurrentRow.Cells[6].Value.ToString();
            cus.txtCal.Text = this.dgvFinancial.CurrentRow.Cells[7].Value.ToString();
            cus.txtDate.Text = this.dgvFinancial.CurrentRow.Cells[8].Value.ToString();
            cus.ShowDialog();
            this.Close();
        }

        private void financialView_Load(object sender, EventArgs e)
        {
            DataTable dt = f.Select();
            dgvFinancial.DataSource = dt;
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string keyword = textBoxSearch.Text;

            if (keyword == "Search by CustomerID , Date ")
            {
                DataTable dt = f.Select();
                dgvFinancial.DataSource = dt;
            }
            else
            {
                SqlConnection conn = new SqlConnection(connString);

                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM tbl_Profit " +
                    "WHERE CustomerID LIKE '%" + keyword + "%' or Date LIKE '%"  + keyword + "%'", conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                dgvFinancial.DataSource = dt;
            }
        }
    }
}
