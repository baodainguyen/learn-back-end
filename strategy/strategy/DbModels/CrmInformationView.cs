using System;
using System.Collections.Generic;

#nullable disable

namespace strategy.DbModels
{
    public partial class CrmInformationView
    {
        public long Id { get; set; }
        public long? CategoryId { get; set; }
        public long? CrmId { get; set; }
        public string Value { get; set; }
        public string Name { get; set; }
        public int Type { get; set; }
        public int? TypeId { get; set; }
        public long? ProjectId { get; set; }
        public int? ParentType { get; set; }
    }
}
