using Salon.Data.Repositories.Interfaces;
using Salon.Domain;
using Salon.Service.Interfaces;
using System;
using System.Collections.Generic;

namespace Salon.Service
{
    public class GiftCardService: IGiftCardService
    {
        private readonly IGiftCardRepository _giftCardRepository;
        public GiftCardService(IGiftCardRepository giftCardRepository)
        {
            _giftCardRepository = giftCardRepository;
        }       

        public IEnumerable<GiftCardViewModel> GetGiftCards()
        {
            var gc = _giftCardRepository.GetAllGiftCards();
            return gc;
        }

        public GiftCardViewModel GetGiftCard(int id)
        {
            return _giftCardRepository.GetGiftCardById(id);
        }

        public GiftCardViewModel AddGiftCard(GiftCardViewModel model)
        {
            return _giftCardRepository.AddGiftCard(model);
        }
        public GiftCardViewModel UpdateGiftCard(int id, GiftCardViewModel model)
        {
            return _giftCardRepository.UpdateGiftCard(id, model);
        }
        public void DeleteGiftCard(GiftCardViewModel giftCard)
        {
            giftCard.IsDeleted = true;
            _giftCardRepository.UpdateGiftCard(giftCard.Id, giftCard);
        }
    }
}
