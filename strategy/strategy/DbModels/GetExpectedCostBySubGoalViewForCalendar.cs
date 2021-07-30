using System;
using System.Collections.Generic;

#nullable disable

namespace strategy.DbModels
{
    public partial class GetExpectedCostBySubGoalViewForCalendar
    {
        public decimal? Cost { get; set; }
        public Guid Id { get; set; }
    }
}
