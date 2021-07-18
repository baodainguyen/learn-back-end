using System;
using System.Collections.Generic;

#nullable disable

namespace strategy.Models
{
    public partial class CrmPersonResponsibilityForFilter
    {
        public long CrmId { get; set; }
        public string Name { get; set; }
        public int TypeId { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
