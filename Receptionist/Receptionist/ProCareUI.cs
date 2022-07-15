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
using System.IO;

namespace Receptionist
{
    public partial class frmProCare : Form
    {
        String username, prefix;
        LogInCode obj1 = new LogInCode();

        public frmProCare(String username)
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            TopMost = true;
            this.username = username;
            getPrefix();

            
            if (prefix.Equals("ADM"))
            {
                pnlDashboardInfo.Visible = true;
                
                pnlRegPatientImplement.Visible = false;
                
                
                pnlUpdPatient.Visible = false;
                pnlMed.Visible = false;
                pnlDrugInventory.Visible = false;
                pnlStfMgt.Visible = false;

                pnlSelectDashboard.Visible = true;
                pnlSelectDrugInventory.Visible = false;
                pnlSelectMedication.Visible = false;
                pnlSelectRegPatient.Visible = false;
                pnlSelectStaffMgt.Visible = false;
                pnlSelectUpdPatient.Visible = false;
            }
            else if (prefix.Equals("DOC")){
                btnStaffMgt.Enabled = false;
                btnDashboard.Enabled = false;

                pnlDashboardInfo.Visible = false;
                pnlRegPatientImplement.Visible = true;
                pnlUpdPatient.Visible = false;
                pnlMed.Visible = false;
                pnlDrugInventory.Visible = false;
                pnlStfMgt.Visible = false;

                pnlSelectDashboard.Visible = false;
                pnlSelectDrugInventory.Visible = false;
                pnlSelectMedication.Visible = false;
                pnlSelectRegPatient.Visible = true;
                pnlSelectStaffMgt.Visible = false;
                pnlSelectUpdPatient.Visible = false;
            }
            else if (prefix.Equals("REC"))
            {
                btnDashboard.Enabled = false;
                btnMedication.Enabled = false;
                btnDrugInventory.Enabled = false;
                btnStaffMgt.Enabled = false;

                pnlDashboardInfo.Visible = false;
                pnlRegPatientImplement.Visible = true;
                pnlUpdPatient.Visible = false;
                pnlMed.Visible = false;
                pnlDrugInventory.Visible = false;
                pnlStfMgt.Visible = false;

                pnlSelectDashboard.Visible = false;
                pnlSelectDrugInventory.Visible = false;
                pnlSelectMedication.Visible = false;
                pnlSelectRegPatient.Visible = true;
                pnlSelectStaffMgt.Visible = false;
                pnlSelectUpdPatient.Visible = false;
            }
            else if (prefix.Equals("MGR"))
            {
                btnDashboard.Enabled = false;
                btnMedication.Enabled = false;
                btnDrugInventory.Enabled = false;
                btnRegPatient.Enabled = false;
                btnUpdPatient.Enabled = false;

                pnlDashboardInfo.Visible = false;
                pnlRegPatientImplement.Visible = false;
                pnlUpdPatient.Visible = false;
                pnlMed.Visible = false;
                pnlDrugInventory.Visible = false;
                pnlStfMgt.Visible = true;

                pnlSelectDashboard.Visible = false;
                pnlSelectDrugInventory.Visible = false;
                pnlSelectMedication.Visible = false;
                pnlSelectRegPatient.Visible = false;
                pnlSelectStaffMgt.Visible = true;
                pnlSelectUpdPatient.Visible = false;
            }
            else if (prefix.Equals("PHA"))
            {
                btnDashboard.Enabled = false;
                btnMedication.Enabled = false;
                btnStaffMgt.Enabled = false;
                btnRegPatient.Enabled = false;
                btnUpdPatient.Enabled = false;

                pnlDashboardInfo.Visible = false;
                pnlRegPatientImplement.Visible = false;
                pnlUpdPatient.Visible = false;
                pnlMed.Visible = false;
                pnlDrugInventory.Visible = true;
                pnlStfMgt.Visible = false;

                pnlSelectDashboard.Visible = false;
                pnlSelectDrugInventory.Visible = true;
                pnlSelectMedication.Visible = false;
                pnlSelectRegPatient.Visible = false;
                pnlSelectStaffMgt.Visible = false;
                pnlSelectUpdPatient.Visible = false;
            }
            else if (prefix.Equals("NUR"))
            {
                btnDashboard.Enabled = false;
                btnMedication.Enabled = false;
                btnDrugInventory.Enabled = false;
                btnStaffMgt.Enabled = false;

                pnlDashboardInfo.Visible = false;
                pnlRegPatientImplement.Visible = true;
                pnlUpdPatient.Visible = false;
                pnlMed.Visible = false;
                pnlDrugInventory.Visible = false;
                pnlStfMgt.Visible = false;

                pnlSelectDashboard.Visible = false;
                pnlSelectDrugInventory.Visible = false;
                pnlSelectMedication.Visible = false;
                pnlSelectRegPatient.Visible = true;
                pnlSelectStaffMgt.Visible = false;
                pnlSelectUpdPatient.Visible = false;
            }

            setUserName();
        }

        public void setUserName()
        {
            try
            {
                String name = obj1.getName(username, prefix);
                lblProfName.Text = name;
            }
            catch
            {

            }
        }

