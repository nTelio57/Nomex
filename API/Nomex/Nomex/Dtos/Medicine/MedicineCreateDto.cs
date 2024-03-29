﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nomex.Dtos.Medicine
{
    public class MedicineCreateDto
    {
        public string Barcode { get; set; }
        public float Price { get; set; }
        public string Name { get; set; }
        public DateTime ExpireDate { get; set; }
        public bool IsCompensated { get; set; }
    }
}
