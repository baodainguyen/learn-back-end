using System;
using System.Collections.Generic;

#nullable disable

namespace strategy.Models
{
    public partial class CrmLinkQuestion
    {
        public long Id { get; set; }
        public long CrmAnswerId { get; set; }
        public long CrmQuestionId { get; set; }
        public int Mindex { get; set; }
        public long CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public long? DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }

        public virtual CrmAnswer CrmAnswer { get; set; }
    }
}
