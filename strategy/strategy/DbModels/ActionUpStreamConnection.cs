using System;
using System.Collections.Generic;

#nullable disable

namespace strategy.DbModels
{
    public partial class ActionUpStreamConnection
    {
        public long Id { get; set; }
        public long ProjectId { get; set; }
        public Guid? UpActionId { get; set; }
        public Guid ActionId { get; set; }
        public int? TypeId { get; set; }
        public DateTime CreatedDate { get; set; }
        public long CreatedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public long? DeletedBy { get; set; }
        public long? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual Action Action { get; set; }
    }
}
