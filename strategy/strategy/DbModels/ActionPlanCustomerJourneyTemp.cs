using System;
using System.Collections.Generic;

#nullable disable

namespace strategy.DbModels
{
    public partial class ActionPlanCustomerJourneyTemp
    {
        public long? Id { get; set; }
        public Guid GoalActionId { get; set; }
        public int GoalActionTypeId { get; set; }
        public long CustomerJourneyId { get; set; }
        public int TypeId { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public long? DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public Guid TemplateId { get; set; }
    }
}
