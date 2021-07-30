using System;
using System.Collections.Generic;

#nullable disable

namespace strategy.DbModels
{
    public partial class CrmTagView
    {
        public long Id { get; set; }
        public long? CategoryId { get; set; }
        public long? CrmId { get; set; }
        public int? TypeId { get; set; }
        public int? Mindex { get; set; }
        public string TagName { get; set; }
        public long? ProjectId { get; set; }
        public int? Mdf { get; set; }
        public int? Type { get; set; }
        public int? ParentType { get; set; }
        public string Extension { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
