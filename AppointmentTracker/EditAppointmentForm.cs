using AppointmentTracker.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppointmentTracker
{
    public partial class EditAppointmentForm : Form
    {
        private RandevuTanimlari _appointment;

        public EditAppointmentForm(RandevuTanimlari appointment)
        {
            InitializeComponent();
            _appointment = appointment;
            LoadAppointmentDetails();
        }

        private void LoadAppointmentDetails()
        {
            txtDoctorName.Text = _appointment.doktor_adi;
            txtDoctorLastName.Text = _appointment.doktor_soyadi;
            txtPatientName.Text = _appointment.hasta_adi;
            txtPatientLastName.Text = _appointment.hasta_soyadi;
            dateTimePickerStartTime.Value = _appointment.baslangic_saati ?? DateTime.Now;
            dateTimePickerEndTime.Value = _appointment.bitis_saati ?? DateTime.Now;
            txtDescription.Text = _appointment.aciklama;
            dateTimePickerRecordDate.Value = _appointment.kayit_tarihi ?? DateTime.Now;


        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _appointment.doktor_adi = txtDoctorName.Text;
            _appointment.doktor_soyadi = txtDoctorLastName.Text;
            _appointment.hasta_adi = txtPatientName.Text;
            _appointment.hasta_soyadi = txtPatientLastName.Text;
            _appointment.baslangic_saati = dateTimePickerStartTime.Value;
            _appointment.bitis_saati = dateTimePickerEndTime.Value;
            _appointment.aciklama = txtDescription.Text;
            _appointment.kayit_tarihi = dateTimePickerRecordDate.Value;

            DatabaseManager manager = new DatabaseManager();
            if (manager.UpdateAppointment(_appointment))
            {
                MessageBox.Show("Randevu başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Randevu güncellenirken bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

