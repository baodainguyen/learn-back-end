using System;
using System.Collections.Generic;

#nullable disable

namespace strategy.DbModels
{
    public partial class CrmAnswer
    {
        public CrmAnswer()
        {
            CrmLinkQuestions = new HashSet<CrmLinkQuestion>();
        }

        public long Id { get; set; }
        public long CrmQuestionId { get; set; }
        public string Name { get; set; }
        public long? LinkQuestionId { get; set; }
        public int Mdf { get; set; }
        public int? Mindex { get; set; }
        public long CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public long? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public long? DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string Description { get; set; }
        public string Nr { get; set; }
        public decimal? Price { get; set; }
        public string Article { get; set; }

        public virtual CrmQuestion CrmQuestion { get; set; }
        public virtual CrmAnswerOption CrmAnswerOption { get; set; }
        public virtual ICollection<CrmLinkQuestion> CrmLinkQuestions { get; set; }
    }
}
