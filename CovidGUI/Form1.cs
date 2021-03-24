using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CovidGUI
{
    
    public partial class Form1 : Form
    {

        info i = new info();

        public Form1()
        {
            InitializeComponent();
            
        }
       

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        public void txtName_TextChanged(object sender, EventArgs e)
        {
             
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtName.Text= "";
            txtNumber.Text = "";
            txtSurname.Text = "";
            txtAllergies.Text = "";
            txtHospitalAddress.Text = "";
            txtHospitalName.Text= "";
            txtHospitalNumber.Text = "";
            txtRefDoc.Text = "";
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
           String strName = txtName.Text;
           String strID = txtNumber.Text;
           String strSurname = txtSurname.Text;
           String strRefDoc  = txtRefDoc.Text;
           String strHospitalName = txtHospitalNumber.Text;
           String strHospitalAddress = txtHospitalAddress.Text;
           String strAllergies = txtAllergies.Text;
            String strHospitalNumber = txtHospitalNumber.Text;

            lbxInfo.Items.Add("Patient Name: "+ strName);
            lbxInfo.Items.Add("Patient Surname: "+strSurname);
            lbxInfo.Items.Add("Patient ID: "+ strID);
            lbxInfo.Items.Add("Allergies: " + strAllergies);
            lbxInfo.Items.Add("Refered Dockter: " +strRefDoc);
            lbxInfo.Items.Add("Hospital Name: " +strHospitalName);
            lbxInfo.Items.Add("Hospital Address: " +strHospitalAddress);
            lbxInfo.Items.Add("Hospital Number: "+strHospitalNumber);
            
        }

        private void txtNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSurname_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void cbxHadCovid_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
