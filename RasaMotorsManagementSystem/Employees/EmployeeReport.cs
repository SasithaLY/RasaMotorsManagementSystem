using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RasaMotorsManagementSystem.Employees
{
    public partial class EmployeeReport : Form
    {
        public EmployeeReport()
        {
            InitializeComponent();
        }

        private void EmployeeReport_Load(object sender, EventArgs e)
        {
           
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            this.empTableAdapter.Fill(this.EmployeeDataSet.emp, dateTimePickerFrom.Text, dateTimePickerTo.Text);

            this.reportViewerEmp.RefreshReport();
        }
    }
}
