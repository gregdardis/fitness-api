using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace FitnessAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        [Route("get-token")]
        [HttpGet]
        public IActionResult GetToken()
        {
            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Sub, "jeremy@jeremylikness.com"),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
            };

            var key = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes(
                Environment.GetEnvironmentVariable("SECRET")));

            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken("http://localhost:1029", // issued by
                "http://localhost:1029", // issued for
                claims, // payload
                expires: DateTime.Now.AddMinutes(30), // valid for 1/2 hour
                signingCredentials: creds); // signature

            var tokenEncoded = new JwtSecurityTokenHandler().WriteToken(token);

            return new OkObjectResult(new { token = tokenEncoded });
        }
    }
}