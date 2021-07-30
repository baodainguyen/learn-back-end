using System;
using System.Collections.Generic;

#nullable disable

namespace strategy.DbModels
{
    public partial class ApDemand
    {
        public long Id { get; set; }
        public long TargetGroupId { get; set; }
        public string Description { get; set; }
        public string DemandText { get; set; }
        public int Importance { get; set; }
        public string ExpectationText { get; set; }
        public bool IsExpectation { get; set; }
        public int Mindex { get; set; }
        public int TypeId { get; set; }
        public long CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public long? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public long? DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public int? CriteriaId { get; set; }
    }
}
