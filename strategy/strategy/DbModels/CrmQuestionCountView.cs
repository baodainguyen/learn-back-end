using System;
using System.Collections.Generic;

#nullable disable

namespace strategy.DbModels
{
    public partial class CrmQuestionCountView
    {
        public long? CrmQuestionGroupId { get; set; }
        public long CrmPersonId { get; set; }
        public int? QuestionCount { get; set; }
    }
}
