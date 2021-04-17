using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Nomex.Models;

namespace Nomex.Data
{
    public class UserRepository : IUserRepo
    {
        private readonly NomexContext _context;

        public UserRepository(NomexContext context)
        {
            _context = context;
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

        public IEnumerable<User> GetAllUsers()
        {
            return _context.Users.ToList();
        }

        public User GetUserById(int id)
        {
            return _context.Users.FirstOrDefault(p => p.Id == id);
        }

        public void CreateUser(User user)
        {
            if(user == null)
                throw new ArgumentNullException(nameof(user));

            _context.Users.Add(user);
        }

        public void UpdateUser(User user)
        {
            //nothing
        }

        public void DeleteUser(User user)
        {
            if (user == null)
                throw new ArgumentNullException(nameof(user));

            _context.Users.Remove(user);
        }
    }
}
