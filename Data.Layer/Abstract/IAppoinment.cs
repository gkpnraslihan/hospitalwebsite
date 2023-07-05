using Entity.Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Data.Layer.Abstract
{
    public interface IAppoinment
    {
        List<Appoinment> List();
        void Insert(Appoinment appoinment);
        Appoinment Get(Expression<Func<Appoinment, bool>> filter);
        void Update(Appoinment appoinment);
        void Delete(Appoinment appoinment);
        List<Appoinment> List(Expression<Func<Appoinment, bool>> filter);
    }
}
