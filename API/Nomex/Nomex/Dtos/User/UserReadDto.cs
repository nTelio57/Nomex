using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Nomex.Dtos.UserPersonal;

namespace Nomex.Dtos
{
    public class UserReadDto
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public UserPersonalReadDto PersonalDetails { get; set; }
    }
}
