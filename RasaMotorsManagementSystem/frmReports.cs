using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RasaMotorsManagementSystem
{
    public partial class frmReports : Form
    {
        public frmReports()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            new CustomerVehicles.CusVehReportViewer().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Employees.EmployeeReport().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Finance.reportViewer().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Inventory.InventoryReport().Show();
        }

        private void btnJbRprt_Click(object sender, EventArgs e)
        {
            new JobCard.JobReport().Show();
        }

        private void btSpRprt_Click(object sender, EventArgs e)
        {
            new Supplier.reportViewSup().Show();
        }

        private void btnSalRprt_Click(object sender, EventArgs e)
        {
            new Salary.salaryreport().Show();
        }
    }
}
