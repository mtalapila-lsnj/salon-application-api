using Salon.Data.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Salon.Data.Entities
{
    public class Appointment: AbstractDataEntity
    {
        public int Id { get; set; }
        public string Name { get; set; } // your nail appointment etc.
        public int? CustomerId { get; set; }
        public int? EmployeeId { get; set; }
        public int? ServiceId { get; set; }
        public DateTimeOffset Start { get; set; }
        public TimeSpan? Duration { get; set; }
        public bool IsPaid { get; set; }
        public string Confirmation { get; set; }
        public bool? IsPrimaryRequest { get; set; }
        public bool? IsSecondaryRequest { get; set; }
        public string Remarks { get; set; }
        public int? VisitId { get; set; }
        public int? GroupPartyId { get; set; }        
        public bool IsDeleted { get; set; }


        [ForeignKey("CustomerId")]
        public virtual Customer Customer { get; set; }
        [ForeignKey("EmployeeId")]
        public virtual Employee Employee { get; set; }
        [ForeignKey("ServiceId")]
        public virtual Service Service { get; set; }
        [ForeignKey("VisitId")]
        public virtual Visit Visit { get; set; }
        [ForeignKey("GroupPartyId")]
        public virtual GroupParty GroupParty { get; set; }
        public virtual ICollection<AppointmentTransaction> AppointmentTransactions { get; set; }
        public virtual ICollection<AppointmentProduct> AppointmentUsedProducts { get; set; }
        public virtual ICollection<AppointmentDetail> AppointmentDetails { get; set; }
    }
}
