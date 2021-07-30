using System;
using System.Collections.Generic;

#nullable disable

namespace strategy.DbModels
{
    public partial class ActionPlanLink
    {
        public long Id { get; set; }
        public Guid? GoalActionId { get; set; }
        public Guid? LinkId { get; set; }
        public int GoalActionTypeId { get; set; }
        public int LinkTypeId { get; set; }
        public long CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public long? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public long? DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public int? Mindex { get; set; }
    }
}
