using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Nomex.Models
{
    public class UserPersonal
    {
        [Key]
        public int Id { get; set; }
        
        public string Name { get; set; }
        
        public string Surname { get; set; }
        
        public string PersonalCode { get; set; }

        public DateTime BirthDate { get; set; }


        public User User { get; set; }
    }
}
