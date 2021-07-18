using System;
using System.Collections.Generic;

#nullable disable

namespace strategy.Models
{
    public partial class SubmarketCountEval
    {
        public Guid MarketSegmentRegionId { get; set; }
        public int? Ecount { get; set; }
    }
}
