using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimesheetManagement.Services.DbContext;

namespace TimesheetManagement.Services.General
{
    public interface IBaseService<T> where T: class
    {
        ITimesheetManagementContext Context { get; set; }

        //Task<T> GetById(int id);

        //Task<IQueryable<T>> GetAll();

        //Task Add(T item);
    }
}
