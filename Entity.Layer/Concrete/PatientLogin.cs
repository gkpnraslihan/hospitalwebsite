using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Layer
{
    public class PatientLogin
    {
        public int KimlikId { get; set; }
        public int HastaId { get; set; }
        public string TCKimlikNumarasi { get; set; }
        public string Sifre { get; set; }


        public ICollection<Patient> Patients { get; set; }
    }
}
