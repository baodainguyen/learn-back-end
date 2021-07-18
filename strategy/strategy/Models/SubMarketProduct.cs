using System;
using System.Collections.Generic;

#nullable disable

namespace strategy.Models
{
    public partial class SubMarketProduct
    {
        public SubMarketProduct()
        {
            DemandCharts = new HashSet<DemandChart>();
            MainGoals = new HashSet<MainGoal>();
            ProductCompetitions = new HashSet<ProductCompetition>();
            ProductEvaluations = new HashSet<ProductEvaluation>();
            ProductFinances = new HashSet<ProductFinance>();
            ProductPositions = new HashSet<ProductPosition>();
            SubMarketProductAccounts = new HashSet<SubMarketProductAccount>();
            TargetGroups = new HashSet<TargetGroup>();
        }

        public Guid Id { get; set; }
        public long ProductId { get; set; }
        public long SubMarketId { get; set; }
        public Guid? EvaluationTemplateId { get; set; }
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
        public bool? IsEdit { get; set; }
        public Guid? ProductTemplateId { get; set; }
        public Guid? CompetitionTemplateId { get; set; }
        public bool? IsNotRelative { get; set; }
        public bool? IsMasterGoalKpi { get; set; }
        public bool IsMaingoalNav { get; set; }

        public virtual Template EvaluationTemplate { get; set; }
        public virtual Product Product { get; set; }
        public virtual SubMarket SubMarket { get; set; }
        public virtual ICollection<DemandChart> DemandCharts { get; set; }
        public virtual ICollection<MainGoal> MainGoals { get; set; }
        public virtual ICollection<ProductCompetition> ProductCompetitions { get; set; }
        public virtual ICollection<ProductEvaluation> ProductEvaluations { get; set; }
        public virtual ICollection<ProductFinance> ProductFinances { get; set; }
        public virtual ICollection<ProductPosition> ProductPositions { get; set; }
        public virtual ICollection<SubMarketProductAccount> SubMarketProductAccounts { get; set; }
        public virtual ICollection<TargetGroup> TargetGroups { get; set; }
    }
}
