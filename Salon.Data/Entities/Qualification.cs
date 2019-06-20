using Salon.Data.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Salon.Data.Entities
{
    public class Qualification: AbstractDataEntity
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public int ServiceId { get; set; }

        [ForeignKey("EmployeeId")]
        public virtual Employee Employee { get; set; }
        [ForeignKey("ServiceId")]
        public virtual Service  Service { get; set; }

        public virtual ICollection<CustomerServicePreference> CustomerPreferences { get; set; }
    }
}
