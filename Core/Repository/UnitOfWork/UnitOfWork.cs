using Entities.Context;
using Entities.EFModel;
using Repository.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        #region Private Methods

        EmployeeDBContext _context;

        private GenericRepository<Employee> _employeeRepository;
        private GenericRepository<Department> _departmentRepository;

        #endregion

        public UnitOfWork(EmployeeDBContext context)
        {
            _context = context;
        }

        public GenericRepository<Employee> EmployeeRepository => _employeeRepository ?? (_employeeRepository = new GenericRepository<Employee>(_context));

        public GenericRepository<Department> DepartmentRepository => _departmentRepository ?? (_departmentRepository = new GenericRepository<Department>(_context));
    }
}
