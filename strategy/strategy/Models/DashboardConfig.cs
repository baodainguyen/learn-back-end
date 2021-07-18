using System;
using System.Collections.Generic;

#nullable disable

namespace strategy.Models
{
    public partial class DashboardConfig
    {
        public long Id { get; set; }
        public long AccountId { get; set; }
        public long ProjectId { get; set; }
        public int Type { get; set; }
        public string Mkey { get; set; }
        public string Value { get; set; }
    }
}
