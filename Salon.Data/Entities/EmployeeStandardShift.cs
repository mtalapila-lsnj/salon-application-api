using Salon.Data.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Salon.Data.Entities
{
    public class EmployeeStandardShift: AbstractDataEntity
    {
        public int Id { get; set; }
        public int? EmployeeId { get; set; }
        // used for day of week number of day of month number 
        public int? Number { get; set; }
        public EmployeeStandardShiftType? EmployeeStandardShiftType { get; set; }
        public int? StartHour { get; set; }
        public int? StartMinute { get; set; }
        public int? EndHour { get; set; }
        public int? EndMinute { get; set; }
        public DateTimeOffset? CreatedOn { get; set; }
        public DateTimeOffset? ModifiedOn { get; set; }
        [ForeignKey("EmployeeId")]
        public virtual Employee Employee { get; set; }
    }
    public enum EmployeeStandardShiftType
    {
        DayOfWeek = 0,
        DayOfMonth
    }
}
