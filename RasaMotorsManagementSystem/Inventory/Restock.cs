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
    public partial class Restock : Form
    {
        public Restock()
        {
            InitializeComponent();
        }

        private static Restock instance;
        Item i = new Item();
        public Restock checkInstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Restock();
                }
                else
                {
                    instance.BringToFront();
                    instance.Focus();
                }
                return instance;
            }
        }
        private void btnRestock_Click(object sender, EventArgs e)
        {
            if (txtBoxRestockQty.Text == "" || !Regex.IsMatch(txtBoxRestockQty.Text, @"^[0-9]+$"))
            {
                MessageBox.Show("Enter Quantity Value!");
            }
            else if (txtBoxUnitPrice.Text == "" || !Regex.IsMatch(txtBoxUnitPrice.Text, @"^[0-9.9]+$"))
            {
                MessageBox.Show("Please enter valid amount for unit price!");
            }
            else
            {
                //get data from input fields
                i.itemID = int.Parse(labelID.Text);
                i.itemName = labelItem.Text;
                i.quantity = int.Parse(txtBoxRestockQty.Text);
                i.buyingPrice = double.Parse(txtBoxUnitPrice.Text);
               
                //update data
                Boolean success = i.Restock(i);
                if (success == true)
                {
                    MessageBox.Show("Restock Successfull!");

                    Close();
                }
                else
                {
                    MessageBox.Show("Restock Failed! Try Again!");
                }
            }
        }

        private void Restock_FormClosed(object sender, FormClosedEventArgs e)
        {
            instance = null;
        }
    }
}
