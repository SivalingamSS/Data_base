using Datetime_overlapmethod.Dbcontact;
using Datetime_overlapmethod.model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
namespace Datetime_overlapmethod.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class overlapping : Controller
    {
        private readonly Dbcontext _Dbcontext;
        public overlapping(Dbcontext dbcontext)
        {
            _Dbcontext = dbcontext;
        }
        //  [HttpPost("overlap")]
        /* public object overlap(MODEL MODE)
         {
             var obj = new MODEL()
             {
                 DATE_ID = MODE.DATE_ID,
                 StartDate = MODE.StartDate,
                 EndDate = MODE.EndDate,
             };
             _Dbcontext.SIVA_DATETIME.Add(obj);
             _Dbcontext.SaveChanges();
             return obj;
         }
         [HttpGet("get")]
         public async Task<IActionResult> Getfactory()
         {
             var str = await _Dbcontext.SIVA_DATETIME.ToListAsync();

             return Ok(str);
         }*/
      
        [HttpPost("post")]
        public object ovelap(MODEL MODE)
        {
            var str = _Dbcontext.SIV_DATETIME.ToList();
            bool overlaps = false;
            foreach (var item in str)
            {
                if ((MODE.StartDate <= item.EndDate)&&( MODE.EndDate >= item.StartDate))
                {
                    overlaps = true;
                    break;
                }
            }
            if (!overlaps)
            {
                _Dbcontext.SIV_DATETIME.Add(MODE);
                _Dbcontext.SaveChanges();
            }
           
            return null;
        }
    }

    
}

