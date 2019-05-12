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
    public partial class Salaryform : Form
    {
        public static SqlConnection con = new SqlConnection("Data Source=DESKTOP-T0HOCLV;Initial Catalog=ServiceCenterManagementDB;Integrated Security=True");
        public Salaryform()
        {
            InitializeComponent();
            timer1.Start();
        }

        ssalaryclass s = new ssalaryclass();

        private void Edit_details_Click(object sender, EventArgs e)
        {
            //view button
            this.Hide();
            EditDetails f = new EditDetails();
            f.Show();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                SalaryView f3 = new SalaryView();//shortcuts key


                //Get value from the table
                s.EmployeeID = int.Parse(combo.Text);
                s.BasicSalary = int.Parse(txtBasic.Text);
                s.OTHours = int.Parse(txtOT.Text);
                s.Bonus = int.Parse(TxtBonus.Text);
                s.Date = dateTimePicker1.Value;
                s.EtfEpf = int.Parse(txtEpf.Text);
                s.OTPayment = int.Parse(txtRate.Text);
                s.Total = int.Parse(txtTot.Text);

                string OTHours = "^[0-9]*[.][0-9]*$";
                string Bonus = " ^[0 - 9] *[.][0 - 9] * $";
                // string Date = "{0:d/MM/yyyy}";

                bool isOTHoursValid = Regex.IsMatch(txtOT.Text, OTHours);
                bool isBonusValid = Regex.IsMatch(TxtBonus.Text, Bonus);


                if (txtOT.Text == "" || TxtBonus.Text == "" || txtTot.Text == "")
                {
                    MessageBox.Show("fileds are empty");
                }

                else
                {
                    //insert data into database
                    bool successs = s.Insert(s);
                    if (successs == true)
                    {
                        MessageBox.Show("inserted successfully");
                    }
                    else
                    {
                        MessageBox.Show("insert fail,Try again");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("fileds are empty");
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            //view button
            this.Hide();
            SalaryView f4 = new SalaryView();
            f4.Show();
        }

        public void Clear()
        {

            txtBasic.Text = "";
            txtOT.Text = "";
            txtRate.Text = "";
            txtEpf.Text = "";
            TxtBonus.Text = "";

            txtTot.Text = "";



        }

        private void btnClear_Click(object sender, EventArgs e)
        {

            this.Clear();
        }

        private void combo_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM emp WHERE EmployeeID='" + combo.SelectedItem.ToString() + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    txtBasic.Text = dr["Salary"].ToString();

                }
                con.Close();

                con.Open();
                SqlCommand cm = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM EditDet WHERE ID='" + combo.SelectedItem.ToString() + "'";
                cmd.ExecuteNonQuery();
                DataTable d = new DataTable();
                SqlDataAdapter f = new SqlDataAdapter(cm);
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    txtRate.Text = dr["OTPayment"].ToString();
                    txtEpf.Text = dr["EtfEpf"].ToString();

                }
                con.Close();
            }
            catch (Exception ex)
            {

            }
        }

        private void TxtBonus_TextChanged(object sender, EventArgs e)
        {


            if (TxtBonus.Text == "")
            {
                labbon.Visible = false;
            }
            else if (s.Bonus < 0)
            {
                labbon.Visible = true;
            }
            else if (!Regex.IsMatch(TxtBonus.Text, @"^[0-9.9]+$"))
            {
                labbon.Visible = true;
            }

            else
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
                catch(Exception ex)
                {

                }


            }
        }

        private void txtOT_TextChanged(object sender, EventArgs e)
        {

            if (txtOT.Text == "")
            {
                labot.Visible = false;
            }
            else if (s.OTHours < 0)
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
            else if (!Regex.IsMatch(txtOT.Text, @"^[0-9.9]+$"))
            {
                TxtBonus.Enabled = true;
            }
            else
            {
                labot.Visible = false;
                TxtBonus.Enabled = false;
            }
        }

        private void Salaryform_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                BtnAdd.PerformClick();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            DateTime dateTime = DateTime.Now;
            this.Time.Text = dateTime.ToString();
        }

        public void fill()
        {
            try
            {
                combo.Items.Clear();
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from emp";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    combo.Items.Add(dr["EmployeeID"].ToString());
                }
                con.Close();
            }
            catch (Exception ex)
            {

            }
        }

        private void Salaryform_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            fill();
        }

        private void txtRate_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
