using System;
using System.Collections.Generic;

#nullable disable

namespace strategy.Models
{
    public partial class CrmOrganisationRelationView
    {
        public long Id { get; set; }
        public long CrmOrganisationId { get; set; }
        public string Note { get; set; }
    }
}
