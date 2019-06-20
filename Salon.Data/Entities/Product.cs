using Salon.Data.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Salon.Data.Entities
{
    public class Product: AbstractDataEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageSource { get; set; }

        public virtual ICollection<AppointmentProduct> AppointmentProducts { get; set; }
        public virtual ICollection<CustomerProductPreference> ProductPreferences { get; set; }
    }
}
