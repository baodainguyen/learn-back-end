using System;
using System.Collections.Generic;

#nullable disable

namespace strategy.DbModels
{
    public partial class KpiOutcomeIndexTimeTemp
    {
        public long Id { get; set; }
        public long? KpiActionIndexId { get; set; }
        public long? KpiOutcomeTimeId { get; set; }
        public decimal? KpiValue { get; set; }
        public long CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public long? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public long? DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public Guid TemplateId { get; set; }
    }
}
