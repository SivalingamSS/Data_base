using Business.two.tables.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TWO_TABLE_DTO.VIEWMODEL;

namespace TWO_MERGE_DATABASE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TavlesController : ControllerBase
    {
        private readonly Ibusinesslayertable _ibusinesslayertable;
        public TavlesController(Ibusinesslayertable ibusinesslayertable)
        {
            _ibusinesslayertable = ibusinesslayertable;
        }
        [HttpPost("PostValue")]
        public ActionResult POST(VIEWDETAILS details)
        {
            var end = _ibusinesslayertable.POST(details);
            return Ok(end);
        }
        [HttpGet("GET")]
        public ActionResult GET()
        {
            var end = _ibusinesslayertable.GET();
            return Ok(end);
        }
        [HttpPut("PUT")]
        public ActionResult PUT(VIEWDETAILS details)
        {
            var end = _ibusinesslayertable.PUT(details);
            return Ok(end);
        }
        [HttpDelete("DELETE")]
        public ActionResult DELETE(VIEWDETAILS details)
        {
            var end = _ibusinesslayertable.DELETE(details);
            return Ok(end);
        }
    }
}
