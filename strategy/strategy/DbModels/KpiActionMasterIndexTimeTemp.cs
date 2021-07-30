﻿using System;
using System.Collections.Generic;

#nullable disable

namespace strategy.DbModels
{
    public partial class KpiActionMasterIndexTimeTemp
    {
        public long Id { get; set; }
        public long? KpiActionMasterIndexId { get; set; }
        public long? KpiActionMasterTimeId { get; set; }
        public decimal? KpiValue { get; set; }
        public long CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public long? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public long? DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public Guid TemplateId { get; set; }
    }
}