using Salon.Data.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Salon.Domain
{
    public class ContactTypeViewModel: AbstractDomainEntity
    {
        public int Id { get; set; }
        public string Type { get; set; }
    }
}
