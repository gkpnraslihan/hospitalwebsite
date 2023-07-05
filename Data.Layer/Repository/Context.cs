using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Entity.Layer;

namespace Data.Layer.Repository
{
    public class Context : DbContext
    {
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Appoinment> Appoinments { get; set; }
        public DbSet<Brans> Brans { get; set; }
        public DbSet<Doctor> Abouts { get; set; }
        public DbSet<Login> Login { get; set; }
        public DbSet<PatientLogin> PatientLogins { get; set; }

    }
}
