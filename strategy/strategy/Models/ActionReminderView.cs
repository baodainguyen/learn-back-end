using System;
using System.Collections.Generic;

#nullable disable

namespace strategy.Models
{
    public partial class ActionReminderView
    {
        public Guid ActionId { get; set; }
        public long? CountValue { get; set; }
    }
}
