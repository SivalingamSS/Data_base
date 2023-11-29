using linq_examples.modal;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace linq_examples.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        [HttpPost("Interval")]
        public IActionResult Index()
        {
            List<int> month = new List<int>() { 11, 22, 88, 44, 89, 56, };
            List<int> month1 = new List<int>() { 11, 63, 88, 74, 89, 78, };
            List<int> month2 = new List<int>();
            var result = month.Union(month1);
            foreach (var item in result)
            {
                month2.Add(item);
            }
            return Ok(month2);
        }
        [HttpGet("union all")]
        public IActionResult Action()
        {
            List<int> month = new List<int>() { 11, 22, 88, 44, 89, 56, };
            List<int> month1 = new List<int>() { 11, 63, 88, 74, 89, 78, };
            List<int> month2 = new List<int>();
            var result = month.Concat(month1);
            foreach (var item in result)
            {
                month2.Add(item);
            }
            return Ok(month2);
        }
        [HttpGet("intersect")]
        public IActionResult Result()
        {
            List<int> month = new List<int>() { 11, 22, 88, 44, 89, 56, };
            List<int> month1 = new List<int>() { 11, 63, 88, 74, 89, 78, };
            List<int> month2 = new List<int>();
            var result = month.Intersect(month1);
            foreach (var item in result)
            {
                month2.Add(item);
            }
            return Ok(month2);
        }
        [HttpGet("jions")]
        public IActionResult result1()
        {
            List<student> Students = new List<student>
            {
                new student { Id = 1, Name = "Sam",deptId = 1 },
                new student { Id = 2, Name = "Jhon",deptId =2  },
                new student { Id = 3, Name = "Kevin",deptId = 1 },
                new student { Id = 4, Name = "Bob" }
            };
            List<int> month3 = new List<int>();
            List<Department> departments = new List<Department>
            {
                new Department {deptId = 1, role = "Content Writing" },
                new Department { deptId = 2, role = "Marketing" },
                new Department { deptId = 3, role = "Engineering" }
            };

            var resultquery = from student in Students
                              join Department in departments
                              on student.deptId equals Department.deptId
                              select new
                              {
                                  Id = student.Id,
                                  deptId = Department.deptId,
                              };
            foreach (var item in resultquery)
            {
                 month3.Add(item.deptId);
            }

            return Ok();
        }

    }
}