using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Nomex.Models;

namespace Nomex.Data
{
    public interface IUserPersonalRepo
    {
        bool SaveChanges();

        IEnumerable<UserPersonal> GetAllUserPersonals();
        UserPersonal GetUserPersonalById(int id);
        void CreateUserPersonal(UserPersonal userPersonal);
        void UpdateUserPersonal(UserPersonal userPersonal);
        void DeleteUserPersonal(UserPersonal userPersonal);
    }
}
