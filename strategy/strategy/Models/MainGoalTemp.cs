using System;
using System.Collections.Generic;

#nullable disable

namespace strategy.Models
{
    public partial class MainGoalTemp
    {
        public Guid Id { get; set; }
        public long ProjectId { get; set; }
        public Guid? SubMarketProductId { get; set; }
        public long? IndependencyId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public long? Category { get; set; }
        public string Effect { get; set; }
        public DateTime? Date { get; set; }
        public long? Evaluation { get; set; }
        public long? Field { get; set; }
        public bool? Visibility { get; set; }
        public bool? Finish { get; set; }
        public int? Mindex { get; set; }
        public int Mdf { get; set; }
        public long CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public long? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public long? DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public Guid? ParentId { get; set; }
        public DateTime? StartDate { get; set; }
        public decimal? Budget { get; set; }
        public Guid TemplateId { get; set; }
        public string Purpose { get; set; }
        public string Arrived { get; set; }
        public bool? IsCalendar { get; set; }
        public int? ApEvaluation { get; set; }
        public string ApEvaluationComment { get; set; }
        public Guid? ApEvaluationTemplateId { get; set; }
        public Guid? ApSwotanalyseTemplateId { get; set; }
        public Guid? ApProductTemplateId { get; set; }
        public string Mcolor { get; set; }
    }
}
