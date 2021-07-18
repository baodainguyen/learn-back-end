using System;
using System.Collections.Generic;

#nullable disable

namespace strategy.Models
{
    public partial class CrmTagMapping
    {
        public long Id { get; set; }
        public long CrmTagId { get; set; }
        public long CrmTagCrowdId { get; set; }
        public long? CrmCrowdProjectId { get; set; }
        public long CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public long? DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public long? CrmPersonId { get; set; }
        public long? StatusId { get; set; }
        public long? CrmActivityId { get; set; }

        public virtual CrmCrowdProject CrmCrowdProject { get; set; }
        public virtual CrmTag CrmTag { get; set; }
    }
}
