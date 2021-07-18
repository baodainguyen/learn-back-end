using System;
using System.Collections.Generic;

#nullable disable

namespace strategy.Models
{
    public partial class GetAvgSubmarket
    {
        public Guid MarketSegmentRegionId { get; set; }
        public int? EvaluationSub { get; set; }
    }
}
