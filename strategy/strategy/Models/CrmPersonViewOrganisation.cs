using System;
using System.Collections.Generic;

#nullable disable

namespace strategy.Models
{
    public partial class CrmPersonViewOrganisation
    {
        public long Id { get; set; }
        public string PositionName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int? Mindex { get; set; }
        public string Note { get; set; }
        public DateTime? DueDate { get; set; }
        public long ProjectId { get; set; }
        public long? DeletedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public long? Rn { get; set; }
    }
}
