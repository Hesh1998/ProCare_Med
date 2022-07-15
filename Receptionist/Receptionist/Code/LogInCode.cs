using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ProCare.Code
{
    class LogInCode
    {
        DB_Con objdb = new DB_Con();


        public String[] getAccess(String username, String password)
        {
            String[] valid = { "N", "NUL" };

            int length = username.Length;
            char[] chars = username.ToCharArray();
            String prefix = ""+chars[0] + chars[1] + chars[2];
            String prefixOrg = prefix.ToUpper();
            String query = null;
            
            if (length==4 || length == 5)
            {
                username = prefixOrg;
                for (int i = 0; i < length-3; i++)
                {
                    username = username + chars[i+3];
                }

                if (prefixOrg.Equals("ADM") || prefixOrg.Equals("DOC")){
                    query = "SELECT count(doctor_id) AS num FROM doctor WHERE doctor_id='"+username+"' AND password='"+password+"';";
                }
                else if (prefixOrg.Equals("NUR") || prefixOrg.Equals("MGR") || prefixOrg.Equals("PHA") || prefixOrg.Equals("REC"))
                {
                    query = "SELECT count(staff_id) AS num FROM staff WHERE staff_id='"+username+"' AND password='"+password+"';";
                }
            }


            String count = "-1";
            try
            {
                MySqlConnection conn = objdb.getConn();


                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    count = dr.GetString("num");
                }

                conn.Close();

            }
            catch
            {
                throw;
            }

            int countInt = Int32.Parse(count);

            if (countInt >= 1)
            {
                valid[0] = "Y";
                valid[1] =username;
            }
            

            return valid;
        }

        public String getName(String username, String prefixOrg)
        {
            String name="";
            String query=null;

            try
            {
                MySqlConnection conn = objdb.getConn();

                if (prefixOrg.Equals("ADM") || prefixOrg.Equals("DOC"))
                {
                    query = "SELECT name FROM doctor WHERE doctor_id='" + username + "';";
                }
                else if (prefixOrg.Equals("NUR") || prefixOrg.Equals("MGR") || prefixOrg.Equals("PHA") || prefixOrg.Equals("REC"))
                {
                    query = "SELECT name FROM staff WHERE staff_id='" + username + "';";
                }

                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    name = dr.GetString("name");
                }

                conn.Close();
            }
            catch
            {
                throw;
            }
            
            return name;
        }
    }
}
