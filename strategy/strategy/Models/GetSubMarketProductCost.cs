using System;
using System.Collections.Generic;

#nullable disable

namespace strategy.Models
{
    public partial class GetSubMarketProductCost
    {
        public double? Cost { get; set; }
        public double? Income { get; set; }
        public string Name { get; set; }
        public long SubMarketId { get; set; }
    }
}
