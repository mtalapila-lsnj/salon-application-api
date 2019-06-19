using System;
using System.Collections.Generic;
using System.Text;

namespace Salon.Data.Entities
{
    public class ServiceType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Service> Services { get; set; }
    }
}
