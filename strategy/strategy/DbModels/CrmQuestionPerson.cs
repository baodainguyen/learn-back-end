using System;
using System.Collections.Generic;

#nullable disable

namespace strategy.DbModels
{
    public partial class CrmQuestionPerson
    {
        public long Id { get; set; }
        public long CrmQuestionId { get; set; }
        public long CrmPersonId { get; set; }
        public long? CrmCrowdProjectId { get; set; }
        public int? Mindex { get; set; }
        public bool? IsEdit { get; set; }
        public long? DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public long? CrmParentAnswerId { get; set; }
        public long? CrmAnswerPersonId { get; set; }
        public bool IsHide { get; set; }
        public long? StatusId { get; set; }
        public long? CrmActivityId { get; set; }

        public virtual CrmQuestion CrmQuestion { get; set; }
    }
}
