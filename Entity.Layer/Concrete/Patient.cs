using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Layer
{
    public class Patient
    {
        public int HastaId { get; set; }
        public string HastaAd { get; set;}
        public string HastaSoyad { get; set; }
        public string HastaTC { get; set; }
        public int HastaTelefon { get; set; }
        public string HastaSifre { get; set; }
        public string HastaCinsiyet { get; set; }
        public bool SilindiMi { get; set; }
        public DateTime EklenmeTarihi { get; set; }

        public virtual Patient Patients { get; set; }

    }
}
