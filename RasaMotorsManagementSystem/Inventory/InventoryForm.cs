﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using RasaMotorsManagementSystem.Inventory.inventoryClasses;
using RasaMotorsManagementSystem.Supplier;

namespace RasaMotorsManagementSystem.Inventory
{
    public partial class InventoryForm : Form
    {
        string connString = Common.Utils.ConnectionString;
        public InventoryForm()
        {
            InitializeComponent();
            fillCombo();
        }

        Item i = new Item();

        private static InventoryForm instance;

        public InventoryForm checkInstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new InventoryForm();
                }
                else
                {
                    instance.BringToFront();
                    instance.Focus();
                }
                return instance;
            }
        }

        //method to clear the input fields
        public void Clear()
        {
            txtBoxItemID.Text = "";
            txtBoxItemName.Text = "";
            txtBoxItemType.Text = "";
            txtBoxSellPrice.Text = "";
            txtBoxBuyPrice.Text = "";
            txtBoxQnt.Text = "";
            cmbBoxSupplier.Text = "";
            txtboxMinQty.Text = "";
        }


        public void fillCombo()
        {
            string sql1 = "SELECT * FROM supplierDetails";
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand(sql1, conn);
            SqlDataReader reader;

            try
            {
                conn.Open();
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string supName = reader.GetString(6);
                    cmbBoxSupplier.Items.Add(supName);

                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }

        public Boolean validate()
        {
            Boolean val = false;

            try
            {
                if (txtBoxItemName.Text == string.Empty || txtBoxItemType.Text == string.Empty || txtBoxBuyPrice.Text == string.Empty || txtBoxSellPrice.Text == string.Empty || txtBoxQnt.Text == string.Empty || txtboxMinQty.Text == string.Empty || cmbBoxSupplier.Text == string.Empty)
                {
                    MessageBox.Show("Please Fill All The Fields!");
                    val = false;

                }
                else if (!Regex.IsMatch(txtBoxBuyPrice.Text, @"^[0-9.9]+$"))
                {
                    MessageBox.Show("Enter Only Numbers for Price Fields!");
                    val = false;
                }
                else if (!Regex.IsMatch(txtBoxSellPrice.Text, @"^[0-9.9]+$"))
                {
                    MessageBox.Show("Enter Only Numbers for Price Fields!");
                    val = false;
                }
                else if (!Regex.IsMatch(txtBoxQnt.Text, @"^[0-9]+$"))
                {
                    MessageBox.Show("Enter Only Numbers for Quantity!");
                    val = false;
                }
                else if (!Regex.IsMatch(txtboxMinQty.Text, @"^[0-9]+$"))
                {
                    MessageBox.Show("Enter Only Numbers for Quantity!");
                    val = false;
                }
                else
                {
                    val = true;
                }


            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return val;
        }

   
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //insert data into database
            if (validate())
            {
                //get values from input fields
                i.itemName = txtBoxItemName.Text;
                i.itemType = txtBoxItemType.Text;
                i.buyingPrice = double.Parse(txtBoxBuyPrice.Text);
                i.sellingPrice = double.Parse(txtBoxSellPrice.Text);
                i.quantity = int.Parse(txtBoxQnt.Text);
                i.supplier = cmbBoxSupplier.Text;
                i.minQty = int.Parse(txtboxMinQty.Text);

                Boolean success = i.Insert(i);

                if (success == true)
                {
                    MessageBox.Show("New Item Added Successfully!");
                    //clear inputs fields
                    Clear();
                    Close();
                }
                else
                {
                    MessageBox.Show("Failed to Add New Item. Try Again!");
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //clear data in input fields
            Clear();
        }

        private void txtBoxBuyPrice_TextChanged(object sender, EventArgs e)
        {
            if (txtBoxBuyPrice.Text == string.Empty)
            {
                lblErrorBuy.Visible = false;
            }
            else if (!Regex.IsMatch(txtBoxBuyPrice.Text, @"^[0-9.9]+$"))
            {
                lblErrorBuy.Visible = true;
            }
            else
            {
                lblErrorBuy.Visible = false;
            }
        }

        private void txtBoxSellPrice_TextChanged(object sender, EventArgs e)
        {
            if (txtBoxSellPrice.Text == string.Empty)
            {
                lblErrorSell.Visible = false;
            }
            else if (!Regex.IsMatch(txtBoxSellPrice.Text, @"^[0-9.9]+$"))
            {
                lblErrorSell.Visible = true;
            }
            else
            {
                lblErrorSell.Visible = false;
            }
        }

        private void txtBoxQnt_TextChanged(object sender, EventArgs e)
        {
            if (txtBoxQnt.Text == string.Empty)
            {
                lblErrorQty.Visible = false;
            }
            else if (!Regex.IsMatch(txtBoxQnt.Text, @"^[0-9]+$"))
            {
                lblErrorQty.Visible = true;
            }
            else
            {
                lblErrorQty.Visible = false;
            }
        }

        private void InventoryForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            instance = null;
        }

        private void lblErrorMinQty_Click(object sender, EventArgs e)
        {
            if (txtboxMinQty.Text == string.Empty)
            {
                lblErrorMinQty.Visible = false;
            }
            else if (!Regex.IsMatch(txtboxMinQty.Text, @"^[0-9]+$"))
            {
                lblErrorMinQty.Visible = true;
            }
            else
            {
                lblErrorMinQty.Visible = false;
            }
        }

        private void btnAddSup_Click_1(object sender, EventArgs e)
        {
            Supplier.supplieInsert supplieInsert = new Supplier.supplieInsert();
            supplieInsert.Show();
        }

        private void InventoryForm_Activated(object sender, EventArgs e)
        {
            cmbBoxSupplier.Items.Clear();
            fillCombo();
        }
    }
}
