using System;
using System.Collections.Generic;
using System.Linq;

namespace ContractApiV2.Models
{
    public class Contact
    {
        public int ContactId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Guid OwnerId { get; set; }

    }

}
