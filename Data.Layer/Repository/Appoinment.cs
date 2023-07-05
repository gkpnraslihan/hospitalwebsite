using Data.Layer.Abstract;
using Data.Layer.Repository;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Data.Layer.Concrete
{
    public class Appoinment : IAppoinment
    {
        Context c = new Context();
        DbSet<Appoinment> _object;
        public Appoinment()
        {
            _object = c.Set<Appoinment>();

        }
        public void Delete(Entity.Layer.Appoinment p)
        {
            var deletedEntity = c.Entry(p);
            deletedEntity.State = EntityState.Deleted;
            c.SaveChanges();
        }

        public Entity.Layer.Appoinment Get(Expression<Func<Entity.Layer.Appoinment, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Insert(Entity.Layer.Appoinment appoinment)
        {
            throw new NotImplementedException();
        }

        public List<Entity.Layer.Appoinment> List()
        {
            throw new NotImplementedException();
        }

        public List<Entity.Layer.Appoinment> List(Expression<Func<Entity.Layer.Appoinment, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Update(Entity.Layer.Appoinment appoinment)
        {
            throw new NotImplementedException();
        }
    }
}
