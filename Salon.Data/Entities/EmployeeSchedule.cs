using Salon.Data.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Salon.Data.Entities
{
    public class EmployeeSchedule: AbstractDataEntity
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public int TimeSlotId { get; set; }

        [ForeignKey("EmployeeId")]
        public virtual Employee Employee { get; set; }
        [ForeignKey("TimeSlotId")]
        public virtual TimeSlot TimeSlot { get; set; }
    }
}
