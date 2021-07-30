using System;
using System.Collections.Generic;

#nullable disable

namespace strategy.DbModels
{
    public partial class CrmFilter
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string FilterValue { get; set; }
        public long AccountId { get; set; }
        public long CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public long? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public long? DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public long? ProjectId { get; set; }
        public int? TypeId { get; set; }
        public int? StandardId { get; set; }
        public bool? IsNavigation { get; set; }
        public bool? IsShare { get; set; }
        public string Mcolor { get; set; }
        public int? Mindex { get; set; }
        public long? CrmFilterLanId { get; set; }
        public int? Mcount { get; set; }

        public virtual Account Account { get; set; }
        public virtual Project Project { get; set; }
    }
}
