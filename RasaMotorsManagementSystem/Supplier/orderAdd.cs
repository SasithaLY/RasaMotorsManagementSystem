using RasaMotorsManagementSystem.Supplier.ordersClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RasaMotorsManagementSystem.Supplier
{
    public partial class orderAdd : Form
    {
        public orderAdd()
        {
            InitializeComponent();
        }

        orderClass c = new orderClass();

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }



        private void ordADD_Click(object sender, EventArgs e)
        {
            //add the values
            c.supplierName = txtSupName.Text;
            c.orderDate = orderDate.Text;
            c.inventoryType = cmbInType.Text;
            c.amount = Double.Parse(txtAmount.Text);

            string supplierNamePattern = "^[a-zA-Z][a-zA-Z\\s]+$";
            string amountPattern = "^[1 - 9]\\d * (\\.\\d +)?$";

            bool isSupplierNamePattern = Regex.IsMatch(txtSupName.Text, supplierNamePattern);
            bool isAmountPattern = Regex.IsMatch(txtAmount.Text, amountPattern);

            if (c.supplierName == "" || c.orderDate == "" || c.inventoryType == "" || c.amount.Equals(""))
            {
                MessageBox.Show("Please fill the Fields");
            }

            else if (!isSupplierNamePattern || c.supplierName == "")
            {
                MessageBox.Show("Empty Fields or Invalid Supplier name");
            }

            else if (isAmountPattern || c.amount.Equals(""))
            {
                MessageBox.Show("Empty Fields or Invalid Amount");
            }

            else
            {


                //Inserting data

                bool success = c.Insert(c);

                if (success == true)
                {
                    MessageBox.Show("New order successfully inserted!");

                    DataTable dt = c.Select();
                    //clear data
                    Clear();


                }
                else
                {
                    MessageBox.Show("Faild to add new order, Try again!");
                }

                //Lord data dgv



                //orderView.DataSource = dt;

            }
        }

        private void order_Load(object sender, EventArgs e)
        {

            DataTable dt = c.Select();

            //orderView.DataSource = dt;
        }


        //Clear data
        public void Clear()
        {
            // txtOrdID.Text = "";
            txtSupName.Text = "";
            orderDate.Text = "";
            cmbInType.Text = "";
            txtAmount.Text = "";
        }


        private void btnClear_Click_1(object sender, EventArgs e)
        {
            //clear data
            Clear();
        }

        static string connectionString = Common.Utils.ConnectionString;


        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            orderInsert order = new orderInsert();
            order.ShowDialog();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            this.Hide();
            orderInsert order = new orderInsert();
            order.ShowDialog();
        }

        private void txtSupName_TextChanged(object sender, EventArgs e)
        {
            if (txtSupName.Text == "")
            {
                labSupName.Visible = false;
            }

            else if (!Regex.IsMatch(txtSupName.Text, "^[a-zA-Z][a-zA-Z\\s]+$"))
            {
                labSupName.Visible = true;
            }

            else
            {
                labSupName.Visible = false;
            }
        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {
            if (txtAmount.Text == "")
            {
                labAmount.Visible = false;
            }

            else if (!Regex.IsMatch(txtAmount.Text, @"^[0-9.9]+$"))
            {
                labAmount.Visible = true;
            }

            else
            {
                labAmount.Visible = false;
            }
        }

        private void btnDemo_Click(object sender, EventArgs e)
        {
            txtSupName.Text = "Thilina";
            cmbInType.Text = "Bumper";
            txtAmount.Text = "2000";
        }
    }
}
