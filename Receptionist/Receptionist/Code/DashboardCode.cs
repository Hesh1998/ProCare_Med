using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ProCare.Code
{
    class DashboardCode
    {
        DB_Con objdb = new DB_Con();

        public String noOfDOC()
        {
            String count = "";
            try
            {
                MySqlConnection conn = objdb.getConn();
                String query = "SELECT COUNT(doctor_id) AS num FROM doctor;";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    count = dr.GetString("num");
                }

                cmd.Dispose();
                dr.Dispose();
                conn.Close();

                return count;
            }
            catch
            {
                throw;
            }
        }

        public String noOfNUR()
        {
            String count = "";
            try
            {
                MySqlConnection conn = objdb.getConn();
                String query = "SELECT COUNT(staff_id) AS num FROM staff WHERE staff_type='NUR';";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    count = dr.GetString("num");
                }

                cmd.Dispose();
                dr.Dispose();
                conn.Close();

                return count;
            }
            catch
            {
                throw;
            }
        }

        public String noOfMGR()
        {
            String count = "";
            try
            {
                MySqlConnection conn = objdb.getConn();
                String query = "SELECT COUNT(staff_id) AS num FROM staff WHERE staff_type='MGR';";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    count = dr.GetString("num");
                }

                cmd.Dispose();
                dr.Dispose();
                conn.Close();

                return count;
            }
            catch
            {
                throw;
            }
        }

        public String noOfPHA()
        {
            String count = "";
            try
            {
                MySqlConnection conn = objdb.getConn();
                String query = "SELECT COUNT(staff_id) AS num FROM staff WHERE staff_type='PHA';";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    count = dr.GetString("num");
                }

                cmd.Dispose();
                dr.Dispose();
                conn.Close();

                return count;
            }
            catch
            {
                throw;
            }
        }

        public String noOfREC()
        {
            String count = "";
            try
            {
                MySqlConnection conn = objdb.getConn();
                String query = "SELECT COUNT(staff_id) AS num FROM staff WHERE staff_type='REC';";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    count = dr.GetString("num");
                }

                cmd.Dispose();
                dr.Dispose();
                conn.Close();

                return count;
            }
            catch
            {
                throw;
            }
        }

        public String getEarning(String year, String month)
        {
            String earning = "";
            

            try
            {
                MySqlConnection conn = objdb.getConn();
                String query = "SELECT SUM(payment) AS sum FROM treatment WHERE (year='"+year+"' AND month='"+month+"');";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    earning = dr.GetString("sum");
                }

                cmd.Dispose();
                dr.Dispose();
                conn.Close();

            }
            catch
            {
                throw;
            }

            return earning;
        }

        public String[] getPatientCount(String year, String month)
        {
            String[] countPat = {"", "" };


            try
            {
                MySqlConnection conn1 = objdb.getConn();
                String query1 = "SELECT COUNT(treatment_id) AS num FROM treatment WHERE (year='" + year + "' AND month='" + month + "');";
                MySqlCommand cmd1 = new MySqlCommand(query1, conn1);
                MySqlDataReader dr1 = cmd1.ExecuteReader();

                while (dr1.Read())
                {
                    countPat[0] = dr1.GetString("num");
                }

                cmd1.Dispose();
                dr1.Dispose();
                conn1.Close();

                MySqlConnection conn2 = objdb.getConn();
                String query2 = "SELECT COUNT(patient_code) AS num FROM patient WHERE year='"+year+"' AND month='"+month+"';";
                MySqlCommand cmd2 = new MySqlCommand(query2, conn2);
                MySqlDataReader dr2 = cmd2.ExecuteReader();

                while (dr2.Read())
                {
                    countPat[1] = dr2.GetString("num");
                }

                cmd2.Dispose();
                dr2.Dispose();
                conn2.Close();

            }
            catch
            {
                throw;
            }

            return countPat;
        }
    }
}
