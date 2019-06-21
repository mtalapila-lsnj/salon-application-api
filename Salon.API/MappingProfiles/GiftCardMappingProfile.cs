using AutoMapper;
using Salon.Data.Entities;
using Salon.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Salon.API.MappingProfiles
{
    public class GiftCardMappingProfile: Profile
    {
        public GiftCardMappingProfile()
        {
            CreateMap<GiftCard, GiftCardViewModel>().ReverseMap();
            CreateMap<GiftCardViewModel, GiftCard>().ReverseMap();
        }
    }
}
