using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Nomex.Models;

namespace Nomex.Dtos.Recipe
{
    public class RecipeReadDto
    {
        public int Id { get; set; }
        public DateTime ValidUntil { get; set; }
        public int? UserId { get; set; }
        public int? UsageId { get; set; }
        public int? MedicineId { get; set; }

    }
}
