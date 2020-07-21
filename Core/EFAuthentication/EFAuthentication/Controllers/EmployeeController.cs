using Microsoft.AspNetCore.Mvc;
using Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFAuthentication.Controllers
{
    public class EmployeeController: Controller
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            this._employeeService = employeeService;
        }

        public IActionResult GetEmployees()
        {
            return View("ListEmployee", _employeeService.GetAll());
        }
    }
}
