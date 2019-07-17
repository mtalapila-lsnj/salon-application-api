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
        public int? DayOfWeek { get; set; }
        public int? DayOfMonth { get; set; }
        public int? StartHour { get; set; }
        public int? StartMinute { get; set; }
        public int? EndHour { get; set; }
        public int? EndMinute { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? ModifiedOn { get; set; }
        [ForeignKey("EmployeeId")]
        public virtual Employee Employee { get; set; }
    }
}
