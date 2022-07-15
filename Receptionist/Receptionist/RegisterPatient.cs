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
    public partial class RegisterPatient : UserControl
    {
        PatientRegCode obj1 = new PatientRegCode();
        String pmhCode = "";
        

        public RegisterPatient()
        {
            InitializeComponent();
            cmbBloodGrp.SelectedIndex = 0;
            try
            {
                pmhCode = obj1.getNextPMHcode();
            }
            catch
            {

            }
            
        }

        private void RegisterPatient_Load(object sender, EventArgs e)
        {
            cmbBloodGrp.SelectedIndex = 0;
            String patientCode="";
            try
            {
                patientCode = obj1.getNextPatientCode();
            }
            catch
            {

            }
            
            txtPatientCode.Text = patientCode; 
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            isValid();
            
        }
        
        public void clearAll()
        {
            String patientCode = obj1.getNextPatientCode();
            txtPatientCode.Text = patientCode;

            txtName.Text = "";
            rdMale.Checked = false;
            rdFemale.Checked = false;
            txtOccupation.Text = "";
            datDOB.Refresh();
            cmbBloodGrp.SelectedIndex = 0;
            txtNIC.Text = "";
            txtMobileNo.Text = "";
            txtLANNo.Text = "";
            txtEmail.Text = "";
            txtHomeAddress.Text = "";
            chkAsthma.Checked = false;
            chkBleeding.Checked = false;
            chkCardiac.Checked = false;
            chkDiabetes.Checked = false;
            chkDrug.Checked = false;
            chkHypertension.Checked = false;
            chkLiver.Checked = false;
            chkOtherDrugs.Checked = false;
            txtOther.Text = "";
        }
        
        public void updatePMH()
        {
            pmhCode = obj1.getNextPMHcode();
            String d0, d1, d2, d3, d4, d5, d6, d7, d8, d9;
            d0 = pmhCode;
            if (chkAsthma.Checked)
            {
                d1 = "Y";
            }
            else
            {
                d1 = "N";
            }

            if (chkBleeding.Checked)
            {
                d2 = "Y";
            }
            else
            {
                d2 = "N";
            }

            if (chkCardiac.Checked)
            {
                d3 = "Y";
            }
            else
            {
                d3 = "N";
            }

            if (chkDiabetes.Checked)
            {
                d4 = "Y";
            }
            else
            {
                d4 = "N";
            }

            if (chkDrug.Checked)
            {
                d5 = "Y";
            }
            else
            {
                d5 = "N";
            }

            if (chkHypertension.Checked)
            {
                d6 = "Y";
            }
            else
            {
                d6 = "N";
            }


            if (chkLiver.Checked)
            {
                d7 = "Y";
            }
            else
            {
                d7 = "N";
            }

            if (chkOtherDrugs.Checked)
            {
                d8 = "Y";
            }
            else
            {
                d8 = "N";
            }

            d9 = txtOther.Text;

            obj1.updatePMH(d0, d1, d2, d3, d4, d5, d6, d7, d8, d9);
        }

        public void updatePersonal()
        {
            String d0, d1, d2, d3, d4, d5, d6, d7, d8, d9, d10, d11, d12, d13, d14;
            d0 = txtPatientCode.Text;
            d1 = pmhCode;

            DateTime today = DateTime.Today;
            String date = today.ToString("dd/MM/yyyy");
            char[] charDate = date.ToCharArray();
            String month = "" + charDate[3] + charDate[4];
            String year = "" + charDate[6] + charDate[7] + charDate[8] + charDate[9];
            String day = "" +charDate[0]+charDate[1];
            int monthInt = Int32.Parse(month);
            int yearInt = Int32.Parse(year);
            int dayInt = Int32.Parse(day);

            d2 = yearInt.ToString();
            d3 = monthInt.ToString();
            d4 = dayInt.ToString();
            d5 = txtName.Text;
            if (rdMale.Checked == true)
            {
                d6 = "Male";
            }
            else
            {
                d6 = "Female";
            }
            d7 = txtOccupation.Text;
            d8 = txtNIC.Text;
            d9 = txtEmail.Text;
            d10 = cmbBloodGrp.SelectedItem.ToString();
            d11 = datDOB.Text;
            d12 = txtMobileNo.Text;
            d13 = txtLANNo.Text;
            d14 = txtHomeAddress.Text;

            try{
                obj1.updatePersonal(d0, d1, d2, d3, d4, d5, d6, d7, d8, d9, d10, d11, d12, d13, d14);
            }catch
            {
                
            }
                
            
            
        }
        
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
        
        public void isValid()
        {
            String valid = "N";

            if (txtName.Text.Equals(""))
            {
                String message = "Please Enter Your Name !";
                String title = "Error";
                MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else if(rdMale.Checked==false && rdFemale.Checked == false)
            {
                String message = "Please Enter Your Gender !";
                String title = "Error";
                MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else if (!txtNIC.Text.Equals("") && isvalidNIC()==false)
            {
                String message = "Please Enter a valid NIC !";
                String title = "Error";
                MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }/*else if (txtMobileNo.Text.Equals("") && txtLANNo.Text.Equals(""))
            {
                String message = "Please Enter either Mobile Number or LAN Number !";
                String title = "Error";
                MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else if (validate_emailaddress.IsMatch(txtEmail.Text) != true)
            {
                String message = "Please Enter a valid Email Address !";
                String title = "Error";
                MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
            else if (txtHomeAddress.Text.Equals(""))
            {
                String message = "Please Enter your Home Address";
                String title = "Error";
                MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                updatePMH();
                updatePersonal();
                String message = "Patient Registered Successfully";
                String title = "Success";
                MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearAll();
            }
        }

        


        public bool isvalidNIC()
        {
            bool isNICValid = true;
            String numNIC = txtNIC.Text;
            if (numNIC.Length == 10 || numNIC.Length == 12)
            {
                if (numNIC.Length == 10)
                { // Old NIC number
                    if (numNIC[9] == 'V' || numNIC[9] == 'v')
                    {
                        for (int i = 0; i < 9; i++)
                        {
                            if (!Char.IsDigit(numNIC[i]))
                            {
                                isNICValid = false;
                            }
                        }
                    }
                    else
                    {
                        isNICValid = false;
                    }
                }
                else if (numNIC.Length == 12)
                {
                    for (int i = 0; i < 12; i++)
                    {
                        if (!Char.IsDigit(numNIC[i]))
                        {
                            isNICValid = false;
                        }
                    }
                }
                else
                {
                    isNICValid = false;
                }
            }
            else
            {
                isNICValid = false;
            }

            return isNICValid;
        }
        
        private void btnReset_Click(object sender, EventArgs e)
        {
            clearAll();
        }
        
        private void PatientReg_VisibleChanged(object sender, EventArgs e)
        {
            clearAll();
        }

        private void PatientRet_Enter(object sender, EventArgs e)
        {
            clearAll();
        }
    }
}
