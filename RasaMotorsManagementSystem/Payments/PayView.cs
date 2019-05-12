using RasaMotorsManagementSystem.Employees.PaymentClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RasaMotorsManagementSystem.Payments
{
    public partial class PayView : Form
    {
        string conString = Common.Utils.ConnectionString;
        public PayView()
        {
            InitializeComponent();
        }

        Payment1 p = new Payment1();
       

        private void button2_Click(object sender, EventArgs e)
        {
            //Get Data from the Textboxes
            p.CustomerID = Convert.ToInt32(txtCustomer.Text);
            bool success = p.Delete(p);
            if (success == true)
            {
                //Successfully Deleted
                MessageBox.Show("Contact Successfully deleted");
                //Refresh the Data Grid veiw

                DataTable dt = p.Select();
                PaymentDetails.DataSource = dt;
            }
            else
            {
                //Failed to delete
                MessageBox.Show("Failed to Delete. Try again.");
            }

        }



        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                float BillAmount = Convert.ToInt32(txtBill.Text);
                float DiscountAmount = Convert.ToInt32(txtDis.Text);

                float NetAmount = (BillAmount - DiscountAmount);
                txtNet.Text = NetAmount.ToString();

                if (NetAmount == BillAmount)
                {
                    MessageBox.Show("No Discounts Applied!!");
                }
                else
                {
                    MessageBox.Show("Discounts Applied.");
                }
                //Get the Data from Textboxes
                p.BillAmount = int.Parse(txtBill.Text);
                p.DiscountAmount = int.Parse(txtDis.Text);
                p.NetAmount = int.Parse(txtNet.Text);
                p.CustomerID = int.Parse(txtCustomer.Text);
                //Update data in database

                string BillAmountPattern = "^[1 - 9]\\d * (\\.\\d +) ?$";
                string DiscountAmountPattern = "^[1 - 9]\\d * (\\.\\d +) ?$";
                string NetAmountPattern = "^[1 - 9]\\d * (\\.\\d +) ?$";

                bool isBillValid = Regex.IsMatch(txtBill.Text, BillAmountPattern);
                bool isDiscountValid = Regex.IsMatch(txtDis.Text, DiscountAmountPattern);
                bool isNetValid = Regex.IsMatch(txtNet.Text, NetAmountPattern);

                if (isBillValid)
                {
                    MessageBox.Show("Please enter a valid Amount.");
                }
                else if (isDiscountValid)
                {
                    MessageBox.Show("Please enter a valid Amount.");
                }
                else if (isNetValid)
                {
                    MessageBox.Show("Please enter a valid Amount.");
                }
                else
                {

                    bool success = p.Update(p);
                    if (success == true)
                    {
                        //Updated Successfully
                        MessageBox.Show("Payment has been Updated");
                        //Load Data table into the DataGrid
                        DataTable dt = p.Select();
                        PaymentDetails.DataSource = dt;
                        //Call the clear method
                        //Clear();
                    }
                    else
                    {
                        //Failed to Update
                        MessageBox.Show("Failed to Update Payment.Try Again");
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void PaymentDetails_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Get data from DataGrid Veiw in to the text boxes respectively
            //Identify the row where the mouse is clicked
            int rowIndex = e.RowIndex;
            txtCustomer.Text = PaymentDetails.Rows[rowIndex].Cells[0].Value.ToString();
            txtJob.Text = PaymentDetails.Rows[rowIndex].Cells[1].Value.ToString();
            txtDateF.Text = PaymentDetails.Rows[rowIndex].Cells[2].Value.ToString();
            txtDateT.Text = PaymentDetails.Rows[rowIndex].Cells[3].Value.ToString();
            txtCustomerN.Text = PaymentDetails.Rows[rowIndex].Cells[4].Value.ToString();
            txtVehicleN.Text = PaymentDetails.Rows[rowIndex].Cells[6].Value.ToString();
            txtMobileN.Text = PaymentDetails.Rows[rowIndex].Cells[7].Value.ToString();
            txtBill.Text = PaymentDetails.Rows[rowIndex].Cells[8].Value.ToString();
            txtDis.Text = PaymentDetails.Rows[rowIndex].Cells[9].Value.ToString();
            txtNet.Text = PaymentDetails.Rows[rowIndex].Cells[10].Value.ToString();

        }
        private void PayView_Load(object sender, EventArgs e)
        {
            //Load Data table into the DataGrid
            DataTable dt = p.Select();
            PaymentDetails.DataSource = dt;
        }


        private void button4_Click(object sender, EventArgs e)
        {
            // Main Page
            new PaymentMain().Show();
            this.Hide();
        }

        private void PaymentDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            //Get the value from text box
            string keyword = textBox1.Text;
            SqlConnection conn = new SqlConnection(conString);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM payN WHERE CustomerName LIKE '%" + keyword + "%' OR VehicleNumber LIKE '%" + keyword + "%'", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            PaymentDetails.DataSource = dt;
        }

        private void txtDateT_TextChanged(object sender, EventArgs e)
        {

        }

        // private void PayView_Load(object sender, EventArgs e)
        // {
        //Load Data table into the DataGrid
        //     DataTable dt = p.Select();
        //    PaymentDetails.DataSource = dt;
        //}
    }
}
