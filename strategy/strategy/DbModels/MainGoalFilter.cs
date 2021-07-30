using System;
using System.Collections.Generic;

#nullable disable

namespace strategy.DbModels
{
    public partial class MainGoalFilter
    {
        public long Id { get; set; }
        public long AccountId { get; set; }
        public long ProjectId { get; set; }
        public string MainGoalIds { get; set; }
        public Guid? SubMarketProductId { get; set; }
        public long? IndependencyId { get; set; }
    }
}
