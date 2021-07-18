using System;
using System.Collections.Generic;

#nullable disable

namespace strategy.Models
{
    public partial class ProductPositionChart
    {
        public Guid Id { get; set; }
        public Guid ProductPositionId { get; set; }
        public int Xvalue { get; set; }
        public int Yvalue { get; set; }
        public Guid ProductCompetitionId { get; set; }
        public int Mdf { get; set; }
        public int Mindex { get; set; }
        public long CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public long? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public long? DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }

        public virtual ProductPosition ProductPosition { get; set; }
    }
}
