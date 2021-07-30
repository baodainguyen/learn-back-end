using System;
using System.Collections.Generic;

#nullable disable

namespace strategy.DbModels
{
    public partial class ReportGoalGetCategoryView
    {
        public Guid GoalId { get; set; }
        public int TypeId { get; set; }
        public string Name { get; set; }
    }
}
