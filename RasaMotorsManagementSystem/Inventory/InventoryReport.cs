using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RasaMotorsManagementSystem.Inventory
{
    public partial class InventoryReport : Form
    {
        public InventoryReport()
        {
            InitializeComponent();
        }

        private void InventoryReport_Load(object sender, EventArgs e)
        {
            
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'InventoryData.inventory' table. You can move, or remove it, as needed.
            this.inventoryTableAdapter.Fill(this.InventoryData.inventory, dtpFrom.Value, dtpTo.Value);

            this.reportViewer1.RefreshReport();
        }
    }
}
