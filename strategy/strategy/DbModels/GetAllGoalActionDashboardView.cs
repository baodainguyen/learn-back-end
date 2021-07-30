using System;
using System.Collections.Generic;

#nullable disable

namespace strategy.DbModels
{
    public partial class GetAllGoalActionDashboardView
    {
        public string Name { get; set; }
        public Guid Id { get; set; }
        public int Type { get; set; }
        public Guid? ParentId { get; set; }
        public DateTime? Date { get; set; }
        public long? Person { get; set; }
        public bool? OverDate { get; set; }
        public bool? NonArchive { get; set; }
        public bool? OverCost { get; set; }
        public bool? Finish { get; set; }
        public Guid? SubMarketProductId { get; set; }
        public long? IndependencyId { get; set; }
    }
}
