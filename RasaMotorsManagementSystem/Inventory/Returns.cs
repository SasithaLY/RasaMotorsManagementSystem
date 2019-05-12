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
using RasaMotorsManagementSystem.Inventory.inventoryClasses;

namespace RasaMotorsManagementSystem.Inventory
{
    public partial class Returns : Form
    {
        public Returns()
        {
            InitializeComponent();
        }

        private static Returns instance;
        Item i = new Item();
        public Returns checkInstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Returns();
                }
                else
                {
                    instance.BringToFront();
                    instance.Focus();
                }
                return instance;
            }
        }
        private void btnAddReturn_Click(object sender, EventArgs e)
        {
            if (txtBoxReturnQty.Text == "" || !Regex.IsMatch(txtBoxReturnQty.Text, @"^[0-9]+$"))
            {
                MessageBox.Show("Enter Quantity Value!");
            }
            else if (txtBoxReason.Text == "") 
            {
                MessageBox.Show("Please Enter Reason for Return...");
            }
            else
            {
                //get data from input fields
                i.itemID = int.Parse(labelID.Text);
                i.itemName = labelItem.Text;
                i.quantity = int.Parse(txtBoxReturnQty.Text);
                i.reason = txtBoxReason.Text;


                //update data
                Boolean success = i.Return(i);
                if (success == true)
                {
                    MessageBox.Show("Return Added Successfully!");

                    Close();
                }
                else
                {
                    MessageBox.Show("Return Failed! Try Again!");
                }
            }
        }

        private void Returns_FormClosed(object sender, FormClosedEventArgs e)
        {
            instance = null;
        }
    }
}
