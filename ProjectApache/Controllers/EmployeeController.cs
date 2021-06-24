using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProjectApache.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectApache.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeeController : ControllerBase
    {

        private readonly ILogger<EmployeeController> _logger;

        public EmployeeController(ILogger<EmployeeController> logger)
        {
            _logger = logger;
        }


        [HttpGet]
        public IEnumerable<Employee> GetAll()
        {
            var empList = new List<Employee>();

            for (int i = 0; i < 20; i++)
            {
                var obj = new Employee();

                obj.Id = i;
                obj.EmpCode = "EMP-" + i;
                obj.FullName = "MR. Employee" + " " + i;
                empList.Add(obj);
            }
            return empList;
        }




    }
}
