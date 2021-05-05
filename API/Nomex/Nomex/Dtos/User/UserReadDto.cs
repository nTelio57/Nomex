using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nomex.Dtos
{
    public class UserReadDto
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PersonalCode { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
