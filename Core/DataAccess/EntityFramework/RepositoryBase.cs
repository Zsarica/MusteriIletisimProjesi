using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess.EntityFramework
{
    public class RepositoryBase<TEntity> : IRepository<TEntity>
         where TEntity : class, new()
    {
        DbContext _db;
        public RepositoryBase(DbContext db)
        {
            _db = db;
        }
        public void Add(TEntity entity)
        {
            _db.Set<TEntity>().Add(entity);
        }

        public void Delete(TEntity entity)
        {
            _db.Entry(entity).State = EntityState.Deleted;
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            if (filter != null)
            {
                return _db.Set<TEntity>().Where(filter).SingleOrDefault();
            }
            throw new Exception("filter parametresi null gönderilemez.");
        }

        public List<TEntity> GetList(Expression<Func<TEntity, bool>> filter = null)
        {
            return filter != null ? _db.Set<TEntity>().Where(filter).ToList()
               : _db.Set<TEntity>().ToList();
        }

        public IQueryable<TEntity> GetQuery(Expression<Func<TEntity, bool>> filter = null)
        {
            return filter != null ? _db.Set<TEntity>().Where(filter).Select(t => t) : _db.Set<TEntity>().Select(t => t);
        }

        public void Update(TEntity entity)
        {
            _db.Entry(entity).State = EntityState.Modified;
        }
    }
}
