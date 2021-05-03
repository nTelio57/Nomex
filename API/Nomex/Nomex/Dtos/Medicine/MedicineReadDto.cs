using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Nomex.Dtos.Usage;

namespace Nomex.Dtos.Medicine
{
    public class MedicineReadDto
    {
        public int Id { get; set; }
        public string Barcode { get; set; }
        public float Price { get; set; }
        public string Name { get; set; }
        public DateTime ExpireDate { get; set; }
        public bool IsCompensated { get; set; }
        public UsageReadDto UsageTemplate { get; set; }
    }
}
