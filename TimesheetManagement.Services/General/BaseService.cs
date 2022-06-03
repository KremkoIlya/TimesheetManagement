using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TimesheetManagement.Services.DbContext;

namespace TimesheetManagement.Services.General
{
    public class BaseService<T> : IBaseService<T> where T: class
    {
        public ITimesheetManagementContext Context { get ; set; }

        public BaseService(ITimesheetManagementContext context)
        {
            Context = context;
        }

        public IQueryable<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> GetBy(Expression<Func<T, bool>> expression, bool trackChanges)
        {
            throw new NotImplementedException();
        }

        public Task Create(T entity)
        {
            throw new NotImplementedException();
        }

        public Task Update(T entity)
        {
            throw new NotImplementedException();
        }

        public Task Delete(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
