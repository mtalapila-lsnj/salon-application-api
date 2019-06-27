using Salon.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Salon.Data.Repositories.Interfaces
{
    public interface IGiftCardRepository
    {
        IEnumerable<GiftCardViewModel> GetAllGiftCards();
        GiftCardViewModel GetGiftCardById(int id);
        GiftCardViewModel AddGiftCard(GiftCardViewModel viewModel);

        GiftCardViewModel UpdateGiftCard(int id, GiftCardViewModel giftCard);

    }
}
