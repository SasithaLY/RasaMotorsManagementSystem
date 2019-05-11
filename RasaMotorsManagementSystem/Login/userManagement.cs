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

namespace RasaMotorsManagementSystem.Login
{
    public partial class userManagement : Form
    {
        

        public userManagement()
        {
            InitializeComponent();
           
        }
        

        string myconnstring = Common.Utils.ConnectionString;
        LoginClass c = new LoginClass();

        

        private void userManagement_Load(object sender, EventArgs e)
        {
            txtId.Visible = false;
            DataTable dt = c.select();
            dgvLogIn.DataSource = dt;
            

        }

        public void clear()
        {
            txtId.Text = "";
            txtUsrname.Text = "";
            txtPwrd.Text = "";
            cmbJStatus.Text = "";
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                c.logId = Convert.ToInt32(txtId.Text);


                if (DialogResult.Yes == MessageBox.Show("Are you sure you want to remove this item?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Information))
                {

                    bool success = c.Delete(c);
                    if (success == true)
                    {
                        MessageBox.Show("Item Deleted Successfully!");
                        clear();
                        DataTable dt = c.select();
                        dgvLogIn.DataSource = dt;

                    }
                    else
                    {
                        MessageBox.Show("Item Delete Failed!");
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Item Delete Failed Due to Exception!");
            }
        }

        private void btnUpdt_Click(object sender, EventArgs e)
        {
            try
            {
                //Get data from textbox
                c.logId = int.Parse(txtId.Text);
                c.userName = txtUsrname.Text;
                c.password = txtPwrd.Text;
                c.jobStatus = cmbJStatus.Text;


                //update in database
                bool success = c.Update(c);
                if (success == true)
                {
                    MessageBox.Show("Successfully Updated!");
                    //Clear Fields
                    clear();
                    //update grid view
                    DataTable dt = c.select();
                    dgvLogIn.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Update Unsuccessful!");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnInsrt_Click(object sender, EventArgs e)
        {
            try
            {

                c.userName = txtUsrname.Text;
                c.password = txtPwrd.Text;
                c.jobStatus = cmbJStatus.Text;

                    SqlConnection sqlConnection = new SqlConnection(myconnstring);

                    sqlConnection.Open();
                    using (var sqlCommand = new SqlCommand("SELECT * FROM login  WHERE userName = '" + txtUsrname.Text + "'", sqlConnection))
                    {

                        SqlDataReader reader = sqlCommand.ExecuteReader();
                        if (reader.HasRows)
                        {
                            MessageBox.Show("UserName Already Exist!");

                        }
                        else
                        {

                            bool success = c.Insert(c);
                            if (success == true)
                            {
                                MessageBox.Show("User Successfully Created!");
                                //clear();
                            }
                            else
                            {
                                MessageBox.Show("User Creation Unsuccessful!");
                            }

                            DataTable dt = c.select();
                            dgvLogIn.DataSource = dt;

                        }

                        reader.Close();
                        reader.Dispose();
                    }

                    sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lblSession_Click(object sender, EventArgs e)
        {

        }

        private void dgvLogIn_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            txtId.Text = dgvLogIn.Rows[rowIndex].Cells[0].Value.ToString();
            txtUsrname.Text = dgvLogIn.Rows[rowIndex].Cells[1].Value.ToString();
            txtPwrd.Text = dgvLogIn.Rows[rowIndex].Cells[2].Value.ToString();
            cmbJStatus.Text = dgvLogIn.Rows[rowIndex].Cells[3].Value.ToString();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
