using LONGINPASSWORD.DBcontext;
using LONGINPASSWORD.Modal;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Microsoft.Win32;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;

namespace LONGINPASSWORD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly DbContact _DbContact;

        public IConfiguration _Configuration;
        public HomeController(DbContact Dbcontact, IConfiguration configuration)
        {
            _DbContact = Dbcontact;
            _Configuration = configuration;
        }
        [HttpPost]
        public string Register(student user)
        {
            student db = new student();
            if (db.user_Id == 0)
            {
                db.User_name = user.User_name;
                db.Password = Encrypt(user.Password);
                db.Email = user.Email;
                db.Ph_number = user.Ph_number;
                db.Department = user.Department;
                _DbContact.Logins2.Add(db);
                _DbContact.SaveChanges();
            }
            return user.User_name;
        }

        public static string Encrypt(string Password)
        {
            string EncryptionKey = "djknh46hdkkjsdvvjjsijeykskerfubb1906234575";
            byte[] clearBytes = Encoding.Unicode.GetBytes(Password);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] {
            0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76});
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(),
                    CryptoStreamMode.Write))
                    {
                        cs.Write(clearBytes, 0, clearBytes.Length);
                        cs.Close();
                    }
                    Password = Convert.ToBase64String(ms.ToArray());
                }
            }
            return Password;
        }
        [Route("Login")]
        [HttpPost]
        public IActionResult Post(UserLogin userData)
        {
            if (userData != null)
            {
                var claims = new[]
                {
                        new Claim  (JwtRegisteredClaimNames.Sub,_Configuration["Jwt:Subject"]),
                        new Claim  (JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                        new Claim  (JwtRegisteredClaimNames.Iat, DateTime.UtcNow.ToString()),
                        new Claim  ("User_name", userData.User_name),
                        new Claim  ("password", userData.Password)
                };
                var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_Configuration["Jwt:Key"]));
                var signIn = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
                var token = new JwtSecurityToken(
                    _Configuration["Jwt:Issuer"],
                    _Configuration["Jwt:Audience"],
                    claims,
                    expires: DateTime.UtcNow.AddSeconds(40),
                    signingCredentials: signIn);
                return Ok(new JwtSecurityTokenHandler().WriteToken(token));
            }
            else
            {
                return Ok();
            }
        }
        private ActionResult<UserLogin> User(string User_name, string Password)
        {
            var data = _DbContact.Logins2.Where(x => x.User_name == User_name &&
            x.Password == Encrypt(Password)).FirstOrDefault();
            return null;
        }
    }
    
}
