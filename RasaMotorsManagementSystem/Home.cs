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

namespace RasaMotorsManagementSystem
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

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
    }
}
