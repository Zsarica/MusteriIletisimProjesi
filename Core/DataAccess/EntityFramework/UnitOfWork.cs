using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess.EntityFramework
{
    public class UnitOfWork : IUnitOfWork
    {
        DbContext _context;
        public UnitOfWork(DbContext context)
        {
            _context = context;
        }
        public IRepository<T> GetRepository<T>() where T : class, new()
        {
            return new RepositoryBase<T>(_context);
        }

        public int Save()
        {
            DbContextTransaction tran = _context.Database.BeginTransaction(System.Data.IsolationLevel.ReadUncommitted);
            int ess = 0;
            try
            {
                ess = _context.SaveChanges();
                tran.Commit();
            }
            catch (Exception ex)
            {
                tran.Rollback();
            }
            return ess;
        }
    }
}
