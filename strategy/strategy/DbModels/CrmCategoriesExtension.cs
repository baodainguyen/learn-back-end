using System;
using System.Collections.Generic;

#nullable disable

namespace strategy.DbModels
{
    public partial class CrmCategoriesExtension
    {
        public long Id { get; set; }
        public long CrmCategoriesId { get; set; }
        public int TypeId { get; set; }
        public long CrmId { get; set; }
        public long CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public long? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public long? DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string Note { get; set; }
        public bool? IsManualSend { get; set; }
        public decimal? Qday { get; set; }
        public TimeSpan? Qtime { get; set; }
        public bool? IsUserSoftware { get; set; }
        public bool? IsAutoSend { get; set; }
    }
}
