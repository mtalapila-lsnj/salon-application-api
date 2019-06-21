using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Salon.Data.Base;
using Salon.Data.Entities;
using Salon.Data.Repositories.Interfaces;
using Salon.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Salon.Data.Repositories
{
    public class GiftCardRepository: EntityMappingRepository<GiftCard, GiftCardViewModel>, IGiftCardRepository
    {
        public GiftCardRepository(SalonContext salonContext, IMapper mapper) : base(salonContext, mapper) { }

        public IEnumerable<GiftCardViewModel> GetAllGiftCards()
        {
            return _context.Set<GiftCard>().Include(x => x.Customer).Include(x => x.GiftCardTransactions).Select(x => MapFrom(x));
        }
    }
}
