using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using LoginPassword.model;
using System.Collections.Generic;
using LoginPassword.Dbcontact;
using System.Security.Cryptography;
using System.Text;
using LoginPassword;
using Azure;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.AspNetCore.Authentication;
using System.Security.Claims;
using LinqToTwitter;
using Microsoft.AspNetCore.Authorization;

namespace UserRegistration_Demo
{
    [ApiController]
    [Route("api/[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly Dbcontact1 _DbContact;
       
        public  IConfiguration _Configuration;
        public WeatherForecastController(Dbcontact1 Dbcontact, IConfiguration configuration)
        {
            _DbContact = Dbcontact;
            _Configuration = configuration;
        }
        [HttpPost]
        public ActionResult Login(UserLogin userLogin)
        {
            var user = Authenticate(userLogin);
            if (user != null)
            {
                var token = GenerateToken(user);
                return Ok(token);
            }

            return NotFound("user not found");
        }
        private string GenerateToken(UserModel user)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_Configuration["Jwt:Key"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);
            var claims = new[]
            {
                new Claim(ClaimTypes.NameIdentifier,user.User_name),
                new Claim(ClaimTypes.Role,user.Role)
            };
            var token = new JwtSecurityToken(_Configuration["Jwt:Issuer"],
                _Configuration["Jwt:Audience"],
                claims,
                expires: DateTime.Now.AddMinutes(15),
                signingCredentials: credentials);


            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        private UserModel Authenticate(UserLogin userLogin)
        {
            var currentUser = UserConstants.Users.FirstOrDefault(x => x.User_name ==
                userLogin.User_name && x.Password == userLogin.Password);
            if (currentUser != null)
            {
                return currentUser;
            }
            return null;
        }
      
    }
}
