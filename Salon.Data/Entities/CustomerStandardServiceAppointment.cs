using Salon.Data.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Salon.Data.Entities
{
    public class CustomerStandardServiceAppointment: AbstractDataEntity
    {
        public int Id { get; set; }
        public int? CustomerId { get; set; }
        public int? ServiceId { get; set; }
        public int? EmployeePreferenceId { get; set; }
        public int? EmployeeTwoPreferenceId { get; set; }
        public DayOfWeek? DayOfWk { get; set; }        
        public int? DayOfMonth { get; set; }
        public CustomerStandardServiceAppointmentType? GetCustomerStandardServiceAppointmentType { get; set; }
        public int? StartHour { get; set; }
        public int? StartMinute { get; set; }
        public string Note { get; set; }
        public int? GapDuration { get; set; }
        [ForeignKey("EmployeePreferenceId")]
        public virtual Employee EmployeePreference { get; set; }
        [ForeignKey("EmployeeTwoPreferenceId")]
        public virtual Employee EmployeeTwoPreference { get; set; }
    }
}
