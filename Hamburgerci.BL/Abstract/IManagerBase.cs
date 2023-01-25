using Hamburgerci.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Hamburgerci.BL.Abstract
{
    public interface IManagerBase<T> where T : BaseEntity
    {
        T FindById(int id);
        T Find(string name);
        T Find(Expression<Func<T, bool>> filter = null);
        
        IList<T> FindAll(Expression<Func<T, bool>> filter = null);
        int Add(T input);
        int Update(T input);
        int Delete(T input);
    }
}
