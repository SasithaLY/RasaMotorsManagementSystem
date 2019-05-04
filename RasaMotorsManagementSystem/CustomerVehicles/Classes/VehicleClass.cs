using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RasaMotorsManagementSystem.CustomerVehicles.Classes
{
    class VehicleClass
    {
        //Getter Setter Properties

        public int VehicleID { get; set; }
        public String VehicleNo { get; set; }
        public String Brand { get; set; }
        public String Model { get; set; }
        public String EngineNo { get; set; }
        public String ChassiNo { get; set; }
        public int ProductionYear { get; set; }
        public String Type { get; set; }
        public String EnteredDate { get; set; }
        public String CustomerID { get; set; }

        static string myconn = Common.Utils.ConnectionString;

        //selecting data from database



        public DataTable select(String where)
        {
            SqlConnection conn = new SqlConnection(myconn);
            DataTable dt = new DataTable();

            try
            {
                string sql = "SELECT * FROM VehDetails " + where;
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


        public DataTable select()
        {
            SqlConnection conn = new SqlConnection(myconn);
            DataTable dt = new DataTable();

            try
            {
                string sql = "SELECT * FROM VehDetails";
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

        //inserting data into database

        public bool insert(VehicleClass v)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconn);

            try
            {
                string sql = "INSERT INTO VehDetails (VehicleNo, Brand, Model, EngineNo, ChassiNo, ProductionYear, Type, EnteredDate, CustomerID) VALUES ('" + v.VehicleNo + "', '" + v.Brand + "', '" + v.Model + "', '" + v.EngineNo + "', '" + v.ChassiNo + "', '" + v.ProductionYear + "', '" + v.Type + "', '" + DateTime.Now.ToString("yyyy-MM-dd") + "','" + v.CustomerID + "')";
                SqlCommand cmd = new SqlCommand(sql, conn);

                //cmd.Parameters.AddWithValue("@Brand", v.Brand);
                //cmd.Parameters.AddWithValue("@Model", v.Model);
                //cmd.Parameters.AddWithValue("@EngineNo", v.EngineNo);
                //cmd.Parameters.AddWithValue("@ChassiNo", v.ChassiNo);
                //cmd.Parameters.AddWithValue("@ProductionYear", v.ProductionYear);
                //cmd.Parameters.AddWithValue("@Type", v.Type);
                //cmd.Parameters.AddWithValue("@EnteredDate", DateTime.Now);

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

        //update data in database

        public bool update(VehicleClass v)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconn);

            try
            {
                string sql = "UPDATE VehDetails SET VehicleNo='" + v.VehicleNo + "', Brand='" + v.Brand + "', Model='" + v.Model + "', EngineNo='" + v.EngineNo + "', ChassiNo='" + v.ChassiNo + "', ProductionYear='" + v.ProductionYear + "', Type='" + v.Type + "' WHERE VehicleID='" + v.VehicleID + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);

                //cmd.Parameters.AddWithValue("@Name", c.Name);
                //cmd.Parameters.AddWithValue("@NIC", c.NIC);
                //cmd.Parameters.AddWithValue("@Address", c.Address);
                //cmd.Parameters.AddWithValue("@PhoneNumber", c.PhoneNumber);
                //cmd.Parameters.AddWithValue("@EMail", c.EMail);
                //cmd.Parameters.AddWithValue("@Gender", c.Gender);

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

        public bool delete(VehicleClass v)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconn);

            try
            {
                string sql = "DELETE FROM VehDetails WHERE VehicleID=@VehicleID";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@VehicleID", v.VehicleID);

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
    }
}

