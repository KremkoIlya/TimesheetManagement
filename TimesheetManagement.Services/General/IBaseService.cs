using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TimesheetManagement.Services.DbContext;

namespace TimesheetManagement.Services.General
{
    public interface IBaseService<T> where T: class
    {
        ITimesheetManagementContext Context { get; set; }

        IQueryable<T> GetAll();
        IQueryable<T> GetBy(Expression<Func<T, bool>> expression, bool trackChanges);
        Task Create(T entity);
        Task Update(T entity);
        Task Delete(T entity);
    }
}
