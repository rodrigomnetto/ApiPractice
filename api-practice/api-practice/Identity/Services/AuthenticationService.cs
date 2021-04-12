using ApiPractice.Identity.Services.Interfaces;
using ApiPractice.Settings;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace ApiPractice.Identity.Services
{
    public class AuthenticationService : IAuthenticationService
    {
        private IOptions<AuthenticationSettings> _authenticationOptions;

        public AuthenticationService(IOptions<AuthenticationSettings> authenticationOptions)
        {
            _authenticationOptions = authenticationOptions;
        }

        public string GenerateToken(Entities.User.User user)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_authenticationOptions.Value.Secret);

            var tokenDescriptor = new SecurityTokenDescriptor()
            {
                Subject = new ClaimsIdentity(new Claim[] 
                { 
                    new Claim(ClaimTypes.Name, user.Name),
                    new Claim(ClaimTypes.Email, user.Email)
                }),
                Expires = DateTime.UtcNow.AddHours(2),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }
}
