using System;
using System.Collections.Generic;

#nullable disable

namespace strategy.DbModels
{
    public partial class CrmGroupQuestionReportView
    {
        public long? CrmPersonId { get; set; }
        public double? Value { get; set; }
        public long? CrmQuestionGroupId { get; set; }
    }
}
