using Salon.Data.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Salon.Domain
{
    public class ServiceViewModel: AbstractDomainEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string ImageSource { get; set; }
        public string Description { get; set; }
        public ServiceTypeViewModel ServiceType { get; set; }
    }
}
