﻿using System;
using System.Collections.Generic;

#nullable disable

namespace strategy.Models
{
    public partial class ActionTodoPerson
    {
        public long Id { get; set; }
        public long ActionTodoId { get; set; }
        public long AccountId { get; set; }
        public int TypeId { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public long? DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
    }
}
