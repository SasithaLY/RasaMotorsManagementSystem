﻿using RasaMotorsManagementSystem.Supplier.suppliersClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RasaMotorsManagementSystem.Supplier
{
    public partial class updateDeleteSup : Form
    {
        public updateDeleteSup()
        {
            InitializeComponent();
        }

        supplierClass c = new supplierClass();

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        //Clear data
        public void Clear()
        {
            txtSupID.Text = "";
            txtNIC.Text = "";
            txtFName.Text = "";
            txtLName.Text = "";
            txtCNum.Text = "";
            txtEmail.Text = "";
            txtCName.Text = "";
            cmbGender.Text = "";

        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            //clear data
            Clear();
        }
        private void btnOrder_Click(object sender, EventArgs e)
        {
            this.Hide();
            supplieInsert supplier = new supplieInsert();
            supplier.ShowDialog();


        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            try
            {
                //delete data
                c.supplierID = Convert.ToInt32(txtSupID.Text);

                //deleting data

                bool success = c.Delete(c);

                if (success == true)
                {
                    MessageBox.Show("Supplier successfully deleted!");

                    //Lord data dgv
                    DataTable dt = c.Select();

                    //supplierView.DataSource = dt;

                    //clear data
                    Clear();

                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Faild to delete Supplier, Try again!");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Fields are empty");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                //update data
                c.supplierID = int.Parse(txtSupID.Text);
                c.supplierNIC = txtNIC.Text;
                c.firstName = txtFName.Text;
                c.lastName = txtLName.Text;
                c.contactNumber = txtCNum.Text;
                c.supDate = supplierDate.Text;
                c.email = txtEmail.Text;
                c.companyName = txtCName.Text;
                c.gender = cmbGender.Text;


                string firstNamePattern = "^[a-zA-Z][a-zA-Z\\s]+$";
                string lastNamePattern = "^[a-zA-Z][a-zA-Z\\s]+$";
                string companyPattern = "^[a-zA-Z][a-zA-Z\\s]+$";
                string emailPattern = @"^\w+@[a-zA-Z_]+?\.[a-zA-Z]{2,3}$";
                string phonePattern = "[0-9]{10}";
                //string NICPattern = "/^[0-9]{9}[vVxX]$/";

                bool isFirstValid = Regex.IsMatch(txtFName.Text, firstNamePattern);
                bool isLastValid = Regex.IsMatch(txtLName.Text, lastNamePattern);
                bool isCompanyValid = Regex.IsMatch(txtCName.Text, companyPattern);
                bool isPhoneValid = Regex.IsMatch(txtCNum.Text, phonePattern);
                bool isEmailValid = Regex.IsMatch(txtEmail.Text, emailPattern);
                //bool isNICValid = Regex.IsMatch(txtNIC.Text, NICPattern);

                if (c.supplierNIC == "" || c.firstName == "" || c.lastName == "" || c.contactNumber == "" || c.email == "" || c.companyName == "" || c.gender == "")
                {
                    MessageBox.Show("Please fill the Fields");
                }

                //else if (isNICValid || c.supplierNIC == "")
                //{
                //    MessageBox.Show("Empty Fields or Invalid NIC");
                //}

                else if (!isFirstValid || c.firstName == "")
                {
                    MessageBox.Show("Empty Fields or Invalid First name");
                }

                else if (!isLastValid || c.lastName == "")
                {
                    MessageBox.Show("Empty Fields or Invalid Last name");
                }

                else if (!isPhoneValid || c.contactNumber == "")
                {
                    MessageBox.Show("Empty Fields or Invalid Phone number");
                }

                else if (!isEmailValid || c.email == "")
                {
                    MessageBox.Show("Empty Fields or Invalid Email");
                }

                else if (!isCompanyValid || c.companyName == "")
                {
                    MessageBox.Show("Empty Fields or Invalid company name");
                }

                else if (c.gender == "")
                {
                    MessageBox.Show("Empty Fields or Invalid Gender");
                }

                //Update data
                else
                {
                    bool success = c.Update(c);

                    if (success == true)
                    {
                        MessageBox.Show("Supplier successfully updated!");

                        //Lord data dgv
                        DataTable dt = c.Select();

                        //supplierView.DataSource = dt;

                        //clear data
                        Clear();

                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Faild to update Supplier, Try again!");
                    }

                }

            }

            catch (Exception ex)
            {
                MessageBox.Show("Fields are empty");
            }


        }

        static string connectionString = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

        private void supplierView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void supSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            suppliers supplier = new suppliers();
            supplier.ShowDialog();
        }

        private void txtNIC_TextChanged(object sender, EventArgs e)
        {
            if (txtNIC.Text == "")
            {
                labNIC.Visible = false;
            }

            else if (!Regex.IsMatch(txtNIC.Text, "[0-9]{9}[vVxX]{1}$"))
            {
                labNIC.Visible = true;
            }

            else
            {
                labNIC.Visible = false;
            }
        }

        private void txtFName_TextChanged(object sender, EventArgs e)
        {
            if (txtFName.Text == "")
            {
                labFirstName.Visible = false;
            }

            else if (!Regex.IsMatch(txtFName.Text, "^[a-zA-Z][a-zA-Z\\s]+$"))
            {
                labFirstName.Visible = true;
            }

            else
            {
                labFirstName.Visible = false;
            }
        }

        private void txtLName_TextChanged(object sender, EventArgs e)
        {
            if (txtLName.Text == "")
            {
                labLastName.Visible = false;
            }

            else if (!Regex.IsMatch(txtLName.Text, "^[a-zA-Z][a-zA-Z\\s]+$"))
            {
                labLastName.Visible = true;
            }

            else
            {
                labLastName.Visible = false;
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                labEmail.Visible = false;
            }

            else if (!Regex.IsMatch(txtEmail.Text, @"^\w+@[a-zA-Z_]+?\.[a-zA-Z]{2,3}$"))
            {
                labEmail.Visible = true;
            }

            else
            {
                labEmail.Visible = false;
            }
        }

        private void txtCNum_TextChanged(object sender, EventArgs e)
        {
            if (txtCNum.Text == "")
            {
                labCNum.Visible = false;
            }

            else if (!Regex.IsMatch(txtCNum.Text, "[0-9]{10}"))
            {
                labCNum.Visible = true;
            }

            else
            {
                labCNum.Visible = false;
            }
        }

        private void txtCName_TextChanged(object sender, EventArgs e)
        {
            if (txtCName.Text == "")
            {
                labCompany.Visible = false;
            }

            else if (!Regex.IsMatch(txtCName.Text, "^[a-zA-Z][a-zA-Z\\s]+$"))
            {
                labCompany.Visible = true;
            }

            else
            {
                labCompany.Visible = false;
            }
        }
    }
}
