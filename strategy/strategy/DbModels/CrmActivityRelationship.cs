using System;
using System.Collections.Generic;

#nullable disable

namespace strategy.DbModels
{
    public partial class CrmActivityRelationship
    {
        public long Id { get; set; }
        public long CrmActivityId { get; set; }
        public long CrmId { get; set; }
        public int? TypeId { get; set; }
        public long? CategoryId { get; set; }
        public long CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public long? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public long? DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public int Mdf { get; set; }
        public long? RoleId { get; set; }
        public int Mindex { get; set; }

        public virtual CrmActivity CrmActivity { get; set; }
    }
}
