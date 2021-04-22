using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Nomex.Models;

namespace Nomex.Auth
{
    public interface IAuthRepo
    {
        bool SaveChanges();
        User GetUserByEmail(string email);
        string GenerateToken(string email);
        void AddNewUser(User user);
        User GetUserByLogin(string email, string password);
    }
}
