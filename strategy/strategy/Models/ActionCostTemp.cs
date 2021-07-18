using System;
using System.Collections.Generic;

#nullable disable

namespace strategy.Models
{
    public partial class ActionCostTemp
    {
        public long Id { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public decimal? ExpectedCost { get; set; }
        public decimal? ActualCost { get; set; }
        public int Mindex { get; set; }
        public long CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public long? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public long? DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public int? NumberOfDay { get; set; }
        public string FibuSupplier { get; set; }
        public string FibuDescription { get; set; }
        public long? FibuSupplierId { get; set; }
        public Guid ActionId { get; set; }
        public Guid TemplateId { get; set; }
        public string Description { get; set; }
        public bool? Finish { get; set; }
        public long? CategoryId { get; set; }
    }
}
