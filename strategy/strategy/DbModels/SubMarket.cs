using System;
using System.Collections.Generic;

#nullable disable

namespace strategy.DbModels
{
    public partial class SubMarket
    {
        public SubMarket()
        {
            SubMarketLabels = new HashSet<SubMarketLabel>();
            SubMarketProducts = new HashSet<SubMarketProduct>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Guid MarketSegmentRegionId { get; set; }
        public int Type { get; set; }
        public int Mindex { get; set; }
        public int Mdf { get; set; }
        public long CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public long? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public long? DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public Guid? GroupId { get; set; }
        public bool? IsRelation { get; set; }
        public bool? IsSubClient { get; set; }
        public long? OrganisationId { get; set; }
        public bool? Isxy { get; set; }

        public virtual MarketSegmentRegion MarketSegmentRegion { get; set; }
        public virtual ICollection<SubMarketLabel> SubMarketLabels { get; set; }
        public virtual ICollection<SubMarketProduct> SubMarketProducts { get; set; }
    }
}
