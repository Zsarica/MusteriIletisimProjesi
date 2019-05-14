using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess
{
    public interface IRepository<T>
         where T : class, new()
    {
        void Add(T entity);
        void Update(T entity);
        T Get(Expression<Func<T, bool>> filter);
        List<T> GetList(Expression<Func<T, bool>> filter = null);
        IQueryable<T> GetQuery(Expression<Func<T, bool>> filter = null);
        void Delete(T entity);
    }
}
