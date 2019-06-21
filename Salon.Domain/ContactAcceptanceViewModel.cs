using Salon.Data.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Salon.Domain
{
    public class ContactAcceptanceViewModel: AbstractDomainEntity
    {
        public int Id { get; set; }
        public ContactTypeViewModel Contact { get; set; }
        public DateTime? AcceptedOn { get; set; }
        public bool? OkToContact { get; set; }
        public bool? IsDeleted { get; set; }
        public DateTime? DeletedOn { get; set; }
    }
}
