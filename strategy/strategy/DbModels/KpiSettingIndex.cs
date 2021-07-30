using System;
using System.Collections.Generic;

#nullable disable

namespace strategy.DbModels
{
    public partial class KpiSettingIndex
    {
        public long Id { get; set; }
        public long KpiIndexId { get; set; }
        public int Mindex { get; set; }
        public long? CategoryId { get; set; }
        public decimal? ExpectedValue { get; set; }
        public long CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public long? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public long? DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public bool? IsKpiDefault { get; set; }
    }
}
