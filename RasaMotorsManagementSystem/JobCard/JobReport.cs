﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RasaMotorsManagementSystem.JobCard
{
    public partial class JobReport : Form
    {
        public JobReport()
        {
            InitializeComponent();
        }

        private void JobReport_Load(object sender, EventArgs e)
        {
           
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'jobData.jobPred' table. You can move, or remove it, as needed.
            this.jobPredTableAdapter.Fill(this.jobData.jobPred, Convert.ToDateTime(dtFrm.Text), Convert.ToDateTime(dtTo.Text));

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
