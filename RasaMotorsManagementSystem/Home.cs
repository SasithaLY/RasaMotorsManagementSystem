using RasaMotorsManagementSystem.Supplier;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RasaMotorsManagementSystem.Inventory;
using RasaMotorsManagementSystem.Employees;
using System.Data.SqlClient;
using RasaMotorsManagementSystem.CustomerVehicles;

namespace RasaMotorsManagementSystem
{
    public partial class Home : Form
    {
        String username, jstatus;
        public Home(String uname, String jStatus)
        {
            InitializeComponent();
            username = uname;
            jstatus = jStatus;

        }

        string connString = Common.Utils.ConnectionString;

        private void button3_Click(object sender, EventArgs e)
        {
            suppliers supplier = new suppliers();
            supplier.ShowDialog();
        }
        
        private void btnInventory_Click(object sender, EventArgs e)
        {
            InventoryView inventoryView = new InventoryView();
            inventoryView.checkInstance.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ViewEmployee viewEmp = new ViewEmployee();
            viewEmp.Show();
        }

        private void jobBtn_Click(object sender, EventArgs e)
        {
            new JobCard.searchJob().Show();
        }

        private void btnNotifications_Click(object sender, EventArgs e)
        {
     
        }


        public void notify()
        {
            SqlConnection conn = new SqlConnection(connString);
            //sql query
            string sql = "SELECT itemID, itemName, availableQty FROM inventory where availableQty < minQty";

            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            SqlDataReader reader;

            try
            {
                conn.Open();
                reader = cmd.ExecuteReader();

                int count = 0;
                while (reader.Read())
                {
                    string id = reader.GetValue(0).ToString();
                    string itemName = reader.GetString(1);
                    string quantity = reader.GetValue(2).ToString();   
                    toolStripDropDownButton1.DropDownItems.Add(itemName + " - Low Quantity : "+quantity);
                    count++;
                }
                lblNotifications.Text = count.ToString();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }  

        private void Home_Activated(object sender, EventArgs e)
        {
            toolStripDropDownButton1.DropDownItems.Clear();
            notify();
        }

        private void listNotifications_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        Boolean flag = true;
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
            if(flag == true)
            {
                toolStripDropDownButton1.ShowDropDown();
                pictureBox2.BackColor = Color.DimGray;
                flag = false; 
            }
            else
            {
                pictureBox2.BackColor = Color.Transparent;
                flag = true;
            }
            
            
        }


        private void cusBtn_Click(object sender, EventArgs e)
        {
            frmCustomerList nList = new frmCustomerList();
            nList.ShowDialog();
        }
        
        private void btnFinance_Click(object sender, EventArgs e)
        {
            new Finance.calculation().Show();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            new Salary.Salaryform().Show();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            //if (flag == true)
            //{
            //    pictureBox2.BackColor = Color.DimGray;
            //    flag = false;
            //}
            //else
            //{
            //    pictureBox2.BackColor = Color.Transparent;
            //    flag = true;
            //}
        }

        private void Home_Load(object sender, EventArgs e)
        {
            if( jstatus == "Cashier")
            {
                logLbl.Text = "Hi Welcome Back " + username;
                btnInventory.Visible = false;
                btnFinance.Visible = false;
                btnSupplier.Visible = false;
                btnSalary.Visible = false;
                btnEmployee.Visible = false;
                btnReports.Visible = false;
                btnUserManagement.Visible = false;
            }
            else if( jstatus == "Supervisor")
            {
                logLbl.Text = "Hi Welcome Back " + username;
                btnFinance.Visible = false;
                btnReports.Visible = false;
                btnUserManagement.Visible = false;
            }
            else
            {
                logLbl.Text = "Hi Welcome Back " + username;
            }
        }

    

        private void btnReports_Click_1(object sender, EventArgs e)
        {
            frmReports reports = new frmReports();
            reports.Show();
        }

        private void btnUserManagement_Click(object sender, EventArgs e)
        {
            new Login.userManagement().Show();
        }

        private void Home_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmLogin login = new frmLogin();
            login.checkInstance.Show();
            Application.OpenForms.Cast<Form>().Where(x => !(x is frmLogin)).ToList().ForEach(x => x.Close());
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            
                pictureBox2.BackColor = Color.Transparent;
                
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            pictureBox2.BackColor = Color.DimGray;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            frmLogin login = new frmLogin();
            login.checkInstance.Show();
        }
    }
}
