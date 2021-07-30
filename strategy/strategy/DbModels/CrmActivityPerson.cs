using System;
using System.Collections.Generic;

#nullable disable

namespace strategy.DbModels
{
    public partial class CrmActivityPerson
    {
        public long Id { get; set; }
        public long CrmActivityId { get; set; }
        public long AccountId { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public long? DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public int? IsRead { get; set; }

        public virtual CrmActivity CrmActivity { get; set; }
    }
}
