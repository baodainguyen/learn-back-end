using System;
using System.Collections.Generic;

#nullable disable

namespace strategy.DbModels
{
    public partial class ActionPlanReminder
    {
        public long Id { get; set; }
        public Guid? ParentGuidId { get; set; }
        public long? ParentBigIntId { get; set; }
        public int TypeId { get; set; }
        public int? ReminderDay { get; set; }
        public TimeSpan? ReminderTime { get; set; }
        public string Description { get; set; }
        public string CurrentLang { get; set; }
        public long CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public long? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public long? DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
    }
}
