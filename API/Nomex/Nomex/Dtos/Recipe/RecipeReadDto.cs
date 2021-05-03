using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Nomex.Dtos.Medicine;
using Nomex.Dtos.Usage;
using Nomex.Models;

namespace Nomex.Dtos.Recipe
{
    public class RecipeReadDto
    {
        public int Id { get; set; }
        public DateTime ValidUntil { get; set; }
        public int? UserId { get; set; }
        public UsageReadDto Usage { get; set; }
        public MedicineReadDto Medicine { get; set; }

    }
}
