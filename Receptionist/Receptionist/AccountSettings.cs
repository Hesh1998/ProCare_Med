using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ProCare.Code;
using System.IO;

namespace ProCare
{
    public partial class AccountSettings : Form
    {
        DB_Con obj1 = new DB_Con();
        MySqlConnection conn;
        MySqlCommand cmd;
        MySqlDataAdapter da;
        String username, prefixOrg;
        

        public AccountSettings(String username, String prefix)
        {
            InitializeComponent();
            this.username = username;
            prefixOrg = prefix;
            showPhoto();
            getDetails();
        }

        public void showPhoto()
        {
            try
            {
                conn = obj1.getConn();
                String query = null;

                if (prefixOrg.Equals("ADM") || prefixOrg.Equals("DOC"))
                {
                    query = "SELECT * FROM doctor WHERE doctor_id='"+username+"';";
                }
                else if (prefixOrg.Equals("NUR") || prefixOrg.Equals("MGR") || prefixOrg.Equals("PHA") || prefixOrg.Equals("REC"))
                {
                    query = "SELECT * FROM staff WHERE staff_id='"+username+"';";
                }

                cmd = new MySqlCommand(query, conn);
                da = new MySqlDataAdapter(cmd);

                DataTable table = new DataTable();
                da.Fill(table);

                byte[] img = (byte[])table.Rows[0][3];

                MemoryStream ms = new MemoryStream(img);
                picDP.Image = Image.FromStream(ms);
                da.Dispose();
                cmd.Dispose();
                conn.Close();

            }
            catch
            {

            }
            
        }

        public void getDetails()
        {
            try
            {
                conn = obj1.getConn();
                String query = null;

                if (prefixOrg.Equals("ADM") || prefixOrg.Equals("DOC"))
                {
                    query = "SELECT password FROM doctor WHERE doctor_id='"+username+"';";
                }
                else if (prefixOrg.Equals("NUR") || prefixOrg.Equals("MGR") || prefixOrg.Equals("PHA") || prefixOrg.Equals("REC"))
                {
                    query = "SELECT password FROM staff WHERE staff_id='"+username+"';";
                }

                cmd = new MySqlCommand(query, conn);
                da = new MySqlDataAdapter(cmd);

                DataTable table = new DataTable();
                da.Fill(table);

                txtStaffID.Text = username;
                txtPassword.Text = table.Rows[0][0].ToString();
                
                da.Dispose();
                cmd.Dispose();
                conn.Close();

            }
            catch
            {

            }
        }


        

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void AccountSettings_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnChnage_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;*.png;)|*.jpg;*.jpeg;.*.gif;*.png";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                picDP.Image = new Bitmap(opnfd.FileName);
            }
        }


        public void setImage()
        {
            try
            {
                conn = obj1.getConn();
                String query = null;

                

                if (prefixOrg.Equals("ADM") || prefixOrg.Equals("DOC"))
                {
                    query = "UPDATE doctor SET `profile_picture`=@img WHERE doctor_id='" + username+"';";
                }
                else if (prefixOrg.Equals("NUR") || prefixOrg.Equals("MGR") || prefixOrg.Equals("PHA") || prefixOrg.Equals("REC"))
                {
                    query = "SELECT password FROM staff WHERE staff_id='" + username + "';";
                }

                MemoryStream stream = new MemoryStream();
                picDP.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                byte[] img = stream.ToArray();
                cmd.Parameters.AddWithValue("@img", img);

                cmd.ExecuteNonQuery();

                cmd.Dispose();
                conn.Close();
            }
            catch
            {

            }

            
        }

        public void setPassword()
        {
            if(!txtNewPass.Text.Equals("") || !txtConPass.Text.Equals(""))
            {
                if (!txtNewPass.Text.Equals(txtConPass.Text))
                {
                    String message = "New Password and Confirm Password is not matching !";
                    String title = "Error";
                    MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        conn = obj1.getConn();

                        String query = null;

                        if (prefixOrg.Equals("ADM") || prefixOrg.Equals("DOC"))
                        {
                            query="UPDATE doctor SET `password` = '"+txtNewPass.Text+"' WHERE doctor_id = '"+username+"';";
                        }
                        else if (prefixOrg.Equals("NUR") || prefixOrg.Equals("MGR") || prefixOrg.Equals("PHA") || prefixOrg.Equals("REC"))
                        {
                            query = "UPDATE staff SET `password` = '" + txtNewPass.Text + "' WHERE staff_id = '" + username + "';";
                        }

                        cmd = new MySqlCommand(query, conn);
                        cmd.ExecuteNonQuery();
                        String message = "New Profile Picture and Password updated successfully !";
                        String title = "Success";
                        MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);

                        cmd.Dispose();
                        conn.Close();
                    }
                    catch
                    {

                    }
                }
            }
        }

        

        private void btnSave_Click(object sender, EventArgs e)
        {
            setImage();
            setPassword();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
