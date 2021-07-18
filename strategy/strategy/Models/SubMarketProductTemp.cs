using System;
using System.Collections.Generic;

#nullable disable

namespace strategy.Models
{
    public partial class SubMarketProductTemp
    {
        public Guid Id { get; set; }
        public Guid TemplateId { get; set; }
        public long ProductId { get; set; }
        public long SubMarketId { get; set; }
        public string EvaluationComment { get; set; }
        public int EvaluationResult { get; set; }
        public int Mdf { get; set; }
        public long CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public long? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public long? StrategyId { get; set; }
        public string CompetitionComment { get; set; }
        public int? MarketGrowth { get; set; }
        public int? RelativeMarketShare { get; set; }
        public long? DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public Guid? EvaluationTemplateId { get; set; }
        public Guid? ProductTemplateId { get; set; }
        public Guid? CompetitionTemplateId { get; set; }
    }
}
