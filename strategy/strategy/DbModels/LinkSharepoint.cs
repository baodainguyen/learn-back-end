using System;
using System.Collections.Generic;

#nullable disable

namespace strategy.DbModels
{
    public partial class LinkSharepoint
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public int TypeId { get; set; }
        public long CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsActive { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string OptionColumn { get; set; }
        public long FilterId { get; set; }
        public long ProjectId { get; set; }
        public string Language { get; set; }
        public int ViewTypeId { get; set; }
        public long? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public long? DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string FilterSnapshot { get; set; }
    }
}
