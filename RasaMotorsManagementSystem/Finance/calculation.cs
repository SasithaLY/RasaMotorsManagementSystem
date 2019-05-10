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

namespace RasaMotorsManagementSystem.Finance
{
    public partial class calculation : Form
    {
        public static SqlConnection conn = new SqlConnection("Data Source=DESKTOP-T0HOCLV;Initial Catalog=ServiceCenterManagementDB;Integrated Security=True");

        public calculation()
        {
            InitializeComponent();
        }

       serviceCenterClasses.netProfit c = new serviceCenterClasses.netProfit();

        private void btnLoad_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select sum(NetAmount) as net from pay where ToDate between '" + Convert.ToDateTime(dtPckr.Text) + "'and'" + Convert.ToDateTime(dtPkr1.Text) + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                txtTotIncome.Text = dr["net"].ToString();
            }



            SqlCommand cmd1 = conn.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "select sum(Total) as tot from sal where Date between '" + Convert.ToDateTime(dtPckr.Text) + "'and'" + Convert.ToDateTime(dtPkr1.Text) + "'";
            cmd1.ExecuteNonQuery();
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
            da1.Fill(dt1);
            foreach (DataRow dr in dt1.Rows)
            {
                txtSal.Text = dr["tot"].ToString();
            }

            SqlCommand cmd2 = conn.CreateCommand();
            cmd2.CommandType = CommandType.Text;
            cmd2.CommandText = "select sum(amount) as tot from orderDetails where orderDate between '" + Convert.ToDateTime(dtPckr.Text) + "'and'" + Convert.ToDateTime(dtPkr1.Text) + "'";
            cmd2.ExecuteNonQuery();
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
            da2.Fill(dt2);
            foreach (DataRow dr in dt2.Rows)
            {
                txtOrder.Text = dr["tot"].ToString();
            }
            conn.Close();


        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            try
            {
                float totIn = Convert.ToInt32(txtTotIncome.Text);
                float InvenSale = Convert.ToInt32(txtInvenSales.Text);
                float order = Convert.ToInt32(txtOrder.Text);
                float InvenPay = Convert.ToInt32(txtInvenPay.Text);
                float Utility = Convert.ToInt32(txtUtilityPay.Text);
                float salary = Convert.ToInt32(txtSal.Text);


                float profit = (totIn + InvenSale) - (order + InvenPay + Utility + salary);
                txtCal.Text = profit.ToString();

                if (profit < 0)
                {
                    MessageBox.Show("This is a LOST!!!");
                }
                else
                {
                    MessageBox.Show("This month is PROFITABLE....");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fields are Empty!");
            }
        }
       
        
        
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                c.Income = float.Parse(txtTotIncome.Text);
                c.InvenSal = float.Parse(txtInvenSales.Text);
                c.Orders = float.Parse(txtOrder.Text);
                c.InvenPay = float.Parse(txtInvenPay.Text);
                c.Utility = float.Parse(txtUtilityPay.Text);
                c.Salary = float.Parse(txtSal.Text);
                c.Profit = float.Parse(txtCal.Text);
                c.Date = DateTime.Parse(dtPckr.Text);


                bool Success = c.Insert(c);
                if (Success == true)
                {
                    MessageBox.Show(".....completed......");

                }
                else
                {
                    MessageBox.Show(".....error occured....");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("...Fields cannot be empty...");
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            new financialView().Show();
            this.Close();
        }

        private void txtTotIncome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((e.KeyChar >= 48 && e.KeyChar <= 57) || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                MessageBox.Show("please enter only numbers.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }

        private void txtInvenSales_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                MessageBox.Show("please enter only numbers.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }

        private void txtOrder_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                MessageBox.Show("please enter only numbers.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }

        private void txtInvenPay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                MessageBox.Show("please enter only numbers.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }

        private void txtUtilityPay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                MessageBox.Show("please enter only numbers.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }

        private void txtSal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                MessageBox.Show("please enter only numbers.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }
    }
}
