using Data.Layer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;


namespace Data.Layer.Concrete
{
    public class Doctor : IDoctorDal
    {
        public void Delete(Entity.Layer.Doctor doctor)
        {
            throw new NotImplementedException();
        }

        public Entity.Layer.Patient Get(Expression<Func<Entity.Layer.Doctor, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Insert(Entity.Layer.Doctor doctor)
        {
            throw new NotImplementedException();
        }

        public List<Entity.Layer.Doctor> List()
        {
            throw new NotImplementedException();
        }

        public List<Entity.Layer.Doctor> List(Expression<Func<Entity.Layer.Doctor, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Update(Entity.Layer.Doctor doctor)
        {
            throw new NotImplementedException();
        }
    }
}
