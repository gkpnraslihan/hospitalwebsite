using Entity.Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Data.Layer.Abstract
{
    public interface IBransDal
    {
        List<Brans> List();
        void Insert(Brans brans);
        Brans Get(Expression<Func<Brans, bool>> filter);
        void Update(Brans brans);
        void Delete(Brans brans);
        List<Brans> List(Expression<Func<Brans, bool>> filter);
    }
}
