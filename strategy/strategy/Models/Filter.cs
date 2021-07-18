using System;
using System.Collections.Generic;

#nullable disable

namespace strategy.Models
{
    public partial class Filter
    {
        public int Id { get; set; }
        public long AccountId { get; set; }
        public int Type { get; set; }
        public long ProjectId { get; set; }
        public int? LandType { get; set; }
        public long? LandId { get; set; }
        public long? RegionId { get; set; }
        public string FilterValue { get; set; }
        public long CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public long? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public long? DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string Name { get; set; }
        public bool? IsUsing { get; set; }
        public string SubFilterValue { get; set; }
    }
}
