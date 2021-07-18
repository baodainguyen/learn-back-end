using System;
using System.Collections.Generic;

#nullable disable

namespace strategy.Models
{
    public partial class CrmCrowdProjectPerson
    {
        public long Id { get; set; }
        public long CrmPersonId { get; set; }
        public long CrmCrowdProjectId { get; set; }
        public bool? IsAccess { get; set; }
        public DateTime? FirstTimeLoginDate { get; set; }
        public bool IsReceivedMail { get; set; }
        public DateTime? LastLoginDate { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public long? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public long? DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public bool? IsReadMail { get; set; }
        public long? StatusId { get; set; }
        public long? CrmActivityId { get; set; }
    }
}
