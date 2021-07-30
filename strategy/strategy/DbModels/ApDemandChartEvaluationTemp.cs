using System;
using System.Collections.Generic;

#nullable disable

namespace strategy.DbModels
{
    public partial class ApDemandChartEvaluationTemp
    {
        public long Id { get; set; }
        public long DemandId { get; set; }
        public long DemandChartId { get; set; }
        public int? Value { get; set; }
        public long CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public long? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public long? DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public Guid TemplateId { get; set; }
    }
}
