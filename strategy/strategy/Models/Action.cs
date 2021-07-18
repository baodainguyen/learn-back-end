using System;
using System.Collections.Generic;

#nullable disable

namespace strategy.Models
{
    public partial class Action
    {
        public Action()
        {
            ActionPeople = new HashSet<ActionPerson>();
            ActionUpStreamConnections = new HashSet<ActionUpStreamConnection>();
            StatusProtocols = new HashSet<StatusProtocol>();
        }

        public Guid Id { get; set; }
        public long ProjectId { get; set; }
        public Guid? GoalId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public long? Category { get; set; }
        public long? Instrument { get; set; }
        public DateTime? Start { get; set; }
        public DateTime? End { get; set; }
        public bool Visibility { get; set; }
        public bool IsCalendar { get; set; }
        public bool Finish { get; set; }
        public int? Mindex { get; set; }
        public string ActualEffect { get; set; }
        public string ExpectedEffect { get; set; }
        public decimal? ExpectedCost { get; set; }
        public decimal? ActualCost { get; set; }
        public long? Field { get; set; }
        public int Mdf { get; set; }
        public long CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public long? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public long? DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public long? AdvertisingMaterial { get; set; }
        public long? Advertiser { get; set; }
        public int? NumberOfDay { get; set; }
        public string Color { get; set; }
        public Guid? MasterId { get; set; }
        public string FibuSupplier { get; set; }
        public string FibuDescription { get; set; }
        public long? FibuSupplierId { get; set; }
        public long? SubjetThema { get; set; }
        public long? KpiFormatId { get; set; }
        public Guid? ApEvaluationTemplateId { get; set; }
        public Guid? ApProductTemplateId { get; set; }
        public Guid? ApSwotanalyseTemplateId { get; set; }
        public string ApEvaluationComment { get; set; }
        public int? ApEvaluation { get; set; }
        public long? ActionPlanColumnId { get; set; }
        public long? BoardColumnId { get; set; }

        public virtual MainGoal Goal { get; set; }
        public virtual ICollection<ActionPerson> ActionPeople { get; set; }
        public virtual ICollection<ActionUpStreamConnection> ActionUpStreamConnections { get; set; }
        public virtual ICollection<StatusProtocol> StatusProtocols { get; set; }
    }
}
