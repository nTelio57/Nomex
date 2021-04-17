using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Nomex.Models;

namespace Nomex.Dtos.Usage
{
    public class UsageReadDto
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public Dosage Dosage { get; set; }
    }
}
