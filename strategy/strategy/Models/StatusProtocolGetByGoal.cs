using System;
using System.Collections.Generic;

#nullable disable

namespace strategy.Models
{
    public partial class StatusProtocolGetByGoal
    {
        public Guid Id { get; set; }
        public Guid? GoalId { get; set; }
        public int? StatusId { get; set; }
        public string GoalStatus { get; set; }
        public string StatusDescription { get; set; }
        public DateTime? GoalDate { get; set; }
        public long? Rn { get; set; }
    }
}
