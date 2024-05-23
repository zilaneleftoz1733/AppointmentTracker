using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using AppointmentTracker.Models;

namespace AppointmentTracker
{
    public class DatabaseManager
    {
        private SqlConnection connection;
        private string connectionString;

        public DatabaseManager()
        {
            // Veritabanı bağlantısı 
            connectionString = "Data Source=ZILAN_ELEFTOZ;Initial Catalog=dbRandevuTakipSistemi;Integrated Security=True;";
            connection = new SqlConnection(connectionString);
        }

        public DataTable ExecuteQuery(string query, Dictionary<string, object> parameters = null)
        {
            using (SqlConnection conn = new SqlConnection(this.connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    if (parameters != null)
                    {
                        foreach (var parameter in parameters)
                        {
                            command.Parameters.AddWithValue(parameter.Key, parameter.Value);
                        }
                    }

                    conn.Open();
                    DataTable dataTable = new DataTable();
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }
                    return dataTable;
                }
            }
        }

        public int ExecuteNonQuery(string query, Dictionary<string, object> parameters = null)
        {
            using (SqlConnection conn = new SqlConnection(this.connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    if (parameters != null)
                    {
                        foreach (var parameter in parameters)
                        {
                            command.Parameters.AddWithValue(parameter.Key, parameter.Value);
                        }
                    }

                    conn.Open();
                    return command.ExecuteNonQuery();
                }
            }
        }

