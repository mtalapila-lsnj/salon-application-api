using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Salon.Data.Entities
{
    public class Customer
    {
        public int Id { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int? GenderId { get; set; }
        [ForeignKey("GenderId")]
        public virtual Gender Gender { get; set; }
        public string PrimaryEmail { get; set; }
        public string SecondaryEmail { get; set; }
        public string PrimaryPhoneNumber { get; set; }
        public string SecondaryPhoneNumber { get; set; }
        public string Notes { get; set; }       

        public virtual ICollection<Appointment> Appointments { get; set; }
        public virtual ICollection<GiftCard> GiftCards { get; set; }
        public virtual ICollection<ContactAcceptance> ContactAcceptances { get; set; }
    }
}
