using System;
using System.Collections.Generic;

#nullable disable

namespace strategy.Models
{
    public partial class KpiUnit
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public int TypeId { get; set; }
        public string Symbol { get; set; }
        public int? PositionId { get; set; }
        public int? OrderId { get; set; }
        public long ProjectId { get; set; }
        public string Description { get; set; }
        public long CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public long? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public long? DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public int? Mindex { get; set; }
        public bool? IsContact { get; set; }
        public bool? IsRevenue { get; set; }
        public bool? IsTurnover { get; set; }
    }
}
