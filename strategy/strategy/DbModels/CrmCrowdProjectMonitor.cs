﻿using System;
using System.Collections.Generic;

#nullable disable

namespace strategy.DbModels
{
    public partial class CrmCrowdProjectMonitor
    {
        public long Id { get; set; }
        public long CrmCrowdProjectId { get; set; }
        public long AccountId { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public long? DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
    }
}