using System;
using System.Collections.Generic;

#nullable disable

namespace strategy.DbModels
{
    public partial class Template
    {
        public Template()
        {
            MarketSegmentRegions = new HashSet<MarketSegmentRegion>();
            SubMarketProducts = new HashSet<SubMarketProduct>();
            TargetGroupTemps = new HashSet<TargetGroupTemp>();
        }

        public Guid Id { get; set; }
        public long ProjectId { get; set; }
        public string Name { get; set; }
        public int Type { get; set; }
        public string Value { get; set; }
        public int PublicType { get; set; }
        public long CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public long? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public long? DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }

        public virtual ICollection<MarketSegmentRegion> MarketSegmentRegions { get; set; }
        public virtual ICollection<SubMarketProduct> SubMarketProducts { get; set; }
        public virtual ICollection<TargetGroupTemp> TargetGroupTemps { get; set; }
    }
}
