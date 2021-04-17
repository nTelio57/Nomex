using Nomex.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nomex.Data
{
    public class UserPersonalRepository : IUserPersonalRepo
    {
        private readonly NomexContext _context;
        public UserPersonalRepository(NomexContext context)
        {
            _context = context;
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

        public void CreateUserPersonal(UserPersonal userPersonal)
        {
            if (userPersonal == null)
                throw new ArgumentNullException(nameof(userPersonal));

            _context.UserPersonals.Add(userPersonal);
        }

        public void DeleteUserPersonal(UserPersonal userPersonal)
        {
            if (userPersonal == null)
                throw new ArgumentNullException(nameof(userPersonal));

            _context.UserPersonals.Remove(userPersonal);
        }

        public IEnumerable<UserPersonal> GetAllUserPersonals()
        {
            return _context.UserPersonals.ToList();
        }

        public UserPersonal GetUserPersonalById(int id)
        {
            return _context.UserPersonals.FirstOrDefault(p => p.Id == id);
        }

        public void UpdateUserPersonal(UserPersonal userPersonal)
        {
            //nothing
        }
    }
}
