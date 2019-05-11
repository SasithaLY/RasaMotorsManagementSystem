using RasaMotorsManagementSystem.Employees.PaymentClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RasaMotorsManagementSystem.Payments
{
    public partial class PayHistory : Form
    {
        public PayHistory()
        {
            InitializeComponent();
        }
        Payment1 p = new Payment1();
        private void button3_Click(object sender, EventArgs e)
        {
            // Main Page
            new PaymentMain().Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Get Data from the Textboxes
            //p.CustomerID = Convert.ToInt32(textBox1.Text);
            bool success = p.Delete(p);
            if (success == true)
            {
                //Successfully Deleted
                MessageBox.Show("Contact Successfully deleted");
                //Refresh the Data Grid veiw

                DataTable dt = p.Select();
                dgvHistory.DataSource = dt;
            }
        }

        private void Print_Click(object sender, EventArgs e)
        {
            // Main Page
            new Report().Show();
            this.Hide();
        }
        private void PayHistory_Load(object sender, EventArgs e)
        {
            //Load Data table into the DataGrid
            DataTable dt = p.Select();
            dgvHistory.DataSource = dt;
        }

        private void dgvHistory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

}
