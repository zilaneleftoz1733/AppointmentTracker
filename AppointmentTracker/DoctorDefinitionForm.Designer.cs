using System;
using System.Drawing;
using System.Windows.Forms;

namespace AppointmentTracker
{
    public partial class DoctorDefinitionForm : Form
    {
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtTCIdentityNo;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateOfBirth;
        private System.Windows.Forms.TextBox txtEducation;
        private System.Windows.Forms.TextBox txtGraduatedFromSchool;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnSaveDoctor;
        private System.Windows.Forms.Button btnBack;


        private void InitializeComponent()
        {
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtTCIdentityNo = new System.Windows.Forms.TextBox();
            this.dateTimePickerDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.txtEducation = new System.Windows.Forms.TextBox();
            this.txtGraduatedFromSchool = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnSaveDoctor = new System.Windows.Forms.Button();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblTCIdentityNo = new System.Windows.Forms.Label();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.lblEducation = new System.Windows.Forms.Label();
            this.lblGraduatedFromSchool = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            
            // txtFirstName
           
            this.txtFirstName.Location = new System.Drawing.Point(155, 36);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(200, 22);
            this.txtFirstName.TabIndex = 0;
            
            // txtLastName
           
            this.txtLastName.Location = new System.Drawing.Point(155, 75);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(200, 22);
            this.txtLastName.TabIndex = 1;
           
            // txtPhoneNumber
             
            this.txtPhoneNumber.Location = new System.Drawing.Point(155, 115);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(200, 22);
            this.txtPhoneNumber.TabIndex = 2;
            
            // txtEmail
             
            this.txtEmail.Location = new System.Drawing.Point(155, 155);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(200, 22);
            this.txtEmail.TabIndex = 3;
          
            // txtAddress
            
            this.txtAddress.Location = new System.Drawing.Point(155, 195);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(200, 22);
            this.txtAddress.TabIndex = 4;
            
            // txtTCIdentityNo
            
            this.txtTCIdentityNo.Location = new System.Drawing.Point(155, 236);
            this.txtTCIdentityNo.Name = "txtTCIdentityNo";
            this.txtTCIdentityNo.Size = new System.Drawing.Size(200, 22);
            this.txtTCIdentityNo.TabIndex = 5;
            
            // dateTimePickerDateOfBirth
           
            this.dateTimePickerDateOfBirth.Location = new System.Drawing.Point(155, 276);
            this.dateTimePickerDateOfBirth.Name = "dateTimePickerDateOfBirth";
            this.dateTimePickerDateOfBirth.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerDateOfBirth.TabIndex = 6;
            
            // txtEducation
            
            this.txtEducation.Location = new System.Drawing.Point(155, 316);
            this.txtEducation.Name = "txtEducation";
            this.txtEducation.Size = new System.Drawing.Size(200, 22);
            this.txtEducation.TabIndex = 7;
             
            // txtGraduatedFromSchool
             
            this.txtGraduatedFromSchool.Location = new System.Drawing.Point(155, 352);
            this.txtGraduatedFromSchool.Name = "txtGraduatedFromSchool";
            this.txtGraduatedFromSchool.Size = new System.Drawing.Size(200, 22);
            this.txtGraduatedFromSchool.TabIndex = 8;
            
            // txtDescription
           
            this.txtDescription.Location = new System.Drawing.Point(155, 396);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(200, 22);
            this.txtDescription.TabIndex = 9;
         
            // btnSaveDoctor
            
            this.btnSaveDoctor.Location = new System.Drawing.Point(155, 451);
            this.btnSaveDoctor.Name = "btnSaveDoctor";
            this.btnSaveDoctor.Size = new System.Drawing.Size(200, 30);
            this.btnSaveDoctor.TabIndex = 10;
            this.btnSaveDoctor.Text = "Doktor Kaydet";
            this.btnSaveDoctor.UseVisualStyleBackColor = true;
            this.btnSaveDoctor.Click += new System.EventHandler(this.btnSaveDoctor_Click);
            
            // lblFirstName
           
            this.lblFirstName.Location = new System.Drawing.Point(25, 35);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(100, 23);
            this.lblFirstName.TabIndex = 1;
            this.lblFirstName.Text = "Doktor Adı :";
           
            // lblLastName
            
            this.lblLastName.Location = new System.Drawing.Point(25, 75);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(100, 23);
            this.lblLastName.TabIndex = 2;
            this.lblLastName.Text = "Doktor Soyadı :";
           
            // lblPhoneNumber
           
            this.lblPhoneNumber.Location = new System.Drawing.Point(25, 115);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(124, 23);
            this.lblPhoneNumber.TabIndex = 3;
            this.lblPhoneNumber.Text = "Telefon Numarası :";
         
            // lblEmail
           
            this.lblEmail.Location = new System.Drawing.Point(25, 155);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(100, 23);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "E-Mail :";
          
            // lblAddress
         
            this.lblAddress.Location = new System.Drawing.Point(25, 195);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(100, 23);
            this.lblAddress.TabIndex = 5;
            this.lblAddress.Text = "Adresi :";
         
            // lblTCIdentityNo
         
            this.lblTCIdentityNo.Location = new System.Drawing.Point(25, 235);
            this.lblTCIdentityNo.Name = "lblTCIdentityNo";
            this.lblTCIdentityNo.Size = new System.Drawing.Size(100, 23);
            this.lblTCIdentityNo.TabIndex = 6;
            this.lblTCIdentityNo.Text = "TC Kimlik Numarası :";
             
            // lblDateOfBirth
            
            this.lblDateOfBirth.Location = new System.Drawing.Point(25, 275);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(100, 23);
            this.lblDateOfBirth.TabIndex = 7;
            this.lblDateOfBirth.Text = "Doğum Tarihi :";
          
            // lblEducation
            
            this.lblEducation.Location = new System.Drawing.Point(25, 315);
            this.lblEducation.Name = "lblEducation";
            this.lblEducation.Size = new System.Drawing.Size(100, 23);
            this.lblEducation.TabIndex = 8;
            this.lblEducation.Text = "Eğitim Durumu :";
           
            // lblGraduatedFromSchool
           
            this.lblGraduatedFromSchool.Location = new System.Drawing.Point(25, 355);
            this.lblGraduatedFromSchool.Name = "lblGraduatedFromSchool";
            this.lblGraduatedFromSchool.Size = new System.Drawing.Size(100, 23);
            this.lblGraduatedFromSchool.TabIndex = 9;
            this.lblGraduatedFromSchool.Text = "Mezun Olduğu Okul :";
            
            // lblDescription
           
            this.lblDescription.Location = new System.Drawing.Point(25, 395);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(100, 23);
            this.lblDescription.TabIndex = 10;
            this.lblDescription.Text = "Açıklama :";
          
            // btnBack
            
            this.btnBack.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnBack.Location = new System.Drawing.Point(200, 518);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 30);
            this.btnBack.TabIndex = 19;
            this.btnBack.Text = "Geri";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            
            // DoctorDefinitionForm
           
            this.ClientSize = new System.Drawing.Size(944, 804);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.txtTCIdentityNo);
            this.Controls.Add(this.lblTCIdentityNo);
            this.Controls.Add(this.dateTimePickerDateOfBirth);
            this.Controls.Add(this.lblDateOfBirth);
            this.Controls.Add(this.txtEducation);
            this.Controls.Add(this.lblEducation);
            this.Controls.Add(this.txtGraduatedFromSchool);
            this.Controls.Add(this.lblGraduatedFromSchool);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.btnSaveDoctor);
            this.Controls.Add(this.btnBack);
            this.Name = "DoctorDefinitionForm";
            this.Text = "Doktor Tanımlama Formu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private Label lblFirstName;
        private Label lblLastName;
        private Label lblPhoneNumber;
        private Label lblEmail;
        private Label lblAddress;
        private Label lblTCIdentityNo;
        private Label lblDateOfBirth;
        private Label lblEducation;
        private Label lblGraduatedFromSchool;
        private Label lblDescription;
    }
    }

