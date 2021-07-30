using System;
using System.Collections.Generic;

#nullable disable

namespace strategy.DbModels
{
    public partial class DashboardAccount
    {
        public Guid Id { get; set; }
        public Guid RadarId { get; set; }
        public long AccountId { get; set; }
        public int Type { get; set; }
    }
}
