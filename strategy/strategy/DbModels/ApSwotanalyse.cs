﻿using System;
using System.Collections.Generic;

#nullable disable

namespace strategy.DbModels
{
    public partial class ApSwotanalyse
    {
        public long Id { get; set; }
        public Guid ActionGoalId { get; set; }
        public int TypeId { get; set; }
        public string Name { get; set; }
        public int Mindex { get; set; }
        public long CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public long? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public long? DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
    }
}