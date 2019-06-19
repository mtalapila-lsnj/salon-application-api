using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Salon.Data.Entities
{
    public class GiftCard
    {
        public int Id { get; set; }
        public DateTime? DateSold { get; set; }
        public DateTime? DateExpired { get; set; }
        public decimal Amount { get; set; }
        public int? CustomerId { get; set; }
        public string To { get; set; }
        public string From { get; set; }
        public string Note { get; set; }

        [ForeignKey("CustomerId")]
        public virtual Customer Customer { get; set; }

        public virtual ICollection<GiftCardTransaction> GiftCardTransactions { get; set; }
    }
}
