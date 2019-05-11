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
    public partial class frmAddNewCustomer : Form
    {
        public frmAddNewCustomer()
        {
            InitializeComponent();
        }

        CustomerClass c = new CustomerClass();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (validate())
            {
                //getting values from the input fields

                c.Name = TextBoxName.Text;
                c.NIC = textBoxNIC.Text;
                c.Address = textBoxAddress.Text;
                c.PhoneNumber = textBoxPhone.Text;
                c.EMail = textBoxMail.Text;
                c.Gender = comboBoxGender.Text;


                //check whether insertion is success

                bool success = c.insert(c);

                if (success == true)
                {
                    MessageBox.Show("Successfully Inserted!");
                    this.Close();

                    //to clear data on fields

                    clear();
                }
                else
                {
                    MessageBox.Show("Error Occured!");
                }
            }
        }

        public void clear()
        {
            TextBoxName.Text = "";
            textBoxNIC.Text = "";
            textBoxAddress.Text = "";
            textBoxMail.Text = "";
            textBoxPhone.Text = "";
            comboBoxGender.Text = "";
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
                else if (TextBoxName.Text == "Rajitha Vithana" || textBoxAddress.Text == "15, New Kandy Road, Kothalawala" || textBoxNIC.Text == "123456789v" || textBoxPhone.Text == "0771234567" || textBoxMail.Text == "rasamotors@gmail.com")
                {
                    MessageBox.Show("Please Enter Values According to the Hint!");
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

        private void btnAddCusClear_Click(object sender, EventArgs e)
        {
            clear();
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

        private void frmAddNewCustomer_Load(object sender, EventArgs e)
        {

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

        private void TextBoxName_Enter(object sender, EventArgs e)
        {
            if (TextBoxName.Text == "Rajitha Vithana")
            {
                TextBoxName.Text = "";
                TextBoxName.ForeColor = Color.Black;
            }
        }

        private void TextBoxName_Leave(object sender, EventArgs e)
        {
            if (TextBoxName.Text == "")
            {
                TextBoxName.Text = "Rajitha Vithana";
                TextBoxName.ForeColor = Color.Gray;
            }
        }

        private void textBoxNIC_Enter(object sender, EventArgs e)
        {
            if (textBoxNIC.Text == "123456789v")
            {
                textBoxNIC.Text = "";
                textBoxNIC.ForeColor = Color.Black;
            }
        }

        private void textBoxNIC_Leave(object sender, EventArgs e)
        {
            if (textBoxNIC.Text == "")
            {
                textBoxNIC.Text = "123456789v";
                textBoxNIC.ForeColor = Color.Gray;
            }
        }

        private void textBoxAddress_Enter(object sender, EventArgs e)
        {
            if (textBoxAddress.Text == "15, New Kandy Road, Kothalawala")
            {
                textBoxAddress.Text = "";
                textBoxAddress.ForeColor = Color.Black;
            }
        }

        private void textBoxAddress_Leave(object sender, EventArgs e)
        {
            if (textBoxAddress.Text == "")
            {
                textBoxAddress.Text = "15, New Kandy Road, Kothalawala";
                textBoxAddress.ForeColor = Color.Gray;
            }
        }

        private void textBoxPhone_Enter(object sender, EventArgs e)
        {
            if (textBoxPhone.Text == "0771234567")
            {
                textBoxPhone.Text = "";
                textBoxPhone.ForeColor = Color.Black;
            }
        }

        private void textBoxPhone_Leave(object sender, EventArgs e)
        {
            if (textBoxPhone.Text == "")
            {
                textBoxPhone.Text = "0771234567";
                textBoxPhone.ForeColor = Color.Gray;
            }
        }

        private void textBoxMail_Enter(object sender, EventArgs e)
        {
            if (textBoxMail.Text == "rasamotors@gmail.com")
            {
                textBoxMail.Text = "";
                textBoxMail.ForeColor = Color.Black;
            }
        }

        private void textBoxMail_Leave(object sender, EventArgs e)
        {
            if (textBoxMail.Text == "")
            {
                textBoxMail.Text = "rasamotors@gmail.com";
                textBoxMail.ForeColor = Color.Gray;
            }
        }

        private void btnAddCusBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
