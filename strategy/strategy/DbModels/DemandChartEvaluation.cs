using System;
using System.Collections.Generic;

#nullable disable

namespace strategy.DbModels
{
    public partial class DemandChartEvaluation
    {
        public Guid Id { get; set; }
        public Guid? DemandId { get; set; }
        public Guid? DemandChartId { get; set; }
        public int? Value { get; set; }
        public int Mdf { get; set; }
        public long CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public long? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public long? DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }

        public virtual Demand Demand { get; set; }
        public virtual DemandChart DemandChart { get; set; }
    }
}
