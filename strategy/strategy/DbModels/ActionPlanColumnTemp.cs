using System;
using System.Collections.Generic;

#nullable disable

namespace strategy.DbModels
{
    public partial class ActionPlanColumnTemp
    {
        public long Id { get; set; }
        public Guid GoalId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? Mindex { get; set; }
        public int? Mcount { get; set; }
        public long? CustomerJourneyId { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public long? DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public long? ModifiedBy { get; set; }
        public Guid TemplateId { get; set; }
    }
}
