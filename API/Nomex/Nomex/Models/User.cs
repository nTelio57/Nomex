using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Nomex.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        
        public string Email { get; set; }
        
        public string Password { get; set; }
        
        public string Salt { get; set; }

        //Foreign key for personal details
        [ForeignKey("PersonalDetails")]
        public int? PersonalDetailsId { get; set; }
        public UserPersonal PersonalDetails { get; set; }

        //Recipes
        public ICollection<Recipe> Recipes { get; set; }
    }
}
