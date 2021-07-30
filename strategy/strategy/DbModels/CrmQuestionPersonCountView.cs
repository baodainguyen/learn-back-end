using System;
using System.Collections.Generic;

#nullable disable

namespace strategy.DbModels
{
    public partial class CrmQuestionPersonCountView
    {
        public int? Total { get; set; }
        public int? TotalEdit { get; set; }
        public long CrmPersonId { get; set; }
        public long? CrmCrowdProjectId { get; set; }
    }
}
