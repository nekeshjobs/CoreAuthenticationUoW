using Entities.EFModel;
using Repository.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.UnitOfWork
{
    public interface IUnitOfWork
    {

        GenericRepository<Employee> EmployeeRepository { get; }

        GenericRepository<Department> DepartmentRepository { get; }

    }
}
