using System;
using System.Collections.Generic;

#nullable disable

namespace strategy.Models
{
    public partial class KpiFormatItemValue
    {
        public long Id { get; set; }
        public long? KpiFormatItemId { get; set; }
        public long? Bid { get; set; }
        public Guid? Gid { get; set; }
        public int? TypeId { get; set; }
        public long CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public long? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public long? DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public long FtypeId { get; set; }
    }
}
