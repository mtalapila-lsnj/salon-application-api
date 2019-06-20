using Salon.Data.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Salon.Data.Entities
{
    public class Note: AbstractDataEntity
    {
        public int Id { get; set; }
        public string NoteDescription { get; set; }
        public DateTime? CreatedOn { get; set; }
        public int? CreatedBy { get; set; }
        public bool? Active { get; set; }
        public bool? Completed { get; set; }
        public DateTime? CompletedOn { get; set; }

        [ForeignKey("CreatedBy")]
        public virtual Employee CreatedByEmployee { get; set; }
    }
}
