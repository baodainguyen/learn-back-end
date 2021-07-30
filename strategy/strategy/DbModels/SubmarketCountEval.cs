using System;
using System.Collections.Generic;

#nullable disable

namespace strategy.DbModels
{
    public partial class SubmarketCountEval
    {
        public Guid MarketSegmentRegionId { get; set; }
        public int? Ecount { get; set; }
    }
}
