using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RasaMotorsManagementSystem.CustomerVehicles
{
    public partial class CusVehReportViewer : Form
    {
        public CusVehReportViewer()
        {
            InitializeComponent();
        }


        private void CusVehReportViewer_Load(object sender, EventArgs e)
        {
            
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            Microsoft.Reporting.WinForms.ReportParameter[] rParams = new Microsoft.Reporting.WinForms.ReportParameter[]
            {
                  new Microsoft.Reporting.WinForms.ReportParameter("fromDate", dtpCusVehFrom.Value.Date.ToShortDateString()),
                  new Microsoft.Reporting.WinForms.ReportParameter("toDate", dtpCusVehTo.Value.Date.ToShortDateString())
            };

            DateTime fromDate = DateTime.Parse(dtpCusVehFrom.Text);
            DateTime toDate = DateTime.Parse(dtpCusVehTo.Text);

            reportViewerCusVeh.LocalReport.SetParameters(rParams);

            // TODO: This line of code loads data into the 'CustomerVehicleDataSet.DataTable1' table. You can move, or remove it, as needed.
            this.DataTable1TableAdapter.Fill(this.CustomerVehicleDataSet.DataTable1, dtpCusVehFrom.Value, dtpCusVehTo.Value);

            this.reportViewerCusVeh.RefreshReport();
        }
    }
}
