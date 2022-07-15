using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ProCare.Code
{
    public class DB_Con
    {
        public MySqlConnection getConn()
        {
            try
            {
                MySqlConnection conn = new MySqlConnection();
                conn.ConnectionString = "Data Source=127.0.0.1; DATABASE=procare_med; UID=root; PASSWORD=; sslmode=none;";
                conn.Open();
                return conn;
            }
            catch
            {
                throw;
            }
        }

    }
}
