using System;
using System.Collections.Generic;

#nullable disable

namespace strategy.DbModels
{
    public partial class Label
    {
        public Label()
        {
            SubMarketLabels = new HashSet<SubMarketLabel>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Mindex { get; set; }
        public long RegionId { get; set; }
        public long ProjectId { get; set; }
        public int Mdf { get; set; }
        public long CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public long? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public long? DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }

        public virtual Project Project { get; set; }
        public virtual Region Region { get; set; }
        public virtual ICollection<SubMarketLabel> SubMarketLabels { get; set; }
    }
}
