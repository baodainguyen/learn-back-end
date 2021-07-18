using System;
using System.Collections.Generic;

#nullable disable

namespace strategy.Models
{
    public partial class AccountRole
    {
        public long Id { get; set; }
        public long AccountId { get; set; }
        public int RoleId { get; set; }
        public long? ProjectGroupId { get; set; }
        public long? ProjectId { get; set; }
        public long? StrategyId { get; set; }
        public long CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public long? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public long? DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public long? RegionId { get; set; }
        public long? LandId { get; set; }
        public long? TabId { get; set; }

        public virtual Account Account { get; set; }
        public virtual Role Role { get; set; }
    }
}
