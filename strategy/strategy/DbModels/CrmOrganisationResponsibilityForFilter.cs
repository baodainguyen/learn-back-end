using System;
using System.Collections.Generic;

#nullable disable

namespace strategy.DbModels
{
    public partial class CrmOrganisationResponsibilityForFilter
    {
        public long CrmId { get; set; }
        public string Name { get; set; }
        public int TypeId { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
