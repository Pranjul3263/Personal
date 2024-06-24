using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using webApi.Data;
using webApi.Interface;
using webApi.Model.Entity;
using webApi.Model.models;

namespace webApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly AppDbConst appContext;
        private IEmployee _iemp;
        private readonly ILogger<EmployeesController> _logger;
     

        public EmployeesController(AppDbConst appContext, IEmployee empf, ILogger<EmployeesController> logger)
        {
            this.appContext = appContext;
            _iemp = empf;
            _logger = logger;

        }


       




        [HttpGet]
        [Route("GetAllEmployees")]
        public async Task< IActionResult> GetAllEmployees()
        {

            var allemployees = await _iemp.GetAllEmployees();
            return Ok(allemployees);
        }



        //[HttpGet]
        //[Route("{id:guid}")]
        //public IActionResult GetEmployees(Guid id)
        //{
        //    var emp= appContext.Employees.Find(id);
        //    if (emp == null)
        //    {
        //        return NotFound();
        //    }
        //    return Ok(emp);

        //}

        //[HttpPost]
        //public IActionResult AddEmployees(addEmployeesmod emp)
        //{
        //    var empentity = new Employee()
        //    {
        //        Email = emp.Email,
        //        Name = emp.Name,
        //        Phone = emp.Phone,
        //        Salary = emp.Salary,
        //    };

        //    appContext.Employees.Add(empentity);
        //    appContext.SaveChanges();
        //    return Ok(empentity);
        //}

        //[HttpPut]
        //[Route("{id:guid}")]
        //public IActionResult UpdateEmployees(Guid id, UpdateEmploymod upmod)
        //{
        //    var Employee = appContext.Employees.Find(id);
        //    if (Employee == null)
        //    {
        //        return NotFound();
        //    }
        //    Employee.Name = upmod.Name;
        //    Employee.Email = upmod.Email;
        //    Employee.Phone = upmod.Phone;
        //    Employee.Salary = upmod.Salary;
        //    appContext.SaveChanges();
        //    return Ok(Employee);
        //}
        //[HttpDelete]
        //[Route("{id:guid}")]
        //public IActionResult DeleteEmployees(Guid id)
        //{
        //    var emp = appContext.Employees.Find(id);
        //    if (emp == null)
        //    {
        //        return NotFound();
        //    }
        //    appContext.Employees.Remove(emp);
        //    appContext.SaveChanges();
        //    return Ok(emp);

        //}
    }
}
