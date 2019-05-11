using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RasaMotorsManagementSystem.Salary
{
    public partial class salaryreport : Form
    {
        public salaryreport()
        {
            InitializeComponent();
        }

        private void salaryreport_Load(object sender, EventArgs e)
        {
           
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'EmpData.DataTable1' table. You can move, or remove it, as needed.
            this.DataTable1TableAdapter.Fill(this.EmpData.DataTable1, Convert.ToDateTime(dtpfrom.Text), Convert.ToDateTime(dtpTo.Text));

            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            SalaryView s1 = new SalaryView();
            s1.Show();
        }
    }
}
