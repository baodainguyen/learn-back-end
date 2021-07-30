using System;
using System.Collections.Generic;

#nullable disable

namespace strategy.DbModels
{
    public partial class ActionPerson
    {
        public Guid Id { get; set; }
        public Guid ActionId { get; set; }
        public long AccountId { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public long? DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public int TypeId { get; set; }

        public virtual Account Account { get; set; }
        public virtual Action Action { get; set; }
    }
}
