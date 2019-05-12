using RasaMotorsManagementSystem.CustomerVehicles.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RasaMotorsManagementSystem.CustomerVehicles
{
    public partial class frmVehUpdateDelete : Form
    {
        public frmVehUpdateDelete()
        {
            InitializeComponent();
        }

        VehicleClass v = new VehicleClass();

        private void btnUpdateVehicle_Click(object sender, EventArgs e)
        {
            if (validate())
            {
                //getting data form text fields

                v.VehicleID = int.Parse(textBoxId.Text);
                v.VehicleNo = textBoxVehNo.Text;
                v.Brand = TextBoxBrand.Text;
                v.Model = textBoxModel.Text;
                v.EngineNo = textBoxEngNo.Text;
                v.ChassiNo = textBoxChassiNo.Text;
                v.ProductionYear = int.Parse(textBoxProdYear.Text);
                v.Type = comboBoxType.Text;

                //update data in database

                bool success = v.update(v);

                if (success == true)
                {
                    MessageBox.Show("Vehicle Details has been updated succesfully!");
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Failed to update.Try Again!");
                }
            }
        }

        public Boolean validate()
        {
            Boolean status = false;

            try
            {
                if (textBoxVehNo.Text == string.Empty || TextBoxBrand.Text == string.Empty || textBoxModel.Text == string.Empty || textBoxEngNo.Text == string.Empty || textBoxChassiNo.Text == string.Empty || textBoxProdYear.Text == string.Empty || comboBoxType.Text == string.Empty)
                {
                    MessageBox.Show("Please Fill All The Fields!");
                    status = false;
                }
                else if (!Regex.IsMatch(textBoxVehNo.Text, "^[A-Za-z0-9-]{3,4}[0-9]{4}$"))
                {
                    MessageBox.Show("Please enter a valid Vehicle Number!");
                    status = false;
                }
                else if (!Regex.IsMatch(TextBoxBrand.Text, @"^[a-zA-Z\s]+$"))
                {
                    MessageBox.Show("Please enter a valid Vehicle Brand!");
                    status = false;
                }
                else if (!Regex.IsMatch(textBoxModel.Text, @"^[a-zA-Z\s]+$"))
                {
                    MessageBox.Show("Please enter a valid Vehicle Model!");
                    status = false;
                }
                else if (!Regex.IsMatch(textBoxEngNo.Text, @"^[a-zA-Z0-9-]+$"))
                {
                    MessageBox.Show("Please Enter a Engine Number!");
                    status = false;
                }
                else if (!Regex.IsMatch(textBoxChassiNo.Text, @"^[a-zA-Z0-9-]+$"))
                {
                    MessageBox.Show("Please Enter a Chassi Number!");
                    status = false;
                }
                else if (!Regex.IsMatch(textBoxProdYear.Text, "^[0-9]{4}$"))
                {
                    MessageBox.Show("Please Enter a Valid Year!");
                    status = false;
                }
                else
                {
                    status = true;
                }
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
            }
            return status;
        }

        private void btnDeleteVehicle_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Are you sure you want to delete this vehicle details?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                //get the contact id from the application

                v.VehicleID = Convert.ToInt32(textBoxId.Text);
                bool success = v.delete(v);

                if (success == true)
                {
                    MessageBox.Show("Successfully Deleted");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed to Delete");
                }
            }
        }

        private void textBoxVehNo_TextChanged(object sender, EventArgs e)
        {
            if (textBoxVehNo.Text == string.Empty)
                lblVehicleNoError.Visible = false;
            else if (!Regex.IsMatch(textBoxVehNo.Text, "^[A-Za-z0-9-]{3,4}[0-9]{4}$"))
                lblVehicleNoError.Visible = true;
            else
                lblVehicleNoError.Visible = false;
        }

        private void TextBoxBrand_TextChanged(object sender, EventArgs e)
        {
            if (TextBoxBrand.Text == string.Empty)
                lblBrandError.Visible = false;
            else if (!Regex.IsMatch(TextBoxBrand.Text, @"^[a-zA-Z\s]+$"))
                lblBrandError.Visible = true;
            else
                lblBrandError.Visible = false;
        }

        private void textBoxModel_TextChanged(object sender, EventArgs e)
        {
            if (textBoxModel.Text == string.Empty)
                lblModelError.Visible = false;
            else if (!Regex.IsMatch(textBoxModel.Text, @"^[a-zA-Z\s]+$"))
                lblModelError.Visible = true;
            else
                lblModelError.Visible = false;
        }

        private void textBoxEngNo_TextChanged(object sender, EventArgs e)
        {
            if (textBoxEngNo.Text == string.Empty)
                lblEngineNoError.Visible = false;
            else if (!Regex.IsMatch(textBoxEngNo.Text, @"^[a-zA-Z0-9-]+$"))
                lblEngineNoError.Visible = true;
            else
                lblEngineNoError.Visible = false;
        }

        private void textBoxChassiNo_TextChanged(object sender, EventArgs e)
        {
            if (textBoxChassiNo.Text == string.Empty)
                lblChassiNoError.Visible = false;
            else if (!Regex.IsMatch(textBoxChassiNo.Text, @"^[a-zA-Z0-9-]+$"))
                lblChassiNoError.Visible = true;
            else
                lblChassiNoError.Visible = false;
        }

        private void textBoxProdYear_TextChanged(object sender, EventArgs e)
        {
            if (textBoxProdYear.Text == string.Empty)
                lblProdYearError.Visible = false;
            else if (!Regex.IsMatch(textBoxProdYear.Text, "^[0-9]{4}$"))
                lblProdYearError.Visible = true;
            else
                lblProdYearError.Visible = false;
        }

        private void btnBackAddVeh_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
