using System;
using System.Collections.Generic;

#nullable disable

namespace strategy.DbModels
{
    public partial class MarketSegment
    {
        public MarketSegment()
        {
            MarketSegmentRegions = new HashSet<MarketSegmentRegion>();
        }

        public long Id { get; set; }
        public long ProjectId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Mindex { get; set; }
        public int Type { get; set; }
        public int Mdf { get; set; }
        public long CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public long? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public long? DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public long? LandId { get; set; }
        public long? OldId { get; set; }

        public virtual Project Project { get; set; }
        public virtual ICollection<MarketSegmentRegion> MarketSegmentRegions { get; set; }
    }
}
