using Salon.Data.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Salon.Domain
{
    public class QualificationViewModel: AbstractDomainEntity
    {
        public int Id { get; set; }
        public ServiceViewModel Service { get; set; }
    }
}
