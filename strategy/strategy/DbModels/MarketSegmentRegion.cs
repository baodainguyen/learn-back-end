using System;
using System.Collections.Generic;

#nullable disable

namespace strategy.DbModels
{
    public partial class MarketSegmentRegion
    {
        public MarketSegmentRegion()
        {
            RegionEvaluations = new HashSet<RegionEvaluation>();
            SubMarkets = new HashSet<SubMarket>();
        }

        public Guid Id { get; set; }
        public long MarketSegmentId { get; set; }
        public long? StrategyId { get; set; }
        public long RegionId { get; set; }
        public Guid? TemplateId { get; set; }
        public string Comment { get; set; }
        public int Mdf { get; set; }
        public long CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public long? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? EvaluationResult { get; set; }
        public bool IsActive { get; set; }
        public long? DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }

        public virtual MarketSegment MarketSegment { get; set; }
        public virtual Region Region { get; set; }
        public virtual Template Template { get; set; }
        public virtual ICollection<RegionEvaluation> RegionEvaluations { get; set; }
        public virtual ICollection<SubMarket> SubMarkets { get; set; }
    }
}
