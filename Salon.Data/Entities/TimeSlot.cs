﻿using Salon.Data.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Salon.Data.Entities
{
    public class TimeSlot: AbstractDataEntity
    {
        public int Id { get; set; }
        public DateTime? Start { get; set; }
        public int? Duration { get; set; }

        public virtual ICollection<EmployeeSchedule> EmployeeSchedules { get; set; }
    }
}
