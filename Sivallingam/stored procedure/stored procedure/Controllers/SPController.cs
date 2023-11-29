using BUSINESSLAYER.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using SPStore_DTO.viewmodal;

namespace stored_procedure.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SPController : ControllerBase
    {
        private readonly IBusinessInterface _businessInterface;
        public SPController(IBusinessInterface businessInterface)
        {
            _businessInterface = businessInterface;
        }
        [HttpPost("SPPost")]
        public Task<object> POST(ViewModal details)
        {
            var SAN = _businessInterface.POST(details);

            return SAN;
        }
        [HttpPut("SPPut")]
        public Task<object> Update(ViewModal Update_details)
        {
            var SAN = _businessInterface.Update(Update_details);

            return SAN;

        }
        [HttpGet("SPGet")]
        public Task<object> GET()
        {
            var SAN = _businessInterface.GET();
            return SAN;
        }
        [HttpDelete("SPDelete")]
        public Task<int> Delete( int KAPILAN_ID)
        {
            var san = _businessInterface.Delete(KAPILAN_ID);
            return san;
        }
    }
}
