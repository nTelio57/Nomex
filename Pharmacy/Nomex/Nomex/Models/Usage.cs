using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nomex.Models
{
    public enum Dosage
    {
        Daily,
        Every2Days,
        Every3Days,
        Every4Days,
        Every5Days,
        OnceAWeek,
        Every2Weeks,
        OnceAMonth
    }

    public class Usage
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public Dosage Dosage { get; set; }
    }
}
