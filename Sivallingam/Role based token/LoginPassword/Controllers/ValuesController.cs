using LoginPassword.model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace LoginPassword.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ValuesController : ControllerBase
    { 
            [HttpGet]
            [Route("Admins")]
            [Authorize(Roles = "Admin")] 
            public IActionResult AdminEndPoint()
            {
                var currentUser = GetCurrentUser();
                return Ok($"Hi you are an {currentUser.Role}");
            }
            private UserModel GetCurrentUser()
            {
                var identity = HttpContext.User.Identity as ClaimsIdentity;
                if (identity != null)
                {
                    var userClaims = identity.Claims;
                    return new UserModel
                    {
                        User_name = userClaims.FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier)?.Value,
                        Role = userClaims.FirstOrDefault(x => x.Type == ClaimTypes.Role)?.Value
                    };
                }
                return null;
            }
    }
}