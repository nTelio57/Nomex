using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nomex.Dtos.Recipe
{
    public class RecipeCreateDto
    {
        public DateTime ValidUntil { get; set; }
        public int? UserId { get; set; }
        public int? UsageId { get; set; }
        public int? MedicineId { get; set; }
    }
}
