using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RasaMotorsManagementSystem.Salary.SalaryClasses
{
    class ssalaryclass
    {

        public int EmployeeID { get; set; }
        public float OTHours { get; set; }
        public float Bonus { get; set; }
        public DateTime Date { get; set; }
        public float Total { get; set; }
        public float BasicSalary { get; set; }
        public float OTPayment { get; set; }
        public float EtfEpf { get; set; }
        public int Basic { get; set; }
        public int ID { get; set; }

        public DataGrid DataGrid { get; set; }
        public int No { get; set; }



        static string myconnsstrng = Common.Utils.ConnectionString;

        //select data from database
        public DataTable Select()
        {
            SqlConnection conn = new SqlConnection(myconnsstrng);
            DataTable dt = new DataTable();
            try
            {
                //sql query
                string sql = "select * from empsalary";
                SqlCommand cmd = new SqlCommand(sql, conn);
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

        public DataTable Selectt()
        {
            SqlConnection conn = new SqlConnection(myconnsstrng);
            DataTable dt = new DataTable();
            try
            {
                //sql query
                string sql = "select * from emp";
                SqlCommand cmd = new SqlCommand(sql, conn);
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

        public DataTable Selct()
        {
            SqlConnection conn = new SqlConnection(myconnsstrng);
            DataTable dt = new DataTable();
            try
            {
                //sql query
                string sql = "select * from EditDet";
                SqlCommand cmd = new SqlCommand(sql, conn);
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





        //insert data into database
        public bool Insert(ssalaryclass c)
        {

            //creating default return type and setting its value to false
            bool isSuccess = false;

            //connect database
            SqlConnection conn = new SqlConnection(myconnsstrng);
            try
            {

                //step 2.create sql query to insert data
                string sql = "INSERT INTO empsalary(EmployeeID,BasicSalary,OTHours,Bonus,EtfEpf,OTPayment,Date,Total)VALUES(@EmployeeID,@BasicSalary,@OTHours,@Bonus,@EtfEpf,@OTPayment,@Date,@Total)";
                //create sql command usinf sql,conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //create parameters to add data


                cmd.Parameters.AddWithValue("@EmployeeID", c.EmployeeID);
                cmd.Parameters.AddWithValue("@OTHours", c.OTHours);
                cmd.Parameters.AddWithValue("@BasicSalary", c.BasicSalary);
                cmd.Parameters.AddWithValue("@Bonus", c.Bonus);
                cmd.Parameters.AddWithValue("@Date", c.Date);
                cmd.Parameters.AddWithValue("@Total", c.Total);
                cmd.Parameters.AddWithValue("@EtfEpf", c.EtfEpf);
                cmd.Parameters.AddWithValue("@OTPayment", c.OTPayment);


                //connection open here
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                //if the query runs succs,value of rows will b greater than 0 or else it 0
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

        //method to update data in database from our application
        public bool Update(ssalaryclass c)
        {
            //create a default return value and set it default value to false
            bool isSucces = false;
            SqlConnection conn = new SqlConnection(myconnsstrng);
            try
            {
                //sql to update data in our database
                string sql = "UPDATE empsalary SET OTHours=@OTHours,Bonus=@Bonus,Total=@Total WHERE No=@No";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("No", c.No);

                cmd.Parameters.AddWithValue("OTHours", c.OTHours);
                cmd.Parameters.AddWithValue("Bonus", c.Bonus);
                cmd.Parameters.AddWithValue("Total", c.Total);


                conn.Open();
                //if the query runs succs,value of rows will b greater than 0 or else it 0
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSucces = true;
                }
                else
                {
                    isSucces = false;
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
            return isSucces;
        }
        //delete data from database
        public bool Delete(ssalaryclass c)
        {
            bool isSucces = false;
            //create sql connection
            SqlConnection conn = new SqlConnection(myconnsstrng);
            //try
            //{
            //sql delete data
            string sql = "DELETE FROM empsalary WHERE No=@No";

            //create sql command
            SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@No", c.No);
                //open connection
                conn.Open();
                //if the query runs succs,value of rows will b greater than 0 or else it 0
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSucces = true;
                }
                else
                {
                    isSucces = false;
                }

            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex);
            //}
            //finally
            //{
            //    conn.Close();
            //}
            return isSucces;
        }




    }
}

    
