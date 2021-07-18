using System;
using System.Collections.Generic;

#nullable disable

namespace strategy.Models
{
    public partial class IndependencyRegion
    {
        public long Id { get; set; }
        public long? RegionId { get; set; }
        public long? IndependencyId { get; set; }
        public long CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public long? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public long? DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public int? Mindex { get; set; }

        public virtual Independency Independency { get; set; }
    }
}
