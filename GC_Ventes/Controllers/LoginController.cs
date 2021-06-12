using GC_Ventes.Models;
using GC_Ventes.Models.VueModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;

namespace GC_Ventes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly WEB_GC_Context _context;
        private IConfiguration _config;

        public LoginController(WEB_GC_Context context, IConfiguration config)
        {
            _context = context;
            _config = config;
        }

        // login
        [HttpPost]
        public IActionResult Login(LoginCreds creds)
        {
            IActionResult response;

            MdiUtilisateur currentUser = Authenticate(creds);

            if (currentUser != null)
            {
                var tokenString = GenerateJWT(currentUser);
                response = Ok(new { token = tokenString, currentUser });
            }
            else response = Unauthorized("Username or password incorrect !!!");

            return response;
        }

        // authentication
        private MdiUtilisateur Authenticate(LoginCreds creds)
        {
            MdiUtilisateur signedUser = _context.MdiUtilisateurs.FirstOrDefault(u =>
                u.Pseudo == creds.username
                && u.Pass == creds.password
            );

            return signedUser;
        }

        // generate json web token
        private string GenerateJWT(MdiUtilisateur user)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var claims = new[]
            {
                new Claim(ClaimTypes.NameIdentifier, user.Pseudo)
            };

            var token = new JwtSecurityToken(
                    issuer: _config["Jwt:Issuer"],
                    audience: _config["Jwt:Audience"],
                    claims,
                    expires: DateTime.Now.AddMonths(1),
                    signingCredentials: credentials
                );
            var tokenString = new JwtSecurityTokenHandler().WriteToken(token);
            return tokenString;
        }

    }
}
