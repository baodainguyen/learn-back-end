using System;
using System.Collections.Generic;

#nullable disable

namespace strategy.DbModels
{
    public partial class CrmOrganisationRelationView
    {
        public long Id { get; set; }
        public long CrmOrganisationId { get; set; }
        public string Note { get; set; }
    }
}
