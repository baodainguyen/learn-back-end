using System;
using System.Collections.Generic;

#nullable disable

namespace strategy.Models
{
    public partial class CrmPersonReminder
    {
        public long Id { get; set; }
        public long AccountId { get; set; }
        public long CrmPersonId { get; set; }
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
