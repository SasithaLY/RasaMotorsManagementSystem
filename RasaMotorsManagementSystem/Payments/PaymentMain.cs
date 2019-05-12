using RasaMotorsManagementSystem.Employees.PaymentClasses;
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

namespace RasaMotorsManagementSystem.Payments
{
    public partial class PaymentMain : Form
    {
        public PaymentMain()
        {
            InitializeComponent();
        }
        Payment1 p = new Payment1();
        private void AddButton_Click(object sender, EventArgs e)
        {

            try
            {
                //Get the value from the input feilds
                p.JobCard = JobCard.Text;
                p.CustomerName = CustomerName.Text;
                p.VehicleNumber = VehicleNo.Text;
                p.MobileNUmber = MobileNo.Text;
                p.BillAmount = float.Parse(Bill.Text);
                p.DiscountAmount = float.Parse(Discount.Text);
                p.NetAmount = float.Parse(Net.Text);
                p.FromDate = dateTimePicker1.Value;
                p.ToDate = dateTimePicker1.Value;

                string CustomerNamePattern = "^[a-zA-Z] [a-zA-Z\\s]+$";
                string MobileNumberPattern = "[0-9]{11}";
                string VehicleNumberPattern = "^[a-zA-Z] [a-zA-Z\\s]+$";
                string BillAmountPattern = "^[1 - 9]\\d * (\\.\\d +) ?$";
                string DiscountAmountPattern = "^[1 - 9]\\d * (\\.\\d +) ?$";
                string NetAmountPattern = "^[1 - 9]\\d * (\\.\\d +) ?$";

                bool isCustomerValid = Regex.IsMatch(CustomerName.Text, CustomerNamePattern);
                bool isMObileValid = Regex.IsMatch(MobileNo.Text, MobileNumberPattern);
                bool isVehicleValid = Regex.IsMatch(VehicleNo.Text, VehicleNumberPattern);
                bool isBillValid = Regex.IsMatch(Bill.Text, BillAmountPattern);
                bool isDiscountValid = Regex.IsMatch(Discount.Text, DiscountAmountPattern);
                bool isNetValid = Regex.IsMatch(Net.Text, NetAmountPattern);

                if (p.CustomerName == "" || p.MobileNUmber == "" || p.VehicleNumber == "")
                {
                    MessageBox.Show("Feilds can't be empty.");
                }
                else if (isCustomerValid)
                {
                    MessageBox.Show("Please enter a valid Customer name.");
                }
                else if (isMObileValid)
                {
                    MessageBox.Show("Please enter a valid mobile number.");
                }
                else if (isVehicleValid)
                {
                    MessageBox.Show("Please enter a valid vehicle number.");
                }
                else if (isBillValid)
                {
                    MessageBox.Show("Please enter a valid Amount.");
                }
                else if (isDiscountValid)
                {
                    MessageBox.Show("Please enter a valid Amount.");
                }
                else if (isNetValid)
                {
                    MessageBox.Show("Please enter a valid Amount.");
                }
                else
                {
                    //Insert Data into Database using the method we created before
                    bool success = p.Insert(p);
                    if (success == true)
                    {
                        //Successfully Inserted
                        MessageBox.Show("New Payment Details are inserted successfully.");
                    }
                    else
                    {
                        //Failed to add payment details
                        MessageBox.Show("Failed to add Payment Details.Try again.");
                    }

                    //Load Data into Data GridVeiw
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
                float BillAmount = Convert.ToInt32(Bill.Text);
                float DiscountAmount = Convert.ToInt32(Discount.Text);

                float NetAmount = (BillAmount - DiscountAmount);
                Net.Text = NetAmount.ToString();

                if (NetAmount == BillAmount)
                {
                    MessageBox.Show("No Discounts Applied!!");
                }
                else
                {
                    MessageBox.Show("Discounts Applied.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        
    }

        private void ViewButton_Click(object sender, EventArgs e)
        {
            //Veiw button
            this.Hide();
            PayView f4 = new PayView();
            f4.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //History button
            this.Hide();
            PayHistory h = new PayHistory();
            h.Show();

        }
    }
    }

