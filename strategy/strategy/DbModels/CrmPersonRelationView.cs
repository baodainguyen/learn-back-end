using System;
using System.Collections.Generic;

#nullable disable

namespace strategy.DbModels
{
    public partial class CrmPersonRelationView
    {
        public long Id { get; set; }
        public long CrmPersonId { get; set; }
        public string Note { get; set; }
    }
}
