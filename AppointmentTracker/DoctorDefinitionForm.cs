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
    public partial class DoctorDefinitionForm : Form
    {
        private DoktorTanimlari _doctor;

        public DoctorDefinitionForm(DoktorTanimlari doctor = null)
        {
            InitializeComponent();
            _doctor = doctor ?? new DoktorTanimlari();
            LoadDoctorDetails();
        }

        private void LoadDoctorDetails()
        {
            if (_doctor.id > 0)
            {
                txtFirstName.Text = _doctor.adi;
                txtLastName.Text = _doctor.soyadi;
                txtPhoneNumber.Text = _doctor.telefonu;
                txtEmail.Text = _doctor.email;
                txtAddress.Text = _doctor.adresi;
                txtTCIdentityNo.Text = _doctor.tck_no;
                dateTimePickerDateOfBirth.Value = _doctor.dogum_tarihi ?? DateTime.Now;
                txtEducation.Text = _doctor.egitim_durumu;
                txtGraduatedFromSchool.Text = _doctor.mezun_oldugu_okul;
                txtDescription.Text = _doctor.aciklama;
            }
        }
        private void BtnBack_Click(object sender, EventArgs e)
        {
            
            this.Hide(); 
            AppointmentSystem appointmentSystem = new AppointmentSystem();
            appointmentSystem.Show(); 
        }
        private void InitializeBackButton()
        {
            btnBack = new Button();
            btnBack.Text = "Geri";
            btnBack.Location = new Point(10, 10);
            btnBack.Click += btnBack_Click;
            this.Controls.Add(btnBack);
        }
        private void btnSaveDoctor_Click(object sender, EventArgs e)
        {
            _doctor.adi = txtFirstName.Text;
            _doctor.soyadi = txtLastName.Text;
            _doctor.telefonu = txtPhoneNumber.Text;
            _doctor.email = txtEmail.Text;
            _doctor.adresi = txtAddress.Text;
            _doctor.tck_no = txtTCIdentityNo.Text;
            _doctor.dogum_tarihi = dateTimePickerDateOfBirth.Value;
            _doctor.egitim_durumu = txtEducation.Text;
            _doctor.mezun_oldugu_okul = txtGraduatedFromSchool.Text;
            _doctor.aciklama = txtDescription.Text;
            _doctor.kayit_tarihi = DateTime.Now;

            DatabaseManager manager = new DatabaseManager();

            bool success;
            if (_doctor.id > 0)
            {
                success = manager.UpdateDoctor(_doctor);
            }
            else
            {
                success = manager.SaveDoctor(_doctor);
            }

            if (success)
            {
                MessageBox.Show("Doktor başarıyla kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Doktor kaydedilirken bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            AppointmentSystem appointmentSystem = new AppointmentSystem();
            appointmentSystem.Show(); 
        }
    }
}
