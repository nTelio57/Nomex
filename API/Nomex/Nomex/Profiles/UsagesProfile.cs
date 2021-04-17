using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Nomex.Dtos.Usage;
using Nomex.Models;

namespace Nomex.Profiles
{
    public class UsagesProfile : Profile
    {
        public UsagesProfile()
        {
            CreateMap<Usage, UsageReadDto>();
            CreateMap<UsageCreateDto, Usage>();
            CreateMap<UsageUpdateDto, Usage>();
            CreateMap<Usage, UsageUpdateDto>();
        }
    }
}
