using System;
using System.Collections.Generic;

#nullable disable

namespace strategy.DbModels
{
    public partial class MaingoalReminderView
    {
        public long ReminderId { get; set; }
        public Guid MaingoalId { get; set; }
    }
}
