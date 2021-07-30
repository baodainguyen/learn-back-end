using System;
using System.Collections.Generic;

#nullable disable

namespace strategy.DbModels
{
    public partial class CrmThema
    {
        public CrmThema()
        {
            CrmQuestionGroups = new HashSet<CrmQuestionGroup>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public long CrmFragensetId { get; set; }
        public int Mdf { get; set; }
        public int Mindex { get; set; }
        public long CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public long? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public long? DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }

        public virtual CrmFragenset CrmFragenset { get; set; }
        public virtual ICollection<CrmQuestionGroup> CrmQuestionGroups { get; set; }
    }
}
