using AutoMapper;
using Salon.Data.Entities;
using Salon.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Salon.API.MappingProfiles
{
    public class NoteMappingProfile: Profile
    {
        public NoteMappingProfile()
        {
            CreateMap<Note, NoteViewModel>().ReverseMap();
            CreateMap<NoteViewModel, Note>().ReverseMap();
        }
    }
}
