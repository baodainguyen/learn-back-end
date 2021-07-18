using System;
using System.Collections.Generic;

#nullable disable

namespace strategy.Models
{
    public partial class ProductPosition
    {
        public ProductPosition()
        {
            ProductPositionCharts = new HashSet<ProductPositionChart>();
        }

        public Guid Id { get; set; }
        public Guid SubMarketProductId { get; set; }
        public string Name { get; set; }
        public string Xname { get; set; }
        public string Yname { get; set; }
        public int Xunit { get; set; }
        public int Yunit { get; set; }
        public string Comment { get; set; }
        public int Mdf { get; set; }
        public int Mindex { get; set; }
        public long CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public long? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public long? DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public Guid? ProductPositionTemplateId { get; set; }

        public virtual SubMarketProduct SubMarketProduct { get; set; }
        public virtual ICollection<ProductPositionChart> ProductPositionCharts { get; set; }
    }
}
