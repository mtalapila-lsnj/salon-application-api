using Salon.Data.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Salon.Domain
{
    public class ContactPreferenceViewModel: AbstractDomainEntity
    {
        public int Id { get; set; }
        public CustomerViewModel Customer { get; set; }
        public ContactTypeViewModel ContactType { get; set; }
        public bool? OkToContact { get; set; }
        public bool? OkToContactOnWeekends { get; set; }
        public bool? OkToContactOnHolidays { get; set; }
        public string Notes { get; set; }
        public bool? IsDeleted { get; set; }
    }
}
