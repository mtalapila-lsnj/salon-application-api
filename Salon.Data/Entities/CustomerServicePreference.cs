using Salon.Data.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Salon.Data.Entities
{
    public class CustomerServicePreference: AbstractDataEntity
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int QualificationId { get; set; }
        [ForeignKey("CustomerId")]
        public virtual Customer Customer { get; set; }
        [ForeignKey("QualificationId")]
        public virtual Qualification Qualification { get; set; }
        public int? Order { get; set; }
    }
}
