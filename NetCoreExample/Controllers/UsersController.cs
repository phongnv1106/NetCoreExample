using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using NetCoreExample.Models;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace NetCoreExample.Controllers
{
    public class UsersController : Controller
    {
        private IConfiguration _config;
        public UsersController(IConfiguration config)
        {
            _config = config;
        }
        public IActionResult SignIn()
        {
            if (User.Identity.IsAuthenticated)
            {
                return Redirect("/Admin");
            }
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> SignIn(string UserName, string Password)
        {
            if (UserName.Equals("admin@gmail.com") && Password.Equals("123456"))
            {

                IActionResult response = Unauthorized();
                UserModel userModel = new UserModel(UserName, Password, UserName);
                var user = AuthenticateUser(userModel);

                if (user != null)
                {
                    var tokenString = GenerateJSONWebToken(user);
                    response = Ok(new { token = tokenString });
                }

                return response;
            }



            return View();
        }
        private string GenerateJSONWebToken(UserModel userInfo)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var claims = new[] {
                new Claim(JwtRegisteredClaimNames.Sub, userInfo.UserName),
                new Claim(JwtRegisteredClaimNames.Email, userInfo.Email),
                //new Claim("DateOfJoing", userInfo.DateOfJoing.ToString("yyyy-MM-dd")),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
            };

            var token = new JwtSecurityToken(_config["Jwt:Issuer"],
              _config["Jwt:Issuer"],
              claims,
              expires: DateTime.Now.AddMinutes(120),
              signingCredentials: credentials);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        private UserModel AuthenticateUser(UserModel login)
        {
            UserModel user = null;

            //Validate the User Credentials    
            //Demo Purpose, I have Passed HardCoded User Information    
            if (login.UserName == "admin@gmail.com")
            {
                user = new UserModel ("Adminstrator", null, "admin@gmail.com");
            }
            return user;
        }
    }
}
