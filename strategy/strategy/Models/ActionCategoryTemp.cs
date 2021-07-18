using System;
using System.Collections.Generic;

#nullable disable

namespace strategy.Models
{
    public partial class ActionCategoryTemp
    {
        public Guid Id { get; set; }
        public Guid ActionId { get; set; }
        public long CategoryId { get; set; }
        public int TypeId { get; set; }
        public long CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public long? DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public Guid TemplateId { get; set; }
    }
}
