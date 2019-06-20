using AutoMapper;
using Salon.Data.Entities;
using Salon.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Salon.API.MappingProfiles
{
    public class GenderMappingProfile: Profile
    {
        public GenderMappingProfile()
        {
            CreateMap<GenderViewModel, Gender>().ForMember(c => c.Description, opt => opt.MapFrom(src => src.Name));
            CreateMap<Gender, GenderViewModel>().ForMember(c => c.Name, opt => opt.MapFrom(src => src.Description));
        }
    }
}
