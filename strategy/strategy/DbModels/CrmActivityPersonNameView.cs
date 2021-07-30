using System;
using System.Collections.Generic;

#nullable disable

namespace strategy.DbModels
{
    public partial class CrmActivityPersonNameView
    {
        public long CrmActivityId { get; set; }
        public string DearPersonName { get; set; }
        public long? OrgId { get; set; }
    }
}
