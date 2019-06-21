using Salon.Data.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Salon.Domain
{
    public class GiftCardViewModel: AbstractDomainEntity
    {
        public int Id { get; set; }
        public DateTime? DateSold { get; set; }
        public DateTime? DateExpire { get; set; }
        public decimal Amount { get; set; }
        public CustomerViewModel Customer { get; set; }
        public string To { get; set; }
        public string From { get; set; }
        public string Note { get; set; }
        public ICollection<GiftCardTransactionViewModel> GiftCardTransactions { get; set; }
    }
}
