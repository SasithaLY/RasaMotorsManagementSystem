using RasaMotorsManagementSystem.Employees.EmployeeClasses;
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

namespace RasaMotorsManagementSystem.Employees
{
    public partial class employee : Form
    {
        public employee()
        {
            InitializeComponent();
        }

        EmployeeClass emp = new EmployeeClass();

        public Boolean validate()
        {

            Boolean val = false;

            try
            {
                if (firstname.Text == string.Empty || lastname.Text == string.Empty || contactno.Text == string.Empty || homeContact.Text == string.Empty || address.Text == string.Empty || email.Text == string.Empty || nicnumber.Text == string.Empty || gender.Text == string.Empty || firstDate.Text == string.Empty || occupation.Text == string.Empty || empSalary.Text == string.Empty || combostatus.Text == string.Empty || workphone.Text == string.Empty || emeName.Text == string.Empty || emeRelationship.Text == string.Empty || emeContactNo.Text == string.Empty || emeAddress.Text == string.Empty)
                {
                    MessageBox.Show("Please Fill All the Fields");
                    val = false;
                }
                else if (!Regex.IsMatch(contactno.Text, "[0-9]{10}"))
                {
                    MessageBox.Show("Please Enter Valid Contact Number");
                    val = false;
                }
                else if (!Regex.IsMatch(homeContact.Text, "[0-9]{10}"))
                {
                    MessageBox.Show("Please Enter Valid Contact Number");
                    val = false;
                }
                else if (!Regex.IsMatch(empSalary.Text, @"^[0-9.9]+$"))
                {
                    MessageBox.Show("Please Enter Numbers Only for Salary Fields");
                    val = false;
                }
                else if (!Regex.IsMatch(workphone.Text, "[0-9]{10}"))
                {
                    MessageBox.Show("Please Enter Valid Contact Number");
                    val = false;
                }
                else if (!Regex.IsMatch(emeContactNo.Text, "[0-9]{10}"))
                {
                    MessageBox.Show("Please Enter Valid Contact Number");
                    val = false;
                }
                else if (!Regex.IsMatch(firstname.Text, @"^[a-zA-Z\s]+$"))
                {
                    MessageBox.Show("Please Enter letters Only for Name Fields");
                    val = false;
                }
                else if (!Regex.IsMatch(lastname.Text, @"^[a-zA-Z\s]+$"))
                {
                    MessageBox.Show("Please Enter letters Only for Name Fields");
                    val = false;
                }
                else if (!Regex.IsMatch(email.Text, @"^\w+@[a-zA-Z_]+?\.[a-zA-Z]{2,3}$"))
                {
                    MessageBox.Show("Please Enter Valid Email");
                    val = false;
                }
                else if (!Regex.IsMatch(nicnumber.Text, "[0-9]{9}[vV]{1}$"))
                {
                    MessageBox.Show("Please Enter Valid NIC Number");
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


        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (validate())
            {
                //get data from input fields
                emp.FirstName = firstname.Text;
                emp.LastName = lastname.Text;
                emp.ContactNo = contactno.Text;
                emp.HomeContactNo = homeContact.Text;
                emp.EmailID = email.Text;
                emp.Address = address.Text;
                emp.NICNo = nicnumber.Text;
                emp.Gender = gender.Text;
                emp.DateOfFirstAppointment = firstDate.Text;
                emp.Occupation = occupation.Text;
                emp.Status = combostatus.Text;
                emp.Salary = double.Parse(empSalary.Text);
                emp.WorkPhone = workphone.Text;
                emp.Name = emeName.Text;
                emp.EmeRelationship = emeRelationship.Text;
                emp.EmeContactNo = emeContactNo.Text;
                emp.EmeAddress = emeAddress.Text;

                //insert data
                Boolean success = emp.Insert(emp);

                if (success == true)
                {
                    //successfully inserted
                    MessageBox.Show("New employee details successfully inserted");
                    Close();

                }
                else
                {
                    //failed to insert an employee
                    MessageBox.Show("Failed add a new employee.Try again");
                }
            }
        }

        private void firstname_TextChanged(object sender, EventArgs e)
        {
            if (firstname.Text == string.Empty)
            {
                lblErrorFirstName.Visible = false;
            }
            else if (!Regex.IsMatch(firstname.Text, @"^[a-zA-Z\s]+$"))
            {
                lblErrorFirstName.Visible = true;
            }
            else
            {
                lblErrorFirstName.Visible = false;
            }
        }

        private void contactno_TextChanged(object sender, EventArgs e)
        {
            if (contactno.Text == string.Empty)
            {
                lblErrorContactNo.Visible = false;
            }
            else if (!Regex.IsMatch(contactno.Text, @"^[0-9]{10}$"))
            {
                lblErrorContactNo.Visible = true;
            }
            else
            {
                lblErrorContactNo.Visible = false;
            }
        }

        private void email_TextChanged(object sender, EventArgs e)
        {
            if (email.Text == string.Empty)
            {
                lblErrorEmailId.Visible = false;
            }
            else if (!Regex.IsMatch(email.Text, @"^\w+@[a-zA-Z_]+?\.[a-zA-Z]{2,3}$"))
            {
                lblErrorEmailId.Visible = true;
            }
            else
            {
                lblErrorEmailId.Visible = false;
            }
        }

        private void nicnumber_TextChanged(object sender, EventArgs e)
        {
            if (nicnumber.Text == string.Empty)
            {
                lblErrorNicNo.Visible = false;
            }
            else if (!Regex.IsMatch(nicnumber.Text, "[0-9]{9}[vV]{1}$"))
            {
                lblErrorNicNo.Visible = true;
            }
            else
            {
                lblErrorNicNo.Visible = false;
            }
        }

        private void lastname_TextChanged(object sender, EventArgs e)
        {
            if (lastname.Text == string.Empty)
            {
                lblErrorLastName.Visible = false;
            }
            else if (!Regex.IsMatch(lastname.Text, @"^[a-zA-Z\s]+$"))
            {
                lblErrorLastName.Visible = true;
            }
            else
            {
                lblErrorLastName.Visible = false;
            }
        }

        private void homeContact_TextChanged(object sender, EventArgs e)
        {
            if (homeContact.Text == string.Empty)
            {
                lblErrorHomeContact.Visible = false;
            }
            else if (!Regex.IsMatch(homeContact.Text, @"^[0-9]{10}$"))
            {
                lblErrorHomeContact.Visible = true;
            }
            else
            {
                lblErrorHomeContact.Visible = false;
            }
        }

        private void workphone_TextChanged(object sender, EventArgs e)
        {
            if (workphone.Text == string.Empty)
            {
                lblErrorWorkPhone.Visible = false;
            }
            else if (!Regex.IsMatch(workphone.Text, @"^[0-9]{10}$"))
            {
                lblErrorWorkPhone.Visible = true;
            }
            else
            {
                lblErrorWorkPhone.Visible = false;
            }
        }

        private void emeContactNo_TextChanged(object sender, EventArgs e)
        {
            if (emeContactNo.Text == string.Empty)
            {
                lblErrorEmeContact.Visible = false;
            }
            else if (!Regex.IsMatch(emeContactNo.Text, @"^[0-9]{10}$"))
            {
                lblErrorEmeContact.Visible = true;
            }
            else
            {
                lblErrorEmeContact.Visible = false;
            }
        }

        private void emeName_TextChanged(object sender, EventArgs e)
        {
            if (emeName.Text == string.Empty)
            {
                lblErrorEmeName.Visible = false;
            }
            else if (!Regex.IsMatch(emeName.Text, @"^[a-zA-Z\s]+$"))
            {
                lblErrorEmeName.Visible = true;
            }
            else
            {
                lblErrorEmeName.Visible = false;
            }
        }

        private void empSalary_TextChanged(object sender, EventArgs e)
        {
            if (empSalary.Text == string.Empty)
            {
                lblSalaryError.Visible = false;
            }
            else if (!Regex.IsMatch(empSalary.Text, @"^[0-9.9]+$"))
            {
                lblSalaryError.Visible = true;
            }
            else
            {
                lblSalaryError.Visible = false;
            }
        }

        private void btnDemo_Click(object sender, EventArgs e)
        {
            firstname.Text = "Keerthana";
            lastname.Text = "Albert";
            contactno.Text = "0771776858";
            homeContact.Text = "0652226678";
            email.Text = "akeethu@gmail.com";
            address.Text = "No 10,Rossairo Lane, Batticaloa";
            nicnumber.Text = "966312094V";
            gender.Text = "Female";
            occupation.Text = "Manager";
            combostatus.Text = "Active";
            empSalary.Text = "75000";
            workphone.Text = "0112222404";
            emeName.Text = "Y Albert";
            emeRelationship.Text = "Parent";
            emeContactNo.Text = "0718292272";
            emeAddress.Text = "Rossairo Lane,Batticaloa";
            
        }
    }
}
