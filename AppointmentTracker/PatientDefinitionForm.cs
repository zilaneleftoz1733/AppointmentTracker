using System;
using System.Drawing;
using System.Windows.Forms;
using AppointmentTracker.Models;

namespace AppointmentTracker
{
    public partial class PatientDefinitionForm : Form
    {
        public PatientDefinitionForm()
        {
            InitializeComponent();
        }

        private void btnSavePatient_Click(object sender, EventArgs e)
        {
            // Gerekli doğrulamaları gerçekleştirin
            if (!IsValidPatient())
                return;

            // Kullanıcıdan alınan bilgileri alın
            string firstName = txtFirstName.Text.Trim();
            string lastName = txtLastName.Text.Trim();
            string phoneNumber = txtPhoneNumber.Text.Trim();
            string email = txtEmail.Text.Trim();
            string address = txtAddress.Text.Trim();
            string tcIdentityNo = txtTCIdentityNo.Text.Trim();
            DateTime dateOfBirth = dateTimePickerDateOfBirth.Value;
            string bloodType = txtBloodType.Text.Trim();
            string reference = txtReference.Text.Trim();
            string description = txtDescription.Text.Trim();



            // Hasta bilgilerini bir nesne olarak oluşturun
            HastaTanimlari patient = new HastaTanimlari
            {
                adi = firstName,
                soyadi = lastName,
                telefonu = phoneNumber,
                email = email,
                adresi = address,
                tck_no = tcIdentityNo,
                dogum_tarihi = dateOfBirth,
                kan_grubu = bloodType,
                referans = reference,
                aciklama = description,
                kayit_tarihi = DateTime.Now // Kayıt tarihini ekleyin
            };

            // Hasta bilgilerini veritabanına kaydedin
            bool success = SavePatientToDatabase(patient);

            // Kaydetme işlemi başarılıysa kullanıcıya bilgi verin
            if (success)
            {
                MessageBox.Show("Patient successfully saved!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Alanları temizleyin
                ClearFields();
            }
            else
            {
                MessageBox.Show("An error occurred while saving the patient.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            // Geri dönme işlemini gerçekleştir
            this.Hide(); // Mevcut formu gizle
            AppointmentSystem appointmentSystem = new AppointmentSystem();
            appointmentSystem.Show(); // AppointmentSystem formunu göster
        }
        private void InitializeBackButton()
        {
            btnBack = new Button();
            btnBack.Text = "Geri";
            btnBack.Location = new Point(10, 10);
            btnBack.Click += btnBack_Click;
            this.Controls.Add(btnBack);
        }
        private bool SavePatientToDatabase(HastaTanimlari patient)
        {
            try
            {
                // DatabaseManager sınıfını kullanarak hasta bilgilerini kaydedin
                DatabaseManager manager = new DatabaseManager();
                return manager.SavePatient(patient);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return false;
            }
        }

        // Gerekli doğrulamaları gerçekleştirin
        private bool IsValidPatient()
        {
            // Örneğin, boş alanların kontrolü, TC kimlik numarasının uzunluğunun kontrolü, doğum tarihinin gelecekte olup olmadığının kontrolü, vb. yapılabilir
            // Doğrulama kontrollerini burada gerçekleştirin
            return true; // Geçerliyse true, aksi takdirde false döndürün
        }

        // Giriş alanlarını temizleyin
        private void ClearFields()
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtPhoneNumber.Clear();
            txtEmail.Clear();
            txtAddress.Clear();
            txtTCIdentityNo.Clear();
            dateTimePickerDateOfBirth.Value = DateTime.Now;
            txtBloodType.Clear();
            txtReference.Clear();
            txtDescription.Clear();
        }

        private void PatientDefinitionForm_Load(object sender, EventArgs e)
        {

        }
    }
}
