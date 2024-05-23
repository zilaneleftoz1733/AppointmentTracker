using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppointmentTracker.Models
{
    public class IslemTanimlari
    {
        public int id { get; set; }
        public DateTime kayit_tarihi { get; set; }
        public string islem_adi { get; set; }
        public string aciklama { get; set; }
    }
}
