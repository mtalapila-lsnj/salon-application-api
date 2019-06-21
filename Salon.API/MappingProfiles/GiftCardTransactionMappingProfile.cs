using AutoMapper;
using Salon.Data.Entities;
using Salon.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Salon.API.MappingProfiles
{
    public class GiftCardTransactionMappingProfile: Profile
    {
        public GiftCardTransactionMappingProfile()
        {
            CreateMap<GiftCardTransaction, GiftCardTransactionViewModel>()
                .ReverseMap();
            CreateMap<GiftCardTransactionViewModel, GiftCardTransaction>()
                .ReverseMap();
        }
    }
}
