using System;
using System.Collections.Generic;

#nullable disable

namespace strategy.DbModels
{
    public partial class CrmActivityView
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? StartDate { get; set; }
        public TimeSpan? StartTime { get; set; }
        public DateTime? DueDate { get; set; }
        public TimeSpan? DueTime { get; set; }
        public bool? Finish { get; set; }
        public string CatName { get; set; }
        public string PiorityName { get; set; }
        public string Extension { get; set; }
        public string Note { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public long? ProjectId { get; set; }
        public bool? IsWebForm { get; set; }
    }
}
