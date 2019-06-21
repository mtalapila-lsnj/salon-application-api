using Salon.Data.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Salon.Domain
{
    public class SalonScheduleViewModel: AbstractDomainEntity
    {
        public int Id { get; set; }
        public DateTime Start { get; set; }
        public int Duration { get; set; }
    }
}
