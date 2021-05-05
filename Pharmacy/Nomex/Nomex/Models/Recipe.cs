using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nomex.Models
{
    public class Recipe
    {
        public int UserId { get; set; }
        public int MedicineId { get; set; }
        public int UsageId { get; set; }
        public Medicine Medicine { get; set; }
        public Usage Usage { get; set; }
    }
}
