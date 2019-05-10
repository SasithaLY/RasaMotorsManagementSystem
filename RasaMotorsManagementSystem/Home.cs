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
        public Home()
        {
            InitializeComponent();  
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {  
            toolStripDropDownButton1.ShowDropDown();
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
    }
}
