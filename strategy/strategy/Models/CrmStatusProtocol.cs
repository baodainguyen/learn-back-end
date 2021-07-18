using System;
using System.Collections.Generic;

#nullable disable

namespace strategy.Models
{
    public partial class CrmStatusProtocol
    {
        public long Id { get; set; }
        public DateTime? Date { get; set; }
        public long? StatusId { get; set; }
        public string Description { get; set; }
        public int? Mdf { get; set; }
        public long CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public long? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public long? DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public long CrmActivityId { get; set; }
        public long? CrmPersonId { get; set; }
        public long? AccountId { get; set; }
        public bool? IsUpdateWord { get; set; }
        public long? FolderFileId { get; set; }
        public bool? IsOpenQuestion { get; set; }
        public bool? IsCheck { get; set; }
        public bool? IsSend { get; set; }

        public virtual CrmActivity CrmActivity { get; set; }
    }
}
