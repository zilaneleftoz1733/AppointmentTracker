using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppointmentTracker.Models
{
    public class DoktorTanimlari
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
        public string egitim_durumu { get; set; }
        public string mezun_oldugu_okul { get; set; }
        public string aciklama { get; set; }
    }
}
