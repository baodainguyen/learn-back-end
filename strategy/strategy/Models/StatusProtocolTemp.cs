using System;
using System.Collections.Generic;

#nullable disable

namespace strategy.Models
{
    public partial class StatusProtocolTemp
    {
        public Guid Id { get; set; }
        public Guid? ActionId { get; set; }
        public DateTime? Date { get; set; }
        public int? StatusId { get; set; }
        public string Description { get; set; }
        public long CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public long? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public long? DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }
        public Guid? GoalId { get; set; }
        public int? Mdf { get; set; }
        public Guid TemplateId { get; set; }
    }
}
