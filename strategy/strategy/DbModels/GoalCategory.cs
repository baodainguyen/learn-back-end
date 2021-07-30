using System;
using System.Collections.Generic;

#nullable disable

namespace strategy.DbModels
{
    public partial class GoalCategory
    {
        public Guid Id { get; set; }
        public Guid GoalId { get; set; }
        public long CategoryId { get; set; }
        public int TypeId { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public long? DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
    }
}
