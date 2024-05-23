using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppointmentTracker.Models
{
    public class RandevuIslemleri
    {
        public int id { get; set; }
        public DateTime? kayit_tarihi { get; set; }
        public int? randevu_id { get; set; }
        public int? islem_id { get; set; }
    }
}
