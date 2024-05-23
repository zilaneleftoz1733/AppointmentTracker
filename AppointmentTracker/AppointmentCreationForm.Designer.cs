using System;
using System.Windows.Forms;
using System.Drawing;

namespace AppointmentTracker
{
    public partial class AppointmentCreationForm : Form
    {
       
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.DateTimePicker dateTimePickerRecordDate; 
        private System.Windows.Forms.DateTimePicker dateTimePickerStartTime;
        private System.Windows.Forms.DateTimePicker dateTimePickerEndTime;
        private System.Windows.Forms.Button btnCreateAppointment;
        private System.Windows.Forms.TextBox txtPatientName;
        private System.Windows.Forms.TextBox txtPatientLastName;
        private System.Windows.Forms.TextBox txtDoctorName;
        private System.Windows.Forms.TextBox txtDoctorLastName;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.CheckBox chkPatientAttended;


        private void InitializeComponent()
        {
            this.dateTimePickerRecordDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerStartTime = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerEndTime = new System.Windows.Forms.DateTimePicker();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnCreateAppointment = new System.Windows.Forms.Button();
            this.txtPatientName = new System.Windows.Forms.TextBox();
            this.txtPatientLastName = new System.Windows.Forms.TextBox();
            this.txtDoctorName = new System.Windows.Forms.TextBox();
            this.txtDoctorLastName = new System.Windows.Forms.TextBox();
            this.lblPatientName = new System.Windows.Forms.Label();
            this.lblPatientLastName = new System.Windows.Forms.Label();
            this.lblDoctorName = new System.Windows.Forms.Label();
            this.lblDoctorLastName = new System.Windows.Forms.Label();
            this.lblPatients = new System.Windows.Forms.Label();
            this.lblStartTime = new System.Windows.Forms.Label();
            this.lblEndTime = new System.Windows.Forms.Label();
            this.lblRecordDate = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.chkPatientAttended = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
          
            // dateTimePickerRecordDate
          
            this.dateTimePickerRecordDate.Location = new System.Drawing.Point(173, 381);
            this.dateTimePickerRecordDate.Name = "dateTimePickerRecordDate";
            this.dateTimePickerRecordDate.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerRecordDate.TabIndex = 14;
             
            // dateTimePickerStartTime
            
            this.dateTimePickerStartTime.Location = new System.Drawing.Point(173, 281);
            this.dateTimePickerStartTime.Name = "dateTimePickerStartTime";
            this.dateTimePickerStartTime.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerStartTime.TabIndex = 10;
        
            // dateTimePickerEndTime
           
            this.dateTimePickerEndTime.Location = new System.Drawing.Point(173, 330);
            this.dateTimePickerEndTime.Name = "dateTimePickerEndTime";
            this.dateTimePickerEndTime.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerEndTime.TabIndex = 12;
          
            // txtDescription
            
            this.txtDescription.Location = new System.Drawing.Point(173, 236);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(200, 22);
            this.txtDescription.TabIndex = 16;
            
            // btnCreateAppointment
           
            this.btnCreateAppointment.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnCreateAppointment.Location = new System.Drawing.Point(173, 470);
            this.btnCreateAppointment.Name = "btnCreateAppointment";
            this.btnCreateAppointment.Size = new System.Drawing.Size(200, 30);
            this.btnCreateAppointment.TabIndex = 18;
            this.btnCreateAppointment.Text = "Randevu Oluştur";
            this.btnCreateAppointment.UseVisualStyleBackColor = false;
           
            // txtPatientName
          
            this.txtPatientName.Location = new System.Drawing.Point(173, 137);
            this.txtPatientName.Name = "txtPatientName";
            this.txtPatientName.Size = new System.Drawing.Size(200, 22);
            this.txtPatientName.TabIndex = 0;
            
            // txtPatientLastName
           
            this.txtPatientLastName.Location = new System.Drawing.Point(173, 189);
            this.txtPatientLastName.Name = "txtPatientLastName";
            this.txtPatientLastName.Size = new System.Drawing.Size(200, 22);
            this.txtPatientLastName.TabIndex = 2;
           
            // txtDoctorName
        
            this.txtDoctorName.Location = new System.Drawing.Point(173, 36);
            this.txtDoctorName.Name = "txtDoctorName";
            this.txtDoctorName.Size = new System.Drawing.Size(200, 22);
            this.txtDoctorName.TabIndex = 4;
           
            // txtDoctorLastName
          
            this.txtDoctorLastName.Location = new System.Drawing.Point(173, 79);
            this.txtDoctorLastName.Name = "txtDoctorLastName";
            this.txtDoctorLastName.Size = new System.Drawing.Size(200, 22);
            this.txtDoctorLastName.TabIndex = 6;
          
            // lblPatientName
           
            this.lblPatientName.Location = new System.Drawing.Point(3, 135);
            this.lblPatientName.Name = "lblPatientName";
            this.lblPatientName.Size = new System.Drawing.Size(100, 24);
            this.lblPatientName.TabIndex = 1;
            this.lblPatientName.Text = "HASTA ADI:";
          
            // lblPatientLastName
         
            this.lblPatientLastName.Location = new System.Drawing.Point(3, 189);
            this.lblPatientLastName.Name = "lblPatientLastName";
            this.lblPatientLastName.Size = new System.Drawing.Size(135, 24);
            this.lblPatientLastName.TabIndex = 3;
            this.lblPatientLastName.Text = "HASTA SOYADI:";
        
            // lblDoctorName
           
            this.lblDoctorName.Location = new System.Drawing.Point(3, 39);
            this.lblDoctorName.Name = "lblDoctorName";
            this.lblDoctorName.Size = new System.Drawing.Size(100, 24);
            this.lblDoctorName.TabIndex = 5;
            this.lblDoctorName.Text = "DOKTOR ADI:";
            
            // lblDoctorLastName
           
            this.lblDoctorLastName.Location = new System.Drawing.Point(3, 82);
            this.lblDoctorLastName.Name = "lblDoctorLastName";
            this.lblDoctorLastName.Size = new System.Drawing.Size(135, 24);
            this.lblDoctorLastName.TabIndex = 7;
            this.lblDoctorLastName.Text = "DOKTOR SOYADI:";
         
            // lblPatients
          
            this.lblPatients.Location = new System.Drawing.Point(0, 0);
            this.lblPatients.Name = "lblPatients";
            this.lblPatients.Size = new System.Drawing.Size(100, 23);
            this.lblPatients.TabIndex = 0;
            
            // lblStartTime
         
            this.lblStartTime.Location = new System.Drawing.Point(3, 335);
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.Size = new System.Drawing.Size(100, 24);
            this.lblStartTime.TabIndex = 11;
            this.lblStartTime.Text = "BAŞLANGIÇ SAATİ:";
            
            // lblEndTime
          
            this.lblEndTime.Location = new System.Drawing.Point(3, 286);
            this.lblEndTime.Name = "lblEndTime";
            this.lblEndTime.Size = new System.Drawing.Size(100, 24);
            this.lblEndTime.TabIndex = 13;
            this.lblEndTime.Text = "BİTİŞ SAATİ:";
            
            // lblRecordDate
           
            this.lblRecordDate.Location = new System.Drawing.Point(3, 386);
            this.lblRecordDate.Name = "lblRecordDate";
            this.lblRecordDate.Size = new System.Drawing.Size(100, 24);
            this.lblRecordDate.TabIndex = 15;
            this.lblRecordDate.Text = "KAYIT TARİHİ:";
           
            // lblDescription
           
            this.lblDescription.Location = new System.Drawing.Point(3, 234);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(100, 24);
            this.lblDescription.TabIndex = 17;
            this.lblDescription.Text = "AÇIKLAMA:";
            
            // btnBack
           
            this.btnBack.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnBack.Location = new System.Drawing.Point(219, 540);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 30);
            this.btnBack.TabIndex = 19;
            this.btnBack.Text = "Geri";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
           
