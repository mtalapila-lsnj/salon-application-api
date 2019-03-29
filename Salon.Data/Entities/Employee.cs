using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Salon.Data.Entities
{
    public class Employee: Person
    {
        public DateTime? HireDate { get; set; }
        public bool IsActive { get; set; }
        public int? TitleId { get; set; }
        [ForeignKey("TitleId")]
        public virtual  EmployeeTitle CurrentTitle { get; set; }
    }
}
