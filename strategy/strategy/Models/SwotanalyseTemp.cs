using System;
using System.Collections.Generic;

#nullable disable

namespace strategy.Models
{
    public partial class SwotanalyseTemp
    {
        public Guid Id { get; set; }
        public Guid? TemplateId { get; set; }
        public Guid? SubMarketProductId { get; set; }
        public int GroupType { get; set; }
        public string Name { get; set; }
        public int Mindex { get; set; }
        public int Mdf { get; set; }
        public long CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public long? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public long? ProjectId { get; set; }
        public long? DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public long? SwotTemplateId { get; set; }
    }
}
