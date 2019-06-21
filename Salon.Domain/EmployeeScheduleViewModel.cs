using Salon.Data.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Salon.Domain
{
    public class EmployeeScheduleViewModel: AbstractDomainEntity
    {
        public int Id { get; set; }
        public TimeSlotViewModel TimeSlot { get; set; }
    }
}
