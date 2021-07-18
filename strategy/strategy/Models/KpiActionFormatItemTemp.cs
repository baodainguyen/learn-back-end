using System;
using System.Collections.Generic;

#nullable disable

namespace strategy.Models
{
    public partial class KpiActionFormatItemTemp
    {
        public long KpiFormatTypeId { get; set; }
        public long KpiFormatId { get; set; }
        public Guid ActionId { get; set; }
        public string Mvalue { get; set; }
        public long CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public long? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public long? DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public Guid TemplateId { get; set; }
        public long? Ids { get; set; }
        public long? Id { get; set; }
    }
}
