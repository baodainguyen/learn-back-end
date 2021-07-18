using System;
using System.Collections.Generic;

#nullable disable

namespace strategy.Models
{
    public partial class ActionPlanSubProduct
    {
        public long Id { get; set; }
        public Guid GoalActionId { get; set; }
        public int GoalActionTypeId { get; set; }
        public long SubProductId { get; set; }
        public int TypeId { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public long? DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
    }
}
