using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RasaMotorsManagementSystem.Employees.PaymentClasses
{
    class Payment1
    {
        //Getter and Setter
        //Act as a data carrier in the Application
        public int CustomerID { get; set; }
        public string JobCard { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public string CustomerName { get; set; }
        public string VehicleType { get; set; }
        public string VehicleNumber { get; set; }
        public string MobileNUmber { get; set; }
        public float BillAmount { get; set; }
        public float DiscountAmount { get; set; }
        public float NetAmount { get; set; }

        string myconstring = RasaMotorsManagementSystem.Common.Utils.ConnectionString;
        //static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        //Selecting Data from Database

        public DataTable Select()
        {
            //Step 1:Database Connection

            SqlConnection conn = new SqlConnection(myconstring);
            DataTable dt = new DataTable();
            try
            {
                //Step 2: Writing SQL query
                string sql = "SELECT * FROM pay";
                //Creating cmd using Sql and con
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Creating SQL DataAdapter using cmd
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }
        //Inserting data into Database
        public bool Insert(Payment1 p)
        {
            // Creating a default return type and setting its value to false
            bool isSuccess = false;

            //Step 1: Connect Database
            SqlConnection conn = new SqlConnection(myconstring);

            try
            {
                //Step 2: Create a SQL Query to insert data
                string sql = "INSERT INTO pay(JobCard,FromDate,ToDate,CustomerName,VehicleNumber,MobileNUmber,BillAmount,DiscountAmount,NetAmount) VALUES(@JobCard,@FromDate,@ToDate,@CustomerName,@VehicleNumber,@MobileNUmber,@BillAmount,@DiscountAmount,@NetAmount)";
                //Creating SQL command using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Create parameters to add data
                cmd.Parameters.AddWithValue("@JobCard", p.JobCard);
                cmd.Parameters.AddWithValue("@FromDate", p.FromDate);
                cmd.Parameters.AddWithValue("@ToDate", p.ToDate);
                cmd.Parameters.AddWithValue("@CustomerName", p.CustomerName);
                cmd.Parameters.AddWithValue("@VehicleNumber", p.VehicleNumber);
                cmd.Parameters.AddWithValue("@MobileNUmber", p.MobileNUmber);
                cmd.Parameters.AddWithValue("@BillAmount", p.BillAmount);
                cmd.Parameters.AddWithValue("@DiscountAmount", p.DiscountAmount);
                cmd.Parameters.AddWithValue("@NetAmount", p.NetAmount);

                //Connection Opens here
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                //If the query runs successfully then the values of rows will be greater than zero else its value will be 0

                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }
        //Method to update data in database from our Application
        public bool Update(Payment1 p)
        {
            //Craete a default return type and set it's default value to false
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconstring);
            try
            {
                //SQL to update data in our Database
                string sql = "UPDATE pay SET BillAmount = @BillAmount,DiscountAmount = @DiscountAmount,NetAmount = @NetAmount WHERE CustomerID = @CustomerID";
                //Creating SQL command
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Create Parameters to add value

                cmd.Parameters.AddWithValue("@BillAmount", p.BillAmount);
                cmd.Parameters.AddWithValue("@DiscountAmount", p.DiscountAmount);
                cmd.Parameters.AddWithValue("@NetAmount", p.NetAmount);
                cmd.Parameters.AddWithValue("@CustomerID", p.CustomerID);
                //Open Database Connection

                conn.Open();

                int rows = cmd.ExecuteNonQuery();
                //If the query runs successfully then the values of rows will be greater than zero else its value will be 0
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);

            }
            finally
            {
                conn.Close();
            }
            return isSuccess;

        }

        //Method to Delete Data from the Database
        public bool Delete(Payment1 p)
        {
            //Create a default return value and set its value to false
            bool isSuccesss = false;
            SqlConnection conn = new SqlConnection(myconstring);
            try
            {
                //SQL to Delete data
                string sql = "DELETE FROM pay WHERE CustomerID = @CustomerID";

                //Creating SQL command
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@CustomerID", p.CustomerID);
                //Open Connection
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                //If the query runs successfully then the values of rows will be greater tah zero else its value is 0
                if (rows > 0)
                {
                    isSuccesss = true;
                }
                else
                {
                    isSuccesss = false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                //Close connection
                conn.Close();
            }
            return isSuccesss;

        }
    }
}
