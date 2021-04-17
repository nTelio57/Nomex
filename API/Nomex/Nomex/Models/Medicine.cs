using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Nomex.Models
{
    public class Medicine
    {
        [Key]
        public int Id { get; set; }
        public string Barcode { get; set; }
        public float Price { get; set; }
        public string Name { get; set; }
        public string CompanyName { get; set; }
        public DateTime ExpireDate { get; set; }
        public bool IsCompensated { get; set; }

        //Foreign key for Usage Template
        [ForeignKey("UsageTemplate")]
        public int? UsageTemplateId { get; set; }
        public Usage UsageTemplate { get; set; }

        //Foreign keys for ActiveSubstances
        public ICollection<MedicineActiveSubstance> ActiveSubstances { get; set; }
    }
}
