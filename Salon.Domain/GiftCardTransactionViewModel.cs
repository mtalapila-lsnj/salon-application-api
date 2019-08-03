using Salon.Data.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Salon.Domain
{
    public class GiftCardTransactionViewModel: AbstractDomainEntity
    {
        public int Id { get; set; }
        public DateTimeOffset? TransactionDate { get; set; }
        public string TransactionNote { get; set; }
        public decimal AmountUsed { get; set; }
        public int GiftCardId { get; set; }
    }
}
