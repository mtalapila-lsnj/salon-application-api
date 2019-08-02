using Salon.Data.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Salon.Data.Entities
{
    public class Visit: AbstractDataEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTimeOffset? Start { get; set; }
    }
}
