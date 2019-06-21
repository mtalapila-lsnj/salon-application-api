using AutoMapper;
using Salon.Data.Entities;
using Salon.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Salon.API.MappingProfiles
{
    public class EmployeeMappingProfile: Profile
    {
        public EmployeeMappingProfile()
        {
            CreateMap<EmployeeViewModel, Employee>().ReverseMap();
            CreateMap<Employee, EmployeeViewModel>().ReverseMap();
            CreateMap<Employee, EmployeeViewModel>()
                .ForMember(x => x.Title, opt => opt.MapFrom(src => src.CurrentTitle))
                .ForMember(x => x.EmplooyeeSchedules, opt => opt.MapFrom(src => src.EmployeeSchedules))
                .ForMember(x => x.Notes, opt => opt.MapFrom(src => src.Notes))
                .ForMember(x => x.Qualifications, opt => opt.MapFrom(src => src.EmployeeQualifications));
            CreateMap<EmployeeViewModel, Employee>()
                .ForMember(x => x.CurrentTitle, opt => opt.MapFrom(src => src.Title))
                .ForMember(x => x.EmployeeSchedules, opt => opt.MapFrom(src => src.EmplooyeeSchedules))
                .ForMember(x => x.EmployeeQualifications, opt => opt.MapFrom(src => src.Qualifications));
        }
    }
}