        public void getPrefix()
        {
            char[] chars = username.ToCharArray();
            prefix = "" + chars[0] + chars[1] + chars[2];
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tmrDateAndTime.Start();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            pnlDashboardInfo.Visible = true;
            
            pnlRegPatientImplement.Visible = false;
            pnlUpdPatient.Visible = false;
            pnlMed.Visible = false;
            pnlDrugInventory.Visible = false;
            pnlStfMgt.Visible = false;

            pnlSelectDashboard.Visible = true;
            pnlSelectDrugInventory.Visible = false;
            pnlSelectMedication.Visible = false;
            pnlSelectRegPatient.Visible = false;
            pnlSelectStaffMgt.Visible = false;
            pnlSelectUpdPatient.Visible = false;
        }

        private void pnlDashboard_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pnlDashboardInfo.Visible = false;
            pnlRegPatientImplement.Visible = false;
            pnlUpdPatient.Visible = true;
            pnlMed.Visible = false;
            pnlDrugInventory.Visible = false;
            pnlStfMgt.Visible = false;

            pnlSelectDashboard.Visible = false;
            pnlSelectDrugInventory.Visible = false;
            pnlSelectMedication.Visible = false;
            pnlSelectRegPatient.Visible = false;
            pnlSelectStaffMgt.Visible = false;
            pnlSelectUpdPatient.Visible = true;
        }

        private void btnConsultant_Click(object sender, EventArgs e)
        {
            pnlDashboardInfo.Visible = false;
            pnlRegPatientImplement.Visible = false;
            pnlUpdPatient.Visible = false;
            pnlMed.Visible = true;
            pnlDrugInventory.Visible = false;
            pnlStfMgt.Visible = false;

            pnlSelectDashboard.Visible = false;
            pnlSelectDrugInventory.Visible = false;
            pnlSelectMedication.Visible = true;
            pnlSelectRegPatient.Visible = false;
            pnlSelectStaffMgt.Visible = false;
            pnlSelectUpdPatient.Visible = false;
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void btnRegPatient_Click(object sender, EventArgs e)
        {
            pnlDashboardInfo.Visible = false;
            pnlRegPatientImplement.Visible = true;
            pnlUpdPatient.Visible = false;
            pnlMed.Visible = false;
            pnlDrugInventory.Visible = false;
            pnlStfMgt.Visible = false;

            pnlSelectDashboard.Visible = false;
            pnlSelectDrugInventory.Visible = false;
            pnlSelectMedication.Visible = false;
            pnlSelectRegPatient.Visible = true;
            pnlSelectStaffMgt.Visible = false;
            pnlSelectUpdPatient.Visible = false;
        }

        private void pnlDashboardContent_Load(object sender, EventArgs e)
        {

        }

        private void pnlRegPatientContent_Load(object sender, EventArgs e)
        {

        }

        private void pnlDashboardContent_Load_1(object sender, EventArgs e)
        {

        }

        private void pnlSelectDashboard_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pnlTop_Paint(object sender, PaintEventArgs e)
        {
            
            ControlPaint.DrawBorder(e.Graphics, pnlTop.ClientRectangle,
            Color.Black, 0, ButtonBorderStyle.Solid, // left
            Color.Black, 0, ButtonBorderStyle.Solid, // top
            Color.Black, 0, ButtonBorderStyle.Solid, // right
            Color.Gainsboro, 1, ButtonBorderStyle.Solid);// bottom
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ProCare.AccountSettings acc = new ProCare.AccountSettings(username, prefix);
            acc.ShowDialog();    
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void registerPatient1_Load(object sender, EventArgs e)
        {

        }

        private void dashboard1_Load(object sender, EventArgs e)
        {

        }

        private void Timer_action(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("HH : mm");
            lblDate.Text = DateTime.Now.ToString("MM : dd : yyyy");
        }

        private void lblDate_Click(object sender, EventArgs e)
        {

        }

        private void btnDrugInventory_Click(object sender, EventArgs e)
        {
            pnlDashboardInfo.Visible = false;
            pnlRegPatientImplement.Visible = false;
            pnlUpdPatient.Visible = false;
            pnlMed.Visible = false;
            pnlDrugInventory.Visible = true;
            pnlStfMgt.Visible = false;

            pnlSelectDashboard.Visible = false;
            pnlSelectDrugInventory.Visible = true;
            pnlSelectMedication.Visible = false;
            pnlSelectRegPatient.Visible = false;
            pnlSelectStaffMgt.Visible = false;
            pnlSelectUpdPatient.Visible = false;
        }

        private void pnlStfMgt_Load(object sender, EventArgs e)
        {

        }

        private void btnStaffMgt_Click(object sender, EventArgs e)
        {
            pnlDashboardInfo.Visible = false;
            pnlRegPatientImplement.Visible = false;
            pnlUpdPatient.Visible = false;
            pnlMed.Visible = false;
            pnlDrugInventory.Visible = false;
            pnlStfMgt.Visible = true;

            pnlSelectDashboard.Visible = false;
            pnlSelectDrugInventory.Visible = false;
            pnlSelectMedication.Visible = false;
            pnlSelectRegPatient.Visible = false;
            pnlSelectStaffMgt.Visible = true;
            pnlSelectUpdPatient.Visible = false;
        }
    }
}
