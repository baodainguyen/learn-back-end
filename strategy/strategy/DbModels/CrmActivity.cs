using System;
using System.Collections.Generic;

#nullable disable

namespace strategy.DbModels
{
    public partial class CrmActivity
    {
        public CrmActivity()
        {
            CrmActivityPeople = new HashSet<CrmActivityPerson>();
            CrmActivityRelationships = new HashSet<CrmActivityRelationship>();
            CrmStatusProtocols = new HashSet<CrmStatusProtocol>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public long? CategoryId { get; set; }
        public long? PriorityId { get; set; }
        public DateTime? StartDate { get; set; }
        public TimeSpan? StartTime { get; set; }
        public DateTime? DueDate { get; set; }
        public TimeSpan? DueTime { get; set; }
        public bool? Finish { get; set; }
        public string Note { get; set; }
        public long? ProjectId { get; set; }
        public int Mdf { get; set; }
        public long CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public long? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public long? DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public Guid? ActionId { get; set; }
        public bool? IsWebForm { get; set; }

        public virtual Project Project { get; set; }
        public virtual ICollection<CrmActivityPerson> CrmActivityPeople { get; set; }
        public virtual ICollection<CrmActivityRelationship> CrmActivityRelationships { get; set; }
        public virtual ICollection<CrmStatusProtocol> CrmStatusProtocols { get; set; }
    }
}
