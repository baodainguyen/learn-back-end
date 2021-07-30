using System;
using System.Collections.Generic;

#nullable disable

namespace strategy.DbModels
{
    public partial class ActionPlanRegion
    {
        public long Id { get; set; }
        public Guid? GoalActionId { get; set; }
        public int? GoalActionTypeId { get; set; }
        public long RegionId { get; set; }
        public bool IsCheck { get; set; }
        public long CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public long? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public long? DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
    }
}
