using System;
using System.Collections.Generic;

#nullable disable

namespace strategy.DbModels
{
    public partial class CrmPersonPositionView
    {
        public long PositionId { get; set; }
        public long? CrmOrganisationId { get; set; }
        public long? CrmPersonId { get; set; }
        public long? CatPositionId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PositionName { get; set; }
        public int? CatPositionType { get; set; }
    }
}
