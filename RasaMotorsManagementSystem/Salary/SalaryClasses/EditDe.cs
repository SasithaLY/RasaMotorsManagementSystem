using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RasaMotorsManagementSystem.Salary.SalaryClasses
{
    class EditDe
    {
        public string JobState { get; set; }
        public float BasicSalary { get; set; }
        public float OTPayment { get; set; }
        public float EtfEpf { get; set; }

        static string myconnsstrng = Common.Utils.ConnectionString;

        //select data from database
        public DataTable Select()
        {
            SqlConnection conn = new SqlConnection(myconnsstrng);
            DataTable dt = new DataTable();
            try
            {
                //sql query
                string sql = "select * from edit";
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

        public bool Insert(EditDe c)
        {
            //creating default return type and setting its value to false
            bool isSuccess = false;

            //connect database
            SqlConnection conn = new SqlConnection(myconnsstrng);
            try
            {
                //if (c.OTHours >= 0 && c.Bonus >= 0)
                {
                    //step 2.create sql query to insert data
                    string sql = "INSERT INTO edit(JobState,BasicSalary,OTPayment,EtfEpf)VALUES(@JobState,@BasicSalary,@OTPayment,@EtfEpf)";
                    //create sql command usinf sql,conn
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    //create parameters to add data

                    cmd.Parameters.AddWithValue("@JobState", c.JobState);
                    cmd.Parameters.AddWithValue("@BasicSalary", c.BasicSalary);
                    cmd.Parameters.AddWithValue("@OTPayment", c.OTPayment);
                    cmd.Parameters.AddWithValue("@EtfEpf", c.EtfEpf);

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
                /* else
                 {
                     MessageBox.Show("Please Eneter Valid Inputs");
                 }*/

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


        public bool Update(EditDe c)
        {
            //create a default return value and set it default value to false
            bool isSucces = false;
            SqlConnection conn = new SqlConnection(myconnsstrng);
            try
            {
                //sql to update data in our database
                string sql = "UPDATE edit SET BasicSalary=@BasicSalary,OTPayment=@OTPayment,EtfEpf=@EtfEpf WHERE JobState=@JobState";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@JobState", c.JobState);
                cmd.Parameters.AddWithValue("@BasicSalary", c.BasicSalary);
                cmd.Parameters.AddWithValue("@OTPayment", c.OTPayment);
                cmd.Parameters.AddWithValue("@EtfEpf", c.EtfEpf);



                conn.Open();
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
    }
}

