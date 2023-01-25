using Hamburgerci.DAL.EF.Abstract;
using Hamburgerci.Entities.Abstract;
using Hamburgerci.Entities.Concrete;
using Hamburgerci.Entities.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Hamburgerci.DAL.EF.Concrete
{
    public class RepositoryBase<T> : IRepositoryBase<T> 
        where T : BaseEntity,new()
    {
        protected  readonly SqlDbcontext dbcontext;

        public RepositoryBase()
        {
            this.dbcontext = new SqlDbcontext();
        }


        public virtual int Add(T input)
        {
            dbcontext.Set<T>().Add(input);
            
            return dbcontext.SaveChanges();
        }

        public virtual int Delete(T input)
        {
            dbcontext.Set<T>().Remove(input);

            return dbcontext.SaveChanges();
        }
        //TODO: Pazartesi yapilacak
        public virtual T Find(string name)
        {
            return dbcontext.Set<T>().Find(name);
            
        }

        public T Find(Expression<Func<T, bool>> filter = null)
        {

            var sorgu = dbcontext.Set<T>();

            if (filter != null)
                sorgu.Where(filter);

            return sorgu.FirstOrDefault();
        }

        public virtual IList<T> FindAll()
        {
            return dbcontext.Set<T>().ToList();
        }

        public IList<T> FindAll(Expression<Func<T, bool>> filter = null)
        {
            var sorgu = dbcontext.Set<T>();

            if (filter != null)
                sorgu.Where(filter);

            return sorgu.ToList();

        }

        public virtual T FindById(int id)
        {
            return dbcontext.Set<T>().Find(id);
        }

        public virtual int Update(T input)
        {
            dbcontext.Set<T>().Update(input);

            return dbcontext.SaveChanges();
        }
    }
}
