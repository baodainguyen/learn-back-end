using System;
using System.Collections.Generic;

#nullable disable

namespace strategy.Models
{
    public partial class SubMarketProductAccountTemp
    {
        public long Id { get; set; }
        public Guid SubMarketProductTempId { get; set; }
        public Guid? TemplateId { get; set; }
        public long AccountId { get; set; }
        public long CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public long? DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
    }
}
