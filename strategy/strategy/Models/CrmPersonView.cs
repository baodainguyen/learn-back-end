using System;
using System.Collections.Generic;

#nullable disable

namespace strategy.Models
{
    public partial class CrmPersonView
    {
        public long Id { get; set; }
        public string PersonName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Note { get; set; }
        public long ProjectId { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public long? DeletedBy { get; set; }
        public DateTime? BirthDay { get; set; }
        public int? TypeId { get; set; }
    }
}
