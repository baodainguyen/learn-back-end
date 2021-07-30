using System;
using System.Collections.Generic;

#nullable disable

namespace strategy.DbModels
{
    public partial class CrmAnswerPerson
    {
        public long Id { get; set; }
        public long? CrmAnswerId { get; set; }
        public long? CrmPersonId { get; set; }
        public long? CrmCrowdProjectId { get; set; }
        public string Value { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public long? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public long? DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public bool? IsEdit { get; set; }
        public long? CrmQuestionPersonId { get; set; }
        public string Nr { get; set; }
        public string Article { get; set; }
        public decimal? Price { get; set; }
        public long? StatusId { get; set; }
        public long? CrmActivityId { get; set; }
    }
}
