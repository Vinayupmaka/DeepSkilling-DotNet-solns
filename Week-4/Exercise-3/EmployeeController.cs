using Microsoft.AspNetCore.Mvc;
using MyFirstWebAPI.Models;
using MyFirstWebAPI.Filters;
namespace MyFirstWebAPI.Controllers
{
    [CustomAuthFilter]
    [ApiController]
    [Route("api/emp")]
    public class EmployeeController : ControllerBase
    {
        private static List<Employee> _employees;

        public EmployeeController()
        {
            _employees = GetStandardEmployeeList();
        }

        private List<Employee> GetStandardEmployeeList()
        {
            return new List<Employee>
            {
                new Employee
                {
                    Id = 1,
                    Name = "Suresh",
                    Salary = 60000,
                    Permanent = true,
                    DateOfBirth = new DateTime(1990, 5, 1),
                    department = new department { Id = 101, Name = "IT" },
                    Skills = new List<skill>
                    {
                        new skill { Id = 1, Name = "C#" },
                        new skill { Id = 2, Name = "SQL" }
                    }
                },
                new Employee
                {
                    Id = 2,
                    Name = "Ramesh",
                    Salary = 50000,
                    Permanent = false,
                    DateOfBirth = new DateTime(1995, 8, 10),
                    department = new department { Id = 102, Name = "HR" },
                    Skills = new List<skill>
                    {
                        new skill { Id = 3, Name = "Communication" }
                    }
                }
            };
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            throw new Exception("This is a test exception for filter demo.");
        }


        [HttpPost]
        public ActionResult AddEmployee([FromBody] Employee emp)
        {
            _employees.Add(emp);
            return CreatedAtAction(nameof(GetAll), emp);
        }

        [HttpPut("{id}")]
        public ActionResult UpdateEmployee(int id, [FromBody] Employee updatedEmp)
        {
            var emp = _employees.FirstOrDefault(e => e.Id == id);
            if (emp == null) return NotFound();
            emp.Name = updatedEmp.Name;
            emp.Salary = updatedEmp.Salary;
            emp.Permanent = updatedEmp.Permanent;
            emp.department = updatedEmp.department;
            emp.Skills = updatedEmp.Skills;
            emp.DateOfBirth = updatedEmp.DateOfBirth;
            return Ok(emp);
        }

        [HttpGet("standard")]
        public ActionResult<Employee> GetStandard()
        {
            return Ok(_employees.FirstOrDefault());
        }
    }
}
