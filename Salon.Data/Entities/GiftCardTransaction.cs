using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Salon.Data.Entities
{
    public class GiftCardTransaction: Transaction
    {
        public int GiftCardId { get; set; }
        public decimal AmountUsed { get; set; }
        
        [ForeignKey("GiftCardId")]
        public virtual GiftCard GiftCard { get; set; }
    }
}
