using RasaMotorsManagementSystem.Salary.SalaryClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RasaMotorsManagementSystem.Salary
{
    public partial class update : Form
    {
        public static SqlConnection con = new SqlConnection("Data Source=DESKTOP-T0HOCLV;Initial Catalog=ServiceCenterManagementDB;Integrated Security=True");
        public update()
        {
            InitializeComponent();
        }

        ssalaryclass c1 = new ssalaryclass();

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {

                //get data from textbox
                c1.No = int.Parse(No.Text);
                c1.EmployeeID = int.Parse(txtID.Text);
                c1.OTHours = int.Parse(txtOT.Text);
                c1.Bonus = int.Parse(TxtBonus.Text);
                c1.EtfEpf = int.Parse(txtEpf.Text);
                c1.OTPayment = int.Parse(txtRate.Text);
                c1.BasicSalary = int.Parse(txtBasic.Text);
                c1.Total = int.Parse(txtTot.Text);

                string OTHours = "^[0-9]*[.][0-9]*$";
                string Bonus = " ^[0 - 9] *[.][0 - 9] * $";
                // string Date = "{0:d/MM/yyyy}";

                bool isOTHoursValid = Regex.IsMatch(txtOT.Text, OTHours);
                bool isBonusValid = Regex.IsMatch(TxtBonus.Text, Bonus);
                calculation();




                if (txtOT.Text == "" || TxtBonus.Text == "" || txtTot.Text == "")
                {
                    MessageBox.Show("Fields are Empty");
                }
                else
                {
                    if (DialogResult.Yes == MessageBox.Show("Are you sure want to update this?", "confirm", MessageBoxButtons.YesNo))
                    {
                        bool success = c1.Update(c1);
                        if (success == true)
                        {
                            //update successfully
                            MessageBox.Show("updated successfully");

                            //load data on datagridview
                            DataTable d = c1.Select();
                            //dataGrid.DataSource = d;


                            //clear method
                            //  clear();

                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fields are Empty");
            }

        }

        private void update_Load(object sender, EventArgs e)
        {
            //load data on datagridview
            DataTable dt = c1.Select();
            //c1.DataGrid.DataSource = dt;
        }

        private void TxtBonus_TextChanged(object sender, EventArgs e)
        {
            if (TxtBonus.Text == "")
            {
                labbo.Visible = false;
            }
            else if (c1.Bonus < 0)
            {
                labbo.Visible = true;
            }
            else if (!Regex.IsMatch(TxtBonus.Text, @"^[0-9.9]+$"))
            {
                labbo.Visible = true;
            }
            else
            {
                labbo.Visible = false;
            }
        }

        private void txtOT_TextChanged(object sender, EventArgs e)
        {
            if (txtOT.Text == "")
            {
                labot.Visible = false;

            }
            else if (c1.Bonus < 0)
            {
                labot.Visible = true;
            }
            else if (!Regex.IsMatch(txtOT.Text, @"^[0-9.9]+$"))
            {
                labot.Visible = true;
            }
            else if (txtOT.Text != string.Empty)
            {
                TxtBonus.Enabled = true;
            }

            else if (txtOT.Text == string.Empty)
            {
                TxtBonus.Enabled = false;
            }
            else
            {
                labot.Visible = false;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //SalaryView f1 = new SalaryView();
            //f1.Show();
            this.Hide();
        }

        public void calculation()
        {

            try
            {
                string a = txtOT.Text;
                string b = TxtBonus.Text;
                double OT = Convert.ToDouble(a);
                double Bonus = Convert.ToDouble(b);

                float BasicSalary = Convert.ToInt32(txtBasic.Text);

                float OTPayment = Convert.ToInt32(txtRate.Text);
                float EtfEpf = Convert.ToInt32(txtEpf.Text);

                double Total = (BasicSalary + (((OT * OTPayment) + Bonus) - EtfEpf));
                txtTot.Text = Total.ToString();
            }
            catch (Exception ex)
            { }

        }


    }

}
