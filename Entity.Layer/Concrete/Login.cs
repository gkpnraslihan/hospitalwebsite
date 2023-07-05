using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Layer
{
    public class Login
    {
        public int KullaniciId { get; set; }
        public int DoktorId { get; set; }
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }
    }
}
