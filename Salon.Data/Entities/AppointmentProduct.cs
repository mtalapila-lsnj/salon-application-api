using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Salon.Data.Entities
{
    public class AppointmentProduct
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int AppointmentId { get; set; }

        [ForeignKey("ProductId")]
        public virtual Product Product { get; set; }
        [ForeignKey("AppointmentId")]
        public virtual Appointment Appointment { get; set; }

    }
}
