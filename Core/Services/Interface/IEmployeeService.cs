using Common.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Interface
{
    public interface IEmployeeService
    {
        List<EmployeeModel> GetAll();
    }
}
