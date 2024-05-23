using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppointmentTracker.Models
{
    public class HastaTanimlari
    {
        public int id { get; set; }
        public DateTime kayit_tarihi { get; set; }
        public string adi { get; set; }
        public string soyadi { get; set; }
        public string telefonu { get; set; }
        public string tck_no { get; set; }
        public string adresi { get; set; }
        public string email { get; set; }
        public DateTime? dogum_tarihi { get; set; }
        public string kan_grubu { get; set; }
        public string referans { get; set; }
        public string aciklama { get; set; }
    }
}