            // chkPatientAttended
          
            this.chkPatientAttended.Location = new System.Drawing.Point(173, 427);
            this.chkPatientAttended.Name = "chkPatientAttended";
            this.chkPatientAttended.Size = new System.Drawing.Size(200, 24);
            this.chkPatientAttended.TabIndex = 17;
            this.chkPatientAttended.Text = "Hasta Geldi mi?";
            this.chkPatientAttended.UseVisualStyleBackColor = true;
            
            // AppointmentCreationForm
            
            this.ClientSize = new System.Drawing.Size(1335, 904);
            this.Controls.Add(this.txtPatientName);
            this.Controls.Add(this.lblPatientName);
            this.Controls.Add(this.txtPatientLastName);
            this.Controls.Add(this.lblPatientLastName);
            this.Controls.Add(this.txtDoctorName);
            this.Controls.Add(this.lblDoctorName);
            this.Controls.Add(this.txtDoctorLastName);
            this.Controls.Add(this.lblDoctorLastName);
            this.Controls.Add(this.dateTimePickerStartTime);
            this.Controls.Add(this.lblStartTime);
            this.Controls.Add(this.dateTimePickerEndTime);
            this.Controls.Add(this.lblEndTime);
            this.Controls.Add(this.dateTimePickerRecordDate);
            this.Controls.Add(this.lblRecordDate);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.btnCreateAppointment);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.chkPatientAttended);
            this.Name = "AppointmentCreationForm";
            this.Text = "Randevu Oluşturma Formu";
            this.Load += new System.EventHandler(this.AppointmentCreationForm_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private void InitializeBackButton()
        {
            btnBack = new Button();
          
           
        }
        public AppointmentCreationForm()
        {
            InitializeComponent();
            btnCreateAppointment.Click += btnCreateAppointment_Click;
            InitializeBackButton();
        }
        private void AppointmentCreationForm_Load(object sender, EventArgs e)
        {
           
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
           
            this.Hide();
            AppointmentSystem appointmentSystem = new AppointmentSystem();
            appointmentSystem.Show(); 
        }
        private void btnCreateAppointment_Click(object sender, EventArgs e)
        {
            
            if (!IsValidAppointment())
                return;

            string doctorName = txtDoctorName.Text;
            string DoctorLastName = txtDoctorLastName.Text ;
            string patientName = txtPatientName.Text;
            string patientLastName = txtPatientLastName.Text;
            DateTime startTime = dateTimePickerStartTime.Value;
            DateTime endTime = dateTimePickerEndTime.Value;
            string description = txtDescription.Text;
            DateTime recordDate = dateTimePickerRecordDate.Value;
            bool patientAttended = chkPatientAttended.Checked;


            bool success = DatabaseManager.CreateAppointment(doctorName, DoctorLastName, patientName, patientLastName, startTime, endTime, description, patientAttended, recordDate);

            if (success)
            {
                MessageBox.Show("Randevu başarıyla oluşturuldu!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFields();
            }
            else
            {
                MessageBox.Show("Randevu oluşturulurken bir hata oluştu. Lütfen tekrar deneyin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private bool IsValidAppointment()
        {
            return true; 
        }

        private void ClearFields()
        {
            dateTimePickerStartTime.Value = DateTime.Now;
            dateTimePickerEndTime.Value = DateTime.Now;
            txtDescription.Text = "";
            txtDoctorName.Text = "";
            txtDoctorLastName.Text = "";
            txtPatientName.Text = "";
            txtPatientLastName.Text = "";
        }

        private Label lblPatientName;
        private Label lblPatientLastName;
        private Label lblDoctorName;
        private Label lblDoctorLastName;
        private Label lblPatients;
        private Label lblStartTime;
        private Label lblEndTime;
        private Label lblRecordDate;
        private Label lblDescription;
    }
}
