using Salon.Data.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Salon.Domain
{
    public class AppointmentViewModel: AbstractDomainEntity
    {
        public int Id { get; set; }
        public CustomerViewModel Customer { get; set; }
        public EmployeeViewModel Employee { get; set; }
        public ServiceViewModel Service { get; set; }
        public DateTime? Start { get; set; }
        public int Duration { get; set; }
        public bool IsPaid { get; set; }
        public string Confirmation { get; set; }
        public bool? IsPrimaryRequest { get; set; }
        public bool? IsSecondaryRequest { get; set; }
        public string Remarks { get; set; }
        public ICollection<AppointmentTransactionViewModel> AppointmentTransactions { get; set; }
    }
}
