using Salon.Data.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Salon.Data.Entities
{
    public class Gender: AbstractDataEntity
    {
        public int Id { get; set; }
        public string Description { get; set; }
    }
}
