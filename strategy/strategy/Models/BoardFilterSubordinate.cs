using System;
using System.Collections.Generic;

#nullable disable

namespace strategy.Models
{
    public partial class BoardFilterSubordinate
    {
        public long Id { get; set; }
        public long BoardFilterId { get; set; }
        public long BoardColumnId { get; set; }
        public int? Mindex { get; set; }
        public long CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public long? DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
    }
}
