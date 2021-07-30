using System;
using System.Collections.Generic;

#nullable disable

namespace strategy.DbModels
{
    public partial class ActionCustomView
    {
        public long Id { get; set; }
        public int? TypeId { get; set; }
        public long? CategoriesId { get; set; }
        public string Label { get; set; }
        public string DefaultValue { get; set; }
        public long CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public long? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public long? DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public bool IsCheck { get; set; }
    }
}
