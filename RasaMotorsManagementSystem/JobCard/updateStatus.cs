using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RasaMotorsManagementSystem.JobCard.jobCardClasses;

namespace RasaMotorsManagementSystem.JobCard
{
    public partial class updateStatus : Form
    {
        public updateStatus()
        {
            InitializeComponent();
        }

        assignJobclass obj = new assignJobclass();



        private void btnUpBack_Click(object sender, EventArgs e)
        {
            new JobCard.searchJob().Show();
            this.Close();
        }

        private void stUpdt_Click(object sender, EventArgs e)
        {
            try
            {
                searchJob us = new searchJob();
                //Get data from textbox
                obj.jobStatus = cmbStatus.Text;
                obj.Id = int.Parse(txtUJid.Text);


                //update in database
                bool success = obj.Update(obj);
                if (success == true)
                {
                    MessageBox.Show("Successfully Updated!");
                    //Clear Fields
                    //clear();
                    //update grid view
                    DataTable dt = obj.Select();
                    us.dgvAllJobs.DataSource = dt;

                }
                else
                {
                    MessageBox.Show("Failed to update!");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                obj.Id = Convert.ToInt32(txtUJid.Text);


                if (DialogResult.Yes == MessageBox.Show("Are you sure you want to remove this item?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Information))
                {

                    bool success = obj.Delete(obj);
                    if (success == true)
                    {
                        MessageBox.Show("Item Deleted Successfully!");

                    }
                    else
                    {
                        MessageBox.Show("Item Delete Failed!");
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Item Delete Failed Due to Exception!");
            }
        }
    }
}
