using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Nomex.Models
{
    public class Recipe
    {
        [Key]
        public int Id { get; set; }
        
        public DateTime ValidUntil { get; set; }

        //Foreign key for User
        [ForeignKey("User")]
        public int? UserId { get; set; }
        public User User { get; set; }

        //Foreign key for Usage
        [ForeignKey("Usage")]
        public int? UsageId { get; set; }
        public Usage Usage { get; set; }

        //Foreign key for Medicine
        [ForeignKey("Medicine")]
        public int? MedicineId { get; set; }
        public Medicine Medicine { get; set; }
    }

}
