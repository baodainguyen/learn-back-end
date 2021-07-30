using System;
using System.Collections.Generic;

#nullable disable

namespace strategy.DbModels
{
    public partial class SubMarketLabel
    {
        public Guid Id { get; set; }
        public long SubMarketId { get; set; }
        public long LabelId { get; set; }
        public string Text { get; set; }
        public int Mdf { get; set; }
        public long CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public long? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public long? DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }

        public virtual Label Label { get; set; }
        public virtual SubMarket SubMarket { get; set; }
    }
}
