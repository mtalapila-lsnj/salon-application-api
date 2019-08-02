using Salon.Data.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Salon.Data.Entities
{
    public class GiftCard: AbstractDataEntity
    {
        public int Id { get; set; }
        public DateTimeOffset? DateSold { get; set; }
        public DateTimeOffset? DateExpired { get; set; }
        public decimal Amount { get; set; }
        public int? CustomerId { get; set; }
        public string To { get; set; }
        public string From { get; set; }
        public string Note { get; set; }
        public bool IsDeleted { get; set; }

        [ForeignKey("CustomerId")]
        public virtual Customer Customer { get; set; }

        public virtual ICollection<GiftCardTransaction> GiftCardTransactions { get; set; }
    }
}
