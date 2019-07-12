using Salon.Data.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Salon.Data.Entities
{
    public class AppointmentDetail: AbstractDataEntity
    {
        public int Id { get; set; }
        public int? AppointmentId { get; set; }
        public DateTime Start { get; set; }
        public int? Duration { get; set; }
        
        public int? ServiceStepId { get; set; }
        public int? EmployeeId { get; set; }
        [ForeignKey("EmployeeId")]
        public virtual  Employee Employee { get; set; }
        [ForeignKey("ServiceStepId")]
        public virtual ServiceStep ServiceStep { get; set; }
        [ForeignKey("AppointmentId")]
        public virtual Appointment Appointment { get; set; }
    }
}
