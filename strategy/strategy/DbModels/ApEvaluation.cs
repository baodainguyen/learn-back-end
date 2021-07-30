﻿using System;
using System.Collections.Generic;

#nullable disable

namespace strategy.DbModels
{
    public partial class ApEvaluation
    {
        public long Id { get; set; }
        public Guid ActionGoalId { get; set; }
        public int? CriteriaId { get; set; }
        public string Name { get; set; }
        public int Priority { get; set; }
        public int Evaluation { get; set; }
        public int Mindex { get; set; }
        public long CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public long? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public long DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public int Mdf { get; set; }
        public int TypeId { get; set; }
    }
}