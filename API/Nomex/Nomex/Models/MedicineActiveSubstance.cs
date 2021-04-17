using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Nomex.Models
{
    public class MedicineActiveSubstance
    {
        public int MedicineId { get; set; }
        public Medicine Medicine { get; set; }
        
        public int ActiveSubstanceId { get; set; }
        public ActiveSubstance ActiveSubstance { get; set; }
    }
}
