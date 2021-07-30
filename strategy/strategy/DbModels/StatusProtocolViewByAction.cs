using System;
using System.Collections.Generic;

#nullable disable

namespace strategy.DbModels
{
    public partial class StatusProtocolViewByAction
    {
        public Guid Id { get; set; }
        public Guid? ActionId { get; set; }
        public int? StatusId { get; set; }
        public string ActionStatus { get; set; }
        public string ActionStatusDescription { get; set; }
        public DateTime? ActionStatusDate { get; set; }
        public long? Rn { get; set; }
    }
}
