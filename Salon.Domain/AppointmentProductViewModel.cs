using Salon.Data.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Salon.Domain
{
    public class AppointmentProductViewModel: AbstractDomainEntity
    {
        public int Id { get; set; }
        public ProductViewModel Product { get; set; }
        public AppointmentViewModel Appointment { get; set; }
    }
}
