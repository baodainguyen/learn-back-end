using System;
using System.Collections.Generic;

#nullable disable

namespace strategy.DbModels
{
    public partial class SubMarketProductAccount
    {
        public long Id { get; set; }
        public Guid SubMarketProductId { get; set; }
        public long AccountId { get; set; }
        public long CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public long? DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }

        public virtual Account Account { get; set; }
        public virtual SubMarketProduct SubMarketProduct { get; set; }
    }
}
