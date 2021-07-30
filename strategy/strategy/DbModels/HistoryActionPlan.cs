using System;
using System.Collections.Generic;

#nullable disable

namespace strategy.DbModels
{
    public partial class HistoryActionPlan
    {
        public Guid Id { get; set; }
        public long AccountId { get; set; }
        public DateTime ModifedDate { get; set; }
        public string OldValue { get; set; }
        public string NewValue { get; set; }
        public string ObjectId { get; set; }
        public string TableName { get; set; }
        public string ColumnName { get; set; }
        public int? Action { get; set; }
        public long RecoverBy { get; set; }
    }
}
