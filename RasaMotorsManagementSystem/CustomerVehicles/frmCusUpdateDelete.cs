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
    public partial class frmCusUpdateDelete : Form
    {
        public frmCusUpdateDelete()
        {
            InitializeComponent();
        }

        CustomerClass c = new CustomerClass();

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (validate())
            {
                //getting data from textboxes

                c.CustomerID = int.Parse(textBoxId.Text);
                c.Name = TextBoxName.Text;
                c.NIC = textBoxNIC.Text;
                c.Address = textBoxAddress.Text;
                c.PhoneNumber = textBoxPhone.Text;
                c.EMail = textBoxMail.Text;
                c.Gender = comboBoxGender.Text;

                //update data in database

                bool success = c.update(c);

                if (success == true)
                {
                    MessageBox.Show("Customer Details has been updated succesfully!");
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
            Boolean val = false;

            try
            {
                if (TextBoxName.Text == string.Empty || textBoxAddress.Text == string.Empty || textBoxNIC.Text == string.Empty || textBoxPhone.Text == string.Empty || textBoxMail.Text == string.Empty || comboBoxGender.Text == string.Empty)
                {
                    MessageBox.Show("Please Fill All The Fields!");
                    val = false;
                }
                else if (!Regex.IsMatch(textBoxNIC.Text, "^[0-9]{9}[vV]{1}$"))
                {
                    MessageBox.Show("Please Enter a Valid NIC Number!");
                    val = false;
                }
                else if (!Regex.IsMatch(textBoxPhone.Text, "^[0-9]{10}$"))
                {
                    MessageBox.Show("Please Enter a Valid Phone Number!");
                    val = false;
                }
                else if (!Regex.IsMatch(textBoxMail.Text, @"^\w+@[a-zA-Z_0-9]+?\.[a-zA-Z]{2,3}$"))
                {
                    MessageBox.Show("Please Enter a valid Email!");
                    val = false;
                }
                else if (!Regex.IsMatch(TextBoxName.Text, @"^[a-zA-Z\s]+$"))
                {
                    MessageBox.Show("Please Enter a valid Name!");
                    val = false;
                }
                else if (!Regex.IsMatch(textBoxAddress.Text, @"^[a-zA-Z0-9.,/\s]+$"))
                {
                    MessageBox.Show("Please Enter a valid Address!");
                    val = false;
                }
                else
                {
                    val = true;
                }
            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
            }
            return val;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Are you sure you want to delete all customer information including his vehicle details?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                //get the contact id from the application

                c.CustomerID = Convert.ToInt32(textBoxId.Text);
                bool success = c.deleteAll(c);


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

        private void TextBoxName_TextChanged(object sender, EventArgs e)
        {
            if (TextBoxName.Text == string.Empty)
                lblNameError.Visible = false;
            else if (!Regex.IsMatch(TextBoxName.Text, @"^[a-zA-Z\s]+$"))
                lblNameError.Visible = true;
            else
                lblNameError.Visible = false;
        }

        private void textBoxNIC_TextChanged(object sender, EventArgs e)
        {
            if (textBoxNIC.Text == string.Empty)
                lblNicError.Visible = false;
            else if (!Regex.IsMatch(textBoxNIC.Text, "^[0-9]{9}[vV]{1}$"))
                lblNicError.Visible = true;
            else
                lblNicError.Visible = false;
        }

        private void textBoxAddress_TextChanged(object sender, EventArgs e)
        {
            if (textBoxAddress.Text == string.Empty)
                lblAddressError.Visible = false;
            else if (!Regex.IsMatch(textBoxAddress.Text, @"^[a-zA-Z0-9.,/\s]+$"))
                lblAddressError.Visible = true;
            else
                lblAddressError.Visible = false;
        }

        private void textBoxPhone_TextChanged(object sender, EventArgs e)
        {
            if (textBoxPhone.Text == string.Empty)
                lblPhoneError.Visible = false;
            else if (!Regex.IsMatch(textBoxPhone.Text, "^[0-9]{10}$"))
                lblPhoneError.Visible = true;
            else
                lblPhoneError.Visible = false;
        }

        private void textBoxMail_TextChanged(object sender, EventArgs e)
        {
            if (textBoxMail.Text == string.Empty)
                lblMailError.Visible = false;
            else if (!Regex.IsMatch(textBoxMail.Text, @"^\w+@[a-zA-Z_0-9]+?\.[a-zA-Z]{2,3}$"))
                lblMailError.Visible = true;
            else
                lblMailError.Visible = false;
        }

        private void comboBoxGender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdDelBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
