﻿using System;
using System.Collections.Generic;

#nullable disable

namespace strategy.DbModels
{
    public partial class DemandTemp
    {
        public Guid Id { get; set; }
        public Guid DemandId { get; set; }
        public Guid? TargetGroupId { get; set; }
        public Guid? TargetGroupTempId { get; set; }
        public Guid TemplateId { get; set; }
        public string Description { get; set; }
        public string DemandText { get; set; }
        public int Importance { get; set; }
        public string ExpectationText { get; set; }
        public bool? IsExpectation { get; set; }
        public int Mdf { get; set; }
        public int Mindex { get; set; }
        public int Type { get; set; }
        public long CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public long? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public long? DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public int CriteriaId { get; set; }
    }
}