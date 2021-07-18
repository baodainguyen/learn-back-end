using System;
using System.Collections.Generic;

#nullable disable

namespace strategy.Models
{
    public partial class GetExpectedCostBySubGoalView
    {
        public decimal? Cost { get; set; }
        public Guid Id { get; set; }
    }
}
