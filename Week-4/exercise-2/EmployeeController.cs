using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace MyFirstWebAPI.Controllers
{
    [ApiController]
    [Route("api/emp")]
    public class EmployeeController : ControllerBase
    {
        private static List<Employee> employees = new List<Employee>
        {
            new Employee { Id = 1, Name = "raghupati", Department = "IT" },
            new Employee { Id = 2, Name = "raghava", Department = "HR" },
            new Employee { Id = 3, Name = "rajaram", Department = "Finance" }
        };

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(employees);
        }
    }

    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
    }
}
