using Salon.Data.Repositories.Interfaces;
using Salon.Domain;
using Salon.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Salon.Service
{
    public class GiftCardTransactionService : IGiftCardTransactionService
    {
        private readonly IGiftCardTransactionRepository _giftCardTransactionRepository;
        public GiftCardTransactionService(IGiftCardTransactionRepository giftCardTransactionRepository)
        {
            _giftCardTransactionRepository = giftCardTransactionRepository;
        }
        public GiftCardTransactionViewModel CreateTransactionForGiftCard(GiftCardTransactionViewModel transaction)
        {
            return _giftCardTransactionRepository.CreateTransactionForGiftCard(transaction);
        }

        public GiftCardTransactionViewModel GetGiftCardTransactionById(int id)
        {
            return _giftCardTransactionRepository.GetTransactionById(id);
        }

        public IEnumerable<GiftCardTransactionViewModel> GetTransactionsByGiftCardId(int id)
        {
            return _giftCardTransactionRepository.GetTransactionsByGiftCardId(id);
        }
    }
}
