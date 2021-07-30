using System;
using System.Collections.Generic;

#nullable disable

namespace strategy.DbModels
{
    public partial class TodoAccount
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public long CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public long? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public long? DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public long? ProjectId { get; set; }
    }
}
