using System;
using System.Collections.Generic;

#nullable disable

namespace strategy.Models
{
    public partial class BoardNamePerson
    {
        public long Id { get; set; }
        public long BoardNameId { get; set; }
        public long AccountId { get; set; }
        public int Mindex { get; set; }
        public int TypeId { get; set; }
        public long CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public long? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public long? DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }

        public virtual BoardName BoardName { get; set; }
    }
}
