using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Layer
{
    public class Appoinment
    {
        public int RandevuId { get; set; }
        public int DoktorId { get; set; }
        public int HastaId { get; set; }
        public DateTime RandevuTarih { get; set; }
        public DateTime RandevuSaat { get; set; }
        public string RandevuBrans { get; set; }
        public string RandevuDoktor { get; set; }
        public byte RandevuDurum { get; set; }
        public string HastaTC { get; set; }
        public string HastaSikayet { get; set; }
        public byte SilindiMi { get; set; }
        public DateTime EklenmeTarihi { get; set; }
    }
}
