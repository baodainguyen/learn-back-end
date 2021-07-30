using System;
using System.Collections.Generic;

#nullable disable

namespace strategy.DbModels
{
    public partial class KpiGoalIndexLinkTemp
    {
        public long? Id { get; set; }
        public long? KpiGoalIndexId { get; set; }
        public long? LinkId { get; set; }
        public int? TypeId { get; set; }
        public long CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public long? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public long? DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public Guid? TemplateId { get; set; }
    }
}
