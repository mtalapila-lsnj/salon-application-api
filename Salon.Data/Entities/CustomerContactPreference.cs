using Salon.Data.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Salon.Data.Entities
{
    public class CustomerContactPreference: AbstractDataEntity
    {
        public int Id { get; set; }
        public int? CustomerId { get; set; }
        public int? ContactTypeId { get; set; }
        public bool? OkToContact { get; set; }
        public bool? OkToContactOnWeekends { get; set; }
        public bool? OkToContactOnHolidays { get; set; }
        public string Notes { get; set; }
        public bool? IsDeleted { get; set; }

        [ForeignKey("CustomerId")]
        public virtual Customer Customer { get; set; }
        [ForeignKey("ContactTypeId")]
        public virtual ContactType ContactType { get; set; }
    }
}
