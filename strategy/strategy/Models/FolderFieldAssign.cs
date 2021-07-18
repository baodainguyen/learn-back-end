using System;
using System.Collections.Generic;

#nullable disable

namespace strategy.Models
{
    public partial class FolderFieldAssign
    {
        public FolderFieldAssign()
        {
            FolderFileAssignReports = new HashSet<FolderFileAssignReport>();
        }

        public Guid Id { get; set; }
        public long FolderFiIeId { get; set; }
        public long? AssignIdI { get; set; }
        public Guid? AssignIdU { get; set; }
        public string Type { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public long? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public long? DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public bool? FromAssigned { get; set; }

        public virtual ICollection<FolderFileAssignReport> FolderFileAssignReports { get; set; }
    }
}
