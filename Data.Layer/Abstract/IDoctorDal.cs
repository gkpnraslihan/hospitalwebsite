using Entity.Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Data.Layer.Abstract
{
    public interface IDoctorDal
    {
        List<Doctor> List();
        void Insert(Doctor doctor);
        Patient Get(Expression<Func<Doctor, bool>> filter);
        void Update(Doctor doctor);
        void Delete(Doctor doctor);
        List<Doctor> List(Expression<Func<Doctor, bool>> filter);
    }
}
