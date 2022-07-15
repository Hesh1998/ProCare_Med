using MySql.Data.MySqlClient;
using ProCare.Code;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Receptionist
{
    public partial class Dashboard : UserControl
    {
        DashboardCode obj1 = new DashboardCode();
        public Dashboard()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
        
        public void getEarnings()
        {
            int indexMonth = cmbMonth.SelectedIndex+1;
            String year = (String)cmbYear.SelectedItem;
            String month = indexMonth.ToString();
            String earning = "";
            try
            {
                earning = obj1.getEarning(year, month);
            }
            catch(Exception ex)
            {

            }

            if (earning.Equals(""))
            {
                earning = "0";
            }

            earning = "LKR " + earning;
            lblEarning.Text = earning;
        }

        public void patientCount()
        {
            int indexMonth = cmbMonthNum.SelectedIndex + 1;
            String year = (String)cmbYearNum.SelectedItem;
            String month = indexMonth.ToString();
            String[] countPat={ "0", "0"};
            try
            {
                countPat = obj1.getPatientCount(year, month);
            }
            catch(Exception ex)
            {

            }

            if (countPat[0].Equals(""))
            {
                countPat[0] = "0";
            }

            if (countPat[1].Equals(""))
            {
                countPat[1] = "0";
            }

            lblNumOfPatients.Text = countPat[0];
            lblRegPat.Text = countPat[1];
        }

        public void findDate()
        {
            DateTime today = DateTime.Today;
            String date = today.ToString("dd/MM/yyyy");
            char[] charDate = date.ToCharArray();
            String month = "" + charDate[3] + charDate[4];
            String year = "" + charDate[6] + charDate[7] + charDate[8] + charDate[9];
            int monthInt = Int32.Parse(month);
            int yearInt = Int32.Parse(year);

            cmbMonth.SelectedIndex = monthInt-1;
            cmbYear.SelectedItem = yearInt;
            cmbYear.SelectedIndex = 0;
            cmbMonthNum.SelectedIndex = monthInt - 1;
            cmbYearNum.SelectedItem = yearInt;
            cmbYearNum.SelectedIndex = 0;
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            cmbMonth.SelectedIndex = 7;
            cmbYear.SelectedIndex = 0;
            cmbMonth.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbYear.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMonthNum.SelectedIndex = 7;
            cmbYearNum.SelectedIndex = 0;
            cmbMonthNum.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbYearNum.DropDownStyle = ComboBoxStyle.DropDownList;
            
            findDate();
            getEarnings();
            patientCount();
            
            lblNoOfDoctors.Text = obj1.noOfDOC();
            lblNoOfManagers.Text = obj1.noOfMGR();
            lblNoOfNurses.Text = obj1.noOfNUR();
            lblNoOfPharmacists.Text = obj1.noOfPHA();
            lblNoOfReceptionists.Text = obj1.noOfREC();
        }

        private void cmbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            getEarnings();
        }

        private void cmbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            getEarnings();
        }

        private void cmbYearNum_SelectedIndexChanged(object sender, EventArgs e)
        {
            patientCount();
        }

        private void cmbMonthNum_SelectedIndexChanged(object sender, EventArgs e)
        {
            patientCount();
        }

        private void Dashboard_VisbleChanged(object sender, EventArgs e)
        {
            findDate();
        }
    }
}
