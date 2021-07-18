using System;
using System.Collections.Generic;

#nullable disable

namespace strategy.Models
{
    public partial class FolderFileAssignReport
    {
        public long Id { get; set; }
        public Guid FolderFileAssignId { get; set; }
        public long CrmCrowdProjectId { get; set; }
        public long CrmPersonId { get; set; }
        public int? TypeId { get; set; }
        public long? StatusId { get; set; }
        public long? CrmActivityId { get; set; }

        public virtual FolderFieldAssign FolderFileAssign { get; set; }
    }
}
