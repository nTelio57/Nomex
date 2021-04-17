using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Nomex.Dtos;
using Nomex.Dtos.UserPersonal;
using Nomex.Models;

namespace Nomex.Profiles
{
    public class UserPersonalProfile : Profile
    {
        public UserPersonalProfile()
        {
            CreateMap<UserPersonal, UserPersonalReadDto>();
            CreateMap<UserPersonalCreateDto, UserPersonal>();
            CreateMap<UserPersonalUpdateDto, UserPersonal>();
            CreateMap<UserPersonal, UserPersonalUpdateDto>();
        }
    }
}
