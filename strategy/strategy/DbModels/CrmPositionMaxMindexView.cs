using System;
using System.Collections.Generic;

#nullable disable

namespace strategy.DbModels
{
    public partial class CrmPositionMaxMindexView
    {
        public long Id { get; set; }
        public long? CrmOrganisationId { get; set; }
        public long? CrmPersonId { get; set; }
        public long? CategoryId { get; set; }
        public string Name { get; set; }
    }
}
