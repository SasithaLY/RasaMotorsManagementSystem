using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RasaMotorsManagementSystem.Inventory.StockInDataSetTableAdapters;

namespace RasaMotorsManagementSystem.Inventory
{
    public partial class InventoryReport : Form
    {
        public static string from, to;
        public InventoryReport()
        {
            InitializeComponent();
        }

        private void InventoryReport_Load(object sender, EventArgs e)
        {
          
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            from = dtpInventoryFrom.Text;
            to = dtpInventoryTo.Text;

            ItemsReport itemsReport = new ItemsReport();
            itemsReport.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            from = dtpInventoryFrom.Text;
            to = dtpInventoryTo.Text;

            ReturnsReport returnsReport = new ReturnsReport();
            returnsReport.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            from = dtpInventoryFrom.Text;
            to = dtpInventoryTo.Text;

            if (rbAll.Checked)
            {
                HistoryReportAll historyReport = new HistoryReportAll();
                historyReport.Show();
            }
            else if(rbUpdate.Checked)
            {
                UpdatedHistoryReport updatedHistory = new UpdatedHistoryReport();
                updatedHistory.Show();

            }else if (rbDelete.Checked)
            {
                DeleteHistoryReport deleteHistory = new DeleteHistoryReport();
                deleteHistory.Show();
            }

           
        }

        private void btnStockIn_Click(object sender, EventArgs e)
        {
            from = dtpInventoryFrom.Text;
            to = dtpInventoryTo.Text;

            StockInReport stockInReport = new StockInReport();
            stockInReport.Show();
        }
    }
}
