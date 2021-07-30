using System;
using System.Collections.Generic;

#nullable disable

namespace strategy.DbModels
{
    public partial class CrmStatusProtocolViewLastStatus
    {
        public long CrmId { get; set; }
        public string Name { get; set; }
        public int TypeId { get; set; }
        public DateTime? StatusDate { get; set; }
        public long? StatusId { get; set; }
        public string StatusName { get; set; }
        public long? Rn { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
