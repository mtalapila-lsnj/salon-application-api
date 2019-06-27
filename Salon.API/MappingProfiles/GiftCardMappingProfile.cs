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
            CreateMap<GiftCard, GiftCardViewModel>()
                .ForMember(x => x.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(x => x.DateSold, opt => opt.MapFrom(src => src.DateSold))
                .ForMember(x => x.DateExpire, opt => opt.MapFrom(src => src.DateExpired))
                .ForMember(x => x.Amount, opt => opt.MapFrom(src => src.Amount))
                .ForMember(x => x.Customer, opt => opt.MapFrom(src => src.Customer))
                .ForMember(x => x.To, opt => opt.MapFrom(src => src.To))
                .ForMember(x => x.From, opt => opt.MapFrom(src => src.From))
                .ForMember(x => x.Note, opt => opt.MapFrom(src => src.Note));
            CreateMap<GiftCardViewModel, GiftCard>()
                .ForMember(x => x.DateExpired, opt => opt.MapFrom(src => src.DateExpire));
        }
    }
}
