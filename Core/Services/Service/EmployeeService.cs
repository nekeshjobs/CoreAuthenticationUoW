using Common.Model;
using Repository.UnitOfWork;
using Services.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Services.Service
{
    public class EmployeeService : IEmployeeService
    {
        private IUnitOfWork _unitOfWork;

        public EmployeeService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public List<EmployeeModel> GetAll()
        {
            return
            (from emp in _unitOfWork.EmployeeRepository.GetPredicate()
            select new EmployeeModel() {
                FirstName = emp.FirstName,
                LastName = emp.LastName,
                Salary = emp.Salary
            }).ToList();
        }
    }
}
