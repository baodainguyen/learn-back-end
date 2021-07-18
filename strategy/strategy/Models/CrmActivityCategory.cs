using System;
using System.Collections.Generic;

#nullable disable

namespace strategy.Models
{
    public partial class CrmActivityCategory
    {
        public long Id { get; set; }
        public long CrmActivityId { get; set; }
        public long CategoryId { get; set; }
        public long CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public long? DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
    }
}
