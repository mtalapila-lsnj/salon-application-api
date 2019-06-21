using Salon.Data.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Salon.Domain
{
    public class AppointmentTransactionViewModel: AbstractDomainEntity
    {
        public int Id { get; set; }
        public DateTime? TransactionDate { get; set; }
        public string TransactionNote { get; set; }
        public decimal AmountPaid { get; set; }
    }
}
