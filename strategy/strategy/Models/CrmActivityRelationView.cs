using System;
using System.Collections.Generic;

#nullable disable

namespace strategy.Models
{
    public partial class CrmActivityRelationView
    {
        public long CrmActivityId { get; set; }
        public long CrmId { get; set; }
        public long Id { get; set; }
        public string ActivityName { get; set; }
        public long? CategoryId { get; set; }
        public long? PriorityId { get; set; }
        public DateTime? StartDate { get; set; }
        public TimeSpan? StartTime { get; set; }
        public DateTime? DueDate { get; set; }
        public TimeSpan? DueTime { get; set; }
        public bool? Finish { get; set; }
        public string Note { get; set; }
        public string CatActivityName { get; set; }
    }
}
