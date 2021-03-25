using ImTools;
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
           
            txtName.Text = "";
            txtNumber.Text = "";
            txtSurname.Text = "";
            txtAllergies.Text = "";
            txtHospitalAddress.Text = "";
            txtHospitalName.Text = "";
            txtRefDoc.Text = "";
            txtMedicalAid.Text = "";
            txtBloodType.Text = "";
            txtVaccine.Text = "";
            txtHadCovid.Text = "";
        }
        
        public void button1_Click(object sender, EventArgs e)
        {
            setPatientDetails(i);
             PrintInfo(i);
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

        private void displayHopitalInfo(info i)
        {
           txtHospitalName.Text = i.Hospital_Name;
           txtHospitalAddress.Text = i.Hospital_Address;
            
        }


        


            private void setPatientDetails(info i)
        {
            string Hospital_Name = txtHospitalName.Text;
            string Hospital_Address = txtHospitalAddress.Text;
            string strID = txtNumber.Text;
            string strFirstName = txtName.Text;
            string strSurname = txtSurname.Text;
            string strMedAid = txtMedicalAid.Text;
            string strRefDoc = txtRefDoc.Text;
            string cBloodType = txtBloodType.Text;
            string strAllergies = txtAllergies.Text;
            string strVaccine = txtVaccine.Text;
            string bHadCovid = txtHadCovid.Text;

            i.setArrays(i.ArraySize + 1);
            i.AddPatient(strID, strMedAid, strFirstName, strSurname, strRefDoc, cBloodType, strAllergies, bHadCovid, strVaccine);
        }




        private void PrintInfo(info i)
            {
                lbxInfo.Items.Clear();
                for (int x = 0; x < i.ArraySize; x++)
                {
                lbxInfo.Items.Add("Hospital name : " + i.Hospital_Name);
                lbxInfo.Items.Add("Hospital address : " + i.Hospital_Address);
                lbxInfo.Items.Add("Patient Name and ID: " + i.StrName[x] + " \n" + i.StrSurname[x] + "\t" + i.StrID[x]);
                lbxInfo.Items.Add("Medical Aid: " + i.StrMedAid[x]);
                lbxInfo.Items.Add("Blood Type:" + i.CBloodType[x]);
                lbxInfo.Items.Add("Referring Dr: " + i.StrRefDoc[x]);
                lbxInfo.Items.Add("Allergies: " + i.StrAllergies[x]);
                lbxInfo.Items.Add("Vaccine: " + i.StrVaccine[x]);
                lbxInfo.Items.Add("Patient had COVID-19: " + i.BHasCovid[x]);
                lbxInfo.Items.Add("=====================================");
                
            }
        }

        private void txtMedicalAid_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbxInfo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    } 
}

//i.String StrName = txtName.Text;
//i.String StrSurname = txtSurname.Text;
//i.String StrRefDoc = txtRefDoc.Text;
//i.String Hospital_Address = txtHospitalAddress.Text;
//i.String StrAllergies = txtAllergies.Text;
//i.String Hospital_Name = txtHospitalName.Text;
//i.String StrID = txtNumber.Text;