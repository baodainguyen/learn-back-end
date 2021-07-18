﻿using System;
using System.Collections.Generic;

#nullable disable

namespace strategy.Models
{
    public partial class Independency
    {
        public Independency()
        {
            IndependencyRegions = new HashSet<IndependencyRegion>();
            MainGoals = new HashSet<MainGoal>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public long ProjectId { get; set; }
        public long CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public long? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public long? DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public long? ParentId { get; set; }
        public int? Mdf { get; set; }
        public int? Mindex { get; set; }
        public bool? SelectAllRegion { get; set; }
        public bool IsMasterGoal { get; set; }
        public long? CurrencyId { get; set; }
        public bool? IsMasterGoalKpi { get; set; }
        public bool IsMaingoalNav { get; set; }

        public virtual Project Project { get; set; }
        public virtual ICollection<IndependencyRegion> IndependencyRegions { get; set; }
        public virtual ICollection<MainGoal> MainGoals { get; set; }
    }
}
