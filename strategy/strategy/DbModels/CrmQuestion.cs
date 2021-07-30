using System;
using System.Collections.Generic;

#nullable disable

namespace strategy.DbModels
{
    public partial class CrmQuestion
    {
        public CrmQuestion()
        {
            CrmAnswers = new HashSet<CrmAnswer>();
            CrmQuestionPeople = new HashSet<CrmQuestionPerson>();
        }

        public long Id { get; set; }
        public int TypeId { get; set; }
        public long? ParentId { get; set; }
        public long? CrmQuestionGroupId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Mdf { get; set; }
        public int Mindex { get; set; }
        public long CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public long? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public long? DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public bool IsMainQuestion { get; set; }
        public bool IsTitle { get; set; }
        public int? LimitedAnswer { get; set; }
        public bool? IsPercent { get; set; }
        public bool IsRequired { get; set; }
        public string Nr { get; set; }
        public string Quantity { get; set; }
        public string Price { get; set; }
        public string Symbol { get; set; }
        public string Article { get; set; }

        public virtual CrmQuestionGroup CrmQuestionGroup { get; set; }
        public virtual ICollection<CrmAnswer> CrmAnswers { get; set; }
        public virtual ICollection<CrmQuestionPerson> CrmQuestionPeople { get; set; }
    }
}
