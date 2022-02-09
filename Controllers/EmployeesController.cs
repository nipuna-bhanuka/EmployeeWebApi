using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeWebApi.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeWebApi.Controllers
{
    [Route("api/[controller]")] //class level attribute
    [ApiController]

    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeeRepository _employeeService;

        public EmployeesController(IEmployeeRepository repository)
        {
            _employeeService = repository;
        }

        [HttpGet("{id?}")] //method level attribute
        public IActionResult GetEmployees(int? id)
        {
            var MyEmps = _employeeService.AllEmployees();
            if(id is null)
            {
                return Ok(MyEmps);
            }
            MyEmps = MyEmps.Where(e => e.EmployeeID == id).ToList();
            return Ok(MyEmps);
        }



        
    }
}
