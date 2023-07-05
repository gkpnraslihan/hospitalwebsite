using Entity.Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Data.Layer
{
    public interface IPatientDal
    {

        List<Patient> List();
        void Insert(Patient patient);
        Patient Get(Expression<Func<Patient, bool>> filter);
        void Update(Patient patient);
        void Delete(Patient patient);
        List<Patient> List(Expression<Func<Patient, bool>> filter);

    }
}
