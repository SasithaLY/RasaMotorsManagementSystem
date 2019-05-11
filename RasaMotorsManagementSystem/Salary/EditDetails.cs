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
    public partial class EditDetails : Form
    {


        public static SqlConnection con = new SqlConnection("Data Source=DESKTOP-T0HOCLV;Initial Catalog=ServiceCenterManagementDB;Integrated Security=True");

       
        public EditDetails()
        {
            InitializeComponent();
        }

        EditDe ob = new EditDe();

        public void fillcombo()
        {
            try
            {
                comboStates.Items.Clear();
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
                    comboStates.Items.Add(dr["Occupation"].ToString());
                }
                con.Close();
            }
            catch (Exception ex)
            {

            }
        }

        private void comboStates_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM emp WHERE Occupation='" + comboStates.SelectedItem.ToString() + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                txtBasic.Text = dr["Salary"].ToString();
            }
            con.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                ob.JobState = comboStates.Text;
                ob.BasicSalary = float.Parse(txtBasic.Text);
                ob.OTPayment = float.Parse(TxtPayments.Text);
                ob.EtfEpf = float.Parse(txtEpf.Text);
                // c.Bonus = float.Parse(TxtBonus.Text);
                // c.Date = dateTimePicker1.Value.Date;

                if (comboStates.Text == "" || txtBasic.Text == "" || TxtPayments.Text == "" || txtEpf.Text == "")
                {
                    MessageBox.Show("fileds are empty");
                }
                else
                {

                    //insert data into database usinf values
                    bool success = ob.Update(ob);
                    if (success == true)
                    {
                        MessageBox.Show("successfully inserted");
                        //call the clear method here


                    }
                    else
                    {
                        MessageBox.Show("failed to add,try again");
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void EditDetails_Load(object sender, EventArgs e)
        {
            fillcombo();
        }

        private void back_Click(object sender, EventArgs e)
        {

            //view button
            this.Hide();
            Salaryform f4 = new Salaryform();
            f4.Show();
        }

        private void txtBasic_TextChanged(object sender, EventArgs e)
        {
            if (txtBasic.Text == "")
            {
                labbasic.Visible = false;
            }
            else if (ob.BasicSalary < 0)
            {
                labbasic.Visible = true;
            }
            else if (!Regex.IsMatch(txtBasic.Text, @"^[0-9.9]+$"))
            {
                labbasic.Visible = true;
            }
            else
            {
                labbasic.Visible = false;
            }

        }

        private void TxtPayments_TextChanged(object sender, EventArgs e)
        {
            if (TxtPayments.Text == "")
            {
                labot.Visible = false;
            }
            else if (ob.BasicSalary < 0)
            {
                labot.Visible = true;
            }
            else if (!Regex.IsMatch(TxtPayments.Text, @"^[0-9.9]+$"))
            {
                labot.Visible = true;
            }
            else
            {
                labot.Visible = false;
            }
        }

        private void txtEpf_TextChanged(object sender, EventArgs e)
        {
            if (txtEpf.Text == "")
            {
                labetf.Visible = false;
            }
            else if (ob.BasicSalary < 0)
            {
                labetf.Visible = true;
            }
            else if (!Regex.IsMatch(txtEpf.Text, @"^[0-9.9]+$"))
            {
                labetf.Visible = true;
            }
            else
            {
                labetf.Visible = false;
            }
        }
    }
}
