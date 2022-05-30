using System;
using System.Collections.Generic;
using System.Linq;
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

        //public Task<T> GetById(int id)
        //{
        //    throw new NotImplementedException();
        //}

        //public Task<IQueryable<T>> GetAll()
        //{
        //    throw new NotImplementedException();
        //}

        //public Task Add(T item)
        //{
        //    throw new NotImplementedException();
        //}

    }
}
