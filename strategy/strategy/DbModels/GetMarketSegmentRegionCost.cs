using System;
using System.Collections.Generic;

#nullable disable

namespace strategy.DbModels
{
    public partial class GetMarketSegmentRegionCost
    {
        public double? Cost { get; set; }
        public double? Income { get; set; }
        public string Name { get; set; }
        public Guid MarketSegmentRegionId { get; set; }
    }
}
