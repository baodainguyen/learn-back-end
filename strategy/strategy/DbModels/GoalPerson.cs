using System;
using System.Collections.Generic;

#nullable disable

namespace strategy.DbModels
{
    public partial class GoalPerson
    {
        public Guid Id { get; set; }
        public Guid GoalId { get; set; }
        public long AccountId { get; set; }
        public long CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public long? DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public int? Mdf { get; set; }

        public virtual Account Account { get; set; }
        public virtual MainGoal Goal { get; set; }
    }
}
