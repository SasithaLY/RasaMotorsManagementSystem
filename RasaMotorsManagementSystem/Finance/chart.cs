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

namespace RasaMotorsManagementSystem.Finance
{
    public partial class chart : Form
    {
        public chart()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new calculation().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            new reportViewer().Show();
        }

        private void chart_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-T0HOCLV;Initial Catalog=ServiceCenterManagementDB;Integrated Security=True");
            DataSet ds = new DataSet();
            con.Open();
            SqlDataAdapter adapt = new SqlDataAdapter("Select * from tbl_Chart", con);
            adapt.Fill(ds);
            chart1.DataSource = ds;
            //set the member of the chart data source used to data bind to the X-values of the series  
            chart1.Series["Profit"].XValueMember = "Month";
            //set the member columns of the chart data source used to data bind to the X-values of the series  
            chart1.Series["Profit"].YValueMembers = "NetProfit";
            chart1.Titles.Add("Profit Chart");
            con.Close();
        }
    }
}
