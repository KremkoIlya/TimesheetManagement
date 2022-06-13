using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using TimesheetManagement.Contracts.General;
using TimesheetManagement.Data.Contexts;

namespace TimesheetManagement.Services.General
{
    public class BaseService<T> : IBaseService<T> where T: class
    {
        protected TimesheetManagementContext _context;

        public BaseService(TimesheetManagementContext context)
        {
            _context = context;
        }

        public IQueryable<T> GetAll()
        {
            return _context.Set<T>();
        }

        public IQueryable<T> GetBy(Expression<Func<T, bool>> expression)
        {
            return _context.Set<T>().Where(expression);
        }

        public void Create(T entity)
        {
            _context.Set<T>().Add(entity);
        }

        public void Update(T entity)
        {
            _context.Set<T>().Update(entity);
        }

        public void Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
        }

        public Task<int> SaveChangesAsync()
        {
            return _context.SaveChangesAsync();
        }
    }
}
