using Salon.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Salon.Service.Interfaces
{
    public interface IGiftCardService
    {
        IEnumerable<GiftCardViewModel> GetGiftCards();
        GiftCardViewModel GetGiftCard(int id);
        GiftCardViewModel AddGiftCard(GiftCardViewModel giftCard);
        GiftCardViewModel UpdateGiftCard(int id, GiftCardViewModel giftCard);
    }
}
