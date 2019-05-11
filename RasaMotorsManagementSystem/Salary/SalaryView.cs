using RasaMotorsManagementSystem.Salary.SalaryClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RasaMotorsManagementSystem.Salary
{
    public partial class SalaryView : Form
    {
        public static SqlConnection con = new SqlConnection("Data Source=DESKTOP-T0HOCLV;Initial Catalog=ServiceCenterManagementDB;Integrated Security=True");
        update u = new update();

        public SalaryView()
        {
            InitializeComponent();
            timer1.Start();
        }
        ssalaryclass c1 = new ssalaryclass();
        Salaryform s = new Salaryform();

        private void SalaryView_Load(object sender, EventArgs e)
        {

            //load data on datagridview
            DataTable dt = c1.Select();
            dataGrid.DataSource = dt;

            this.KeyPreview = true;

        }

        public void clear()
        {
            u.txtOT.Text = "";
            u.TxtBonus.Text = "";
            // dateTimePicker1.Text = "";
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (DialogResult.Yes == MessageBox.Show("Are you sure want to delete this?", "confirm", MessageBoxButtons.YesNo))
                {
                    // hii
                    //get contact id from application
                    //   float N = Convert.ToInt32(No.Text);
                    //u.No=Convert.ToInt32
                    c1.No = Convert.ToInt32(u.No.Text);
                    bool success = c1.Delete(c1);
                    if (success == true)
                    {
                        MessageBox.Show("deleted successfully");

                        //refresh data grid view
                        //load data on datagridview
                        DataTable dt = c1.Select();
                        dataGrid.DataSource = dt;

                    }
                    else
                    {
                        MessageBox.Show("failed to delete.try again");
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("please select an item");
            }
        }
            

        static string myconnsstrng = Common.Utils.ConnectionString;

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            //get the value from textbox
            string keyword = txtSearch.Text;
            SqlConnection conn = new SqlConnection(myconnsstrng);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM empsalary WHERE EmployeeID LIKE '%" + keyword + "%'", conn);


            DataTable dt = new DataTable();
            sda.Fill(dt);
            // sa.Fill(dt);
            dataGrid.DataSource = dt;

        }

        private void btnback_Click(object sender, EventArgs e)
        {
            //view button
            this.Hide();
            Salaryform f4 = new Salaryform();
            f4.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sdf = new SqlDataAdapter("select * from empsalary where Date between '" + from.Value.ToString() + "' and '" + To.Value.ToString() + "'", con);
            DataTable sd = new DataTable();
            sdf.Fill(sd);
            dataGrid.DataSource = sd;

        }

        private void SalaryView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                btndelete.PerformClick();
            }
        }

        private void dataGrid_KeyDown(object sender, KeyEventArgs e)
        {
            //move from key enter
            if (e.KeyData == Keys.Enter)
            {
                int col = dataGrid.CurrentCell.ColumnIndex;
                int row = dataGrid.CurrentCell.RowIndex;

                if (col < dataGrid.ColumnCount - 1)
                {
                    col++;
                }
                else
                {
                    col = 0;
                    row++;
                }
                if (row == dataGrid.RowCount)
                    dataGrid.Rows.Add();

                dataGrid.CurrentCell = dataGrid[col, row];
                e.Handled = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            this.Time.Text = dateTime.ToString();
        }

        private void SalaryView_Activated(object sender, EventArgs e)
        {
            DataTable dt = c1.Select();
            dataGrid.DataSource = dt;

        }

        private void dataGrid_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //get data from datagrid into text boxes
            //identify rows on which mouse click
            int rowIndex = e.RowIndex;


            dataGrid.Rows[rowIndex].Cells["EmployeeID"].ToString();
            u.No.Text = dataGrid.Rows[rowIndex].Cells[8].Value.ToString();
            u.txtID.Text = dataGrid.Rows[rowIndex].Cells[0].Value.ToString();
            u.txtOT.Text = dataGrid.Rows[rowIndex].Cells[2].Value.ToString();
            u.TxtBonus.Text = dataGrid.Rows[rowIndex].Cells[3].Value.ToString();
            u.txtBasic.Text = dataGrid.Rows[rowIndex].Cells[1].Value.ToString();
            u.txtEpf.Text = dataGrid.Rows[rowIndex].Cells[4].Value.ToString();
            u.txtRate.Text = dataGrid.Rows[rowIndex].Cells[5].Value.ToString();
            u.txtTot.Text = dataGrid.Rows[rowIndex].Cells[7].Value.ToString();


            // up.dateTimePicker1.Text = dataGrid.Rows[rowIndex].Cells[6].Value.ToString();
            u.ShowDialog();
            //  this.Close();
        }

        private void dataGrid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int i = 1;
            foreach (DataGridViewRow row in dataGrid.Rows)
            {
                row.Cells[0].Value = i;
                i++;
            }
        }

        private void btnsum_Click(object sender, EventArgs e)
        {
            int A = 0, B = 0;
            for (A = 0; A < dataGrid.Rows.Count; ++A)
            {
                B += Convert.ToInt32(dataGrid.Rows[A].Cells[7].Value);
            }
            Total.Text = B.ToString();
        }

       

        private void btndelete_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                btndelete.PerformClick();
            }
        }

        private void dataGrid_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;


            dataGrid.Rows[rowIndex].Cells["EmployeeID"].ToString();
            u.No.Text = dataGrid.Rows[rowIndex].Cells[8].Value.ToString();
            u.txtID.Text = dataGrid.Rows[rowIndex].Cells[0].Value.ToString();
            u.txtOT.Text = dataGrid.Rows[rowIndex].Cells[2].Value.ToString();
            u.TxtBonus.Text = dataGrid.Rows[rowIndex].Cells[3].Value.ToString();
            u.txtBasic.Text = dataGrid.Rows[rowIndex].Cells[1].Value.ToString();
            u.txtEpf.Text = dataGrid.Rows[rowIndex].Cells[4].Value.ToString();
            u.txtRate.Text = dataGrid.Rows[rowIndex].Cells[5].Value.ToString();
            u.txtTot.Text = dataGrid.Rows[rowIndex].Cells[7].Value.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            salaryreport f4 = new salaryreport();
            f4.Show();
        }
    }
}
