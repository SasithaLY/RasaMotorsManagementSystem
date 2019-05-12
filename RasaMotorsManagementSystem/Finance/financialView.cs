﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RasaMotorsManagementSystem.Finance
{
    public partial class financialView : Form
    {
        public financialView()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            new calculation().Show();
            this.Close();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            this.Hide();
           reportViewer manager = new reportViewer();

           manager.ShowDialog();
            this.Close();
        }

       
        private void dgvFinancial_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            financeUpDel cus = new financeUpDel();
            cus.txtID.Text = this.dgvFinancial.CurrentRow.Cells[0].Value.ToString();
            cus.txtTotIncome.Text = this.dgvFinancial.CurrentRow.Cells[1].Value.ToString();
            cus.txtInvenSales.Text = this.dgvFinancial.CurrentRow.Cells[2].Value.ToString();
            cus.txtOrder.Text = this.dgvFinancial.CurrentRow.Cells[3].Value.ToString();
            cus.txtInvenPay.Text = this.dgvFinancial.CurrentRow.Cells[4].Value.ToString();
            cus.txtUtilityPay.Text = this.dgvFinancial.CurrentRow.Cells[5].Value.ToString();
            cus.txtSal.Text = this.dgvFinancial.CurrentRow.Cells[6].Value.ToString();
            cus.txtCal.Text = this.dgvFinancial.CurrentRow.Cells[7].Value.ToString();
            cus.txtDate.Text = this.dgvFinancial.CurrentRow.Cells[8].Value.ToString();
            cus.ShowDialog();
            this.Close();
        }

        private void financialView_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'serviceCenterManagementDBDataSet1.tbl_Profit' table. You can move, or remove it, as needed.
           this.tbl_ProfitTableAdapter1.Fill(this.serviceCenterManagementDBDataSet1.tbl_Profit);
            // TODO: This line of code loads data into the 'serviceCenterManagementDBDataSet.tbl_Profit' table. You can move, or remove it, as needed.
           // this.tbl_ProfitTableAdapter.Fill(this.serviceCenterManagementDBDataSet.tbl_Profit);

        }
    }
}
