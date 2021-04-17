using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Nomex.Models
{
    public class ActiveSubstance
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public float Amount { get; set; }

        //Foreign keys for medicine
        public ICollection<MedicineActiveSubstance> Medicines { get; set; }
    }
}
