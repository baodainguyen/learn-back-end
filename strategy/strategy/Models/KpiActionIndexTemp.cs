using System;
using System.Collections.Generic;

#nullable disable

namespace strategy.Models
{
    public partial class KpiActionIndexTemp
    {
        public long KpiIndexId { get; set; }
        public int Mindex { get; set; }
        public long CategoryId { get; set; }
        public Guid ActionId { get; set; }
        public decimal? ExpectedValue { get; set; }
        public decimal? LstValue { get; set; }
        public long CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public long? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public long? DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public decimal? KpiPercent { get; set; }
        public Guid TemplateId { get; set; }
        public long? KpiSettingIndexId { get; set; }
        public long? Ids { get; set; }
        public long? Id { get; set; }
        public bool? IsCalculate { get; set; }
        public long? ParentId { get; set; }
    }
}
