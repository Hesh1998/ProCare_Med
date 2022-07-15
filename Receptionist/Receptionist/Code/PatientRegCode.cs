using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ProCare.Code
{
    class PatientRegCode
    {
        DB_Con objdb = new DB_Con();

        public String getNextPatientCode()
        {
            String PatientCode = "";
            String patcnt = "";

            DateTime today = DateTime.Today;
            String date = today.ToString("dd/MM/yyyy");
            char[] charDate = date.ToCharArray();
            String month = "" + charDate[3] + charDate[4];
            String year = "" + charDate[6] + charDate[7] + charDate[8] + charDate[9];
            int monthInt = Int32.Parse(month);
            int yearInt = Int32.Parse(year);



            try
            {
                MySqlConnection conn2 = objdb.getConn();
                String query2 = "SELECT COUNT(patient_code) AS num FROM patient WHERE year='" + year + "' AND month='" + month + "';";
                MySqlCommand cmd2 = new MySqlCommand(query2, conn2);
                MySqlDataReader dr2 = cmd2.ExecuteReader();

                while (dr2.Read())
                {
                    patcnt = dr2.GetString("num");
                }

                cmd2.Dispose();
                dr2.Dispose();
                conn2.Close();

            }
            catch
            {
                throw;
            }

            String monthShort="";
            switch (monthInt)
            {
                case 1: monthShort = "Jan";break;
                case 2: monthShort = "Feb"; break;
                case 3: monthShort = "Mar"; break;
                case 4: monthShort = "Apr"; break;
                case 5: monthShort = "May"; break;
                case 6: monthShort = "Jun"; break;
                case 7: monthShort = "Jul"; break;
                case 8: monthShort = "Aug"; break;
                case 9: monthShort = "Sep"; break;
                case 10: monthShort = "Oct"; break;
                case 11: monthShort = "Nov"; break;
                case 12: monthShort = "Dec"; break;
            }

            int patient = Int32.Parse(patcnt)+1;

            PatientCode = ""+ charDate[8] + charDate[9]+monthShort+patient.ToString();
            return PatientCode;
        }

        public String getNextPMHcode()
        {
            String newPHMCode = "";

            String max = "";
            try
            {
                MySqlConnection conn = objdb.getConn();
                String query = "SELECT MAX(pmh_id) AS maxnum FROM pmh;";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    max = dr.GetString("maxnum");
                }

                cmd.Dispose();
                dr.Dispose();
                conn.Close();
            }
            catch
            {
                throw;
            }

            int realCount = Int32.Parse(max)+1;
            newPHMCode = realCount.ToString();
            return newPHMCode;
        }

        public void updatePMH(String d0, String d1, String d2, String d3, String d4, String d5, String d6, String d7, String d8, String d9)
        {
            try
            {
                MySqlConnection conn = objdb.getConn();
                String query = "INSERT INTO pmh VALUES('" + d0 + "', '" + d1 + "', '" + d2 + "', '" + d3 + "', '" + d4 + "', '" + d5 + "', '" + d6 + "', '" + d7 + "', '" + d8 + "', '" + d9 + "');";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch
            {
                throw;
            }
            
        }

        public void updatePersonal(String d0, String d1, String d2, String d3, String d4, String d5, String d6, String d7, String d8, String d9, String d10, String d11, String d12, String d13, String d14)
        {
            try
            {
                MySqlConnection conn = objdb.getConn();
                String query = "INSERT INTO patient VALUES ('"+d0+"', '"+d1+"', '"+d2+"', '"+d3+"', '"+d4+"', '"+d5+"', '"+d6+"', '"+d7+"', '"+d8+"', '"+d9+"', '"+d10+"', '"+d11+"', '"+d12+"', '"+d13+"', '"+d14+"');";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch
            {
                throw;
            }
        }

        public void addToTreatment2(String d1, String d2, String d3, String d4, String d5, String d6, String d7, String d8, String d9, String d10, String d11, String d12, String d13)
        {
            try
            {
                MySqlConnection conn = objdb.getConn();
                String query = "INSERT INTO treatment VALUES('3', 'ADM1', '21Aug1', '2021', '8', '9', '2021', '8', '25', 'Fever', 'Paracetamol', '5000', 'No');";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch
            {
                throw;
            }
        }
        public String getNextTreatCode()
        {
            String newTreatCode = "";

            String max = "";
            try
            {
                MySqlConnection conn = objdb.getConn();
                String query = "SELECT MAX(treatment_id) AS maxnum FROM treatment;";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    max = dr.GetString("maxnum");
                }

                cmd.Dispose();
                dr.Dispose();
                conn.Close();
            }
            catch
            {
                throw;
            }

            int realCount = Int32.Parse(max) + 1;
            newTreatCode = realCount.ToString();
            return newTreatCode;
        }


        public void addToTreatment(String d1, String d2, String d3, String d4, String d5, String d6, String d7, String d8, String d9, String d10, String d11, String d12, String d13)
        {
            try
            {
                MySqlConnection conn = objdb.getConn();
                String query = "INSERT INTO treatment VALUES('"+d1+"', 'ADM1', '"+d3+"', '"+d4+"', '"+d5+"', '"+d6+"', '"+d7+"', '"+d8+"', '"+d9+"', '"+d10+"', '"+d11+"', '"+d12+"', '"+d13+"');";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch
            {
                throw;
            }
        }
    }




}

