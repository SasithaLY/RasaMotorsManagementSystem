using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RasaMotorsManagementSystem.Common
{
    class Utils
    {
        //private static string connectionString = "Data Source=DESKTOP-T0HOCLV;Initial Catalog=ServiceCenterManagementDB;Integrated Security=True";
        private static string connectionString = @"Data Source=LAPTOP-0PR0J0T3\SQLL;Initial Catalog=ServiceCenterManagementDB;Integrated Security=True";

        public static string ConnectionString
        {
            get
            {
                return connectionString;
            }
            set
            {
                connectionString = value;
            }
        }
    }

}

