using System;
using System.Collections.Generic;

#nullable disable

namespace strategy.Models
{
    public partial class BoardColumn
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ColorId { get; set; }
        public int Mcount { get; set; }
        public int Mindex { get; set; }
        public long BoardLineId { get; set; }
        public long CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public long? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public long? DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public bool? IsFinish { get; set; }
        public bool? IsDueDate { get; set; }
        public int? AddDays { get; set; }
        public bool? IsShowFinish { get; set; }
        public bool? IsGridView { get; set; }
        public int? SortTypeId { get; set; }
        public bool? IsDesc { get; set; }
        public bool? IsRegion { get; set; }
        public bool? IsXy { get; set; }
        public bool? IsSyncOrder { get; set; }
        public bool? IsDepartment { get; set; }

        public virtual BoardLine BoardLine { get; set; }
    }
}
