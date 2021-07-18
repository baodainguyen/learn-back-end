using System;
using System.Collections.Generic;

#nullable disable

namespace strategy.Models
{
    public partial class MarketSegmentCostView
    {
        public long MarketSegmentId { get; set; }
        public long RegionId { get; set; }
        public double? Income { get; set; }
        public double? Cost { get; set; }
        public string Year { get; set; }
    }
}
