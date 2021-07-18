using System;
using System.Collections.Generic;

#nullable disable

namespace strategy.Models
{
    public partial class GetProductFinanceCost
    {
        public double? Cost { get; set; }
        public double? Income { get; set; }
        public string Name { get; set; }
        public Guid SubMarketProductId { get; set; }
    }
}
