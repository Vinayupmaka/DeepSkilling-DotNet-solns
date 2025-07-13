using Microsoft.AspNetCore.Mvc;
using MyFirstWebAPI.Models;
using System.Collections.Generic;
using System.Linq;

namespace MyFirstWebAPI.Controllers
{
    [ApiController]
    [Route("api/emp")]
    public class EmployeeController : ControllerBase
    {
        private static List<Employee> _employees = new List<Employee>
        {
            new Employee { Id = 1, Name = "Swetha", Salary = 40000 },
            new Employee { Id = 2, Name = "Bavya", Salary = 45000 },
            new Employee { Id = 3, Name = "Sesha", Salary = 50000 }
        };
        [HttpPut("{id}")]
        public ActionResult<Employee> UpdateEmployee(int id, [FromBody] Employee updatedEmp)
        {
            if (id <= 0)
            {
                return BadRequest("Invalid employee id");
            }
            var existingEmp = _employees.FirstOrDefault(e => e.Id == id);
            if (existingEmp == null)
            {
                return BadRequest("Invalid employee id");
            }
            existingEmp.Name = updatedEmp.Name;
            existingEmp.Salary = updatedEmp.Salary;
            return Ok(existingEmp);
        }
    }
}
