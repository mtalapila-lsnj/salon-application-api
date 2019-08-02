using Salon.Data.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Salon.Data.Entities
{
    public class ContactAcceptance: AbstractDataEntity
    {
        public int Id { get; set; }
        public int? TypeId { get; set; }
        [ForeignKey("TypeId")]
        public virtual ContactType ContactType { get; set; }
        public DateTimeOffset? AcceptedOn { get; set; }
        public bool? IsOkToCotact { get; set; }
        public int? CustomerId { get; set; }
        public bool? IsDeleted { get; set; }
        public DateTimeOffset? DeletedOn { get; set; }
        [ForeignKey("CustomerId")]
        public virtual Customer Customer { get; set; }
    }
}
