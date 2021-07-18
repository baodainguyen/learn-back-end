using System;
using System.Collections.Generic;

#nullable disable

namespace strategy.Models
{
    public partial class ProductGroup
    {
        public ProductGroup()
        {
            Products = new HashSet<Product>();
        }

        public long Id { get; set; }
        public long ProjectId { get; set; }
        public long RegionId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Mindex { get; set; }
        public int Type { get; set; }
        public int Mdf { get; set; }
        public long CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public long? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public long? DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public Guid? GroupId { get; set; }
        public bool? IsRelation { get; set; }

        public virtual Project Project { get; set; }
        public virtual Region Region { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
