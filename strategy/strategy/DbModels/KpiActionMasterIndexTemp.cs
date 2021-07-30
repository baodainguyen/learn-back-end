using System;
using System.Collections.Generic;

#nullable disable

namespace strategy.DbModels
{
    public partial class KpiActionMasterIndexTemp
    {
        public long Id { get; set; }
        public long? LongLinkId { get; set; }
        public Guid? GuidLinkId { get; set; }
        public long? KpiUnitId { get; set; }
        public decimal? KpiPercent { get; set; }
        public decimal? ImplementPercent { get; set; }
        public decimal? ExpectedValue { get; set; }
        public decimal? LstValue { get; set; }
        public long KpiActionMasterTopicId { get; set; }
        public long CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public long? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public long? DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public int? TypeId { get; set; }
        public int? Mindex { get; set; }
        public Guid? TemplateId { get; set; }
    }
}
