using System;
using System.Windows.Forms;

namespace AppointmentTracker
{
    public partial class AppointmentSystem : Form
    {
       

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnAppointmentList = new System.Windows.Forms.Button();
            this.btnAppointmentCreate = new System.Windows.Forms.Button();
            this.btnPatientDefine = new System.Windows.Forms.Button();
            this.btnDoctorDefine = new System.Windows.Forms.Button();
            this.SuspendLayout();
            
            // labelwelcome
            
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(776, 143);
            this.label1.TabIndex = 0;
            this.label1.Text = "Randevu Sistemine Hoşgeldiniz\r\nLütfen Yapmak İstediğiniz İşlemi Seçiniz";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            
            // btnAppointmentList
            
            this.btnAppointmentList.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAppointmentList.Location = new System.Drawing.Point(337, 155);
            this.btnAppointmentList.Name = "btnAppointmentList";
            this.btnAppointmentList.Size = new System.Drawing.Size(150, 50);
            this.btnAppointmentList.TabIndex = 1;
            this.btnAppointmentList.Text = "Randevu Listele";
            this.btnAppointmentList.UseVisualStyleBackColor = false;
            this.btnAppointmentList.Click += new System.EventHandler(this.btnAppointmentList_Click);
            
            // btnAppointmentCreate
            
            this.btnAppointmentCreate.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAppointmentCreate.Location = new System.Drawing.Point(337, 244);
            this.btnAppointmentCreate.Name = "btnAppointmentCreate";
            this.btnAppointmentCreate.Size = new System.Drawing.Size(150, 50);
            this.btnAppointmentCreate.TabIndex = 2;
            this.btnAppointmentCreate.Text = "Randevu Oluştur";
            this.btnAppointmentCreate.UseVisualStyleBackColor = false;
            this.btnAppointmentCreate.Click += new System.EventHandler(this.btnAppointmentCreate_Click);
            
            // btnPatientDefine
          
            this.btnPatientDefine.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnPatientDefine.Location = new System.Drawing.Point(337, 324);
            this.btnPatientDefine.Name = "btnPatientDefine";
            this.btnPatientDefine.Size = new System.Drawing.Size(150, 50);
            this.btnPatientDefine.TabIndex = 3;
            this.btnPatientDefine.Text = "Hasta Tanımla";
            this.btnPatientDefine.UseVisualStyleBackColor = false;
            this.btnPatientDefine.Click += new System.EventHandler(this.btnPatientDefine_Click);
           
            // btnDoctorDefine
            
            this.btnDoctorDefine.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnDoctorDefine.Location = new System.Drawing.Point(337, 402);
            this.btnDoctorDefine.Name = "btnDoctorDefine";
            this.btnDoctorDefine.Size = new System.Drawing.Size(150, 50);
            this.btnDoctorDefine.TabIndex = 4;
            this.btnDoctorDefine.Text = "Doktor Tanımla";
            this.btnDoctorDefine.UseVisualStyleBackColor = false;
            this.btnDoctorDefine.Click += new System.EventHandler(this.btnDoctorDefine_Click);
           
            // AppointmentSystem
            
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 578);
            this.Controls.Add(this.btnDoctorDefine);
            this.Controls.Add(this.btnPatientDefine);
            this.Controls.Add(this.btnAppointmentCreate);
            this.Controls.Add(this.btnAppointmentList);
            this.Controls.Add(this.label1);
            this.Name = "AppointmentSystem";
            this.Text = "Randevu Sistemi";
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAppointmentList;
        private System.Windows.Forms.Button btnAppointmentCreate;
        private System.Windows.Forms.Button btnPatientDefine;
        private System.Windows.Forms.Button btnDoctorDefine;

        private void btnAppointmentList_Click(object sender, EventArgs e)
        {
            AppointmentListingForm appointmentListingForm = new AppointmentListingForm();
            appointmentListingForm.Show();
        }

        private void btnAppointmentCreate_Click(object sender, EventArgs e)
        {
            AppointmentCreationForm appointmentCreationForm = new AppointmentCreationForm();
            appointmentCreationForm.Show();
        }

        private void btnPatientDefine_Click(object sender, EventArgs e)
        {
            PatientDefinitionForm patientDefinitionForm = new PatientDefinitionForm();
            patientDefinitionForm.Show();
        }

        private void btnDoctorDefine_Click(object sender, EventArgs e)
        {
            DoctorDefinitionForm doctorDefinitionForm = new DoctorDefinitionForm();
            doctorDefinitionForm.Show();
        }
    }
}
