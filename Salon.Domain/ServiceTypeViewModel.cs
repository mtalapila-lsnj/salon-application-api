using Salon.Data.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Salon.Domain
{
    public class ServiceTypeViewModel: AbstractDomainEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
