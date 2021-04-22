using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.IdentityModel.Tokens;
using Nomex.Data;
using Nomex.Models;
using Nomex.Utilities;

namespace Nomex.Auth
{
    public class AuthRepository : IAuthRepo
    {
        private readonly NomexContext _context;
        private readonly IDictionary<string, string> users = new Dictionary<string, string>
        {
            {"test1", "password1"}, {"test2", "password2"}
        };

        private readonly string _key;

        public AuthRepository(NomexContext context, string key)
        {
            _context = context;
            _key = key;
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

        public string GenerateToken(string email)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var tokenKey = Encoding.ASCII.GetBytes(_key);
            var tokenDescriptor = new SecurityTokenDescriptor()
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Email, email)
                }),
                Expires = DateTime.UtcNow.AddMonths(1),
                SigningCredentials = new SigningCredentials(
                    new SymmetricSecurityKey(tokenKey), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }

        public User GetUserByEmail(string email)
        {
            return _context.Users.FirstOrDefault(x => x.Email == email);
        }

        public void AddNewUser(User user)
        {
            _context.Users.Add(user);
        }

        public User GetUserByLogin(string email, string password)
        {
            return _context.Users.FirstOrDefault(x => x.Email == email && x.Password.Equals(Crypto.Hash(password)));
        }
    }
}
