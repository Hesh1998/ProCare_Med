using ProCare.Code;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Receptionist
{

    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();
        }

        LogInCode obj1 = new LogInCode();


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
             
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        
        


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShow.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }

        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            String username = txtUsername.Text;
            String password = txtPassword.Text;

            String[] valid;

            

            try
            {
                valid = obj1.getAccess(username, password);
                if (valid[0].Equals("Y"))
                {
                    frmProCare wrk = new frmProCare(valid[1]);
                    wrk.ShowDialog();
                    this.Close();
                }
                else
                {
                    String message = "Invalid Username or Password !";
                    String title = "Error";
                    MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex)
            {
                String message = "Invalid Username or Password !";
                String title = "Error";
                MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
