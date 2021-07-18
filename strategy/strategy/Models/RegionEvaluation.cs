using System;
using System.Collections.Generic;

#nullable disable

namespace strategy.Models
{
    public partial class RegionEvaluation
    {
        public Guid Id { get; set; }
        public Guid MarketSegmentRegionId { get; set; }
        public string Name { get; set; }
        public int Priority { get; set; }
        public int Evaluation { get; set; }
        public int Mdf { get; set; }
        public long CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public long? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int Mindex { get; set; }
        public long? DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public int? CriteriaId { get; set; }

        public virtual MarketSegmentRegion MarketSegmentRegion { get; set; }
    }
}
