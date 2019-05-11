using RasaMotorsManagementSystem.Login;
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

namespace RasaMotorsManagementSystem
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        private static frmLogin instance;

        public frmLogin checkInstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new frmLogin();
                }
                else
                {
                    instance.BringToFront();
                    instance.Focus();
                }
                return instance;
            }
        }
        string connString = Common.Utils.ConnectionString;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
           
        }

        public void clear()
        {
            textBoxUserName.Text = "";
            textBoxPass.Text = "";
            txtSt.Text = "";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (textBoxUserName.Text == "" || textBoxPass.Text == "")
            {
                MessageBox.Show("Fill the Username and Password!");
            }
            else
            {
                SqlConnection conn = new SqlConnection(connString);

                conn.Open();

                string sql = "SELECT userName, password, jobstatus from login where userName='" + textBoxUserName.Text + "' and password='" + textBoxPass.Text + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    txtSt.Text = dr["jobstatus"].ToString();
                }

                if (dt.Rows.Count > 0)
                {
                    new Home(textBoxUserName.Text, txtSt.Text).Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Login Failed");
                }

                conn.Close();
                clear();
            }
        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            instance = null;
        }
    }
}
