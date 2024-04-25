using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using RepositoryPattern.Models;
using System.IdentityModel.Tokens.Jwt;
using System.Text;

namespace RepositoryPattern.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        [HttpPost]
        public IActionResult Login(LoginModel model)
        {
            if (model.Username == "Admin" && model.Password == "Admin")
            {
                var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("MySuperSecureMySuperSecureMySuperSecureMySuperSecureMySuperSecureMySuperSecureMySuperSecure"));
                var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
                var Sectoken = new JwtSecurityToken("company.com", "company.com",
              null,
              expires: DateTime.Now.AddMinutes(120),
              signingCredentials: credentials);
              var token = new JwtSecurityTokenHandler().WriteToken(Sectoken);
              return Ok(token);
            }
            return Unauthorized();
        }
    }
}
