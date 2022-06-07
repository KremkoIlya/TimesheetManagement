using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using TimesheetManagement.Contracts.General;

namespace TimesheetManagement.Services.General
{
    public class BaseService<T> : IBaseService<T> where T: class
    {
        public BaseService()
        { }

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
