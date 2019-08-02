using Salon.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Salon.Data.Repositories.Interfaces
{
    public interface IGiftCardTransactionRepository
    {
        GiftCardTransactionViewModel GetTransactionById(int id);
        IEnumerable<GiftCardTransactionViewModel> GetTransactionsByGiftCardId(int id);
        GiftCardTransactionViewModel CreateTransactionForGiftCard(GiftCardTransactionViewModel giftCardTransaction);
    }
}
