using System;
using System.Collections.Generic;

#nullable disable

namespace strategy.DbModels
{
    public partial class Region
    {
        public Region()
        {
            Labels = new HashSet<Label>();
            MarketSegmentRegions = new HashSet<MarketSegmentRegion>();
            ProductGroups = new HashSet<ProductGroup>();
        }

        public long Id { get; set; }
        public long LandId { get; set; }
        public string Name { get; set; }
        public int Mindex { get; set; }
        public int Mdf { get; set; }
        public long CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public long? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public long? DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public string Description { get; set; }
        public int? Type { get; set; }
        public long? CurrencyId { get; set; }
        public bool? IsRelation { get; set; }
        public bool? IsMaster { get; set; }

        public virtual Land Land { get; set; }
        public virtual ICollection<Label> Labels { get; set; }
        public virtual ICollection<MarketSegmentRegion> MarketSegmentRegions { get; set; }
        public virtual ICollection<ProductGroup> ProductGroups { get; set; }
    }
}
