using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RasaMotorsManagementSystem.Login
{
    class LoginClass
    {
        public int logId { get; set; }
        public String userName { get; set; }
        public String password { get; set; }
        public String jobStatus { get; set; }

        string connString = Common.Utils.ConnectionString;

        public DataTable select()
        {
            //database connection
            SqlConnection conn = new SqlConnection(connString);

            DataTable dt = new DataTable();

            try
            {
                //sql query
                string sql = "SELECT * FROM login";

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

        public bool Insert(LoginClass c)
        {
            bool IsSuccess = false;

            //step1:connect database
            SqlConnection conn = new SqlConnection(connString);
            try
            {
                string sql = "INSERT INTO login(userName,password,jobStatus)VALUES(@UName,@Pwrd, @Jstatus)";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@UName", c.userName);
                cmd.Parameters.AddWithValue("@Pwrd", c.password);
                cmd.Parameters.AddWithValue("@Jstatus", c.jobStatus);

                //connection open here
                conn.Open();
                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    IsSuccess = true;
                }
                else
                {
                    IsSuccess = false;
                }


            }
            catch (Exception ex)
            {
            }
            finally
            {
                conn.Close();
            }
            return IsSuccess;

        }

        //Update Method 
        public bool Update(LoginClass c)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(connString);
            try
            {
                string sql = "UPDATE login SET userName=@uName, password=@Pwrd, jobStatus=@jStatus Where logID=@Id";

                //Creating SQL command
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Set Parameters
                cmd.Parameters.AddWithValue("@uName", c.userName);
                cmd.Parameters.AddWithValue("@Pwrd", c.password);
                cmd.Parameters.AddWithValue("@jStatus",c.jobStatus);

                cmd.Parameters.AddWithValue("@Id", c.logId);

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
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();

            }
            return isSuccess;

        }

        //Method to Delete
        public bool Delete(LoginClass c)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(connString);
            try
            {
                string sql = "DELETE FROM login where logID=@Id";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Id", c.logId);

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
            catch (Exception ex)
            {
            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }
    }
}
