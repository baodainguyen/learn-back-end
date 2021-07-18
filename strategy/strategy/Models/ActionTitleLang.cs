using System;
using System.Collections.Generic;

#nullable disable

namespace strategy.Models
{
    public partial class ActionTitleLang
    {
        public long Id { get; set; }
        public string TitleName { get; set; }
        public int TypeId { get; set; }
        public string Language { get; set; }
        public Guid? SubmarketProductId { get; set; }
        public long? IndependenceId { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public long? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public long? DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public Guid? GoalId { get; set; }
        public long? ProjectId { get; set; }
    }
}
