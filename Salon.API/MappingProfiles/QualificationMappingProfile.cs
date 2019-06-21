using AutoMapper;
using Salon.Data.Entities;
using Salon.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Salon.API.MappingProfiles
{
    public class QualificationMappingProfile: Profile
    {
        public QualificationMappingProfile()
        {
            CreateMap<Qualification, QualificationViewModel>().ReverseMap();
            CreateMap<QualificationViewModel, Qualification>().ReverseMap();
        }
    }
}
