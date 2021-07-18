using System;
using System.Collections.Generic;

#nullable disable

namespace strategy.Models
{
    public partial class ActionTodoDiscussion
    {
        public long Id { get; set; }
        public long ActionTodoId { get; set; }
        public Guid ActionId { get; set; }
        public long AccountId { get; set; }
        public string Discussion { get; set; }
        public int Mindex { get; set; }
        public long ProjectId { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public long? DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public long? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