        public bool SaveDoctor(DoktorTanimlari doctor)
        {
            try
            {
                string query = "INSERT INTO tbl_DoktorTanimlari (adi, soyadi, telefonu, tck_no, adresi, email, dogum_tarihi, egitim_durumu, aciklama, kayit_tarihi) " +
                               "VALUES (@FirstName, @LastName, @PhoneNumber, @TCIdentityNo, @Address, @Email, @DateOfBirth, @Education, @Description, @RegistrationDate)";

                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { "@FirstName", doctor.adi },
                    { "@LastName", doctor.soyadi },
                    { "@PhoneNumber", doctor.telefonu },
                    { "@TCIdentityNo", doctor.tck_no },
                    { "@Address", doctor.adresi },
                    { "@Email", doctor.email },
                    { "@DateOfBirth", doctor.dogum_tarihi },
                    { "@Education", doctor.egitim_durumu },
                    { "@Description", doctor.aciklama },
                    { "@RegistrationDate", doctor.kayit_tarihi }
                };

                int result = ExecuteNonQuery(query, parameters);
                return result > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return false;
            }
        }

        public bool UpdateDoctor(DoktorTanimlari doctor)
        {
            try
            {
                string query = "UPDATE tbl_DoktorTanimlari SET adi = @FirstName, soyadi = @LastName, telefonu = @PhoneNumber, tck_no = @TCIdentityNo, adresi = @Address, email = @Email, dogum_tarihi = @DateOfBirth, egitim_durumu = @Education, aciklama = @Description WHERE id = @DoctorId";

                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { "@DoctorId", doctor.id },
                    { "@FirstName", doctor.adi },
                    { "@LastName", doctor.soyadi },
                    { "@PhoneNumber", doctor.telefonu },
                    { "@TCIdentityNo", doctor.tck_no },
                    { "@Address", doctor.adresi },
                    { "@Email", doctor.email },
                    { "@DateOfBirth", doctor.dogum_tarihi },
                    { "@Education", doctor.egitim_durumu },
                    { "@Description", doctor.aciklama }
                };

                int result = ExecuteNonQuery(query, parameters);
                return result > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return false;
            }
        }

        public static bool CreateAppointment(string doctorName, string doctorLastName, string patientName, string patientLastName, DateTime startTime, DateTime endTime, string description, bool patientAttended, DateTime recordDate)

        {
            string query = "INSERT INTO tbl_RandevuTanimlari (doktor_adi, doktor_soyadi, hasta_adi,hasta_soyadi, baslangic_saati,bitis_saati, aciklama, kayit_tarihi,hasta_randevuya_geldi_mi) VALUES (@doktor_adi,@doktor_soyadi ,@hasta_adi,@hasta_soyadi, @baslangic_saati, @bitis_saati, @aciklama, @kayit_tarihi,@hasta_randevuya_geldi_mi)";
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@doktor_adi", doctorName },
                { "@doktor_soyadi", doctorLastName },
                { "@hasta_adi", patientName },
                { "@hasta_soyadi", patientLastName },
                { "@baslangic_saati", startTime },
                { "@bitis_saati", endTime },
                { "@aciklama", description },
                { "@kayit_tarihi", recordDate },
                { "@hasta_randevuya_geldi_mi", patientAttended }
            };

            try
            {
                DatabaseManager manager = new DatabaseManager();
                int rowsAffected = manager.ExecuteNonQuery(query, parameters);
                return rowsAffected > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return false;
            }
        }

        public List<RandevuTanimlari> GetAppointments()
        {
            List<RandevuTanimlari> appointments = new List<RandevuTanimlari>();
            string query = "SELECT * FROM tbl_RandevuTanimlari";
            DataTable dt = ExecuteQuery(query);

            foreach (DataRow row in dt.Rows)
            {
                RandevuTanimlari appointment = new RandevuTanimlari
                {
                    id = Convert.ToInt32(row["id"]),
                    doktor_adi = row["doktor_adi"].ToString(),
                    doktor_soyadi = row["doktor_soyadi"].ToString(),
                    hasta_adi = row["hasta_adi"].ToString(),
                    hasta_soyadi = row["hasta_soyadi"].ToString(),
                    baslangic_saati = row["baslangic_saati"] is TimeSpan ? DateTime.Today.Add((TimeSpan)row["baslangic_saati"]) : Convert.ToDateTime(row["baslangic_saati"]),
                    bitis_saati = row["bitis_saati"] is TimeSpan ? DateTime.Today.Add((TimeSpan)row["bitis_saati"]) : Convert.ToDateTime(row["bitis_saati"]),
                    aciklama = row["aciklama"].ToString(),
                    kayit_tarihi = Convert.ToDateTime(row["kayit_tarihi"]),
                    hasta_randevuya_geldi_mi = Convert.ToBoolean(row["hasta_randevuya_geldi_mi"]) 
                };
            

            appointments.Add(appointment);
            }
            return appointments;
        }

        public bool DeleteAppointment(int id)
        {
            string query = "DELETE FROM tbl_RandevuTanimlari WHERE id = @id";
            Dictionary<string, object> parameters = new Dictionary<string, object> { { "@id", id } };
            return ExecuteNonQuery(query, parameters) > 0;
        }

        public bool UpdateAppointment(RandevuTanimlari appointment)
        { 
            string query = "UPDATE tbl_RandevuTanimlari SET doktor_adi = @doktor_adi, doktor_soyadi = @doktor_soyadi, hasta_adi = @hasta_adi, hasta_soyadi = @hasta_soyadi, baslangic_saati = @baslangic_saati, bitis_saati = @bitis_saati, aciklama = @aciklama, kayit_tarihi = @kayit_tarihi WHERE id = @id";
            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@doktor_adi", appointment.doktor_adi },
                { "@doktor_soyadi", appointment.doktor_soyadi },
                { "@hasta_adi", appointment.hasta_adi },
                { "@hasta_soyadi", appointment.hasta_soyadi },
                { "@baslangic_saati", appointment.baslangic_saati },
                { "@bitis_saati", appointment.bitis_saati },
                { "@aciklama", appointment.aciklama },
                { "@kayit_tarihi", appointment.kayit_tarihi },
                { "@hasta_randevuya_geldi_mi", appointment.hasta_randevuya_geldi_mi }, 
                { "@id", appointment.id }
            };
            return ExecuteNonQuery(query, parameters) > 0;
        }

        public bool SavePatient(HastaTanimlari patient)
        {
            try
            {
                string query = "INSERT INTO tbl_HastaTanimlari (adi, soyadi, telefonu, tck_no, adresi, email, dogum_tarihi, referans, aciklama, kayit_tarihi) " +
                               "VALUES (@FirstName, @LastName, @PhoneNumber, @TCIdentityNo, @Address, @Email, @DateOfBirth, @Reference, @Description, @RegistrationDate)";

                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { "@FirstName", patient.adi },
                    { "@LastName", patient.soyadi },
                    { "@PhoneNumber", patient.telefonu },
                    { "@TCIdentityNo", patient.tck_no },
                    { "@Address", patient.adresi },
                    { "@Email", patient.email },
                    { "@DateOfBirth", patient.dogum_tarihi },
                    { "@Reference", patient.referans },
                    { "@Description", patient.aciklama },
                    { "@RegistrationDate", patient.kayit_tarihi }
                };

                int result = ExecuteNonQuery(query, parameters);
                return result > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return false;
            }
        }
    }
}
