using JWT_Token_WebApi.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Text;

namespace JWT_Token_WebApi.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class LoginController : ControllerBase
    {
        private readonly IConfiguration _config;

        public LoginController(IConfiguration configuration)
        {
            _config = configuration;
        }

        private UserModel AuthenticateUser(UserModel model)
        {
            UserModel user = null;
            if (model.UserName == "admin" && model.Password == "12345")
            {
                user = new UserModel { UserName = "devanshu" };
            }
            return user;
        }

        private string GenerateToken(UserModel user)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(_config["Jwt:Issuer"], _config["Jwt:Audience"],
                expires: DateTime.Now.AddMinutes(Convert.ToInt32(_config["Jwt:ExpiryInMinutes"])),
                signingCredentials: credentials);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        [AllowAnonymous]
        [HttpPost]
        public IActionResult Login([FromBody]UserModel model)
        {
            IActionResult response = Unauthorized();
            var user = AuthenticateUser(model);
            if (user != null)
            {
                var token = GenerateToken(user);
                response = Ok(new { token });
            }
            return response;
        }
    }
}
