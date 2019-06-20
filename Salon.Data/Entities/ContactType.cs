using Salon.Data.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Salon.Data.Entities
{
    public class ContactType: AbstractDataEntity
    {
        public int Id { get; set; }
        public string Type { get; set; }
    }
}
