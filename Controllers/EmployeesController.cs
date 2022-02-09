using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeWebApi.Controllers
{
    [Route("api/[controller]")] //class level attribute
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        [HttpGet] //method level attribute
        public IActionResult Employees()
        {
            var emp =new string[] { "task1", "task2", "task3" };
            return Ok(emp);
        }

        [HttpPost]
        public IActionResult NewEmployees()
        {
            return Ok();
        }
    }
}
