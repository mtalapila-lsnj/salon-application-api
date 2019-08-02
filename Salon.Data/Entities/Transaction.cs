using Salon.Data.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Salon.Data.Entities
{
    public class Transaction: AbstractDataEntity
    {
        public int Id { get; set; }
        public DateTimeOffset? TransactionDate { get; set; }
        public string TransactionNote { get; set; }
    }
}
