using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ProCare.Code;

namespace ProCare
{
    public partial class Medication : UserControl
    {
        DB_Con obj1 = new DB_Con();
        PatientRegCode obj2 = new PatientRegCode();

        String pmh = "";
        String treatmentID = "";
        public Medication()
        {
            InitializeComponent();
        }

        public void getPersonalDetails()
        {
            try
            {
                MySqlConnection conn = obj1.getConn();
                String query = null;

                String query1 = "SELECT * FROM patient WHERE patient_code='" + txtSearchMed.Text + "';";

                MySqlCommand cmd = new MySqlCommand(query1, conn);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                DataTable table = new DataTable();
                da.Fill(table);

                pmh = table.Rows[0][1].ToString();
                txtNameMed.Text = table.Rows[0][5].ToString();
                txtGenderMed.Text = table.Rows[0][6].ToString();
                txtBloodMed.Text = table.Rows[0][10].ToString(); 




                da.Dispose();
                cmd.Dispose();
                conn.Close();

            }
            catch
            {
                String message = "Invalid Patient Code !";
                String title = "Error";
                MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Medication_Load(object sender, EventArgs e)
        {

        }


        public void getPMH()
        {
            try
            {
                MySqlConnection conn = obj1.getConn();
                String query = null;

                String query1 = "SELECT * FROM pmh WHERE pmh_id='" + pmh + "';";

                MySqlCommand cmd = new MySqlCommand(query1, conn);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                DataTable table = new DataTable();
                da.Fill(table);

                String d1, d2, d3, d4, d5, d6, d7, d8, d9;
                d1 = table.Rows[0][1].ToString();
                d2 = table.Rows[0][2].ToString();
                d3 = table.Rows[0][3].ToString();
                d4 = table.Rows[0][4].ToString();
                d5 = table.Rows[0][5].ToString();
                d6 = table.Rows[0][6].ToString();
                d7 = table.Rows[0][7].ToString();
                d8 = table.Rows[0][8].ToString();
                d9 = table.Rows[0][9].ToString();

                if (d1.Equals("Y"))
                {
                    chkAsthmaMed.Checked = true;
                }
                else
                {
                    chkAsthmaMed.Checked = false;
                }

                if (d2.Equals("Y"))
                {
                    chkBleedingMed.Checked = true;
                }
                else
                {
                    chkBleedingMed.Checked = false;
                }


                if (d3.Equals("Y"))
                {
                    chkCardiacMed.Checked = true;
                }
                else
                {
                    chkCardiacMed.Checked = false;
                }

                if (d4.Equals("Y"))
                {
                    chkDiabetesMed.Checked = true;
                }
                else
                {
                    chkDiabetesMed.Checked = false;
                }

                if (d5.Equals("Y"))
                {
                    chkDrugMed.Checked = true;
                }
                else
                {
                    chkDrugMed.Checked = false;
                }

                if (d6.Equals("Y"))
                {
                    chkHypertensionMed.Checked = true;
                }
                else
                {
                    chkHypertensionMed.Checked = false;
                }

                if (d7.Equals("Y"))
                {
                    chkLiverMed.Checked = true;
                }
                else
                {
                    chkLiverMed.Checked = false;
                }

                if (d8.Equals("Y"))
                {
                    chkOtherDrugMed.Checked = true;
                }
                else
                {
                    chkOtherDrugMed.Checked = false;
                }

                txtOtherMed.Text = d9;

                da.Dispose();
                cmd.Dispose();
                conn.Close();

            }
            catch
            {
                String message = "Invalid Patient Code !";
                String title = "Error";
                MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearchMed_Click(object sender, EventArgs e)
        {
            getPersonalDetails();
            getPMH();
            treatmentID = obj2.getNextPatientCode();
        }

        private void btnSaveMed_Click(object sender, EventArgs e)
        {
            String d1, d2, d3, d4, d5, d6, d7, d8, d9, d10, d11, d12, d13;
            d1 = treatmentID;
            d2 = "ADM1";
            d3 = txtSearchMed.Text;
            d4 = "2021";
            d5 = "8";
            d6 = "9";
            d7 = "2021";
            d8 = "8";
            d9 = "25";
            d10 = txtIllnessMed.Text;
            d11 = txtDrugAndDoseMed.Text;
            d12 = txtPaymentMed.Text;
            d13 = txtNotesMed.Text;

            try
            {
                // obj2.addToTreatment(d1, d2, d3, d4, d5, d6, d7, d8, d9, d10, d11, d12, d13);
                obj2.addToTreatment2(d1, d2, d3, d4, d5, d6, d7, d8, d9, d10, d11, d12, d13);
                String message = "Treatment Done !";
                String title = "Success";
                MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {

            }
            
        }
    }
}
