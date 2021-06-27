using GC_Ventes.Models;
using GC_Ventes.Models.VueModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
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

        // Cryptage de mot de passe
        public static string CalculateMD5Hash(string input)
        {
            // step 1, calculate MD5 hash from input
            MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
            byte[] hash = md5.ComputeHash(inputBytes);

            // step 2, convert byte array to hex string
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("x2"));
            }
            return sb.ToString();
        }


        // login
        [HttpPost]
        public IActionResult Login(LoginCreds creds)
        {
            IActionResult response;
            
            // l'utilisateur connecté, null si le login incorrect 
            MdiUtilisateur currentUser = Authenticate(creds); // cette methods est pour verifier le login

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
            MdiUtilisateur signedUser = _context.MdiUtilisateurs.FirstOrDefault(user =>
                user.Pseudo == creds.username
                && user.Pass == CalculateMD5Hash(creds.password) // crypter le mot de passe
            );

            return signedUser;
        }

        // generate json web token
        private string GenerateJWT(MdiUtilisateur user)
        {
            // recuperer la clé de génération dans appsetting.json
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));

            // SigningCredential Représente la clé cryptographique
            // et les algorithmes de sécurité utilisés pour générer une signature numérique.
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);
            
            // claims sont utilisées pour accéder aux ressources
            var claims = new[]
            {
                new Claim(ClaimTypes.NameIdentifier, user.Pseudo)
            };
            
            // generation de JWT token
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
