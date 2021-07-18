﻿using System;
using System.Collections.Generic;

#nullable disable

namespace strategy.Models
{
    public partial class ActionPlanExpand
    {
        public int Id { get; set; }
        public long AccountId { get; set; }
        public long ProjectId { get; set; }
        public string ExpandValue { get; set; }
        public string ExpandParentValue { get; set; }
        public long CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public long? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public long? DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string ExpandGrandValue { get; set; }
        public int? TypeId { get; set; }
        public string ExpandMaingoalNavValue { get; set; }
        public string ExpandSubgoalValue { get; set; }
    }
}
