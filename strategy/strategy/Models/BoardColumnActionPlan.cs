using System;
using System.Collections.Generic;

#nullable disable

namespace strategy.Models
{
    public partial class BoardColumnActionPlan
    {
        public long Id { get; set; }
        public long BoardColumnId { get; set; }
        public Guid GoalActionId { get; set; }
        public int TypeId { get; set; }
        public int? Mindex { get; set; }
        public long CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public long? DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public long? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
