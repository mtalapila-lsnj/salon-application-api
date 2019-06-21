using Salon.Data.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Salon.Domain
{
    public class ServicePreferenceViewModel: AbstractDomainEntity
    {
        public int Id { get; set; }
        public QualificationViewModel Qualification { get; set; }
        public int Order { get; set; }
    }
}
