using System;
using System.Collections.Generic;

#nullable disable

namespace strategy.Models
{
    public partial class CrmOrganisationView
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string BranchName { get; set; }
        public string Logo { get; set; }
        public string Note { get; set; }
        public string LegalForm { get; set; }
        public string Employee { get; set; }
        public string Revenue { get; set; }
        public long ProjectId { get; set; }
        public long? DeletedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
