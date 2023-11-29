using Microsoft.AspNetCore.Mvc;
namespace union_unionall_insert_jions_linq.Controllers
{
    [ApiController]
    [Route("[Controllers]")]
    public class HomeController : Controller
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
    }
}
