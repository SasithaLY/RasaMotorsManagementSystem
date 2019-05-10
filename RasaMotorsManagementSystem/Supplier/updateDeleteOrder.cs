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
    public partial class updateDeleteOrder : Form
    {
        public updateDeleteOrder()
        {
            InitializeComponent();
        }

        orderClass c = new orderClass();

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void order_Load(object sender, EventArgs e)
        {

            DataTable dt = c.Select();

            // orderView.DataSource = dt;
        }


        //Clear data
        public void Clear()
        {
            txtOrdID.Text = "";
            txtSupName.Text = "";
            orderDate.Text = "";
            cmbInType.Text = "";
            txtAmount.Text = "";
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            try
            {
                //update data
                c.orderID = int.Parse(txtOrdID.Text);
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

                else if (c.inventoryType == "")
                {
                    MessageBox.Show("Empty Fields or Invalid Inventory Type");
                }

                //Update data

                else
                {
                    if (DialogResult.Yes == MessageBox.Show("Are you sure you want to update this order?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Information))
                    {
                        bool success = c.Update(c);

                        if (success == true)
                        {
                            MessageBox.Show("Order successfully updated!");

                            //Lord data dgv
                            DataTable dt = c.Select();

                            //orderView.DataSource = dt;

                            //clear data
                            Clear();
                            this.Hide();

                        }
                        else
                        {
                            MessageBox.Show("Faild to update Order, Try again!");
                        }
                    }
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show("Fields are empty");
            }


        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //clear data
            Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (DialogResult.Yes == MessageBox.Show("Are you sure you want to remove this order?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Information))
                {
                    //delete data
                    c.orderID = Convert.ToInt32(txtOrdID.Text);

                    //deleting data

                    bool success = c.Delete(c);

                    if (success == true)
                    {
                        MessageBox.Show("Order successfully deleted!");

                        //Lord data dgv
                        DataTable dt = c.Select();

                        //orderView.DataSource = dt;

                        //clear data
                        Clear();
                        this.Hide();


                    }
                    else
                    {
                        MessageBox.Show("Faild to delete Order, Try again!");
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Order not selected");
            }
        }

        static string connectionString = Common.Utils.ConnectionString;


        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            supplieInsert supplier = new supplieInsert();
            supplier.ShowDialog();
        }

        private void orderDate_ValueChanged_1(object sender, EventArgs e)
        {

        }

        private void btnView_Click(object sender, EventArgs e)
        {
            this.Hide();
            orderAdd order = new orderAdd();
            order.ShowDialog();
        }

        private void orderView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBack_Click_1(object sender, EventArgs e)
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
    }
}
