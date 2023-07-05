using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Data.Layer.Concrete
{
    public class Patient : IPatientDal
    {
        public void Delete(Entity.Layer.Patient patient)
        {
            throw new NotImplementedException();
        }

        public Entity.Layer.Patient Get(Expression<Func<Entity.Layer.Patient, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Insert(Entity.Layer.Patient patient)
        {
            throw new NotImplementedException();
        }

        public List<Entity.Layer.Patient> List()
        {
            throw new NotImplementedException();
        }

        public List<Entity.Layer.Patient> List(Expression<Func<Entity.Layer.Patient, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Update(Entity.Layer.Patient patient)
        {
            throw new NotImplementedException();
        }
    }
}
