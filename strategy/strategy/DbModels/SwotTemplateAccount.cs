using System;
using System.Collections.Generic;

#nullable disable

namespace strategy.DbModels
{
    public partial class SwotTemplateAccount
    {
        public long Id { get; set; }
        public long SwotTemplateId { get; set; }
        public long AccountId { get; set; }
        public long? ProjectId { get; set; }
    }
}
