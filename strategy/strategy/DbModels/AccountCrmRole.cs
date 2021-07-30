using System;
using System.Collections.Generic;

#nullable disable

namespace strategy.DbModels
{
    public partial class AccountCrmRole
    {
        public long Id { get; set; }
        public long AccountId { get; set; }
        public int RoleId { get; set; }
        public long LandId { get; set; }
        public long? FromId { get; set; }
        public long? ToId { get; set; }
        public long ProjectId { get; set; }
        public long CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public long? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public long? DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
    }
}
