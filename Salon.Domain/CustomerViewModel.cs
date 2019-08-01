using Salon.Data.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Salon.Domain
{
    public class CustomerViewModel: AbstractDomainEntity
    {
        public int Id { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public GenderViewModel Gender { get; set; }
        public string PrimaryEmail { get; set; }
        public string SecondaryEmail { get; set; }
        public string PrimaryPhoneNumber { get; set; }
        public string SecondaryPhoneNumber { get; set; }
        public string Notes { get; set; }
        public bool? IsDeleted { get; set; }
        public ICollection<ContactAcceptanceViewModel> ContactAcceptances { get; set; }
        public ICollection<ProductPreferenceViewModel> ProductPreferences { get; set; }
        public ICollection<ServicePreferenceViewModel> ServicePreferences { get; set; }
    }
}
