using Salon.Data.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Salon.Domain
{
    public class NoteViewModel: AbstractDomainEntity
    {
        public int Id { get; set; }
        public string NoteDescription { get; set; }
        public DateTime? CreatedOn { get; set; }
        public EmployeeViewModel CreatedBy { get; set; }
        public bool? Active { get; set; }
        public bool? Comleted { get; set; }
        public DateTime? CompletedOn { get; set; }
    }
}
