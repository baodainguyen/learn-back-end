using System;
using System.Collections.Generic;

#nullable disable

namespace strategy.DbModels
{
    public partial class CrmActivityPersonNameOneOrgTopView
    {
        public long CrmActivityId { get; set; }
        public long PersonId { get; set; }
        public long OrgId { get; set; }
    }
}
