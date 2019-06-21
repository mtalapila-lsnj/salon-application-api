using Salon.Data.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Salon.Domain
{
    public class ProductPreferenceViewModel: AbstractDomainEntity
    {
        public int Id { get; set; }
        public ProductViewModel Product { get; set; }
    }
}
