using System;
using System.Collections.Generic;

#nullable disable

namespace strategy.Models
{
    public partial class KpiActionMasterIndexTime
    {
        public long Id { get; set; }
        public long? KpiActionMasterIndexId { get; set; }
        public long? KpiActionMasterTimeId { get; set; }
        public decimal? KpiValue { get; set; }
        public long CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public long? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public long? DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
    }
}
