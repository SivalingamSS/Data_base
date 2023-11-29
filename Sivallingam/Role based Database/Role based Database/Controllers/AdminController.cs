using Businesslayer.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Role_Entity.Dbcontext;

namespace Role_based_Database.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private readonly IBusiness _ibusiness;
        public AdminController(IBusiness ibusiness)
        {
            _ibusiness = ibusiness;
        }
        [HttpPost]
        public Task<object> POST(Admin details)
        {
            var post = _ibusiness.POST(details);
            return post;
        }
    }
}
