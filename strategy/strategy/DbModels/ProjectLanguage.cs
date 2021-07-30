using System;
using System.Collections.Generic;

#nullable disable

namespace strategy.DbModels
{
    public partial class ProjectLanguage
    {
        public long Id { get; set; }
        public long ProjectId { get; set; }
        public string ClientKeyName { get; set; }
        public string LangId { get; set; }
        public string Value { get; set; }
        public long CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public long? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public long? DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }

        public virtual Project Project { get; set; }
    }
}
