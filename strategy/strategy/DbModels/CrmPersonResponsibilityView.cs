using System;
using System.Collections.Generic;

#nullable disable

namespace strategy.DbModels
{
    public partial class CrmPersonResponsibilityView
    {
        public long CrmPersonId { get; set; }
        public long AccountId { get; set; }
        public string Name { get; set; }
    }
}
