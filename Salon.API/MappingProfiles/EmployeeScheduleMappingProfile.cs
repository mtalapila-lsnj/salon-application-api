using AutoMapper;
using Salon.Data.Entities;
using Salon.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Salon.API.MappingProfiles
{
    public class EmployeeScheduleMappingProfile: Profile
    {
        public EmployeeScheduleMappingProfile()
        {
            CreateMap<EmployeeSchedule, EmployeeScheduleViewModel>().ReverseMap();
            CreateMap<EmployeeScheduleViewModel, EmployeeSchedule>().ReverseMap();
        }
    }
}
