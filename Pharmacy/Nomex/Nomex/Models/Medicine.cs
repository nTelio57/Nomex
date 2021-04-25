using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nomex.Models;

namespace Nomex
{
    public class Medicine
    {
        public int Id { get; set; }
        public string Barcode { get; set; }
        public float Price { get; set; }
        public string Name { get; set; }
        public DateTime ExpireDate { get; set; }
        public bool IsCompensated { get; set; }
        public Usage usageTemplate { get; set; }

    }
}
