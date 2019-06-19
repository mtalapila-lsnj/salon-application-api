using System;
using System.Collections.Generic;
using System.Text;

namespace Salon.Data.Entities
{
    public class Transaction
    {
        public int Id { get; set; }
        public DateTime TransactionDate { get; set; }
        public string TransactionNote { get; set; }
    }
}
