using System;
using System.Collections.Generic;

#nullable disable

namespace strategy.DbModels
{
    public partial class CrmStatusProtocolView
    {
        public long CrmActivityId { get; set; }
        public string StatusName { get; set; }
        public string StatusDescription { get; set; }
    }
}
