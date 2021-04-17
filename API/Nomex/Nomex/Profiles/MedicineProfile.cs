using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Nomex.Dtos.Medicine;
using Nomex.Models;

namespace Nomex.Profiles
{
    public class MedicineProfile : Profile
    {
        public MedicineProfile()
        {
            CreateMap<Medicine, MedicineReadDto>();
            CreateMap<MedicineCreateDto, Medicine>();
            CreateMap<MedicineUpdateDto, Medicine>();
            CreateMap<Medicine, MedicineUpdateDto>();
        }
    }
}
