using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppointmentTracker.Models
{
    public class RandevuTanimlari
    {
        public int id { get; set; }
        public DateTime? kayit_tarihi { get; set; }
        public DateTime? tarih { get; set; }
        public DateTime? baslangic_saati { get; set; }
        public DateTime? bitis_saati { get; set; }
        public int? doktor_id { get; set; }
        public string doktor_adi { get; set; }
        public string doktor_soyadi { get; set; }
        public int? hasta_id { get; set; }
        public string hasta_adi { get; set; }
        public string hasta_soyadi { get; set; }
        public string aciklama { get; set; }
        public bool? hasta_randevuya_geldi_mi { get; set; }
    }
}
