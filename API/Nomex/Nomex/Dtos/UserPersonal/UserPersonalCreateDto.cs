using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nomex.Dtos.UserPersonal
{
    public class UserPersonalCreateDto
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        public string PersonalCode { get; set; }

        public DateTime BirthDate { get; set; }
    }
}
