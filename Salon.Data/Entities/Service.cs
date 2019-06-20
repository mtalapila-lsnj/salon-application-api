using Salon.Data.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Salon.Data.Entities
{
    public class Service: AbstractDataEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string ImageSource { get; set; }
        public string Description { get; set; }
        public int? TypeId { get; set; }
        [ForeignKey("TypeId")]
        public virtual ServiceType ServiceType { get; set; }
        public virtual ICollection<Appointment> Appointments { get; set; }
        public virtual ICollection<Qualification> Qualifications { get; set; }
    }
}
