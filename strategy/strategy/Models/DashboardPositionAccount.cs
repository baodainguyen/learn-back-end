using System;
using System.Collections.Generic;

#nullable disable

namespace strategy.Models
{
    public partial class DashboardPositionAccount
    {
        public long Id { get; set; }
        public string Position { get; set; }
        public long AccountId { get; set; }
        public long ProjectId { get; set; }
        public int TypeId { get; set; }
    }
}
