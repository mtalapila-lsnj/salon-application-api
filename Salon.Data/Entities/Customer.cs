using System;
using System.Collections.Generic;
using System.Text;

namespace Salon.Data.Entities
{
    public class Customer: Person
    {
        public string PrimaryEmail { get; set; }
        public string SecondaryEmail { get; set; }
        public string PrimaryPhoneNumber { get; set; }
        public string SecondaryPhoneNumber { get; set; }
        public string Notes { get; set; }
    }
}
