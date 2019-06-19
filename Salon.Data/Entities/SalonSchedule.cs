using System;
using System.Collections.Generic;
using System.Text;

namespace Salon.Data.Entities
{
    public class SalonSchedule
    {
        public int Id { get; set; }
        public DateTime Start { get; set; }
        public int Duration { get; set; }
    }
}
