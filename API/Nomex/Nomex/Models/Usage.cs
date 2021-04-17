using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security;
using System.Threading.Tasks;
using AutoMapper.Configuration.Conventions;
using Microsoft.EntityFrameworkCore;

namespace Nomex.Models
{
    public enum Dosage
    {
        OnceADay,
        TwiceADay,
        TriceADay,
        OnceAWeek
    }

    public class Usage
    {
        [Key]
        public int Id { get; set; }
        public string Description { get; set; }
        public Dosage Dosage { get; set; }
    }
}
