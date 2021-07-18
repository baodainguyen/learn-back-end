using System;
using System.Collections.Generic;

#nullable disable

namespace strategy.Models
{
    public partial class AccountLastAction
    {
        public long Id { get; set; }
        public long ProjectId { get; set; }
        public long AccountId { get; set; }
        public int CodeLastActionId { get; set; }
        public string Value { get; set; }
        public long DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
    }
}
