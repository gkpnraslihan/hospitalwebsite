using Data.Layer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Data.Layer.Concrete
{
    public class Brans : IBransDal
    {
        public void Delete(Entity.Layer.Brans brans)
        {
            throw new NotImplementedException();
        }

        public Entity.Layer.Brans Get(Expression<Func<Entity.Layer.Brans, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Insert(Entity.Layer.Brans brans)
        {
            throw new NotImplementedException();
        }

        public List<Entity.Layer.Brans> List()
        {
            throw new NotImplementedException();
        }

        public List<Entity.Layer.Brans> List(Expression<Func<Entity.Layer.Brans, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Update(Entity.Layer.Brans brans)
        {
            throw new NotImplementedException();
        }
    }
}
