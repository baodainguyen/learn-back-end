using System;
using System.Collections.Generic;

#nullable disable

namespace strategy.DbModels
{
    public partial class CrmCrowdProjectCc
    {
        public long Id { get; set; }
        public long CrmCrowdProjectId { get; set; }
        public long AccountId { get; set; }
        public byte AccountTypeId { get; set; }
        public byte TypeId { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public long? DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
    }
}
