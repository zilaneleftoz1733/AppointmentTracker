namespace AppointmentTracker
{
    partial class PatientDefinitionForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtBloodType;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtReference;
        private System.Windows.Forms.TextBox txtTCIdentityNo;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateOfBirth;
        private System.Windows.Forms.Button btnSavePatient;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblTCIdentityNo;
        private System.Windows.Forms.Label lblDateOfBirth;
        private System.Windows.Forms.Label lblBloodType;
        private System.Windows.Forms.Label lblReference;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Button btnBack;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtBloodType = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtReference = new System.Windows.Forms.TextBox();
            this.txtTCIdentityNo = new System.Windows.Forms.TextBox();
            this.dateTimePickerDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.btnSavePatient = new System.Windows.Forms.Button();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblTCIdentityNo = new System.Windows.Forms.Label();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.lblBloodType = new System.Windows.Forms.Label();
            this.lblReference = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            
            // txtAddress
            
            this.txtAddress.Location = new System.Drawing.Point(161, 124);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(200, 22);
            this.txtAddress.TabIndex = 4;
            
            // txtGraduated from school
            
            this.txtBloodType.Location = new System.Drawing.Point(161, 208);
            this.txtBloodType.Name = "txtGraduatedFromSchool";
            this.txtBloodType.Size = new System.Drawing.Size(200, 22);
            this.txtBloodType.TabIndex = 7;
            
            // txtDescription
            
            this.txtDescription.Location = new System.Drawing.Point(161, 264);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(200, 22);
            this.txtDescription.TabIndex = 9;
            
            // txtEmail
            
            this.txtEmail.Location = new System.Drawing.Point(161, 96);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(200, 22);
            this.txtEmail.TabIndex = 3;
            
            // txtFirstName
            
            this.txtFirstName.Location = new System.Drawing.Point(161, 9);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(200, 22);
            this.txtFirstName.TabIndex = 0;
            
            // txtLastName
            
            this.txtLastName.Location = new System.Drawing.Point(161, 37);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(200, 22);
            this.txtLastName.TabIndex = 1;
            
            // txtPhoneNumber
            
            this.txtPhoneNumber.Location = new System.Drawing.Point(161, 68);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(200, 22);
            this.txtPhoneNumber.TabIndex = 2;
            
            // txtReference
             
            this.txtReference.Location = new System.Drawing.Point(161, 236);
            this.txtReference.Name = "txtReference";
            this.txtReference.Size = new System.Drawing.Size(200, 22);
            this.txtReference.TabIndex = 8;
            
            // txtTCIdentityNo
            
            this.txtTCIdentityNo.Location = new System.Drawing.Point(161, 152);
            this.txtTCIdentityNo.Name = "txtTCIdentityNo";
            this.txtTCIdentityNo.Size = new System.Drawing.Size(200, 22);
            this.txtTCIdentityNo.TabIndex = 5;
            
            // dateTimePickerDateOfBirth
           
            this.dateTimePickerDateOfBirth.Location = new System.Drawing.Point(161, 180);
            this.dateTimePickerDateOfBirth.Name = "dateTimePickerDateOfBirth";
            this.dateTimePickerDateOfBirth.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerDateOfBirth.TabIndex = 6;
            
            // btnSavePatient
            
            this.btnSavePatient.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSavePatient.Location = new System.Drawing.Point(161, 327);
            this.btnSavePatient.Name = "btnSavePatient";
            this.btnSavePatient.Size = new System.Drawing.Size(200, 30);
            this.btnSavePatient.TabIndex = 0;
            this.btnSavePatient.Text = "Hasta Kaydet";
            this.btnSavePatient.UseVisualStyleBackColor = false;
            this.btnSavePatient.Click += new System.EventHandler(this.btnSavePatient_Click);
            
            // lblFirstName
            
            this.lblFirstName.Location = new System.Drawing.Point(12, 12);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(100, 23);
            this.lblFirstName.TabIndex = 18;
            this.lblFirstName.Text = " Hasta Adı :";
            
            // lblLastName
            
            this.lblLastName.Location = new System.Drawing.Point(12, 40);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(100, 23);
            this.lblLastName.TabIndex = 17;
            this.lblLastName.Text = "Hasta Soyadı :";
            
            // lblPhoneNumber
            
            this.lblPhoneNumber.Location = new System.Drawing.Point(12, 68);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(100, 23);
            this.lblPhoneNumber.TabIndex = 16;
            this.lblPhoneNumber.Text = "Telefon Numarası :";
            
            // lblEmail
            
            this.lblEmail.Location = new System.Drawing.Point(12, 96);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(100, 23);
            this.lblEmail.TabIndex = 15;
            this.lblEmail.Text = "E-Mail:";
            
            // lblAddress
            
            this.lblAddress.Location = new System.Drawing.Point(12, 124);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(100, 23);
            this.lblAddress.TabIndex = 14;
            this.lblAddress.Text = "Adresi:";
            
            // lblTCIdentityNo
            
            this.lblTCIdentityNo.Location = new System.Drawing.Point(12, 152);
            this.lblTCIdentityNo.Name = "lblTCIdentityNo";
            this.lblTCIdentityNo.Size = new System.Drawing.Size(130, 23);
            this.lblTCIdentityNo.TabIndex = 13;
            this.lblTCIdentityNo.Text = "TC Kimlik Numarası:";
            
            // lblDateOfBirth
            
            this.lblDateOfBirth.Location = new System.Drawing.Point(12, 180);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(100, 23);
            this.lblDateOfBirth.TabIndex = 12;
            this.lblDateOfBirth.Text = "Doğum Tarihi:";
            
            // lblGraduated from school
             
            this.lblBloodType.Location = new System.Drawing.Point(12, 208);
            this.lblBloodType.Name = "lblGraduatedFromSchool";
            this.lblBloodType.Size = new System.Drawing.Size(100, 23);
            this.lblBloodType.TabIndex = 11;
            this.lblBloodType.Text = "Kan Grubu:";
            
            // lblReference
            
            this.lblReference.Location = new System.Drawing.Point(12, 236);
            this.lblReference.Name = "lblReference";
            this.lblReference.Size = new System.Drawing.Size(100, 23);
            this.lblReference.TabIndex = 10;
            this.lblReference.Text = "Referans:";
           
            // lblDescription
            
            this.lblDescription.Location = new System.Drawing.Point(12, 264);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(100, 23);
            this.lblDescription.TabIndex = 1;
            this.lblDescription.Text = "Açıklama:";
          
            // btnBack
          
            this.btnBack.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnBack.Location = new System.Drawing.Point(215, 382);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 30);
            this.btnBack.TabIndex = 19;
            this.btnBack.Text = "Geri";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            
            // PatientDefinitionForm
            
            this.ClientSize = new System.Drawing.Size(2034, 1049);
            this.Controls.Add(this.btnSavePatient);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblReference);
            this.Controls.Add(this.txtReference);
            this.Controls.Add(this.lblBloodType);
            this.Controls.Add(this.txtBloodType);
            this.Controls.Add(this.lblDateOfBirth);
            this.Controls.Add(this.dateTimePickerDateOfBirth);
            this.Controls.Add(this.lblTCIdentityNo);
            this.Controls.Add(this.txtTCIdentityNo);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.btnBack);
            this.Name = "PatientDefinitionForm";
            this.Text = "Hasta Tanımlama Formu";
            this.Load += new System.EventHandler(this.PatientDefinitionForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
    }
