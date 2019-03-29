using System;
using System.Collections.Generic;
using System.Text;

namespace Salon.Data.Entities
{
    public class Gender
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public virtual List<Employee> Employees { get; set; }
        
    }
}
