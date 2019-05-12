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
    public partial class UpdatedHistoryReport : Form
    {
        public UpdatedHistoryReport()
        {
            InitializeComponent();
        }

        private void UpdatedHistoryReport_Load(object sender, EventArgs e)
        {
            string from = InventoryReport.from;
            string to = InventoryReport.to;

            Microsoft.Reporting.WinForms.ReportParameter[] rParams = new Microsoft.Reporting.WinForms.ReportParameter[]
          {
                  new Microsoft.Reporting.WinForms.ReportParameter("fromDate", from),
                  new Microsoft.Reporting.WinForms.ReportParameter("toDate", to)
          };

            DateTime fromDate = DateTime.Parse(from);
            DateTime toDate = DateTime.Parse(to);

            reportUpdated.LocalReport.SetParameters(rParams);
            // TODO: This line of code loads data into the 'UpdateHistoryData.inventoryHistory' table. You can move, or remove it, as needed.
            this.inventoryHistoryTableAdapter.Fill(this.UpdateHistoryData.inventoryHistory, fromDate, toDate);

            this.reportUpdated.RefreshReport();
        }
    }
}
