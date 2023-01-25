using Hamburgerci.BL.Abstract;
using Hamburgerci.DAL.EF.Abstract;
using Hamburgerci.DAL.EF.Concrete;
using Hamburgerci.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Hamburgerci.BL.Concrete
{
    public class ManagerBase<T> : IManagerBase<T>
        where T : BaseEntity,new()
    {

        readonly protected RepositoryBase<T> repositoryBase;
        internal object dbcontext;

        public ManagerBase()
        {
            this.repositoryBase = new RepositoryBase<T>();
        }
        public virtual int Add(T input)
        {
            return repositoryBase.Add(input);
        }

        public virtual int Delete(T input)
        {
            return repositoryBase.Delete(input);
        }

        public virtual T Find(string name)
        {
            return repositoryBase.Find(name);
        }

        public T Find(Expression<Func<T, bool>> filter = null)
        {
            return repositoryBase.Find(filter);
        }

        

        public virtual IList<T> FindAll(Expression<Func<T, bool>> filter = null)
        {
            return repositoryBase.FindAll(filter);
        }

        

        public virtual T FindById(int id)
        {
           return repositoryBase.FindById(id);
        }

        public virtual int Update(T input)
        {
            return repositoryBase.Update(input);
        }
    }
}
