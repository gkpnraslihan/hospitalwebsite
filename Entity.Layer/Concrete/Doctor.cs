using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Layer
{
    public class Doctor
    {
        public int DoktorId { get; set; }
        public string DoktorAd { get; set; }
        public string DoktorSoyad { get; set; }
        public string DoktorBrans { get; set; }
        public int DoktorTC { get; set; }
        public string DoktorSifre { get; set; }
        public byte SilindiMi { get; set; }
        public DateTime EklenmeTarihi { get; set; }
    }
}
