using Salon.Data.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Salon.Data.Entities
{
    public class GroupParty: AbstractDataEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Start { get; set; }
        public int? ParticipantsQuantity { get; set; }
        public string Note { get; set; }
    }
}
