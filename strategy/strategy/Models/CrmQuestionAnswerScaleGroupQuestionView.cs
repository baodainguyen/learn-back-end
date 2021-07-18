using System;
using System.Collections.Generic;

#nullable disable

namespace strategy.Models
{
    public partial class CrmQuestionAnswerScaleGroupQuestionView
    {
        public long Id { get; set; }
        public long? CrmPersonId { get; set; }
        public double? Value { get; set; }
        public long? CrmQuestionGroupId { get; set; }
        public long? CrmCrowdProjectId { get; set; }
        public long CrmQuestionId { get; set; }
        public long? CrmActivityId { get; set; }
    }
}
