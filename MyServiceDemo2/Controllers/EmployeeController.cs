using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyServiceDemo2.Models;

namespace MyServiceDemo2.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class EmployeeController : ControllerBase
    {
       private List<Employee> employees; 
       public EmployeeController()
       {
           employees = new List<Employee>();
           employees.Add(new Employee(){EmpNo=1,EmpName="A",Salary=13000});
           employees.Add(new Employee(){EmpNo=2,EmpName="B",Salary=23000});
           employees.Add(new Employee(){EmpNo=3,EmpName="C",Salary=33000});
            
       }    

       [HttpGet]
       public IActionResult Get()
       {
            return Ok(employees);
       }
       
    }
}
