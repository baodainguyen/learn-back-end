using System;
using System.Collections.Generic;

#nullable disable

namespace strategy.DbModels
{
    public partial class ActionTodoNotify
    {
        public long Id { get; set; }
        public long ActionTodoId { get; set; }
        public long AccountId { get; set; }
        public long ActionTodoDiscussionId { get; set; }
        public bool? IsRead { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public long? DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public long? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
