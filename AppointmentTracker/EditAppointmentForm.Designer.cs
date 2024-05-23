using System.Drawing;
using System.Windows.Forms;

namespace AppointmentTracker
{
    partial class EditAppointmentForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtDoctorName;
        private System.Windows.Forms.TextBox txtDoctorLastName;
        private System.Windows.Forms.TextBox txtPatientName;
        private System.Windows.Forms.TextBox txtPatientLastName;
        private System.Windows.Forms.DateTimePicker dateTimePickerStartTime;
        private System.Windows.Forms.DateTimePicker dateTimePickerEndTime;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.DateTimePicker dateTimePickerRecordDate;
        private System.Windows.Forms.Button btnSave;

        private void InitializeComponent()
        {
            this.txtDoctorName = new System.Windows.Forms.TextBox();
            this.txtDoctorLastName = new System.Windows.Forms.TextBox();
            this.txtPatientName = new System.Windows.Forms.TextBox();
            this.txtPatientLastName = new System.Windows.Forms.TextBox();
            this.dateTimePickerStartTime = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerEndTime = new System.Windows.Forms.DateTimePicker();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.dateTimePickerRecordDate = new System.Windows.Forms.DateTimePicker();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblDoctorName = new System.Windows.Forms.Label();
            this.lblDoctorLastName = new System.Windows.Forms.Label();
            this.lblPatientName = new System.Windows.Forms.Label();
            this.lblPatientLastName = new System.Windows.Forms.Label();
            this.lblStartTime = new System.Windows.Forms.Label();
            this.lblEndTime = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblRecordDate = new System.Windows.Forms.Label();
            this.SuspendLayout();
           
            // txtDoctorName
            
            this.txtDoctorName.Location = new System.Drawing.Point(166, 14);
            this.txtDoctorName.Margin = new System.Windows.Forms.Padding(4);
            this.txtDoctorName.Name = "txtDoctorName";
            this.txtDoctorName.Size = new System.Drawing.Size(265, 22);
            this.txtDoctorName.TabIndex = 16;
          
            // txtDoctorLastName
          
            this.txtDoctorLastName.Location = new System.Drawing.Point(166, 44);
            this.txtDoctorLastName.Margin = new System.Windows.Forms.Padding(4);
            this.txtDoctorLastName.Name = "txtDoctorLastName";
            this.txtDoctorLastName.Size = new System.Drawing.Size(265, 22);
            this.txtDoctorLastName.TabIndex = 15;
           
            // txtPatientName
            
            this.txtPatientName.Location = new System.Drawing.Point(166, 79);
            this.txtPatientName.Margin = new System.Windows.Forms.Padding(4);
            this.txtPatientName.Name = "txtPatientName";
            this.txtPatientName.Size = new System.Drawing.Size(265, 22);
            this.txtPatientName.TabIndex = 14;
         
            // txtPatientLastName
            
            this.txtPatientLastName.Location = new System.Drawing.Point(166, 108);
            this.txtPatientLastName.Margin = new System.Windows.Forms.Padding(4);
            this.txtPatientLastName.Name = "txtPatientLastName";
            this.txtPatientLastName.Size = new System.Drawing.Size(265, 22);
            this.txtPatientLastName.TabIndex = 13;
           
            // dateTimePickerStartTime
            
            this.dateTimePickerStartTime.Location = new System.Drawing.Point(166, 143);
            this.dateTimePickerStartTime.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerStartTime.Name = "dateTimePickerStartTime";
            this.dateTimePickerStartTime.Size = new System.Drawing.Size(265, 22);
            this.dateTimePickerStartTime.TabIndex = 12;
           
            // dateTimePickerEndTime
           
            this.dateTimePickerEndTime.Location = new System.Drawing.Point(166, 170);
            this.dateTimePickerEndTime.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerEndTime.Name = "dateTimePickerEndTime";
            this.dateTimePickerEndTime.Size = new System.Drawing.Size(265, 22);
            this.dateTimePickerEndTime.TabIndex = 11;
            
            // txtDescription
            
            this.txtDescription.Location = new System.Drawing.Point(166, 204);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(265, 22);
            this.txtDescription.TabIndex = 10;
          
            // dateTimePickerRecordDate
         
            this.dateTimePickerRecordDate.Location = new System.Drawing.Point(166, 234);
            this.dateTimePickerRecordDate.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerRecordDate.Name = "dateTimePickerRecordDate";
            this.dateTimePickerRecordDate.Size = new System.Drawing.Size(265, 22);
            this.dateTimePickerRecordDate.TabIndex = 9;
            
            // btnSave
           
            this.btnSave.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSave.Location = new System.Drawing.Point(166, 322);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(265, 28);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Kaydet";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
          
            // lblDoctorName
           
            this.lblDoctorName.Location = new System.Drawing.Point(16, 15);
            this.lblDoctorName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDoctorName.Name = "lblDoctorName";
            this.lblDoctorName.Size = new System.Drawing.Size(133, 28);
            this.lblDoctorName.TabIndex = 0;
            this.lblDoctorName.Text = "Doktor Adı:";
           
            // lblDoctorLastName
           
            this.lblDoctorLastName.Location = new System.Drawing.Point(16, 47);
            this.lblDoctorLastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDoctorLastName.Name = "lblDoctorLastName";
            this.lblDoctorLastName.Size = new System.Drawing.Size(133, 28);
            this.lblDoctorLastName.TabIndex = 1;
            this.lblDoctorLastName.Text = "Doktor Soyadı:";
         
            // lblPatientName
           
            this.lblPatientName.Location = new System.Drawing.Point(16, 79);
            this.lblPatientName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPatientName.Name = "lblPatientName";
            this.lblPatientName.Size = new System.Drawing.Size(133, 28);
            this.lblPatientName.TabIndex = 2;
            this.lblPatientName.Text = "Hasta Adı:";
            
            // lblPatientLastName
           
            this.lblPatientLastName.Location = new System.Drawing.Point(16, 111);
            this.lblPatientLastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPatientLastName.Name = "lblPatientLastName";
            this.lblPatientLastName.Size = new System.Drawing.Size(133, 28);
            this.lblPatientLastName.TabIndex = 3;
            this.lblPatientLastName.Text = "Hasta Soyadı:";
         
            // lblStartTime
            
            this.lblStartTime.Location = new System.Drawing.Point(16, 143);
            this.lblStartTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.Size = new System.Drawing.Size(133, 28);
            this.lblStartTime.TabIndex = 4;
            this.lblStartTime.Text = "Başlangıç Saati:";
           
            // lblEndTime
            
            this.lblEndTime.Location = new System.Drawing.Point(16, 175);
            this.lblEndTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEndTime.Name = "lblEndTime";
            this.lblEndTime.Size = new System.Drawing.Size(133, 28);
            this.lblEndTime.TabIndex = 5;
            this.lblEndTime.Text = "Bitiş Saati:";
           
            // lblDescription
           
            this.lblDescription.Location = new System.Drawing.Point(16, 207);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(133, 28);
            this.lblDescription.TabIndex = 6;
            this.lblDescription.Text = "Açıklama:";
            
            // lblRecordDate
            
            this.lblRecordDate.Location = new System.Drawing.Point(16, 239);
            this.lblRecordDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRecordDate.Name = "lblRecordDate";
            this.lblRecordDate.Size = new System.Drawing.Size(133, 28);
            this.lblRecordDate.TabIndex = 7;
            this.lblRecordDate.Text = "Kayıt Tarihi:";
           
            // EditAppointmentForm
           
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 786);
            this.Controls.Add(this.lblDoctorName);
            this.Controls.Add(this.lblDoctorLastName);
            this.Controls.Add(this.lblPatientName);
            this.Controls.Add(this.lblPatientLastName);
            this.Controls.Add(this.lblStartTime);
            this.Controls.Add(this.lblEndTime);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblRecordDate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dateTimePickerRecordDate);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.dateTimePickerEndTime);
            this.Controls.Add(this.dateTimePickerStartTime);
            this.Controls.Add(this.txtPatientLastName);
            this.Controls.Add(this.txtPatientName);
            this.Controls.Add(this.txtDoctorLastName);
            this.Controls.Add(this.txtDoctorName);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EditAppointmentForm";
            this.Text = "Randevu Düzenle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private Label lblDoctorName;
        private Label lblDoctorLastName;
        private Label lblPatientName;
        private Label lblPatientLastName;
        private Label lblStartTime;
        private Label lblEndTime;
        private Label lblDescription;
        private Label lblRecordDate;
    }
}
