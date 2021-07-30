using System;
using System.Collections.Generic;

#nullable disable

namespace strategy.DbModels
{
    public partial class GetAvgSubmarket
    {
        public Guid MarketSegmentRegionId { get; set; }
        public int? EvaluationSub { get; set; }
    }
}
