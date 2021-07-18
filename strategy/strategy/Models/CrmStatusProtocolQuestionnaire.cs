using System;
using System.Collections.Generic;

#nullable disable

namespace strategy.Models
{
    public partial class CrmStatusProtocolQuestionnaire
    {
        public long CrmActivityId { get; set; }
        public DateTime? DueDate { get; set; }
        public long CrmStatusProtocolId { get; set; }
        public long? StatusId { get; set; }
        public bool? IsOpenQuestion { get; set; }
        public bool? IsSend { get; set; }
        public long CrmCrowdProjectId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public long? CrmFragensetId { get; set; }
        public bool? IsManualSend { get; set; }
        public bool? IsAutoSend { get; set; }
        public bool? IsUserSoftware { get; set; }
        public decimal? Qday { get; set; }
        public TimeSpan? Qtime { get; set; }
    }
}
