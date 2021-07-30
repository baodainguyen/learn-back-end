using System;
using System.Collections.Generic;

#nullable disable

namespace strategy.DbModels
{
    public partial class LandCostView
    {
        public long LandId { get; set; }
        public double? Income { get; set; }
        public double? Cost { get; set; }
        public string Year { get; set; }
    }
}
