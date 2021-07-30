using System;
using System.Collections.Generic;

#nullable disable

namespace strategy.DbModels
{
    public partial class CrmFiltersCrowd
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string FilterValue { get; set; }
        public long AccountId { get; set; }
        public long CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public long? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public long? DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public long? ProjectId { get; set; }
        public long? CrowdProjectId { get; set; }
        public int? TypeId { get; set; }

        public virtual Account Account { get; set; }
        public virtual CrmCrowdProject CrowdProject { get; set; }
    }
}
