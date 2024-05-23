using AppointmentTracker.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace AppointmentTracker
{
    public partial class AppointmentListingForm : Form
    {
        private static AppointmentListingForm _instance;

        public static AppointmentListingForm Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new AppointmentListingForm();
                }
                return _instance;
            }
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
           
            this.Hide(); 
            AppointmentSystem appointmentSystem = new AppointmentSystem();
            appointmentSystem.Show(); 
        }
        private void AppointmentListingForm_Load(object sender, EventArgs e)
        {
            LoadAppointments();
        }

        public void LoadAppointments()
        {
            DatabaseManager manager = new DatabaseManager();
            List<RandevuTanimlari> appointments = manager.GetAppointments();
            dataGridViewAppointments.DataSource = appointments;
        }

        private void btnDeleteAppointment_Click(object sender, EventArgs e)
        {
            if (dataGridViewAppointments.SelectedRows.Count > 0)
            {
                int selectedId = (int)dataGridViewAppointments.SelectedRows[0].Cells["id"].Value;
                DatabaseManager manager = new DatabaseManager();
                if (manager.DeleteAppointment(selectedId))
                {
                    MessageBox.Show("Randevu başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadAppointments();
                }
                else
                {
                    MessageBox.Show("Randevu silinirken bir hata oluştu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
       
        private void btnEditAppointment_Click(object sender, EventArgs e)
        {
            if (dataGridViewAppointments.SelectedRows.Count > 0)
            {
                RandevuTanimlari appointment = (RandevuTanimlari)dataGridViewAppointments.SelectedRows[0].DataBoundItem;
                EditAppointmentForm editForm = new EditAppointmentForm(appointment);
                editForm.ShowDialog();
                LoadAppointments();
            }
        }
        private void InitializeBackButton()
        {
            btnBack = new Button();
            btnBack.Text = "Geri";
            btnBack.Location = new Point(10, 10);
            btnBack.Click += btnBack_Click;
            this.Controls.Add(btnBack);
        }
        private void InitializeComponent()
        {
            this.dataGridViewAppointments = new System.Windows.Forms.DataGridView();
            this.btnDeleteAppointment = new System.Windows.Forms.Button();
            this.btnEditAppointment = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAppointments)).BeginInit();
            this.SuspendLayout();
            
            // dataGridViewAppointments
             
            this.dataGridViewAppointments.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridViewAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAppointments.Location = new System.Drawing.Point(24, 23);
            this.dataGridViewAppointments.Name = "dataGridViewAppointments";
            this.dataGridViewAppointments.RowHeadersWidth = 51;
            this.dataGridViewAppointments.RowTemplate.Height = 24;
            this.dataGridViewAppointments.Size = new System.Drawing.Size(1478, 498);
            this.dataGridViewAppointments.TabIndex = 0;
            
            // btnDeleteAppointment
            
            this.btnDeleteAppointment.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnDeleteAppointment.Location = new System.Drawing.Point(984, 547);
            this.btnDeleteAppointment.Name = "btnDeleteAppointment";
            this.btnDeleteAppointment.Size = new System.Drawing.Size(150, 30);
            this.btnDeleteAppointment.TabIndex = 1;
            this.btnDeleteAppointment.Text = "Randevuyu Sil";
            this.btnDeleteAppointment.UseVisualStyleBackColor = false;
            this.btnDeleteAppointment.Click += new System.EventHandler(this.btnDeleteAppointment_Click);
           
            // btnEditAppointment
            
            this.btnEditAppointment.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnEditAppointment.Location = new System.Drawing.Point(1178, 547);
            this.btnEditAppointment.Name = "btnEditAppointment";
            this.btnEditAppointment.Size = new System.Drawing.Size(150, 30);
            this.btnEditAppointment.TabIndex = 2;
            this.btnEditAppointment.Text = "Randevuyu Düzenle";
            this.btnEditAppointment.UseVisualStyleBackColor = false;
            this.btnEditAppointment.Click += new System.EventHandler(this.btnEditAppointment_Click);
            
            // btnBack
            
            this.btnBack.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnBack.Location = new System.Drawing.Point(1372, 547);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 30);
            this.btnBack.TabIndex = 19;
            this.btnBack.Text = "Geri";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            
            // AppointmentListingForm
           
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1532, 603);
            this.Controls.Add(this.btnEditAppointment);
            this.Controls.Add(this.btnDeleteAppointment);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dataGridViewAppointments);
            this.Name = "AppointmentListingForm";
            this.Text = "Randevu Listeleme Sayfası";
            this.Load += new System.EventHandler(this.AppointmentListingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAppointments)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.DataGridView dataGridViewAppointments;
        private System.Windows.Forms.Button btnDeleteAppointment;
        private System.Windows.Forms.Button btnEditAppointment;
        private System.Windows.Forms.Button btnBack;
    }
}
