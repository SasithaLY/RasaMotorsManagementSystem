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
    public partial class frmAddNewVehicle : Form
    {
        VehicleClass v = new VehicleClass();
        private string customerID;

        public frmAddNewVehicle()
        {
            InitializeComponent();
        }

        public frmAddNewVehicle(string customerID)
        {
            this.customerID = customerID;
            InitializeComponent();
        }

        private void frmAddNewVehicle_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (validate())
            {
                //getting values from the input fields

                v.VehicleNo = textBoxVehNo.Text;
                v.Brand = TextBoxBrand.Text;
                v.Model = textBoxModel.Text;
                v.EngineNo = textBoxEngNo.Text;
                v.ChassiNo = textBoxChassiNo.Text;
                v.ProductionYear = Int32.Parse(textBoxProdYear.Text);
                v.Type = comboBoxType.Text;
                v.CustomerID = customerID;

                //check whether insertion is success

                bool success = v.insert(v);

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
            textBoxVehNo.Text = "";
            TextBoxBrand.Text = "";
            textBoxModel.Text = "";
            textBoxEngNo.Text = "";
            textBoxChassiNo.Text = "";
            textBoxProdYear.Text = "";
            comboBoxType.Text = "";
        }

        private void btnClearAddVeh_Click(object sender, EventArgs e)
        {
            clear();
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
                else if (textBoxVehNo.Text == "ABC-1234" || textBoxEngNo.Text == "1HGBH41JXMN109186" || textBoxChassiNo.Text == "WAUZZZ8R8AA042836" || textBoxProdYear.Text == "2005")
                {
                    MessageBox.Show("Please Enter Values According to the Hint!");
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

        private void textBoxVehNo_Enter(object sender, EventArgs e)
        {
            if (textBoxVehNo.Text == "ABC-1234")
            {
                textBoxVehNo.Text = "";
                textBoxVehNo.ForeColor = Color.Black;
            }
        }

        private void textBoxVehNo_Leave(object sender, EventArgs e)
        {
            if (textBoxVehNo.Text == "")
            {
                textBoxVehNo.Text = "ABC-1234";
                textBoxVehNo.ForeColor = Color.Gray;
            }
        }

        private void TextBoxBrand_Enter(object sender, EventArgs e)
        {
            if (TextBoxBrand.Text == "Honda")
            {
                TextBoxBrand.Text = "";
                TextBoxBrand.ForeColor = Color.Black;
            }
        }

        private void TextBoxBrand_Leave(object sender, EventArgs e)
        {
            if (TextBoxBrand.Text == "")
            {
                TextBoxBrand.Text = "Honda";
                TextBoxBrand.ForeColor = Color.Gray;
            }
        }

        private void textBoxModel_Enter(object sender, EventArgs e)
        {
            if (textBoxModel.Text == "Civic")
            {
                textBoxModel.Text = "";
                textBoxModel.ForeColor = Color.Black;
            }
        }

        private void textBoxModel_Leave(object sender, EventArgs e)
        {
            if (textBoxModel.Text == "")
            {
                textBoxModel.Text = "Civic";
                textBoxModel.ForeColor = Color.Gray;
            }
        }

        private void textBoxEngNo_Enter(object sender, EventArgs e)
        {
            if (textBoxEngNo.Text == "1HGBH41JXMN109186")
            {
                textBoxEngNo.Text = "";
                textBoxEngNo.ForeColor = Color.Black;
            }
        }

        private void textBoxEngNo_Leave(object sender, EventArgs e)
        {
            if (textBoxEngNo.Text == "")
            {
                textBoxEngNo.Text = "1HGBH41JXMN109186";
                textBoxEngNo.ForeColor = Color.Gray;
            }
        }

        private void textBoxChassiNo_Enter(object sender, EventArgs e)
        {
            if (textBoxChassiNo.Text == "WAUZZZ8R8AA042836")
            {
                textBoxChassiNo.Text = "";
                textBoxChassiNo.ForeColor = Color.Black;
            }
        }

        private void textBoxChassiNo_Leave(object sender, EventArgs e)
        {
            if (textBoxChassiNo.Text == "")
            {
                textBoxChassiNo.Text = "WAUZZZ8R8AA042836";
                textBoxChassiNo.ForeColor = Color.Gray;
            }
        }

        private void textBoxProdYear_Enter(object sender, EventArgs e)
        {
            if (textBoxProdYear.Text == "2005")
            {
                textBoxProdYear.Text = "";
                textBoxProdYear.ForeColor = Color.Black;
            }
        }

        private void textBoxProdYear_Leave(object sender, EventArgs e)
        {
            if (textBoxProdYear.Text == "")
            {
                textBoxProdYear.Text = "2005";
                textBoxProdYear.ForeColor = Color.Gray;
            }
        }

        private void btnAddVehBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
