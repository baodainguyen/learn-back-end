using System;
using System.Collections.Generic;

#nullable disable

namespace strategy.Models
{
    public partial class BoardFilter
    {
        public long Id { get; set; }
        public long BoardLineId { get; set; }
        public int TypeId { get; set; }
        public int ActionPlanTypeId { get; set; }
        public string FilterValue { get; set; }
        public long ProjectId { get; set; }
        public long CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public long? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public long? DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public long? DependBoardLineId { get; set; }
        public long? DependBoardNameId { get; set; }

        public virtual BoardLine BoardLine { get; set; }
    }
}
