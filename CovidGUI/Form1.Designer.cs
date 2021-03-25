
namespace CovidGUI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.lblHopitalName = new System.Windows.Forms.Label();
            this.btnSAVE = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lbxInfo = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtHospitalName = new System.Windows.Forms.TextBox();
            this.txtHospitalAddress = new System.Windows.Forms.TextBox();
            this.txtRefDoc = new System.Windows.Forms.TextBox();
            this.txtAllergies = new System.Windows.Forms.TextBox();
            this.txtMedicalAid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBloodType = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtVaccine = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtHadCovid = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Covid Application";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 43);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hospital name:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 190);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Patient  ID:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 166);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Patient  Surname:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 142);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Patient  Name:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(117, 135);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(78, 20);
            this.txtName.TabIndex = 6;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(117, 183);
            this.txtNumber.Margin = new System.Windows.Forms.Padding(2);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(78, 20);
            this.txtNumber.TabIndex = 7;
            this.txtNumber.TextChanged += new System.EventHandler(this.txtNumber_TextChanged);
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(117, 159);
            this.txtSurname.Margin = new System.Windows.Forms.Padding(2);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(78, 20);
            this.txtSurname.TabIndex = 8;
            this.txtSurname.TextChanged += new System.EventHandler(this.txtSurname_TextChanged);
            // 
            // lblHopitalName
            // 
            this.lblHopitalName.AutoSize = true;
            this.lblHopitalName.Location = new System.Drawing.Point(117, 39);
            this.lblHopitalName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHopitalName.Name = "lblHopitalName";
            this.lblHopitalName.Size = new System.Drawing.Size(0, 13);
            this.lblHopitalName.TabIndex = 9;
            // 
            // btnSAVE
            // 
            this.btnSAVE.Location = new System.Drawing.Point(11, 313);
            this.btnSAVE.Margin = new System.Windows.Forms.Padding(2);
            this.btnSAVE.Name = "btnSAVE";
            this.btnSAVE.Size = new System.Drawing.Size(56, 19);
            this.btnSAVE.TabIndex = 11;
            this.btnSAVE.Text = "Save";
            this.btnSAVE.UseVisualStyleBackColor = true;
            this.btnSAVE.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(139, 313);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(56, 19);
            this.btnRefresh.TabIndex = 12;
            this.btnRefresh.Text = "Clear";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbxInfo
            // 
            this.lbxInfo.FormattingEnabled = true;
            this.lbxInfo.Location = new System.Drawing.Point(210, 35);
            this.lbxInfo.Margin = new System.Windows.Forms.Padding(2);
            this.lbxInfo.Name = "lbxInfo";
            this.lbxInfo.Size = new System.Drawing.Size(261, 316);
            this.lbxInfo.TabIndex = 13;
            this.lbxInfo.SelectedIndexChanged += new System.EventHandler(this.lbxInfo_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 89);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Refering Doc:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 118);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Allergies:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 65);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Hospital Address:";
            // 
            // txtHospitalName
            // 
            this.txtHospitalName.Location = new System.Drawing.Point(117, 36);
            this.txtHospitalName.Margin = new System.Windows.Forms.Padding(2);
            this.txtHospitalName.Name = "txtHospitalName";
            this.txtHospitalName.Size = new System.Drawing.Size(78, 20);
            this.txtHospitalName.TabIndex = 18;
            // 
            // txtHospitalAddress
            // 
            this.txtHospitalAddress.Location = new System.Drawing.Point(117, 58);
            this.txtHospitalAddress.Margin = new System.Windows.Forms.Padding(2);
            this.txtHospitalAddress.Name = "txtHospitalAddress";
            this.txtHospitalAddress.Size = new System.Drawing.Size(78, 20);
            this.txtHospitalAddress.TabIndex = 20;
            // 
            // txtRefDoc
            // 
            this.txtRefDoc.Location = new System.Drawing.Point(117, 82);
            this.txtRefDoc.Margin = new System.Windows.Forms.Padding(2);
            this.txtRefDoc.Name = "txtRefDoc";
            this.txtRefDoc.Size = new System.Drawing.Size(78, 20);
            this.txtRefDoc.TabIndex = 21;
            // 
            // txtAllergies
            // 
            this.txtAllergies.Location = new System.Drawing.Point(117, 111);
            this.txtAllergies.Margin = new System.Windows.Forms.Padding(2);
            this.txtAllergies.Name = "txtAllergies";
            this.txtAllergies.Size = new System.Drawing.Size(78, 20);
            this.txtAllergies.TabIndex = 23;
            // 
            // txtMedicalAid
            // 
            this.txtMedicalAid.Location = new System.Drawing.Point(117, 207);
            this.txtMedicalAid.Margin = new System.Windows.Forms.Padding(2);
            this.txtMedicalAid.Name = "txtMedicalAid";
            this.txtMedicalAid.Size = new System.Drawing.Size(78, 20);
            this.txtMedicalAid.TabIndex = 24;
            this.txtMedicalAid.TextChanged += new System.EventHandler(this.txtMedicalAid_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 214);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Medical aid:";
            // 
            // txtBloodType
            // 
            this.txtBloodType.Location = new System.Drawing.Point(115, 231);
            this.txtBloodType.Margin = new System.Windows.Forms.Padding(2);
            this.txtBloodType.Name = "txtBloodType";
            this.txtBloodType.Size = new System.Drawing.Size(78, 20);
            this.txtBloodType.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 238);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Blood Type:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 260);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 13);
            this.label11.TabIndex = 28;
            this.label11.Text = "Vaccine:";
            // 
            // txtVaccine
            // 
            this.txtVaccine.Location = new System.Drawing.Point(115, 255);
            this.txtVaccine.Margin = new System.Windows.Forms.Padding(2);
            this.txtVaccine.Name = "txtVaccine";
            this.txtVaccine.Size = new System.Drawing.Size(78, 20);
            this.txtVaccine.TabIndex = 29;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(20, 284);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 13);
            this.label12.TabIndex = 30;
            this.label12.Text = "Had Covid:";
            // 
            // txtHadCovid
            // 
            this.txtHadCovid.Location = new System.Drawing.Point(115, 279);
            this.txtHadCovid.Margin = new System.Windows.Forms.Padding(2);
            this.txtHadCovid.Name = "txtHadCovid";
            this.txtHadCovid.Size = new System.Drawing.Size(78, 20);
            this.txtHadCovid.TabIndex = 31;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 415);
            this.Controls.Add(this.txtHadCovid);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtVaccine);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtBloodType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMedicalAid);
            this.Controls.Add(this.txtAllergies);
            this.Controls.Add(this.txtRefDoc);
            this.Controls.Add(this.txtHospitalAddress);
            this.Controls.Add(this.txtHospitalName);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbxInfo);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnSAVE);
            this.Controls.Add(this.lblHopitalName);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "-";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label lblHopitalName;
        private System.Windows.Forms.Button btnSAVE;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ListBox lbxInfo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtHospitalName;
        private System.Windows.Forms.TextBox txtHospitalAddress;
        private System.Windows.Forms.TextBox txtRefDoc;
        private System.Windows.Forms.TextBox txtAllergies;
        private System.Windows.Forms.TextBox txtMedicalAid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBloodType;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtVaccine;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtHadCovid;
    }
}

