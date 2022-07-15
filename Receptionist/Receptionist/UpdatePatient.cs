using ProCare.Code;
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

namespace ProCare
{
    public partial class UpdatePatient : UserControl
    {

        DB_Con obj1 = new DB_Con();
        String pmh = "";
        public UpdatePatient()
        {
            InitializeComponent();
        }

        private void UpdatePatient_Load(object sender, EventArgs e)
        {

        }

        public void getPersonalDetails()
        {
            try
            {
                MySqlConnection conn = obj1.getConn();
                String query = null;

                String query1 = "SELECT * FROM patient WHERE patient_code='"+txtSearchUpd.Text+"';";

                MySqlCommand cmd = new MySqlCommand(query1, conn);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                DataTable table = new DataTable();
                da.Fill(table);

                pmh = table.Rows[0][1].ToString();
                txtNameUpd.Text = table.Rows[0][5].ToString();
                String gender= table.Rows[0][6].ToString();
                if (gender.Equals("Male"))
                {
                    rdMaleUpd.Checked = true;
                }
                else
                {
                    rdFemaleUpd.Checked = true;
                }
                txtOccupationUpd.Text = table.Rows[0][7].ToString();
                txtNICUpd.Text = table.Rows[0][8].ToString();
                txtEmailUpd.Text = table.Rows[0][9].ToString();
                cmbBloodGrpUpd.SelectedItem = table.Rows[0][10].ToString();
                datDOBUpd.Text= table.Rows[0][11].ToString();
                txtMobileNoUpd.Text= table.Rows[0][12].ToString();
                txtLANNoUpd.Text = table.Rows[0][12].ToString();
                txtHomeAddressUpd.Text = table.Rows[0][12].ToString();

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

        public void getPMH()
        {
            try
            {
                MySqlConnection conn = obj1.getConn();
                String query = null;

                String query1 = "SELECT * FROM pmh WHERE pmh_id='"+pmh+"';";

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
                    chkAsthmaUpd.Checked = true;
                }
                else
                {
                    chkAsthmaUpd.Checked = false;
                }

                if (d2.Equals("Y"))
                {
                    chkBleedingUpd.Checked = true;
                }
                else
                {
                    chkBleedingUpd.Checked = false;
                }


                if (d3.Equals("Y"))
                {
                    chkCardiacUpd.Checked = true;
                }
                else
                {
                    chkCardiacUpd.Checked = false;
                }

                if (d4.Equals("Y"))
                {
                    chkDiabetesUpd.Checked = true;
                }
                else
                {
                    chkDiabetesUpd.Checked = false;
                }

                if (d5.Equals("Y"))
                {
                    chkDrugUpd.Checked = true;
                }
                else
                {
                    chkDrugUpd.Checked = false;
                }

                if (d6.Equals("Y"))
                {
                    chkHypertensionUpd.Checked = true;
                }
                else
                {
                    chkHypertensionUpd.Checked = false;
                }

                if (d7.Equals("Y"))
                {
                    chkLiverUpd.Checked = true;
                }
                else
                {
                    chkLiverUpd.Checked = false;
                }

                if (d8.Equals("Y"))
                {
                    chkOtherDrugsUpd.Checked = true;
                }
                else
                {
                    chkOtherDrugsUpd.Checked = false;
                }

                txtOtherUpd.Text = d9;

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

        private void txtNameUpd_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearchUpd_Click(object sender, EventArgs e)
        {
            getPersonalDetails();
            getPMH();
        }

        private void btnUpdateUpd_Click(object sender, EventArgs e)
        {
            string message = "Do you want to update?";
            string title = "Update Confirm";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                try
                {
                    MySqlConnection conn = obj1.getConn();

                    String query = "UPDATE patient SET `name`='"+txtNameUpd.Text+"', `nic`='"+txtNICUpd.Text+"' WHERE patient_code='21Aug1';";

                    String message1 = "Update Successfully";
                    String title1 = "Success";
                    MessageBox.Show(message1, title1, MessageBoxButtons.OK, MessageBoxIcon.Information);

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    

                    cmd.Dispose();
                    conn.Close();
                }
                catch
                {

                }

                
            }
            else
            {
                
            }
        }

        private void btnDeleteUpd_Click(object sender, EventArgs e)
        {
            string message = "Do you want to update?";
            string title = "Update Confirm";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                

            }
            else
            {

            }
        }
    }
}
