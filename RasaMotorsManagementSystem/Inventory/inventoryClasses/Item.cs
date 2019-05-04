using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RasaMotorsManagementSystem.Inventory.inventoryClasses
{
    class Item
    {
        //getters and setters
        public int itemID { get; set; }
        public string itemName { get; set; }
        public string itemType { get; set; }
        public double buyingPrice { get; set; }
        public double sellingPrice { get; set; }
        public int quantity { get; set; }
        public string supplier { get; set; }
        public int minQty { get; set; }
        public string reason { get; set; }


        string connString = Common.Utils.ConnectionString;


        //getting data from database
        public DataTable select()
        {
            //database connection
            SqlConnection conn = new SqlConnection(connString);

            DataTable dt = new DataTable();

            try
            {
                //sql query
                string sql = "SELECT itemID as 'Item ID', itemName as 'Item Name', itemType as 'Item Type', buyingPrice as 'Buying Price', sellingPrice as 'Selling Price', availableQty as 'Available Qty', soldQty as 'Sold Qty', addedDate as 'Added Date & Time', supplier as 'Supplier', minQty as 'Min Qty' FROM inventory";

                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                conn.Open();
                adapter.Fill(dt);

            }
            catch (Exception e)
            {

            }
            finally
            {
                conn.Close();
            }
            return dt;
        }

        //Insert data to database
        public Boolean Insert(Item i)
        {
            //default return value
            Boolean isSuccess = false;

            //database connection
            SqlConnection conn = new SqlConnection(connString);

            try
            {
                //sql query
                string sql = "INSERT INTO inventory (itemName, itemType, buyingPrice, sellingPrice, availableQty, addedDate, supplier, minQty) VALUES(@itemName, @itemType, @buyingPrice, @sellingPrice, @availableQty, @addedDate, @supplier, @minQty)";
 
                SqlCommand cmd = new SqlCommand(sql, conn);

                //parameters to add data
                cmd.Parameters.AddWithValue("@itemName", i.itemName);
                cmd.Parameters.AddWithValue("@itemType", i.itemType);
                cmd.Parameters.AddWithValue("@buyingPrice", i.buyingPrice);
                cmd.Parameters.AddWithValue("@sellingPrice", i.sellingPrice);
                cmd.Parameters.AddWithValue("@availableQty", i.quantity);
                cmd.Parameters.AddWithValue("@addedDate", DateTime.Now);
                cmd.Parameters.AddWithValue("@supplier", i.supplier);
                cmd.Parameters.AddWithValue("@minQty", i.minQty);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }


            }
            catch (System.Data.SqlClient.SqlException sqlExceptione)
            {
                System.Windows.Forms.MessageBox.Show(sqlExceptione.Message);
            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }

        //Restock Item 
        public Boolean Restock(Item i) {
            //defalt return value
            Boolean isSuccess = false;

            //database connection
            SqlConnection conn = new SqlConnection(connString);

            try
            {
                //sql query
                string sql1 = "INSERT INTO restock (itemID, itemName, quantity, date, unitPrice) VALUES(@itemID, @itemName, @quantity, @date, @unitPrice)";
                string sql2 = "UPDATE inventory SET availableQty = availableQty +'" + i.quantity + "', buyingPrice = '"+i.buyingPrice+"' where itemID = '" + i.itemID + "'";

                SqlCommand cmd = new SqlCommand(sql1, conn);
                SqlCommand cmd2 = new SqlCommand(sql2, conn);

                //parameters to add data
                cmd.Parameters.AddWithValue("@itemID", i.itemID);
                cmd.Parameters.AddWithValue("@itemName", i.itemName);
                cmd.Parameters.AddWithValue("@quantity", i.quantity);
                cmd.Parameters.AddWithValue("@date", DateTime.Now);
                cmd.Parameters.AddWithValue("@unitPrice", i.buyingPrice);
   
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();

                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (System.Data.SqlClient.SqlException sqlExceptione)
            {
                System.Windows.Forms.MessageBox.Show(sqlExceptione.Message);
            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }

        //Return Item
        public Boolean Return(Item i)
        {
            //defalt return value
            Boolean isSuccess = false;

            //database connection
            SqlConnection conn = new SqlConnection(connString);

            try
            {
                //sql queries
                string sql1 = "INSERT INTO returnItems (itemID, itemName, quantity, returnDate, reason) VALUES(@itemID, @itemName, @quantity, @date, @reason)";
                string sql2 = "UPDATE inventory SET availableQty = availableQty -'" + i.quantity + "' where itemID = '" + i.itemID + "'";

                SqlCommand cmd = new SqlCommand(sql1, conn);
                SqlCommand cmd2 = new SqlCommand(sql2, conn);

                //parameters to add data
                cmd.Parameters.AddWithValue("@itemID", i.itemID);
                cmd.Parameters.AddWithValue("@itemName", i.itemName);
                cmd.Parameters.AddWithValue("@quantity", i.quantity);
                cmd.Parameters.AddWithValue("@date", DateTime.Now);
                cmd.Parameters.AddWithValue("@reason", i.reason);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();

                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (System.Data.SqlClient.SqlException sqlExceptione)
            {
                System.Windows.Forms.MessageBox.Show(sqlExceptione.Message);
            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }


        //update data in database
        public Boolean Update(Item i)
        {
            //default return value
            Boolean isSuccess = false;

            SqlConnection conn = new SqlConnection(connString);

            try
            {
                //query to update data
                string sql = "UPDATE inventory SET itemName = @itemName, itemType = @itemType, buyingPrice = @buyingPrice, sellingPrice = @sellingPrice, availableQty = @availableQty, supplier = @supplier, minQty = @minQty WHERE itemID = @itemID";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@itemName", i.itemName);
                cmd.Parameters.AddWithValue("@itemType", i.itemType);
                cmd.Parameters.AddWithValue("@buyingPrice", i.buyingPrice);
                cmd.Parameters.AddWithValue("@sellingPrice", i.sellingPrice);
                cmd.Parameters.AddWithValue("@availableQty", i.quantity);
                cmd.Parameters.AddWithValue("@supplier", i.supplier);
                cmd.Parameters.AddWithValue("@itemID", i.itemID);
                cmd.Parameters.AddWithValue("@minQty", i.minQty);

                conn.Open();

                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception e)
            {

            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }

        //delete data from database
        public Boolean Delete(Item i)
        {
            //default return value
            Boolean isSuccess = false;

            SqlConnection conn = new SqlConnection(connString);

            try
            {
                //sql query to delete data

                string sql = "DELETE FROM inventory WHERE itemID = @itemID";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@itemID", i.itemID);

                conn.Open();

                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception e)
            {

            }
            finally
            {
                conn.Close();
            }

            return isSuccess;
        }

        public Boolean validate()
        {
            Boolean isSuccess = false;

            try
            {
                if (itemName == null || itemType == null || quantity.Equals(null) || buyingPrice.Equals(null) || sellingPrice.Equals(null) || supplier == null || minQty.Equals(null))
                {
                    isSuccess = false;
                }
                else
                {
                    isSuccess = true;
                }


            }
            catch (Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
            }

            return isSuccess;
        }

      
    }
}
